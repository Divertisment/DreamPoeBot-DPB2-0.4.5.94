using System;
using ns0;

namespace DreamPoeBot.Loki.Bot;

public class BotChangedEventArgs : EventArgs
{
	public IBot New;

	public IBot Old;

	internal static BotChangedEventArgs botChangedEventArgs_0;

	internal BotChangedEventArgs(IBot old, IBot @new)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static BotChangedEventArgs smethod_1()
	{
		return null;
	}

	static BotChangedEventArgs()
	{
		Class200.smethod_34();
	}
}
