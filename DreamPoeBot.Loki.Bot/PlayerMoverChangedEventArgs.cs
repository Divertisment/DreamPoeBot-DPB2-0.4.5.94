using System;
using ns0;

namespace DreamPoeBot.Loki.Bot;

public class PlayerMoverChangedEventArgs : EventArgs
{
	public IPlayerMover Old;

	public IPlayerMover New;

	internal static PlayerMoverChangedEventArgs playerMoverChangedEventArgs_0;

	internal PlayerMoverChangedEventArgs(IPlayerMover old, IPlayerMover @new)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static PlayerMoverChangedEventArgs smethod_1()
	{
		return null;
	}

	static PlayerMoverChangedEventArgs()
	{
		Class200.smethod_34();
	}
}
