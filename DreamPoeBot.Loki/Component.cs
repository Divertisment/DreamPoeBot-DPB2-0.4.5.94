using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Game.Objects;
using ns0;

namespace DreamPoeBot.Loki;

public abstract class Component : RemoteMemoryObject
{
	private Entity entity_0;

	private long long_1;

	internal static Component component_0;

	public override Memory M => null;

	public override bool IsValid => true;

	protected NetworkObject Owner => null;

	[SpecialName]
	internal Entity method_0()
	{
		return null;
	}

	internal void method_1(Entity entity_1)
	{
	}

	protected void EnsureLifetime()
	{
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static Component smethod_3()
	{
		return null;
	}

	static Component()
	{
		Class200.smethod_34();
	}
}
