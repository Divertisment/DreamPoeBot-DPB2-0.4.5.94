using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class SentinelDrone : Component
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct246
	{
		private long long_0;

		private long long_1;

		private long long_2;

		private long long_3;

		public int int_0;

		public int int_1;

		public int int_2;

		private long long_4;

		private long long_5;

		public int int_3;
	}

	private static int int_0;

	private PerFrameCachedValue<Struct246> perFrameCachedValue_0;

	internal static SentinelDrone sentinelDrone_0;

	public int ChargesUsed => 0;

	public int BaseCharges => 0;

	public int BaseDuration => 0;

	public int BaseEmpowers => 0;

	public int BaseEmpowerments => 0;

	[SpecialName]
	internal Struct246 method_2()
	{
		return (Struct246)(object)null;
	}

	[SpecialName]
	internal Struct246 method_3()
	{
		return (Struct246)(object)null;
	}

	static SentinelDrone()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		int_0 = -1;
	}

	[CompilerGenerated]
	private Struct246 method_4()
	{
		return (Struct246)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static SentinelDrone smethod_5()
	{
		return null;
	}
}
