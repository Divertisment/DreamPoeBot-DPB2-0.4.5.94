using System;
using ns0;

namespace DreamPoeBot.Loki.Bot;

public class RoutineChangedEventArgs : EventArgs
{
	public IRoutine Old;

	public IRoutine New;

	internal static RoutineChangedEventArgs routineChangedEventArgs_0;

	internal RoutineChangedEventArgs(IRoutine old, IRoutine @new)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static RoutineChangedEventArgs smethod_1()
	{
		return null;
	}

	static RoutineChangedEventArgs()
	{
		Class200.smethod_34();
	}
}
