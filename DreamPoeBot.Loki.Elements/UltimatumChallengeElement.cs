using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Game.Objects;
using DreamPoeBot.Loki.Game.Std;
using ns0;

namespace DreamPoeBot.Loki.Elements;

public class UltimatumChallengeElement : Element
{
	private static UltimatumChallengeElement ultimatumChallengeElement_0;

	public new bool IsVisible => true;

	public Element BeginButton => null;

	public Element PreviewRewardsButton => null;

	public Element RewardsElement => null;

	public Element TakeRewardsButton => null;

	public string Title => null;

	public List<Item> RewardItem => null;

	public Dictionary<long, Element> OptionElementsDictionary => null;

	[SpecialName]
	private Element method_29()
	{
		return null;
	}

	[SpecialName]
	internal int method_30()
	{
		return 0;
	}

	[SpecialName]
	internal NativeVector method_31()
	{
		return (NativeVector)(object)null;
	}

	internal int method_32(long long_5)
	{
		return 0;
	}

	internal static bool smethod_11()
	{
		return true;
	}

	internal static UltimatumChallengeElement smethod_12()
	{
		return null;
	}

	static UltimatumChallengeElement()
	{
		Class200.smethod_34();
	}
}
