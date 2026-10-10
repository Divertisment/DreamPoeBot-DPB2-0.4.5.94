using System;
using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

[Obsolete("Legacy Abyss API: not supported for the reworked encounter; retained for compatibility.", false)]
public class AbyssNodeMini : NetworkObject
{
	private static AbyssNodeMini abyssNodeMini_0;

	public override string Name => null;

	public float TimeLeft => 0f;

	internal AbyssNodeMini(NetworkObject entry)
	{
	}

	internal static bool smethod_24()
	{
		return true;
	}

	internal static AbyssNodeMini smethod_25()
	{
		return null;
	}

	static AbyssNodeMini()
	{
		Class200.smethod_34();
	}
}
