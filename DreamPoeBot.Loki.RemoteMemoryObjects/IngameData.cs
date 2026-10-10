using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Objects;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.Game.Utilities;
using DreamPoeBot.Loki.Models;
using ns0;

namespace DreamPoeBot.Loki.RemoteMemoryObjects;

public class IngameData : RemoteMemoryObject
{
	public class PortalObject : RemoteMemoryObject
	{
		public const int StructSize = 56;

		internal static PortalObject portalObject_0;

		public NetworkObject NetworkObject => null;

		public long Id => 0L;

		public string OwnerName => null;

		public DatWorldAreaWrapper Area => null;

		public override string ToString()
		{
			return null;
		}

		internal static bool smethod_2()
		{
			return true;
		}

		internal static PortalObject smethod_3()
		{
			return null;
		}

		static PortalObject()
		{
			Class200.smethod_34();
		}
	}

	private class Class53
	{
		internal readonly long long_0;

		internal readonly Memory memory_0;

		private readonly IngameData ingameData_0;

		private readonly object object_0;

		private PerFrameCachedValue<Struct41> perFrameCachedValue_0;

		private static Class53 class53_0;

		public Class53(IngameData ingameData_1, long long_1, Memory memory_1)
		{
		}

		[SpecialName]
		private Struct41 method_0()
		{
			return (Struct41)(object)null;
		}

		private void method_1()
		{
		}

		private Struct41 method_2()
		{
			return (Struct41)(object)null;
		}

		[SpecialName]
		public AreaTemplate method_3()
		{
			return null;
		}

		[SpecialName]
		public DatWorldAreaWrapper method_4()
		{
			return null;
		}

		[SpecialName]
		public long method_5()
		{
			return 0L;
		}

		[SpecialName]
		public int method_6()
		{
			return 0;
		}

		[SpecialName]
		public byte method_7()
		{
			return 0;
		}

		[SpecialName]
		public uint method_8()
		{
			return 0u;
		}

		[SpecialName]
		public EntityWrapper method_9()
		{
			return null;
		}

		[SpecialName]
		private EntityWrapper method_10()
		{
			return null;
		}

		[SpecialName]
		public NativeVector method_11()
		{
			return (NativeVector)(object)null;
		}

		[SpecialName]
		public long method_12()
		{
			return 0L;
		}

		[SpecialName]
		public NativeMap method_13()
		{
			return (NativeMap)(object)null;
		}

		[SpecialName]
		public NativeVector method_14()
		{
			return (NativeVector)(object)null;
		}

		[SpecialName]
		public NativeMap sabAcZoYmu4()
		{
			return (NativeMap)(object)null;
		}

		[SpecialName]
		public NativeVector method_15()
		{
			return (NativeVector)(object)null;
		}

		[SpecialName]
		public List<PortalObject> method_16()
		{
			return null;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class53 smethod_1()
		{
			return null;
		}

		static Class53()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	private struct Struct41
	{
		[FieldOffset(152)]
		public long long_0;

		[FieldOffset(168)]
		private long long_1;

		[FieldOffset(176)]
		public long long_2;

		[FieldOffset(184)]
		private long long_3;

		[FieldOffset(196)]
		public byte byte_0;

		[FieldOffset(194)]
		public byte kbaAcqwwPva;

		[FieldOffset(276)]
		public uint uint_0;

		[FieldOffset(304)]
		public NativeVector nativeVector_0;

		[FieldOffset(1216)]
		public NativeVector nativeVector_1;

		[FieldOffset(1456)]
		public long long_4;

		[FieldOffset(1464)]
		public NativeVector nativeVector_2;

		[FieldOffset(1776)]
		public NativeMap nativeMap_0;

		[FieldOffset(1792)]
		public NativeMap wagAcTvtUhO;

		[FieldOffset(2032)]
		public NativeVector nativeVector_3;
	}

	private readonly object object_0;

	private Class53 class53_0;

	internal static IngameData ingameData_0;

	public AreaTemplate CurrentArea => null;

	public DatWorldAreaWrapper CurrentWorldArea => null;

	public long CurrentWorldAreaAddress => 0L;

	public int CurrentAreaLevel => 0;

	public bool IsGuildHideout => true;

	public uint CurrentAreaHash => 0u;

	public EntityWrapper LocalPlayer => null;

	public long LocalPlayerRealArd => 0L;

	public NativeVector LocalPlayerVector => (NativeVector)(object)null;

	public long ServerDataAddress => 0L;

	public NativeMap FullEntityListAdr => (NativeMap)(object)null;

	public NativeMap SmallEntityListAdr => (NativeMap)(object)null;

	public NativeVector AreaGGGStatsType => (NativeVector)(object)null;

	public List<PortalObject> TownPortals => null;

	public NativeVector TopologiesAndRoomsVector => (NativeVector)(object)null;

	internal static uint smethod_2(Memory memory_0, long long_1)
	{
		return 0u;
	}

	[SpecialName]
	private Class53 method_0()
	{
		return null;
	}

	public void UpdateAddress(long l)
	{
	}

	internal static bool smethod_3()
	{
		return true;
	}

	internal static IngameData smethod_4()
	{
		return null;
	}

	static IngameData()
	{
		Class200.smethod_34();
	}
}
