using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Loki.RemoteMemoryObjects;

public class Map : RemoteMemoryObject
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct43
	{
		public long long_0;

		public long long_1;

		public long long_2;

		public long long_3;

		public long long_4;

		public long long_5;

		public long long_6;

		public long long_7;

		public int int_0;

		public int int_1;

		public long long_8;

		public long long_9;

		public long long_10;

		public long long_11;

		public long long_12;

		public int int_2;

		public int int_3;

		public int int_4;

		public int int_5;

		public int int_6;

		public int int_7;

		public long long_13;

		public long long_14;

		public int int_8;

		public byte byte_0;

		public byte byte_1;
	}

	private string string_0;

	private string string_1;

	private string string_2;

	private string string_3;

	private int int_0;

	internal static Map map_0;

	public string Name => null;

	public string NameUnique => null;

	public string Metadata => null;

	public string MetadataUnique => null;

	public int Series => 0;

	private void method_0()
	{
	}

	public override string ToString()
	{
		return null;
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static Map smethod_3()
	{
		return null;
	}

	static Map()
	{
		Class200.smethod_34();
	}
}
