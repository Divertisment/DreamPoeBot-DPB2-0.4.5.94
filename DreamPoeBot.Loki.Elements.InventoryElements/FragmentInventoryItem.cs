using ns0;
using SharpDX;

namespace DreamPoeBot.Loki.Elements.InventoryElements;

public class FragmentInventoryItem : NormalInventoryItem
{
	private static FragmentInventoryItem fragmentInventoryItem_0;

	public override int InventPosX => 0;

	public override int InventPosY => 0;

	public override RectangleF GetClientRect()
	{
		return (RectangleF)(object)null;
	}

	internal static bool smethod_13()
	{
		return true;
	}

	internal static FragmentInventoryItem smethod_14()
	{
		return null;
	}

	static FragmentInventoryItem()
	{
		Class200.smethod_34();
	}
}
