using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.RemoteMemoryObjects;

public class SupportedAnimationList : RemoteMemoryObject
{
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct ActorAnimationListStruct
	{
		[FieldOffset(16)]
		public NativeVector AnimationList;
	}

	private PerFrameCachedValue<ActorAnimationListStruct> perFrameCachedValue_0;

	private List<AnimationStageList> list_0;

	internal static SupportedAnimationList supportedAnimationList_0;

	public List<AnimationStageList> Animations => null;

	[SpecialName]
	internal ActorAnimationListStruct method_0()
	{
		return (ActorAnimationListStruct)(object)null;
	}

	[CompilerGenerated]
	private ActorAnimationListStruct method_1()
	{
		return (ActorAnimationListStruct)(object)null;
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static SupportedAnimationList smethod_3()
	{
		return null;
	}

	static SupportedAnimationList()
	{
		Class200.smethod_34();
	}
}
