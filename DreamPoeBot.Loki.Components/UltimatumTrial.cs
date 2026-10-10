using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class UltimatumTrial : Component
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct Struct265
	{
		public long xGepGiqburG;

		public long long_0;

		public int Level;

		public int int_0;

		public long long_1;

		public long long_2;

		public long long_3;

		public long long_4;

		public NativeList nativeList_0;

		public long long_5;

		public long long_6;
	}

	private PerFrameCachedValue<Struct265> perFrameCachedValue_0;

	internal static UltimatumTrial ultimatumTrial_0;

	public int AreaLevel => 0;

	public string Challenge => null;

	public DatBaseItemTypeWrapper RequireSecrifice => null;

	public string Reward => null;

	public DatUltimatumEncounterWrapper DatUltimatumEncounter => null;

	public DatUltimatumItemisedRewardWrapper DatUltimatumItemisedReward => null;

	public List<DatUltimatumModifiersWrapper> DatUltimatumModifiers => null;

	[SpecialName]
	private Struct265 method_2()
	{
		return (Struct265)(object)null;
	}

	private Struct265 method_3()
	{
		return (Struct265)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static UltimatumTrial smethod_5()
	{
		return null;
	}

	static UltimatumTrial()
	{
		Class200.smethod_34();
	}
}
