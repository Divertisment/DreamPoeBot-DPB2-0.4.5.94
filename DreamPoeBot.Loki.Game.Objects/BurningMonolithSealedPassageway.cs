using System.Collections.Generic;
using DreamPoeBot.Loki.Elements;
using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

public class BurningMonolithSealedPassageway : NetworkObject
{
	internal static BurningMonolithSealedPassageway burningMonolithSealedPassageway_0;

	private new BurningMonolithSealedPassagewayElement Ui => null;

	public bool IsVisible => true;

	public IReadOnlyList<BurningMonolithFragmentSlot> Slots => null;

	public Element ActivateButton => null;

	public bool IsActivateVisible => true;

	public bool IsActivateEnabled => true;

	public bool Activate()
	{
		return true;
	}

	public void Click()
	{
	}

	internal BurningMonolithSealedPassageway(NetworkObject entry)
	{
	}

	internal static bool smethod_24()
	{
		return true;
	}

	internal static BurningMonolithSealedPassageway smethod_25()
	{
		return null;
	}

	static BurningMonolithSealedPassageway()
	{
		Class200.smethod_34();
	}
}
