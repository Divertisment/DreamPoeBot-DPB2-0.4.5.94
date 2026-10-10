using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using ns0;

namespace DreamPoeBot.Loki.FilesInMemory;

public record DatGroundEffectWrapper
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 235)]
	internal struct Struct149
	{
		[FieldOffset(0)]
		public long long_0;

		[FieldOffset(40)]
		public float vTmlqeirNmi;

		[FieldOffset(69)]
		public long long_1;
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

	public required long GroundEffectTypesPtr
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

	public required string GroundEffectType
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

	public required float Size
	{
		[CompilerGenerated]
		get
		{
			return 0f;
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
	private readonly long long_1;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly float float_0;

	[CompilerGenerated]
	private readonly string string_1;

	[CompilerGenerated]
	private readonly int int_0;

	private static DatGroundEffectWrapper datGroundEffectWrapper_0;

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
	protected DatGroundEffectWrapper(DatGroundEffectWrapper original)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static DatGroundEffectWrapper smethod_1()
	{
		return null;
	}

	static DatGroundEffectWrapper()
	{
		Class200.smethod_34();
	}
}
