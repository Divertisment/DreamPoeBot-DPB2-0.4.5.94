using DreamPoeBot.Loki.Elements;
using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

public class EffigyOfTheKing : NetworkObject
{
	private static EffigyOfTheKing effigyOfTheKing_0;

	private new EffigyOfTheKingElement Ui => null;

	public bool IsVisible => true;

	public string Title => null;

	public string Body => null;

	public bool IsActivateEnabled => true;

	public bool IsAttachtheHeadofTheKingEnabled => true;

	public void Activate()
	{
	}

	public void AttachtheHeadoftheKing()
	{
	}

	public void Click()
	{
	}

	internal EffigyOfTheKing(NetworkObject entry)
	{
	}

	internal static bool smethod_24()
	{
		return true;
	}

	internal static EffigyOfTheKing smethod_25()
	{
		return null;
	}

	static EffigyOfTheKing()
	{
		Class200.smethod_34();
	}
}
