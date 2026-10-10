using System;
using ns0;

namespace DreamPoeBot.Loki.Game.Utilities;

public class PerAreaCachedValue<T> : PerCachedValue<T>
{
	private long long_0;

	private uint uint_0;

	private string string_0;

	internal static object object_1;

	public PerAreaCachedValue(Func<T> producer, string name)
	{
	}

	public PerAreaCachedValue(Func<T> producer)
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

	static PerAreaCachedValue()
	{
		Class200.smethod_34();
	}
}
