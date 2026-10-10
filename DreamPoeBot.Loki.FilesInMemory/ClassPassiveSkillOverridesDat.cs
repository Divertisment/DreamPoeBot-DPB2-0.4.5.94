using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Game.GameData;
using ns0;

namespace DreamPoeBot.Loki.FilesInMemory;

public class ClassPassiveSkillOverridesDat : FileInMemory<DatClassPassiveSkillOverridesWrapper>
{
	public Dictionary<CharacterClass, Dictionary<int, int>> RecordsByCharacterClass;

	private static ClassPassiveSkillOverridesDat classPassiveSkillOverridesDat_0;

	public ClassPassiveSkillOverridesDat(Memory m, long address, int dataLength = 40, bool parallel = true)
	{
	}

	private protected override long vmethod_0(DatClassPassiveSkillOverridesWrapper record)
	{
		return 0L;
	}

	private protected override void vmethod_1()
	{
	}

	[CompilerGenerated]
	internal static DatClassPassiveSkillOverridesWrapper smethod_4(DatClassPassiveSkillOverridesWrapper.DatClassPassiveSkillOverridesWrapperStruct datClassPassiveSkillOverridesWrapperStruct_0, long long_6, int int_2)
	{
		return null;
	}

	internal static bool smethod_5()
	{
		return true;
	}

	internal static ClassPassiveSkillOverridesDat smethod_6()
	{
		return null;
	}

	static ClassPassiveSkillOverridesDat()
	{
		Class200.smethod_34();
	}
}
