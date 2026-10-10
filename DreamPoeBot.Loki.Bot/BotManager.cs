using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using DreamPoeBot.Loki.Common;
using DreamPoeBot.Loki.Game;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Bot;

public static class BotManager
{
	public delegate void BotEvent(IBot bot);

	private static Stopwatch stopwatch_0;

	[CompilerGenerated]
	private static int int_0;

	[CompilerGenerated]
	private static Thread thread_0;

	public static List<IBot> _bots;

	public static int TotalExceptionRuntime;

	public static bool LogVariableChange;

	private static readonly ILog ilog_0;

	private static BotEvent botEvent_0;

	private static BotEvent botEvent_1;

	private static BotEvent botEvent_2;

	private static BotEvent botEvent_3;

	private static BotEvent botEvent_4;

	private static BotEvent botEvent_5;

	private static readonly object object_0;

	private static readonly ManualResetEvent manualResetEvent_0;

	private static DateTime dateTime_0;

	private static StopReasonData stopReasonData_0;

	private static bool bool_0;

	private static bool bool_1;

	private static bool bool_2;

	private static int int_1;

	private static IBot ibot_0;

	private static EventHandler<BotChangedEventArgs> eventHandler_0;

	private static EventHandler<ClientFrozenEventArgs> eventHandler_1;

	private static EventHandler<BotTickExceptionEventArgs> eventHandler_2;

	private static bool bool_3;

	private static readonly Stopwatch stopwatch_1;

	private static int int_2;

	private static readonly List<Tuple<Exception, DateTime>> list_0;

	private static int int_3;

	internal static BotManager botManager_0;

	public static IReadOnlyList<IBot> Bots => null;

	public static StopReasonData StopReason => null;

	public static DateTime TimeOfLastTick => (DateTime)(object)null;

	public static int StopBotAfterXExceptionsBeforeTickCompletes
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static IBot Current
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static Thread BotThread
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static int ExceptionCount => 0;

	public static IReadOnlyList<Tuple<Exception, DateTime>> Exceptions => null;

	public static bool ClientFrozen => true;

	public static int MsBeforeNextTick
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int MsBetweenTicks
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static bool IsStopping => true;

	public static bool IsRunning => true;

	public static event BotEvent PreStart
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event BotEvent PostStart
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event BotEvent PreTick
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event BotEvent PostTick
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event BotEvent PreStop
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event BotEvent PostStop
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event EventHandler<BotChangedEventArgs> OnBotChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event EventHandler<ClientFrozenEventArgs> OnClientFrozen
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event EventHandler<BotTickExceptionEventArgs> OnBotTickException
	{
		add
		{
		}
		remove
		{
		}
	}

	static BotManager()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		stopwatch_0 = Stopwatch.StartNew();
		thread_0 = null;
		_bots = new List<IBot>();
		TotalExceptionRuntime = 0;
		LogVariableChange = false;
		ilog_0 = Logger.GetLoggerInstanceForName(Class200.smethod_20(2900374));
		manualResetEvent_0 = new ManualResetEvent(initialState: false);
		dateTime_0 = DateTime.MinValue;
		stopwatch_1 = Stopwatch.StartNew();
		list_0 = new List<Tuple<Exception, DateTime>>();
		ilog_0 = Logger.GetLoggerInstanceForName(Class200.smethod_20(2900374));
		_bots = new List<IBot>();
		manualResetEvent_0 = new ManualResetEvent(initialState: false);
		dateTime_0 = DateTime.MinValue;
		StopBotAfterXExceptionsBeforeTickCompletes = 100;
		stopwatch_1 = Stopwatch.StartNew();
		list_0 = new List<Tuple<Exception, DateTime>>();
		object_0 = new object();
		MsBeforeNextTick = 80;
		LokiPoe.ProcessHookManager.OnInjectionDisabledByIngecion = (LokiPoe.ProcessHookManager.HookDisabledByIngecionEventHandler)Delegate.Combine(LokiPoe.ProcessHookManager.OnInjectionDisabledByIngecion, new LokiPoe.ProcessHookManager.HookDisabledByIngecionEventHandler(smethod_0));
	}

	private static void smethod_0(object sender, LokiPoe.ProcessHookManager.HookDisabledByIngecionEventArgs e)
	{
	}

	internal static void smethod_1(IBot ibot_1)
	{
	}

	internal static void smethod_2(IBot ibot_1)
	{
	}

	internal static void smethod_3(IBot ibot_1)
	{
	}

	private static void smethod_4(IBot ibot_1, BotEvent botEvent_6)
	{
	}

	public static bool Start()
	{
		return true;
	}

	public static bool Stop(bool force = false)
	{
		return true;
	}

	public static bool Stop(StopReasonData reason, bool force = false)
	{
		return true;
	}

	internal static bool smethod_5(StopReasonData stopReasonData_1, bool bool_4 = false)
	{
		return true;
	}

	private static bool smethod_6(StopReasonData stopReasonData_1, bool bool_4 = false)
	{
		return true;
	}

	private static void smethod_7()
	{
	}

	internal static void smethod_8(IReadOnlyList<ThirdPartyInstance> ireadOnlyList_0)
	{
	}

	internal static bool smethod_9()
	{
		return true;
	}

	internal static BotManager smethod_10()
	{
		return null;
	}
}
