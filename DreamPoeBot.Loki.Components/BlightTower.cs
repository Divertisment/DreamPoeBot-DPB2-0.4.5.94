using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class BlightTower : Component
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct190
	{
		public long long_0;

		public long long_1;

		public long long_2;

		public long long_3;

		public long long_4;

		public long long_5;

		public long long_6;

		public long long_7;

		public int int_0;

		public int int_1;

		public long long_8;

		public long long_9;

		public long long_10;
	}

	private PerFrameCachedValue<Struct190> perFrameCachedValue_0;

	private static BlightTower blightTower_0;

	[SpecialName]
	internal Struct190 method_2()
	{
		return (Struct190)(object)null;
	}

	private Struct190 method_3()
	{
		return (Struct190)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static BlightTower smethod_5()
	{
		return null;
	}

	static BlightTower()
	{
		Class200.smethod_34();
	}
}
