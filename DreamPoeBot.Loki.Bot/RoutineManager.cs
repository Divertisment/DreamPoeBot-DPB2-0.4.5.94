using System;
using System.Collections.Generic;
using DreamPoeBot.Loki.Common;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Bot;

public static class RoutineManager
{
	public delegate void RoutineEvent(IRoutine routine);

	private static readonly ILog ilog_0;

	private static readonly ILog ilog_1;

	private static List<IRoutine> list_0;

	private static RoutineEvent routineEvent_0;

	private static RoutineEvent routineEvent_1;

	private static RoutineEvent routineEvent_2;

	private static RoutineEvent routineEvent_3;

	private static RoutineEvent routineEvent_4;

	private static RoutineEvent routineEvent_5;

	private static IRoutine iroutine_0;

	private static EventHandler<RoutineChangedEventArgs> eventHandler_0;

	internal static RoutineManager routineManager_0;

	public static IReadOnlyList<IRoutine> Routines => null;

	public static IRoutine Current
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static event RoutineEvent PreStart
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event RoutineEvent PostStart
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event RoutineEvent PreTick
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event RoutineEvent PostTick
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event RoutineEvent PreStop
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event RoutineEvent PostStop
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event EventHandler<RoutineChangedEventArgs> OnRoutineChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	public static void Start()
	{
	}

	public static void Start(IRoutine routine)
	{
	}

	public static void Tick()
	{
	}

	public static void Tick(IRoutine routine)
	{
	}

	public static void Stop()
	{
	}

	public static void Stop(IRoutine routine)
	{
	}

	private static void smethod_0(IRoutine iroutine_1, RoutineEvent routineEvent_6)
	{
	}

	internal static void smethod_1(IReadOnlyList<ThirdPartyInstance> ireadOnlyList_0)
	{
	}

	static RoutineManager()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForName(Class200.smethod_20(2908520));
		ilog_1 = Logger.GetLoggerInstanceForType();
		list_0 = new List<IRoutine>();
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static RoutineManager smethod_3()
	{
		return null;
	}
}
