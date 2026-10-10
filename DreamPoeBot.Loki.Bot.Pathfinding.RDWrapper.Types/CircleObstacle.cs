using System.Numerics;
using System.Runtime.CompilerServices;
using DreamPoeBot.Common;
using ns0;

namespace DreamPoeBot.Loki.Bot.Pathfinding.RDWrapper.Types;

public class CircleObstacle : Obstacle
{
	[CompilerGenerated]
	private readonly Vector2i vector2i_0;

	[CompilerGenerated]
	private readonly float float_0;

	[CompilerGenerated]
	private ObstacleType obstacleType_0;

	internal static CircleObstacle circleObstacle_0;

	public Vector2i Center
	{
		[CompilerGenerated]
		get
		{
			return (Vector2i)(object)null;
		}
	}

	public float Radius
	{
		[CompilerGenerated]
		get
		{
			return 0f;
		}
	}

	public override ObstacleType Type
	{
		[CompilerGenerated]
		get
		{
			return (ObstacleType)(object)null;
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public CircleObstacle(Vector2i center, float radius)
	{
	}

	internal System.Numerics.Vector3 method_0()
	{
		return (System.Numerics.Vector3)(object)null;
	}

	public override string ToString()
	{
		return null;
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static CircleObstacle smethod_3()
	{
		return null;
	}

	static CircleObstacle()
	{
		Class200.smethod_34();
	}
}
