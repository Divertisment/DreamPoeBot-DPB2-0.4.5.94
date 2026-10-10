using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ns0;

namespace DreamPoeBot.Loki.FilesInMemory;

public class GroundEffectsDat : FileInMemory<DatGroundEffectWrapper>
{
	public Dictionary<string, DatGroundEffectWrapper> RecordsByAOFile;

	private static GroundEffectsDat groundEffectsDat_0;

	public GroundEffectsDat(Memory m, long address, int datalen = 32)
	{
	}

	private protected override long vmethod_0(DatGroundEffectWrapper record)
	{
		return 0L;
	}

	private protected override void vmethod_1()
	{
	}

	[CompilerGenerated]
	private DatGroundEffectWrapper method_3(DatGroundEffectWrapper.Struct149 struct149_0, long long_6, int int_2)
	{
		return null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static GroundEffectsDat smethod_5()
	{
		return null;
	}

	static GroundEffectsDat()
	{
		Class200.smethod_34();
	}
}
