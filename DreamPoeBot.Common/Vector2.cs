using System;
using System.Runtime.CompilerServices;
using ns0;

namespace DreamPoeBot.Common;

public struct Vector2 : IEquatable<Vector2>
{
	public float X;

	public float Y;

	[CompilerGenerated]
	private static Vector2 vector2_0;

	[CompilerGenerated]
	private static Vector2 vector2_1;

	private static object object_0;

	public bool IsZero => true;

	public static Vector2 Zero
	{
		[CompilerGenerated]
		get
		{
			return (Vector2)(object)null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static Vector2 One
	{
		[CompilerGenerated]
		get
		{
			return (Vector2)(object)null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	static Vector2()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		Zero = new Vector2(0f, 0f);
		One = new Vector2(1f, 1f);
	}

	public Vector2 GetPointAtDistanceAfterThis(Vector2 end, float distance)
	{
		return (Vector2)(object)null;
	}

	public Vector2 GetPointAtDistanceBeforeThis(Vector2 end, float distance)
	{
		return (Vector2)(object)null;
	}

	public Vector2 GetPointAtDistanceBeforeEnd(Vector2 end, float distance)
	{
		return (Vector2)(object)null;
	}

	public Vector2 GetPointAtDistanceAfterEnd(Vector2 end, float distance)
	{
		return (Vector2)(object)null;
	}

	public Vector2(float x, float y)
	{
	}

	public float Length()
	{
		return 0f;
	}

	public float LengthSqr()
	{
		return 0f;
	}

	public void Normalize()
	{
	}

	public float Distance(Vector2 v)
	{
		return 0f;
	}

	public float Distance(ref Vector2 v)
	{
		return 0f;
	}

	public float DistanceSqr(Vector2 v)
	{
		return 0f;
	}

	public float DistanceSqr(ref Vector2 v)
	{
		return 0f;
	}

	public Vector2i method_0()
	{
		return (Vector2i)(object)null;
	}

	public Vector3 ToVector3()
	{
		return (Vector3)(object)null;
	}

	public bool Equals(Vector2 other)
	{
		return true;
	}

	public bool Equals(ref Vector2 other)
	{
		return true;
	}

	public static bool Equals(ref Vector2 v1, ref Vector2 v2)
	{
		return true;
	}

	public static bool operator ==(Vector2 ls, Vector2 rs)
	{
		return true;
	}

	public static bool operator !=(Vector2 ls, Vector2 rs)
	{
		return true;
	}

	public override bool Equals(object obj)
	{
		return true;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	public static Vector2 operator +(Vector2 ls, Vector2 rs)
	{
		return (Vector2)(object)null;
	}

	public static Vector2 operator -(Vector2 ls, Vector2 rs)
	{
		return (Vector2)(object)null;
	}

	public static Vector2 operator -(Vector2 v)
	{
		return (Vector2)(object)null;
	}

	public static Vector2 operator *(Vector2 ls, Vector2 rs)
	{
		return (Vector2)(object)null;
	}

	public static Vector2 operator *(Vector2 ls, float rs)
	{
		return (Vector2)(object)null;
	}

	public static Vector2 operator /(Vector2 ls, Vector2 rs)
	{
		return (Vector2)(object)null;
	}

	public static Vector2 operator /(Vector2 ls, float rs)
	{
		return (Vector2)(object)null;
	}

	public static void Add(ref Vector2 v1, ref Vector2 v2, out Vector2 result)
	{
	}

	public static void Subtract(ref Vector2 v1, ref Vector2 v2, out Vector2 result)
	{
	}

	public static void Multiply(ref Vector2 v1, ref Vector2 v2, out Vector2 result)
	{
	}

	public static void Multiply(ref Vector2 v1, float scalar, out Vector2 result)
	{
	}

	public static void Divide(ref Vector2 v1, ref Vector2 v2, out Vector2 result)
	{
	}

	public static void Divide(ref Vector2 v1, float divisor, out Vector2 result)
	{
	}

	public static float Distance(ref Vector2 v1, ref Vector2 v2)
	{
		return 0f;
	}

	public static float DistanceSqr(ref Vector2 v1, ref Vector2 v2)
	{
		return 0f;
	}

	public static void GetDirection(ref Vector2 from, ref Vector2 to, out Vector2 dir)
	{
	}

	public static Vector2 Min(Vector2 v1, Vector2 v2)
	{
		return (Vector2)(object)null;
	}

	public static void Min(ref Vector2 v1, ref Vector2 v2, out Vector2 result)
	{
	}

	public static Vector2 Max(Vector2 v1, Vector2 v2)
	{
		return (Vector2)(object)null;
	}

	public static void Max(ref Vector2 v1, ref Vector2 v2, out Vector2 result)
	{
	}

	public static float Dot(Vector2 v1, Vector2 v2)
	{
		return 0f;
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static object smethod_1()
	{
		return null;
	}
}
