using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

public class DarkShrine : NetworkObject
{
	public const string TypeMetadata = "Metadata/Shrines/DarkShrine";

	private PerFrameCachedValue<bool> perFrameCachedValue_4;

	internal static DarkShrine darkShrine_0;

	public bool IsDeactivated => true;

	internal DarkShrine(NetworkObject entry)
	{
	}

	public override string ToString()
	{
		return null;
	}

	private bool method_7()
	{
		return true;
	}

	internal static bool smethod_24()
	{
		return true;
	}

	internal static DarkShrine smethod_25()
	{
		return null;
	}

	static DarkShrine()
	{
		Class200.smethod_34();
	}
}
