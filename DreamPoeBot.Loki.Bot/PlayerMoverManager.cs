using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Bot.Pathfinding.RDWrapper.Types;
using DreamPoeBot.Loki.Common;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Bot;

public static class PlayerMoverManager
{
	public delegate void PlayerMoverEvent(IPlayerMover mover);

	private static readonly ILog zZcAiMmywQp;

	private static readonly ILog ilog_0;

	private static List<IPlayerMover> list_0;

	[CompilerGenerated]
	private static PlayerMoverEvent playerMoverEvent_0;

	[CompilerGenerated]
	private static PlayerMoverEvent playerMoverEvent_1;

	[CompilerGenerated]
	private static PlayerMoverEvent playerMoverEvent_2;

	[CompilerGenerated]
	private static PlayerMoverEvent playerMoverEvent_3;

	[CompilerGenerated]
	private static PlayerMoverEvent playerMoverEvent_4;

	[CompilerGenerated]
	private static PlayerMoverEvent playerMoverEvent_5;

	private static IPlayerMover iplayerMover_0;

	[CompilerGenerated]
	private static EventHandler<PlayerMoverChangedEventArgs> eventHandler_0;

	private static PlayerMoverManager playerMoverManager_0;

	public static IReadOnlyList<IPlayerMover> PlayerMovers => null;

	public static IPlayerMover Current
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static PathResult? CurrentCommand => null;

	public static event PlayerMoverEvent PreStart
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event PlayerMoverEvent PostStart
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event PlayerMoverEvent PreTick
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event PlayerMoverEvent PostTick
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event PlayerMoverEvent PreStop
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event PlayerMoverEvent PostStop
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event EventHandler<PlayerMoverChangedEventArgs> OnPlayerMoverChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static void Start()
	{
	}

	public static void Start(IPlayerMover mover)
	{
	}

	public static void Tick()
	{
	}

	public static void Tick(IPlayerMover mover)
	{
	}

	public static void Stop()
	{
	}

	public static void Stop(IPlayerMover mover)
	{
	}

	private static void smethod_0(IPlayerMover iplayerMover_1, PlayerMoverEvent playerMoverEvent_6)
	{
	}

	internal static void smethod_1(IReadOnlyList<ThirdPartyInstance> ireadOnlyList_0)
	{
	}

	public static bool MoveTowards(Vector2i position, object user = null)
	{
		return true;
	}

	static PlayerMoverManager()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		zZcAiMmywQp = Logger.GetLoggerInstanceForName(Class200.smethod_20(2906580));
		ilog_0 = Logger.GetLoggerInstanceForType();
		list_0 = new List<IPlayerMover>();
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static PlayerMoverManager smethod_3()
	{
		return null;
	}
}
