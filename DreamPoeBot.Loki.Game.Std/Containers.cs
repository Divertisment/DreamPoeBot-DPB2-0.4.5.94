using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Elements;
using DreamPoeBot.Loki.Game.GameData;
using ns0;

namespace DreamPoeBot.Loki.Game.Std;

public static class Containers
{
	[StructLayout(LayoutKind.Explicit, Size = 92)]
	public struct AmmoTreeNode
	{
		[FieldOffset(0)]
		public long Left;

		[FieldOffset(8)]
		public long Parent;

		[FieldOffset(16)]
		public long Right;

		[FieldOffset(24)]
		public byte Color;

		[FieldOffset(25)]
		public byte IsNil;

		[FieldOffset(32)]
		public uint SkillId;

		[FieldOffset(76)]
		public int MaxBolts;

		[FieldOffset(80)]
		public int CurrentBolts;

		[FieldOffset(88)]
		public int State;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 24)]
	internal struct Struct83
	{
		public readonly long long_0;

		private readonly long long_1;

		public readonly AtlasPanel2.Struct159 struct159_0;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 24)]
	internal struct Struct84
	{
		public readonly long long_0;

		private readonly long long_1;

		public readonly long long_2;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 32)]
	internal struct Struct85
	{
		public readonly long long_0;

		private readonly long long_1;

		public readonly AtlasPanel2.Struct158 struct158_0;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 32)]
	internal struct Struct86
	{
		public readonly long long_0;

		private readonly long long_1;

		public readonly byte byte_0;

		private readonly byte byte_1;

		private readonly ushort ushort_0;

		private readonly ushort ushort_1;

		private readonly ushort ushort_2;

		public readonly long long_2;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 52)]
	internal struct Struct87
	{
		public readonly long long_0;

		public readonly long long_1;

		public readonly GStruct2 gstruct2_0;

		public readonly int fmcAhEorhsw;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct88
	{
		public readonly long long_0;

		public readonly long long_1;

		public readonly LokiPoe.InGameState.ChatPanel.ChatMessageStruct chatMessageStruct_0;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct89
	{
		public readonly long Left;

		public readonly long long_0;

		public readonly long Right;

		public readonly byte byte_0;

		public readonly byte byte_1;

		private readonly byte byte_2;

		private readonly byte byte_3;

		private readonly int int_0;

		public readonly int int_1;

		private readonly int int_2;

		public readonly long Value;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct90
	{
		public readonly long Left;

		public readonly long Center;

		public readonly long Right;

		public readonly byte byte_0;

		public readonly byte byte_1;

		private readonly byte byte_2;

		private readonly byte byte_3;

		private readonly int int_0;

		public readonly long long_0;

		public readonly long Value;
	}

	private static int int_0;

	private static byte[] byte_0;

	private static byte[] byte_1;

	internal static Containers containers_0;

	public static bool TryFindAmmoNode(NativeMap map, uint skillId, out long nodeAddress, out AmmoTreeNode nodeData)
	{
		return true;
	}

	internal static (long, AtlasPanel2.Struct159)[] smethod_0<T>(NativeList nativeList_0, Memory memory_0 = null) where T : unmanaged
	{
		return null;
	}

	internal static (long, long)[] smethod_1<T>(NativeList nativeList_0, Memory memory_0 = null) where T : unmanaged
	{
		return null;
	}

	internal static (long, AtlasPanel2.Struct158)[] smethod_2<T>(NativeList nativeList_0, Memory memory_0 = null) where T : unmanaged
	{
		return null;
	}

	public static List<int> NativeList_ListInt<TValue>(NativeList nativeList, Memory m = null) where TValue : unmanaged
	{
		return null;
	}

	public static List<KeyValuePair<ushort, long>> StdInt_LongList<TValue>(NativeList nativeList, Memory m = null) where TValue : unmanaged
	{
		return null;
	}

	public static List<KeyValuePair<GStruct2, int>> StdNativeStringWCustom_intList<TValue>(NativeList nativeList, Memory m = null) where TValue : unmanaged
	{
		return null;
	}

	internal static List<KeyValuePair<StatTypeGGG, int>> smethod_3<T>(NativeVector nativeVector_0, Memory memory_0 = null) where T : unmanaged
	{
		return null;
	}

	internal static List<KeyValuePair<long, long>> smethod_4(NativeVector nativeVector_0, Memory memory_0 = null)
	{
		return null;
	}

	public static string StdStringW(NativeStringW nativeString)
	{
		return null;
	}

	public static string StdStringWCustom(GStruct2 nativeString)
	{
		return null;
	}

	public static string StdStringACustom(GStruct2 nativeString)
	{
		return null;
	}

	public static string StdStringA(NativeStringA nativeString)
	{
		return null;
	}

	public static Dictionary<int, long> StdInt_LongHashMap<TKey, TValue>(NativeHashMap nativeHashMap, Memory m = null)
	{
		return null;
	}

	public static Dictionary<int, long> StdInt_LongDictFromList<TKey, TValue>(NativeList nativeList, Memory m = null)
	{
		return null;
	}

	public static Dictionary<GStruct2, int> StdNativeStringWCustom_intHashMap<TKey, TValue>(NativeHashMap nativeHashMap, Memory m = null)
	{
		return null;
	}

	internal static List<Tuple<LokiPoe.InGameState.ChatPanel.ChatMessageStruct, long>> smethod_5<T>(NativeList nativeList_0, Memory memory_0 = null) where T : unmanaged
	{
		return null;
	}

	internal static List<LokiPoe.InGameState.ChatPanel.ChatMessageStruct> smethod_6<T>(NativeList nativeList_0, Memory memory_0 = null) where T : unmanaged
	{
		return null;
	}

	[SpecialName]
	private static int smethod_7()
	{
		return 0;
	}

	public static List<long> StdListLongUltimatumModifiers(NativeList nativeList, Memory m = null)
	{
		return null;
	}

	public static Dictionary<int, long> StdMapIntLongWhile(NativeMap nativeMap, Memory m = null, Func<int, bool> keyfilter = null, bool benchmark = false)
	{
		return null;
	}

	public static Dictionary<int, long> StdMapIntLong(NativeMap nativeMap, Memory m = null, Func<int, bool> keyfilter = null, bool benchmark = false)
	{
		return null;
	}

	private static void smethod_8(long long_0, ref Dictionary<long, Struct89> dictionary_0, ref Dictionary<int, long> dictionary_1, ref Memory memory_0, uint uint_0, Func<int, bool> func_0 = null)
	{
	}

	static Containers()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		int_0 = -1;
		byte_0 = new byte[8];
		byte_1 = new byte[160];
	}

	internal static bool smethod_9()
	{
		return true;
	}

	internal static Containers smethod_10()
	{
		return null;
	}
}
