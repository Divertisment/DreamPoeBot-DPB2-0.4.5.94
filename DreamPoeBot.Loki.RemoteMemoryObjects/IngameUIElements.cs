using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Elements;
using DreamPoeBot.Loki.Game;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.RemoteMemoryObjects;

public class IngameUIElements : Element
{
	public static LokiPoe.PoeVersion UIClientVersion;

	private PerAreaCachedValue<long> perAreaCachedValue_0;

	private PerAreaCachedValue<ItemsOnGroundLabelElement> perAreaCachedValue_1;

	private static long long_5;

	private static IngameUIElements ingameUIElements_0;

	public Element SkillGemPanel => null;

	public long ThisAddress => 0L;

	public Element RootUI => null;

	public MainUiElement MainUi => null;

	public HudUIElement HudUI => null;

	public ContextMenuUiElement ContextMenuUi => null;

	public PopupManagerElement PopupManager => null;

	public Element QuickFlaskHud => null;

	public Element ChatToggle => null;

	public CursorElement CursorOverlay => null;

	public SkillBarElement SkillBar => null;

	public HiddenSkillBarElement HiddenSkillBar => null;

	public PartyHudUIElement PartyHudUI => null;

	public Element HideoutUnlocked => null;

	public Element SkipCutscenePanel => null;

	public MovementModeSelectionElement MovementModeSelectionPanel => null;

	public TimersPannelElement TimersPannel => null;

	public PoeChatElement ChatBox => null;

	public UiQuestStatesElement UiQuestStates => null;

	public Element OpenLeftPanel => null;

	public Element OpenRightPanel => null;

	public Element ShopPannel => null;

	public InventoryElement InventoryPanel => null;

	public StashElement StashPannel => null;

	public MerchantPanelElement MerchantPanel => null;

	public StashElement GuildStashPannel => null;

	public SocialPanelElement SocialPanel => null;

	public PassiveTreeElement TreePanel => null;

	public AtlasSkillElement AtlasSkillPanel => null;

	public OptionsElement OptionsPannel => null;

	public Element SkillGemcutting => null;

	public Element SupportGemcutting => null;

	public Element BuffSkillsGemcutting => null;

	public WorldElement2 WorldPanel2 => null;

	public Element MicrotransactionPannel => null;

	public Element RelicAltar1 => null;

	public Element RelicAltar2 => null;

	public Element RelicLocker => null;

	public MapElement MapPannel => null;

	public Element NewNpcDialogUi => null;

	public RewardElement RewardPannel => null;

	public GClass1 NPCBuyWindowUi => null;

	public DisenchantElement DisenchantPanel => null;

	public TradeUiElement TradeUi => null;

	public AscendUIElement AscendUI => null;

	public HideoutSelectionElement HideoutSelection => null;

	public InstillingElement InstillingUi => null;

	public RitualFavorElement RitualFavorUi => null;

	public RuneshapeConbinationsElement RuneshapeConbinationsUi => null;

	public Element TrialOfSeckhemasMap => null;

	public CurrencyExchangeElement CurrencyExchangeUi => null;

	public ReforgingBenchElement ReforgingBenchUi => null;

	public Element CheckPointUI => null;

	public TheGenesisTreeElement TheGenesisTreeUi => null;

	public Element MinionsDisplaydUi => null;

	public Element SigilsDisplayUi => null;

	public Element BuffsDisplayUi => null;

	public Element DeBuffsDisplayUi => null;

	public AtlasWarningElement AtlasWarningDialog => null;

	public PremiumStashSettingElement PremiumStashSettingUi => null;

	public DisplayNoteElement DisplayNoteUI => null;

	public SplitStackUiElement SplitStackUi => null;

	public TradePriceItemDialogElement TradePriceItemDialog => null;

	public GlobalWarningDialogElement GlobalWarningDialog => null;

	public InstanceManager InstanceManager => null;

	public Element WaitingForTradeDialog => null;

	public ResurrectElement ResurrectPannel => null;

	public Element DeliriumEndButton => null;

	public ShowRitualRewardElement ShowRitualRewardButton => null;

	public ToggleExplosivePlacementElement ExplosivePlacementPannel => null;

	public Element HideoutControlPannel => null;

	public Element HideoutMusicPannel => null;

	public Element EnteringAreaMessage => null;

	public NotificationHudElement NotificationHud => null;

	public Element DeiriumRewardUi => null;

	public EncounterDisplayContainerElement EncounterDisplayContainerPanel => null;

	public TempleOfferingElement TempleOfferingUi => null;

	public long Azmeri_dust_hud_display_Address => 0L;

	public TempleConsoleElement TempleConsolePanel => null;

	public ItemsOnGroundLabelElement ItemsOnGroundLabelElement => null;

	public IEnumerable<ItemsOnGroundLabelElement> ItemsOnGroundLabels => null;

	public Dictionary<int, ItemsOnGroundLabelElement> ItemsOnGroundLabelsDictionary => null;

	public List<Tuple<Quest, int>> GetNormalQuests => null;

	public List<Tuple<Quest, int>> GetUncompletedNormalQuests => null;

	public List<Tuple<Quest, int>> GetCompletedNornalQuests => null;

	public Dictionary<string, KeyValuePair<Quest, QuestState>> GetNormalQuestStates => null;

	[SpecialName]
	private int method_29()
	{
		return 0;
	}

	static IngameUIElements()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		UIClientVersion = LokiPoe.PoeVersion.Unknown;
		long_5 = 880L;
	}

	[CompilerGenerated]
	private long method_30()
	{
		return 0L;
	}

	[CompilerGenerated]
	private ItemsOnGroundLabelElement method_31()
	{
		return null;
	}

	internal static bool smethod_11()
	{
		return true;
	}

	internal static IngameUIElements smethod_12()
	{
		return null;
	}
}
