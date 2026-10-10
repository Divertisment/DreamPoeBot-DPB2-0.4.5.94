using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

public class MiniMonolith : Monolith
{
	public new const string TypeMetadata = "Metadata/MiscellaneousObjects/MiniMonolith";

	private static MiniMonolith miniMonolith_0;

	public override bool IsMini => true;

	internal MiniMonolith(NetworkObject entry)
	{
	}

	public new string Dump()
	{
		return null;
	}

	internal static bool smethod_27()
	{
		return true;
	}

	internal static MiniMonolith smethod_28()
	{
		return null;
	}

	static MiniMonolith()
	{
		Class200.smethod_34();
	}
}
