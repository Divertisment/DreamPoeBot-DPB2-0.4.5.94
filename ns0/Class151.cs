using System.Collections.Concurrent;
using System.Numerics;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Bot.Pathfinding.RDWrapper.Types;
using DreamPoeBot.Loki.Game;
using RecastManaged.Detour;
using RecastManaged.DetourTileCache;
using RecastManaged.Recast;

namespace ns0;

internal class Class151
{
	internal static Class151 class151_0;

	private static void Log(string msg)
	{
	}

	public static (NavMesh, TileCache) smethod_0(CachedTerrainData cachedTerrainData_0, byte byte_0, out System.Numerics.Vector3 vector3_0, out System.Numerics.Vector3 vector3_1, RecastMeshSettings recastMeshSettings_0 = null)
	{
		return ((NavMesh, TileCache))null;
	}

	private static (NavMesh, TileCache) smethod_1(CachedTerrainData cachedTerrainData_0, RecastMeshSettings recastMeshSettings_0, System.Numerics.Vector3 vector3_0, System.Numerics.Vector3 vector3_1, byte byte_0)
	{
		return ((NavMesh, TileCache))null;
	}

	private static NavMeshData smethod_2(int int_0, int int_1, CachedTerrainData cachedTerrainData_0, byte byte_0, RecastMeshSettings recastMeshSettings_0)
	{
		return null;
	}

	private static void smethod_3(TileCache tileCache_0, Vector2i vector2i_0, Vector2i vector2i_1, NavMesh navMesh_0)
	{
	}

	private static void smethod_4(Heightfield heightfield_0, CachedTerrainData cachedTerrainData_0, byte byte_0, System.Numerics.Vector3 vector3_0, System.Numerics.Vector3 vector3_1, float float_0, out int int_0)
	{
	}

	private static (NavMesh, TileCache) smethod_5(ConcurrentBag<NavMeshData> concurrentBag_0, Vector2i vector2i_0, Vector2i vector2i_1, RecastMeshSettings recastMeshSettings_0)
	{
		return ((NavMesh, TileCache))null;
	}

	internal static bool smethod_6()
	{
		return true;
	}

	internal static Class151 smethod_7()
	{
		return null;
	}

	static Class151()
	{
		Class200.smethod_34();
	}
}
