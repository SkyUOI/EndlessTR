// 用于生成世界的独立出来的一份数据
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Terraria;
using Terraria.Utilities;
using Vector2 = Microsoft.Xna.Framework.Vector2;
using Terraria.ID;
using System;
using Terraria.Graphics.Renderers;
using Terraria.Map;
using Terraria.GameContent;

namespace EndlessTR.WorldData.WorldGenState;

public class Main
{
    public static double ladyBugRainBoost;

    public static bool getGoodWorld;
    public static bool drunkWorld;
    public static bool tenthAnniversaryWorld;
    public static bool dontStarveWorld;
    public static bool notTheBeesWorld;
    public static bool remixWorld;
    public static bool noTrapsWorld;
    public static bool zenithWorld;
    public static bool afterPartyOfDoom;
    public static bool shimmerAlpha;
    public static bool shimmerDarken;
    public static bool shimmerBrightenDelay;

    public static int mapDelay;

    public static int waterStyle;
    public static int windCounter;
    public static int extremeWindCounter;

    public static Main instance;
    public static bool xMas;
    public static bool forceXMasForToday;

    public static bool halloween;
    public static bool forceHalloweenForToday;

    public static bool mapReady;

    private static string _statusText = "";
    public static string statusText
    {
        get => _statusText;
        set
        {
            // Logging.LogStatusChange(value);
            _statusText = value;
        }
    }

    public static WorldMap Map;
    public static ParticleRenderer ParticleSystem_World_OverPlayers = new ParticleRenderer();
    public static ParticleRenderer ParticleSystem_World_BehindPlayers = new ParticleRenderer();

    public static bool pumpkinMoon;

    public static bool clearMap;
    public static int mapTime = Terraria.Main.mapTimeMax;
    public static bool updateMap;
    public static bool refreshMap;
    public static bool eclipse;
    public static bool slimeRain;
    public static double slimeRainTime;
    public static int slimeWarningTime;
    public static int sundialCooldown;
    public static int moondialCooldown;
    public static bool fastForwardTimeToDawn;
    public static bool fastForwardTimeToDusk;
    public static void ResetWindCounter(bool resetExtreme = false)
    {
        FastRandom fastRandom = FastRandom.CreateWithRandomSeed();
        windCounter = fastRandom.Next(900, 2701);
        if (resetExtreme)
            extremeWindCounter = fastRandom.Next(10, 31);
    }

    public static void checkXMas()
    {
        DateTime now = DateTime.Now;
        int day = now.Day;
        int month = now.Month;
        if (day >= 15 && month == 12)
            xMas = true;
        else
            xMas = false;

        if (forceXMasForToday)
            xMas = true;
    }

    public static void checkHalloween()
    {
        DateTime now = DateTime.Now;
        int day = now.Day;
        int month = now.Month;
        if (day >= 10 && month == 10)
            halloween = true;
        else if (day <= 1 && month == 11)
            halloween = true;
        else
            halloween = false;

        if (forceHalloweenForToday)
            halloween = true;
    }


}
public class NPC
{
    public static bool freeCake;

    public static int mechQueen;
    public static bool EoCKilledToday;
    public static bool WoFKilledToday;

    public static int[] killCount = new int[NPCID.Count];

    public static int MoonLordCountdown = 0;

    public static CoinLossRevengeSystem RevengeManager = new CoinLossRevengeSystem();

    public static void ResetBadgerHatTime()
    {
        EoCKilledToday = false;
        WoFKilledToday = false;
    }

    public static void ResetKillCount()
    {
        for (int i = 0; i < killCount.Length; i++)
        {
            killCount[i] = 0;
        }
    }
}

public class PressurePlateHelper
{

    public static object EntityCreationLock = new object();
    public static Dictionary<Point, bool[]> PressurePlatesPressed = new Dictionary<Point, bool[]>();
    public static bool NeedsFirstUpdate;
    private static Vector2[] PlayerLastPosition = new Vector2[255];
    private static Rectangle pressurePlateBounds = new Rectangle(0, 0, 16, 10);

    public static void Update()
    {
        if (!NeedsFirstUpdate)
            return;

        foreach (Point key in PressurePlatesPressed.Keys)
        {
            PokeLocation(key);
        }

        PressurePlatesPressed.Clear();
        NeedsFirstUpdate = false;
    }

    public static void Reset()
    {
        PressurePlatesPressed.Clear();
        for (int i = 0; i < PlayerLastPosition.Length; i++)
        {
            PlayerLastPosition[i] = Vector2.Zero;
        }
    }

    public static void ResetPlayer(int player)
    {
        Point[] array = PressurePlatesPressed.Keys.ToArray();
        for (int i = 0; i < array.Length; i++)
        {
            MoveAwayFrom(array[i], player);
        }
    }

    public static void UpdatePlayerPosition(Terraria.Player player)
    {
        Point p = new Point(1, 1);
        Vector2 vector = p.ToVector2();
        List<Point> tilesIn = Collision.GetTilesIn(PlayerLastPosition[player.whoAmI] + vector, PlayerLastPosition[player.whoAmI] + player.Size - vector * 2f);
        List<Point> tilesIn2 = Collision.GetTilesIn(player.TopLeft + vector, player.BottomRight - vector * 2f);
        Rectangle hitbox = player.Hitbox;
        Rectangle hitbox2 = player.Hitbox;
        hitbox.Inflate(-p.X, -p.Y);
        hitbox2.Inflate(-p.X, -p.Y);
        hitbox2.X = (int)PlayerLastPosition[player.whoAmI].X;
        hitbox2.Y = (int)PlayerLastPosition[player.whoAmI].Y;
        for (int i = 0; i < tilesIn.Count; i++)
        {
            Point point = tilesIn[i];
            Tile tile = WorldData.MapData[WorldData.nowGenerating, point.X, point.Y];
            if (tile.HasTile && tile.TileType == 428)
            {
                pressurePlateBounds.X = point.X * 16;
                pressurePlateBounds.Y = point.Y * 16 + 16 - pressurePlateBounds.Height;
                if (!hitbox.Intersects(pressurePlateBounds) && !tilesIn2.Contains(point))
                    MoveAwayFrom(point, player.whoAmI);
            }
        }

        for (int j = 0; j < tilesIn2.Count; j++)
        {
            Point point2 = tilesIn2[j];
            Tile tile2 = WorldData.MapData[WorldData.nowGenerating, point2.X, point2.Y];
            if (tile2.HasTile && tile2.TileType == 428)
            {
                pressurePlateBounds.X = point2.X * 16;
                pressurePlateBounds.Y = point2.Y * 16 + 16 - pressurePlateBounds.Height;
                if (hitbox.Intersects(pressurePlateBounds) && (!tilesIn.Contains(point2) || !hitbox2.Intersects(pressurePlateBounds)))
                    MoveInto(point2, player.whoAmI);
            }
        }

        PlayerLastPosition[player.whoAmI] = player.position;
    }

    public static void DestroyPlate(Point location)
    {
        if (PressurePlatesPressed.TryGetValue(location, out var _))
        {
            PressurePlatesPressed.Remove(location);
            PokeLocation(location);
        }
    }

    private static void UpdatePlatePosition(Point location, int player, bool onIt)
    {
        if (onIt)
            MoveInto(location, player);
        else
            MoveAwayFrom(location, player);
    }

    private static void MoveInto(Point location, int player)
    {
        if (PressurePlatesPressed.TryGetValue(location, out var value))
        {
            value[player] = true;
            return;
        }

        lock (EntityCreationLock)
        {
            PressurePlatesPressed[location] = new bool[255];
        }

        PressurePlatesPressed[location][player] = true;
        PokeLocation(location);
    }

    private static void MoveAwayFrom(Point location, int player)
    {
        if (!PressurePlatesPressed.TryGetValue(location, out var value))
            return;

        value[player] = false;
        bool flag = false;
        for (int i = 0; i < value.Length; i++)
        {
            if (value[i])
            {
                flag = true;
                break;
            }
        }

        if (!flag)
        {
            lock (EntityCreationLock)
            {
                PressurePlatesPressed.Remove(location);
            }

            PokeLocation(location);
        }
    }

    private static void PokeLocation(Point location)
    {
        if (Terraria.Main.netMode != NetmodeID.MultiplayerClient)
        {
            Wiring.blockPlayerTeleportationForOneIteration = true;
            Wiring.HitSwitch(location.X, location.Y);
            NetMessage.SendData(MessageID.HitSwitch, -1, -1, null, location.X, location.Y);
        }
    }
}
