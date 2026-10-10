using DreamPoeBot.Loki.Models;
using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

public class Effect : NetworkObject
{
	public const string TypeMetadata = "Metadata/Effects/Effect";

	internal static Effect effect_0;

	internal Effect(EntityWrapper entry)
	{
	}

	internal Effect(NetworkObject entry)
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

	internal static Effect smethod_25()
	{
		return null;
	}

	static Effect()
	{
		Class200.smethod_34();
	}
}
