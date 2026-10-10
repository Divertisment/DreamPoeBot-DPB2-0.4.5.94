using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using ns0;

namespace DreamPoeBot.Loki.Common;

public static class MouseHook
{
	public delegate void MouseEventDelegate();

	private static Thread thread_0;

	private static volatile bool bool_0;

	[CompilerGenerated]
	private static MouseEventDelegate mouseEventDelegate_0;

	[CompilerGenerated]
	private static MouseEventDelegate mouseEventDelegate_1;

	private static MouseHook mouseHook_0;

	public static event MouseEventDelegate OnButtonDown
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

	public static event MouseEventDelegate OnButtonUp
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

	[SpecialName]
	private static bool smethod_0()
	{
		return true;
	}

	[DllImport("user32.dll")]
	[SuppressUnmanagedCodeSecurity]
	private static extern short GetAsyncKeyState(Keys keys_0);

	private static void smethod_1()
	{
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static MouseHook smethod_3()
	{
		return null;
	}

	static MouseHook()
	{
		Class200.smethod_34();
	}
}
