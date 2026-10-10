using System;
using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

[Obsolete("Legacy Abyss API: not supported for the reworked encounter; retained for compatibility.", false)]
public class AbyssCrackSpawner : NetworkObject
{
	internal static AbyssCrackSpawner abyssCrackSpawner_0;

	public override string Name => null;

	internal AbyssCrackSpawner(NetworkObject entry)
	{
	}

	internal static bool smethod_24()
	{
		return true;
	}

	internal static AbyssCrackSpawner smethod_25()
	{
		return null;
	}

	static AbyssCrackSpawner()
	{
		Class200.smethod_34();
	}
}
