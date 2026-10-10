using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Common;
using DreamPoeBot.Loki.FilesInMemory;
using DreamPoeBot.Loki.FilesInMemory.Base;
using DreamPoeBot.Loki.Game.Utilities;
using DreamPoeBot.Loki.RemoteMemoryObjects;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Controllers;

public class FsController
{
	private class Class116
	{
		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private Dictionary<string, string> dictionary_0;

		private static Class116 class116_0;

		[SpecialName]
		[CompilerGenerated]
		public string method_0()
		{
			return null;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_1(string string_1)
		{
		}

		[SpecialName]
		[CompilerGenerated]
		public Dictionary<string, string> method_2()
		{
			return null;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_3(Dictionary<string, string> dictionary_1)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class116 smethod_1()
		{
			return null;
		}

		static Class116()
		{
			Class200.smethod_34();
		}
	}

	public readonly struct FileInformation
	{
		[CompilerGenerated]
		private readonly long long_0;

		[CompilerGenerated]
		private readonly int int_0;

		internal static object object_0;

		public long Ptr
		{
			[CompilerGenerated]
			get
			{
				return 0L;
			}
		}

		public int ChangeCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		public FileInformation(long ptr, int changeCount)
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

		static FileInformation()
		{
			Class200.smethod_34();
		}
	}

	private static readonly ILog Log;

	private readonly Lazy<BaseItemTypeDat> lazy_0;

	private readonly RetryingLazy<ModsDat> retryingLazy_0;

	private readonly Lazy<StatsDat> lazy_1;

	private readonly Lazy<TagsDat> lazy_2;

	private readonly Lazy<GroundEffectsDat> lazy_3;

	private readonly Lazy<MiscAnimatedDat> lazy_4;

	private readonly Lazy<ClientStringsDat> lazy_5;

	private readonly Lazy<GrantedEffectsPerLevelDat> lazy_6;

	private readonly Lazy<QuestFlagsDat> lazy_7;

	private readonly Lazy<MinimapIconsDat> lazy_8;

	private readonly Lazy<ActiveSkillsDat> lazy_9;

	private readonly RetryingLazy<WorldAreaDat> retryingLazy_1;

	private readonly Lazy<PassiveSkillsDat> lazy_10;

	private readonly Lazy<ClassPassiveSkillOverridesDat> lazy_11;

	private readonly Lazy<EndGameMapsDat> lazy_12;

	private readonly Lazy<PassiveSkillVariantsDat> dcnFbWecws;

	private readonly Lazy<RitualAtlaslineModsDat> lazy_13;

	private readonly RetryingLazy<GClass0> retryingLazy_2;

	private readonly RetryingLazy<Expedition2RecipesDat> retryingLazy_3;

	private readonly RetryingLazy<Class40> retryingLazy_4;

	private readonly object object_0;

	private long long_0;

	private BreachStashTabLayout breachStashTabLayout_0;

	private AbyssStashTabLayout abyssStashTabLayout_0;

	private ExpeditionStashTabLayout expeditionStashTabLayout_0;

	private SocketableStashTabLayout socketableStashTabLayout_0;

	private DeliriumStashTabLayouts deliriumStashTabLayouts_0;

	private FragmentStashTabLayouts fragmentStashTabLayouts_0;

	private readonly object object_1;

	private CurrencyStashTabLayouts currencyStashTabLayouts_0;

	private EssenceStashTabLayouts essenceStashTabLayouts_0;

	private RitualStashTabLayouts ritualStashTabLayouts_0;

	private static PantheonSoulsDatFileWrapper pantheonSoulsDatFileWrapper_0;

	public PantheonSoulsDatFileWrapper PantheonSoulsDatFileWrapper;

	private BlightStashTabLayouts blightStashTabLayouts_0;

	private static StatDescription statDescription_0;

	private EndGameMapContent endGameMapContent_0;

	private LabyrinthTrials labyrinthTrials_0;

	private UniversalFileWrapper<Quest> universalFileWrapper_0;

	private long long_1;

	private long long_2;

	private long long_3;

	private long long_4;

	private QuestStates questStates_0;

	private MonsterVarieties monsterVarieties_0;

	private QuestReward questReward_0;

	private PerAreaCachedValue<Dictionary<string, long>> perAreaCachedValue_0;

	private bool bool_0;

	private readonly Memory memory_0;

	private readonly object object_2;

	private static FsController fsController_0;

	public BaseItemTypeDat BaseItemTypeDat => null;

	public ModsDat Mods => null;

	public StatsDat Stats => null;

	public TagsDat Tags => null;

	public GroundEffectsDat GroundEffects => null;

	public MiscAnimatedDat MiscAnimated => null;

	public ClientStringsDat ClientStrings => null;

	public GrantedEffectsPerLevelDat GrantedEffectsPerLevel => null;

	public QuestFlagsDat QuestFlags => null;

	public WorldAreaDat WorldAreaDat => null;

	public PassiveSkillsDat PassiveSkillsDat => null;

	public MinimapIconsDat MinimapIconsDat => null;

	public ActiveSkillsDat ActiveSkillsDat => null;

	public ClassPassiveSkillOverridesDat ClassPassiveSkillOverridesDat => null;

	public EndGameMapsDat EndGameMapDat => null;

	public RitualAtlaslineModsDat RitualAtlaslineModsDat => null;

	public Expedition2RecipesDat Expedition2RecipesDat => null;

	public GClass0 Expedition2RunesDat => null;

	public PassiveSkillVariantsDat PassiveSkillVariantsDat => null;

	public BreachStashTabLayout BreachStashTabLayoutDat => null;

	public AbyssStashTabLayout AbyssStashTabLayoutDat => null;

	public ExpeditionStashTabLayout ExpeditionStashTabLayoutDat => null;

	public SocketableStashTabLayout SocketableStashTabLayoutDat => null;

	public DeliriumStashTabLayouts DeliriumStashTabLayoutsDat => null;

	public FragmentStashTabLayouts FragmentStashTabLayoutDat => null;

	public CurrencyStashTabLayouts CurrencyStashTabLayoutDat => null;

	public EssenceStashTabLayouts EssenceStashTabLayoutDat => null;

	public RitualStashTabLayouts RitualStashTabLayoutDat => null;

	public BlightStashTabLayouts BlightStashTabLayoutDat => null;

	public StatDescription StatDescription => null;

	public EndGameMapContent EndGameMapContentDat => null;

	public LabyrinthTrials LabyrinthTrials => null;

	public UniversalFileWrapper<Quest> Quests => null;

	public long SkillGemsPtr => 0L;

	public long IncursionArchitect => 0L;

	public long DelveLevelScaling => 0L;

	public long IncursionRooms => 0L;

	public QuestStates QuestStates => null;

	public MonsterVarieties MonsterVarieties => null;

	[SpecialName]
	internal Class40 method_0()
	{
		return null;
	}

	internal bool method_1()
	{
		return true;
	}

	public void ReloadQuests()
	{
	}

	public void ReloadQuestsState()
	{
	}

	[SpecialName]
	internal Dictionary<string, long> method_2()
	{
		return null;
	}

	public void LoadDataFiles()
	{
	}

	public FsController(Memory me)
	{
	}

	private void method_3()
	{
	}

	public bool DumpDataFiles()
	{
		return true;
	}

	public long FindFile(string[] names, bool reload = false)
	{
		return 0L;
	}

	public long FindFile(string name, bool reload = false, int timeout = 5000)
	{
		return 0L;
	}

	internal long method_4(string string_0, int int_0 = 2000)
	{
		return 0L;
	}

	public Dictionary<string, long> GetAllFilesNew()
	{
		return null;
	}

	private long method_5(string string_0, bool bool_1 = false)
	{
		return 0L;
	}

	private long method_6(string[] string_0, bool bool_1 = false)
	{
		return 0L;
	}

	static FsController()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		Log = Logger.GetLoggerInstanceForType();
	}

	[CompilerGenerated]
	private ModsDat method_7()
	{
		return null;
	}

	[CompilerGenerated]
	private MinimapIconsDat method_8()
	{
		return null;
	}

	[CompilerGenerated]
	private ActiveSkillsDat method_9()
	{
		return null;
	}

	[CompilerGenerated]
	private GrantedEffectsPerLevelDat method_10()
	{
		return null;
	}

	[CompilerGenerated]
	private GroundEffectsDat method_11()
	{
		return null;
	}

	[CompilerGenerated]
	private MiscAnimatedDat method_12()
	{
		return null;
	}

	[CompilerGenerated]
	private ClientStringsDat method_13()
	{
		return null;
	}

	[CompilerGenerated]
	private TagsDat method_14()
	{
		return null;
	}

	[CompilerGenerated]
	private QuestFlagsDat method_15()
	{
		return null;
	}

	[CompilerGenerated]
	private WorldAreaDat method_16()
	{
		return null;
	}

	[CompilerGenerated]
	private PassiveSkillsDat method_17()
	{
		return null;
	}

	[CompilerGenerated]
	private BaseItemTypeDat method_18()
	{
		return null;
	}

	[CompilerGenerated]
	private StatsDat method_19()
	{
		return null;
	}

	[CompilerGenerated]
	private ClassPassiveSkillOverridesDat method_20()
	{
		return null;
	}

	[CompilerGenerated]
	private EndGameMapsDat method_21()
	{
		return null;
	}

	[CompilerGenerated]
	private PassiveSkillVariantsDat method_22()
	{
		return null;
	}

	[CompilerGenerated]
	private GClass0 bFeFgwvoYT()
	{
		return null;
	}

	[CompilerGenerated]
	private Expedition2RecipesDat method_23()
	{
		return null;
	}

	[CompilerGenerated]
	private Class40 method_24()
	{
		return null;
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static FsController smethod_1()
	{
		return null;
	}
}
