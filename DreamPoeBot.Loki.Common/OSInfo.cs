using System;
using System.Runtime.InteropServices;
using System.Security;
using ns0;

namespace DreamPoeBot.Loki.Common;

public static class OSInfo
{
	private struct Struct270
	{
		public int int_0;

		public readonly int int_1;

		public readonly int int_2;

		public readonly int int_3;

		public readonly int int_4;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public readonly string string_0;

		public readonly short short_0;

		public readonly short short_1;

		public readonly short short_2;

		public readonly byte byte_0;

		public readonly byte byte_1;
	}

	private static string string_0;

	private static string string_1;

	internal static OSInfo osinfo_0;

	public static int Bits => 0;

	public static string Edition => null;

	public static string Name => null;

	public static string ServicePack => null;

	public static int BuildVersion => 0;

	public static string VersionString => null;

	public static Version Version => null;

	public static int MajorVersion => 0;

	public static int MinorVersion => 0;

	public static int RevisionVersion => 0;

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	internal static extern bool GetProductInfo(int int_0, int int_1, int int_2, int int_3, out int int_4);

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool GetVersionEx(ref Struct270 struct270_0);

	internal static bool smethod_0()
	{
		return true;
	}

	internal static OSInfo smethod_1()
	{
		return null;
	}

	static OSInfo()
	{
		Class200.smethod_34();
	}
}
