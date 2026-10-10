using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Windows.Forms;
using ns0;

namespace DreamPoeBot.Loki.Game;

[SuppressUnmanagedCodeSecurity]
public static class Interop
{
	[Flags]
	internal enum Enum4
	{

	}

	[Flags]
	internal enum Enum5
	{

	}

	public enum Cmd
	{
		Hide,
		Normal,
		ShowMinimized,
		Maximize,
		ShowNoActivate,
		Show,
		Minimize,
		ShowMinNoActive,
		ShowNA,
		Restore,
		ShowDefault,
		ForceMinimize
	}

	public enum Protection
	{
		PAGE_NOACCESS = 1,
		PAGE_READONLY = 2,
		PAGE_READWRITE = 4,
		PAGE_WRITECOPY = 8,
		PAGE_EXECUTE = 0x10,
		PAGE_EXECUTE_READ = 0x20,
		PAGE_EXECUTE_READWRITE = 0x40,
		PAGE_EXECUTE_WRITECOPY = 0x80,
		PAGE_GUARD = 0x100,
		PAGE_NOCACHE = 0x200,
		PAGE_WRITECOMBINE = 0x400
	}

	public delegate bool EnumThreadDelegate(nint hWnd, nint lParam);

	public struct WindowInfoWin32
	{
		public uint Size;

		public RectWin32 Window;

		public RectWin32 Client;

		public uint Style;

		public uint ExStyle;

		public uint WindowStatus;

		public uint WindowBordersX;

		public uint WindowBordersY;

		public ushort WindowType;

		public ushort CreatorVersion;
	}

	public struct RectWin32
	{
		public int Left;

		public int Top;

		public int Right;

		public int Bottom;

		private static object object_0;

		public override string ToString()
		{
			return null;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static object smethod_1()
		{
			return null;
		}

		static RectWin32()
		{
			Class200.smethod_34();
		}
	}

	private sealed class Class54
	{
		public List<nint> list_0;

		public EnumThreadDelegate enumThreadDelegate_0;

		private static Class54 class54_0;

		internal bool method_0(nint intptr_0, nint intptr_1)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class54 smethod_1()
		{
			return null;
		}

		static Class54()
		{
			Class200.smethod_34();
		}
	}

	private static Interop interop_0;

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	internal static extern nint VirtualAllocEx(nint intptr_0, nint intptr_1, uint uint_0, Enum4 enum4_0, Enum5 enum5_0);

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	public static extern bool QueryPerformanceCounter(out long lpPerformanceCount);

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	public static extern bool QueryPerformanceFrequency(out long lpFrequency);

	[DllImport("user32.dll")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool SetForegroundWindow(nint hWnd);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	[SuppressUnmanagedCodeSecurity]
	public static extern nint GetModuleHandle(string libname);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern nint GetProcAddress(nint hModule, string lpProcName);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern bool SetWindowText(nint hWnd, string text);

	[DllImport("user32.dll", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void SwitchToThisWindow(nint hWnd, bool turnOn);

	[DllImport("user32.dll")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetWindowInfo(nint hWnd, ref WindowInfoWin32 pwi);

	[DllImport("user32.dll", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	internal static extern nint FindWindow(string string_0, string string_1);

	[DllImport("user32.dll", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool SetCursorPos(int x, int y);

	[DllImport("user32.dll")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool PostMessage(nint hWnd, int msg, nint wParam, nint lParam);

	[DllImport("user32.dll")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool SendMessage(nint hWnd, int msg, nint wParam, nint lParam);

	[DllImport("user32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool SendMessageW(nint hWnd, uint msg, nint wParam, nint lParam);

	[DllImport("user32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool PostMessageW(nint intptr_0, uint uint_0, nint intptr_1, nint intptr_2);

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	public static extern uint GetTickCount();

	[DllImport("user32.dll")]
	[SuppressUnmanagedCodeSecurity]
	public static extern uint MapVirtualKeyW(uint uCode, uint uMapType);

	[DllImport("user32.dll")]
	[SuppressUnmanagedCodeSecurity]
	public static extern uint MapVirtualKeyEx(uint uCode, uint uMapType, nint dwhkl);

	[DllImport("user32.dll")]
	[SuppressUnmanagedCodeSecurity]
	public static extern int GetClassName(nint hWnd, StringBuilder lpClassName, int nMaxCount);

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	internal static extern nint OpenThread(uint uint_0, bool bool_0, uint uint_1);

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	internal static extern nint OpenProcess(uint uint_0, bool bool_0, uint uint_1);

	[DllImport("user32.dll")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool EnumThreadWindows(int dwThreadId, EnumThreadDelegate lpfn, nint lParam);

	[DllImport("kernel32.dll", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	internal static extern bool DebugActiveProcess(uint uint_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	internal static extern bool DebugActiveProcessStop(uint uint_0);

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	internal static extern bool DebugSetProcessKillOnExit(uint uint_0);

	[DllImport("user32.dll")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool ShowWindow(nint hWnd, Cmd cmd);

	[DllImport("user32.dll")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool IsIconic(nint hWnd);

	public static char MapVirtualKeyEx(Keys key)
	{
		return '\0';
	}

	internal static nint smethod_0(Process process_0, string string_0 = "POEWindowClass")
	{
		return (nint)(object)null;
	}

	internal static IEnumerable<nint> smethod_1(Process process_0)
	{
		return null;
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static Interop smethod_3()
	{
		return null;
	}

	static Interop()
	{
		Class200.smethod_34();
	}
}
