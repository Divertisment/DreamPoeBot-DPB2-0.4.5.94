using System.Runtime.CompilerServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Bot.Pathfinding.RDWrapper.Core;
using ns0;

namespace DreamPoeBot.Loki.Bot.Pathfinding.RDWrapper.Types;

public abstract class Obstacle
{
	[CompilerGenerated]
	private uint uint_0;

	[CompilerGenerated]
	private string string_0;

	private static Obstacle obstacle_0;

	public abstract ObstacleType Type { get; protected set; }

	public uint ReferenceId
	{
		[CompilerGenerated]
		get
		{
			return 0u;
		}
		[CompilerGenerated]
		internal set
		{
		}
	}

	public bool IsActive => true;

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static CircleObstacle CreateCircle(Vector2i center, float radius)
	{
		return null;
	}

	public static BoxObstacle CreateBox(Vector2i min, Vector2i max)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	public bool TryRemove(Pathfinder pathfinder)
	{
		return true;
	}

	public static OrientedBoxObstacle CreateOrientedBox(Vector2i center, Vector2i halfExtents, float yRotation)
	{
		return null;
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static Obstacle smethod_1()
	{
		return null;
	}

	static Obstacle()
	{
		Class200.smethod_34();
	}
}
