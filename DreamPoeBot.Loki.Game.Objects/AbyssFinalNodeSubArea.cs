using System;
using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

[Obsolete("Legacy Abyss API: not supported for the reworked encounter; retained for compatibility.", false)]
public class AbyssFinalNodeSubArea : TriggerableBlockage
{
	private static AbyssFinalNodeSubArea abyssFinalNodeSubArea_0;

	public override string Name => null;

	internal AbyssFinalNodeSubArea(NetworkObject entry)
	{
	}

	internal static bool smethod_26()
	{
		return true;
	}

	internal static AbyssFinalNodeSubArea smethod_27()
	{
		return null;
	}

	static AbyssFinalNodeSubArea()
	{
		Class200.smethod_34();
	}
}
