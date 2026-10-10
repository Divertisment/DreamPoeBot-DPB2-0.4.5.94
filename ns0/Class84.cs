using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.Game.Utilities;

namespace ns0;

internal class Class84 : MemoryObject
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct18
	{
		private long long_0;

		public NativeVector nativeVector_0;
	}

	[Serializable]
	private sealed class Class25
	{
		public static readonly Class25 class25_0;

		public static Func<KeyValuePair<StatTypeGGG, int>, StatTypeGGG> func_0;

		public static Func<KeyValuePair<StatTypeGGG, int>, int> func_1;

		internal static Class25 class25_1;

		internal StatTypeGGG method_0(KeyValuePair<StatTypeGGG, int> keyValuePair_0)
		{
			return (StatTypeGGG)(object)null;
		}

		internal int method_1(KeyValuePair<StatTypeGGG, int> keyValuePair_0)
		{
			return 0;
		}

		static Class25()
		{
			Class200.smethod_34();
			Class204.smethod_0();
			class25_0 = new Class25();
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class25 smethod_1()
		{
			return null;
		}
	}

	private readonly Struct18? nullable_0;

	private PerFrameCachedValue<Struct18> perFrameCachedValue_0;

	private static Class84 class84_0;

	internal Class84(long long_0)
	{
	}

	internal Class84(Struct18 struct18_0)
	{
	}

	[SpecialName]
	private Struct18 method_1()
	{
		return (Struct18)(object)null;
	}

	[SpecialName]
	private Struct18 method_2()
	{
		return (Struct18)(object)null;
	}

	[SpecialName]
	internal List<KeyValuePair<StatTypeGGG, int>> method_3()
	{
		return null;
	}

	[SpecialName]
	internal Dictionary<StatTypeGGG, int> method_4()
	{
		return null;
	}

	internal int method_5(StatTypeGGG statTypeGGG_0)
	{
		return 0;
	}

	private Struct18 method_6()
	{
		return (Struct18)(object)null;
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static Class84 smethod_3()
	{
		return null;
	}

	static Class84()
	{
		Class200.smethod_34();
	}
}
