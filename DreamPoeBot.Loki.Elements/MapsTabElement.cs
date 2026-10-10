using System.Collections.Generic;
using DreamPoeBot.Loki.Game;
using ns0;

namespace DreamPoeBot.Loki.Elements;

public class MapsTabElement : Element
{
	public class TierElementClass : Element
	{
		private static TierElementClass tierElementClass_0;

		public bool IsSelected => true;

		public int NrOfMaps => 0;

		internal static bool smethod_11()
		{
			return true;
		}

		internal static TierElementClass smethod_12()
		{
			return null;
		}

		static TierElementClass()
		{
			Class200.smethod_34();
		}
	}

	public class MapsInventory : Element
	{
		private TabControlWrapper tabControlWrapper_0;

		private static MapsInventory mapsInventory_0;

		public TabControlWrapper TabControl => null;

		public InventoryControlWrapper InventoryControl(bool isGuildStash)
		{
			return null;
		}

		internal static bool smethod_11()
		{
			return true;
		}

		internal static MapsInventory smethod_12()
		{
			return null;
		}

		static MapsInventory()
		{
			Class200.smethod_34();
		}
	}

	private static MapsTabElement mapsTabElement_0;

	public List<MapsInventory> MapsInventories => null;

	public bool IsTiersListLoaded => true;

	public bool IsFakeInventoryVisible => true;

	public List<TierElementClass> TiersList => null;

	internal static bool smethod_11()
	{
		return true;
	}

	internal static MapsTabElement smethod_12()
	{
		return null;
	}

	static MapsTabElement()
	{
		Class200.smethod_34();
	}
}
