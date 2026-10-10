using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Common;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Bot;

public static class PluginManager
{
	public delegate void PluginEvent(IPlugin plugin);

	[CompilerGenerated]
	private sealed class Class456
	{
		public string string_0;

		private static Class456 class456_0;

		internal bool method_0(IPlugin iplugin_0)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class456 smethod_1()
		{
			return null;
		}

		static Class456()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private sealed class Class457
	{
		public string string_0;

		internal static Class457 class457_0;

		internal bool method_0(IPlugin iplugin_0)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class457 smethod_1()
		{
			return null;
		}

		static Class457()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private sealed class Class458
	{
		public string string_0;

		private static Class458 class458_0;

		internal bool method_0(IPlugin iplugin_0)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class458 smethod_1()
		{
			return null;
		}

		static Class458()
		{
			Class200.smethod_34();
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class Class459
	{
		public static readonly Class459 Method9;

		public static Func<IPlugin, bool> Method9__46_0;

		public static Func<IPlugin, string> Method9__47_0;

		internal static Class459 class459_0;

		internal bool method_0(IPlugin iplugin_0)
		{
			return true;
		}

		internal string method_1(IPlugin iplugin_0)
		{
			return null;
		}

		static Class459()
		{
			Class200.smethod_34();
			Class204.smethod_0();
			Method9 = new Class459();
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class459 smethod_1()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class Class460
	{
		public string string_0;

		internal static Class460 class460_0;

		internal bool method_0(IPlugin iplugin_0)
		{
			return true;
		}

		internal bool method_1(IPlugin iplugin_0)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class460 smethod_1()
		{
			return null;
		}

		static Class460()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private sealed class Class461
	{
		public IPlugin iplugin_0;

		private static Class461 class461_0;

		internal bool method_0(IPlugin iplugin_1)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class461 smethod_1()
		{
			return null;
		}

		static Class461()
		{
			Class200.smethod_34();
		}
	}

	private static readonly ILog ilog_0;

	private static readonly ILog ilog_1;

	private static List<IPlugin> list_0;

	[CompilerGenerated]
	private static PluginEvent pluginEvent_0;

	[CompilerGenerated]
	private static PluginEvent pluginEvent_1;

	[CompilerGenerated]
	private static PluginEvent pluginEvent_2;

	[CompilerGenerated]
	private static PluginEvent pluginEvent_3;

	[CompilerGenerated]
	private static PluginEvent pluginEvent_4;

	[CompilerGenerated]
	private static PluginEvent pluginEvent_5;

	[CompilerGenerated]
	private static PluginEvent pluginEvent_6;

	[CompilerGenerated]
	private static PluginEvent pluginEvent_7;

	private static readonly Dictionary<IPlugin, bool> dictionary_0;

	internal static PluginManager pluginManager_0;

	public static IReadOnlyList<IPlugin> Plugins => null;

	public static List<IPlugin> EnabledPlugins => null;

	public static List<IPlugin> DisabledPlugins => null;

	public static event PluginEvent PreStart
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

	public static event PluginEvent PostStart
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

	public static event PluginEvent PreTick
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

	public static event PluginEvent PostTick
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

	public static event PluginEvent PreStop
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

	public static event PluginEvent PostStop
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

	public static event PluginEvent OnPluginEnabled
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

	public static event PluginEvent OnPluginDisabled
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

	public static bool IsEnabled(string name)
	{
		return true;
	}

	public static bool IsEnabled(IPlugin plugin)
	{
		return true;
	}

	public static void Start()
	{
	}

	private static void smethod_0(IPlugin iplugin_0)
	{
	}

	public static void Tick()
	{
	}

	private static void smethod_1(IPlugin iplugin_0)
	{
	}

	public static void Stop()
	{
	}

	private static void smethod_2(IPlugin iplugin_0)
	{
	}

	public static bool Enable(string name)
	{
		return true;
	}

	public static bool Enable(IPlugin plugin)
	{
		return true;
	}

	public static bool Disable(string name)
	{
		return true;
	}

	public static bool Disable(IPlugin plugin)
	{
		return true;
	}

	private static void smethod_3(IPlugin iplugin_0, PluginEvent pluginEvent_8)
	{
	}

	internal static void smethod_4(IReadOnlyList<ThirdPartyInstance> ireadOnlyList_0, List<string> list_1, List<string> list_2)
	{
	}

	static PluginManager()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForName(Class200.smethod_20(2907422));
		ilog_1 = Logger.GetLoggerInstanceForType();
		list_0 = new List<IPlugin>();
		dictionary_0 = new Dictionary<IPlugin, bool>();
	}

	internal static bool smethod_5()
	{
		return true;
	}

	internal static PluginManager smethod_6()
	{
		return null;
	}
}
