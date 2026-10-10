using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Loki.Elements;

public class SanctumArchivesElement : Element
{
	public class SanctumRoom : Element
	{
		private static SanctumRoom sanctumRoom_0;

		public string DeferReward1 => null;

		public string DeferReward2 => null;

		public string DeferReward3 => null;

		public string PersistentEffectStatType => null;

		public string PersistentEffectName => null;

		public string Id0 => null;

		public string Id1 => null;

		public string Metadata0 => null;

		public string Metadata1 => null;

		public string ContainDescription0 => null;

		public string ContainDescription1 => null;

		[SpecialName]
		private Struct169 method_29()
		{
			return (Struct169)(object)null;
		}

		[SpecialName]
		private Struct169 method_30()
		{
			return (Struct169)(object)null;
		}

		[SpecialName]
		private long method_31()
		{
			return 0L;
		}

		[SpecialName]
		private Struct171 method_32()
		{
			return (Struct171)(object)null;
		}

		[SpecialName]
		private Struct171 method_33()
		{
			return (Struct171)(object)null;
		}

		[SpecialName]
		private long method_34()
		{
			return 0L;
		}

		[SpecialName]
		private long method_35()
		{
			return 0L;
		}

		[SpecialName]
		private long method_36()
		{
			return 0L;
		}

		internal static bool smethod_11()
		{
			return true;
		}

		internal static SanctumRoom smethod_12()
		{
			return null;
		}

		static SanctumRoom()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct169
	{
		public long Id;

		public long Metadata;

		public long oEalbWxowHt;

		public long long_0;

		public long long_1;

		public long long_2;

		public long long_3;

		public long long_4;

		public long long_5;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct170
	{
		public long long_0;

		public byte byte_0;

		public byte byte_1;

		public long long_1;

		public long long_2;

		public long long_3;

		public long long_4;

		public int int_0;

		public byte mVilbDuPvbZ;

		public long long_5;

		public byte byte_2;

		public long long_6;

		public int int_1;

		public int int_2;

		public long long_7;

		public int int_3;

		public int int_4;

		public long long_8;

		public long long_9;

		public byte byte_3;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct171
	{
		public long Id;

		public long long_0;

		public long long_1;

		public long long_2;

		public long long_3;

		public long long_4;

		public long long_5;

		public long long_6;

		public long long_7;

		public long long_8;
	}

	private static SanctumArchivesElement sanctumArchivesElement_0;

	public Element ActualCurrencyPannel => null;

	public Element MainPannel => null;

	public Element RoomsTree => null;

	public Element RoomsColumns => null;

	public Dictionary<int, List<SanctumRoom>> Rooms => null;

	public Element Resolver => null;

	public Element StoreRoomForLater => null;

	public Element RelicEffects => null;

	internal static bool smethod_11()
	{
		return true;
	}

	internal static SanctumArchivesElement smethod_12()
	{
		return null;
	}

	static SanctumArchivesElement()
	{
		Class200.smethod_34();
	}
}
