using DreamPoeBot.Loki.Bot;
using DreamPoeBot.Loki.Common.MVVM;
using ns0;

namespace DreamPoeBot.DreamPoe;

public class BotBindingWrapper : NotificationObject
{
	private readonly IBot ibot_0;

	private static BotBindingWrapper botBindingWrapper_0;

	public string Version => null;

	public string Author => null;

	public string Description => null;

	public bool IsActive => true;

	internal BotBindingWrapper(IBot bot)
	{
	}

	internal static bool smethod_3()
	{
		return true;
	}

	internal static BotBindingWrapper smethod_4()
	{
		return null;
	}

	static BotBindingWrapper()
	{
		Class200.smethod_34();
	}
}
