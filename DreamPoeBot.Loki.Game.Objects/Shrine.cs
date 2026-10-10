using DreamPoeBot.Loki.Game.Utilities;
using DreamPoeBot.Loki.Models;
using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

public class Shrine : NetworkObject
{
	private PerFrameCachedValue<bool> perFrameCachedValue_4;

	private PerFrameCachedValue<string> perFrameCachedValue_5;

	private PerFrameCachedValue<string> perFrameCachedValue_6;

	private PerFrameCachedValue<string> perFrameCachedValue_7;

	internal static Shrine shrine_0;

	public bool IsDeactivated => true;

	public string ShrineId => null;

	public string ShrineName => null;

	public string ShrineDescription => null;

	internal Shrine(EntityWrapper entity)
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

	private string method_8()
	{
		return null;
	}

	private string method_9()
	{
		return null;
	}

	private string method_10()
	{
		return null;
	}

	internal static bool smethod_24()
	{
		return true;
	}

	internal static Shrine smethod_25()
	{
		return null;
	}

	static Shrine()
	{
		Class200.smethod_34();
	}
}
