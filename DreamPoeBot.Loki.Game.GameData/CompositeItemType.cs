using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ns0;

namespace DreamPoeBot.Loki.Game.GameData;

public class CompositeItemType
{
	[CompilerGenerated]
	private readonly ItemTypes VhQuOjkocc;

	[CompilerGenerated]
	private readonly ArmorTypes armorTypes_0;

	[CompilerGenerated]
	private readonly WeaponTypes weaponTypes_0;

	[CompilerGenerated]
	private readonly WeaponHandTypes weaponHandTypes_0;

	[CompilerGenerated]
	private readonly FlaskTypes flaskTypes_0;

	internal static readonly CompositeItemType CoPuEiBfJu;

	internal static readonly Dictionary<string, CompositeItemType> dictionary_0;

	internal static CompositeItemType compositeItemType_0;

	public ItemTypes ItemType
	{
		[CompilerGenerated]
		get
		{
			return (ItemTypes)(object)null;
		}
	}

	public ArmorTypes ArmorType
	{
		[CompilerGenerated]
		get
		{
			return (ArmorTypes)(object)null;
		}
	}

	public WeaponTypes WeaponType
	{
		[CompilerGenerated]
		get
		{
			return (WeaponTypes)(object)null;
		}
	}

	public WeaponHandTypes WeaponHandType
	{
		[CompilerGenerated]
		get
		{
			return (WeaponHandTypes)(object)null;
		}
	}

	public FlaskTypes FlaskType
	{
		[CompilerGenerated]
		get
		{
			return (FlaskTypes)(object)null;
		}
	}

	internal CompositeItemType(ItemTypes itemType, ArmorTypes armorType, WeaponTypes weaponType, WeaponHandTypes weaponHandType, FlaskTypes flaskType)
	{
	}

	public override string ToString()
	{
		return null;
	}

	static CompositeItemType()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		CoPuEiBfJu = new CompositeItemType(ItemTypes.Unknown, ArmorTypes.NonArmor, WeaponTypes.NonWeapon, WeaponHandTypes.NonWeapon, FlaskTypes.NonFlask);
		dictionary_0 = new Dictionary<string, CompositeItemType>
		{
			{
				Class200.smethod_20(490954),
				new CompositeItemType(ItemTypes.Armor, ArmorTypes.BodyArmor, WeaponTypes.NonWeapon, WeaponHandTypes.NonWeapon, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(490980),
				new CompositeItemType(ItemTypes.Armor, ArmorTypes.Helmet, WeaponTypes.NonWeapon, WeaponHandTypes.NonWeapon, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(73094),
				new CompositeItemType(ItemTypes.Armor, ArmorTypes.Gloves, WeaponTypes.NonWeapon, WeaponHandTypes.NonWeapon, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(73110),
				new CompositeItemType(ItemTypes.Armor, ArmorTypes.Boots, WeaponTypes.NonWeapon, WeaponHandTypes.NonWeapon, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(70780),
				new CompositeItemType(ItemTypes.Armor, ArmorTypes.Shield, WeaponTypes.NonWeapon, WeaponHandTypes.NonWeapon, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(490996),
				new CompositeItemType(ItemTypes.Weapon, ArmorTypes.NonArmor, WeaponTypes.Dagger, WeaponHandTypes.OneHanded, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(491012),
				new CompositeItemType(ItemTypes.Weapon, ArmorTypes.NonArmor, WeaponTypes.Claw, WeaponHandTypes.OneHanded, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(491024),
				new CompositeItemType(ItemTypes.Weapon, ArmorTypes.NonArmor, WeaponTypes.Bow, WeaponHandTypes.TwoHanded, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(491034),
				new CompositeItemType(ItemTypes.Weapon, ArmorTypes.NonArmor, WeaponTypes.Wand, WeaponHandTypes.OneHanded, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(491046),
				new CompositeItemType(ItemTypes.Weapon, ArmorTypes.NonArmor, WeaponTypes.Staff, WeaponHandTypes.TwoHanded, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(491060),
				new CompositeItemType(ItemTypes.Weapon, ArmorTypes.NonArmor, WeaponTypes.Axe1H, WeaponHandTypes.OneHanded, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(491088),
				new CompositeItemType(ItemTypes.Weapon, ArmorTypes.NonArmor, WeaponTypes.Axe2H, WeaponHandTypes.TwoHanded, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(491116),
				new CompositeItemType(ItemTypes.Weapon, ArmorTypes.NonArmor, WeaponTypes.Mace1H, WeaponHandTypes.OneHanded, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(491146),
				new CompositeItemType(ItemTypes.Weapon, ArmorTypes.NonArmor, WeaponTypes.Sceptre, WeaponHandTypes.OneHanded, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(491164),
				new CompositeItemType(ItemTypes.Weapon, ArmorTypes.NonArmor, WeaponTypes.Mace2H, WeaponHandTypes.TwoHanded, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(491194),
				new CompositeItemType(ItemTypes.Weapon, ArmorTypes.NonArmor, WeaponTypes.Sword1H, WeaponHandTypes.OneHanded, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(491226),
				new CompositeItemType(ItemTypes.Weapon, ArmorTypes.NonArmor, WeaponTypes.SwordThrusting, WeaponHandTypes.OneHanded, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(491278),
				new CompositeItemType(ItemTypes.Weapon, ArmorTypes.NonArmor, WeaponTypes.Sword2H, WeaponHandTypes.TwoHanded, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(73166),
				new CompositeItemType(ItemTypes.Belt, ArmorTypes.NonArmor, WeaponTypes.NonWeapon, WeaponHandTypes.NonWeapon, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(491310),
				new CompositeItemType(ItemTypes.Quiver, ArmorTypes.NonArmor, WeaponTypes.NonWeapon, WeaponHandTypes.NonWeapon, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(491326),
				new CompositeItemType(ItemTypes.Ring, ArmorTypes.NonArmor, WeaponTypes.NonWeapon, WeaponHandTypes.NonWeapon, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(491338),
				new CompositeItemType(ItemTypes.Amulet, ArmorTypes.NonArmor, WeaponTypes.NonWeapon, WeaponHandTypes.NonWeapon, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(491354),
				new CompositeItemType(ItemTypes.Flask, ArmorTypes.NonArmor, WeaponTypes.NonWeapon, WeaponHandTypes.NonWeapon, FlaskTypes.Life)
			},
			{
				Class200.smethod_20(491376),
				new CompositeItemType(ItemTypes.Flask, ArmorTypes.NonArmor, WeaponTypes.NonWeapon, WeaponHandTypes.NonWeapon, FlaskTypes.Mana)
			},
			{
				Class200.smethod_20(491398),
				new CompositeItemType(ItemTypes.Flask, ArmorTypes.NonArmor, WeaponTypes.NonWeapon, WeaponHandTypes.NonWeapon, FlaskTypes.Hybrid)
			},
			{
				Class200.smethod_20(491424),
				new CompositeItemType(ItemTypes.Flask, ArmorTypes.NonArmor, WeaponTypes.NonWeapon, WeaponHandTypes.NonWeapon, FlaskTypes.Utility)
			},
			{
				Class200.smethod_20(491452),
				new CompositeItemType(ItemTypes.Flask, ArmorTypes.NonArmor, WeaponTypes.NonWeapon, WeaponHandTypes.NonWeapon, FlaskTypes.Utility)
			},
			{
				Class200.smethod_20(491496),
				new CompositeItemType(ItemTypes.Currency, ArmorTypes.NonArmor, WeaponTypes.NonWeapon, WeaponHandTypes.NonWeapon, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(491534),
				new CompositeItemType(ItemTypes.Gem, ArmorTypes.NonArmor, WeaponTypes.NonWeapon, WeaponHandTypes.NonWeapon, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(491570),
				new CompositeItemType(ItemTypes.Gem, ArmorTypes.NonArmor, WeaponTypes.NonWeapon, WeaponHandTypes.NonWeapon, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(71184),
				new CompositeItemType(ItemTypes.Map, ArmorTypes.NonArmor, WeaponTypes.NonWeapon, WeaponHandTypes.NonWeapon, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(491608),
				new CompositeItemType(ItemTypes.MapFragment, ArmorTypes.NonArmor, WeaponTypes.NonWeapon, WeaponHandTypes.NonWeapon, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(491634),
				new CompositeItemType(ItemTypes.MapFragment, ArmorTypes.NonArmor, WeaponTypes.NonWeapon, WeaponHandTypes.NonWeapon, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(491670),
				new CompositeItemType(ItemTypes.MapFragment, ArmorTypes.NonArmor, WeaponTypes.NonWeapon, WeaponHandTypes.NonWeapon, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(491696),
				new CompositeItemType(ItemTypes.Jewel, ArmorTypes.NonArmor, WeaponTypes.NonWeapon, WeaponHandTypes.NonWeapon, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(491710),
				new CompositeItemType(ItemTypes.DivinationCard, ArmorTypes.NonArmor, WeaponTypes.NonWeapon, WeaponHandTypes.NonWeapon, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(491742),
				new CompositeItemType(ItemTypes.Quest, ArmorTypes.NonArmor, WeaponTypes.NonWeapon, WeaponHandTypes.NonWeapon, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(491764),
				new CompositeItemType(ItemTypes.IncursionItem, ArmorTypes.NonArmor, WeaponTypes.NonWeapon, WeaponHandTypes.NonWeapon, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(491794),
				new CompositeItemType(ItemTypes.LabyrinthItem, ArmorTypes.NonArmor, WeaponTypes.NonWeapon, WeaponHandTypes.NonWeapon, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(491824),
				new CompositeItemType(ItemTypes.LabyrinthItem, ArmorTypes.NonArmor, WeaponTypes.NonWeapon, WeaponHandTypes.NonWeapon, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(491860),
				new CompositeItemType(ItemTypes.Leaguestone, ArmorTypes.NonArmor, WeaponTypes.NonWeapon, WeaponHandTypes.NonWeapon, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(491886),
				new CompositeItemType(ItemTypes.FishingRod, ArmorTypes.NonArmor, WeaponTypes.NonWeapon, WeaponHandTypes.NonWeapon, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(491910),
				new CompositeItemType(ItemTypes.Microtransaction, ArmorTypes.NonArmor, WeaponTypes.NonWeapon, WeaponHandTypes.NonWeapon, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(491946),
				new CompositeItemType(ItemTypes.HideoutDoodad, ArmorTypes.NonArmor, WeaponTypes.NonWeapon, WeaponHandTypes.NonWeapon, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(491976),
				new CompositeItemType(ItemTypes.PantheonSoul, ArmorTypes.NonArmor, WeaponTypes.NonWeapon, WeaponHandTypes.NonWeapon, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(492004),
				new CompositeItemType(ItemTypes.UniqueFragment, ArmorTypes.NonArmor, WeaponTypes.NonWeapon, WeaponHandTypes.NonWeapon, FlaskTypes.NonFlask)
			},
			{
				Class200.smethod_20(492036),
				new CompositeItemType(ItemTypes.AbyssJewel, ArmorTypes.NonArmor, WeaponTypes.NonWeapon, WeaponHandTypes.NonWeapon, FlaskTypes.NonFlask)
			}
		};
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static CompositeItemType smethod_1()
	{
		return null;
	}
}
