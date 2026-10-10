using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Game.Std;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class Inventories : Component
{
	private static Inventories inventories_0;

	public InventoryVisual LeftHand => null;

	public InventoryVisual RightHand => null;

	public InventoryVisual Chest => null;

	public InventoryVisual Helm => null;

	public InventoryVisual Gloves => null;

	public InventoryVisual Boots => null;

	public InventoryVisual Unknown => null;

	public InventoryVisual LeftRing => null;

	public InventoryVisual RightRing => null;

	public InventoryVisual Belt => null;

	[SpecialName]
	private NativeVector method_2()
	{
		return (NativeVector)(object)null;
	}

	internal InventoryVisual method_3(int int_0)
	{
		return null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static Inventories smethod_5()
	{
		return null;
	}

	static Inventories()
	{
		Class200.smethod_34();
	}
}
