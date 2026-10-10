using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class Map : Component
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct227
	{
		private long long_0;

		private long long_1;

		public long long_2;
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct MapComponentStructureExtra
	{
		[FieldOffset(16)]
		public long DataMapsDataAddress;

		[FieldOffset(24)]
		private long bsdlJoPeigP;

		[FieldOffset(80)]
		public int MapTier;
	}

	private PerFrameCachedValue<Struct227> perFrameCachedValue_0;

	private PerFrameCachedValue<MapComponentStructureExtra> perFrameCachedValue_1;

	internal static Map map_0;

	public InventoryTabMapSeries MapSeries => (InventoryTabMapSeries)(object)null;

	public int MapTier => 0;

	[SpecialName]
	internal long method_2()
	{
		return 0L;
	}

	[SpecialName]
	internal Struct227 method_3()
	{
		return (Struct227)(object)null;
	}

	private Struct227 method_4()
	{
		return (Struct227)(object)null;
	}

	[SpecialName]
	internal MapComponentStructureExtra kFyApfOgrpm()
	{
		return (MapComponentStructureExtra)(object)null;
	}

	private MapComponentStructureExtra method_5()
	{
		return (MapComponentStructureExtra)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static Map smethod_5()
	{
		return null;
	}

	static Map()
	{
		Class200.smethod_34();
	}
}
