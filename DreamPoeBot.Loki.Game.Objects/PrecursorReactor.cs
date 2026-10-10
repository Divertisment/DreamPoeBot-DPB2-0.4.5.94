using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

public class PrecursorReactor : NetworkObject
{
	private static PrecursorReactor precursorReactor_0;

	public bool IsVisible => true;

	public bool IsActivateEnabled => true;

	private new Element Ui => null;

	public void Click()
	{
	}

	public void Activate()
	{
	}

	internal PrecursorReactor(NetworkObject entry)
	{
	}

	internal static bool smethod_24()
	{
		return true;
	}

	internal static PrecursorReactor smethod_25()
	{
		return null;
	}

	static PrecursorReactor()
	{
		Class200.smethod_34();
	}
}
