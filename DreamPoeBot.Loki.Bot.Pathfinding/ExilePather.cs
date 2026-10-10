using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Bot.Pathfinding.RDWrapper.Core;
using DreamPoeBot.Loki.Bot.Pathfinding.RDWrapper.Types;
using DreamPoeBot.Loki.Common;
using DreamPoeBot.Loki.Components;
using DreamPoeBot.Loki.Game;
using DreamPoeBot.Loki.Game.Objects;
using DreamPoeBot.Loki.Game.Utilities;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Bot.Pathfinding;

public static class ExilePather
{
	public delegate void ExilePatherReloadEvent();

	public delegate void ObstacleUpdateEvent();

	public delegate bool PlotFunction(int x, int y);

	public delegate bool PlotObjectFunction(int x, int y, List<RaycastNetworkObject> objectsToConsider);

	public class EditedTriggerableBlokage
	{
		internal NetworkObject Source;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private byte[] ihqpShcVwp4;

		[CompilerGenerated]
		private Vector2i vector2i_0;

		[CompilerGenerated]
		private Vector2i vector2i_1;

		[CompilerGenerated]
		private bool bool_0;

		internal static EditedTriggerableBlokage editedTriggerableBlokage_0;

		public string Metadata
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int Id
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public byte[] NavData
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

		public Vector2i BoundsMin
		{
			[CompilerGenerated]
			get
			{
				return (Vector2i)(object)null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Vector2i BoundsMax
		{
			[CompilerGenerated]
			get
			{
				return (Vector2i)(object)null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool ShouldBlock
		{
			[CompilerGenerated]
			get
			{
				return true;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public EditedTriggerableBlokage(int id, string metadata, byte[] navData, bool shouldBlock, Vector2i boundsMin, Vector2i boundsMax)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static EditedTriggerableBlokage smethod_1()
		{
			return null;
		}

		static EditedTriggerableBlokage()
		{
			Class200.smethod_34();
		}
	}

	private sealed class Class145
	{
		public Vector2i vector2i_0;

		public Vector2i vector2i_1;

		internal static Class145 class145_0;

		internal List<Vector2i> method_0()
		{
			return null;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class145 smethod_1()
		{
			return null;
		}

		static Class145()
		{
			Class200.smethod_34();
		}
	}

	private sealed class Class146
	{
		public List<Vector2i> fHtpoelsmnC;

		internal static Class146 class146_0;

		internal bool yNdpotnaIv7(int int_0, int int_1)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class146 smethod_1()
		{
			return null;
		}

		static Class146()
		{
			Class200.smethod_34();
		}
	}

	private sealed class Class147
	{
		public CachedTerrainData cachedTerrainData_0;

		public Vector2i vector2i_0;

		public List<RaycastNetworkObject> list_0;

		public Vector2i vector2i_1;

		internal static Class147 class147_0;

		internal Tuple<bool, Vector2i> method_0(bool bool_0 = false)
		{
			return null;
		}

		internal RaycastResult method_1(bool bool_0 = false)
		{
			return null;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class147 smethod_1()
		{
			return null;
		}

		static Class147()
		{
			Class200.smethod_34();
		}
	}

	private sealed class Class148
	{
		public Class147 class147_0;

		public Vector2i vector2i_0;

		public int rfUpoYaMdDm;

		private static Class148 class148_0;

		internal bool method_0(int int_0, int int_1)
		{
			return true;
		}

		internal bool method_1(int int_0, int int_1)
		{
			return true;
		}

		internal bool method_2(int int_0, int int_1, List<RaycastNetworkObject> list_0)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class148 smethod_1()
		{
			return null;
		}

		static Class148()
		{
			Class200.smethod_34();
		}
	}

	private sealed class Class149
	{
		public CachedTerrainData cachedTerrainData_0;

		public int int_0;

		public Vector2i vector2i_0;

		public int int_1;

		public Vector2i vector2i_1;

		private static Class149 class149_0;

		internal void method_0()
		{
		}

		internal void method_1()
		{
		}

		internal void method_2()
		{
		}

		internal void method_3()
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class149 smethod_1()
		{
			return null;
		}

		static Class149()
		{
			Class200.smethod_34();
		}
	}

	public class RaycastNetworkObject
	{
		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private Vector2i vector2i_0;

		[CompilerGenerated]
		private float CcGpokOpyUi;

		internal static RaycastNetworkObject raycastNetworkObject_0;

		public int Id
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

		public Vector2i Position
		{
			[CompilerGenerated]
			get
			{
				return (Vector2i)(object)null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float Radius
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static RaycastNetworkObject smethod_1()
		{
			return null;
		}

		static RaycastNetworkObject()
		{
			Class200.smethod_34();
		}
	}

	public class RaycastResult
	{
		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private Vector2i vector2i_0;

		[CompilerGenerated]
		private bool bool_0;

		private static RaycastResult raycastResult_0;

		public int ObjectId
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

		public Vector2i Hitpoint
		{
			[CompilerGenerated]
			get
			{
				return (Vector2i)(object)null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool Result
		{
			[CompilerGenerated]
			get
			{
				return true;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static RaycastResult smethod_1()
		{
			return null;
		}

		static RaycastResult()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CReloadAsync_003Ed__79 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CancellationToken ct;

		public bool force;

		private CancellationTokenSource _003Ccts_003E5__2;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private uint _003CareaHash_003E5__3;

		private long _003CtsStart_003E5__4;

		private DateTime _003CreloadDeadline_003E5__5;

		private CancellationToken _003Ctoken_003E5__6;

		private Task _003CheightMapTask_003E5__7;

		private Task<Pathfinder> _003CpathfinderTask_003E5__8;

		private Task _003CwhenAll_003E5__9;

		private ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter _003C_003Eu__2;

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

		static _003CReloadAsync_003Ed__79()
		{
			Class200.smethod_34();
		}
	}

	private static readonly ILog Log;

	private static readonly List<int> list_0;

	private static readonly List<int> list_1;

	internal static readonly Dictionary<int, EditedTriggerableBlokage> dictionary_0;

	private static readonly Dictionary<Vector2i, Vector2i> dictionary_1;

	public static List<string> JumpableTgt;

	public static bool IsReady;

	private static SlowCacheValue<byte> slowCacheValue_0;

	private static readonly SemaphoreSlim semaphoreSlim_0;

	private static CancellationTokenSource cancellationTokenSource_0;

	private static readonly TimeSpan timeSpan_0;

	[CompilerGenerated]
	private static bool bool_0;

	[CompilerGenerated]
	private static bool bool_1;

	[CompilerGenerated]
	private static bool bool_2;

	[CompilerGenerated]
	private static uint uint_0;

	[CompilerGenerated]
	private static int int_0;

	[CompilerGenerated]
	private static int int_1;

	[CompilerGenerated]
	private static int int_2;

	[CompilerGenerated]
	private static bool bool_3;

	[CompilerGenerated]
	private static Pathfinder pathfinder_0;

	[CompilerGenerated]
	private static ObstacleUpdateEvent obstacleUpdateEvent_0;

	[CompilerGenerated]
	private static ExilePatherReloadEvent exilePatherReloadEvent_0;

	private static ExilePather exilePather_0;

	public static bool UseWalkableCheck
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static bool ShouldBlockNPC
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static bool ShouldBlockChest
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static uint AreaHash
	{
		[CompilerGenerated]
		get
		{
			return 0u;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static int AscendancyDoorRadiusOverride
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

	public static int LabyrinthLockedDoorRadiusOverride
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

	public static int TempleLockedDoorRadiusOverride
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

	public static bool AutoSavePathfindingData
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static Pathfinder Pathfinder
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

	public static event ObstacleUpdateEvent OnObstacleUpdate
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event ExilePatherReloadEvent OnExilePatherReload
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[SpecialName]
	internal static byte smethod_0()
	{
		return 0;
	}

	internal static byte smethod_1(Positioned positioned_0)
	{
		return 0;
	}

	public static List<Vector2i> GetPointsOnSegment(Vector2i start, Vector2i end, bool dontLeaveFrame)
	{
		return null;
	}

	public static bool CanObjectSee(Vector2i start, Vector2i end, out Vector2i hitPoint, bool dontLeaveFrame = false, bool shouldUseRangedMap = false)
	{
		return true;
	}

	public static bool CanObjectSee(NetworkObject obj, NetworkObject other, out Vector2i hitPoint, bool dontLeaveFrame = false, bool shouldUseRangedMap = false)
	{
		return true;
	}

	public static bool CanObjectSee(NetworkObject obj, Vector2i position, out Vector2i hitPoint, bool dontLeaveFrame = false, bool shouldUseRangedMap = false)
	{
		return true;
	}

	private static void smethod_2<T>(ref T gparam_0, ref T gparam_1)
	{
	}

	public static bool Raycast(Vector2i start, Vector2i end, out Vector2i hitPoint, bool dontLeaveFrame = false, bool shouldUseRangedMap = false)
	{
		return true;
	}

	public static bool RaycastPf(Vector2i start, Vector2i end, out Vector2i hitPoint)
	{
		return true;
	}

	public static bool Raycast(Vector2i start, Vector2i end, List<NetworkObject> objectsToConsider, out Vector2i hitPoint, out int objectId, bool dontLeaveFrame = false, bool shouldUseRangedMap = false)
	{
		return true;
	}

	public static bool Raycast(Vector2i start, Vector2i end, List<CircleObstacle> positionsToConsider, out Vector2i hitPoint, out CircleObstacle? obst, bool dontLeaveFrame = false, bool shouldUseRangedMap = false)
	{
		return true;
	}

	private static bool smethod_3(NetworkObject networkObject_0)
	{
		return true;
	}

	private static void smethod_4()
	{
	}

	private static void smethod_5(byte[] byte_0, int int_3, NetworkObject networkObject_0, bool bool_4, bool bool_5)
	{
	}

	private static void smethod_6(byte[] byte_0, int int_3, int int_4, Class141.Class144 class144_0, bool bool_4, bool bool_5)
	{
	}

	internal static void smethod_7(Func<NetworkObject, bool> func_0, List<NetworkObject> list_2)
	{
	}

	public static void BlockTriggerableBlockages(ref byte[] data, int bytesPerRow, Func<NetworkObject, bool> shouldBlock, List<NetworkObject> obj)
	{
	}

	internal static bool smethod_8(byte[] byte_0, int int_3, byte[] byte_1, Vector2i vector2i_0, Vector2i vector2i_1, bool bool_4, byte[] byte_2)
	{
		return true;
	}

	private static void smethod_9(ref byte[] byte_0, int int_3, List<NetworkObject> list_2)
	{
	}

	internal static void smethod_10(ref byte[] byte_0, int int_3, Func<NetworkObject, bool> func_0, Dictionary<int, EditedTriggerableBlokage> dictionary_2)
	{
	}

	public static void Reload(bool force = false)
	{
	}

	[AsyncStateMachine(typeof(_003CReloadAsync_003Ed__79))]
	public static Task ReloadAsync(bool force = false, CancellationToken ct = default(CancellationToken))
	{
		return null;
	}

	public static bool UpdateObstacles()
	{
		return true;
	}

	public static IReadOnlyList<Obstacle> GetObstacles()
	{
		return null;
	}

	public static void ClearObstacles()
	{
	}

	public static uint AddCircleObstacle(Vector2i position, float radius, string description = null)
	{
		return 0u;
	}

	public static uint AddBoxObstacle(Vector2i min, Vector2i max, string description = null)
	{
		return 0u;
	}

	public static uint AddObstacle(Obstacle obstacle)
	{
		return 0u;
	}

	public static bool RemoveObstacle(Obstacle obstacle)
	{
		return true;
	}

	public static bool RemoveObstacle(uint obstacleRef)
	{
		return true;
	}

	public static int RemoveObstacles(Vector2i position)
	{
		return 0;
	}

	public static int RemoveObstacles(Func<Obstacle, bool> predicate)
	{
		return 0;
	}

	public static Obstacle GetObstacle(uint obstacleRef)
	{
		return null;
	}

	[Obsolete("Use PathExistsBetween", true)]
	private static bool smethod_11(Vector2i vector2i_0, Vector2i vector2i_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool PathExistsBetween(Vector2i start, Vector2i end)
	{
		return true;
	}

	public static PathResult FindPath(Vector2i start, Vector2i end, bool waypoints = true, byte distanceBetweenHops = 15)
	{
		return (PathResult)(object)null;
	}

	public static PathResult FindPathWithObstacles(Vector2i start, Vector2i end, List<Obstacle> obstacles, bool waypoints = true, byte distanceBetweenHops = 15)
	{
		return (PathResult)(object)null;
	}

	[Obsolete("Use PathDistance", true)]
	private static float smethod_12(Vector2i vector2i_0, Vector2i vector2i_1)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float PathDistance(Vector2i start, Vector2i end)
	{
		return 0f;
	}

	public static (float, Vector2i) DistanceToWall(Vector2i pos, float maxRadius)
	{
		return ((float, Vector2i))null;
	}

	public static bool IsWalkable(Vector2i arg)
	{
		return true;
	}

	public static bool IsWalkable(int x, int y)
	{
		return true;
	}

	public static void ClearWalkablePositionCache()
	{
	}

	public static Vector2i FastWalkablePositionFor(NetworkObject obj, int range = 30, bool cache = true)
	{
		return (Vector2i)(object)null;
	}

	private static bool smethod_13(CachedTerrainData cachedTerrainData_0, Vector2i vector2i_0)
	{
		return true;
	}

	private static double smethod_14(Vector2 vector2_0, Vector2 vector2_1)
	{
		return 0.0;
	}

	private static Vector2i smethod_15(Vector2i vector2i_0, double double_0, double double_1)
	{
		return (Vector2i)(object)null;
	}

	internal static Vector2i smethod_16(Vector2i vector2i_0, double double_0, int int_3 = 30)
	{
		return (Vector2i)(object)null;
	}

	public static Vector2i FastWalkablePositionFor(Vector2i pos, int range = 30, bool cache = true)
	{
		return (Vector2i)(object)null;
	}

	public static void SignalObstacleUpdate()
	{
	}

	static ExilePather()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		Log = Logger.GetLoggerInstanceForType();
		list_0 = new List<int>();
		list_1 = new List<int>();
		dictionary_0 = new Dictionary<int, EditedTriggerableBlokage>();
		dictionary_1 = new Dictionary<Vector2i, Vector2i>();
		JumpableTgt = new List<string>();
		semaphoreSlim_0 = new SemaphoreSlim(1, 1);
		timeSpan_0 = TimeSpan.FromSeconds(60.0);
		bool_0 = true;
		bool_1 = true;
		bool_2 = false;
		int_0 = 0;
		int_1 = 0;
		int_2 = 0;
		bool_3 = false;
	}

	[CompilerGenerated]
	internal static bool smethod_17()
	{
		return true;
	}

	[CompilerGenerated]
	internal static void smethod_18(List<uint> list_2)
	{
	}

	internal static bool smethod_19()
	{
		return true;
	}

	internal static ExilePather smethod_20()
	{
		return null;
	}
}
