using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Common;
using DreamPoeBot.Loki.Game;
using DreamPoeBot.Loki.Game.GameData;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Bot;

public class GridExplorer : IExplorer, IStartStopEvents, ITickEvents
{
	public enum FilterType
	{
		Original,
		Enhanced,
		MinBacktrack,
		Wavefront,
		Frontier,
		FastMarch,
		NBV
	}

	public class ReceivedDataEventArgs : EventArgs
	{
		[CompilerGenerated]
		private IOrderedEnumerable<Node> iorderedEnumerable_0;

		[CompilerGenerated]
		private float float_0;

		[CompilerGenerated]
		private Vector2i vector2i_0;

		[CompilerGenerated]
		private Vector2i vector2i_1;

		[CompilerGenerated]
		private Vector2i vector2i_2;

		internal static ReceivedDataEventArgs receivedDataEventArgs_0;

		public IOrderedEnumerable<Node> nodes
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

		public float PercentCompleted
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

		public Vector2i Location
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

		public Vector2i PreviousLocation
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

		public Vector2i MapEntryPoint
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

		internal static bool smethod_0()
		{
			return true;
		}

		internal static ReceivedDataEventArgs smethod_1()
		{
			return null;
		}

		static ReceivedDataEventArgs()
		{
			Class200.smethod_34();
		}
	}

	public enum ExplorationMethodEnum
	{
		Breadth_First,
		Depth_First
	}

	public delegate Vector2i LocationSelectorDelegate();

	public delegate void LocationUpdateEvent<ReceivedDataEventArgs>(ReceivedDataEventArgs e);

	public enum Flags
	{
		Unknown = 0,
		Known = 1,
		Seen = 2,
		Ignored = 4,
		Disconnected = 8
	}

	public class Node
	{
		[CompilerGenerated]
		private Flags flags_0;

		[CompilerGenerated]
		private Vector2i vector2i_0;

		[CompilerGenerated]
		private Vector2i vector2i_1;

		[CompilerGenerated]
		private Vector2i vector2i_2;

		[CompilerGenerated]
		private Vector2i vector2i_3;

		[CompilerGenerated]
		private Vector2i vector2i_4;

		[CompilerGenerated]
		private float float_0;

		internal static Node node_0;

		public Flags Flag
		{
			[CompilerGenerated]
			get
			{
				return (Flags)(object)null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public Vector2i Location
		{
			[CompilerGenerated]
			get
			{
				return (Vector2i)(object)null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public Vector2i Size
		{
			[CompilerGenerated]
			get
			{
				return (Vector2i)(object)null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public Vector2i Index
		{
			[CompilerGenerated]
			get
			{
				return (Vector2i)(object)null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public Vector2i NavigableLocation
		{
			[CompilerGenerated]
			get
			{
				return (Vector2i)(object)null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public Vector2i Center
		{
			[CompilerGenerated]
			get
			{
				return (Vector2i)(object)null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public float Weight
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

		public Node(int x, int y)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Node smethod_1()
		{
			return null;
		}

		static Node()
		{
			Class200.smethod_34();
		}
	}

	private sealed class Class130
	{
		public GridExplorer gridExplorer_0;

		public int int_0;

		public int int_1;

		public Vector2i vector2i_0;

		private static Class130 class130_0;

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class130 smethod_1()
		{
			return null;
		}

		static Class130()
		{
			Class200.smethod_34();
		}
	}

	private sealed class Class131
	{
		[CompilerGenerated]
		private CachedTerrainData cachedTerrainData_0;

		[CompilerGenerated]
		private Class130 class130_0;

		internal static Class131 class131_0;

		public Class131(CachedTerrainData cachedTerrainData_1, Class130 class130_1)
		{
		}

		internal void wqEpwCaJbNq()
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class131 smethod_1()
		{
			return null;
		}

		static Class131()
		{
			Class200.smethod_34();
		}
	}

	private sealed class Class132
	{
		public GridExplorer gridExplorer_0;

		public CachedTerrainData cachedTerrainData_0;

		public Vector2i vector2i_0;

		internal static Class132 class132_0;

		internal void method_0()
		{
		}

		public void method_1()
		{
		}

		public void method_2()
		{
		}

		public void method_3()
		{
		}

		public void method_4()
		{
		}

		public void method_5()
		{
		}

		public void method_6()
		{
		}

		public void method_7()
		{
		}

		public void method_8()
		{
		}

		public void method_9()
		{
		}

		public void method_10()
		{
		}

		private void method_11()
		{
		}

		private Vector2i method_12()
		{
			return (Vector2i)(object)null;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class132 smethod_1()
		{
			return null;
		}

		static Class132()
		{
			Class200.smethod_34();
		}
	}

	public class SynthesisDataClass
	{
		public int LowestSynthX;

		public int LowestSynthY;

		public int HighestSynthX;

		public int HighestSynthY;

		private static SynthesisDataClass synthesisDataClass_0;

		public bool IsInSynthesis()
		{
			return true;
		}

		public bool IsInSynthesis(int x, int y)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static SynthesisDataClass smethod_1()
		{
			return null;
		}

		static SynthesisDataClass()
		{
			Class200.smethod_34();
		}
	}

	public class IncursionDataClass
	{
		public int LowestSynthX;

		public int LowestSynthY;

		public int HighestSynthX;

		public int HighestSynthY;

		public bool HasIncursion;

		internal static IncursionDataClass incursionDataClass_0;

		public bool IsMeInIncursion()
		{
			return true;
		}

		public bool IsPositionInIncursions(int x, int y)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static IncursionDataClass smethod_1()
		{
			return null;
		}

		static IncursionDataClass()
		{
			Class200.smethod_34();
		}
	}

	public class SyndacateDataClass
	{
		public int LowestSynthX;

		public int LowestSynthY;

		public int HighestSynthX;

		public int HighestSynthY;

		public bool HasSyndacate;

		internal static SyndacateDataClass syndacateDataClass_0;

		public bool IsMeInSyndacate()
		{
			return true;
		}

		public bool IsPositionInSyndacate(int x, int y)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static SyndacateDataClass smethod_1()
		{
			return null;
		}

		static SyndacateDataClass()
		{
			Class200.smethod_34();
		}
	}

	public class SacredGroveDataClass
	{
		public int LowestSynthX;

		public int LowestSynthY;

		public int HighestSynthX;

		public int HighestSynthY;

		public bool HasSacredGrove;

		internal static SacredGroveDataClass sacredGroveDataClass_0;

		public bool IsInSacredGrove()
		{
			return true;
		}

		public bool IsInSacredGrove(int x, int y)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static SacredGroveDataClass smethod_1()
		{
			return null;
		}

		static SacredGroveDataClass()
		{
			Class200.smethod_34();
		}
	}

	public class SanctumDataClass
	{
		public int LowestSynthX;

		public int LowestSynthY;

		public int HighestSynthX;

		public int HighestSynthY;

		internal static SanctumDataClass sanctumDataClass_0;

		public bool IsInSanctum()
		{
			return true;
		}

		public bool IsInSanctum(int x, int y)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static SanctumDataClass smethod_1()
		{
			return null;
		}

		static SanctumDataClass()
		{
			Class200.smethod_34();
		}
	}

	public class AflictionDataClass
	{
		public int LowestAflicX;

		public int LowestAflicY;

		public int HighestAflicX;

		public int HighestAflicY;

		public bool HasAfliction;

		internal static AflictionDataClass aflictionDataClass_0;

		public bool IsInAfliction()
		{
			return true;
		}

		public bool IsInAfliction(int x, int y)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static AflictionDataClass smethod_1()
		{
			return null;
		}

		static AflictionDataClass()
		{
			Class200.smethod_34();
		}
	}

	public class SyndicateDataClass
	{
		public int LowestSyndicateX;

		public int LowestSyndicateY;

		public int HighestSyndicateX;

		public int HighestSyndicateY;

		public bool HasSyndicate;

		internal static SyndicateDataClass syndicateDataClass_0;

		public bool IsInSyndicate()
		{
			return true;
		}

		public bool IsInSyndicate(int x, int y)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static SyndicateDataClass smethod_1()
		{
			return null;
		}

		static SyndicateDataClass()
		{
			Class200.smethod_34();
		}
	}

	public class UltimatumDataClass
	{
		public int LowestUltimatumX;

		public int LowestUltimatumY;

		public int HighestUltimatumX;

		public int HighestUltimatumY;

		public bool HasUltimatum;

		internal static UltimatumDataClass ultimatumDataClass_0;

		public bool IsInUltimatum()
		{
			return true;
		}

		public bool IsInUltimatum(int x, int y)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static UltimatumDataClass smethod_1()
		{
			return null;
		}

		static UltimatumDataClass()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003Ec__DisplayClass58_0
	{
		public Vector2i vector2i_0;

		public GridExplorer gridExplorer_0;
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003Ec__DisplayClass59_0
	{
		public GridExplorer gridExplorer_0;

		public Vector2i vector2i_0;
	}

	private static bool bool_0;

	private static bool bool_1;

	[CompilerGenerated]
	private FilterType filterType_0;

	public IncursionDataClass IncursionData;

	public SynthesisDataClass SyntesisData;

	public SacredGroveDataClass SacredGroveData;

	public SanctumDataClass SanctumData;

	public AflictionDataClass AflictionData;

	public SyndicateDataClass SyndicateData;

	public UltimatumDataClass UltimatumData;

	public ExplorationMethodEnum ExplorationMethod;

	public static LocationSelectorDelegate ThisLocationSelectorDelegate;

	[CompilerGenerated]
	private static LocationUpdateEvent<ReceivedDataEventArgs> locationUpdateEvent_0;

	[CompilerGenerated]
	private DatWorldAreaWrapper datWorldAreaWrapper_0;

	[CompilerGenerated]
	private uint uint_0;

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	private Vector2i vector2i_0;

	[CompilerGenerated]
	private Vector2i vector2i_1;

	[CompilerGenerated]
	private Vector2i vector2i_2;

	[CompilerGenerated]
	private float float_0;

	private static readonly ILog Log;

	private int int_2;

	private int int_3;

	private bool bool_2;

	private int int_4;

	private int int_5;

	private Node[,] node_0;

	private readonly Dictionary<Flags, List<Node>> dictionary_0;

	private bool bool_3;

	private static GridExplorer gridExplorer_0;

	public FilterType ExplorerFilterType
	{
		[CompilerGenerated]
		get
		{
			return (FilterType)(object)null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public bool AutoResetOnAreaChange
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	public int TileKnownRadius
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int TileSeenRadius
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public DatWorldAreaWrapper Area
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

	public uint Hash
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

	public int Cols
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

	public int Rows
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

	public bool HasLocation => true;

	public Vector2i Location
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

	public Vector2i PreviousLocation
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

	public Vector2i MapEntryPoint
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

	public Node LocationNode => null;

	public float PercentComplete
	{
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static event LocationUpdateEvent<ReceivedDataEventArgs> OnLocationUpdate
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

	private static void smethod_0(string string_0, bool[][] bool_4)
	{
	}

	public List<Vector2i> SimulateFullExploration()
	{
		return null;
	}

	public static void SignalLocationUpdate(ReceivedDataEventArgs e)
	{
	}

	public void Start()
	{
	}

	public void Stop()
	{
	}

	public void Tick()
	{
	}

	private float method_0(Node node_1, Vector2i vector2i_3)
	{
		return 0f;
	}

	private float method_1(Node node_1, Vector2i vector2i_3)
	{
		return 0f;
	}

	private float method_2(Node node_1, Vector2i vector2i_3)
	{
		return 0f;
	}

	private float method_3(Node node_1, Vector2i vector2i_3)
	{
		return 0f;
	}

	private float method_4(Node node_1, Vector2i vector2i_3)
	{
		return 0f;
	}

	private float method_5(Node node_1, Vector2i vector2i_3)
	{
		return 0f;
	}

	private float method_6(Node node_1)
	{
		return 0f;
	}

	public Node GetNodeForLocation(Vector2i location)
	{
		return null;
	}

	public void ForceNodeFlags(Vector2i location, Flags flags)
	{
	}

	public void Ignore(Vector2i location)
	{
	}

	public List<Node> GetNodesByFlag(Flags flag)
	{
		return null;
	}

	public void Reset()
	{
	}

	private void method_9()
	{
	}

	private void method_10(Node[,] node_1, string string_0, uint uint_1)
	{
	}

	private float method_11(FilterType filterType_1)
	{
		return 0f;
	}

	private void method_12(CachedTerrainData cachedTerrainData_0, Vector2i vector2i_3, Node node_1, bool bool_4)
	{
	}

	private void method_13(CachedTerrainData cachedTerrainData_0, Vector2i vector2i_3, Node node_1, Vector2i vector2i_4, bool bool_4)
	{
	}

	public void Unload()
	{
	}

	static GridExplorer()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		bool_0 = false;
		bool_1 = false;
		ThisLocationSelectorDelegate = null;
		Log = Logger.GetLoggerInstanceForType();
	}

	[CompilerGenerated]
	private float method_14(Node node_1)
	{
		return 0f;
	}

	[CompilerGenerated]
	private bool method_15(Node node_1)
	{
		return true;
	}

	[CompilerGenerated]
	private float method_16(Node node_1, ref _003C_003Ec__DisplayClass58_0 _003C_003Ec__DisplayClass58_0_0)
	{
		return 0f;
	}

	[CompilerGenerated]
	private int method_17(Node node_1, ref _003C_003Ec__DisplayClass58_0 _003C_003Ec__DisplayClass58_0_0)
	{
		return 0;
	}

	[CompilerGenerated]
	private float method_18(Node node_1, ref _003C_003Ec__DisplayClass59_0 _003C_003Ec__DisplayClass59_0_0)
	{
		return 0f;
	}

	[CompilerGenerated]
	private float method_19(Node node_1, ref _003C_003Ec__DisplayClass59_0 _003C_003Ec__DisplayClass59_0_0)
	{
		return 0f;
	}

	[CompilerGenerated]
	private float method_20(Node node_1)
	{
		return 0f;
	}

	internal static bool smethod_1()
	{
		return true;
	}

	internal static GridExplorer smethod_2()
	{
		return null;
	}
}
