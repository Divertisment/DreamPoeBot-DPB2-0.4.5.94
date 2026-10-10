using DreamPoeBot.Common;
using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

public class Arrow : NetworkObject
{
	public const string TypeMetadata = "Metadata/Effects/Spells/Masters/Dex/Arrow";

	internal static Arrow arrow_0;

	public override string Name => null;

	public Vector2i Destination => (Vector2i)(object)null;

	public bool Visible => true;

	internal Arrow(NetworkObject entry)
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

	internal static Arrow smethod_25()
	{
		return null;
	}

	static Arrow()
	{
		Class200.smethod_34();
	}
}
