using System;
using DreamPoeBot.Common;
using ns0;

namespace DreamPoeBot.Loki.Common;

public static class MathEx
{
	private static readonly Random random_0;

	private static MathEx mathEx_0;

	public static double Random(double min, double max)
	{
		return 0.0;
	}

	public static float Lerp(float min, float max, float amount)
	{
		return 0f;
	}

	public static float InverseLerp(float min, float max, float amount)
	{
		return 0f;
	}

	public static float GetPercentage(float current, float max, bool isHundredHigh = true)
	{
		return 0f;
	}

	public static float GetAmount(float min, float max, float value)
	{
		return 0f;
	}

	public static float ToRadians(float degrees)
	{
		return 0f;
	}

	public static float ToDegrees(float radians)
	{
		return 0f;
	}

	public static float DistanceSqr(ref Vector3 point, ref LineSegment line)
	{
		return 0f;
	}

	public static float DistanceSqr(Vector3 point, LineSegment line)
	{
		return 0f;
	}

	public static float Distance(ref Vector3 point, ref LineSegment line)
	{
		return 0f;
	}

	public static float Distance(Vector3 point, LineSegment line)
	{
		return 0f;
	}

	public static float WrapAngle(float radian)
	{
		return 0f;
	}

	public static Vector3 CalculatePointFrom(Vector3 myLoc, Vector3 targetLoc, float pointDistanceToTarget)
	{
		return (Vector3)(object)null;
	}

	public static Vector3 GetPointAt(Vector3 from, float distance, float rotationRadians)
	{
		return (Vector3)(object)null;
	}

	public static bool IntersectsPath(Vector3 target, float radius, Vector3 start, Vector3 destination)
	{
		return true;
	}

	public static bool IntersectsPath(Vector2i target, float radius, Vector2i start, Vector2i destination)
	{
		return true;
	}

	public static float Clamp(float min, float max, float value)
	{
		return 0f;
	}

	public static double GenerateRandomNormalDistributed(double min, double max, bool isInteger = false)
	{
		return 0.0;
	}

	static MathEx()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		random_0 = new Random();
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static MathEx smethod_1()
	{
		return null;
	}
}
