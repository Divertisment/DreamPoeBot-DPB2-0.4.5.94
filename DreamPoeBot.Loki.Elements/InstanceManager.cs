using DreamPoeBot.Common;
using ns0;

namespace DreamPoeBot.Loki.Elements;

public class InstanceManager : Element
{
	private static InstanceManager instanceManager_0;

	public int OpenInstances => 0;

	public Element MyInstance => null;

	public Element NewInstance => null;

	public Vector2i NewInstanceClickPosition => (Vector2i)(object)null;

	private int method_29()
	{
		return 0;
	}

	internal static bool smethod_11()
	{
		return true;
	}

	internal static InstanceManager smethod_12()
	{
		return null;
	}

	static InstanceManager()
	{
		Class200.smethod_34();
	}
}
