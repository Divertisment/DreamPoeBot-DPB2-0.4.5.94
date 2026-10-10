using DreamPoeBot.Loki.Bot;
using DreamPoeBot.Loki.Common.MVVM;
using ns0;

namespace DreamPoeBot.DreamPoe;

public class MoverBindingWrapper : NotificationObject
{
	private readonly IPlayerMover iplayerMover_0;

	private static MoverBindingWrapper moverBindingWrapper_0;

	public string Version => null;

	public string Author => null;

	public string Description => null;

	public bool IsActive => true;

	internal MoverBindingWrapper(IPlayerMover mover)
	{
	}

	internal static bool smethod_3()
	{
		return true;
	}

	internal static MoverBindingWrapper smethod_4()
	{
		return null;
	}

	static MoverBindingWrapper()
	{
		Class200.smethod_34();
	}
}
