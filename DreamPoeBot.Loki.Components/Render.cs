using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class Render : Component
{
	[StructLayout(LayoutKind.Explicit)]
	internal struct Struct245
	{
		[FieldOffset(312)]
		public Vector3 vector3_0;

		[FieldOffset(324)]
		public Vector3 vector3_1;

		[FieldOffset(352)]
		public GStruct2 Name;

		[FieldOffset(392)]
		public Vector3 vector3_2;

		[FieldOffset(432)]
		public float float_0;
	}

	private PerFrameCachedValue<Struct245> perFrameCachedValue_0;

	internal static Render render_0;

	public Vector3 InteractCenterWorld => (Vector3)(object)null;

	public Vector3 InteractSize => (Vector3)(object)null;

	public string Name => null;

	public Vector3 Rotation => (Vector3)(object)null;

	public float TerrainHeightAt => 0f;

	public Vector3 WorldPosition => (Vector3)(object)null;

	[SpecialName]
	internal Struct245 method_2()
	{
		return (Struct245)(object)null;
	}

	private Struct245 method_3()
	{
		return (Struct245)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static Render smethod_5()
	{
		return null;
	}

	static Render()
	{
		Class200.smethod_34();
	}
}
