using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class Stats : Component
{
	[StructLayout(LayoutKind.Explicit, Size = 512)]
	public struct StatsComponentStructure
	{
		[FieldOffset(352)]
		public long StatsDictionaryStructure;

		[FieldOffset(456)]
		public long Stats2DictionaryStructure;
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct StatsDictionaryStructure
	{
		[FieldOffset(248)]
		public NativeVector StatsDictionaryVector;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct257
	{
		public StatTypeGGG statTypeGGG_0;

		public int int_0;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct258
	{
		public StatTypeGGG statTypeGGG_0;

		private int int_0;

		public int Value;

		private int int_1;

		private NativeVector nativeVector_0;
	}

	private PerFrameCachedValue<StatsComponentStructure> perFrameCachedValue_0;

	private PerFrameCachedValue<Dictionary<StatTypeGGG, int>> perFrameCachedValue_1;

	internal static Stats stats_0;

	public Dictionary<StatTypeGGG, int> statsDictionary => null;

	[SpecialName]
	internal int method_2()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	public int GetStat(StatTypeGGG stat)
	{
		return 0;
	}

	private Dictionary<StatTypeGGG, int> method_3()
	{
		return null;
	}

	[SpecialName]
	internal StatsComponentStructure method_4()
	{
		return (StatsComponentStructure)(object)null;
	}

	private StatsComponentStructure method_5()
	{
		return (StatsComponentStructure)(object)null;
	}

	internal static Dictionary<StatTypeGGG, int> smethod_4(long long_2, bool bool_0 = true)
	{
		return null;
	}

	[Obsolete("Use ReadNativeStatGraph: native inherited/computed statistics require class-aware traversal.")]
	internal static Dictionary<StatTypeGGG, int> smethod_5(StatsDictionaryStructure statsDictionaryStructure_0, StatsDictionaryStructure statsDictionaryStructure_1 = default(StatsDictionaryStructure))
	{
		return null;
	}

	internal static bool smethod_6()
	{
		return true;
	}

	internal static Stats smethod_7()
	{
		return null;
	}

	static Stats()
	{
		Class200.smethod_34();
	}
}
