using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Game;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.RemoteMemoryObjects;

public class AreaMap : RemoteMemoryObject
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct30
	{
		private readonly long long_0;

		private readonly long long_1;

		private readonly long long_2;

		public readonly long long_3;

		public readonly long long_4;

		public NativeVector nativeVector_0;

		private readonly long long_5;

		private readonly long long_6;

		private readonly NativeVector nativeVector_1;

		private readonly NativeVector nativeVector_2;

		public readonly int int_0;

		private readonly int int_1;

		private readonly long long_7;

		private readonly long long_8;

		private readonly long long_9;

		private readonly long long_10;

		private readonly long long_11;

		private readonly long long_12;

		private readonly long long_13;

		private readonly long long_14;

		private readonly long long_15;

		public readonly NativeVector nativeVector_3;

		public readonly NativeVector nativeVector_4;

		public readonly NativeVector nativeVector_5;

		public readonly NativeVector nativeVector_6;

		public readonly int int_2;

		public readonly short short_0;
	}

	private static readonly int int_0;

	private PerAreaCachedValue<Struct30> perAreaCachedValue_0;

	private PerAreaCachedValue<LokiPoe.TerrainData.Struct71[]> perAreaCachedValue_1;

	private static AreaMap areaMap_0;

	public Memory Memory => null;

	public long GrountMapStart => 0L;

	public long GroundMapEnd => 0L;

	public long FlyMapStart => 0L;

	public long FlyMapEnd => 0L;

	public int MapWidth => 0;

	public int TileHeightMultiplyier => 0;

	public byte[] GroundLayer0 => null;

	public byte[] FlyLayer1 => null;

	public Vector2i Size => (Vector2i)(object)null;

	public int Cols => 0;

	public int Rows => 0;

	public Vector2i SizeInNavCells => (Vector2i)(object)null;

	public int BytesPerRow => 0;

	public long TerrainDataEntryArrayPointer => 0L;

	public long TerrainDataEntryArrayPointerLast => 0L;

	public NativeVector TerrainDataEntryArrayVector => (NativeVector)(object)null;

	[SpecialName]
	private Struct30 method_0()
	{
		return (Struct30)(object)null;
	}

	[SpecialName]
	internal LokiPoe.TerrainData.Struct71[] method_1()
	{
		return null;
	}

	private LokiPoe.TerrainData.Struct71[] GetTerrainDataEntryArray()
	{
		return null;
	}

	static AreaMap()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		int_0 = Marshal.SizeOf<LokiPoe.TerrainData.Struct71>();
	}

	[CompilerGenerated]
	private Struct30 method_2()
	{
		return (Struct30)(object)null;
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static AreaMap smethod_3()
	{
		return null;
	}
}
