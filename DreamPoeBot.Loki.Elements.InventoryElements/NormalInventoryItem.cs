using DreamPoeBot.Common;
using DreamPoeBot.Loki.Game.Objects;
using ns0;

namespace DreamPoeBot.Loki.Elements.InventoryElements;

public class NormalInventoryItem : Element
{
	private static NormalInventoryItem normalInventoryItem_0;

	public virtual int InventPosX => 0;

	public virtual int InventPosY => 0;

	public Item InnerItem => null;

	public Element ToolTip => null;

	public int StaskSize => 0;

	public Vector2i LocationTopLeft => (Vector2i)(object)null;

	public Vector2i LocationBottomRight => (Vector2i)(object)null;

	public int LocalId => 0;

	internal static bool smethod_11()
	{
		return true;
	}

	internal static NormalInventoryItem smethod_12()
	{
		return null;
	}

	static NormalInventoryItem()
	{
		Class200.smethod_34();
	}
}
