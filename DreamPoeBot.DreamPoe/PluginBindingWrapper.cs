using DreamPoeBot.Loki.Bot;
using DreamPoeBot.Loki.Common;
using DreamPoeBot.Loki.Common.MVVM;
using log4net;
using ns0;

namespace DreamPoeBot.DreamPoe;

public class PluginBindingWrapper : NotificationObject
{
	private static readonly ILog ilog_0;

	private readonly IPlugin iplugin_0;

	internal static PluginBindingWrapper pluginBindingWrapper_0;

	public string Version => null;

	public string Author => null;

	public string Description => null;

	public bool IsEnabled
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	internal PluginBindingWrapper(IPlugin plugin)
	{
	}

	static PluginBindingWrapper()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_3()
	{
		return true;
	}

	internal static PluginBindingWrapper smethod_4()
	{
		return null;
	}
}
