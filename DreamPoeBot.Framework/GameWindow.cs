using System.Diagnostics;
using System.Runtime.CompilerServices;
using DreamPoeBot.Common;
using ns0;
using SharpDX;

namespace DreamPoeBot.Framework;

public class GameWindow
{
	private readonly nint intptr_0;

	[CompilerGenerated]
	private Process process_0;

	internal static GameWindow gameWindow_0;

	public Process Process
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

	public GameWindow(Process process, nint mwhandle)
	{
	}

	public RectangleF GetWindowRectangle()
	{
		return (RectangleF)(object)null;
	}

	public RectangleF GetWindowRectangleReal()
	{
		return (RectangleF)(object)null;
	}

	public bool IsForeground()
	{
		return true;
	}

	public DreamPoeBot.Common.Vector2 ScreenToClient(int x, int y)
	{
		return (DreamPoeBot.Common.Vector2)(object)null;
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static GameWindow smethod_1()
	{
		return null;
	}

	static GameWindow()
	{
		Class200.smethod_34();
	}
}
