using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Common;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct Matrix
{
	public float M11;

	public float M12;

	public float M13;

	public float M14;

	public float M21;

	public float M22;

	public float M23;

	public float M24;

	public float M31;

	public float M32;

	public float M33;

	public float M34;

	public float M41;

	public float M42;

	public float M43;

	public float M44;

	[CompilerGenerated]
	private static Matrix matrix_0;

	internal static object object_0;

	public static Matrix Identity
	{
		[CompilerGenerated]
		get
		{
			return (Matrix)(object)null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public Matrix(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44)
	{
	}

	public void GetUp(out Vector3 up)
	{
	}

	public void GetDown(out Vector3 down)
	{
	}

	public void GetRight(out Vector3 right)
	{
	}

	public void GetLeft(out Vector3 left)
	{
	}

	public void GetBackwards(out Vector3 backwards)
	{
	}

	public void GetForward(out Vector3 forward)
	{
	}

	public void GetTranslation(out Vector3 translation)
	{
	}

	public static void Multiply(ref Matrix m1, ref Matrix m2, out Matrix result)
	{
	}

	public static void CreateTranslation(ref Vector3 position, out Matrix result)
	{
	}

	public static Matrix CreateTranslation(Vector3 position)
	{
		return (Matrix)(object)null;
	}

	public static void CreateScale(float xScale, float yScale, float zScale, out Matrix result)
	{
	}

	public static Matrix CreateScale(float xScale, float yScale, float zScale)
	{
		return (Matrix)(object)null;
	}

	public static void CreateScale(float scale, out Matrix result)
	{
	}

	public static Matrix CreateScale(float scale)
	{
		return (Matrix)(object)null;
	}

	public static void CreateRotationX(float radians, out Matrix result)
	{
	}

	public static Matrix CreateRotationX(float radians)
	{
		return (Matrix)(object)null;
	}

	public static void CreateRotationY(float radians, out Matrix result)
	{
	}

	public static Matrix CreateRotationY(float radians)
	{
		return (Matrix)(object)null;
	}

	public static void CreateRotationZ(float radians, out Matrix result)
	{
	}

	public static Matrix CreateRotationZ(float radians)
	{
		return (Matrix)(object)null;
	}

	public static void CreateFromQuaternion(ref Quaternion quaternion, out Matrix result)
	{
	}

	public static Matrix CreateFromQuaternion(Quaternion quaternion)
	{
		return (Matrix)(object)null;
	}

	public static Matrix CreateFromYawPitchRoll(float yaw, float pitch, float roll)
	{
		return (Matrix)(object)null;
	}

	public static Matrix operator *(Matrix ls, Matrix rs)
	{
		return (Matrix)(object)null;
	}

	static Matrix()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		Identity = new Matrix(1f, 0f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 0f, 1f);
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
