using System.Runtime.CompilerServices;
using DreamPoeBot.Common;
using ns0;

namespace DreamPoeBot.Loki.Components;

public sealed class ProjectileSnapshot
{
	internal static readonly ProjectileSnapshot Empty;

	[CompilerGenerated]
	private readonly long long_0;

	[CompilerGenerated]
	private readonly int int_0;

	[CompilerGenerated]
	private readonly bool bool_0;

	[CompilerGenerated]
	private readonly Vector2 vector2_0;

	[CompilerGenerated]
	private readonly Vector2 vector2_1;

	private static ProjectileSnapshot projectileSnapshot_0;

	public long CasterAddress
	{
		[CompilerGenerated]
		get
		{
			return 0L;
		}
	}

	public int CasterId
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
	}

	public bool HasCaster => true;

	public bool HasTrajectory
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
	}

	public Vector2 Center
	{
		[CompilerGenerated]
		get
		{
			return (Vector2)(object)null;
		}
	}

	public Vector2 Direction
	{
		[CompilerGenerated]
		get
		{
			return (Vector2)(object)null;
		}
	}

	public bool IsAvailable => true;

	private ProjectileSnapshot()
	{
	}

	internal ProjectileSnapshot(long casterAddress, int casterId, bool hasTrajectory, Vector2 center, Vector2 direction)
	{
	}

	public Vector2 GetPointAlongTrajectory(float distance)
	{
		return (Vector2)(object)null;
	}

	static ProjectileSnapshot()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		Empty = new ProjectileSnapshot();
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static ProjectileSnapshot smethod_1()
	{
		return null;
	}
}
