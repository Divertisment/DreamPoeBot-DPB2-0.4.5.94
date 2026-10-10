using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class Weapon : Component
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct266
	{
		public Struct14 struct14_0;

		public long long_0;

		public long long_1;

		public long long_2;

		public long long_3;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct267
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;

		public int int_5;

		public int int_6;

		public int int_7;

		private long long_0;
	}

	private PerFrameCachedValue<Struct266> perFrameCachedValue_0;

	private PerFrameCachedValue<Struct267> perFrameCachedValue_1;

	internal static Weapon weapon_0;

	public int BaseWeaponType => 0;

	public int BaseMinPhysicalDamage => 0;

	public int BaseMaxPhysicalDamage => 0;

	public double BaseAttacksPerSecond => 0.0;

	public int BaseAttacksPerSecondRaw => 0;

	public double BaseCritialStrikeChance => 0.0;

	public int BaseCritialStrikeChanceRaw => 0;

	public int _14 => 0;

	public int WeaponRange => 0;

	public int _1C => 0;

	[SpecialName]
	internal Struct266 method_2()
	{
		return (Struct266)(object)null;
	}

	[SpecialName]
	internal long method_3()
	{
		return 0L;
	}

	[SpecialName]
	internal Struct267 method_4()
	{
		return (Struct267)(object)null;
	}

	private Struct266 method_5()
	{
		return (Struct266)(object)null;
	}

	private Struct267 method_6()
	{
		return (Struct267)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static Weapon smethod_5()
	{
		return null;
	}

	static Weapon()
	{
		Class200.smethod_34();
	}
}
