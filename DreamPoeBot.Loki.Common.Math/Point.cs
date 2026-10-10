using System;
using ns0;

namespace DreamPoeBot.Loki.Common.Math;

[Serializable]
public struct Point : IEquatable<Point>
{
	public int X;

	public int Y;

	private static readonly Point point_0;

	internal static object object_0;

	public static Point Zero => (Point)(object)null;

	public Point(int x, int y)
	{
	}

	public bool Equals(Point other)
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

	public static bool operator ==(Point a, Point b)
	{
		return true;
	}

	public static bool operator !=(Point a, Point b)
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

	static Point()
	{
		Class200.smethod_34();
	}
}
