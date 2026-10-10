using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class LocalStats : Component
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 56)]
	internal struct Struct226
	{
		internal Struct14 struct14_0;

		public long long_0;

		public Class84.Struct18 struct18_0;
	}

	private PerFrameCachedValue<Struct226> perFrameCachedValue_0;

	private static LocalStats localStats_0;

	public Dictionary<StatTypeGGG, int> StatDictionary => null;

	[Obsolete("DA RITESTARE: legacy +0 is a component vtable, not a stat entry. Use StatDictionary.")]
	public int Type => 0;

	[Obsolete("DA RITESTARE: legacy +4 is inside the vtable pointer, not a stat value. Use StatDictionary.")]
	public int Value => 0;

	public Dictionary<StatTypeGGG, int> Stats => null;

	public LocalStats()
	{
	}

	public LocalStats(long address)
	{
	}

	public int GetStat(StatTypeGGG stat)
	{
		return 0;
	}

	[SpecialName]
	internal Struct226 method_2()
	{
		return (Struct226)(object)null;
	}

	private Struct226 method_3()
	{
		return (Struct226)(object)null;
	}

	[SpecialName]
	internal Class84 method_4()
	{
		return null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static LocalStats smethod_5()
	{
		return null;
	}

	static LocalStats()
	{
		Class200.smethod_34();
	}
}
