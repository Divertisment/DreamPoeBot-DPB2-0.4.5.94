using DreamPoeBot.Loki.Models.Enums;
using ns0;

namespace DreamPoeBot.Loki.RemoteMemoryObjects;

public class InventoryList : RemoteMemoryObject
{
	internal static InventoryList inventoryList_0;

	public static int InventoryCount => 0;

	public Inventory this[InventoryIndex inv] => null;

	internal static bool smethod_2()
	{
		return true;
	}

	internal static InventoryList smethod_3()
	{
		return null;
	}

	static InventoryList()
	{
		Class200.smethod_34();
	}
}
