using System;
using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

[Obsolete("Legacy Abyss API: not supported for the reworked encounter; retained for compatibility.", false)]
public class AbyssFinalNodeChest : TriggerableBlockage
{
	internal static AbyssFinalNodeChest abyssFinalNodeChest_0;

	public override string Name => null;

	internal AbyssFinalNodeChest(NetworkObject entry)
	{
	}

	internal static bool smethod_26()
	{
		return true;
	}

	internal static AbyssFinalNodeChest smethod_27()
	{
		return null;
	}

	static AbyssFinalNodeChest()
	{
		Class200.smethod_34();
	}
}
