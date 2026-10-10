using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class HeistContract : Component
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct211
	{
		public long long_0;

		public long long_1;

		public long long_2;

		public int int_0;

		public byte byte_0;

		public byte byte_1;

		public byte byte_2;

		public byte byte_3;

		public long long_3;

		public long long_4;

		public NativeVector nativeVector_0;

		public NativeVector nativeVector_1;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct215
	{
		public long long_0;

		public long long_1;

		private float float_0;

		public long long_2;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct216
	{
		public long long_0;

		public long long_1;

		public byte byte_0;

		public byte byte_1;

		public byte byte_2;

		public byte byte_3;

		public byte byte_4;

		public byte byte_5;

		public byte byte_6;

		public byte byte_7;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct217
	{
		public long Id;

		public long Name;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct218
	{
		public long long_0;

		public long long_1;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct219
	{
		public long long_0;

		public long long_1;

		public long long_2;

		public long long_3;

		public int int_0;

		public int int_1;

		public long long_4;

		public long long_5;

		public int int_2;

		public int int_3;

		public long long_6;

		public long long_7;

		public long long_8;

		private float float_0;

		public int int_4;

		public int int_5;

		public long long_9;

		public long long_10;

		public long long_11;
	}

	private PerFrameCachedValue<Struct211> perFrameCachedValue_0;

	private PerFrameCachedValue<Struct215> perFrameCachedValue_1;

	internal static HeistContract heistContract_0;

	public int AreaLevel => 0;

	public string ClientName => null;

	public DatBaseItemTypeWrapper HeistTarget => null;

	public Dictionary<string, int> JobsRequires => null;

	public List<string> NpcsRequires => null;

	[SpecialName]
	internal Struct211 method_2()
	{
		return (Struct211)(object)null;
	}

	[SpecialName]
	internal Struct215 method_3()
	{
		return (Struct215)(object)null;
	}

	[CompilerGenerated]
	private Struct211 method_4()
	{
		return (Struct211)(object)null;
	}

	[CompilerGenerated]
	private Struct215 method_5()
	{
		return (Struct215)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static HeistContract smethod_5()
	{
		return null;
	}

	static HeistContract()
	{
		Class200.smethod_34();
	}
}
