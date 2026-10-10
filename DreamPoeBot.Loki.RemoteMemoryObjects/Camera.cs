using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Loki.RemoteMemoryObjects;

public class Camera : RemoteMemoryObject
{
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	internal struct Struct37
	{
		[FieldOffset(624)]
		public int Width;

		[FieldOffset(628)]
		public int int_0;

		[FieldOffset(256)]
		public Struct38 struct38_0;

		[FieldOffset(996)]
		public Vector3 vector3_0;

		[FieldOffset(1152)]
		public float float_0;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct38
	{
		public readonly float float_0;

		public readonly float float_1;

		public readonly float float_2;

		public readonly float float_3;

		public readonly float float_4;

		public readonly float float_5;

		public readonly float float_6;

		public readonly float float_7;

		public readonly float float_8;

		public readonly float float_9;

		public readonly float float_10;

		public readonly float float_11;

		public readonly float float_12;

		public readonly float float_13;

		public readonly float float_14;

		public readonly float float_15;
	}

	internal static Camera camera_0;

	public int Width => 0;

	public int Height => 0;

	public float ZFar => 0f;

	[SpecialName]
	internal Struct37 method_0()
	{
		return (Struct37)(object)null;
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static Camera smethod_3()
	{
		return null;
	}

	static Camera()
	{
		Class200.smethod_34();
	}
}
