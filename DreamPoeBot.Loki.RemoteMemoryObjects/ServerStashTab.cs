using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.RemoteMemoryObjects;

public class ServerStashTab : RemoteMemoryObject
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct50
	{
		public readonly int int_0;

		public readonly int int_1;

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

		private readonly byte byte_0;

		private readonly byte byte_1;

		private readonly short short_0;

		private readonly short short_1;

		private readonly short short_2;

		private readonly short short_3;
	}

	private PerFrameCachedValue<Struct50> perFrameCachedValue_0;

	internal static ServerStashTab serverStashTab_0;

	public string DisplayName => null;

	public int InventoryId => 0;

	public uint Color => 0u;

	public InventoryTabPermissions inventoryMemberFlags => (InventoryTabPermissions)(object)null;

	public InventoryTabPermissions inventoryOfficerFlags => (InventoryTabPermissions)(object)null;

	public InventoryTabType inventoryTabType => (InventoryTabType)(object)null;

	public ushort DisplayIndex => 0;

	public ushort LinkedParentId => 0;

	public InventoryTabMapSeries inventoryTabMapSeries => (InventoryTabMapSeries)(object)null;

	public InventoryTabFlags inventoryTabFlags => (InventoryTabFlags)(object)null;

	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	internal Struct50 method_0()
	{
		return (Struct50)(object)null;
	}

	private Struct50 method_1()
	{
		return (Struct50)(object)null;
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static ServerStashTab smethod_3()
	{
		return null;
	}

	static ServerStashTab()
	{
		Class200.smethod_34();
	}
}
