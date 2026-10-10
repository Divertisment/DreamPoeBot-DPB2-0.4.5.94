using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Elements;

public class MapElement : Element
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct168
	{
		public float float_0;

		public float float_1;

		public float float_2;

		public float float_3;

		public long long_0;

		public long long_1;

		public long long_2;

		public long long_3;

		public long long_4;

		public long long_5;

		public float float_4;
	}

	public const double CameraAngle = 0.6754424205218056;

	public static readonly float CameraAngleCos;

	public static readonly float CameraAngleSin;

	private readonly int int_3;

	private PerFrameCachedValue<Struct168> perFrameCachedValue_6;

	private PerFrameCachedValue<Struct168> perFrameCachedValue_7;

	internal static MapElement mapElement_0;

	public Element MapCompleteElement => null;

	public Element LargeMap => null;

	public float LargeMapShiftX => 0f;

	public float LargeMapShiftY => 0f;

	public float LargeMapDefaultShiftX => 0f;

	public float LargeMapDefaultShiftY => 0f;

	public float LargeMapZoom => 0f;

	public float LargeMapScale => 0f;

	public float LargeMapCenter => 0f;

	public Element SmallMap => null;

	public float SmallMapShiftX => 0f;

	public float SmallMapShiftY => 0f;

	public float SmallMapDefaultShiftX => 0f;

	public float SmallMapDefaultShiftY => 0f;

	public float SmallMapZoom => 0f;

	public Element ZoneDescriptionElement => null;

	public string ZoneDescription => null;

	public Element MapModPanelButton => null;

	public bool IsMapModPanelVisibleAndExpanded => true;

	[SpecialName]
	internal Struct168 method_29()
	{
		return (Struct168)(object)null;
	}

	[SpecialName]
	internal Struct168 method_30()
	{
		return (Struct168)(object)null;
	}

	static MapElement()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		CameraAngleCos = (float)Math.Cos(0.6754424205218056);
		CameraAngleSin = (float)Math.Sin(0.6754424205218056);
	}

	[CompilerGenerated]
	private Struct168 method_31()
	{
		return (Struct168)(object)null;
	}

	[CompilerGenerated]
	private Struct168 method_32()
	{
		return (Struct168)(object)null;
	}

	internal static bool smethod_11()
	{
		return true;
	}

	internal static MapElement smethod_12()
	{
		return null;
	}
}
