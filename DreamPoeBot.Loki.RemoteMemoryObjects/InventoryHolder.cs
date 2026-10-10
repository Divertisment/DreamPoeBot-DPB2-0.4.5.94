using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.RemoteMemoryObjects;

public class InventoryHolder : RemoteMemoryObject
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct Struct42
	{
		public readonly int Id;

		private readonly uint uint_0;

		public readonly long long_0;
	}

	private int int_0;

	private PerFrameCachedValue<Struct42> perFrameCachedValue_0;

	internal static InventoryHolder inventoryHolder_0;

	public int Id => 0;

	public DreamPoeBot.Loki.Game.Inventory Inventory => null;

	private DreamPoeBot.Loki.Game.Inventory method_0()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	private Struct42 method_1()
	{
		return (Struct42)(object)null;
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static InventoryHolder smethod_3()
	{
		return null;
	}

	static InventoryHolder()
	{
		Class200.smethod_34();
	}
}
