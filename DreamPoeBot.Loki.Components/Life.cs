using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.Objects;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class Life : Component
{
	private struct Struct221
	{
		public long long_0;

		public long long_1;
	}

	[StructLayout(LayoutKind.Explicit, Size = 40)]
	private struct Struct222
	{
		[FieldOffset(8)]
		public int int_0;

		[FieldOffset(12)]
		public int int_1;

		[FieldOffset(16)]
		public long long_0;

		[FieldOffset(24)]
		public int int_2;

		[FieldOffset(28)]
		public int int_3;

		[FieldOffset(32)]
		public int XaMljLcEtGq;

		[FieldOffset(36)]
		public byte byte_0;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct223
	{
		private nint intptr_0;

		private int int_0;

		private int int_1;

		private nint intptr_1;

		public int int_2;

		public int yXlljcfAedf;

		private byte byte_0;

		private byte byte_1;

		private byte byte_2;

		private byte byte_3;

		private int int_3;

		private nint intptr_2;

		public float float_0;

		public int int_4;

		public int int_5;

		private int int_6;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct224
	{
		public Struct223 struct223_0;

		private ushort ushort_0;

		private byte byte_0;

		private byte byte_1;

		private float float_0;

		private float float_1;
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	internal struct Struct225
	{
		[FieldOffset(424)]
		public Struct223 struct223_0;

		[FieldOffset(512)]
		public Struct223 struct223_1;

		[FieldOffset(576)]
		public Struct223 struct223_2;

		[FieldOffset(776)]
		public byte byte_0;
	}

	private PerFrameCachedValue<Struct225> perFrameCachedValue_0;

	internal static Life life_0;

	public int Health => 0;

	public int MaxHealth => 0;

	public float HealthPercent => 0f;

	public int HealthReserved => 0;

	public int HealthReservedPercent => 0;

	public float HealthRegen => 0f;

	public int Mana => 0;

	public int MaxMana => 0;

	public float ManaPercent => 0f;

	public float ManaPercentTotal => 0f;

	public int ManaReserved => 0;

	public float ManaReservedPercent => 0f;

	public float ManaRegen => 0f;

	public int EnergyShield => 0;

	public int EnergyShieldMax => 0;

	public float EnergyShieldPercent => 0f;

	public float EnergyShieldPercentTotal => 0f;

	public int EnergyShieldReserved => 0;

	public float EnergyShieldReservedPercent => 0f;

	public float EnergyShieldRegen => 0f;

	[Obsolete("CorpseUsable offset308 is unconfirmed on PE59AD938D; do not use as an action gate.")]
	public bool CorpseUsable => true;

	public SpiritData GetSpirit(int weaponSet)
	{
		return (SpiritData)(object)null;
	}

	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	internal float method_2()
	{
		return 0f;
	}

	[SpecialName]
	internal Struct225 method_3()
	{
		return (Struct225)(object)null;
	}

	private Struct225 method_4()
	{
		return (Struct225)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static Life smethod_5()
	{
		return null;
	}

	static Life()
	{
		Class200.smethod_34();
	}
}
