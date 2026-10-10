using System;
using System.Collections.Generic;
using ns0;

namespace DreamPoeBot.Framework.Helpers;

public static class LinqHelper
{
	public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
	{
	}

	public static void ForEach<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> dictionary, Action<TKey, TValue> action)
	{
	}

	static LinqHelper()
	{
		Class200.smethod_34();
	}
}
