using ns0;

namespace DreamPoeBot.Loki.RemoteMemoryObjects;

public class AreaTemplate : RemoteMemoryObject
{
	private static AreaTemplate areaTemplate_0;

	public string Id => null;

	public string Name => null;

	public int Act => 0;

	public bool IsTown => true;

	public bool IsHideOut => true;

	public bool HasWaypoint => true;

	public int NominalLevel => 0;

	public AreaTemplate()
	{
	}

	public AreaTemplate(long address)
	{
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static AreaTemplate smethod_3()
	{
		return null;
	}

	static AreaTemplate()
	{
		Class200.smethod_34();
	}
}
