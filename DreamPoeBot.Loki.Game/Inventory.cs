using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Objects;
using ns0;

namespace DreamPoeBot.Loki.Game;

public class Inventory : RemoteMemoryObject
{
	public class HashNodeStruct242 : RemoteMemoryObject
	{
		internal static HashNodeStruct242 hashNodeStruct242_0;

		public HashNodeStruct242 Previous => null;

		public HashNodeStruct242 Root => null;

		public HashNodeStruct242 Next => null;

		public bool IsNull => true;

		public int Key => 0;

		internal long Value1 => 0L;

		internal static bool smethod_2()
		{
			return true;
		}

		internal static HashNodeStruct242 smethod_3()
		{
			return null;
		}

		static HashNodeStruct242()
		{
			Class200.smethod_34();
		}
	}

	private List<ushort> list_0;

	private string string_0;

	private bool bool_0;

	private bool bool_1;

	private Vector2i? nullable_0;

	[CompilerGenerated]
	private int int_0;

	private static Inventory inventory_0;

	public int Id
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		internal set
		{
		}
	}

	public bool IsRequested => true;

	public InventoryType PageType => (InventoryType)(object)null;

	public InventorySlot PageSlot => (InventorySlot)(object)null;

	public Dictionary<int, Item> ItemMap => null;

	public List<Item> Items => null;

	public int Rows => 0;

	public int Cols => 0;

	public int Columns => 0;

	public int InventorySpacePercent => 0;

	public int AvailableInventorySquares => 0;

	internal Inventory(long inventoryPageContents, int id)
	{
	}

	internal Inventory(long inventoryPageContents)
	{
	}

	internal Inventory(long inventoryPageContents, string heistLockerMetadata)
	{
	}

	internal Inventory(long inventoryPageContents, bool isEldrichTab = false, bool isMavenTab = false, List<ushort> storableBaseItemTypeKeys = null)
	{
	}

	private Dictionary<int, long> method_0(long long_1, uint uint_0)
	{
		return null;
	}

	[SpecialName]
	internal Struct11 method_1()
	{
		return (Struct11)(object)null;
	}

	private bool method_2(int int_1)
	{
		return true;
	}

	public Item FindItemByPos(Vector2i pos)
	{
		return null;
	}

	public Item GetItemById(int id)
	{
		return null;
	}

	public bool NextAvailableInventoryPosition(int w, int h, out Vector2i pos)
	{
		return true;
	}

	public bool[,] GetItemPlacementGraph()
	{
		return null;
	}

	public bool CanFitItemAt(int col, int row, int width, int height, bool allowOverlap, out bool overlapped)
	{
		return true;
	}

	public Item GetItemAtLocation(Vector2i pos)
	{
		return null;
	}

	public Item GetItemAtLocation(int col, int row)
	{
		return null;
	}

	public bool CanFitItem(Item item)
	{
		return true;
	}

	internal void method_3(int int_1)
	{
	}

	internal void method_4(Vector2i vector2i_0)
	{
	}

	public bool CanFitItem(Item item, out int col, out int row)
	{
		return true;
	}

	public bool CanFitItem(Vector2i itemSize, out int col, out int row)
	{
		return true;
	}

	public bool CanFitItem(Vector2i itemSize)
	{
		return true;
	}

	public bool CanFitItem(int itemWidth, int itemHeight, out int fcol, out int frow)
	{
		return true;
	}

	public bool CanSlideItemUpOrLeft(Item item)
	{
		return true;
	}

	public bool CanFitItemSizeAt(int itemWidth, int itemHeight, int col, int row)
	{
		return true;
	}

	public Item FindItemByFullName(string fullName)
	{
		return null;
	}

	public Item FindItemByName(string name)
	{
		return null;
	}

	private int method_5(IEnumerable<Item> ienumerable_0)
	{
		return 0;
	}

	public int GetTotalItemQuantityByName(string name)
	{
		return 0;
	}

	public int GetTotalItemQuantityByFullName(string fullName)
	{
		return 0;
	}

	public int GetTotalItemQuantityByMetadata(string metadata)
	{
		return 0;
	}

	public int GetTotalItemQuantityByMetadataFlags(MetadataFlags flag)
	{
		return 0;
	}

	public int GetTotalItemStacksByFullName(string fullName)
	{
		return 0;
	}

	public bool NeedsToMerge()
	{
		return true;
	}

	public override string ToString()
	{
		return null;
	}

	[CompilerGenerated]
	private bool method_6(KeyValuePair<int, Item> keyValuePair_0)
	{
		return true;
	}

	[CompilerGenerated]
	private bool method_7(KeyValuePair<int, Item> keyValuePair_0)
	{
		return true;
	}

	[CompilerGenerated]
	private bool method_8(Item item_0)
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
