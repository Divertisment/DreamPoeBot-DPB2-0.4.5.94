using System;
using ns0;

namespace DreamPoeBot.Loki.Game.Utilities;

public class PerFrameCachedValue<T> : PerCachedValue<T>
{
	private long long_0;

	private static object object_1;

	public PerFrameCachedValue(Func<T> producer)
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

	static PerFrameCachedValue()
	{
		Class200.smethod_34();
	}
}
