using DreamPoeBot.Common;
using DreamPoeBot.Loki.RemoteMemoryObjects;
using ns0;

namespace DreamPoeBot.Loki.Elements;

public class DisenchantElement : Element
{
	internal static DisenchantElement disenchantElement_0;

	private new bool IsValid => true;

	public Element MyOffertElement => null;

	public Inventory MyOffert => null;

	public Element OtherOffertElement => null;

	public Inventory OtherOffert => null;

	public Element AcceptButton => null;

	public bool IsAcceptButtonEnabled => true;

	public Element CancelButton => null;

	public Vector2i AcceptButtonPosition => (Vector2i)(object)null;

	public Vector2i CancellButtonPosition => (Vector2i)(object)null;

	internal static bool smethod_11()
	{
		return true;
	}

	internal static DisenchantElement smethod_12()
	{
		return null;
	}

	static DisenchantElement()
	{
		Class200.smethod_34();
	}
}
