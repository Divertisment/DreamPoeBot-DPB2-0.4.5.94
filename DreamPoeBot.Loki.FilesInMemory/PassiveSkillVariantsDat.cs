using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Game.GameData;
using ns0;

namespace DreamPoeBot.Loki.FilesInMemory;

public class PassiveSkillVariantsDat : FileInMemory<DatPassiveSkillVariantsWrapper>
{
	public Dictionary<ushort, List<ushort>> DictFromIdtoListIds;

	internal static PassiveSkillVariantsDat passiveSkillVariantsDat_0;

	public PassiveSkillVariantsDat(Memory m, long address, int dataLength = 40, bool parallel = true)
	{
	}

	private protected override long vmethod_0(DatPassiveSkillVariantsWrapper record)
	{
		return 0L;
	}

	private protected override void vmethod_1()
	{
	}

	[CompilerGenerated]
	internal static DatPassiveSkillVariantsWrapper smethod_4(DatPassiveSkillVariantsWrapper.Struct120 struct120_0, long long_6, int int_2)
	{
		return null;
	}

	internal static bool smethod_5()
	{
		return true;
	}

	internal static PassiveSkillVariantsDat smethod_6()
	{
		return null;
	}

	static PassiveSkillVariantsDat()
	{
		Class200.smethod_34();
	}
}
