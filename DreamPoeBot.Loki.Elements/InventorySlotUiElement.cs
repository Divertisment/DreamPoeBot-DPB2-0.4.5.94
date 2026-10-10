using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Game.Objects;
using DreamPoeBot.Loki.Models.Enums;
using ns0;

namespace DreamPoeBot.Loki.Elements;

public class InventorySlotUiElement : Element
{
	public float slotsize;

	private Vector2i? nullable_0;

	private double double_0;

	private StashType stashType_0;

	private string string_0;

	public static int id_offset;

	public static int item_offset;

	internal static InventorySlotUiElement inventorySlotUiElement_0;

	public int ItemsCount => 0;

	public Dictionary<Vector2i, Item> PlacementGraph => null;

	public Dictionary<Vector2i, Dictionary<int, Vector2i>> SocketDictionary => null;

	public Vector2i LocationTopLeft => (Vector2i)(object)null;

	public Vector2i Size => (Vector2i)(object)null;

	public Dictionary<int, Element> DictionaryIdElements => null;

	public Vector2i RewardLocationTopLeft => (Vector2i)(object)null;

	internal void method_29(int int_3, int int_4)
	{
	}

	public InventorySlotUiElement()
	{
	}

	public InventorySlotUiElement(long address, StashType stashType, string heistLockerMetadata = "")
	{
	}

	public void SetStashType(StashType stashType)
	{
	}

	internal static bool smethod_11(Element element_2)
	{
		return true;
	}

	internal static bool smethod_12(Element element_2, bool bool_0)
	{
		return true;
	}

	[SpecialName]
	private List<Vector2i> method_30()
	{
		return null;
	}

	internal bool method_31(int int_3, long long_5, out Vector2i vector2i_0)
	{
		return true;
	}

	public Vector2i SlotClickLocation(Vector2i slot)
	{
		return (Vector2i)(object)null;
	}

	public Vector2i RewardSlotClickLocation(Vector2i slot)
	{
		return (Vector2i)(object)null;
	}

	static InventorySlotUiElement()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		id_offset = 1864;
		item_offset = 1248;
	}

	internal static bool smethod_13()
	{
		return true;
	}

	internal static InventorySlotUiElement smethod_14()
	{
		return null;
	}
}
