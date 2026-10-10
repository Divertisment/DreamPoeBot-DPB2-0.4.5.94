using ns0;

namespace DreamPoeBot.Loki.Bot;

public static class LatencyTracker
{
	public const int MinBound = 1;

	public const int MaxBound = 5000;

	private static LatencyTracker latencyTracker_0;

	public static int Current => 0;

	public static int Lowest => 0;

	public static int Average => 0;

	public static int Highest => 0;

	private static int smethod_0(int int_0)
	{
		return 0;
	}

	internal static bool smethod_1()
	{
		return true;
	}

	internal static LatencyTracker smethod_2()
	{
		return null;
	}

	static LatencyTracker()
	{
		Class200.smethod_34();
	}
}
