using System.Numerics;
using System.Runtime.CompilerServices;
using DreamPoeBot.Common;
using ns0;

namespace DreamPoeBot.Loki.Bot.Pathfinding.RDWrapper.Types;

public class BoxObstacle : Obstacle
{
	[CompilerGenerated]
	private readonly Vector2i vector2i_0;

	[CompilerGenerated]
	private readonly Vector2i vector2i_1;

	[CompilerGenerated]
	private ObstacleType obstacleType_0;

	internal static BoxObstacle boxObstacle_0;

	public Vector2i Min
	{
		[CompilerGenerated]
		get
		{
			return (Vector2i)(object)null;
		}
	}

	public Vector2i Max
	{
		[CompilerGenerated]
		get
		{
			return (Vector2i)(object)null;
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

	public BoxObstacle(Vector2i min, Vector2i max)
	{
	}

	internal System.Numerics.Vector3 method_0()
	{
		return (System.Numerics.Vector3)(object)null;
	}

	internal System.Numerics.Vector3 method_1()
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

	internal static BoxObstacle smethod_3()
	{
		return null;
	}

	static BoxObstacle()
	{
		Class200.smethod_34();
	}
}
