using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class BrequelFruit : Component
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct192
	{
		public long long_0;

		public long long_1;

		public long long_2;

		public int Level;
	}

	private PerFrameCachedValue<Struct192> perFrameCachedValue_0;

	public static readonly Dictionary<int, int> GGPKHardcodedData;

	internal static BrequelFruit brequelFruit_0;

	public int FruitLevel => 0;

	public int HivebloodRequired => 0;

	[SpecialName]
	private Struct192 method_2()
	{
		return (Struct192)(object)null;
	}

	static BrequelFruit()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		GGPKHardcodedData = new Dictionary<int, int>
		{
			[1] = 8,
			[2] = 8,
			[3] = 8,
			[4] = 8,
			[5] = 9,
			[6] = 9,
			[7] = 10,
			[8] = 11,
			[9] = 11,
			[10] = 14,
			[11] = 14,
			[12] = 16,
			[13] = 19,
			[14] = 21,
			[15] = 21,
			[16] = 22,
			[17] = 22,
			[18] = 25,
			[19] = 25,
			[20] = 25,
			[21] = 27,
			[22] = 27,
			[23] = 28,
			[24] = 32,
			[25] = 32,
			[26] = 35,
			[27] = 36,
			[28] = 36,
			[29] = 36,
			[30] = 36,
			[31] = 37,
			[32] = 45,
			[33] = 45,
			[34] = 45,
			[35] = 46,
			[36] = 46,
			[37] = 49,
			[38] = 49,
			[39] = 49,
			[40] = 59,
			[41] = 59,
			[42] = 63,
			[43] = 63,
			[44] = 76,
			[45] = 85,
			[46] = 88,
			[47] = 88,
			[48] = 88,
			[49] = 93,
			[50] = 93,
			[51] = 106,
			[52] = 106,
			[53] = 106,
			[54] = 112,
			[55] = 112,
			[56] = 117,
			[57] = 117,
			[58] = 118,
			[59] = 120,
			[60] = 126,
			[61] = 126,
			[62] = 126,
			[63] = 127,
			[64] = 132,
			[65] = 135,
			[66] = 135,
			[67] = 136,
			[68] = 210,
			[69] = 286,
			[70] = 361,
			[71] = 437,
			[72] = 514,
			[73] = 590,
			[74] = 667,
			[75] = 745,
			[76] = 822,
			[77] = 900,
			[78] = 979,
			[79] = 1058,
			[80] = 1137,
			[81] = 1217,
			[82] = 1297,
			[83] = 1297,
			[84] = 1297,
			[85] = 1297,
			[86] = 1297,
			[87] = 1297,
			[88] = 1297,
			[89] = 1297,
			[90] = 1297,
			[91] = 1297,
			[92] = 1297,
			[93] = 1297,
			[94] = 1297,
			[95] = 1297,
			[96] = 1297,
			[97] = 1297,
			[98] = 1297,
			[99] = 1297,
			[100] = 1297
		};
	}

	[CompilerGenerated]
	private Struct192 method_3()
	{
		return (Struct192)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static BrequelFruit smethod_5()
	{
		return null;
	}
}
