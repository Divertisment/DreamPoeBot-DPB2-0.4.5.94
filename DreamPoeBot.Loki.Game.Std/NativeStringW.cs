using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Loki.Game.Std;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct NativeStringW : IEquatable<NativeStringW>
{
	[StructLayout(LayoutKind.Sequential, Size = 16)]
	[CompilerGenerated]
	[UnsafeValueType]
	public struct Bufe__FixedBuffer
	{
		public unsafe fixed char FixedElementField[8];
	}

	public Bufe__FixedBuffer Buf;

	public readonly uint Size;

	public readonly uint Sizeunused;

	public readonly uint ReservedSize;

	public readonly uint ReservedSizeunused;

	internal static object object_0;

	public override string ToString()
	{
		return null;
	}

	public bool Equals(NativeStringW other)
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

	static NativeStringW()
	{
		Class200.smethod_34();
	}
}
