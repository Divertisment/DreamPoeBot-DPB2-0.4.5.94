using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

public class WaterGeyser : NetworkObject
{
	public const string TypeMetadata = "Metadata/Effects/Spells/monsters_effects/act1/merveil/water_geyser/WaterGeyser";

	private static WaterGeyser waterGeyser_0;

	public override string Name => null;

	internal WaterGeyser(NetworkObject entry)
	{
	}

	internal static bool smethod_24()
	{
		return true;
	}

	internal static WaterGeyser smethod_25()
	{
		return null;
	}

	static WaterGeyser()
	{
		Class200.smethod_34();
	}
}
