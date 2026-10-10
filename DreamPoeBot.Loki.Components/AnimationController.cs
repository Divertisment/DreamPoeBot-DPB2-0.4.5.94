using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Common;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.Game.Utilities;
using DreamPoeBot.Loki.RemoteMemoryObjects;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class AnimationController : Component
{
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct AnimationControllerStruct
	{
		[FieldOffset(32)]
		public NativeVector ActiveAnimationsArrayPtr;

		[FieldOffset(384)]
		public long ActorAnimationArrayPtr;

		[FieldOffset(400)]
		public int AnimationInActorId;

		[FieldOffset(420)]
		public float AnimationProgress;

		[FieldOffset(424)]
		public int CurrentAnimationStage;

		[FieldOffset(428)]
		public float NextAnimationPoint;

		[FieldOffset(432)]
		public float AnimationSpeedMultiplier1;

		[FieldOffset(376)]
		public float AnimationSpeedMultiplier2;

		[FieldOffset(440)]
		public float MaxAnimationProgressOffset;

		[FieldOffset(444)]
		public float MaxAnimationProgress;

		[FieldOffset(456)]
		internal int int_0;

		[FieldOffset(468)]
		internal byte byte_0;
	}

	private static readonly ILog ilog_0;

	internal static Func<float, float> func_0;

	private readonly PerCachedValue<Func<float, float>> perCachedValue_0;

	private readonly PerCachedValue<float> perCachedValue_1;

	private readonly PerFrameCachedValue<ActiveAnimationData> perFrameCachedValue_0;

	private readonly PerFrameCachedValue<SupportedAnimationList> perFrameCachedValue_1;

	private readonly PerFrameCachedValue<AnimationControllerStruct> perFrameCachedValue_2;

	private static AnimationController animationController_0;

	public AnimationControllerStruct Structure => (AnimationControllerStruct)(object)null;

	public ActiveAnimationData ActiveAnimationData => null;

	public float MaxRawAnimationProgress => 0f;

	public float RawNextAnimationPoint => 0f;

	public float RawAnimationProgress => 0f;

	public float RawAnimationSpeed => 0f;

	public float TransformedMaxRawAnimationProgress => 0f;

	public float TransformedRawNextAnimationPoint => 0f;

	public float TransformedRawAnimationProgress => 0f;

	public float AnimationSpeed => 0f;

	public SupportedAnimationList SupportedAnimationList => null;

	public int CurrentAnimationId => 0;

	public int CurrentAnimationStage => 0;

	public AnimationStageList CurrentAnimation => null;

	public float NextAnimationPoint => 0f;

	public float AnimationProgress => 0f;

	public TimeSpan AnimationCompletesIn => (TimeSpan)(object)null;

	public TimeSpan AnimationActiveFor => (TimeSpan)(object)null;

	private ActiveAnimationData method_2()
	{
		return null;
	}

	private static float smethod_4(AnimationControllerStruct animationControllerStruct_0)
	{
		return 0f;
	}

	public float TransformProgress(float progress)
	{
		return 0f;
	}

	private static float smethod_5(float float_0, float float_1)
	{
		return 0f;
	}

	static AnimationController()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	[CompilerGenerated]
	private AnimationControllerStruct method_3()
	{
		return (AnimationControllerStruct)(object)null;
	}

	[CompilerGenerated]
	private Func<float, float> method_4()
	{
		return null;
	}

	[CompilerGenerated]
	private float method_5()
	{
		return 0f;
	}

	[CompilerGenerated]
	private SupportedAnimationList method_6()
	{
		return null;
	}

	internal static bool smethod_6()
	{
		return true;
	}

	internal static AnimationController smethod_7()
	{
		return null;
	}
}
