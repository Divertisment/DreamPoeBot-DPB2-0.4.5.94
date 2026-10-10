using System;
using ns0;

namespace DreamPoeBot.Loki.Game.Utilities;

public class SlowCacheValue<T> : PerCachedValue<T>
{
	private long long_0;

	internal static object object_1;

	public SlowCacheValue(Func<T> producer)
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

	static SlowCacheValue()
	{
		Class200.smethod_34();
	}
}
