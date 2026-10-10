using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Bot.Pathfinding.RDWrapper.Types;
using DreamPoeBot.Loki.Game;
using ns0;
using RecastManaged.Detour;
using RecastManaged.DetourTileCache;

namespace DreamPoeBot.Loki.Bot.Pathfinding.RDWrapper.Core;

public class Pathfinder : IDisposable
{
	private readonly struct Struct271 : IDisposable
	{
		private readonly ReaderWriterLockSlim readerWriterLockSlim_0;

		private readonly bool bool_0;

		internal static object object_0;

		internal Struct271(ReaderWriterLockSlim readerWriterLockSlim_1, bool bool_1)
		{
		}

		public void Dispose()
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static object smethod_1()
		{
			return null;
		}

		static Struct271()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGenerateNavMeshAsync_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public Pathfinder _003C_003E4__this;

		private TaskAwaiter<bool> _003C_003Eu__1;

		internal static object object_0;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static object smethod_1()
		{
			return null;
		}

		static _003CGenerateNavMeshAsync_003Ed__35()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private static int int_0;

	private readonly ConcurrentDictionary<uint, Obstacle> concurrentDictionary_0;

	private readonly ConcurrentQueue<NavMeshQuery> concurrentQueue_0;

	private CachedTerrainData cachedTerrainData_0;

	private QueryFilter queryFilter_0;

	private byte byte_0;

	[CompilerGenerated]
	private NavMesh navMesh_0;

	[CompilerGenerated]
	private TileCache tileCache_0;

	[CompilerGenerated]
	private System.Numerics.Vector3 vector3_0;

	[CompilerGenerated]
	private System.Numerics.Vector3 vector3_1;

	[CompilerGenerated]
	private bool bool_0;

	private readonly ReaderWriterLockSlim readerWriterLockSlim_0;

	private Dictionary<uint, uint> dictionary_0;

	private uint uint_0;

	private bool bool_1;

	private RecastMeshSettings recastMeshSettings_0;

	private readonly Dictionary<int, Entity> dictionary_1;

	private byte[] byte_1;

	internal static Pathfinder pathfinder_0;

	public static int QueryMaxNodes
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public NavMesh NavMesh
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public TileCache TileCache
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public System.Numerics.Vector3 WMin
	{
		[CompilerGenerated]
		get
		{
			return (System.Numerics.Vector3)(object)null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public System.Numerics.Vector3 WMax
	{
		[CompilerGenerated]
		get
		{
			return (System.Numerics.Vector3)(object)null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsNavMeshReady => true;

	public uint AreaHash => 0u;

	public bool IsDisposed
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

	private Pathfinder()
	{
	}

	public void Dispose()
	{
	}

	public static Pathfinder CreateAndInit(CachedTerrainData ctd, RecastMeshSettings rms = null)
	{
		return null;
	}

	public static Pathfinder CreateAndInit(uint areaHash, byte[] terrainData, int bytesPerRow, int columns, int rows, byte walkableValue, string areaId = null)
	{
		return null;
	}

	public static Pathfinder Create(CachedTerrainData ctd)
	{
		return null;
	}

	public static Pathfinder Create(uint areaHash, byte[] terrainData, int bytesPerRow, int columns, int rows, byte walkableValue, string areaId = null)
	{
		return null;
	}

	public static Pathfinder CreateAndInitWithCache(uint areaHash, byte[] terrainData, int bytesPerRow, int columns, int rows, byte walkableValue, string areaId = null)
	{
		return null;
	}

	public bool GenerateNavMesh(RecastMeshSettings rms = null)
	{
		return true;
	}

	[AsyncStateMachine(typeof(_003CGenerateNavMeshAsync_003Ed__35))]
	public Task<bool> GenerateNavMeshAsync()
	{
		return null;
	}

	public bool LiesOnPoly(int x, int y)
	{
		return true;
	}

	private NavMeshQuery method_0()
	{
		return null;
	}

	private void method_1(NavMeshQuery navMeshQuery_0)
	{
	}

	private NavMeshQuery method_2()
	{
		return null;
	}

	public PathResult FindPath(Vector2i start, Vector2i end, bool waypoints = true, byte distanceBetweenHops = 15)
	{
		return (PathResult)(object)null;
	}

	private float method_3(Vector2i vector2i_0, Vector2i vector2i_1)
	{
		return 0f;
	}

	public bool Raycast(Vector2i start, Vector2i end, out Vector2i hitpoint)
	{
		return true;
	}

	public float PathDistance(Vector2i start, Vector2i end)
	{
		return 0f;
	}

	public (float, Vector2i) DistanceToWall(Vector2i pos, float maxRadius)
	{
		return ((float, Vector2i))null;
	}

	private bool method_4(Vector2i vector2i_0, Vector2i vector2i_1)
	{
		return true;
	}

	public bool PathExists(Vector2i start, Vector2i end)
	{
		return true;
	}

	public bool UpdateObstacles()
	{
		return true;
	}

	public void ClearObstacles()
	{
	}

	public uint AddObstacle(Obstacle obstacle)
	{
		return 0u;
	}

	public uint AddCircleObstacle(CircleObstacle circleObstacle)
	{
		return 0u;
	}

	public uint AddCircleObstacle(Vector2i center, float radius)
	{
		return 0u;
	}

	public uint AddBoxObstacle(BoxObstacle boxObstacle)
	{
		return 0u;
	}

	public uint AddBoxObstacle(Vector2i min, Vector2i max)
	{
		return 0u;
	}

	public uint AddOrientedBoxObstacle(OrientedBoxObstacle oriented)
	{
		return 0u;
	}

	public uint AddOrientedBoxObstacle(Vector2i center, Vector2i halfExtents, float yRotation)
	{
		return 0u;
	}

	public bool RemoveObstacle(uint obstacleRef)
	{
		return true;
	}

	public bool RemoveObstacle(Obstacle obstacle)
	{
		return true;
	}

	public int RemoveObstacles(Vector2i pos)
	{
		return 0;
	}

	public int RemoveObstacles(Func<Obstacle, bool> predicate)
	{
		return 0;
	}

	public int RemoveObstaclesInAabb(Vector2i min, Vector2i max)
	{
		return 0;
	}

	public IReadOnlyCollection<Obstacle> GetAllObstacles()
	{
		return null;
	}

	public Obstacle GetObstacle(uint obstacleRef)
	{
		return null;
	}

	public NavMeshDebugData GetNavMeshDebugData()
	{
		return null;
	}

	public TileCacheDebugData GetTileCacheDebugData()
	{
		return null;
	}

	public List<TileDebugData> GetTileDebugData()
	{
		return null;
	}

	public WalkabilityDebugData GetWalkabilityDebugData()
	{
		return null;
	}

	private Struct271 method_5()
	{
		return (Struct271)(object)null;
	}

	internal void method_6(byte[] byte_2, int int_1, int int_2, Class141.Class144 class144_0, bool bool_2, bool bool_3)
	{
	}

	internal bool method_7(byte[] byte_2, int int_1)
	{
		return true;
	}

	private uint method_8(Obstacle obstacle_0, uint uint_1)
	{
		return 0u;
	}

	private static bool smethod_0(TileCache tileCache_1, NavMesh navMesh_1)
	{
		return true;
	}

	private bool method_9(RecastMeshSettings recastMeshSettings_1)
	{
		return true;
	}

	static Pathfinder()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		int_0 = 8192;
	}

	[CompilerGenerated]
	private bool method_10()
	{
		return true;
	}

	internal static bool smethod_1()
	{
		return true;
	}

	internal static Pathfinder smethod_2()
	{
		return null;
	}
}
