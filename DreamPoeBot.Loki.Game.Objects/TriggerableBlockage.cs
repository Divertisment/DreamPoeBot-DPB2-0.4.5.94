using DreamPoeBot.Common;
using DreamPoeBot.Loki.Models;
using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

public class TriggerableBlockage : NetworkObject
{
	private static TriggerableBlockage triggerableBlockage_0;

	public bool IsOpened => true;

	public Vector2i BoundsMin => (Vector2i)(object)null;

	public Vector2i BoundsMax => (Vector2i)(object)null;

	public Vector2i Size => (Vector2i)(object)null;

	public byte[] OpenedOverlayNavData => null;

	internal TriggerableBlockage(EntityWrapper entry)
	{
	}

	internal static bool smethod_24()
	{
		return true;
	}

	internal static TriggerableBlockage smethod_25()
	{
		return null;
	}

	static TriggerableBlockage()
	{
		Class200.smethod_34();
	}
}
