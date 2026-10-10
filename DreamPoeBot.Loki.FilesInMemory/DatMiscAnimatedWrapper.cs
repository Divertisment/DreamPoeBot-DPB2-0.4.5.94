using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using ns0;

namespace DreamPoeBot.Loki.FilesInMemory;

public record DatMiscAnimatedWrapper
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 44)]
	internal struct Struct150
	{
		[FieldOffset(0)]
		public long long_0;

		[FieldOffset(8)]
		public long long_1;

		[FieldOffset(36)]
		public int int_0;

		[FieldOffset(40)]
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

	public required long Address
	{
		[CompilerGenerated]
		get
		{
			return 0L;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	public required string Id
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	public required string AOFile
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	public required int BaseSize
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	public required uint Hash
	{
		[CompilerGenerated]
		get
		{
			return 0u;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	public required int Index
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	[CompilerGenerated]
	private readonly long long_0;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly string string_1;

	[CompilerGenerated]
	private readonly int int_0;

	[CompilerGenerated]
	private readonly uint uint_0;

	[CompilerGenerated]
	private readonly int int_1;

	private static DatMiscAnimatedWrapper datMiscAnimatedWrapper_0;

	[CompilerGenerated]
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
	[SetsRequiredMembers]
	protected DatMiscAnimatedWrapper(DatMiscAnimatedWrapper original)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static DatMiscAnimatedWrapper smethod_1()
	{
		return null;
	}

	static DatMiscAnimatedWrapper()
	{
		Class200.smethod_34();
	}
}
