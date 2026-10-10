using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Game.Utilities;
using DreamPoeBot.Loki.RemoteMemoryObjects;
using ns0;

namespace DreamPoeBot.Loki.Elements;

public class StashElement : Element
{
	internal static long long_5;

	private PerAreaCachedValue<Element> perAreaCachedValue_0;

	private PerAreaCachedValue<Element> perAreaCachedValue_1;

	private PerAreaCachedValue<Element> perAreaCachedValue_2;

	private PerAreaCachedValue<Element> perAreaCachedValue_3;

	private static StashElement stashElement_0;

	public long TotalStashes => 0L;

	public string SearchElementText => null;

	public Element SearchElement => null;

	public Element SearchCloseElement => null;

	public Element StashOptionsElement => null;

	public Element MainControl => null;

	public bool HideRemoveOnlyTabs => true;

	public Element TabListButton => null;

	public bool IsTabListButtonVisible => true;

	public List<Element> UpperTabsContainer => null;

	public float UpperTabContainerXOffset => 0f;

	public Element RightTabsContainerElement => null;

	public float RightTabsContainerYOffset => 0f;

	public float RightTabsContainerHeight => 0f;

	public Element RightTabsContainerScrollUp => null;

	public Element RightTabsContainerScrollDown => null;

	public bool IsRightTabsContainerElementVisible => true;

	public List<Element> RightButtonContainer => null;

	public Element StashInventoryPanel => null;

	public Element GetStashInventoryPanel => null;

	public byte IndexVisibleStash => 0;

	public Inventory VisibleStash => null;

	internal bool method_29(out int int_3, out Element element_2)
	{
		return true;
	}

	private Element GetMainControl()
	{
		return null;
	}

	private Element GetStashOptionsElement()
	{
		return null;
	}

	private Element GetSearchCloseElement()
	{
		return null;
	}

	private Element GetSearchElement()
	{
		return null;
	}

	private Inventory method_30()
	{
		return null;
	}

	public Inventory GetStashInventoryByIndex(int index)
	{
		return null;
	}

	internal static bool smethod_11(Element element_2)
	{
		return true;
	}

	[SpecialName]
	internal MapsTabElement method_31()
	{
		return null;
	}

	static StashElement()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		long_5 = 856L;
	}

	internal static bool smethod_12()
	{
		return true;
	}

	internal static StashElement smethod_13()
	{
		return null;
	}
}
