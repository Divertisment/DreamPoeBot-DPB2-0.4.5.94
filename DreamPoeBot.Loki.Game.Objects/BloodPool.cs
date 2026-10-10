using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

public class BloodPool : NetworkObject
{
	public const string TypeMetadata = "Metadata/Effects/Spells/Masters/Dex/BloodPool";

	private static BloodPool bloodPool_0;

	public override string Name => null;

	internal BloodPool(NetworkObject entry)
	{
	}

	internal static bool smethod_24()
	{
		return true;
	}

	internal static BloodPool smethod_25()
	{
		return null;
	}

	static BloodPool()
	{
		Class200.smethod_34();
	}
}
