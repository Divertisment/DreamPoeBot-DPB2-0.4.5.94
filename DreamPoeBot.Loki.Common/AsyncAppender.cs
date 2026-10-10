using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using log4net.Appender;
using log4net.Core;
using log4net.Util;
using ns0;

namespace DreamPoeBot.Loki.Common;

public sealed class AsyncAppender : IAppender, IBulkAppender, IOptionHandler, IAppenderAttachable
{
	private class Class122
	{
		internal object object_0;

		internal ConcurrentQueue<object> concurrentQueue_0;

		internal AppenderAttachedImpl appenderAttachedImpl_0;

		private static Class122 class122_0;

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class122 smethod_1()
		{
			return null;
		}

		static Class122()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private string string_0;

	private AppenderAttachedImpl appenderAttachedImpl_0;

	private FixFlags fixFlags_0;

	private Func<int> func_0;

	private string string_1;

	private Stopwatch stopwatch_0;

	private readonly ConcurrentQueue<object> concurrentQueue_0;

	private readonly object object_0;

	internal static AsyncAppender asyncAppender_0;

	public FixFlags Fix
	{
		get
		{
			return (FixFlags)(object)null;
		}
		set
		{
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public AppenderCollection Appenders => null;

	public AsyncAppender(Func<int> getDropRepeatMessageDelayMs)
	{
	}

	public void Close()
	{
	}

	public void DoAppend(LoggingEvent loggingEvent)
	{
	}

	public void AddAppender(IAppender newAppender)
	{
	}

	public IAppender GetAppender(string name)
	{
		return null;
	}

	public void RemoveAllAppenders()
	{
	}

	public IAppender RemoveAppender(IAppender appender)
	{
		return null;
	}

	public IAppender RemoveAppender(string name)
	{
		return null;
	}

	public void DoAppend(LoggingEvent[] loggingEvents)
	{
	}

	public void ActivateOptions()
	{
	}

	private static void smethod_0(object object_1)
	{
	}

	internal static bool smethod_1()
	{
		return true;
	}

	internal static AsyncAppender smethod_2()
	{
		return null;
	}

	static AsyncAppender()
	{
		Class200.smethod_34();
	}
}
