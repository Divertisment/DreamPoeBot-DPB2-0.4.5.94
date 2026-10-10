using DreamPoeBot.Loki.Models;
using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

public class Stash : NetworkObject
{
	public const string TypeMetadata = "Metadata/MiscellaneousObjects/Stash";

	private static Stash stash_0;

	internal Stash(EntityWrapper entity)
	{
	}

	internal static bool smethod_24()
	{
		return true;
	}

	internal static Stash smethod_25()
	{
		return null;
	}

	static Stash()
	{
		Class200.smethod_34();
	}
}
