using System;
using System.Collections.Generic;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Common.Math;
using ns0;

namespace DreamPoeBot.Loki.Common;

[Serializable]
public struct BoundingBox : IEquatable<BoundingBox>
{
	public const int CornerCount = 8;

	public Vector3 Min;

	public Vector3 Max;

	private static object object_0;

	public Vector3[] GetCorners()
	{
		return null;
	}

	public void GetCorners(Vector3[] corners)
	{
	}

	public BoundingBox(Vector3 min, Vector3 max)
	{
	}

	public bool Equals(BoundingBox other)
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

	public static BoundingBox CreateMerged(BoundingBox original, BoundingBox additional)
	{
		return (BoundingBox)(object)null;
	}

	public static void CreateMerged(ref BoundingBox original, ref BoundingBox additional, out BoundingBox result)
	{
	}

	public static BoundingBox CreateFromPoints(IEnumerable<Vector3> points)
	{
		return (BoundingBox)(object)null;
	}

	public bool Intersects(BoundingBox box)
	{
		return true;
	}

	public void Intersects(ref BoundingBox box, out bool result)
	{
	}

	public ContainmentType Contains(BoundingBox box)
	{
		return (ContainmentType)(object)null;
	}

	public void Contains(ref BoundingBox box, out ContainmentType result)
	{
	}

	public ContainmentType Contains(Vector3 point)
	{
		return (ContainmentType)(object)null;
	}

	public void Contains(ref Vector3 point, out ContainmentType result)
	{
	}

	internal void method_0(ref Vector3 vector3_0, out Vector3 vector3_1)
	{
	}

	public static bool operator ==(BoundingBox a, BoundingBox b)
	{
		return true;
	}

	public static bool operator !=(BoundingBox a, BoundingBox b)
	{
		return true;
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static object smethod_1()
	{
		return null;
	}

	static BoundingBox()
	{
		Class200.smethod_34();
	}
}
