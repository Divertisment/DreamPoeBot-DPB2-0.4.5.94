using System.Runtime.CompilerServices;
using ns0;

namespace DreamPoeBot.Loki.Coroutine;

public struct ExternalTaskWaitResult<T>
{
	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private T gparam_0;

	internal static readonly ExternalTaskWaitResult<T> externalTaskWaitResult_0;

	public bool Completed
	{
		[CompilerGenerated]
		readonly get
		{
			return true;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public T Result
	{
		[CompilerGenerated]
		readonly get
		{
			return (T)null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	private ExternalTaskWaitResult(T result)
	{
	}

	internal static ExternalTaskWaitResult<T> smethod_0(T gparam_1)
	{
		return (ExternalTaskWaitResult<T>)null;
	}

	internal static bool smethod_1()
	{
		return true;
	}

	internal static object smethod_2()
	{
		return null;
	}

	static ExternalTaskWaitResult()
	{
		Class200.smethod_34();
	}
}
