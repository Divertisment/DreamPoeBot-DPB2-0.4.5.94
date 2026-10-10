using System.Collections.Generic;
using DreamPoeBot.Common;
using ns0;

namespace DreamPoeBot.Loki.Bot.Pathfinding.RDWrapper.Types;

public struct PathResult
{
	public List<Vector2i> Path;

	public PathfindError ErrorCode;

	public readonly Vector2i Start;

	public readonly Vector2i End;

	internal static object object_0;

	public bool Success => true;

	public PathResult(List<Vector2i> path, int errorCode, Vector2i start, Vector2i end)
	{
	}

	public PathResult(List<Vector2i> path, PathfindError errorCode, Vector2i start, Vector2i end)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static object smethod_1()
	{
		return null;
	}

	static PathResult()
	{
		Class200.smethod_34();
	}
}
