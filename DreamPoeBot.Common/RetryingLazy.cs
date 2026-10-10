using System;
using DreamPoeBot.Loki.Common;
using log4net;
using ns0;

namespace DreamPoeBot.Common;

public sealed class RetryingLazy<T> where T : class
{
	private static readonly ILog Log;

	private readonly Func<T> func_0;

	private readonly Func<T, bool> func_1;

	private readonly T gparam_0;

	private readonly object object_0;

	private T? gparam_1;

	private volatile bool bool_0;

	internal static object object_1;

	public bool HasValue => true;

	public T Value => null;

	public RetryingLazy(Func<T> loader, Func<T, bool> validator, T emptyValue)
	{
	}

	public bool TryGetValue(out T value)
	{
		return true;
	}

	public void Invalidate()
	{
	}

	static RetryingLazy()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		Log = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static object smethod_1()
	{
		return null;
	}
}
