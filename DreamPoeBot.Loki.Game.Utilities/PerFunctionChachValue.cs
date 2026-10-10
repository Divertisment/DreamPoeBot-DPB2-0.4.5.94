using System;
using ns0;

namespace DreamPoeBot.Loki.Game.Utilities;

public class PerFunctionChachValue<T, TKey> : PerCachedValue<T>
{
	private readonly Func<TKey> func_1;

	private TKey gparam_1;

	private bool bool_1;

	private static object object_1;

	public PerFunctionChachValue(Func<T> producer, Func<TKey> keyFunc)
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

	static PerFunctionChachValue()
	{
		Class200.smethod_34();
	}
}
