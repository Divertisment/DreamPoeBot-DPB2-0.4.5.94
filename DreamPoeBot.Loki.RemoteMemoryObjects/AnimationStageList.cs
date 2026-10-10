using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Game.Std;
using ns0;

namespace DreamPoeBot.Loki.RemoteMemoryObjects;

public class AnimationStageList : RemoteMemoryObject
{
	private List<AnimationStage> list_0;

	private static AnimationStageList animationStageList_0;

	public List<AnimationStage> AllStages => null;

	[SpecialName]
	private NativeVector method_0()
	{
		return (NativeVector)(object)null;
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static AnimationStageList smethod_3()
	{
		return null;
	}

	static AnimationStageList()
	{
		Class200.smethod_34();
	}
}
