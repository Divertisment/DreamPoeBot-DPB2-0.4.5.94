using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Common;
using DreamPoeBot.Loki.Elements;
using DreamPoeBot.Loki.Game.NativeWrappers;
using DreamPoeBot.Loki.Game.Objects;
using DreamPoeBot.Loki.Models.Enums;
using DreamPoeBot.Loki.RemoteMemoryObjects;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Game;

public class InventoryControlWrapper : RemoteMemoryObject
{
	private sealed class Class55
	{
		internal Memory memory_0;

		internal long long_0;

		internal long long_1;

		internal long long_2;

		internal long long_3;

		internal long long_4;

		internal long long_5;

		internal int int_0;

		internal int int_1;

		internal ushort ushort_0;

		internal bool bool_0;

		internal Element element_0;

		internal static Class55 class55_0;

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class55 smethod_1()
		{
			return null;
		}

		static Class55()
		{
			Class200.smethod_34();
		}
	}

	private Class55 class55_0;

	private long long_1;

	private long long_2;

	private Memory memory_0;

	private InventoryControlFlagEnum inventoryControlFlagEnum_0;

	internal Vector2i vector2i_0;

	private static readonly ILog ilog_0;

	private List<ushort> list_0;

	private string string_0;

	private string string_1;

	private int int_0;

	private int int_1;

	public SingleSlotUiElement SingleSlotUiElement;

	public InventorySlotUiElement InventorySlotUiElement;

	[CompilerGenerated]
	private Inventory inventory_0;

	internal static InventoryControlWrapper inventoryControlWrapper_0;

	public string CustomTabMetadata => null;

	public string CustomTabItemName => null;

	public bool HasCustomTabOverride => true;

	public Item CustomTabItem => null;

	public Inventory Inventory => null;

	private int Id => 0;

	public InventoryControlWrapper()
	{
	}

	public InventoryControlWrapper(long control)
	{
	}

	internal void method_0(long long_3, long long_4)
	{
	}

	private bool method_1()
	{
		return true;
	}

	internal bool method_2(StashTabInfo stashTabInfo_0, bool bool_0, Element element_0 = null)
	{
		return true;
	}

	private bool method_3(bool bool_0 = false)
	{
		return true;
	}

	private void method_4(bool bool_0 = false)
	{
	}

	internal void method_5(Vector2i vector2i_1)
	{
	}

	[SpecialName]
	internal InventoryControlFlagEnum method_6()
	{
		return (InventoryControlFlagEnum)(object)null;
	}

	[SpecialName]
	internal void method_7(InventoryControlFlagEnum inventoryControlFlagEnum_1)
	{
	}

	internal void method_8()
	{
	}

	internal void method_9(string string_2, string string_3)
	{
	}

	internal void method_10(string string_2, int int_2)
	{
	}

	internal void method_11(string string_2, int int_2)
	{
	}

	internal void method_12(string string_2, int int_2)
	{
	}

	internal void method_13(string string_2, int int_2)
	{
	}

	internal void method_14(string string_2, int int_2)
	{
	}

	internal void method_15(string string_2, int int_2)
	{
	}

	internal void method_16(string string_2, int int_2)
	{
	}

	internal void method_17(string string_2, int int_2)
	{
	}

	internal void method_18(string string_2, int int_2)
	{
	}

	internal void method_19(string string_2, int int_2)
	{
	}

	internal void method_20(string string_2, int int_2)
	{
	}

	internal void method_21(string string_2, int int_2)
	{
	}

	internal void method_22(string string_2, int int_2)
	{
	}

	internal void method_23(int int_2 = -1, int int_3 = -1)
	{
	}

	internal void method_24(Vector2i vector2i_1)
	{
	}

	internal void method_25()
	{
	}

	internal void method_26()
	{
	}

	internal void method_27()
	{
	}

	[SpecialName]
	internal int method_28()
	{
		return 0;
	}

	[SpecialName]
	internal Dictionary<int, long> method_29()
	{
		return null;
	}

	public ViewItemsInInventoryResult ViewItemsInInventory(ShouldViewItemDelegate shouldViewItem, Func<bool> isOpened)
	{
		return (ViewItemsInInventoryResult)(object)null;
	}

	public ViewItemsInInventoryResult ViewItemsInInventory(ShouldViewItemDelegate shouldViewItem, Func<bool> isOpened, bool dontClearKeysState)
	{
		return (ViewItemsInInventoryResult)(object)null;
	}

	public PickupResult Pickup(int localId, bool actuallyPickup = true)
	{
		return (PickupResult)(object)null;
	}

	public PickupResult Pickup(bool actuallyPickup = true)
	{
		return (PickupResult)(object)null;
	}

	public FastMoveResult FastMoveReward(int localId, bool actuallyMove = true)
	{
		return (FastMoveResult)(object)null;
	}

	public int GetLevelRequirement(int localId)
	{
		return 0;
	}

	public int GetIntRequirement(int localId)
	{
		return 0;
	}

	public int GetDexRequirement(int localId)
	{
		return 0;
	}

	public int GetStrRequirement(int localId)
	{
		return 0;
	}

	public FastMoveResult FastMove(int localId, bool dontClearKeysState, bool actuallyMove = true, bool ignoreIncubators = true)
	{
		return (FastMoveResult)(object)null;
	}

	public FastMoveResult FastMove(int localId, bool actuallyMove = true, bool ignoreIncubators = true)
	{
		return (FastMoveResult)(object)null;
	}

	public FastMoveResult FastMove(bool dontClearKeysState, bool actuallyMove = true, bool ignoreIncubators = true, bool IgnoreCursorState = false)
	{
		return (FastMoveResult)(object)null;
	}

	public FastMoveResult FastMove(bool actuallyMove = true, bool ignoreIncubators = true, bool IgnoreCursorState = false)
	{
		return (FastMoveResult)(object)null;
	}

	public FastMoveResult FastMoveAll(int localId, bool dontClearKeysState = false, bool actuallyMove = true, bool ignoreIncubators = true)
	{
		return (FastMoveResult)(object)null;
	}

	public FastMoveResult FastMoveAll(bool dontClearKeysState = false, bool actuallyMove = true, bool ignoreIncubators = true, bool IgnoreCursorState = false)
	{
		return (FastMoveResult)(object)null;
	}

	public MergeStackResult MergeStack(int localId, bool actuallyMerge = true)
	{
		return (MergeStackResult)(object)null;
	}

	public MergeStackResult MergeStack(bool actuallyMerge = true)
	{
		return (MergeStackResult)(object)null;
	}

	public OpenDisplayNoteResult OpenDisplayNote(bool actuallyUse = true)
	{
		return (OpenDisplayNoteResult)(object)null;
	}

	public OpenDisplayNoteResult OpenDisplayNote(int localId, bool actuallyUse = true)
	{
		return (OpenDisplayNoteResult)(object)null;
	}

	public SplitStackResult SplitStack(int value, bool actuallySplit = true)
	{
		return (SplitStackResult)(object)null;
	}

	public SplitStackResult SplitStack(int localId, int value, bool actuallySplit = true)
	{
		return (SplitStackResult)(object)null;
	}

	public UseItemResult UseItem(int localId, bool actuallyUse = true)
	{
		return (UseItemResult)(object)null;
	}

	public UseItemResult UseItem(bool actuallyUse = true)
	{
		return (UseItemResult)(object)null;
	}

	public static ApplyCursorResult BeginApplyCursor(bool holdShift = false)
	{
		return (ApplyCursorResult)(object)null;
	}

	public static ApplyCursorResult EndApplyCursor()
	{
		return (ApplyCursorResult)(object)null;
	}

	public ApplyCursorResult ApplyCursorAt(int col, int row, bool actuallyApply = true)
	{
		return (ApplyCursorResult)(object)null;
	}

	public ApplyCursorResult ApplyCursorTo(bool actuallyApply = true)
	{
		return (ApplyCursorResult)(object)null;
	}

	public ApplyCursorResult ApplyCursorTo(int localId, bool actuallyApply = true)
	{
		return (ApplyCursorResult)(object)null;
	}

	public PlaceCursorIntoResult PlaceCursorInto(int col, int row, bool allowOverlap = false, bool actuallyPlace = true)
	{
		return (PlaceCursorIntoResult)(object)null;
	}

	public PlaceCursorIntoResult PlaceCursorInto(bool allowOverlap = false, bool actuallyPlace = true)
	{
		return (PlaceCursorIntoResult)(object)null;
	}

	public UnequipSkillGemResult UnequipSkillGem(int index, bool actuallyUnequip = true)
	{
		return (UnequipSkillGemResult)(object)null;
	}

	public UnequipSkillGemResult UnequipSkillGem(int localId, int index, bool actuallyUnequip = true)
	{
		return (UnequipSkillGemResult)(object)null;
	}

	public EquipSkillGemResult EquipSkillGem(int index, bool actuallyEquip = true)
	{
		return (EquipSkillGemResult)(object)null;
	}

	internal static bool smethod_2(Item item_0)
	{
		return true;
	}

	public EquipSkillGemResult EquipSkillGem(int localId, int index, bool actuallyEquip = true)
	{
		return (EquipSkillGemResult)(object)null;
	}

	public GetItemCostResult GetItemGoldCost(int localId, out int goldCost, out bool canAfford)
	{
		return (GetItemCostResult)(object)null;
	}

	public GetItemGoldSellPriceResult GetItemGoldSellPrice(int localId, out int goldSellPrice)
	{
		return (GetItemGoldSellPriceResult)(object)null;
	}

	public GetItemCostResult GetItemCost(int localId, out List<KeyValuePair<string, int>> info, out bool canAfford)
	{
		return (GetItemCostResult)(object)null;
	}

	private bool method_30(Element element_0, out bool bool_0)
	{
		return true;
	}

	public bool IsItemDeferred(int localId)
	{
		return true;
	}

	public GetItemTributeCostResult GetItemTributeCostEx(int localId, out int tributeCost, out bool canAfford)
	{
		return (GetItemTributeCostResult)(object)null;
	}

	public GetItemDeferalCostResult GetItemDeferalCostEx(int localId, out int futureDiscount, out int deferalFee, out int totalDeferalCost)
	{
		return (GetItemDeferalCostResult)(object)null;
	}

	private static Element smethod_3(List<Element> list_1, string string_2)
	{
		return null;
	}

	public bool IsItemTransparent(int localId)
	{
		return true;
	}

	public void SetSingleSlotUi(SingleSlotUiElement element)
	{
	}

	public void SetInventorySlotUi(InventorySlotUiElement element, StashType stashType = StashType.NormalStash)
	{
	}

	[SpecialName]
	[CompilerGenerated]
	private Inventory method_31()
	{
		return null;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_32(Inventory inventory_1)
	{
	}

	public void SetInventory(Inventory inv)
	{
	}

	static InventoryControlWrapper()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	[CompilerGenerated]
	internal static bool smethod_4(long long_3)
	{
		return true;
	}

	[CompilerGenerated]
	private bool method_33(InventoryHolder inventoryHolder_0)
	{
		return true;
	}

	[CompilerGenerated]
	private bool method_34(InventoryHolder inventoryHolder_0)
	{
		return true;
	}

	[CompilerGenerated]
	private bool method_35(InventoryHolder inventoryHolder_0)
	{
		return true;
	}

	internal static bool smethod_5()
	{
		return true;
	}

	internal static InventoryControlWrapper smethod_6()
	{
		return null;
	}
}
