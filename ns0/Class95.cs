using System.Collections.Generic;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Game;

namespace ns0;

internal sealed class Class95
{
	private struct Struct80
	{
		internal int int_0;

		internal float float_0;

		internal float float_1;
	}

	private struct Struct81
	{
		internal int int_0;

		internal float float_0;

		internal bool bool_0;
	}

	private readonly LokiPoe.InstanceInfo.Expedition.PlacementGrid placementGrid_0;

	private readonly byte[] byte_0;

	private readonly int int_0;

	private readonly int int_1;

	private readonly int int_2;

	private static readonly int[] int_3;

	private static readonly int[] int_4;

	internal static Class95 class95_0;

	internal Class95(LokiPoe.InstanceInfo.Expedition.PlacementGrid placementGrid_1, byte[] byte_1, int int_5, int int_6, int int_7)
	{
	}

	internal List<Vector2i> method_0(Vector2i vector2i_0, Vector2i vector2i_1, Vector2i vector2i_2, Vector2i vector2i_3)
	{
		return null;
	}

	private static float smethod_0(int int_5, int int_6, Vector2i vector2i_0)
	{
		return 0f;
	}

	private int method_1(int int_5, int int_6)
	{
		return 0;
	}

	private bool method_2(Vector2i vector2i_0, Vector2i vector2i_1)
	{
		return true;
	}

	private static void smethod_1(List<Struct80> list_0, Struct80 struct80_0)
	{
	}

	private static Struct80 smethod_2(List<Struct80> list_0)
	{
		return (Struct80)(object)null;
	}

	static Class95()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		int_3 = new int[8] { 0, 1, 0, -1, 1, 1, -1, -1 };
		int_4 = new int[8] { -1, 0, 1, 0, -1, 1, 1, -1 };
	}

	internal static bool smethod_3()
	{
		return true;
	}

	internal static Class95 smethod_4()
	{
		return null;
	}
}
