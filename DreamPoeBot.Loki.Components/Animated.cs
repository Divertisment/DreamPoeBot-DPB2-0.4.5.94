using DreamPoeBot.Loki.FilesInMemory;
using DreamPoeBot.Loki.Game.Utilities;
using DreamPoeBot.Loki.Models;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class Animated : Component
{
	private PerFrameCachedValue<AnimatedSnapshot> perFrameCachedValue_0;

	private long long_2;

	private long long_3;

	private int int_0;

	private static Animated animated_0;

	public AnimatedSnapshot Snapshot => null;

	public EntityWrapper BaseAnimatedObjectEntity => null;

	public DatMiscAnimatedWrapper MiscAnimated => null;

	public AnimationController AnimatedAnimationController => null;

	private bool method_2()
	{
		return true;
	}

	private AnimatedSnapshot method_3()
	{
		return null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static Animated smethod_5()
	{
		return null;
	}

	static Animated()
	{
		Class200.smethod_34();
	}
}
