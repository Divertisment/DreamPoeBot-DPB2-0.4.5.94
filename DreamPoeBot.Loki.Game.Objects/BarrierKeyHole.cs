using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

public class BarrierKeyHole : NetworkObject
{
	private static BarrierKeyHole barrierKeyHole_0;

	private new Element Ui => null;

	public bool IsVisible => true;

	public bool IsDispelVisible => true;

	public void Click()
	{
	}

	public void Dispel()
	{
	}

	internal BarrierKeyHole(NetworkObject entry)
	{
	}

	internal static bool smethod_24()
	{
		return true;
	}

	internal static BarrierKeyHole smethod_25()
	{
		return null;
	}

	static BarrierKeyHole()
	{
		Class200.smethod_34();
	}
}
