using System;
using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

[Obsolete("Legacy Abyss API: not supported for the reworked encounter; retained for compatibility.", false)]
public class AbyssStartNode : NetworkObject
{
	private static AbyssStartNode abyssStartNode_0;

	public override string Name => null;

	internal AbyssStartNode(NetworkObject entry)
	{
	}

	internal static bool smethod_24()
	{
		return true;
	}

	internal static AbyssStartNode smethod_25()
	{
		return null;
	}

	static AbyssStartNode()
	{
		Class200.smethod_34();
	}
}
