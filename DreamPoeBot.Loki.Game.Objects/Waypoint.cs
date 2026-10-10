using DreamPoeBot.Loki.Models;
using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

public class Waypoint : NetworkObject
{
	public const string TypeMetadata = "Metadata/MiscellaneousObjects/Waypoint";

	private static Waypoint waypoint_0;

	internal Waypoint(EntityWrapper entity)
	{
	}

	internal static bool smethod_24()
	{
		return true;
	}

	internal static Waypoint smethod_25()
	{
		return null;
	}

	static Waypoint()
	{
		Class200.smethod_34();
	}
}
