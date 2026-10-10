using System.Collections.Generic;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Game.Objects;
using ns0;

namespace DreamPoeBot.Loki.Elements;

public class SingleSlotUiElement : Element
{
	public enum SingleSlotType
	{
		inventory,
		Currency,
		Essence,
		Card,
		Fragment,
		Map,
		ExplorationLocker,
		FiveSlotMapDevice,
		BlightTabMap,
		MapDevice,
		RogueMarker,
		ReforgingBench,
		GenesisTreeWomb
	}

	private SingleSlotType singleSlotType_0;

	private static int int_3;

	private static int int_4;

	internal static SingleSlotUiElement singleSlotUiElement_0;

	private Vector2 SlotSize => (Vector2)(object)null;

	public Item Item => null;

	public Element ItemElement => null;

	public int SocketCount => 0;

	public Dictionary<int, Vector2i> SocketsLocations => null;

	public Vector2i LocationTopLeft => (Vector2i)(object)null;

	public Vector2i Size => (Vector2i)(object)null;

	public SingleSlotUiElement()
	{
	}

	public SingleSlotUiElement(Element element, SingleSlotType slotType = SingleSlotType.inventory)
	{
	}

	public SingleSlotUiElement(long elementAddress, SingleSlotType slotType = SingleSlotType.inventory)
	{
	}

	static SingleSlotUiElement()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		int_3 = InventorySlotUiElement.id_offset;
		int_4 = InventorySlotUiElement.item_offset;
	}

	internal static bool smethod_11()
	{
		return true;
	}

	internal static SingleSlotUiElement smethod_12()
	{
		return null;
	}
}
