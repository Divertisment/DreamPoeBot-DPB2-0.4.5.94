using System;
using ns0;

namespace DreamPoeBot.Loki.Game.Utilities;

public class PerFramesCachedValue<T> : PerCachedValue<T>
{
	private long long_0;

	private readonly long long_1;

	internal static object object_1;

	public PerFramesCachedValue(Func<T> producer, int duration)
	{
	}

	protected override bool ShouldUpdateCache(bool force = false)
	{
		return true;
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static object smethod_3()
	{
		return null;
	}

	static PerFramesCachedValue()
	{
		Class200.smethod_34();
	}
}
