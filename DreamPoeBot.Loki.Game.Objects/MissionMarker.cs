using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

public class MissionMarker : NetworkObject
{
	public const string TypeMetadata = "Metadata/MiscellaneousObjects/MissionMarker";

	private static MissionMarker missionMarker_0;

	public override string Name => null;

	internal MissionMarker(NetworkObject entry)
	{
	}

	internal static bool smethod_24()
	{
		return true;
	}

	internal static MissionMarker smethod_25()
	{
		return null;
	}

	static MissionMarker()
	{
		Class200.smethod_34();
	}
}
