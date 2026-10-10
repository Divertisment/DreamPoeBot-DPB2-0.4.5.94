using System.Runtime.InteropServices;
using System.Security;

namespace ns0;

internal static class Class20
{
	public delegate int Delegate0(nint hwnd, int msg, nint lParam, nint lpData);

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	public class Class21
	{
		public nint intptr_0;

		public nint intptr_1;

		public nint intptr_2;

		public string string_0;

		public int int_0;

		public Delegate0 delegate0_0;

		public nint intptr_3;

		public int int_1;

		private static Class21 class21_0;

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class21 smethod_1()
		{
			return null;
		}

		static Class21()
		{
			Class200.smethod_34();
		}
	}

	[ComImport]
	[Guid("00000002-0000-0000-c000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[SuppressUnmanagedCodeSecurity]
	public interface Interface7
	{
		[PreserveSig]
		nint imethod_0(int int_0);

		[PreserveSig]
		nint imethod_1(nint intptr_0, int int_0);

		[PreserveSig]
		void imethod_2(nint intptr_0);

		[PreserveSig]
		int imethod_3(nint intptr_0);

		[PreserveSig]
		int imethod_4(nint intptr_0);

		[PreserveSig]
		void imethod_5();
	}

	[SuppressUnmanagedCodeSecurity]
	internal static class Class22
	{
		[DllImport("shell32.dll", CharSet = CharSet.Auto)]
		public static extern nint SHBrowseForFolder([In] Class21 class21_0);

		[DllImport("shell32.dll")]
		public static extern int SHGetMalloc([Out][MarshalAs(UnmanagedType.LPArray)] Interface7[] interface7_0);

		[DllImport("shell32.dll", CharSet = CharSet.Auto)]
		public static extern bool SHGetPathFromIDList(nint intptr_0, nint intptr_1);

		[DllImport("shell32.dll")]
		public static extern int SHGetSpecialFolderLocation(nint intptr_0, int int_0, ref nint intptr_1);

		static Class22()
		{
			Class200.smethod_34();
		}
	}

	[SuppressUnmanagedCodeSecurity]
	internal static class Class23
	{
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern nint SendMessage(HandleRef handleRef_0, int int_0, int int_1, string string_0);

		[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SendMessage")]
		public static extern nint SendMessage_1(HandleRef handleRef_0, int int_0, int int_1, int int_2);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern nint FindWindowEx(HandleRef handleRef_0, nint intptr_0, string string_0, string string_1);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool SetWindowText(nint intptr_0, string string_0);

		static Class23()
		{
			Class200.smethod_34();
		}
	}

	static Class20()
	{
		Class200.smethod_34();
	}
}
