using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Common;
using DreamPoeBot.Loki.FilesInMemory;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.Game.Utilities;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Game.GameData;

public static class Dat
{
	public class DatQuestRewardWrapper
	{
		[CompilerGenerated]
		private NativeQuestStaticReward nativeQuestStaticReward_0;

		[CompilerGenerated]
		private CharacterClass characterClass_0;

		[CompilerGenerated]
		private DatQuestWrapper datQuestWrapper_0;

		[CompilerGenerated]
		private DatBaseItemTypeWrapper datBaseItemTypeWrapper_0;

		[CompilerGenerated]
		private Rarity rarity_0;

		internal static DatQuestRewardWrapper datQuestRewardWrapper_0;

		public CharacterClass Class
		{
			[CompilerGenerated]
			get
			{
				return (CharacterClass)(object)null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public DatQuestWrapper Quest
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public DatBaseItemTypeWrapper Item
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public Rarity Rarity
		{
			[CompilerGenerated]
			get
			{
				return (Rarity)(object)null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		[SpecialName]
		[CompilerGenerated]
		internal NativeQuestStaticReward method_0()
		{
			return (NativeQuestStaticReward)(object)null;
		}

		[SpecialName]
		[CompilerGenerated]
		internal void method_1(NativeQuestStaticReward nativeQuestStaticReward_1)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static DatQuestRewardWrapper smethod_1()
		{
			return null;
		}

		static DatQuestRewardWrapper()
		{
			Class200.smethod_34();
		}
	}

	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct NativeQuestStaticReward
	{
		public int QuestId;

		public int _00;

		public int StatsKeysCount;

		public int _01;

		public long StatsKeysAddress;

		public int StatsValueCount;

		public int _02;

		public long StatsValueAddress;

		public long QuestDatAddress;

		public long QuestDatFile;

		public int _03;

		public long ClientStringAddress;

		public long ClientStringFile;

		public int _04;
	}

	[Serializable]
	private sealed class Class109
	{
		public static readonly Class109 class109_0;

		private static Class109 class109_1;

		internal string ftolZlswaZR(KeyValuePair<string, DatDivinationCardStashTabLayoutWrapper> keyValuePair_0)
		{
			return null;
		}

		internal int method_0(NativeExperienceLevels nativeExperienceLevels_0)
		{
			return 0;
		}

		internal int method_1(DatBaseItemTypeWrapper datBaseItemTypeWrapper_0)
		{
			return 0;
		}

		internal int method_2(DatQuestWrapper datQuestWrapper_0)
		{
			return 0;
		}

		internal int method_3(DatWordsWrapper datWordsWrapper_0)
		{
			return 0;
		}

		internal DatWordsWrapper VxVlZtIvfWa(DatWordsWrapper datWordsWrapper_0)
		{
			return null;
		}

		internal int method_4(DatBaseItemTypeWrapper datBaseItemTypeWrapper_0)
		{
			return 0;
		}

		internal int method_5(DatQuestWrapper datQuestWrapper_0)
		{
			return 0;
		}

		static Class109()
		{
			Class200.smethod_34();
			Class204.smethod_0();
			class109_0 = new Class109();
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class109 smethod_1()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct NativeExperienceLevels
	{
		public int NameIndex;

		public int Level;

		public uint Experience;
	}

	public static class Runtime
	{
		[CompilerGenerated]
		private sealed class _003Cget_MonsterVarieties2_003Ed__2 : IEnumerable<DatMonsterVarietyWrapper>, IEnumerable, IEnumerator<DatMonsterVarietyWrapper>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private DatMonsterVarietyWrapper _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private DatMonsterVarietyWrapper.MonsterVarietyStruct[] _003Cstruct286s_003E5__2;

			private int _003Ci_003E5__3;

			internal static _003Cget_MonsterVarieties2_003Ed__2 _003Cget_MonsterVarieties2_003Ed__2_0;

			DatMonsterVarietyWrapper IEnumerator<DatMonsterVarietyWrapper>.Current => null;

			object IEnumerator.Current => null;

			public _003Cget_MonsterVarieties2_003Ed__2(int _003C_003E1__state)
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

			IEnumerator<DatMonsterVarietyWrapper> IEnumerable<DatMonsterVarietyWrapper>.GetEnumerator()
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

			internal static _003Cget_MonsterVarieties2_003Ed__2 smethod_1()
			{
				return null;
			}

			static _003Cget_MonsterVarieties2_003Ed__2()
			{
				Class200.smethod_34();
			}
		}

		internal static Runtime runtime_0;

		public static IEnumerable<DatMonsterVarietyWrapper> MonsterVarieties2
		{
			[IteratorStateMachine(typeof(_003Cget_MonsterVarieties2_003Ed__2))]
			get
			{
				return null;
			}
		}

		internal static long smethod_0()
		{
			return 0L;
		}

		internal static bool smethod_1()
		{
			return true;
		}

		internal static Runtime smethod_2()
		{
			return null;
		}

		static Runtime()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private sealed class _003Cget_BestiaryRecipes_003Ed__61 : IEnumerable<DatBestiaryRecipesWrapper>, IEnumerable, IEnumerator<DatBestiaryRecipesWrapper>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private DatBestiaryRecipesWrapper _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private (long Address, DatBestiaryRecipesWrapper.Struct104 Value)[] _003Ctuples_003E5__2;

		private int _003Ci_003E5__3;

		internal static _003Cget_BestiaryRecipes_003Ed__61 _003Cget_BestiaryRecipes_003Ed__61_0;

		DatBestiaryRecipesWrapper IEnumerator<DatBestiaryRecipesWrapper>.Current => null;

		object IEnumerator.Current => null;

		public _003Cget_BestiaryRecipes_003Ed__61(int _003C_003E1__state)
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

		IEnumerator<DatBestiaryRecipesWrapper> IEnumerable<DatBestiaryRecipesWrapper>.GetEnumerator()
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

		internal static _003Cget_BestiaryRecipes_003Ed__61 smethod_1()
		{
			return null;
		}

		static _003Cget_BestiaryRecipes_003Ed__61()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private sealed class _003Cget_GetSkillGemsList_003Ed__55 : IEnumerable<DatSkillGemWrapper>, IEnumerable, IEnumerator<DatSkillGemWrapper>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private DatSkillGemWrapper _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private (long Address, DatSkillGemWrapper.Struct123 Value)[] _003Ctuples_003E5__2;

		private int _003Ci_003E5__3;

		internal static _003Cget_GetSkillGemsList_003Ed__55 _003Cget_GetSkillGemsList_003Ed__55_0;

		DatSkillGemWrapper IEnumerator<DatSkillGemWrapper>.Current => null;

		object IEnumerator.Current => null;

		public _003Cget_GetSkillGemsList_003Ed__55(int _003C_003E1__state)
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

		IEnumerator<DatSkillGemWrapper> IEnumerable<DatSkillGemWrapper>.GetEnumerator()
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

		internal static _003Cget_GetSkillGemsList_003Ed__55 smethod_1()
		{
			return null;
		}

		static _003Cget_GetSkillGemsList_003Ed__55()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private sealed class _003Cget_IncursionArchitect_003Ed__64 : IEnumerable<DatIncursionArchitectWrapper>, IEnumerable, IEnumerator<DatIncursionArchitectWrapper>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private DatIncursionArchitectWrapper _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private (long Address, DatIncursionArchitectWrapper.Struct115 Value)[] _003Ctuples_003E5__2;

		private int _003Ci_003E5__3;

		internal static _003Cget_IncursionArchitect_003Ed__64 _003Cget_IncursionArchitect_003Ed__64_0;

		DatIncursionArchitectWrapper IEnumerator<DatIncursionArchitectWrapper>.Current => null;

		object IEnumerator.Current => null;

		public _003Cget_IncursionArchitect_003Ed__64(int _003C_003E1__state)
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

		IEnumerator<DatIncursionArchitectWrapper> IEnumerable<DatIncursionArchitectWrapper>.GetEnumerator()
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

		internal static _003Cget_IncursionArchitect_003Ed__64 smethod_1()
		{
			return null;
		}

		static _003Cget_IncursionArchitect_003Ed__64()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private sealed class _003Cget_IncursionRooms_003Ed__67 : IEnumerable<DatIncursionRoomsWrapper>, IEnumerable, IEnumerator<DatIncursionRoomsWrapper>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private DatIncursionRoomsWrapper _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private DatIncursionRoomsWrapper.Struct116[] _003Cstruct104s_003E5__2;

		private int _003Ci_003E5__3;

		private static _003Cget_IncursionRooms_003Ed__67 _003Cget_IncursionRooms_003Ed__67_0;

		DatIncursionRoomsWrapper IEnumerator<DatIncursionRoomsWrapper>.Current => null;

		object IEnumerator.Current => null;

		public _003Cget_IncursionRooms_003Ed__67(int _003C_003E1__state)
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

		IEnumerator<DatIncursionRoomsWrapper> IEnumerable<DatIncursionRoomsWrapper>.GetEnumerator()
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

		internal static _003Cget_IncursionRooms_003Ed__67 smethod_1()
		{
			return null;
		}

		static _003Cget_IncursionRooms_003Ed__67()
		{
			Class200.smethod_34();
		}
	}

	private static readonly ILog ilog_0;

	private static Dictionary<Enum0, DatBaseItemTypeWrapper> dictionary_0;

	private static Dictionary<string, Enum0> dictionary_1;

	private static List<DatSkillGemWrapper> list_0;

	private static readonly Dictionary<long, DatIncursionArchitectWrapper> dictionary_2;

	private static List<DatQuestRewardWrapper> list_1;

	private static readonly Dictionary<string, DatQuestWrapper> dictionary_3;

	private static readonly Dictionary<long, EndgameMapContentWrapper> dictionary_4;

	private static Dictionary<string, Dictionary<int, DatQuestStateWrapper>> dictionary_5;

	private static PerFrameCachedValue<Dictionary<string, long>> perFrameCachedValue_0;

	private static long long_0;

	private static List<DelveLevelScalingWrapper> list_2;

	public static List<short> HellscapeModsDatList;

	internal static Dat dat_0;

	public static BaseItemTypeDat BaseItemTypeDat => null;

	public static WorldAreaDat WorldAreaDat => null;

	public static GrantedEffectsPerLevelDat GrantedEffectsPerLevelDat => null;

	public static QuestFlagsDat QuestFlagsDat => null;

	public static MinimapIconsDat MinimapIconsDat => null;

	public static StatsDat StatsDat => null;

	public static TagsDat TagsDat => null;

	public static PassiveSkillsDat PassiveSkillsDat => null;

	public static ActiveSkillsDat ActiveSkillsDat => null;

	public static ModsDat ModsDat => null;

	public static ClassPassiveSkillOverridesDat ClassPassiveSkillOverridesDat => null;

	public static EndGameMapsDat EndGameMapsDat => null;

	public static Expedition2RecipesDat Expedition2RecipesDat => null;

	public static GClass0 Expedition2RunesDat => null;

	public static PassiveSkillVariantsDat PassiveSkillVariantsDat => null;

	public static IEnumerable<DatQuestWrapper> Quests => null;

	public static IEnumerable<DatQuestStateWrapper> QuestStates => null;

	public static List<DatSkillGemWrapper> SkillGems => null;

	public static IEnumerable<DatSkillGemWrapper> GetSkillGemsList
	{
		[IteratorStateMachine(typeof(_003Cget_GetSkillGemsList_003Ed__55))]
		get
		{
			return null;
		}
	}

	public static List<DelveLevelScalingWrapper> DelveLevelScaling => null;

	public static IEnumerable<DatBestiaryRecipesWrapper> BestiaryRecipes
	{
		[IteratorStateMachine(typeof(_003Cget_BestiaryRecipes_003Ed__61))]
		get
		{
			return null;
		}
	}

	public static IEnumerable<DatIncursionArchitectWrapper> IncursionArchitect
	{
		[IteratorStateMachine(typeof(_003Cget_IncursionArchitect_003Ed__64))]
		get
		{
			return null;
		}
	}

	public static IEnumerable<DatIncursionRoomsWrapper> IncursionRooms
	{
		[IteratorStateMachine(typeof(_003Cget_IncursionRooms_003Ed__67))]
		get
		{
			return null;
		}
	}

	public static string PathToQuestRewardsDat => null;

	public static string PathToQuestRewardsDat2 => null;

	[SpecialName]
	private static Memory smethod_0()
	{
		return null;
	}

	public static DatQuestStateWrapper LookupQuestState(DatQuestWrapper quest, int stateId)
	{
		return null;
	}

	public static DatQuestStateWrapper LookupQuestState(string questId, int stateId)
	{
		return null;
	}

	public static DatClientStringWrapper LookupClientString(ClientStringsEnum arg)
	{
		return null;
	}

	internal static void smethod_1(string string_0, long long_1)
	{
	}

	internal static NativeVector smethod_2(long long_1)
	{
		return (NativeVector)(object)null;
	}

	internal static long smethod_3()
	{
		return 0L;
	}

	internal static long smethod_4()
	{
		return 0L;
	}

	internal static long smethod_5()
	{
		return 0L;
	}

	internal static DatIncursionArchitectWrapper smethod_6(long long_1, bool bool_0 = false)
	{
		return null;
	}

	public static void DumpStats()
	{
	}

	internal static NativeQuestStaticReward UriuHeCdwD(byte[] byte_0)
	{
		return (NativeQuestStaticReward)(object)null;
	}

	static Dat()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
		list_0 = new List<DatSkillGemWrapper>();
		dictionary_2 = new Dictionary<long, DatIncursionArchitectWrapper>();
		dictionary_3 = new Dictionary<string, DatQuestWrapper>();
		dictionary_4 = new Dictionary<long, EndgameMapContentWrapper>();
		list_2 = new List<DelveLevelScalingWrapper>();
		HellscapeModsDatList = new List<short>
		{
			24298, 24299, 24300, 24301, 24302, 24303, 24304, 24305, 24306, 24307,
			24308, 24309, 24310, 24311, 24312, 24313, 24314, 24315, 24316, 24317,
			24318, 24319, 24320, 24321, 24322, 24323, 24324, 24325, 24326, 24327,
			24328, 24329, 24330, 24331, 24332, 24333, 24334, 24335, 24336, 24337,
			24338, 24339, 24340, 24341, 24342, 24343, 24344, 24345, 24346, 24347,
			24348, 24349, 24350, 24351, 24352, 24353, 24354, 24355, 24356, 24357,
			24358, 24359, 24360, 24361, 24362, 24363, 24364, 24365, 24366, 24367,
			24368, 24369, 24370, 24371, 24372, 24373, 24374, 24375, 24376, 24377,
			24378, 24379, 24380, 24381, 24382, 24383, 24384, 24385, 24386, 24387,
			24388, 24389, 24390, 24391, 24392, 24393, 24394, 24395, 24396, 24397,
			24398, 24399, 24400, 24401, 24402, 24403, 24404, 24405, 24406, 24407,
			24408, 24409, 24410, 24411, 24412, 24413, 24414, 24415, 24416, 24417,
			24418, 24419, 24420, 24421, 24422, 24423, 24424, 24425, 24426, 24427,
			24428, 24429, 24430, 24431, 24432, 24433, 24434, 24435, 24436, 24437,
			24438, 24439, 24440, 24441, 24442, 24443, 24444, 24445, 24446, 24447,
			24448, 24449, 24450, 24451, 24452, 24453, 24454, 24455, 24456, 24457,
			24458, 24459, 24460, 24461, 24462, 24463, 24464, 24465, 24466, 24467,
			24468, 24469, 24470, 24471, 24472, 24473, 24474, 24475, 24476, 24477,
			24478, 24479, 24480, 24481, 24482, 24483, 24484, 24485, 24486, 24487,
			24488, 24489, 24490, 24491, 24492, 24493, 24494, 24495, 24496, 24497,
			24498, 24499, 24500, 24501, 24502, 24503, 24504, 24505, 24506, 24507,
			24508, 24509, 24510, 24511, 24512, 24513, 24514, 24515, 24516, 24517,
			24518, 24519, 24520, 24521, 24522, 24523, 24524, 24525, 24526, 24527,
			24528, 24529, 24530, 24531, 24532, 24533, 24534, 24535, 24536, 24537,
			24538, 24539, 24540, 24541, 24542, 24543, 24544, 24545, 24546, 24547,
			24548, 24549, 24550, 24551, 24552, 24553, 24554, 24555, 24556, 24557,
			24558, 24559, 24560, 24561, 24562, 24563, 24564, 24565, 24566, 24567,
			24568, 24569, 24570, 24571, 24572, 24573, 24574, 24575, 24576, 24577,
			24578, 24579, 24580, 24581, 24582, 24583, 24584, 24585, 24586, 24587,
			24588, 24589, 24590, 24591, 24592, 24593, 24594, 24595, 24596, 24597,
			24598, 24599, 24600, 24601, 24602, 24603, 24604, 24605, 24606, 24607,
			24608, 24609, 24610, 24611, 24612, 24613, 24614, 24615, 24616, 24617,
			24618, 24619, 24620, 24621, 24622, 24623, 24624, 24625, 24626, 24627,
			24628, 24629, 24630, 24631, 24632, 24633, 24634, 24635, 24636, 24637,
			24638, 24639, 24640, 24641, 24642, 24643, 24644, 24645, 24646, 24647,
			24648, 24649, 24650, 24651, 24652, 24653, 24654, 24655, 24656, 24657,
			24658, 24659, 24660, 24661, 24662, 24663, 24664, 24665, 24666, 24667,
			24668, 24669, 24670, 24671, 24672, 24673, 24674, 24675, 24676, 24677,
			24678, 24679, 24680, 24681, 24682, 24683, 24684, 24685, 24686, 24687,
			24688, 24689, 24690, 24691, 24692, 24693, 24694, 24695, 24696, 24697,
			24698, 24699, 24700, 24701, 24702, 24703, 24704, 24705, 24706, 24707,
			24708, 24709, 24710, 24711, 24712, 24713, 24714, 24715, 24716, 24717,
			24718, 24719, 24720, 24721, 24722, 24723, 24724, 24725, 24726, 24727,
			24728, 24729, 24730, 24731, 24732, 24733, 24734, 24735, 24736, 24737,
			24738, 24739, 24740, 24741, 24742, 24743, 24744, 24745, 24746, 24747,
			24748, 24749, 24750, 24751, 24752, 24753, 24754, 24755, 24756, 24757,
			24758, 24759, 24760, 24761, 24762, 24763, 24764, 24765, 24766, 24767,
			24768, 24769, 24770, 24771, 24772, 24773, 24774, 24775, 24776, 24777,
			24778, 24779, 24780, 24781, 24782, 24783, 24784, 24785, 24786, 24787,
			24788, 24789, 24790, 24791, 24792, 24793, 24794, 24795, 24796, 24797,
			24798, 24799, 24800, 24801, 24802, 24803, 24804, 24805, 24806, 24807,
			24808, 24809, 24810, 24811, 24812, 24813, 24814, 24815, 24816, 24817,
			24818, 24819, 24820, 24821, 24822, 24823, 24824, 24825, 24826, 24827,
			24828, 24829, 24830, 24831, 24832, 24833, 24834, 24835, 24836, 24837,
			24838, 24839, 24840, 24841, 24842, 24843, 24844, 24845, 24846, 24847,
			24848, 24849, 24850, 24851, 24852, 24853, 24854, 24855, 24856, 24857,
			24858, 24859, 24860, 24861, 24862, 24863, 24864, 24865, 24866, 24867,
			24868, 24869, 24870, 24871, 24872, 24873, 24874, 24875, 24876, 24877,
			24878, 24879, 24880, 24881, 24882, 24883, 24884, 24885, 24886, 24887,
			24888, 24889, 24890, 24891, 24892, 24893, 24894, 24895, 24896, 24897,
			24898, 24899, 24900, 24901, 24902, 24903, 24904, 24905, 24906, 24907,
			24908, 24909, 24910, 24911, 24912, 24913, 24914, 24915, 24916, 24917,
			24918, 24919, 24920, 24921, 24922, 24923, 24924, 24925, 24926, 24927,
			24928, 24929, 24930, 24931, 24932, 24933, 24934, 24935, 24936, 24937,
			24938, 24939, 24940, 24941, 24942, 24943, 24944, 24945, 24946, 24947,
			24948, 24949, 24950, 24951, 24952, 24953, 24954, 24955, 24956, 24957,
			24958, 24959, 24960, 24961, 24962, 24963, 24964, 24965, 24966, 24967,
			24968, 24969, 24970, 24971, 24972, 24973, 24974, 24975, 24976, 24977,
			24978, 24979, 24980, 24981, 24982, 24983, 24984, 24985, 24986, 24987,
			24988, 24989, 24990, 24991, 24992, 24993, 24994, 24995, 24996, 24997,
			24998, 24999, 25000, 25001, 25002, 25003, 25004, 25005, 25006, 25007,
			25008, 25009, 25010, 25011, 25012, 25013, 25014, 25015, 25016, 25017,
			25018, 25019, 25020, 25021, 25022, 25023, 25024, 25025, 25026, 25027,
			25028, 25029, 25030, 25031, 25032, 25033, 25034, 25035, 25036, 25037,
			25038, 25039, 25040, 25041, 25042, 25043, 25044, 25045, 25046, 25047,
			25048, 25049, 25050, 25051, 25052, 25053, 25054, 25055, 25056, 25057,
			25058, 25059, 25060, 25061, 25062, 25063, 25064, 25065, 25066, 25067,
			25068, 25069, 25070, 25071, 25072, 25073, 25074, 25075, 25076, 25077,
			25078, 25079, 25080, 25081, 25082, 25083, 25084, 25085, 25086, 25087,
			25088, 25089, 25090, 25091, 25092, 25093, 25094, 25095, 25096, 25097,
			25098, 25099, 25100, 25101, 25102, 25103, 25104, 25105, 25106, 25107,
			25108, 25109, 25110, 25111, 25112, 25113, 25114, 25115, 25116, 25117,
			25118, 25119, 25120, 25121, 25122, 25123, 25124, 25125, 25126, 25127,
			25128, 25129, 25130, 25131, 25132, 25133, 25134, 25135, 25136, 25137,
			25138, 25139, 25140, 25141, 25142, 25143, 25144, 25145, 25146, 25147,
			25148, 25149, 25150, 25151, 25152, 25153, 25154, 25155, 25156, 25157,
			25158, 25159, 25160, 25161, 25162, 25163, 25164, 25165, 25166, 25167,
			25168, 25169, 25170, 25171, 25172, 25173, 25174, 25175, 25176, 25177,
			25178, 25179, 25180, 25181, 25182, 25183, 25184, 25185, 25186, 25187,
			25188, 25189, 25190, 25191, 25192, 25193, 25194, 25195, 25196, 25197,
			25198, 25199, 25200, 25201, 25202, 25203, 25204, 25205, 25206, 25207,
			25208, 25209, 25215, 25216, 25217, 25218, 25219, 25220, 25221, 25222,
			25223, 25224, 25225, 25226, 25227, 25228, 25229, 25230, 25231, 25232,
			25233, 25234, 25235, 25236, 25237, 25238, 25239, 25240, 25241, 25242,
			25243, 25244, 25245, 25246, 25247, 25248, 25249, 25250, 25251, 25252,
			25253, 25254, 25255, 25256, 25257, 25258, 25259, 25260, 25261, 25262,
			25263, 25264, 25265, 25266, 25267, 25268, 25269, 25270, 25271, 25272,
			25273, 25274, 25275, 25276, 25277, 25278, 25279, 25280, 25281, 25282,
			25283, 25284, 25285, 25286, 25287, 25288, 25289, 25290, 25291, 25292,
			25293, 25294, 25295, 25296, 25297, 25298, 25299, 25300, 25301, 25302,
			25303, 25304, 25305, 25306, 25307, 25308, 25309, 25310, 25311, 25312,
			25313, 25314, 25315, 25316, 25317, 25318, 25319, 25320, 25321, 25322,
			25323, 25324, 25325, 25326, 25327, 25328, 25329, 25330, 25331, 25332,
			25333, 25334, 25335, 25336, 25337, 25338, 25339, 25340, 25341, 25342,
			25343, 25344, 25345, 25346, 25347, 25348, 25349, 25350, 25351, 25352,
			25353, 25354, 25355, 25356, 25357, 25358, 25359, 25360, 25361, 25362,
			25363, 25364, 25365, 25366, 25367, 25368, 25369, 25370, 25371, 25372,
			25373, 25374, 25375, 25376, 25377, 25378, 25379, 25380, 25381, 25382,
			25383, 25384, 25385, 25386, 25387, 25388, 25389, 25390, 25391, 25392,
			25393, 25394, 25395, 25396, 25397, 25398, 25399, 25400, 25401, 25402,
			25403, 25404, 25405, 25406, 25407, 25408, 25409, 25410, 25411, 25412,
			25413, 25414, 25415, 25416, 25417, 25418, 25419, 25420, 25421, 25422,
			25423, 25424, 25425, 25426, 25427, 25428, 25429, 25430, 25431, 25432,
			25433, 25434, 25435, 25436, 25437, 25438, 25439, 25440, 25441, 25442,
			25443, 25444, 25445, 25446, 25447, 25448, 25449, 25450, 25451, 25452,
			25453, 25454, 25455, 25456, 25457, 25458, 25459, 25460, 25461, 25462,
			25463, 25464, 25465, 25466, 25467, 25468, 25469, 25470, 25471, 25472,
			25473, 25474, 25475, 25476, 25477, 25478, 25479, 25480, 25481, 25482,
			25483, 25484, 25485, 25486, 25487, 25488, 25489, 25490, 25491, 25492,
			25493, 25494, 25495, 25496, 25497, 25498, 25499, 25500, 25501, 25502,
			25503, 25504, 25505, 25506, 25507, 25508, 25509, 25510, 25511, 25512,
			25513, 25514, 25515, 25516, 25517, 25518, 25519, 25520, 25521, 25522,
			25523, 25524, 25525, 25526, 25527, 25528, 25529, 25530, 25531, 25532,
			25533, 25534, 25535, 25536, 25537, 25538, 25539, 25540, 25541, 25542,
			25543, 25544, 25545, 25546, 25547, 25548, 25549, 25550, 25551, 25552,
			25553, 25554, 25555, 25556, 25557, 25558, 25559, 25560, 25561, 25562,
			25563, 25564, 25565, 25566, 25567, 25568, 25569, 25570, 25576, 25577,
			25578, 25579, 25580, 25581, 25582, 25583, 25584, 25585, 25586, 25587,
			25588, 25589, 25210, 25211, 25212, 25213, 25214, 25571, 25572, 25573,
			25574, 25575
		};
	}

	internal static bool smethod_7()
	{
		return true;
	}

	internal static Dat smethod_8()
	{
		return null;
	}
}
