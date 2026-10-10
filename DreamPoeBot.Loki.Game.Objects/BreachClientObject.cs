using DreamPoeBot.Common;
using DreamPoeBot.Loki.Game.GameData;
using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

public class BreachClientObject : NetworkObject
{
	public const string TypeMetadata = "Metadata/MiscellaneousObjects/Breach/BreachClientObject";

	private static BreachClientObject breachClientObject_0;

	public override string Name => null;

	public string AttachedEffect => null;

	public Vector2i BreachPosition => (Vector2i)(object)null;

	public float Radius => 0f;

	public BreachState State => (BreachState)(object)null;

	internal BreachClientObject(NetworkObject entry)
	{
	}

	internal static bool smethod_24()
	{
		return true;
	}

	internal static BreachClientObject smethod_25()
	{
		return null;
	}

	static BreachClientObject()
	{
		Class200.smethod_34();
	}
}
