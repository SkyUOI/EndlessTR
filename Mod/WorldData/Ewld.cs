using EndlessTR.WorldGeneration;
using MonoMod.Cil;
using ReLogic.OS;
using Steamworks;
using System;
using System.IO;
using System.Reflection;
using Terraria;
using Terraria.IO;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace EndlessTR.WorldData
{
    public class Ewld
    {
        public static void Hack()
        {
            HackSaveWorld();
            HackLoadWorld();

            HackWriteArchive();

            HackEraseWorld();
        }

        public static int SaveEndlessTR(BinaryWriter writer) // 保存有关此模组的内容
        {
            writer.Write(WorldData.blockLeft);
            writer.Write(WorldData.blockRight);
            writer.Write(WorldData.nowBlock);
            writer.Write(WorldGeneration.WorldGeneration.BorderX[0]);
            writer.Write(WorldGeneration.WorldGeneration.BorderX[1]);
            writer.Write(WorldGeneration.WorldGeneration.PreviousBorderX[0]);
            writer.Write(WorldGeneration.WorldGeneration.PreviousBorderX[1]);
            return (int)writer.BaseStream.Position;
        }

        public static void LoadEndlessTR(BinaryReader reader)
        {
            WorldData.blockLeft = reader.ReadInt32();
            WorldData.blockRight = reader.ReadInt32();
            WorldData.nowBlock = reader.ReadInt32();
            WorldGeneration.WorldGeneration.BorderX[0] = reader.ReadInt32();
            WorldGeneration.WorldGeneration.BorderX[1] = reader.ReadInt32();
            WorldGeneration.WorldGeneration.PreviousBorderX[0] = reader.ReadInt32();
            WorldGeneration.WorldGeneration.PreviousBorderX[1] = reader.ReadInt32();
        }

        public static void SaveWorldEWld(BinaryWriter writer)
        {
            SaveEndlessTR(writer);
        }


        public static void HackEraseWorld()
        {
            try
            {
                var EraseWorld = typeof(Main).GetMethod("EraseWorld",
                    BindingFlags.Static | BindingFlags.NonPublic);
                if (EraseWorld == null)
                {
                    throw new Exception("HackEraseWorld EraseWorld == null");
                }
                MonoModHooks.Modify(EraseWorld, il =>
                {
                    var cursor = new ILCursor(il);
                    cursor.GotoNext(MoveType.Before, i => i.MatchBrtrue(out var _)
                    && i.Next.MatchCall(out var func)
                    && func.Name == "Get");
                    cursor.Index += 1;
                    cursor.EmitLdarg0();
                    cursor.EmitDelegate(EraseWlds);
                });
            }
            catch
            {
                throw new Exception("HackEraseWorld Error");
            }


        }

        public static void EraseWlds(int i)
        {
            try
            {
                Platform.Get<IPathService>().MoveToRecycleBin(Path.GetDirectoryName(
                    Main.WorldList[i].Path[..^5] + "\\"));
            }
            catch
            {
                throw new Exception("EraseWlds Error");
            }

        }

        public static void HackWriteArchive()
        {
            var World = typeof(Mod).Assembly.GetType("Terraria.ModLoader.BackupIO+World");
            if (World == null) throw new Exception("HackWriteArchive World == null!");
            var WriteArchive = World.GetMethod("WriteArchive", BindingFlags.Static | BindingFlags.NonPublic);
            MonoModHooks.Modify(WriteArchive, ILWriteArchive);

        }

        public static void ILWriteArchive(ILContext il)
        {
            var cursor = new ILCursor(il);
            // cursor.EmitDelegate(() => throw new Exception("WriteArchive"));
            cursor.EmitLdarg0();
            cursor.EmitLdarg2();
            cursor.EmitDelegate(BackupWlds);
        }

        public static void BackupWlds(Ionic.Zip.ZipFile zip, string path)
        {
            // throw new Exception("backupWlds");
            Assembly terraria = Assembly.Load("tModLoader");
            var BackupIO = terraria.GetType("Terraria.ModLoader.BackupIO");
            if (BackupIO == null)
            {
                throw new Exception("BackupWlds: BackupIO == null");
            }

            var AddZipEntry = BackupIO.GetMethod("AddZipEntry", BindingFlags.Static | BindingFlags.NonPublic);
            if (AddZipEntry == null)
            {
                throw new Exception("BackupWlds: AddZipEntry == null");
            }
            for (int i = WorldData.blockLeft; i <= WorldData.blockRight; ++i)
            {
                if (FileUtilities.Exists(path, false))
                    AddZipEntry.Invoke(null, [zip, Utils.GetPath.GetWldPath(i), false]);
            }

        }

        public static void HackLoadWorld()
        {
            var flag = BindingFlags.Public | BindingFlags.Static;
            var WF = typeof(WorldFile);
            var LoadWorld = WF.GetMethod("LoadWorld", flag);
            MonoModHooks.Modify(LoadWorld, ILLoadWorld);
        }

        public static void ILLoadWorld(ILContext il)
        {
            var cursor = new ILCursor(il);

            var flag = BindingFlags.Static | BindingFlags.Public;

            var LoadWorld_Version2 = typeof(WorldFile).GetMethod(nameof(WorldFile.LoadWorld_Version2), flag);
            if (LoadWorld_Version2 == null)
            {
                throw new Exception("LoadWorld_Version2 == null");
            }

            var _LoadWorldEWld = typeof(Ewld).GetMethod(nameof(LoadWorldEWld), flag);

            cursor.GotoNext(MoveType.Before, i => i.MatchCall(LoadWorld_Version2));
            cursor.EmitCall(_LoadWorldEWld);

            var OnWorldLoad = typeof(SystemLoader).GetMethod(
                "OnWorldLoad",
                BindingFlags.Static | BindingFlags.Public
            );

            cursor.GotoNext(MoveType.Before, i => i.MatchCall(OnWorldLoad));
            cursor.EmitDelegate(() =>
            {
                ExtendingMap.loaded = [false, false, false];
                LoadWorldWld(WorldData.nowBlock, 0);
            });
        }

        public static void LoadWorldWld(int blockId, int extendingMapId)
        {
            try
            {
                BindingFlags flag = BindingFlags.NonPublic | BindingFlags.Static;
                int _versionNumber = (int)typeof(WorldFile).GetField("_versionNumber", flag).GetValue(null);
                MethodInfo LoadBestiaryForVersionsBefore210 =
                    typeof(WorldFile).GetMethod("LoadBestiaryForVersionsBefore210", flag);
                if (LoadBestiaryForVersionsBefore210 == null)
                {
                    throw new Exception("LoadBestiaryForVersionsBefore210 == null");
                }

                MethodInfo LoadWorld_LastMinuteFixes =
                    typeof(WorldFile).GetMethod("LoadWorld_LastMinuteFixes", flag);
                if (LoadWorld_LastMinuteFixes == null)
                {
                    throw new Exception("LoadWorld_LastMinuteFixes== null");
                }

                using MemoryStream memoryStream = new MemoryStream(FileUtilities.ReadAllBytes(Utils.GetPath.GetWldPath(blockId), false));
                using BinaryReader reader = new BinaryReader(memoryStream);
                if (ExtendingMap.GetLoaded(extendingMapId)) return;
                WorldData.nowSaveAndLoad = extendingMapId;
                reader.BaseStream.Position = 0L;
                if (!WorldFile.LoadFileFormatHeader(reader, out var importance, out var positions))
                    throw new Exception($"load block {blockId} Error");


                if (reader.BaseStream.Position != positions[0])
                    throw new Exception($"load block {blockId} Error");

                WorldFile.LoadHeader(reader);
                if (reader.BaseStream.Position != positions[1])
                    throw new Exception($"load block {blockId} Error");

                WorldFile.LoadWorldTiles(reader, importance);
                if (reader.BaseStream.Position != positions[2])
                    throw new Exception($"load block {blockId} Error");

                WorldFile.LoadChests(reader);
                if (reader.BaseStream.Position != positions[3])
                    throw new Exception($"load block {blockId} Error");

                WorldFile.LoadSigns(reader);
                if (reader.BaseStream.Position != positions[4])
                    throw new Exception($"load block {blockId} Error");

                WorldFile.LoadNPCs(reader);
                if (reader.BaseStream.Position != positions[5])
                    throw new Exception($"load block {blockId} Error");

                if (_versionNumber >= 116)
                {
                    if (_versionNumber < 122)
                    {
                        WorldFile.LoadDummies(reader);
                        if (reader.BaseStream.Position != positions[6])
                            throw new Exception($"load block {blockId} Error");
                    }
                    else
                    {
                        WorldFile.LoadTileEntities(reader);
                        if (reader.BaseStream.Position != positions[6])
                            throw new Exception($"load block {blockId} Error");
                    }
                }

                if (_versionNumber >= 170)
                {
                    WorldFile.LoadWeightedPressurePlates(reader);
                    if (reader.BaseStream.Position != positions[7])
                        throw new Exception($"load block {blockId} Error");
                }

                if (_versionNumber >= 189)
                {
                    WorldFile.LoadTownManager(reader);
                    if (reader.BaseStream.Position != positions[8])
                        throw new Exception($"load block {blockId} Error");
                }

                if (_versionNumber >= 210)
                {
                    WorldFile.LoadBestiary(reader, _versionNumber);
                    if (reader.BaseStream.Position != positions[9])
                        throw new Exception($"load block {blockId} Error");
                }
                else
                {
                    LoadBestiaryForVersionsBefore210.Invoke(null, []);
                }

                if (_versionNumber >= 220)
                {
                    WorldFile.LoadCreativePowers(reader, _versionNumber);
                    if (reader.BaseStream.Position != positions[10])
                        throw new Exception($"load block {blockId} Error");
                }

                LoadWorld_LastMinuteFixes.Invoke(null, []);
                if (WorldFile.LoadFooter(reader) != 0)
                    throw new Exception($"load block {blockId} Error");
                ExtendingMap.SetLoaded(extendingMapId, true);

            }
            catch
            {
                throw new Exception("LoadWorldWlds error");
            }

        }

        public static void HackSaveWorld()
        {
            var flag = BindingFlags.NonPublic | BindingFlags.Static;
            var InternalSaveWorld = typeof(WorldFile).GetMethod("InternalSaveWorld", flag);
            if (InternalSaveWorld == null)
            {
                throw new Exception("InternalSaveWorld == null");
            }
            try
            {
                MonoModHooks.Modify(InternalSaveWorld, ILInternalSaveWorld);
            }
            catch
            {
                throw new Exception("HackInternalSaveWorld");
            }

        }
        public static int LoadWorldEWld(BinaryReader reader)
        {
            LoadEndlessTR(reader);
            return 0;
        }

        public static void ILInternalSaveWorld(ILContext il)
        {
            var cursor = new ILCursor(il);
            // 用SaveWorldEWld替换SaveWorld_Version2
            MethodInfo version2 = typeof(Terraria.IO.WorldFile).GetMethod(
                "SaveWorld_Version2",
                BindingFlags.Static | BindingFlags.Public
            );
            cursor.GotoNext(MoveType.Before, i => i.MatchCall(version2));
            cursor.Remove();
            cursor.EmitDelegate(Ewld.SaveWorldEWld);
            // 在文件夹内保存.wld文件
            cursor.GotoNext(MoveType.Before, i => i.MatchLdloc1() && i.Next.MatchLdloc0() &&
                     i.Next.Next.MatchLdarg0());
            cursor.EmitDelegate(() =>
            {
                SaveWorldWld(WorldData.nowBlock, 0);
            });

            // 备份世界文件前需要验证文件, 先把他去掉
            // TODO: 修改验证文件的函数valiateWorld

            var ValidateWorld = typeof(WorldFile).GetMethod("ValidateWorld", BindingFlags.Static | BindingFlags.Public);
            if (ValidateWorld == null)
            {
                throw new Exception("ILInternalSaveWorld: ValidateWorld == null");
            }
            cursor.GotoNext(MoveType.Before, i => i.MatchLdloc(8) && i.Next.MatchCall(ValidateWorld));
            cursor.RemoveRange(2);
            cursor.EmitLdcI4(1);

        }

        public static void SaveWorldWld(int blockId, int extendingMapId)
        {
            WorldData.nowSaveAndLoad = extendingMapId;
            int num;
            byte[] array;

            using (MemoryStream memoryStream = new MemoryStream(7000000))
            {
                using (BinaryWriter writer = new BinaryWriter(memoryStream))
                {
                    int[] pointers = [
                        WorldFile.SaveFileFormatHeader(writer),
                        WorldFile.SaveWorldHeader(writer),
                        WorldFile.SaveWorldTiles(writer),
                        WorldFile.SaveChests(writer),
                        WorldFile.SaveSigns(writer),
                        WorldFile.SaveNPCs(writer),
                        WorldFile.SaveTileEntities(writer),
                        WorldFile.SaveWeightedPressurePlates(writer),
                        WorldFile.SaveTownManager(writer),
                        WorldFile.SaveBestiary(writer),
                        WorldFile.SaveCreativePowers(writer)
                    ];

                    WorldFile.SaveFooter(writer);
                    WorldFile.SaveHeaderPointers(writer, pointers);
                }
                array = memoryStream.ToArray();
                num = array.Length;
            }
            FileUtilities.Write(Utils.GetPath.GetWldPath(blockId), array, num, false);
            FileUtilities.Write(Utils.GetPath.GetWldBakPath(blockId), array, num, false);

        }

    }

}