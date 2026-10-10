using System.Runtime.InteropServices;
using DreamPoeBot.Common;
using ns0;

namespace DreamPoeBot.Loki.Common;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct Ray
{
	public Vector3 Position;

	public Vector3 Direction;

	internal static object object_0;

	public Ray(Vector3 position, Vector3 direction)
	{
	}

	public float? Intersects(Sphere sphere)
	{
		return null;
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static object smethod_1()
	{
		return null;
	}

	static Ray()
	{
		Class200.smethod_34();
	}
}
