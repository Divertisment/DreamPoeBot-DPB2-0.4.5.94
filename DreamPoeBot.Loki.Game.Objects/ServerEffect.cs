using DreamPoeBot.Loki.Models;
using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

public class ServerEffect : NetworkObject
{
	public const string TypeMetadata = "Metadata/Effects/ServerEffect";

	internal static ServerEffect serverEffect_0;

	internal ServerEffect(EntityWrapper entry)
	{
	}

	internal ServerEffect(NetworkObject entry)
	{
	}

	public override string ToString()
	{
		return null;
	}

	internal static bool smethod_24()
	{
		return true;
	}

	internal static ServerEffect smethod_25()
	{
		return null;
	}

	static ServerEffect()
	{
		Class200.smethod_34();
	}
}
