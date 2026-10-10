using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Loki.Game.Std;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct GStruct2 : IEquatable<GStruct2>
{
	[StructLayout(LayoutKind.Sequential, Size = 16)]
	public struct Bufe__FixedBuffer
	{
		public long Address;

		public long Address2;
	}

	public Bufe__FixedBuffer Buf;

	public readonly uint Size;

	public readonly uint Sizeunused;

	public readonly uint ReservedSize;

	public readonly uint ReservedSizeunused;

	private static object object_0;

	public ulong Length64 => 0uL;

	public ulong Capacity64 => 0uL;

	internal string method_0(Func<long, int, byte[]> func_0)
	{
		return null;
	}

	internal bool method_1(GStruct2 gstruct2_0)
	{
		return true;
	}

	public bool Equals(GStruct2 other)
	{
		return true;
	}

	public override bool Equals(object obj)
	{
		return true;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	[CompilerGenerated]
	internal static byte[] smethod_0(long long_0, int int_0)
	{
		return null;
	}

	internal static bool smethod_1()
	{
		return true;
	}

	internal static object smethod_2()
	{
		return null;
	}

	static GStruct2()
	{
		Class200.smethod_34();
	}
}
