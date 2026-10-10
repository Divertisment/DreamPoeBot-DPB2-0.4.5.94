using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.NativeWrappers;
using DreamPoeBot.Loki.Game.Utilities;
using DreamPoeBot.Loki.Models;
using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

public class Monster : Actor
{
	private PerFrameCachedValue<bool> perFrameCachedValue_6;

	private static Monster monster_0;

	public bool IsAliveHostile => true;

	public new bool CorpseUsable => true;

	public bool IsImprisoned => true;

	public bool IsActive => true;

	public bool IsActiveDead => true;

	public bool IsHidden => true;

	public Rarity Rarity => (Rarity)(object)null;

	public IEnumerable<DatModsWrapper> Affixes => null;

	public IEnumerable<DatModsWrapper> ImplicitAffixes => null;

	public IEnumerable<DatModsWrapper> ExplicitAffixes => null;

	public IEnumerable<StatContainer> ExplicitStats => null;

	public IEnumerable<StatContainer> ImplicitStats => null;

	public bool IsCursable => true;

	public bool HasSpeciesBeenNettedAlready => true;

	public bool IsSpeciesCapturableForBestiary => true;

	public bool HasBestiaryEnragedAura => true;

	public bool HasBestiaryTrappedAura => true;

	public bool HasBestiaryCapturedAura => true;

	public bool HasBestiaryDisappearingAura => true;

	public bool CannotDie => true;

	public List<string> Tags => null;

	public string MonsterTypeId => null;

	public string MonsterTypeMetadata => null;

	public int Level => 0;

	public List<string> BaseResistenceName => null;

	public bool IsMapBoss => true;

	public bool DropMetamorphosisIngredient => true;

	internal Monster(EntityWrapper entity)
	{
	}

	public new string Dump()
	{
		return null;
	}

	private bool method_12()
	{
		return true;
	}

	[CompilerGenerated]
	private bool method_13(MinimapIconWrapper minimapIconWrapper_0)
	{
		return true;
	}

	internal static bool smethod_26()
	{
		return true;
	}

	internal static Monster smethod_27()
	{
		return null;
	}

	static Monster()
	{
		Class200.smethod_34();
	}
}
