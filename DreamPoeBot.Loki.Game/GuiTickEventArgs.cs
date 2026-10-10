using System;
using System.Runtime.CompilerServices;
using System.Windows;
using ns0;

namespace DreamPoeBot.Loki.Game;

public class GuiTickEventArgs : EventArgs
{
	[CompilerGenerated]
	private Window window_0;

	[CompilerGenerated]
	private Window window_1;

	internal static GuiTickEventArgs guiTickEventArgs_0;

	public Window Window
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		internal set
		{
		}
	}

	internal GuiTickEventArgs(Window window)
	{
	}

	internal GuiTickEventArgs()
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static GuiTickEventArgs smethod_1()
	{
		return null;
	}

	static GuiTickEventArgs()
	{
		Class200.smethod_34();
	}
}
