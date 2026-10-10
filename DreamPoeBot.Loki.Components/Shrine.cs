using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class Shrine : Component
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct247
	{
		public Struct14 struct14_0;

		public byte byte_0;

		public byte byte_1;

		public byte byte_2;

		public byte byte_3;

		public int int_0;

		public long long_0;

		public int int_1;

		public byte byte_4;

		public byte byte_5;

		public byte byte_6;

		public byte byte_7;

		public long long_1;

		public long long_2;

		public long long_3;

		public long long_4;

		public long long_5;

		public Struct9 struct9_0;

		public long long_6;

		public long long_7;

		public long long_8;

		public long long_9;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct248
	{
		public long long_0;

		public int int_0;

		public long long_1;

		public byte deWpMwsRjco;

		public long long_2;

		public long long_3;

		public int int_1;

		public int int_2;

		public long long_4;

		public long long_5;

		public long long_6;

		public int int_3;

		public int int_4;

		public int int_5;

		public int int_6;

		public int wLwpMyPkfju;

		public int int_7;

		public long long_7;

		public long long_8;

		public byte byte_0;

		public int int_8;

		public long long_9;

		public byte byte_1;

		public byte byte_2;

		public byte byte_3;
	}

	private PerFrameCachedValue<Struct247> perFrameCachedValue_0;

	private PerFrameCachedValue<Struct248> perFrameCachedValue_1;

	private static Shrine shrine_0;

	public bool IsDeactivated => true;

	public string ShrineId => null;

	public string ShrineName => null;

	public string ShrineDescription => null;

	[SpecialName]
	private int method_2()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	internal Struct247 method_3()
	{
		return (Struct247)(object)null;
	}

	private Struct247 method_4()
	{
		return (Struct247)(object)null;
	}

	[SpecialName]
	internal Struct248 method_5()
	{
		return (Struct248)(object)null;
	}

	private Struct248 method_6()
	{
		return (Struct248)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static Shrine smethod_5()
	{
		return null;
	}

	static Shrine()
	{
		Class200.smethod_34();
	}
}
