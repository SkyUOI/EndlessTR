using System.Collections.Generic;
using System.Reflection;

namespace EndlessTR.ObjectHack;

class MainClone
{
    // 使用反射自动复制所有字段
    private static readonly Dictionary<FieldInfo, object> _fieldValues = new();

    public static void Init()
    {
        // 自动捕获所有静态字段
        var fields = typeof(Terraria.Main).GetFields(
            BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);

		foreach (var field in fields)
		{
			// 跳过常量和只读字段
			if (field.IsLiteral || field.IsInitOnly) continue;
			//             if (field.FieldType.IsArray)
			// {
			//     var srcArray = (Array)field.GetValue(null);
			//     var destArray = (Array)srcArray.Clone();
			//     field.SetValue(null, destArray);
			// }
			_fieldValues[field] = field.GetValue(null);
        }
        // InitValue();
    }

    // static void InitValue()
    // {
	// 	musicFade[50] = 1f;

	// 	for (int i = 0; i < 10; i++) {
	// 		recentWorld[i] = "";
	// 		recentIP[i] = "";
	// 		recentPort[i] = 0;
	// 	}
        
	// 	if (rand == null)
    //         rand = new UnifiedRandom((int)DateTime.Now.Ticks);

	// 	SetTitle();
	// 	lo = rand.Next(6);
	// 	waterfallManager = new WaterfallManager();
	// 	_windowMover = new WindowStateController();
	// 	sittingManager = new AnchoredEntitiesCollection();
	// 	sleepingManager = new AnchoredEntitiesCollection();
	// 	gameTips = new GameTipsDisplay();
	// 	if (player[myPlayer] == null)
	// 		player[myPlayer] = new Player();

	// 	ContentSamples.Initialize();
	// 	PlayerInput.Initialize();
	// 	player[myPlayer] = new Player();
	// 	WorldGen.Hooks.OnWorldLoad += delegate {
	// 		AmbienceServer = new AmbienceServer();
	// 		LocalGolfState = new GolfState();
	// 		if (!dedServ)
	// 			Lighting.Clear();
	// 	};
	// 	WorldGen.AddGenPasses();
	// 	ModContent.RunEarlyClassConstructors();

	// 	DontStarveSeed.Initialize();
	// 	ResourceSetsManager = new PlayerResourceSetsManager();
	// 	MinimapFrameManagerInstance = new MinimapFrameManager();
	// 	PlayerInput.OnActionableInput += delegate {
	// 		if (LocalGolfState != null)
	// 			LocalGolfState.CancelBallTracking();
	// 	};

	// 	SceneMetrics = new SceneMetrics();
	// 	BindSettingsTo(Configuration);
	// 	if (dedServ) {
	// 		Initialize_AlmostEverything();

	// 		// Allow keeping TML configs on/for server
	// 		Configuration.Load();
	// 		ModLoader.ModLoader.LoadConfiguration();
	// 		return;
	// 	}

	// 	TimeLogger.Initialize();

	// 	// HiDef graphics profile set in Main ctor
	// 	/*
	// 	LoadContent_TryEnteringHiDef();
	// 	*/

	// 	ClientInitialize();
	// 	base.Initialize();
    // }
}