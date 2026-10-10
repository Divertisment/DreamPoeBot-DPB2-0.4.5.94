using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Game.GameData;
using ns0;

namespace DreamPoeBot.Loki.FilesInMemory;

public class PassiveSkillsDat : FileInMemory<DatPassiveSkillWrapper>
{
	public Dictionary<int, DatPassiveSkillWrapper> RecordsById;

	public Dictionary<int, DatPassiveSkillWrapper> RecordsByIndex;

	internal Dictionary<string, ushort> dictionary_2;

	private static PassiveSkillsDat passiveSkillsDat_0;

	public PassiveSkillsDat(Memory m, long address, int dataLength = 24, bool parallel = true)
	{
	}

	private protected override long vmethod_0(DatPassiveSkillWrapper record)
	{
		return 0L;
	}

	private protected override void vmethod_1()
	{
	}

	[CompilerGenerated]
	private DatPassiveSkillWrapper method_3(DatPassiveSkillWrapper.Struct121 struct121_0, long long_6, int int_2)
	{
		return null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static PassiveSkillsDat smethod_5()
	{
		return null;
	}

	static PassiveSkillsDat()
	{
		Class200.smethod_34();
	}
}
