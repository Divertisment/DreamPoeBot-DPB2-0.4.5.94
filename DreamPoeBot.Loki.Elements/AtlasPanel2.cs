using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Timers;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Common;
using DreamPoeBot.Loki.Game;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.Game.Utilities;
using DreamPoeBot.Loki.RemoteMemoryObjects;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Elements;

public class AtlasPanel2 : Element
{
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	internal struct Struct155
	{
		[FieldOffset(1280)]
		[Obsolete]
		public NativeHashMap nativeHashMap_0;

		[FieldOffset(1571)]
		public byte byte_0;

		[FieldOffset(1632)]
		public Vector2i vector2i_0;

		[FieldOffset(1632)]
		[Obsolete]
		public ushort ushort_0;

		[FieldOffset(1634)]
		[Obsolete]
		public ushort ushort_1;
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
	public struct AtlasUnknownVectorOffsetStruct
	{
		[FieldOffset(0)]
		public short coordinateX;

		[FieldOffset(2)]
		public short coordinateY;

		[FieldOffset(8)]
		public long Pointer;
	}

	public enum MovePanelResult
	{
		None,
		AtlasMapFileNotLoaded,
		IdNotFoundInAtlasNodeMap,
		UnableToPlaceTheMouseOverTheNode,
		AtlasMapIsNull,
		ConditionError
	}

	internal class Class51 : RemoteMemoryObject
	{
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct Struct156
		{
			public Vector2i vector2i_0;

			public Vector2i vector2i_1;

			private int int_0;

			public Vector2i vector2i_2;

			private int int_1;

			public Vector2i vector2i_3;

			private int int_2;

			public Vector2i vector2i_4;

			private int int_3;

			public Vector2i vector2i_5;

			private int int_4;
		}

		private Struct156 struct156_0;

		internal static Class51 class51_0;

		internal Vector2i Node => (Vector2i)(object)null;

		public Class51(Struct156 struct156_1, long long_1)
		{
		}

		[SpecialName]
		internal Vector2i AdilknSaRvV()
		{
			return (Vector2i)(object)null;
		}

		[SpecialName]
		internal Vector2i method_0()
		{
			return (Vector2i)(object)null;
		}

		[SpecialName]
		internal Vector2i method_1()
		{
			return (Vector2i)(object)null;
		}

		[SpecialName]
		internal Vector2i method_2()
		{
			return (Vector2i)(object)null;
		}

		[SpecialName]
		internal Vector2i method_3()
		{
			return (Vector2i)(object)null;
		}

		internal static bool smethod_2()
		{
			return true;
		}

		internal static Class51 smethod_3()
		{
			return null;
		}

		static Class51()
		{
			Class200.smethod_34();
		}
	}

	public class AtlasTowerNode : RemoteMemoryObject
	{
		private PerFrameCachedValue<AtlasPanelSpecialNode> perFrameCachedValue_0;

		private PerFrameCachedValue<Struct159> perFrameCachedValue_1;

		private static AtlasTowerNode atlasTowerNode_0;

		public Vector2i Coordinate => (Vector2i)(object)null;

		public string RevealType => null;

		public List<string> FullTooltip => null;

		public AtlasPanelSpecialNode CorrespondingElement => null;

		public void Click()
		{
		}

		public bool IsInFOV(float pct)
		{
			return true;
		}

		public bool MoveTo(int timeout = 5000)
		{
			return true;
		}

		[SpecialName]
		internal Struct159 method_0()
		{
			return (Struct159)(object)null;
		}

		[SpecialName]
		internal nint NhBlkusjBf9()
		{
			return (nint)(object)null;
		}

		[CompilerGenerated]
		private AtlasPanelSpecialNode method_1()
		{
			return null;
		}

		[CompilerGenerated]
		private Struct159 method_2()
		{
			return (Struct159)(object)null;
		}

		internal static bool smethod_2()
		{
			return true;
		}

		internal static AtlasTowerNode smethod_3()
		{
			return null;
		}

		static AtlasTowerNode()
		{
			Class200.smethod_34();
		}
	}

	public class AtlasSpecialNode : RemoteMemoryObject
	{
		private PerFrameCachedValue<AtlasPanelSpecialNode> perFrameCachedValue_0;

		internal static AtlasSpecialNode atlasSpecialNode_0;

		public Vector2i Coordinate => (Vector2i)(object)null;

		public List<string> FullTooltip => null;

		public AtlasPanelSpecialNode CorrespondingElement => null;

		public void Click()
		{
		}

		public bool IsInFOV(float pct)
		{
			return true;
		}

		public bool MoveTo(int timeout = 5000)
		{
			return true;
		}

		[CompilerGenerated]
		private AtlasPanelSpecialNode method_0()
		{
			return null;
		}

		internal static bool smethod_2()
		{
			return true;
		}

		internal static AtlasSpecialNode smethod_3()
		{
			return null;
		}

		static AtlasSpecialNode()
		{
			Class200.smethod_34();
		}
	}

	public class AtlasNode : RemoteMemoryObject
	{
		public class ExtraContent
		{
			private AtlasUnknownVectorOffsetStruct atlasUnknownVectorOffsetStruct_0;

			private static ExtraContent extraContent_0;

			public ExtraContent(AtlasUnknownVectorOffsetStruct node)
			{
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static ExtraContent smethod_1()
			{
				return null;
			}

			static ExtraContent()
			{
				Class200.smethod_34();
			}
		}

		private PerFrameCachedValue<Struct157> perFrameCachedValue_0;

		private PerFrameCachedValue<AtlasPanelNode> perFrameCachedValue_1;

		private static AtlasNode atlasNode_0;

		public List<Vector2i> ConnectedNodesCoordinates => null;

		public List<AtlasNode> ConnectedNodes => null;

		public Vector2i Coordinate => (Vector2i)(object)null;

		public AtlasPanelNode CorrespondingElement => null;

		public bool IsUnlocked => true;

		public bool IsVisited => true;

		public bool IsCompleted => true;

		public bool IsTower => true;

		public bool IsIrradiated => true;

		public bool IsCorrupted => true;

		public bool IsCorruptedNexus => true;

		public byte ExtraAtlasPassiveGranted => 0;

		public AtlasPanelNode.AtlasPassiveSkillSubtreeType ExtraAtlasPassiveGrantedType => (AtlasPanelNode.AtlasPassiveSkillSubtreeType)(object)null;

		public byte MinWaystoneTierRequired => 0;

		public DatPassiveSkillWrapper AtlasPassiveEffect => null;

		public bool IsCleansed => true;

		public bool CanBeUsed => true;

		public bool CanUseTablet => true;

		public bool CanBeSelectedForCruxOfNothingness => true;

		public string CruxOfNothingnessBonus => null;

		public bool IsSelectedForCruxOfNothingness => true;

		public DatWorldAreaWrapper Area => null;

		public bool IsUnique => true;

		public List<EndgameMapContentWrapper> Content => null;

		public List<AtlasEffectSource> Influence => null;

		public BiomeEnum Biome => (BiomeEnum)(object)null;

		public Dictionary<DatStatWrapper, int> Stats => null;

		public AtlasNodeIconElement AtlasOverNodeIcon => null;

		[SpecialName]
		internal bool method_0()
		{
			return true;
		}

		public void Click()
		{
		}

		public bool IsInFOV(float pct)
		{
			return true;
		}

		public bool MoveTo(int timeout = 5000)
		{
			return true;
		}

		public LokiPoe.InGameState.AtlasUi.BookmarkResult Bookmark(string name)
		{
			return (LokiPoe.InGameState.AtlasUi.BookmarkResult)(object)null;
		}

		[SpecialName]
		internal Struct157 method_1()
		{
			return (Struct157)(object)null;
		}

		[SpecialName]
		internal nint method_2()
		{
			return (nint)(object)null;
		}

		[SpecialName]
		internal nint method_3()
		{
			return (nint)(object)null;
		}

		public override string ToString()
		{
			return null;
		}

		[CompilerGenerated]
		private AtlasPanelNode method_4()
		{
			return null;
		}

		[CompilerGenerated]
		private bool method_5(AtlasEffectSource atlasEffectSource_0)
		{
			return true;
		}

		[CompilerGenerated]
		private bool method_6(AtlasEffectSource atlasEffectSource_0)
		{
			return true;
		}

		[CompilerGenerated]
		private Struct157 method_7()
		{
			return (Struct157)(object)null;
		}

		internal static bool smethod_2()
		{
			return true;
		}

		internal static AtlasNode smethod_3()
		{
			return null;
		}

		static AtlasNode()
		{
			Class200.smethod_34();
		}
	}

	public enum BiomeEnum
	{
		Water,
		Mountain,
		Grass,
		Forest,
		Swamp,
		Desert,
		EzomyteCity,
		FaridunCity,
		VaalCity,
		BreachCity,
		Ocean,
		Island,
		OriathCity
	}

	internal struct Struct157
	{
		public readonly int int_0;

		public readonly int int_1;

		public readonly nint intptr_0;

		public readonly nint intptr_1;
	}

	[StructLayout(LayoutKind.Sequential, Size = 16)]
	internal struct Struct158
	{
		public readonly short short_0;

		public readonly short rAeluAldkOB;

		private readonly int int_0;

		public readonly nint intptr_0;
	}

	[StructLayout(LayoutKind.Sequential, Size = 16)]
	internal struct Struct159
	{
		public readonly nint intptr_0;

		public readonly nint intptr_1;

		public readonly nint intptr_2;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct Struct160
	{
		internal long long_0;

		internal long long_1;

		internal byte nsvluoivRyD;
	}

	[StructLayout(LayoutKind.Explicit, Size = 40)]
	private struct Struct161
	{
		[FieldOffset(0)]
		internal int Id;

		[FieldOffset(8)]
		internal int Value;
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003Ec__DisplayClass60_0
	{
		public Dictionary<Vector2i, HashSet<Vector2i>> dictionary_0;
	}

	private static readonly Timer timer_0;

	private static readonly ILog ilog_1;

	private static List<AtlasNode> list_0;

	private static PerFrameCachedValue<List<AtlasNode>> perFrameCachedValue_6;

	internal static Dictionary<Vector2i, AtlasNode> dictionary_0;

	internal static Dictionary<Vector2i, HashSet<Vector2i>> dictionary_1;

	internal static List<Class51> list_1;

	private static long long_5;

	internal static AtlasPanel2 atlasPanel2_0;

	public static long IntPtr_TreeMap => 0L;

	public AtlasMapDevice AtlasMapDeviceUi => null;

	public bool IsOpened => true;

	public static List<AtlasNode> AtlasNodes => null;

	public static List<AtlasNode> UsableAtlasNodes => null;

	public static List<AtlasNode> CompletedAtlasNodes => null;

	public static List<AtlasUnknownVectorOffsetStruct> AtlasUnknownNodes => null;

	public static List<AtlasSpecialNode> AtlasEndgameContentIcons => null;

	public static List<AtlasTowerNode> AtlasTowerNodes => null;

	public static List<AtlasSpecialNode> AtlasIslandsNodes => null;

	public List<Vector2i> CruxOfNothingnessSelectableNodes => null;

	public List<Vector2i> CruxOfNothingnessSelectedNodes => null;

	public List<AtlasEffectSource> EffectSources => null;

	public static AtlasNode CurrentAtlasNode => null;

	public static Vector2i CurrenctAtlasNodeCoordinates => (Vector2i)(object)null;

	[SpecialName]
	private Struct155 method_29()
	{
		return (Struct155)(object)null;
	}

	static AtlasPanel2()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		timer_0 = null;
		ilog_1 = Logger.GetLoggerInstanceForType();
		list_0 = new List<AtlasNode>();
		dictionary_0 = new Dictionary<Vector2i, AtlasNode>();
		dictionary_1 = new Dictionary<Vector2i, HashSet<Vector2i>>();
		list_1 = new List<Class51>();
		timer_0 = new Timer(1000.0)
		{
			Enabled = true
		};
		timer_0.Elapsed += smethod_11;
	}

	private static void smethod_11(object sender, ElapsedEventArgs e)
	{
	}

	[SpecialName]
	internal byte method_30()
	{
		return 0;
	}

	private static List<AtlasNode> smethod_12()
	{
		return null;
	}

	private static List<AtlasSpecialNode> smethod_13(long long_6, int int_3 = 1)
	{
		return null;
	}

	private static List<AtlasTowerNode> smethod_14(long long_6)
	{
		return null;
	}

	internal void method_31()
	{
	}

	internal void method_32()
	{
	}

	internal void method_33()
	{
	}

	internal void method_34()
	{
	}

	internal bool method_35(out IReadOnlyList<RiteOfTheNamelessNode> ireadOnlyList_0)
	{
		return true;
	}

	private T[] method_36<T>(NativeVector nativeVector_0, int int_3) where T : unmanaged
	{
		return null;
	}

	private T[] method_37<T>(long long_6, int int_3) where T : unmanaged
	{
		return null;
	}

	private static bool smethod_15<T>(T[] gparam_0, T[] gparam_1) where T : unmanaged
	{
		return true;
	}

	private bool method_38(ServerData serverData_0)
	{
		return true;
	}

	[CompilerGenerated]
	internal static void smethod_16(Vector2i vector2i_0, Vector2i vector2i_1, ref _003C_003Ec__DisplayClass60_0 _003C_003Ec__DisplayClass60_0_0)
	{
	}

	internal static bool smethod_17()
	{
		return true;
	}

	internal static AtlasPanel2 smethod_18()
	{
		return null;
	}
}
