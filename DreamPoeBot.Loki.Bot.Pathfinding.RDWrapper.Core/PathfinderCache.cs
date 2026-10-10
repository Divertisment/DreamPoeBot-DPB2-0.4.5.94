using System;
using System.Collections.Concurrent;
using System.IO;
using System.Threading;
using ns0;
using RecastManaged.Detour;
using RecastManaged.DetourTileCache;

namespace DreamPoeBot.Loki.Bot.Pathfinding.RDWrapper.Core;

public static class PathfinderCache
{
	private static readonly ConcurrentDictionary<string, byte[]> concurrentDictionary_0;

	private static readonly ConcurrentDictionary<string, byte[]> concurrentDictionary_1;

	private static string string_0;

	private static readonly ReaderWriterLockSlim readerWriterLockSlim_0;

	private static bool bool_0;

	private static PathfinderCache pathfinderCache_0;

	public static string CachePath
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static void Initialize()
	{
	}

	private static void smethod_0()
	{
	}

	public static string GenerateCacheKey(byte[] terrainData, int bytesPerRow, int cols, int rows, byte walkableValue)
	{
		return null;
	}

	public static NavMesh LoadNavMeshFromCache(string cacheKey)
	{
		return null;
	}

	public static TileCache LoadTileCacheFromCache(string cacheKey, NavMesh navMesh)
	{
		return null;
	}

	public static bool SaveToCache(string cacheKey, NavMesh navMesh, TileCache tileCache)
	{
		return true;
	}

	public static void ClearCache()
	{
	}

	static PathfinderCache()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		concurrentDictionary_0 = new ConcurrentDictionary<string, byte[]>();
		concurrentDictionary_1 = new ConcurrentDictionary<string, byte[]>();
		string_0 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Class200.smethod_20(2921260), Class200.smethod_20(2921282));
		readerWriterLockSlim_0 = new ReaderWriterLockSlim();
		bool_0 = false;
	}

	internal static bool smethod_1()
	{
		return true;
	}

	internal static PathfinderCache smethod_2()
	{
		return null;
	}
}
