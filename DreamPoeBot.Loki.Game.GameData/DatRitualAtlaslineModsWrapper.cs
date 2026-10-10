using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using ns0;

namespace DreamPoeBot.Loki.Game.GameData;

public record DatRitualAtlaslineModsWrapper
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 52)]
	internal struct Struct122
	{
		[FieldOffset(0)]
		public long long_0;

		[FieldOffset(16)]
		public int int_0;

		[FieldOffset(20)]
		public long long_1;

		[FieldOffset(36)]
		public long long_2;
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

	public required long Mod
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

	public required int Weighting
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

	public required long ConditionStat
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

	public required long Mod2
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

	[CompilerGenerated]
	private readonly long long_0;

	[CompilerGenerated]
	private readonly int int_0;

	[CompilerGenerated]
	private readonly long long_1;

	[CompilerGenerated]
	private readonly int int_1;

	[CompilerGenerated]
	private readonly long long_2;

	[CompilerGenerated]
	private readonly long long_3;

	internal static DatRitualAtlaslineModsWrapper datRitualAtlaslineModsWrapper_0;

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

	[SetsRequiredMembers]
	[CompilerGenerated]
	protected DatRitualAtlaslineModsWrapper(DatRitualAtlaslineModsWrapper original)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static DatRitualAtlaslineModsWrapper smethod_1()
	{
		return null;
	}

	static DatRitualAtlaslineModsWrapper()
	{
		Class200.smethod_34();
	}
}
