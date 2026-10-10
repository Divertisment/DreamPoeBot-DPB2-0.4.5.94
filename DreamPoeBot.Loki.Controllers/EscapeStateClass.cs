using System.Runtime.CompilerServices;
using ns0;

namespace DreamPoeBot.Loki.Controllers;

public class EscapeStateClass : GameState
{
	internal static EscapeStateClass escapeStateClass_0;

	public Element EscapeMenuElement => null;

	public bool IsEscapeStateActive => true;

	public long baseAddress => 0L;

	public Element ExitToLogin => null;

	public Element ExitToCharSelection => null;

	public Element ExitPathOfExile => null;

	public Element RespawnAtCheckPoint => null;

	public Element Options => null;

	public Element ResumeGame => null;

	public Element MicrotransactionShop => null;

	[SpecialName]
	private long method_0()
	{
		return 0L;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static EscapeStateClass smethod_5()
	{
		return null;
	}

	static EscapeStateClass()
	{
		Class200.smethod_34();
	}
}
