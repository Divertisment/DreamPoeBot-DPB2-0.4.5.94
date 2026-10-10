using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ns0;

namespace DreamPoeBot.Loki.FilesInMemory;

public class MiscAnimatedDat : FileInMemory<DatMiscAnimatedWrapper>
{
	public Dictionary<string, DatMiscAnimatedWrapper> RecordsByAOFile;

	internal static MiscAnimatedDat miscAnimatedDat_0;

	public MiscAnimatedDat(Memory m, long address)
	{
	}

	private protected override long vmethod_0(DatMiscAnimatedWrapper record)
	{
		return 0L;
	}

	private protected override void vmethod_1()
	{
	}

	[CompilerGenerated]
	private DatMiscAnimatedWrapper method_3(DatMiscAnimatedWrapper.Struct150 struct150_0, long long_6, int int_2)
	{
		return null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static MiscAnimatedDat smethod_5()
	{
		return null;
	}

	static MiscAnimatedDat()
	{
		Class200.smethod_34();
	}
}
