using System;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Elements;
using DreamPoeBot.Loki.Models;
using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

public class WorldItem : NetworkObject
{
	private sealed class Class107
	{
		public uint uint_0;

		private static Class107 class107_0;

		internal bool method_0(Player player_0)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class107 smethod_1()
		{
			return null;
		}

		static Class107()
		{
			Class200.smethod_34();
		}
	}

	public class WorldItemLabelClass
	{
		private ItemsOnGroundLabelElement itemsOnGroundLabelElement_0;

		private WorldItem worldItem_0;

		private static WorldItemLabelClass worldItemLabelClass_0;

		public Vector2 Coordinate => (Vector2)(object)null;

		public Vector2 Size => (Vector2)(object)null;

		public WorldItem OwnerWorldItem => null;

		public Element Label => null;

		public bool IsLabelVisible => true;

		public WorldItemLabelClass(WorldItem worldItem, ItemsOnGroundLabelElement itemsOnGroundLabelElement)
		{
		}

		public void HideLabel()
		{
		}

		public void ShowLabel()
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static WorldItemLabelClass smethod_1()
		{
			return null;
		}

		static WorldItemLabelClass()
		{
			Class200.smethod_34();
		}
	}

	private Item item_0;

	private WorldItemLabelClass worldItemLabelClass_0;

	private static WorldItem worldItem_0;

	public bool HasVisibleHighlightLabel => true;

	public DateTime DroppedTime => (DateTime)(object)null;

	public TimeSpan AllocatedToOtherTime => (TimeSpan)(object)null;

	public DateTime PublicTime => (DateTime)(object)null;

	public bool HasAllocation => true;

	public Player AllocatedToPlayer => null;

	public bool IsAllocatedToOther => true;

	public Item Item => null;

	public WorldItemLabelClass WorldItemLabel => null;

	public WorldItem(EntityWrapper entity)
	{
	}

	public new string Dump()
	{
		return null;
	}

	public static bool GetClickableHighlightLabelDimensions(NetworkObject obj, out Vector2 coords, out Vector2 size, bool onlyVisible = true)
	{
		return true;
	}

	internal static bool smethod_24()
	{
		return true;
	}

	internal static WorldItem smethod_25()
	{
		return null;
	}

	static WorldItem()
	{
		Class200.smethod_34();
	}
}
