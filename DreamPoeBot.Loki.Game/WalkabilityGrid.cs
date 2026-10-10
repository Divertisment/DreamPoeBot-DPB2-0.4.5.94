using System.Collections;
using System.Numerics;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Common;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Game;

public static class WalkabilityGrid
{
	internal static readonly ILog ilog_0;

	private static WalkabilityGrid walkabilityGrid_0;

	public static (System.Numerics.Vector3 min, System.Numerics.Vector3 max) GetBoundsFaster(CachedTerrainData cache, byte walkableValue)
	{
		return ((System.Numerics.Vector3 min, System.Numerics.Vector3 max))null;
	}

	private static void smethod_0(CachedTerrainData cachedTerrainData_0, byte byte_0, int int_0, int int_1, ref float float_0, ref float float_1)
	{
	}

	private static void smethod_1(CachedTerrainData cachedTerrainData_0, byte byte_0, int int_0, int int_1, ref float float_0, ref float float_1)
	{
	}

	public static bool IsWalkable(CachedTerrainData cache, Vector2i pos, byte value)
	{
		return true;
	}

	public static bool IsWalkable(CachedTerrainData cache, int c, int r, byte value)
	{
		return true;
	}

	public static bool IsWalkable(byte[] data, int bytesPerRow, Vector2i pos, byte value)
	{
		return true;
	}

	public static bool IsWalkable(byte[] data, int bytesPerRow, int c, int r, byte value)
	{
		return true;
	}

	public static bool IsJumpable(byte[] data, int bytesPerRow, int c, int r, byte jumpableValue)
	{
		return true;
	}

	public static byte WalkableValue(CachedTerrainData cache, Vector2i pos)
	{
		return 0;
	}

	public static byte WalkableValue(CachedTerrainData cache, int c, int r)
	{
		return 0;
	}

	public static byte WalkableValue(byte[] data, int bytesPerRow, Vector2i pos)
	{
		return 0;
	}

	public static byte WalkableValue(byte[] data, int bytesPerRow, int c, int r)
	{
		return 0;
	}

	public static BitArray GetWalkableBitArray(CachedTerrainData cache, byte value)
	{
		return null;
	}

	static WalkabilityGrid()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static WalkabilityGrid smethod_3()
	{
		return null;
	}
}
