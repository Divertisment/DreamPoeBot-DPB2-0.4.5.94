using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class Positioned : Component
{
	[StructLayout(LayoutKind.Explicit)]
	public struct PositionedComponentStructure
	{
		[FieldOffset(480)]
		public byte byte_7Reaction;

		[FieldOffset(504)]
		public sbyte sbyte_ObjectSize;

		[FieldOffset(1092)]
		public Vector2i vector2i_0MapPosition;

		[FieldOffset(1100)]
		public float floatRotationNew;

		[FieldOffset(1132)]
		public float float_Size;

		[FieldOffset(1136)]
		public float float_SizeScale;

		[FieldOffset(1168)]
		public Vector2 vector2_0WorldPosition;
	}

	private PerFrameCachedValue<PositionedComponentStructure> perFrameCachedValue_0;

	private static Positioned positioned_0;

	public int GridX => 0;

	public int GridY => 0;

	public Vector2i GridPos => (Vector2i)(object)null;

	public float WorldX => 0f;

	public float WorldY => 0f;

	public int ObjectSize => 0;

	public int CharacterSize => 0;

	public int TerrainSize => 0;

	public Vector2i MapPosition => (Vector2i)(object)null;

	public float Rotation => 0f;

	public byte Reaction => 0;

	[SpecialName]
	internal Vector2 method_2()
	{
		return (Vector2)(object)null;
	}

	[SpecialName]
	private PositionedComponentStructure method_3()
	{
		return (PositionedComponentStructure)(object)null;
	}

	private PositionedComponentStructure method_4()
	{
		return (PositionedComponentStructure)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static Positioned smethod_5()
	{
		return null;
	}

	static Positioned()
	{
		Class200.smethod_34();
	}
}
