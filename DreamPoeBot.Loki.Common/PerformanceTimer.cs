using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Common;

public class PerformanceTimer : IDisposable
{
	[CompilerGenerated]
	private static bool bool_0;

	private readonly Stopwatch stopwatch_0;

	private readonly string string_0;

	private readonly FinishedMeasuringCallback finishedMeasuringCallback_0;

	private int int_0;

	private readonly bool bool_1;

	private static readonly ILog ilog_0;

	internal static PerformanceTimer performanceTimer_0;

	public static bool DontPrint
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public TimeSpan Elapsed => (TimeSpan)(object)null;

	public long ElapsedMilliseconds => 0L;

	public PerformanceTimer(string debugText, int triggerMs = 0, FinishedMeasuringCallback callback = null, bool? dontPrint = null)
	{
	}

	public void Start()
	{
	}

	private void method_0()
	{
	}

	private void method_1()
	{
	}

	public void StopAndPrint()
	{
	}

	public void Dispose()
	{
	}

	static PerformanceTimer()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		bool_0 = true;
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static PerformanceTimer smethod_1()
	{
		return null;
	}
}
