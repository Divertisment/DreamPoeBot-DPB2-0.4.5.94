using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Game;
using DreamPoeBot.Loki.RemoteMemoryObjects;
using ns0;

namespace DreamPoeBot.Loki.Elements;

public class PurchasePanellElement : Element
{
	private static PurchasePanellElement purchasePanellElement_0;

	public long TotalStashes => 0L;

	public Element ViewAllStashPanel => null;

	public Element StashInventoryPanel => null;

	public int IndexVisibleStash => 0;

	public DreamPoeBot.Loki.RemoteMemoryObjects.Inventory VisibleStash => null;

	public string VisibleStashName => null;

	public List<string> AllStashNames => null;

	public DreamPoeBot.Loki.Game.Inventory VisibleStashInventory => null;

	private DreamPoeBot.Loki.RemoteMemoryObjects.Inventory method_29()
	{
		return null;
	}

	public DreamPoeBot.Loki.RemoteMemoryObjects.Inventory GetStashInventoryByIndex(int index)
	{
		return null;
	}

	private List<string> method_30()
	{
		return null;
	}

	public string GetStashName(int index)
	{
		return null;
	}

	[CompilerGenerated]
	private bool method_31(Element element_2)
	{
		return true;
	}

	internal static bool smethod_11()
	{
		return true;
	}

	internal static PurchasePanellElement smethod_12()
	{
		return null;
	}

	static PurchasePanellElement()
	{
		Class200.smethod_34();
	}
}
