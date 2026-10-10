using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ns0;

namespace DreamPoeBot.Loki.FilesInMemory;

public class TagsDat : FileInMemory<DatTagWrapper>
{
	public Dictionary<string, DatTagWrapper> RecordsByKey;

	internal static TagsDat tagsDat_0;

	public TagsDat(Memory m, long address, int dataLength = 24, bool parallel = true)
	{
	}

	private protected override long vmethod_0(DatTagWrapper record)
	{
		return 0L;
	}

	private protected override void vmethod_1()
	{
	}

	[CompilerGenerated]
	internal static DatTagWrapper smethod_4(DatTagWrapper.Struct153 struct153_0, long long_6, int int_2)
	{
		return null;
	}

	internal static bool smethod_5()
	{
		return true;
	}

	internal static TagsDat smethod_6()
	{
		return null;
	}

	static TagsDat()
	{
		Class200.smethod_34();
	}
}
