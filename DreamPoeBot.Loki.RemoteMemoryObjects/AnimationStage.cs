using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.RemoteMemoryObjects;

public class AnimationStage : RemoteMemoryObject
{
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct ActorAnimationStageStruct
	{
		[FieldOffset(12)]
		public float StageStart;

		[FieldOffset(8)]
		public int ActorAnimationListIndex;

		[FieldOffset(24)]
		public long StageName;
	}

	private PerFrameCachedValue<ActorAnimationStageStruct> perFrameCachedValue_0;

	private string string_0;

	private int? nullable_0;

	private float? nullable_1;

	internal static AnimationStage animationStage_0;

	public float StageStart => 0f;

	public int ActorAnimationListIndex => 0;

	public string StageName => null;

	[SpecialName]
	internal ActorAnimationStageStruct method_0()
	{
		return (ActorAnimationStageStruct)(object)null;
	}

	[CompilerGenerated]
	private ActorAnimationStageStruct method_1()
	{
		return (ActorAnimationStageStruct)(object)null;
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static AnimationStage smethod_3()
	{
		return null;
	}

	static AnimationStage()
	{
		Class200.smethod_34();
	}
}
