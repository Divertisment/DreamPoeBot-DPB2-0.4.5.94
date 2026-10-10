using System;
using System.Runtime.CompilerServices;
using System.Windows;
using ns0;

namespace DreamPoeBot.Loki.Common.Controls;

public class TimeSelectedChangedRoutedEventArgs : RoutedEventArgs
{
	[CompilerGenerated]
	private TimeSpan timeSpan_0;

	[CompilerGenerated]
	private TimeSpan timeSpan_1;

	private static TimeSelectedChangedRoutedEventArgs timeSelectedChangedRoutedEventArgs_0;

	public TimeSpan NewTime
	{
		[CompilerGenerated]
		get
		{
			return (TimeSpan)(object)null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public TimeSpan OldTime
	{
		[CompilerGenerated]
		get
		{
			return (TimeSpan)(object)null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public TimeSelectedChangedRoutedEventArgs(RoutedEvent routedEvent)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static TimeSelectedChangedRoutedEventArgs smethod_1()
	{
		return null;
	}

	static TimeSelectedChangedRoutedEventArgs()
	{
		Class200.smethod_34();
	}
}
