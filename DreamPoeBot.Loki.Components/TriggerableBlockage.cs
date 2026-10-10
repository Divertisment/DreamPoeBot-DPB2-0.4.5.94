using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class TriggerableBlockage : Component
{
	[StructLayout(LayoutKind.Explicit)]
	internal struct Struct264
	{
		[FieldOffset(48)]
		public byte byte_0;

		[FieldOffset(49)]
		public byte byte_1;

		[FieldOffset(50)]
		public byte byte_2;

		[FieldOffset(51)]
		public byte byte_3;

		[FieldOffset(52)]
		public byte byte_4;

		[FieldOffset(100)]
		public Vector2i vector2i_0;

		[FieldOffset(108)]
		public Vector2i vector2i_1;

		[FieldOffset(120)]
		public NativeVector nativeVector_0;

		[FieldOffset(144)]
		public NativeVector nativeVector_1;
	}

	private PerFrameCachedValue<Struct264> perFrameCachedValue_0;

	internal static TriggerableBlockage triggerableBlockage_0;

	public int Distance => 0;

	public string Name => null;

	public string Metadata => null;

	public bool IsTargetable => true;

	public Vector2i BoundsMin => (Vector2i)(object)null;

	public Vector2i BoundsMax => (Vector2i)(object)null;

	public Vector2i Size => (Vector2i)(object)null;

	public bool IsOpened => true;

	public byte _19 => 0;

	public byte _1A => 0;

	public byte _1B => 0;

	public byte _1C => 0;

	public byte[] NavData => null;

	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	internal Struct264 method_2()
	{
		return (Struct264)(object)null;
	}

	private Struct264 method_3()
	{
		return (Struct264)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static TriggerableBlockage smethod_5()
	{
		return null;
	}

	static TriggerableBlockage()
	{
		Class200.smethod_34();
	}
}
