using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Loki.Game.Std;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct NativeStringA : IEquatable<NativeStringA>
{
	[StructLayout(LayoutKind.Sequential, Size = 16)]
	[UnsafeValueType]
	[CompilerGenerated]
	public struct Bufe__FixedBuffer
	{
		public byte FixedElementField;
	}

	public Bufe__FixedBuffer Buf;

	public readonly uint Size;

	private readonly uint uint_0;

	public readonly uint ReservedSize;

	private readonly uint uint_1;

	private static object object_0;

	public bool Equals(NativeStringA other)
	{
		return true;
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static object smethod_1()
	{
		return null;
	}

	static NativeStringA()
	{
		Class200.smethod_34();
	}
}
