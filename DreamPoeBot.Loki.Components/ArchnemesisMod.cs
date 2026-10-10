using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class ArchnemesisMod : Component
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct183
	{
		private long long_0;

		private long long_1;

		private long long_2;

		public long long_3;

		private long long_4;
	}

	private PerFrameCachedValue<Struct183> perFrameCachedValue_0;

	private PerFrameCachedValue<DatArchnemesisModWrapper> perFrameCachedValue_1;

	private static ArchnemesisMod archnemesisMod_0;

	public List<string> RewardList => null;

	public DatModsWrapper ModWrapper => null;

	[SpecialName]
	internal Struct183 method_2()
	{
		return (Struct183)(object)null;
	}

	[SpecialName]
	internal Struct183 method_3()
	{
		return (Struct183)(object)null;
	}

	[SpecialName]
	internal DatArchnemesisModWrapper method_4()
	{
		return null;
	}

	internal DatArchnemesisModWrapper method_5()
	{
		return null;
	}

	[CompilerGenerated]
	private Struct183 method_6()
	{
		return (Struct183)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static ArchnemesisMod smethod_5()
	{
		return null;
	}

	static ArchnemesisMod()
	{
		Class200.smethod_34();
	}
}
