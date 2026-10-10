using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.RemoteMemoryObjects;

public class ServerData : RemoteMemoryObject
{
	private struct Struct44
	{
		public long long_0;

		public long long_1;
	}

	[StructLayout(LayoutKind.Explicit, Size = 16)]
	private struct Struct45
	{
		[FieldOffset(0)]
		public uint Id;

		[FieldOffset(11)]
		public byte byte_0;

		[FieldOffset(12)]
		public byte byte_1;

		[FieldOffset(13)]
		public byte byte_2;
	}

	public class PassiveSkillGraphNode
	{
		private bool bool_0;

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private ushort ushort_0;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private string string_1;

		[CompilerGenerated]
		private long long_0;

		[CompilerGenerated]
		private long long_1;

		internal static PassiveSkillGraphNode passiveSkillGraphNode_0;

		public int Index
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

		public ushort PassiveSkillGraphId
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

		public string Id
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

		public string Name
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

		public long PassiveSkillsInfoAdr
		{
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public long PassiveSkillsDatAdr
		{
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsMainLane => true;

		public List<PassiveSkillGraphNode> LinkedPassiveNode => null;

		public PassiveSkillGraphNode(PassiveSkillGraphStructure native, int idx)
		{
		}

		public PassiveSkillGraphNode(long passiveSkillsInfoAdr, long passiveSkillsDat, int idx)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static PassiveSkillGraphNode smethod_1()
		{
			return null;
		}

		static PassiveSkillGraphNode()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct PassiveSkillGraphStructure
	{
		public long PassiveSkillsDat;

		public long PassiveSkillsDatFile;

		public long PassiveSkillsInfo;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct PassiveGraphSkillsInfoStructure
	{
		private long long_0;

		public long PassiveSkillsDat;

		public long PassiveSkillsDatFile;

		public int Index;

		private int ijiAsMlOgCS;

		private int int_0;

		private int int_1;

		private long long_1;

		private long long_2;

		private long long_3;

		public NativeVector MainLaneLink;

		public NativeVector SideLaneLink;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct AtlasPassiveNodeStructure
	{
		private int int_0;

		private int int_1;

		private int int_2;

		private int int_3;

		public NativeVector nodesVector;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct AssignedAtlasPassiveNodeStructure
	{
		private int int_0;

		public uint AtlasGraphId;

		public NativeVector nodesVector;
	}

	public enum PartyAllocation : byte
	{
		FreeForAll,
		ShortAllocation,
		PermanentAllocation,
		None
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct Struct46
	{
		public int int_0;

		public int int_1;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct47
	{
		public long long_0;

		public long long_1;

		public int int_0;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct StructRitualMain
	{
		public long StructRitualData;

		public int AvailableRitualsInZone;

		public int CompletedRitualsInZone;

		private NativeVector nativeVector_0;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct StructRitualData
	{
		public NativeVector DeferedItemsVector;

		public int CurrentTributes;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct StructServerDataExtra
	{
		private long long_0;

		private long long_1;

		private long long_2;

		private long long_3;

		private long long_4;

		private long long_5;

		private long long_6;

		private long long_7;

		private long long_8;

		private long long_9;

		private long long_10;

		private long long_11;

		private long long_12;

		private long long_13;

		private long VefAsqRijSh;

		private long long_14;

		private long long_15;

		private long tvkAsuWcblc;

		private long long_16;

		private long long_17;

		private long long_18;

		private long long_19;

		private long long_20;

		private long long_21;

		private long long_22;

		private long long_23;

		private long long_24;

		private long long_25;

		private long long_26;

		private long long_27;

		private long long_28;

		private long long_29;

		private long long_30;

		private long long_31;

		private long long_32;

		private long long_33;

		private long long_34;

		private long long_35;

		private long long_36;

		private long long_37;

		private long long_38;

		private long oviAshvwoYF;

		private long long_39;

		private long long_40;

		public long long_41;

		private long long_42;

		private long long_43;

		private long long_44;

		private long long_45;

		private uint uint_0;

		private uint uint_1;

		private uint uint_2;

		private uint uint_3;

		private long long_46;

		private long long_47;

		public NativeVector Psif;

		private long long_48;

		private long long_49;

		private long long_50;

		private long long_51;

		private long long_52;

		private long long_53;

		public NativeVector UnknownNativeVector2;

		public NativeVector UnknownNativeVector3;

		public NativeVector jewels;

		public NativeVector UnknownNativeVector0;

		public NativeVector jewelsPassive;

		public NativeVector MasteryPassive;

		private long long_54;

		private long long_55;

		private long long_56;

		private long long_57;

		private long long_58;

		private long long_59;

		private long long_60;

		private long long_61;

		public byte PlayerClass;

		private byte byte_0;

		private byte byte_1;

		private byte byte_2;

		public uint PlayerLevel;

		public uint uint_4;

		public uint uint_5;

		public uint unknown_1;

		public uint ScionExtraPassiveSkillPointsLeft;

		public uint TotalAscendencyPoints;

		public uint SpentAscendencyPoints;

		private uint uint_6;

		public uint ExtraAscendancyPointSpent;

		private uint uint_7;

		private uint uint_8;

		private NativeHashMap nativeHashMap_0;
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct StructAtlasDataExtra
	{
		[FieldOffset(344)]
		public long long_0;

		[FieldOffset(352)]
		private long long_1;

		[FieldOffset(360)]
		private long long_2;

		[FieldOffset(1032)]
		public NativeVector ListAtlasPassiveTrees;

		[FieldOffset(1056)]
		public NativeVector ListAssignedAtlasPassive;

		[FieldOffset(1204)]
		public int totalGenericAtlasPassivePoints;

		[FieldOffset(1216)]
		public int totalBreachAtlasPassivePoints;

		[FieldOffset(1220)]
		public int totalExpeditionAtlasPassivePoints;

		[FieldOffset(1224)]
		public int totalDeliriumAtlasPassivePoints;

		[FieldOffset(1228)]
		public int totalRitualAtlasPassivePoints;

		[FieldOffset(1232)]
		public int totalAbyssAtlasPassivePoints;

		[FieldOffset(1236)]
		public int totalTempleAtlasPassivePoints;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct48
	{
		public byte byte_0;

		public byte byte_1;

		public byte byte_2;

		public byte byte_3;

		public byte byte_4;

		public byte byte_5;

		public byte byte_6;

		public byte byte_7;

		public byte byte_8;

		public byte byte_9;

		public int int_0;

		public byte byte_10;

		public byte byte_11;

		public byte byte_12;

		public byte byte_13;

		public byte byte_14;

		public byte byte_15;

		public byte byte_16;

		public byte byte_17;

		public byte byte_18;

		public byte byte_19;

		public byte byte_20;

		public byte byte_21;

		public short short_0;

		public short short_1;

		public byte byte_22;

		public byte byte_23;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct49
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;

		public uint uint_6;

		public uint uint_7;

		public uint uint_8;

		public uint uint_9;

		public uint uint_10;

		public uint uint_11;

		public uint uint_12;
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct GStruct0
	{
		[FieldOffset(96)]
		public long LocalPlayerData;

		[FieldOffset(8544)]
		public GStruct2 LeagueName;

		[FieldOffset(8576)]
		public uint InstanceId;

		[FieldOffset(8648)]
		public NativeVector minimapIconNativeVector;

		[FieldOffset(8776)]
		public uint ClientTickSnapshot;

		[FieldOffset(8776)]
		public ulong ulong_0;

		[FieldOffset(8784)]
		private int int_0;

		[FieldOffset(8792)]
		public uint ServerTick;

		[FieldOffset(8792)]
		public ulong ServerTick64;

		[FieldOffset(8800)]
		public uint LatencyAverage;

		[FieldOffset(8816)]
		public uint NetworkState;

		[FieldOffset(8828)]
		public byte PartyAllocationType;

		[FieldOffset(8829)]
		public byte LevelDownscaling;

		[FieldOffset(8864)]
		public GStruct2 PartyDescription;

		[FieldOffset(8896)]
		public GStruct2 PartyLeaderName;

		[FieldOffset(8960)]
		public NativeVector PartyMembers;

		[FieldOffset(8984)]
		public WaypointByteStructure ActiveWaypoints;

		[FieldOffset(9032)]
		public NativeVector AreaMonsterNames;

		[FieldOffset(9872)]
		public long AzmeriControllerPointer;

		[FieldOffset(10024)]
		public byte MonsterLevel;

		[FieldOffset(10025)]
		public byte MonsterRemaining;

		[FieldOffset(10200)]
		public NativeVector PlayerEntriesVec;

		[FieldOffset(10368)]
		public StructRitualMain StructRitualMain;
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct StructPoe2LocalPlayerData
	{
		[FieldOffset(432)]
		internal long long_0;

		[FieldOffset(800)]
		public NativeVector PlayerInventoriesVector;

		[FieldOffset(1216)]
		public NativeVector TradeInventoriesVector;

		[FieldOffset(30160)]
		internal long long_1;

		[FieldOffset(30240)]
		public NativeVector PendingPartyInvite;

		[FieldOffset(30912)]
		internal Struct49 struct49_0;

		[FieldOffset(31104)]
		public long ShapeshiftSkill1;

		[FieldOffset(31120)]
		public long ShapeshiftSkill2;

		[FieldOffset(31136)]
		public long ShapeshiftSkill3;

		[FieldOffset(31152)]
		public Vector2 WorldMousePosition;

		[FieldOffset(33104)]
		public uint int_DialogDepth;

		[FieldOffset(33856)]
		public uint DeliriumBarProgress;

		[FieldOffset(33984)]
		public NativeVector DeliriumEnconterRewardData;
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct StructPoe2LocalPlayerDataExtra
	{
		[FieldOffset(14800)]
		internal uint uint_0;

		[FieldOffset(14880)]
		internal long long_0;

		[FieldOffset(14912)]
		internal uint uint_1;

		[FieldOffset(14936)]
		public NativeVector PlayerCurrencyExchangeOrders;

		[FieldOffset(14992)]
		public NativeVector PlayerStashTabs;

		[FieldOffset(15016)]
		public NativeVector GuildStashTabs;

		[FieldOffset(15616)]
		public NativeVector GuildInventoriesVector;

		[FieldOffset(15672)]
		public NativeHashMap PlayerStashAffinityNativeHashMap;

		[FieldOffset(15736)]
		public NativeHashMap GuidStashAffinityNativeHashMap;

		[FieldOffset(16416)]
		public long GuidDataPtr;
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct StructUnlockedRecipe
	{
		[FieldOffset(0)]
		public unsafe fixed byte byte_0[112];
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct StructAtlasExtraFtructureFiller
	{
		[FieldOffset(0)]
		public unsafe fixed long long_0[82];
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ArchnemesisModStructure
	{
		public long unused_ArchnemesisModDat;

		public long unused_ArchnemesisModDatFile;

		public int int_ModLevel;

		public short short_0;

		public short short_1;
	}

	public struct WaypointByteStructure
	{
		public unsafe fixed byte data[19];
	}

	[CompilerGenerated]
	private sealed class _003Cget_SkillBarIds_003Ed__72 : IEnumerable<uint>, IEnumerable, IEnumerator<uint>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private uint _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public ServerData _003C_003E4__this;

		private Struct49 _003Cids_003E5__2;

		private static _003Cget_SkillBarIds_003Ed__72 _003Cget_SkillBarIds_003Ed__72_0;

		uint IEnumerator<uint>.Current => 0u;

		object IEnumerator.Current => null;

		public _003Cget_SkillBarIds_003Ed__72(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}

		IEnumerator<uint> IEnumerable<uint>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static _003Cget_SkillBarIds_003Ed__72 smethod_1()
		{
			return null;
		}

		static _003Cget_SkillBarIds_003Ed__72()
		{
			Class200.smethod_34();
		}
	}

	private static int int_0;

	private static int ajMnNlAiCb;

	private static int int_1;

	private static int frnntjskmq;

	private static int int_2;

	private static int int_3;

	private PerFrameCachedValue<Struct48> perFrameCachedValue_0;

	private PerFrameCachedValue<StructRitualMain> perFrameCachedValue_1;

	private PerFrameCachedValue<StructRitualData> perFrameCachedValue_2;

	internal PerFrameCachedValue<List<ArchnemesisModStructure>> uUqniAhoUG;

	internal static ServerData serverData_0;

	public long AzmeriControllerPointer => 0L;

	public NativeVector DeliriumEnconterRewardData => (NativeVector)(object)null;

	public uint Latency => 0u;

	public NativeVector MinimapIconNativeVector => (NativeVector)(object)null;

	public uint FrameCount => 0u;

	public NetworkState NetworkState => (NetworkState)(object)null;

	public uint DialogDepth => 0u;

	public NativeVector ExchangeOrders => (NativeVector)(object)null;

	public uint CharacterLevel => 0u;

	public uint WeponSet1SkiPoints => 0u;

	public uint WeponSet2SkiPoints => 0u;

	public uint TotalAscendencyPoints => 0u;

	public uint SpentAscendencyPoints => 0u;

	public uint ExtraAscendancyPointSpent => 0u;

	public int GenericAtlasPassivePoints => 0;

	public int RitualAtlasPassivePoints => 0;

	public int ExpeditionAtlasPassivePoints => 0;

	public int TempleAtlasPassivePoints => 0;

	public int DeliriumAtlasPassivePoints => 0;

	public int BreachAtlasPassivePoints => 0;

	public int AbyssAtlasPassivePoints => 0;

	public Dictionary<ushort, PassiveSkillGraphNode> PassiveSkillGraph => null;

	public Dictionary<ushort, PassiveSkillGraphNode> AtlasSkillGraph => null;

	public List<ushort> PassiveSkillIds => null;

	public List<Tuple<ushort, ushort>> PassiveMasterySkillIds => null;

	public List<List<uint>> AtlasPassiveSkillIdsTest => null;

	public List<uint> AtlasPassiveSkillIds => null;

	public List<ushort> JewelPassiveSkillIds => null;

	public List<ushort> NormalJewelPassiveSkillIds => null;

	public IEnumerable<uint> SkillBarIds
	{
		[IteratorStateMachine(typeof(_003Cget_SkillBarIds_003Ed__72))]
		get
		{
			return null;
		}
	}

	public byte[] ActiveWaypoints => null;

	public string League => null;

	public uint PlayerGolds => 0u;

	public uint PlayerHiveblood => 0u;

	public PartyAllocation PartyAllocationType => (PartyAllocation)(object)null;

	public bool LevelDownscalingEnabled => true;

	public string PartyLeaderName => null;

	public string PartyDescription => null;

	public NativeVector PlayerStashTabsVector => (NativeVector)(object)null;

	public NativeVector GuildStashTabsVector => (NativeVector)(object)null;

	public List<InventoryHolder> PlayerInventories => null;

	public List<long> PlayerInventoryWrapper => null;

	public List<InventoryHolder> TradeInventories => null;

	public List<InventoryHolder> NPCInventories => null;

	public List<InventoryHolder> GuildInventories => null;

	public byte MonsterLevel => 0;

	public byte MonstersRemaining => 0;

	public int Dynamite => 0;

	public int Flare => 0;

	public int MaxDepth => 0;

	public int CurrentAzuriteAmount => 0;

	public int CurrentSulphiteAmount => 0;

	public List<LokiPoe.StashTabAffinitiesEnum> StashTabAffinitiesList => null;

	[SpecialName]
	private static int smethod_2()
	{
		return 0;
	}

	internal int method_0(uint uint_0, int int_4, long long_1)
	{
		return 0;
	}

	internal bool method_1(out NetworkState networkState_0)
	{
		return true;
	}

	[SpecialName]
	internal NativeVector method_2()
	{
		return (NativeVector)(object)null;
	}

	[SpecialName]
	internal NativeVector method_3()
	{
		return (NativeVector)(object)null;
	}

	[SpecialName]
	internal NativeVector method_4()
	{
		return (NativeVector)(object)null;
	}

	private List<ServerStashTab> method_5(int int_4, int int_5)
	{
		return null;
	}

	public List<DreamPoeBot.Loki.Game.Inventory> GetPlayerInventoryBySlot(InventorySlot slot)
	{
		return null;
	}

	public List<DreamPoeBot.Loki.Game.Inventory> GetPlayerInventoryByType(InventoryType type)
	{
		return null;
	}

	public List<DreamPoeBot.Loki.Game.Inventory> GetPlayerInventoryBySlotAndType(InventoryType type, InventorySlot slot)
	{
		return null;
	}

	public DreamPoeBot.Loki.Game.Inventory GetPlayerInventoryById(int id)
	{
		return null;
	}

	[SpecialName]
	internal StructRitualMain method_6()
	{
		return (StructRitualMain)(object)null;
	}

	[SpecialName]
	internal StructRitualData method_7()
	{
		return (StructRitualData)(object)null;
	}

	[SpecialName]
	internal GStruct0 method_8()
	{
		return (GStruct0)(object)null;
	}

	[SpecialName]
	internal StructPoe2LocalPlayerData method_9()
	{
		return (StructPoe2LocalPlayerData)(object)null;
	}

	[SpecialName]
	internal StructPoe2LocalPlayerDataExtra method_10()
	{
		return (StructPoe2LocalPlayerDataExtra)(object)null;
	}

	[SpecialName]
	internal Struct48 method_11()
	{
		return (Struct48)(object)null;
	}

	[SpecialName]
	internal StructServerDataExtra method_12()
	{
		return (StructServerDataExtra)(object)null;
	}

	[SpecialName]
	internal StructAtlasDataExtra method_13()
	{
		return (StructAtlasDataExtra)(object)null;
	}

	private GStruct0 method_14()
	{
		return (GStruct0)(object)null;
	}

	private StructPoe2LocalPlayerData method_15()
	{
		return (StructPoe2LocalPlayerData)(object)null;
	}

	private StructPoe2LocalPlayerDataExtra method_16()
	{
		return (StructPoe2LocalPlayerDataExtra)(object)null;
	}

	private StructRitualData method_17()
	{
		return (StructRitualData)(object)null;
	}

	private Struct48 method_18()
	{
		return (Struct48)(object)null;
	}

	private StructServerDataExtra method_19()
	{
		return (StructServerDataExtra)(object)null;
	}

	private StructAtlasDataExtra method_20()
	{
		return (StructAtlasDataExtra)(object)null;
	}

	public void UpdateAddress(long l)
	{
	}

	static ServerData()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		int_0 = -1;
		ajMnNlAiCb = -1;
		int_1 = -1;
		frnntjskmq = -1;
		int_2 = -1;
		int_3 = -1;
	}

	internal static bool smethod_3()
	{
		return true;
	}

	internal static ServerData smethod_4()
	{
		return null;
	}
}
