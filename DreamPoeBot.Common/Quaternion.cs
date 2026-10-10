using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Common;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct Quaternion
{
	public float X;

	public float Y;

	public float Z;

	public float W;

	internal static object object_0;

	public static void CreateFromYawPitchRoll(float yaw, float pitch, float roll, out Quaternion result)
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

	static Quaternion()
	{
		Class200.smethod_34();
	}
}
