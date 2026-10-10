using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using ns0;

namespace DreamPoeBot.Loki.FilesInMemory;

public record DatTagWrapper
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 44)]
	internal struct Struct153
	{
		[FieldOffset(0)]
		public long long_0;

		[FieldOffset(8)]
		public uint uint_0;
	}

	[CompilerGenerated]
	protected virtual Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public readonly long Address;

	public readonly uint Hash;

	public readonly int Index;

	public readonly string Key;

	internal static DatTagWrapper datTagWrapper_0;

	internal DatTagWrapper(Struct153 str, long Address, int Index)
	{
	}

	public override string ToString()
	{
		return null;
	}

	[CompilerGenerated]
	protected virtual bool PrintMembers(StringBuilder builder)
	{
		return true;
	}

	[CompilerGenerated]
	protected DatTagWrapper(DatTagWrapper original)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static DatTagWrapper smethod_1()
	{
		return null;
	}

	static DatTagWrapper()
	{
		Class200.smethod_34();
	}
}
