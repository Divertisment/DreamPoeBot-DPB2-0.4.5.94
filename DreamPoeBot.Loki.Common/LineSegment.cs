using System.Runtime.InteropServices;
using DreamPoeBot.Common;
using ns0;

namespace DreamPoeBot.Loki.Common;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct LineSegment
{
	public Vector3 Start;

	public Vector3 End;

	internal static object object_0;

	public float DistanceSqr => 0f;

	public float Distance => 0f;

	public Vector3 Direction => (Vector3)(object)null;

	public Vector3 UnitDirection => (Vector3)(object)null;

	public LineSegment(Vector3 start, Vector3 end)
	{
	}

	public float ClosestT(Vector3 point)
	{
		return 0f;
	}

	public Vector3 ClosestPoint(Vector3 point)
	{
		return (Vector3)(object)null;
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static object smethod_1()
	{
		return null;
	}

	static LineSegment()
	{
		Class200.smethod_34();
	}
}
