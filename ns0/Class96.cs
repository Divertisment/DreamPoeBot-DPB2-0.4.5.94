using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki;
using DreamPoeBot.Loki.Game;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.RemoteMemoryObjects;

namespace ns0;

internal static class Class96
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct Struct82
	{
		internal ushort Width;

		internal ushort ushort_0;

		internal ushort ushort_1;

		internal ushort ushort_2;

		internal NativeVector nativeVector_0;
	}

	private sealed class Class97
	{
		internal Memory memory_0;

		internal IngameData ingameData_0;

		internal long long_0;

		internal long long_1;

		internal long long_2;

		internal long long_3;

		internal long Header;

		internal uint uint_0;

		private static Class97 class97_0;

		internal bool method_0(Class97 class97_1)
		{
			return true;
		}

		internal void method_1()
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class97 smethod_1()
		{
			return null;
		}

		static Class97()
		{
			Class200.smethod_34();
		}
	}

	private static readonly object object_0;

	private static Class97 class97_0;

	private static Struct82 struct82_0;

	private static LokiPoe.InstanceInfo.Expedition.PlacementGrid placementGrid_0;

	private static long long_0;

	internal static Class96 class96_0;

	private static bool smethod_0(string string_0, Exception exception_0 = null)
	{
		return true;
	}

	private static T smethod_1<T>(Memory memory_0, long long_1) where T : unmanaged
	{
		return (T)null;
	}

	private static void smethod_2(bool bool_0, string string_0)
	{
	}

	private static Class97 smethod_3()
	{
		return null;
	}

	internal static bool smethod_4(out LokiPoe.InstanceInfo.Expedition.Snapshot snapshot_0)
	{
		return true;
	}

	private static LokiPoe.InstanceInfo.Expedition.PlacementGrid smethod_5(Class97 class97_1)
	{
		return null;
	}

	internal static int smethod_6(int int_0, ushort ushort_0, int int_1)
	{
		return 0;
	}

	private static int smethod_7(Class97 class97_1)
	{
		return 0;
	}

	internal static ushort smethod_8(string string_0)
	{
		return 0;
	}

	internal static bool smethod_9(out IReadOnlyList<LokiPoe.InstanceInfo.Expedition.ForbiddenArea> ireadOnlyList_0)
	{
		return true;
	}

	internal static bool smethod_10(out LokiPoe.InstanceInfo.Expedition.PlacementPlanner placementPlanner_0)
	{
		return true;
	}

	private static bool smethod_11(Exception exception_0)
	{
		return true;
	}

	private static void Clear()
	{
	}

	private static Vector2i Position(byte[] data, int at)
	{
		return (Vector2i)(object)null;
	}

	private static byte[] smethod_12(Memory memory_0, NativeVector nativeVector_0, int int_0, int int_1)
	{
		return null;
	}

	private static int Count(NativeVector vector, int stride, int maximum)
	{
		return 0;
	}

	static Class96()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		object_0 = new object();
	}

	internal static bool smethod_13()
	{
		return true;
	}

	internal static Class96 smethod_14()
	{
		return null;
	}
}
