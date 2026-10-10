using DreamPoeBot.Loki.Game.Utilities;
using DreamPoeBot.Loki.RemoteMemoryObjects;
using ns0;

namespace DreamPoeBot.Loki.Elements;

public class MerchantPanelElement : Element
{
	internal static long long_5;

	private PerAreaCachedValue<Element> perAreaCachedValue_0;

	internal static MerchantPanelElement merchantPanelElement_0;

	public Element UpperMainControl => null;

	public Element UpperPageContainer => null;

	public byte IndexVisibleUpperTab => 0;

	public Element LowerMainControl => null;

	public Element TabListButton => null;

	public Element LowerPageContainer => null;

	public byte IndexVisibleLowerTab => 0;

	public Inventory GetVisibleLowerTabInventory => null;

	private Element GetMainControl()
	{
		return null;
	}

	public Element GetLowerTabControlByIndex(int index)
	{
		return null;
	}

	public Inventory GetLowerTabInventoryByIndex(int index)
	{
		return null;
	}

	static MerchantPanelElement()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		long_5 = StashElement.long_5;
	}

	internal static bool smethod_11()
	{
		return true;
	}

	internal static MerchantPanelElement smethod_12()
	{
		return null;
	}
}
