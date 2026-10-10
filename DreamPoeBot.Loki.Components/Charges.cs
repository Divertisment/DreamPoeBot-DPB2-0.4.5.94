using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Objects;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class Charges : Component
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct193
	{
		public Struct14 struct14_0;

		public long long_0;

		public int int_0;

		private int int_1;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct194
	{
		private long long_0;

		private long long_1;

		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;
	}

	private PerFrameCachedValue<Struct193> perFrameCachedValue_0;

	private static Charges charges_0;

	public int ChargesPerUse => 0;

	public int CurrentCharges => 0;

	public int ExtraCharges => 0;

	public int MaxBaseCharges => 0;

	public int MaxCharges => 0;

	public double MaxChargesModifier => 0.0;

	public int GetMaxCharges(LocalStats localStats)
	{
		return 0;
	}

	[SpecialName]
	internal Struct193 method_2()
	{
		return (Struct193)(object)null;
	}

	private int method_3(StatTypeGGG statTypeGGG_0)
	{
		return 0;
	}

	private Struct193 method_4()
	{
		return (Struct193)(object)null;
	}

	private bool method_5(NetworkObject networkObject_0)
	{
		return true;
	}

	[SpecialName]
	internal Struct194 method_6()
	{
		return (Struct194)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static Charges smethod_5()
	{
		return null;
	}

	static Charges()
	{
		Class200.smethod_34();
	}
}
