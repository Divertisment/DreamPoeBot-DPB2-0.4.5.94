using System;
using System.Collections.Generic;
using DreamPoeBot.Loki.Game.GameData;
using ns0;

namespace DreamPoeBot.Loki.RemoteMemoryObjects;

[Obsolete("Legacy pre-PoE2 layout, includes reads past current row0x74. Use DatGrantedEffectsPerLevelWrapper; DA RITESTARE before reuse.")]
public class GrantedEffectsPerLevel : RemoteMemoryObject
{
	internal static GrantedEffectsPerLevel grantedEffectsPerLevel_0;

	public SkillGemWrapper SkillGemWrapper => null;

	public int Level => 0;

	public int RequiredLevel => 0;

	public int ManaMultiplier => 0;

	public int ManaCost => 0;

	public int EffectivenessOfAddedDamage => 0;

	public int Cooldown => 0;

	public List<Tuple<DatStatWrapper, int>> Stats => null;

	public List<string> Tags => null;

	public List<Tuple<DatStatWrapper, int>> QualityStats => null;

	public List<DatStatWrapper> TypeStats => null;

	internal int method_0(int int_0)
	{
		return 0;
	}

	internal int method_1(int int_0)
	{
		return 0;
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static GrantedEffectsPerLevel smethod_3()
	{
		return null;
	}

	static GrantedEffectsPerLevel()
	{
		Class200.smethod_34();
	}
}
