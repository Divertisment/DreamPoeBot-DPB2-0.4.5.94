using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Windows.Forms;
using DreamPoeBot.Framework.Enums;
using ns0;

namespace DreamPoeBot.Framework;

[SuppressUnmanagedCodeSecurity]
public static class WinApi
{
	private struct Struct273
	{
		private int left;

		private int int_0;

		private int int_1;

		private int int_2;

		private static object object_0;

		public static Struct273 smethod_0(Rectangle rectangle_0)
		{
			return (Struct273)(object)null;
		}

		internal static bool smethod_1()
		{
			return true;
		}

		internal static object smethod_2()
		{
			return null;
		}

		static Struct273()
		{
			Class200.smethod_34();
		}
	}

	private struct Struct274
	{
		private readonly int left;

		private readonly int int_0;

		private readonly int int_1;

		private readonly int int_2;

		private static object object_0;

		public Rectangle method_0(Point point_0)
		{
			return (Rectangle)(object)null;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static object smethod_1()
		{
			return null;
		}

		static Struct274()
		{
			Class200.smethod_34();
		}
	}

	public struct MEMORY_BASIC_INFORMATION64
	{
		public ulong BaseAddress;

		public ulong AllocationBase;

		public int AllocationProtect;

		public int __alignment1;

		public ulong RegionSize;

		public int State;

		public int Protect;

		public int Type;

		public int __alignment2;
	}

	public enum AllocationProtectEnum : uint
	{
		PAGE_EXECUTE = 16u,
		PAGE_EXECUTE_READ = 32u,
		PAGE_EXECUTE_READWRITE = 64u,
		PAGE_EXECUTE_WRITECOPY = 128u,
		PAGE_NOACCESS = 1u,
		PAGE_READONLY = 2u,
		PAGE_READWRITE = 4u,
		PAGE_WRITECOPY = 8u,
		PAGE_GUARD = 256u,
		PAGE_NOCACHE = 512u,
		PAGE_WRITECOMBINE = 1024u
	}

	public enum StateEnum : uint
	{
		MEM_COMMIT = 4096u,
		MEM_FREE = 65536u,
		MEM_RESERVE = 8192u
	}

	public enum TypeEnum : uint
	{
		MEM_IMAGE = 16777216u,
		MEM_MAPPED = 262144u,
		MEM_PRIVATE = 131072u
	}

	[Flags]
	public enum FreeType : uint
	{
		Decommit = 0x4000u,
		Release = 0x8000u
	}

	internal static WinApi winApi_0;

	private static Delegate smethod_0(byte[] byte_0, Type type_0)
	{
		return null;
	}

	public static void EnableTransparent(nint handle, Rectangle size)
	{
	}

	public static Rectangle GetClientRectangle(nint handle)
	{
		return (Rectangle)(object)null;
	}

	public static bool IsForegroundWindow(nint handle)
	{
		return true;
	}

	public static bool IsKeyDown(Keys key)
	{
		return true;
	}

	public static nint OpenProcess(Process process, ProcessAccessFlags flags)
	{
		return (nint)(object)null;
	}

	public static bool WriteProcessMemory(nint handle, nint baseAddress, byte[] buffer)
	{
		return true;
	}

	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	[SuppressUnmanagedCodeSecurity]
	public static extern int ToUnicode(uint virtualKeyCode, uint scanCode, byte[] keyboardState, StringBuilder receivingBuffer, int bufferSize, uint flags);

	[DllImport("user32.dll")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool IsIconic(nint hWnd);

	[DllImport("psapi")]
	[SuppressUnmanagedCodeSecurity]
	public static extern bool EmptyWorkingSet(nint hProcess);

	[DllImport("SoftMagic.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	[SuppressUnmanagedCodeSecurity]
	public static extern int start_injection(long pID, long mWH, long sharedMemory, string key, bool isDebug);

	[DllImport("SoftMagic.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	internal static extern int start_injection_v2(long long_0, long long_1, long long_2, string string_0, ref Struct272 struct272_0);

	[DllImport("SoftMagic.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	[SuppressUnmanagedCodeSecurity]
	public static extern int initialize(string key, string domain);

	[DllImport("SoftMagic.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	[SuppressUnmanagedCodeSecurity]
	public static extern int initialize_for_process(string key, string domain, uint processId);

	[DllImport("SoftMagic.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern bool ex_read_bytes(long pHandle, long address, int length, byte* ret, out nuint bytesRead, bool allowPartialRead = false);

	[DllImport("SoftMagic.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern bool ex_read_server_data_bytes(long pHandle, long address, int length, byte* ret);

	[DllImport("SoftMagic.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern bool ex_read_ritual_data_bytes(long pHandle, long address, int length, byte* ret);

	[DllImport("SoftMagic.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern bool ex_read_delve_data_bytes(long pHandle, long address, int length, byte* ret);

	[DllImport("SoftMagic.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern bool ex_read_waypoint_data_bytes(long pHandle, long address, int length, byte* ret);

	[DllImport("SoftMagic.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern bool ex_read_incursion_data_bytes(long pHandle, long address, int length, byte* ret);

	[DllImport("SoftMagic.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern bool ex_read_blight_data_bytes(long pHandle, long address, int length, byte* ret);

	[DllImport("SoftMagic.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	[SuppressUnmanagedCodeSecurity]
	public static extern int ex_get_patch_offset();

	[DllImport("SoftMagic.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	[SuppressUnmanagedCodeSecurity]
	public static extern int getMagicNumber(int tx, int ty, int rotationselected, byte[] rotatorMatrixHelper, sbyte[] subTileHeightArray, int lenght);

	[DllImport("SoftMagic.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	[SuppressUnmanagedCodeSecurity]
	public static extern bool ex_read_objects_data_bytes(long address);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	[SuppressUnmanagedCodeSecurity]
	public static extern int CallNextHookEx(int idHook, int nCode, int wParam, nint lParam);

	[DllImport("ComDlg32.dll", CharSet = CharSet.Unicode)]
	[SuppressUnmanagedCodeSecurity]
	public static extern bool ChooseColor(ref ChooseColor chooseColor);

	[DllImport("kernel32.dll", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(nint hObject);

	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	[SuppressUnmanagedCodeSecurity]
	public static extern bool MoveWindow(nint hWnd, int x, int y, int width, int height, bool repaint);

	[DllImport("user32.dll")]
	[SuppressUnmanagedCodeSecurity]
	public static extern bool ScreenToClient(nint hWnd, ref Point lpPoint);

	[DllImport("user32.dll")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool SetForegroundWindow(nint hWnd);

	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	[SuppressUnmanagedCodeSecurity]
	public static extern nint SetParent(nint hWndChild, nint hWndParent);

	[DllImport("kernel32.dll", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern int SetProcessWorkingSetSize(nint process, int minimumWorkingSetSize, int maximumWorkingSetSize);

	[DllImport("user32.dll")]
	[SuppressUnmanagedCodeSecurity]
	public static extern bool ClientToScreen(nint hWnd, out Point lpPoint);

	[DllImport("dwmapi.dll")]
	[SuppressUnmanagedCodeSecurity]
	private static extern nint DwmExtendFrameIntoClientArea(nint intptr_0, ref Struct273 struct273_0);

	[DllImport("user32.dll")]
	[SuppressUnmanagedCodeSecurity]
	private static extern short GetAsyncKeyState(Keys keys_0);

	[DllImport("user32.dll")]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool GetClientRect(nint intptr_0, out Struct274 struct274_0);

	[DllImport("user32.dll")]
	[SuppressUnmanagedCodeSecurity]
	private static extern nint GetForegroundWindow();

	[DllImport("user32.dll", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern int GetWindowLong(nint intptr_0, int int_0);

	[DllImport("kernel32.dll", EntryPoint = "OpenProcess")]
	[SuppressUnmanagedCodeSecurity]
	private static extern nint OpenProcess_1(ProcessAccessFlags processAccessFlags_0, bool bool_0, int int_0);

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	internal unsafe static extern bool ReadProcessMemory(nint intptr_0, nint intptr_1, byte* pByte_0, int int_0, out int int_1);

	[DllImport("kernel32.dll", EntryPoint = "WriteProcessMemory")]
	[SuppressUnmanagedCodeSecurity]
	internal static extern bool WriteProcessMemory_1(nint intptr_0, nint intptr_1, byte[] byte_0, int int_0, out nint intptr_2);

	[DllImport("user32.dll", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool SetLayeredWindowAttributes(nint intptr_0, uint uint_0, byte byte_0, uint uint_1);

	[DllImport("user32.dll", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern int SetWindowLong(nint intptr_0, int int_0, nint intptr_1);

	[DllImport("winmm.dll")]
	[SuppressUnmanagedCodeSecurity]
	public static extern int waveOutSetVolume(nint hwo, uint dwVolume);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	internal static extern nint CreateRemoteThread(nint intptr_0, nint intptr_1, uint uint_0, nint intptr_2, nint intptr_3, uint uint_1, out uint uint_2);

	[DllImport("kernel32.dll", EntryPoint = "CreateRemoteThread", ExactSpelling = true, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	internal static extern nint CreateRemoteThread_1(nint intptr_0, nint intptr_1, uint uint_0, nint intptr_2, nint intptr_3, uint uint_1, nint intptr_4);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool VirtualFreeEx(nint hProcess, nint lpAddress, uint dwSize, FreeType dwFreeType);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern uint WaitForSingleObject(nint intptr_0, uint uint_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern bool GetExitCodeThread(nint intptr_0, out uint uint_0);

	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	[SuppressUnmanagedCodeSecurity]
	public static extern short VkKeyScanEx(char ch, nint dwhkl);

	[DllImport("user32.dll")]
	[SuppressUnmanagedCodeSecurity]
	public static extern nint GetKeyboardLayout(uint idThread);

	[DllImport("user32.dll")]
	[SuppressUnmanagedCodeSecurity]
	public static extern long SetCursorPos(int x, int y);

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	internal static extern int VirtualQueryEx(nint intptr_0, nint intptr_1, out MEMORY_BASIC_INFORMATION64 memory_BASIC_INFORMATION64_0, uint uint_0);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	[DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
	internal static extern bool VirtualProtectEx(nint intptr_0, nint intptr_1, nuint uintptr_0, uint uint_0, out uint uint_1);

	internal static bool smethod_1()
	{
		return true;
	}

	internal static WinApi smethod_2()
	{
		return null;
	}

	static WinApi()
	{
		Class200.smethod_34();
	}
}
