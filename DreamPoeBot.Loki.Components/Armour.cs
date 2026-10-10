using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class Armour : Component
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct185
	{
		public Struct14 struct14_0;

		public long long_0;

		public long long_1;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct186
	{
		public long bgplUciEuxu;

		public long long_0;

		public int int_0;

		public int int_1;

		public int int_2;
	}

	private PerFrameCachedValue<Struct185> perFrameCachedValue_0;

	private PerFrameCachedValue<Struct186> perFrameCachedValue_1;

	internal static Armour armour_0;

	public int BaseEvasion => 0;

	public int BaseArmor => 0;

	public int BaseEnergyShield => 0;

	[SpecialName]
	internal Struct185 method_2()
	{
		return (Struct185)(object)null;
	}

	[SpecialName]
	internal Struct186 method_3()
	{
		return (Struct186)(object)null;
	}

	private Struct185 method_4()
	{
		return (Struct185)(object)null;
	}

	private Struct186 method_5()
	{
		return (Struct186)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static Armour smethod_5()
	{
		return null;
	}

	static Armour()
	{
		Class200.smethod_34();
	}
}
