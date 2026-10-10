using System;
using System.Collections.Generic;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Models;
using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

public class Monolith : NetworkObject
{
	public const string TypeMetadata = "Metadata/MiscellaneousObjects/Monolith";

	private string string_2;

	private int int_0;

	private static Monolith monolith_0;

	private new Element Ui => null;

	public List<Item> UpgradeOptions => null;

	public int ChildNetworkObjectId => 0;

	public NetworkObject ChildNetworkObject => null;

	public int OpenPhase => 0;

	public bool IsCorrupted => true;

	public virtual bool IsMini => true;

	public string MonsterTypeId => null;

	public string MonsterTypeMetadata => null;

	public List<DatBaseItemTypeWrapper> EssenceBaseItemTypes => null;

	public override string Name => null;

	internal Monolith(EntityWrapper entry)
	{
	}

	internal Monolith(NetworkObject entry)
	{
	}

	public bool Upgrade(string itemName)
	{
		return true;
	}

	internal static bool smethod_24(bool bool_0, Func<(bool, bool)> func_0, Func<bool> func_1)
	{
		return true;
	}

	public override string ToString()
	{
		return null;
	}

	public new string Dump()
	{
		return null;
	}

	internal static bool smethod_25()
	{
		return true;
	}

	internal static Monolith smethod_26()
	{
		return null;
	}

	static Monolith()
	{
		Class200.smethod_34();
	}
}
