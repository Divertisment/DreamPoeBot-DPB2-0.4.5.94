using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;

namespace ns0;

internal class Class181 : Interface10, IDisposable
{
	private static int int_0;

	private readonly int int_1;

	private unsafe readonly byte* pByte_0;

	private bool bool_0;

	private readonly GCHandle? nullable_0;

	private static Class181 class181_0;

	public Class181(byte[] byte_0)
	{
	}

	public unsafe Class181(byte* pByte_1, int int_2)
	{
	}

	public void Dispose()
	{
	}

	public Struct278 imethod_0(string string_0)
	{
		return (Struct278)(object)null;
	}

	public Struct278 imethod_1(string string_0, int int_2)
	{
		return (Struct278)(object)null;
	}

	public Struct278[] imethod_6(IReadOnlyList<string> ireadOnlyList_0, bool bool_1 = false)
	{
		return null;
	}

	public Struct278[] imethod_7(IReadOnlyList<string> ireadOnlyList_0, bool bool_1 = false)
	{
		return null;
	}

	public Struct278 imethod_2(string string_0)
	{
		return (Struct278)(object)null;
	}

	public Struct278 imethod_5(string string_0)
	{
		return (Struct278)(object)null;
	}

	public Struct278 imethod_3(string string_0)
	{
		return (Struct278)(object)null;
	}

	public Struct278 imethod_4(string string_0)
	{
		return (Struct278)(object)null;
	}

	[SkipLocalsInit]
	public unsafe static Struct278 smethod_0(byte* pByte_1, int int_2, string string_0)
	{
		return (Struct278)(object)null;
	}

	public unsafe static Struct278 smethod_1(byte* pByte_1, int int_2, Struct276 struct276_0)
	{
		return (Struct278)(object)null;
	}

	[MethodImpl(MethodImplOptions.AggressiveOptimization)]
	public unsafe static Struct278 smethod_2(byte* pByte_1, int int_2, string string_0)
	{
		return (Struct278)(object)null;
	}

	[MethodImpl(MethodImplOptions.AggressiveOptimization)]
	private static Span<ushort> smethod_3(in Struct275 scanPattern)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveOptimization)]
	private static Vector128<byte>[] FaiArQgHrZd(in Struct275 cbPattern)
	{
		return null;
	}

	private static Vector256<byte>[] smethod_4(in Struct275 cbPattern)
	{
		return null;
	}

	~Class181()
	{
	}

	protected virtual void Dispose(bool bool_1)
	{
	}

	static Class181()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		int_0 = Process.GetCurrentProcess().Id;
	}

	internal static bool smethod_5()
	{
		return true;
	}

	internal static Class181 smethod_6()
	{
		return null;
	}
}
