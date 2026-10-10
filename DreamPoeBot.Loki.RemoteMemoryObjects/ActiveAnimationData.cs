using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.RemoteMemoryObjects;

public class ActiveAnimationData : RemoteMemoryObject
{
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct ActiveAnimationStruct
	{
		[FieldOffset(32)]
		public int AnimationId;

		[FieldOffset(88)]
		public float SlowAnimationSpeed;

		[FieldOffset(92)]
		public float NormalAnimationSpeed;

		[FieldOffset(72)]
		public long SlowAnimationStartStagePtr;

		[FieldOffset(80)]
		public long SlowAnimationEndStagePtr;

		[FieldOffset(16)]
		internal long YytAbySrlSO;

		[FieldOffset(36)]
		internal int int_0;

		[FieldOffset(64)]
		internal long long_0;

		[FieldOffset(97)]
		internal byte Enabled;
	}

	private PerFrameCachedValue<ActiveAnimationStruct> perFrameCachedValue_0;

	private static readonly Func<float, float> func_0;

	internal static ActiveAnimationData activeAnimationData_0;

	public int AnimationId => 0;

	public float SlowAnimationSpeed => 0f;

	public float NormalAnimationSpeed => 0f;

	public float? AnimationSpeed => null;

	public AnimationStage SlowAnimationStartStage => null;

	public AnimationStage SlowAnimationEndStage => null;

	public Func<float, float> TransformRawProgressFunc => null;

	[SpecialName]
	internal ActiveAnimationStruct method_0()
	{
		return (ActiveAnimationStruct)(object)null;
	}

	static ActiveAnimationData()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		func_0 = (float progress) => 0f;
	}

	[CompilerGenerated]
	private ActiveAnimationStruct method_1()
	{
		return (ActiveAnimationStruct)(object)null;
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static ActiveAnimationData smethod_3()
	{
		return null;
	}
}
