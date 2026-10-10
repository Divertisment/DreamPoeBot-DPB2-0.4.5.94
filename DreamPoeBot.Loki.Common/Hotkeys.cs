using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Interop;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Common;

public static class Hotkeys
{
	private sealed class Class123
	{
		public MSG msg_0;

		public Func<Hotkey, bool> func_0;

		internal static Class123 class123_0;

		internal bool method_0(Hotkey hotkey_0)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class123 smethod_1()
		{
			return null;
		}

		static Class123()
		{
			Class200.smethod_34();
		}
	}

	private static readonly ILog ilog_0;

	private static readonly List<Hotkey> list_0;

	private static bool bool_0;

	private static nint intptr_0;

	private static int int_0;

	private static Thread thread_0;

	private static readonly Queue<Hotkey> queue_0;

	private static readonly Queue<Hotkey> queue_1;

	private static Hotkeys hotkeys_0;

	public static IEnumerable<Hotkey> RegisteredHotkeys => null;

	public static Hotkey Register(string name, Keys key, ModifierKeys modifierKeys, Action<Hotkey> callback)
	{
		return null;
	}

	public static void Unregister(string name)
	{
	}

	public static void Unregister(Hotkey hotkey)
	{
	}

	public static void Initialize(nint windowHandleToWatch)
	{
	}

	private static void smethod_0(Hotkey hotkey_0)
	{
	}

	private static void smethod_1(Hotkey hotkey_0)
	{
	}

	[SpecialName]
	internal static bool smethod_2()
	{
		return true;
	}

	private static void smethod_3()
	{
	}

	private static void smethod_4()
	{
	}

	private static void smethod_5()
	{
	}

	[DllImport("user32.dll")]
	[SuppressUnmanagedCodeSecurity]
	internal static extern nint GetForegroundWindow();

	[DllImport("user32.dll", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool RegisterHotKey(nint intptr_1, int int_1, uint uint_0, uint uint_1);

	[DllImport("user32.dll")]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool UnregisterHotKey(nint intptr_1, int int_1);

	[DllImport("user32.dll")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool PeekMessage(out MSG msg_0, nint intptr_1, uint uint_0, uint uint_1, uint uint_2);

	static Hotkeys()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
		list_0 = new List<Hotkey>();
		queue_0 = new Queue<Hotkey>();
		queue_1 = new Queue<Hotkey>();
	}

	internal static bool smethod_6()
	{
		return true;
	}

	internal static Hotkeys smethod_7()
	{
		return null;
	}
}
