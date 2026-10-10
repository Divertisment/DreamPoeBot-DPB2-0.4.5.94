using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Game;
using DreamPoeBot.Loki.Game.Objects;
using DreamPoeBot.Loki.Models.Enums;
using ns0;

namespace DreamPoeBot.Loki.RemoteMemoryObjects;

public class Inventory : RemoteMemoryObject
{
	private StashType stashType_0;

	internal static Inventory inventory_0;

	public int Id => 0;

	public long ItemsCount => 0L;

	public long TotalBoxesInInventoryRow => 0L;

	public long TotalBoxesInInventoryCol => 0L;

	public int CurrentPlayerInventoriesId => 0;

	public Element InventoryUiElement => null;

	public Element MapInvetoryElement => null;

	public List<Item> Items => null;

	[SpecialName]
	private Element method_0()
	{
		return null;
	}

	[SpecialName]
	private DreamPoeBot.Loki.Game.Inventory method_1()
	{
		return null;
	}

	public Inventory()
	{
	}

	public Inventory(long address)
	{
	}

	public Inventory(long address, StashType invType)
	{
	}

	private StashType method_2()
	{
		return (StashType)(object)null;
	}

	[SpecialName]
	private StashType method_3()
	{
		return (StashType)(object)null;
	}

	private Element method_4()
	{
		return null;
	}

	[CompilerGenerated]
	private bool method_5(Element element_0)
	{
		return true;
	}

	[CompilerGenerated]
	private bool method_6(Element element_0)
	{
		return true;
	}

	[CompilerGenerated]
	private bool method_7(Element element_0)
	{
		return true;
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static Inventory smethod_3()
	{
		return null;
	}

	static Inventory()
	{
		Class200.smethod_34();
	}
}
