using System.Runtime.CompilerServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Components;
using DreamPoeBot.Loki.Models;
using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

public class Projectile : NetworkObject
{
	private DreamPoeBot.Loki.Components.Projectile projectile_0;

	internal static Projectile projectile_1;

	public ProjectileSnapshot ProjectileState => null;

	public NetworkObject Caster => null;

	public Vector2 TrajectoryCenter => (Vector2)(object)null;

	public Vector2 TrajectoryDirection => (Vector2)(object)null;

	[SpecialName]
	private DreamPoeBot.Loki.Components.Projectile method_7()
	{
		return null;
	}

	public Vector2 GetPointAlongTrajectory(float distance)
	{
		return (Vector2)(object)null;
	}

	internal Projectile(EntityWrapper entry)
	{
	}

	internal Projectile(NetworkObject entry)
	{
	}

	public override string ToString()
	{
		return null;
	}

	internal static bool smethod_24()
	{
		return true;
	}

	internal static Projectile smethod_25()
	{
		return null;
	}

	static Projectile()
	{
		Class200.smethod_34();
	}
}
