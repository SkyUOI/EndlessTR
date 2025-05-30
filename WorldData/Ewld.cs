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

        public static void HackEraseWorld()
        {
            try
            {
                var EraseWorld = typeof(Main).GetMethod("EraseWorld",
                    BindingFlags.Static | BindingFlags.NonPublic);
                if (EraseWorld == null)
                {
                    Debug.Error("HackEraseWorld EraseWorld == null");
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
                Debug.Error("HackEraseWorld Error");
            }


        }

        public static void EraseWlds(int i)
        {
            try
            {
                Platform.Get<IPathService>().MoveToRecycleBin(Path.GetDirectoryName(
                    Main.WorldList[i].Path[..^5] + "/"));
            }
            catch
            {
                Debug.Error("EraseWlds Error");
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
            // cursor.EmitDelegate(() => Debug.Error("WriteArchive"));
            cursor.EmitLdarg0();
            cursor.EmitLdarg1();
            cursor.EmitLdarg2();
            cursor.EmitDelegate(BackupWlds);
        }

        public static void BackupWlds(Ionic.Zip.ZipFile zip, bool isCloudSave, string path)
        {
            // throw new Exception("backupWlds");
            Assembly terraria = Assembly.Load("tModLoader");
            var BackupIO = terraria.GetType("Terraria.ModLoader.BackupIO");
            if (BackupIO == null)
            {
                Debug.Error("BackupWlds: BackupIO == null");
            }

            var AddZipEntry = BackupIO.GetMethod("AddZipEntry", BindingFlags.Static | BindingFlags.NonPublic);
            if (AddZipEntry == null)
            {
                Debug.Error("BackupWlds: AddZipEntry == null");
            }
            for (int i = 0; i < WorldData.blockNum; ++i)
            {
                if (FileUtilities.Exists(path, isCloudSave))
                    AddZipEntry.Invoke(null, [zip, GetWldPath(i), isCloudSave]);
            }

        }

        public static void HackLoadWorld()
        {
            var flag = BindingFlags.Public | BindingFlags.Static;
            var WF = typeof(WorldFile);
            var version2 = WF.GetMethod("LoadWorld_Version2", flag);
            MonoModHooks.Modify(version2, ILLoadWorld_Version2);
            var LoadWorld = WF.GetMethod("LoadWorld", flag);
            MonoModHooks.Modify(LoadWorld, ILLoadWorld);

            var LoadHeader = WF.GetMethod("LoadHeader", flag);
            MonoModHooks.Modify(LoadHeader, il =>
            {
                var cursor = new ILCursor(il);
                ILLabel iLLabel = cursor.DefineLabel();
                cursor.GotoNext(MoveType.Before, i => i.MatchLdarg0() && i.Next.MatchCallvirt(out var t)
                    && i.Next.Next.MatchStsfld(out var b) && b.Name == "dungeonX");
                cursor.EmitBr(iLLabel);
                cursor.Index += 6;
                cursor.MarkLabel(iLLabel);
            });


            Debug.Hack(WF, "LoadFileFormatHeader", flag, cursor =>
            {
                // 把有关importance的部分去掉, 放到另一个函数里用于wld文件load
                // 同时注意save也要修改

                // 	// ushort num2 = reader.ReadUInt16();
                // IL_0078: ldarg.0
                // IL_0079: callvirt instance uint16[System.Runtime]System.IO.BinaryReader::ReadUInt16()
                // IL_007e: stloc.1
                // 匹配到这里
                try
                {
                    cursor.GotoNext(MoveType.Before, i => i.MatchLdarg0()
                    && i.Next.MatchCallvirt(out var t) && t.Name == "ReadUInt16"
                    && i.Next.Next.MatchStloc1());
                }
                catch
                {
                    Debug.Error("gotoNext LoadFileFormatHeader ReadUInt16 Error");
                }

                cursor.EmitLdcI4(1);
                cursor.EmitRet();
            });
        }

        public static void ILSaveFileFormatHeader(ILContext il)
        {
            var cursor = new ILCursor(il);
            cursor.GotoNext(MoveType.Before, i => i.MatchLdcI4(out var t) && t == 11);
            cursor.Remove();
            cursor.EmitLdcI4(4);

            try
            {
                cursor.GotoNext(MoveType.Before, i => i.MatchLdarg0()
                && i.Next.MatchLdloc0() && i.Next.Next.MatchCallvirt(out var t) && t.Name == "Write");
            }
            catch
            {
                Debug.Error("gotoNext SaveFileFormatHeader Write Error");
            }

            // 将有关importance的部分去除, 直接跳转到结尾
            ILLabel importanceEnd = cursor.DefineLabel();
            cursor.EmitBr(importanceEnd);

            try
            {
                cursor.GotoNext(MoveType.Before, i => i.MatchLdarg0()
                && i.Next.MatchCallvirt(out var t) && t.Name == "get_BaseStream");
            }
            catch
            {
                Debug.Error("gotoNext SaveFileFormatHeader get_BaseStream Error");
            }

            cursor.MarkLabel(importanceEnd);
        }

        public static void ILSaveWorldHeader(ILContext il)
        {
            /* TODO: 
                处理类似地牢坐标的可能原本在header中但无限世界后需要多个的数据
            */
            var cursor = new ILCursor(il);
            cursor.GotoNext(MoveType.Before, i => i.Next != null
                && i.Next.MatchLdsfld(out var t) && t.DeclaringType.FullName == "Terraria.Main"
                && t.Name == "dungeonX");
            ILLabel ilLabel = cursor.DefineLabel();
            cursor.EmitBr(ilLabel);
            cursor.GotoNext(MoveType.Before, i => i != null
                && i.MatchLdsfld(out var t) && t.DeclaringType.FullName == "Terraria.Main"
                && t.Name == "dungeonY");
            cursor.Index += 2;
            cursor.MarkLabel(ilLabel);
        }

        public static void ILLoadWorld_Version2(ILContext il)
        {
            var cursor = new ILCursor(il);


            var LoadWorldTiles = typeof(WorldFile).GetMethod("LoadWorldTiles",
                BindingFlags.Public | BindingFlags.Static
            );
            cursor.GotoNext(MoveType.Before, i => i.Next.Next.MatchCall(LoadWorldTiles));
            cursor.Index -= 3;

            cursor.Remove();
            ILLabel br = cursor.DefineLabel();
            cursor.EmitBeq(br);
            // cursor.GotoNext(MoveType.Before, i => i.Next.Next.MatchCall(LoadWorldTiles));
            // ILLabel iLLabel = cursor.DefineLabel();
            // cursor.MarkLabel(br);
            // cursor.EmitBr(iLLabel);


            cursor.GotoNext(MoveType.Before, i => i.MatchLdsfld(out var t)
                && t.Name == "_versionNumber" && t.DeclaringType.FullName == "Terraria.IO.WorldFile"
                && i.Next.MatchLdcI4(220));
            cursor.MarkLabel(br);

            // 3355


            cursor.GotoNext(MoveType.Before, i => i.MatchLdcI4(10));
            cursor.Remove();
            cursor.EmitLdcI4(2);


            var LastMinuteFixes = typeof(WorldFile).GetMethod("LoadWorld_LastMinuteFixes",
                BindingFlags.Static | BindingFlags.NonPublic);
            cursor.GotoNext(MoveType.Before, i => i.MatchCall(LastMinuteFixes));

            ILLabel lLoadEndlessTR = cursor.DefineLabel();
            cursor.Index -= 3;
            cursor.Remove();
            cursor.EmitBeq(lLoadEndlessTR);

            // cursor.EmitLdarg0();
            // cursor.EmitDelegate<Action<BinaryReader>>(r => Debug.Error("rd " + r.BaseStream.Position.ToString()));

            cursor.GotoNext(MoveType.Before, i => i.MatchCall(LastMinuteFixes));
            cursor.MarkLabel(lLoadEndlessTR);
            cursor.EmitLdarg0();
            cursor.EmitDelegate<Action<BinaryReader>>(i => LoadEndlessTR(i));

            // {
            // 	Action<string> Error = s => { throw new Exception(s); };
            // 	// 检查返回值
            // 	var LoadFooter = typeof(WorldFile).GetMethod("LoadFooter",
            // 		BindingFlags.Static | BindingFlags.Public
            // 	);
            // 	cursor.GotoNext(MoveType.Before, i => i.MatchCall(LoadFooter));
            // 	cursor.Index += 1;
            // 	cursor.EmitDelegate<Func<int, int>>(i =>
            // 	{
            // 		Error("i:::" + i.ToString());
            // 		return i;
            // 	});
            // }
        }


        public static void SetVersionNumber(int i)
        {
            WorldData.versionNumber = i;
        }

        public static void ILLoadWorld(ILContext il)
        {
            var cursor = new ILCursor(il);

            cursor.GotoNext(MoveType.Before, i => i.MatchLdsfld(out var t) && i.Next.MatchLdcI4(0) && i.Next.Next.MatchBle(out var a));
            cursor.EmitLdloc(5);
            cursor.EmitDelegate(SetVersionNumber);


            var OnWorldLoad = typeof(SystemLoader).GetMethod(
                "OnWorldLoad",
                BindingFlags.Static | BindingFlags.Public
            );

            cursor.GotoNext(MoveType.Before, i => i.MatchCall(OnWorldLoad));
            cursor.EmitLdarg0();
            cursor.EmitDelegate(LoadWorldWlds);
        }

        public static void LoadWorldWlds(bool loadFromCloud)
        {
            bool flag = loadFromCloud && Terraria.Social.SocialAPI.Cloud != null;
            try
            {
                for (int i = 0; i < WorldData.blockNum; ++i)
                {
                    /* TODO: 
                        处理地牢坐标, 以及其他可能原本在header中但无限世界后需要多个的数据
                    */
                    using MemoryStream memoryStream = new MemoryStream(FileUtilities.ReadAllBytes(GetWldPath(i), flag));
                    using BinaryReader binaryReader = new BinaryReader(memoryStream);
                    bool[] importance;
                    if (!LoadImportance(binaryReader, out importance))
                    {
                        Debug.Error("LoadImportance Error");
                    }
                    try
                    {
                        WorldFile.LoadWorldTiles(binaryReader, importance);
                    }
                    catch
                    {
                        Debug.Error("LoadWorldTiles Error");
                    }

                    WorldFile.LoadChests(binaryReader);
                    WorldFile.LoadSigns(binaryReader);
                    WorldFile.LoadNPCs(binaryReader);
                    WorldFile.LoadTileEntities(binaryReader);
                    WorldFile.LoadWeightedPressurePlates(binaryReader);
                    WorldFile.LoadTownManager(binaryReader);
                    WorldFile.LoadBestiary(binaryReader, WorldData.versionNumber);
                }
            }
            catch
            {
                throw new Exception("LoadWorldWlds error");
            }
        }

        public static bool LoadImportance(BinaryReader reader, out bool[] importance)
        {
            ushort num2 = reader.ReadUInt16();
            importance = new bool[num2];
            byte b = 0;
            byte b2 = 128;
            for (int i = 0; i < num2; i++)
            {
                if (b2 == 128)
                {
                    b = reader.ReadByte();
                    b2 = 1;
                }
                else
                {
                    b2 = (byte)(b2 << 1);
                }

                if ((b & b2) == b2)
                    importance[i] = true;
            }

            return true;
        }

        public static void HackSaveWorld()
        {
            var flag = BindingFlags.NonPublic | BindingFlags.Static;
            var InternalSaveWorld = typeof(WorldFile).GetMethod("InternalSaveWorld", flag);
            MonoModHooks.Modify(InternalSaveWorld, ILInternalSaveWorld);

            var flag_ = BindingFlags.Public | BindingFlags.Static;

            var SaveWorldHeader = typeof(WorldFile).GetMethod("SaveWorldHeader", flag_);
            MonoModHooks.Modify(SaveWorldHeader, ILSaveWorldHeader);


            var SaveFileFormatHeader = typeof(WorldFile).GetMethod("SaveFileFormatHeader", flag_);
            MonoModHooks.Modify(SaveFileFormatHeader, ILSaveFileFormatHeader);
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
            cursor.EmitDelegate(SaveWorldEWld);
            // 在文件夹内保存.wld文件
            cursor.GotoNext(MoveType.Before, i => i.MatchLdloc1() && i.Next.MatchLdloc0() &&
                     i.Next.Next.MatchLdarg0());
            cursor.EmitLdarg0();
            cursor.EmitDelegate(SaveWorldWlds);

            // 备份世界文件前需要验证文件, 先把他去掉
            // TODO: 修改验证文件的函数valiateWorld

            var ValidateWorld = typeof(WorldFile).GetMethod("ValidateWorld", BindingFlags.Static | BindingFlags.Public);
            if (ValidateWorld == null)
            {
                Debug.Error("ILInternalSaveWorld: ValidateWorld == null");
            }
            cursor.GotoNext(MoveType.Before, i => i.MatchLdloc(8) && i.Next.MatchCall(ValidateWorld));
            cursor.RemoveRange(2);
            cursor.EmitLdcI4(1);

        }

        public static void SaveWorldWld(BinaryWriter writer)
        {
            /* TODO: 
                处理地牢坐标, 以及其他可能原本在header中但无限世界后需要多个的数据
            */
            SaveImportance(writer); // 原本在fileformatheader里的内容, 与tile有关
            WorldFile.SaveWorldTiles(writer);
            WorldFile.SaveChests(writer);
            WorldFile.SaveSigns(writer);
            WorldFile.SaveNPCs(writer);
            WorldFile.SaveTileEntities(writer);
            WorldFile.SaveWeightedPressurePlates(writer);
            WorldFile.SaveTownManager(writer);
            WorldFile.SaveBestiary(writer);
        }

        public static int SaveImportance(BinaryWriter writer)
        {
            ushort count = Terraria.ID.TileID.Count;
            writer.Write(count);
            byte b = 0;
            byte b2 = 1;
            for (int i = 0; i < count; i++)
            {
                if (Main.tileFrameImportant[i])
                    b = (byte)(b | b2);

                if (b2 == 128)
                {
                    writer.Write(b);
                    b = 0;
                    b2 = 1;
                }
                else
                {
                    b2 = (byte)(b2 << 1);
                }
            }

            if (b2 != 1)
                writer.Write(b);

            return (int)writer.BaseStream.Position;
        }

        public static string GetWldPath(int i)
        {
            return Main.worldPathName[..^5] + "/" + Main.worldName + i.ToString() + ".wld";
        }

        public static string GetWldBakPath(int i)
        {
            return Path.ChangeExtension(GetWldPath(i), "bak");
        }

        public static void SaveWorldWlds(bool useCloudSaving)
        {
            int num;
            byte[] array;
            for (int i = 0; i < WorldData.blockNum; ++i)
            {
                using (MemoryStream memoryStream = new MemoryStream(7000000))
                {
                    using (BinaryWriter writer = new BinaryWriter(memoryStream))
                    {
                        SaveWorldWld(writer);
                    }
                    array = memoryStream.ToArray();
                    num = array.Length;
                }
                FileUtilities.Write(GetWldPath(i), array, num, useCloudSaving);
                FileUtilities.Write(GetWldBakPath(i), array, num, useCloudSaving);
            }
        }

        public static int SaveEndlessTR(BinaryWriter writer) // 保存有关此模组的内容
        {
            writer.Write(WorldData.blockNum);
            writer.Write(WorldData.nowBlock);
            return (int)writer.BaseStream.Position;
        }

        public static void LoadEndlessTR(BinaryReader reader)
        {
            WorldData.blockNum = reader.ReadInt32();
            WorldData.nowBlock = reader.ReadInt32();
        }

        public static void SaveWorldEWld(BinaryWriter writer)
        {
            int[] pointers = [
                WorldFile.SaveFileFormatHeader(writer),
                WorldFile.SaveWorldHeader(writer),
                WorldFile.SaveCreativePowers(writer),
                SaveEndlessTR(writer),
            ];

            WorldFile.SaveFooter(writer);
            WorldFile.SaveHeaderPointers(writer, pointers);
        }
    }
}