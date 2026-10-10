using System.Collections.Generic;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Utilities;
using DreamPoeBot.Loki.Models;
using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

public class Chest : NetworkObject
{
	private PerFrameCachedValue<int> perFrameCachedValue_4;

	private PerFrameCachedValue<bool> perFrameCachedValue_5;

	private PerFrameCachedValue<bool> perFrameCachedValue_6;

	private PerFrameCachedValue<bool> perFrameCachedValue_7;

	private PerFrameCachedValue<bool> perFrameCachedValue_8;

	private PerFrameCachedValue<bool> perFrameCachedValue_9;

	private PerFrameCachedValue<bool> perFrameCachedValue_10;

	private PerFrameCachedValue<bool> perFrameCachedValue_11;

	private PerFrameCachedValue<int> perFrameCachedValue_12;

	private PerFrameCachedValue<bool> perFrameCachedValue_13;

	private PerFrameCachedValue<bool> perFrameCachedValue_14;

	private PerFrameCachedValue<bool> perFrameCachedValue_15;

	private PerFrameCachedValue<bool> perFrameCachedValue_16;

	private PerFrameCachedValue<Rarity> perFrameCachedValue_17;

	private static Chest chest_0;

	private new Element Ui => null;

	public List<Item> UpgradeOptions => null;

	public int Quality => 0;

	public bool IsIdentified => true;

	public bool IsCorrupted => true;

	public bool IsOpened => true;

	public bool IsLocked => true;

	public bool IsVaalVessel => true;

	public bool IsStrongBox => true;

	public bool IsStompable => true;

	public int DropSlots => 0;

	public bool OpensOnDamage => true;

	public bool OpeningDestroys => true;

	public bool AxisAligned => true;

	public bool IsLarge => true;

	public Rarity Rarity => (Rarity)(object)null;

	public IEnumerable<DatModsWrapper> ImplicitAffixes => null;

	public IEnumerable<DatModsWrapper> ExplicitAffixes => null;

	public IEnumerable<StatContainer> ExplicitStats => null;

	public IEnumerable<StatContainer> ImplicitStats => null;

	internal Chest(EntityWrapper entity)
	{
	}

	public bool UpgradeChest(string itemName)
	{
		return true;
	}

	private int method_7()
	{
		return 0;
	}

	private bool method_8()
	{
		return true;
	}

	private bool method_9()
	{
		return true;
	}

	private bool method_10()
	{
		return true;
	}

	private bool method_11()
	{
		return true;
	}

	private bool method_12()
	{
		return true;
	}

	private bool method_13()
	{
		return true;
	}

	private bool method_14()
	{
		return true;
	}

	private int method_15()
	{
		return 0;
	}

	private bool method_16()
	{
		return true;
	}

	private bool method_17()
	{
		return true;
	}

	private bool method_18()
	{
		return true;
	}

	private bool method_19()
	{
		return true;
	}

	private Rarity method_20()
	{
		return (Rarity)(object)null;
	}

	internal static bool smethod_24()
	{
		return true;
	}

	internal static Chest smethod_25()
	{
		return null;
	}

	static Chest()
	{
		Class200.smethod_34();
	}
}
