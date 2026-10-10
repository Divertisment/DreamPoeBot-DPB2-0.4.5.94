using System;
using ns0;

namespace DreamPoeBot.Loki.Coroutine;

public class CoroutineUnhandledException : CoroutineException
{
	internal static CoroutineUnhandledException coroutineUnhandledException_0;

	public CoroutineUnhandledException(string message)
	{
	}

	public CoroutineUnhandledException(string message, Exception innerException)
	{
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static CoroutineUnhandledException smethod_3()
	{
		return null;
	}

	static CoroutineUnhandledException()
	{
		Class200.smethod_34();
	}
}
