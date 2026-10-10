using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using ns0;

namespace DreamPoeBot.Loki.Bot.Pathfinding.RDWrapper.Utils;

public static class Profiler
{
	private static readonly ConcurrentDictionary<string, long> concurrentDictionary_0;

	private static readonly ConcurrentDictionary<string, long> concurrentDictionary_1;

	private static readonly ConcurrentDictionary<string, int> concurrentDictionary_2;

	private static readonly ConcurrentDictionary<string, long> concurrentDictionary_3;

	private static readonly long long_0;

	private static readonly ConcurrentDictionary<string, List<float>> concurrentDictionary_4;

	private static int int_0;

	private static Profiler profiler_0;

	public static void StartTimer(string label)
	{
	}

	public static void StopTimer(string label)
	{
	}

	public static void StartAllocTracking(string label)
	{
	}

	public static void StopAllocTracking(string label)
	{
	}

	public static void Reset()
	{
	}

	public static void Update()
	{
	}

	public static IEnumerable<string> GetOperationNames()
	{
		return null;
	}

	public static float GetAverageTime(string operation)
	{
		return 0f;
	}

	public static float[] GetHistoryData(string operation)
	{
		return null;
	}

	public static string GetResults()
	{
		return null;
	}

	static Profiler()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		concurrentDictionary_0 = new ConcurrentDictionary<string, long>();
		concurrentDictionary_1 = new ConcurrentDictionary<string, long>();
		concurrentDictionary_2 = new ConcurrentDictionary<string, int>();
		concurrentDictionary_3 = new ConcurrentDictionary<string, long>();
		long_0 = GC.GetTotalMemory(forceFullCollection: false);
		concurrentDictionary_4 = new ConcurrentDictionary<string, List<float>>();
		int_0 = 10000;
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static Profiler smethod_1()
	{
		return null;
	}
}
