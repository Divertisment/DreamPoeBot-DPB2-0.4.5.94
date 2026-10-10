using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki;

namespace ns0;

internal sealed class Class40 : FileInMemory<Class112>
{
	[StructLayout(LayoutKind.Explicit, Size = 57)]
	internal struct Struct145
	{
		[FieldOffset(8)]
		public int int_0;

		[FieldOffset(12)]
		public int int_1;

		[FieldOffset(16)]
		public long long_0;

		[FieldOffset(32)]
		public int int_2;
	}

	[CompilerGenerated]
	private static readonly Class40 class40_0;

	private static Class40 class40_1;

	internal static Class40 Empty
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	private Class40()
	{
	}

	internal Class40(Memory memory_1, long long_6)
	{
	}

	internal ushort method_3(long long_6, int int_2, int int_3)
	{
		return 0;
	}

	private protected override long vmethod_0(Class112 record)
	{
		return 0L;
	}

	static Class40()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		class40_0 = new Class40();
	}

	[CompilerGenerated]
	private Class112 method_4(Struct145 struct145_0, long long_6, int int_2)
	{
		return null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static Class40 smethod_5()
	{
		return null;
	}
}
