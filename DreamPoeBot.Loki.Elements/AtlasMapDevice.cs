using System;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.RemoteMemoryObjects;
using ns0;

namespace DreamPoeBot.Loki.Elements;

public class AtlasMapDevice : Element
{
	private int int_3;

	internal static AtlasMapDevice atlasMapDevice_0;

	[Obsolete("Obsolete, use WaystoneSlot, TabletSlot1, TabletSlot2, TabletSlot3", false)]
	public Inventory Inventory => null;

	public Inventory WaystoneSlot => null;

	public Inventory TabletSlot1 => null;

	public bool TabletSlot1Enabled => true;

	public Inventory TabletSlot2 => null;

	public bool TabletSlot2Enabled => true;

	public Inventory TabletSlot3 => null;

	public bool TabletSlot3Enabled => true;

	public Inventory TabletSlot4 => null;

	public bool TabletSlot4Enabled => true;

	public string MapName => null;

	public string MapBiome => null;

	public string MapStats => null;

	public Element TraverseButton => null;

	public bool IsTierSelectorVisible => true;

	public int SelectedTier => 0;

	[SpecialName]
	private Element method_29()
	{
		return null;
	}

	[SpecialName]
	private Element method_30()
	{
		return null;
	}

	[SpecialName]
	private Element method_31()
	{
		return null;
	}

	[SpecialName]
	private Element method_32()
	{
		return null;
	}

	public bool SelectTier(int tier)
	{
		return true;
	}

	internal static bool smethod_11()
	{
		return true;
	}

	internal static AtlasMapDevice smethod_12()
	{
		return null;
	}

	static AtlasMapDevice()
	{
		Class200.smethod_34();
	}
}
