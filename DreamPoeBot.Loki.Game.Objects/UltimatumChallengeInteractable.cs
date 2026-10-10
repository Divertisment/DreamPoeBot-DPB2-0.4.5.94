using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Common;
using DreamPoeBot.Loki.Elements;
using DreamPoeBot.Loki.Game.GameData;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

public class UltimatumChallengeInteractable : NetworkObject
{
	public enum BeginTrialResult
	{
		None,
		UiNotVisible,
		OptionNotSelected,
		ProcessHookManagerNotEnabled
	}

	public enum SelectOptionResult
	{
		None,
		UiNotVisible,
		OptionNotPresent,
		OptionElementNotFound,
		ProcessHookManagerNotEnabled
	}

	public enum TakeRewardResult
	{
		None,
		UiNotVisible,
		ProcessHookManagerNotEnabled
	}

	private static readonly ILog ilog_1;

	internal static UltimatumChallengeInteractable ultimatumChallengeInteractable_0;

	public new UltimatumChallengeElement Ui => null;

	public bool IsInterfaceVisible => true;

	public string TrialTitle => null;

	public Item RewardItem => null;

	public List<DatUltimatumModifiersWrapper> Options => null;

	public DatUltimatumModifiersWrapper SelectedOption => null;

	public bool IsTrialActive => true;

	public bool IsTrialCompleted => true;

	public bool IsRewardPreviewWindowOpen => true;

	public int GetVoteForOption(DatUltimatumModifiersWrapper option)
	{
		return 0;
	}

	public void OpenRewardPreview()
	{
	}

	public TakeRewardResult TakeReward()
	{
		return (TakeRewardResult)(object)null;
	}

	public BeginTrialResult BeginTrial()
	{
		return (BeginTrialResult)(object)null;
	}

	public SelectOptionResult SelectOption(DatUltimatumModifiersWrapper option)
	{
		return (SelectOptionResult)(object)null;
	}

	public new string Dump()
	{
		return null;
	}

	internal UltimatumChallengeInteractable(NetworkObject entry)
	{
	}

	[SpecialName]
	internal List<string> method_7()
	{
		return null;
	}

	static UltimatumChallengeInteractable()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_1 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_24()
	{
		return true;
	}

	internal static UltimatumChallengeInteractable smethod_25()
	{
		return null;
	}
}
