using System;
using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

[Obsolete("Legacy Abyss API: not supported for the reworked encounter; retained for compatibility.", false)]
public class AbyssNodeSmall : TriggerableBlockage
{
	internal static AbyssNodeSmall abyssNodeSmall_0;

	public override string Name => null;

	internal AbyssNodeSmall(NetworkObject entry)
	{
	}

	internal static bool smethod_26()
	{
		return true;
	}

	internal static AbyssNodeSmall smethod_27()
	{
		return null;
	}

	static AbyssNodeSmall()
	{
		Class200.smethod_34();
	}
}
