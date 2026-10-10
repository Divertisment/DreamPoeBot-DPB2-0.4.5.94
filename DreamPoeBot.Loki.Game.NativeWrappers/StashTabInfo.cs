using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.RemoteMemoryObjects;
using ns0;

namespace DreamPoeBot.Loki.Game.NativeWrappers;

public class StashTabInfo
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct100
	{
		private readonly int int_0;

		private readonly int int_1;

		public readonly GStruct2 gstruct2_0;

		public readonly int int_2;

		public readonly uint uint_0;

		public readonly InventoryTabPermissions inventoryTabPermissions_0;

		public readonly InventoryTabPermissions inventoryTabPermissions_1;

		public readonly InventoryTabType inventoryTabType_0;

		public readonly ushort ushort_0;

		public readonly ushort ushort_1;

		public readonly InventoryTabMapSeries inventoryTabMapSeries_0;

		public readonly InventoryTabFlags inventoryTabFlags_0;

		public readonly byte byte_0;

		private readonly byte byte_1;

		private readonly byte byte_2;

		private readonly byte byte_3;

		private readonly byte byte_4;

		private readonly byte byte_5;

		private readonly byte byte_6;

		private readonly byte byte_7;

		private readonly byte byte_8;

		private readonly byte byte_9;

		private long long_0;

		private long long_1;

		private long long_2;

		private readonly int int_3;

		private readonly int int_4;
	}

	[CompilerGenerated]
	private ServerStashTab serverStashTab_0;

	[CompilerGenerated]
	private bool bool_0;

	private readonly Struct100 struct100_0;

	private static StashTabInfo stashTabInfo_0;

	public bool IsGuild
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int InventoryId => 0;

	public uint Color => 0u;

	public string DisplayName => null;

	public ushort DisplayIndex => 0;

	public ushort LinkedParentId => 0;

	public bool IsPremiumFlagged => true;

	public bool IsRemoveOnlyFlagged => true;

	public bool IsPublicFlagged => true;

	public bool IsHiddenFlagged => true;

	public InventoryTabType TabType => (InventoryTabType)(object)null;

	public InventoryTabFlags TabFlags => (InventoryTabFlags)(object)null;

	public bool IsPremium => true;

	public bool IsNormalTab => true;

	public bool IsPremiumCurrency => true;

	public bool IsPremiumEssence => true;

	public bool IsPremiumRitual => true;

	public bool IsPremiumQuad => true;

	public bool IsPremiumDivination => true;

	public bool IsPremiumMap => true;

	public bool IsUniqueCollection => true;

	public bool IsPremiumFragment => true;

	public bool IsPremiumSocketable => true;

	public bool IsPremiumExpedition => true;

	public bool IsPremiumBreach => true;

	public bool IsPremiumAbyss => true;

	public bool IsPremiumDelve => true;

	public bool IsPremiumBlight => true;

	public bool IsPremiumMetamorph => true;

	public bool IsPremiumDelirium => true;

	public bool IsFolder => true;

	public bool IsPremiumGem => true;

	public bool IsPremiumFlask => true;

	public bool IsPremiumSpecial => true;

	public InventoryTabPermissions MemberFlags => (InventoryTabPermissions)(object)null;

	public InventoryTabPermissions OfficerFlags => (InventoryTabPermissions)(object)null;

	public InventoryTabMapSeries MapSeries => (InventoryTabMapSeries)(object)null;

	[SpecialName]
	[CompilerGenerated]
	private ServerStashTab method_0()
	{
		return null;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_1(ServerStashTab serverStashTab_1)
	{
	}

	public StashTabInfo(ServerStashTab element, bool isGuildStashTab)
	{
	}

	internal StashTabInfo(Struct100 native, bool isGuildStashTab)
	{
	}

	[SpecialName]
	internal bool method_2()
	{
		return true;
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static StashTabInfo smethod_1()
	{
		return null;
	}

	static StashTabInfo()
	{
		Class200.smethod_34();
	}
}
