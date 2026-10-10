using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Common;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct Vector3 : IEquatable<Vector3>
{
	public float X;

	public float Y;

	public float Z;

	[CompilerGenerated]
	private static Vector3 vector3_0;

	[CompilerGenerated]
	private static Vector3 vector3_1;

	internal static object object_0;

	public bool IsZero => true;

	public static Vector3 Zero
	{
		[CompilerGenerated]
		get
		{
			return (Vector3)(object)null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static Vector3 One
	{
		[CompilerGenerated]
		get
		{
			return (Vector3)(object)null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	static Vector3()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		Zero = new Vector3(0f, 0f, 0f);
		One = new Vector3(1f, 1f, 1f);
	}

	public Vector3(Vector2 v, float z)
	{
	}

	public Vector3(float v)
	{
	}

	public Vector3(Vector2i v, float z)
	{
	}

	public Vector3(float x, float y, float z)
	{
	}

	public Vector2 ToVector2()
	{
		return (Vector2)(object)null;
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

	public float Distance(Vector3 v)
	{
		return 0f;
	}

	public float Distance(ref Vector3 v)
	{
		return 0f;
	}

	public float DistanceSqr(Vector3 v)
	{
		return 0f;
	}

	public float DistanceSqr(ref Vector3 v)
	{
		return 0f;
	}

	public unsafe void CopyTo(float* arr)
	{
	}

	public bool Equals(Vector3 other)
	{
		return true;
	}

	public bool Equals(ref Vector3 other)
	{
		return true;
	}

	public override bool Equals(object obj)
	{
		return true;
	}

	public static bool operator ==(Vector3 ls, Vector3 rs)
	{
		return true;
	}

	public static bool operator !=(Vector3 ls, Vector3 rs)
	{
		return true;
	}

	public static bool Equals(Vector3 v1, Vector3 v2)
	{
		return true;
	}

	public static bool Equals(ref Vector3 v1, ref Vector3 v2)
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

	public static Vector3 operator *(float left, Vector3 right)
	{
		return (Vector3)(object)null;
	}

	public static Vector3 operator +(Vector3 ls, Vector3 rs)
	{
		return (Vector3)(object)null;
	}

	public static Vector3 operator -(Vector3 ls, Vector3 rs)
	{
		return (Vector3)(object)null;
	}

	public static Vector3 operator *(Vector3 ls, Vector3 rs)
	{
		return (Vector3)(object)null;
	}

	public static Vector3 operator *(Vector3 ls, float rs)
	{
		return (Vector3)(object)null;
	}

	public static Vector3 operator /(Vector3 ls, Vector3 rs)
	{
		return (Vector3)(object)null;
	}

	public static Vector3 operator /(Vector3 ls, float rs)
	{
		return (Vector3)(object)null;
	}

	public static void Add(ref Vector3 v1, ref Vector3 v2, out Vector3 result)
	{
	}

	public static void Subtract(ref Vector3 v1, ref Vector3 v2, out Vector3 result)
	{
	}

	public static void Multiply(ref Vector3 v1, ref Vector3 v2, out Vector3 result)
	{
	}

	public static void Multiply(ref Vector3 v1, float scalar, out Vector3 result)
	{
	}

	public static void Divide(ref Vector3 v1, ref Vector3 v2, out Vector3 result)
	{
	}

	public static void Divide(ref Vector3 v1, float divisor, out Vector3 result)
	{
	}

	public static void Negate(ref Vector3 v, out Vector3 result)
	{
	}

	public static float Distance(Vector3 v1, Vector3 v2)
	{
		return 0f;
	}

	public static float Distance(ref Vector3 v1, ref Vector3 v2)
	{
		return 0f;
	}

	public static float DistanceSqr(Vector3 v1, Vector3 v2)
	{
		return 0f;
	}

	public static float DistanceSqr(ref Vector3 v1, ref Vector3 v2)
	{
		return 0f;
	}

	public float method_0(Vector3 to)
	{
		return 0f;
	}

	public float Distance2DSqr(Vector3 to)
	{
		return 0f;
	}

	public static float smethod_0(ref Vector3 v1, ref Vector3 v2)
	{
		return 0f;
	}

	public static float Distance2DSqr(ref Vector3 v1, ref Vector3 v2)
	{
		return 0f;
	}

	public static Vector3 GetDirection(Vector3 from, Vector3 to)
	{
		return (Vector3)(object)null;
	}

	public static void GetDirection(ref Vector3 from, ref Vector3 to, out Vector3 dir)
	{
	}

	public static Vector3 NormalizedDirection(Vector3 start, Vector3 end)
	{
		return (Vector3)(object)null;
	}

	public static float Dot(Vector3 v1, Vector3 v2)
	{
		return 0f;
	}

	public static Vector3 Cross(Vector3 v1, Vector3 v2)
	{
		return (Vector3)(object)null;
	}

	public static void Cross(ref Vector3 v1, ref Vector3 v2, out Vector3 crossProduct)
	{
	}

	public static void Transform(ref Vector3 v, ref Matrix m, out Vector3 result)
	{
	}

	public static Vector3 Transform(Vector3 v, ref Matrix m)
	{
		return (Vector3)(object)null;
	}

	public static void Min(ref Vector3 v1, ref Vector3 v2, out Vector3 result)
	{
	}

	public static Vector3 Min(Vector3 v1, Vector3 v2)
	{
		return (Vector3)(object)null;
	}

	public static void Max(ref Vector3 v1, ref Vector3 v2, out Vector3 result)
	{
	}

	public static Vector3 Max(Vector3 v1, Vector3 v2)
	{
		return (Vector3)(object)null;
	}

	public static bool CalculateBarycentric(ref Vector3 p1, ref Vector3 p2, ref Vector3 p3, ref Vector3 point, out Vector3 barycentric)
	{
		return true;
	}

	public static void CatmullRom(ref Vector3 beforeStart, ref Vector3 start, ref Vector3 end, ref Vector3 afterEnd, float amount, out Vector3 result)
	{
	}

	public static Vector3 CatmullRom(Vector3 beforeStart, Vector3 start, Vector3 end, Vector3 afterEnd, float amount)
	{
		return (Vector3)(object)null;
	}

	public static void Cardinal(ref Vector3 beforeStart, ref Vector3 start, ref Vector3 end, ref Vector3 afterEnd, float aStart, float aEnd, float amount, out Vector3 result)
	{
	}

	public static Vector3 Cardinal(Vector3 beforeStart, Vector3 start, Vector3 end, Vector3 afterEnd, float aStart, float aEnd, float amount)
	{
		return (Vector3)(object)null;
	}

	public static void Hermite(ref Vector3 value1, ref Vector3 tangent1, ref Vector3 value2, ref Vector3 tangent2, float amount, out Vector3 result)
	{
	}

	public static Vector3 CubiceHermiteCurve(Vector3 start, Vector3 end, Vector3 u, Vector3 v, float t)
	{
		return (Vector3)(object)null;
	}

	public static Vector3 Blend(Vector3 firstPoint, Vector3 secondPoint, float t)
	{
		return (Vector3)(object)null;
	}

	public static Vector3 Hermite(Vector3 value1, Vector3 tangent1, Vector3 value2, Vector3 tangent2, float amount)
	{
		return (Vector3)(object)null;
	}

	internal static bool smethod_1()
	{
		return true;
	}

	internal static object smethod_2()
	{
		return null;
	}
}
