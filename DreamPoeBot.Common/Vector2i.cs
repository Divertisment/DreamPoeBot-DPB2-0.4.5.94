using System;
using System.Runtime.CompilerServices;
using ns0;

namespace DreamPoeBot.Common;

public struct Vector2i : IEquatable<Vector2i>
{
	public int X;

	public int Y;

	[CompilerGenerated]
	private static Vector2i vector2i_0;

	[CompilerGenerated]
	private static Vector2i vector2i_1;

	private static object object_0;

	public bool IsZero => true;

	public static Vector2i Zero
	{
		[CompilerGenerated]
		get
		{
			return (Vector2i)(object)null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static Vector2i One
	{
		[CompilerGenerated]
		get
		{
			return (Vector2i)(object)null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public Vector2i GetPointAtDistanceAfterThis(Vector2i end, float distance)
	{
		return (Vector2i)(object)null;
	}

	public Vector2i GetPointAtDistanceBeforeThis(Vector2i end, float distance)
	{
		return (Vector2i)(object)null;
	}

	public Vector2i GetPointAtDistanceBeforeEnd(Vector2i end, float distance)
	{
		return (Vector2i)(object)null;
	}

	public Vector2i GetPointAtDistanceAfterEnd(Vector2i end, float distance)
	{
		return (Vector2i)(object)null;
	}

	static Vector2i()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		Zero = new Vector2i(0, 0);
		One = new Vector2i(1, 1);
	}

	public Vector2i(int x, int y)
	{
	}

	public Vector2i(Vector2i vector)
	{
	}

	public int Length()
	{
		return 0;
	}

	public int LengthSqr()
	{
		return 0;
	}

	public void Normalize()
	{
	}

	public int Distance(Vector2i v)
	{
		return 0;
	}

	public float DistanceF(Vector2i v)
	{
		return 0f;
	}

	public int Distance(ref Vector2i v)
	{
		return 0;
	}

	public int DistanceSqr(Vector2i v)
	{
		return 0;
	}

	public int DistanceSqr(ref Vector2i v)
	{
		return 0;
	}

	public Vector3 ToVector3()
	{
		return (Vector3)(object)null;
	}

	public Vector2 ToVector2()
	{
		return (Vector2)(object)null;
	}

	public bool Equals(Vector2i other)
	{
		return true;
	}

	public bool Equals(ref Vector2i other)
	{
		return true;
	}

	public static bool Equals(ref Vector2i v1, ref Vector2i v2)
	{
		return true;
	}

	public static bool operator ==(Vector2i ls, Vector2i rs)
	{
		return true;
	}

	public static bool operator !=(Vector2i ls, Vector2i rs)
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

	public static Vector2i operator +(Vector2i ls, Vector2i rs)
	{
		return (Vector2i)(object)null;
	}

	public static Vector2i operator +(Vector2i ls, int rs)
	{
		return (Vector2i)(object)null;
	}

	public static Vector2i operator -(Vector2i ls, int rs)
	{
		return (Vector2i)(object)null;
	}

	public static Vector2i operator -(Vector2i ls, Vector2i rs)
	{
		return (Vector2i)(object)null;
	}

	public static Vector2i operator -(Vector2i v)
	{
		return (Vector2i)(object)null;
	}

	public static Vector2i operator *(Vector2i ls, Vector2i rs)
	{
		return (Vector2i)(object)null;
	}

	public static Vector2i operator *(Vector2i ls, int rs)
	{
		return (Vector2i)(object)null;
	}

	public static Vector2i operator *(Vector2i ls, float rs)
	{
		return (Vector2i)(object)null;
	}

	public static Vector2i operator /(Vector2i ls, Vector2i rs)
	{
		return (Vector2i)(object)null;
	}

	public static Vector2i operator /(Vector2i ls, int rs)
	{
		return (Vector2i)(object)null;
	}

	public static void Add(ref Vector2i v1, ref Vector2i v2, out Vector2i result)
	{
	}

	public static void Subtract(ref Vector2i v1, ref Vector2i v2, out Vector2i result)
	{
	}

	public static void Multiply(ref Vector2i v1, ref Vector2i v2, out Vector2i result)
	{
	}

	public static void Multiply(ref Vector2i v1, float scalar, out Vector2i result)
	{
	}

	public static void Divide(ref Vector2i v1, ref Vector2i v2, out Vector2i result)
	{
	}

	public static void Divide(ref Vector2i v1, int divisor, out Vector2i result)
	{
	}

	public static int Distance(ref Vector2i v1, ref Vector2i v2)
	{
		return 0;
	}

	public static float DistanceF(ref Vector2i v1, ref Vector2i v2)
	{
		return 0f;
	}

	public static int DistanceSqr(ref Vector2i v1, ref Vector2i v2)
	{
		return 0;
	}

	public static void GetDirection(ref Vector2i from, ref Vector2i to, out Vector2i dir)
	{
	}

	public static Vector2i Min(Vector2i v1, Vector2i v2)
	{
		return (Vector2i)(object)null;
	}

	public static void Min(ref Vector2i v1, ref Vector2i v2, out Vector2i result)
	{
	}

	public static Vector2i Max(Vector2i v1, Vector2i v2)
	{
		return (Vector2i)(object)null;
	}

	public static void Max(ref Vector2i v1, ref Vector2i v2, out Vector2i result)
	{
	}

	public static int Dot(Vector2i v1, Vector2i v2)
	{
		return 0;
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
