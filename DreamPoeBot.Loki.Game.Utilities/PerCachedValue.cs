using System;
using ns0;

namespace DreamPoeBot.Loki.Game.Utilities;

public abstract class PerCachedValue<T>
{
	private readonly Func<T> func_0;

	private T gparam_0;

	private EventHandler<CacheUpdateEvent> eventHandler_0;

	private bool bool_0;

	internal static object object_0;

	public T Value => (T)null;

	protected abstract bool ShouldUpdateCache(bool force = false);

	protected PerCachedValue(Func<T> producer)
	{
	}

	public static implicit operator T(PerCachedValue<T> pfcv)
	{
		return (T)null;
	}

	public void RequestCacheFlush()
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static object smethod_1()
	{
		return null;
	}

	static PerCachedValue()
	{
		Class200.smethod_34();
	}
}
