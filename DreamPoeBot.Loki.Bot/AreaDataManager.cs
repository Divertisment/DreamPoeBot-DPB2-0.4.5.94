using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Bot;

public class AreaDataManager<T> where T : AreaData
{
	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private int int_1;

	private readonly ILog ilog_0;

	private readonly Dictionary<uint, T> dictionary_0;

	private readonly Stopwatch stopwatch_0;

	private readonly Func<uint, T> func_0;

	private static object object_0;

	public bool DebugLogging
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

	public int MsBetweenTicks
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public int DataInactivityExpireTimeMs
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public T Active => null;

	public AreaDataManager(Func<uint, T> allocateFunc)
	{
	}

	public void Start()
	{
	}

	public void Tick()
	{
	}

	public void Stop()
	{
	}

	private void method_0()
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

	static AreaDataManager()
	{
		Class200.smethod_34();
	}
}
