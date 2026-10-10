using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using ns0;

namespace DreamPoeBot.Loki.Game.GameData;

public record DatPassiveSkillVariantsWrapper
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 32)]
	internal struct Struct120
	{
		public long long_0;

		public long long_1;

		public long long_2;

		public long long_3;
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

	public long PassiveSkillDat
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

	public long PassiveSkillVariantTypeDat
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

	public ushort FromPassiveGraphId => 0;

	public ushort ToPassiveGraphId => 0;

	[CompilerGenerated]
	private readonly long long_0;

	[CompilerGenerated]
	private readonly int int_0;

	[CompilerGenerated]
	private readonly long long_1;

	[CompilerGenerated]
	private readonly long long_2;

	internal static DatPassiveSkillVariantsWrapper datPassiveSkillVariantsWrapper_0;

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
	protected DatPassiveSkillVariantsWrapper(DatPassiveSkillVariantsWrapper original)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static DatPassiveSkillVariantsWrapper smethod_1()
	{
		return null;
	}

	static DatPassiveSkillVariantsWrapper()
	{
		Class200.smethod_34();
	}
}
