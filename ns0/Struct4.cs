namespace ns0;

internal struct Struct4
{
	private static readonly uint[] uint_0;

	private uint uint_1;

	private static object object_0;

	static Struct4()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		uint_0 = new uint[512];
		for (int num = 8; num >= 0; num--)
		{
			int num2 = 1 << 9 - num - 1;
			uint num3 = (uint)(1 << 9 - num);
			for (uint num4 = (uint)num2; num4 < num3; num4++)
			{
				uint_0[num4] = (uint)(num << 6) + (num3 - num4 << 6 >> 9 - num - 1);
			}
		}
	}

	public void method_0()
	{
	}

	public void method_1(uint uint_2)
	{
	}

	public void method_2(Class1 class1_0, uint uint_2)
	{
	}

	public uint method_3(uint uint_2)
	{
		return 0u;
	}

	public uint method_4()
	{
		return 0u;
	}

	public uint method_5()
	{
		return 0u;
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static object smethod_1()
	{
		return null;
	}
}
