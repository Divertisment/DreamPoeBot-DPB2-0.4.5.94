using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Loki.Game.GameData;

public class DatGrantedEffectsPerLevelWrapper
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 116)]
	internal struct Struct110
	{
		[FieldOffset(0)]
		public Struct10 struct10_0;

		[FieldOffset(16)]
		public int int_0;

		[FieldOffset(20)]
		private int int_1;

		[FieldOffset(24)]
		private int int_2;

		[FieldOffset(28)]
		public int int_3;

		[FieldOffset(32)]
		private int int_4;

		[FieldOffset(36)]
		private int int_5;

		[FieldOffset(40)]
		private int int_6;

		[FieldOffset(44)]
		private int int_7;

		[FieldOffset(108)]
		public float float_0;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[Obsolete("Unused legacy layout; not current GPEL row0x74. DA RITESTARE before reuse.")]
	internal struct Struct111
	{
		public Struct10 struct10_0;

		public int int_0;

		public int int_1;

		private int int_2;

		public long long_0;

		private float float_0;

		private float float_1;

		private float float_2;

		private float float_3;

		private float float_4;

		private float float_5;

		private float float_6;

		private float float_7;

		private float float_8;

		public int int_3;

		private int int_4;

		public long long_1;

		public int int_5;

		public int int_6;

		public int int_7;

		public int int_8;

		public int int_9;

		public int int_10;

		public int int_11;

		public int int_12;

		public int int_13;

		public int int_14;

		public int int_15;

		public int int_16;

		public int int_17;

		public int int_18;

		public int int_19;

		public int int_20;

		public int int_21;

		public int int_22;

		public int int_23;

		public int int_24;

		public int int_25;

		private int int_26;

		public long long_2;

		public byte byte_0;

		public int int_27;

		public int int_28;

		public int int_29;

		public int int_30;

		public int int_31;

		public int int_32;

		public int int_33;
	}

	[CompilerGenerated]
	private short short_0;

	[CompilerGenerated]
	private long long_0;

	[CompilerGenerated]
	private byte byte_0;

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private Struct110 struct110_0;

	private static DatGrantedEffectsPerLevelWrapper datGrantedEffectsPerLevelWrapper_0;

	public short Index
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public long BaseAddress
	{
		[CompilerGenerated]
		get
		{
			return 0L;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public byte Level
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int Cooldown
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public float ActorLevel => 0f;

	public DatGrantedEffectWrapper GrantedEffect => null;

	public DatActiveSkillWrapper ActiveSkill => null;

	[SpecialName]
	internal Memory method_0()
	{
		return null;
	}

	[SpecialName]
	[CompilerGenerated]
	internal Struct110 method_1()
	{
		return (Struct110)(object)null;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_2(Struct110 struct110_1)
	{
	}

	internal DatGrantedEffectsPerLevelWrapper(long address, Struct110 native, short index)
	{
	}

	internal DatGrantedEffectsPerLevelWrapper(long ptr, short index = -1)
	{
	}

	private int method_3(int int_1, Dictionary<long, DatSkillGemWrapper> dictionary_0)
	{
		return 0;
	}

	public int GetRequiredStr(Dictionary<long, DatSkillGemWrapper> SkillGems)
	{
		return 0;
	}

	public int GetRequiredDex(Dictionary<long, DatSkillGemWrapper> SkillGems)
	{
		return 0;
	}

	public int GetRequiredInt(Dictionary<long, DatSkillGemWrapper> SkillGems)
	{
		return 0;
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static DatGrantedEffectsPerLevelWrapper smethod_1()
	{
		return null;
	}

	static DatGrantedEffectsPerLevelWrapper()
	{
		Class200.smethod_34();
	}
}
