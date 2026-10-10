using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.FilesInMemory;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class GroundEffect : Component
{
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct GroundEffectStruct
	{
		[FieldOffset(44)]
		public int SizeIncreaseOverTime;

		[FieldOffset(48)]
		public float MaxDuration;

		[FieldOffset(52)]
		public float Duration;

		[FieldOffset(56)]
		public long GroundEffectDat_EffectDescription;

		[FieldOffset(72)]
		public int Scale;
	}

	private PerFrameCachedValue<GroundEffectStruct> perFrameCachedValue_0;

	internal static GroundEffect groundEffect_0;

	public float Duration => 0f;

	public DatGroundEffectWrapper EffectDescription => null;

	public float MaxDuration => 0f;

	public int Scale => 0;

	public int SizeIncreaseOverTime => 0;

	[SpecialName]
	internal GroundEffectStruct method_2()
	{
		return (GroundEffectStruct)(object)null;
	}

	[CompilerGenerated]
	private GroundEffectStruct method_3()
	{
		return (GroundEffectStruct)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static GroundEffect smethod_5()
	{
		return null;
	}

	static GroundEffect()
	{
		Class200.smethod_34();
	}
}
