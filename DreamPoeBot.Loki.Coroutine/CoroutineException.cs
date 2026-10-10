using System;
using ns0;

namespace DreamPoeBot.Loki.Coroutine;

public abstract class CoroutineException : Exception
{
	internal static CoroutineException coroutineException_0;

	protected CoroutineException(string message)
	{
	}

	protected CoroutineException(string message, Exception innerException)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static CoroutineException smethod_1()
	{
		return null;
	}

	static CoroutineException()
	{
		Class200.smethod_34();
	}
}
