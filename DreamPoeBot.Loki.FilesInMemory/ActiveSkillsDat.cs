using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Game.GameData;
using ns0;

namespace DreamPoeBot.Loki.FilesInMemory;

public class ActiveSkillsDat : FileInMemory<DatActiveSkillWrapper>
{
	private static ActiveSkillsDat activeSkillsDat_0;

	public ActiveSkillsDat(Memory m, long address, int dataLength = 24, bool parallel = true)
	{
	}

	private protected override long vmethod_0(DatActiveSkillWrapper record)
	{
		return 0L;
	}

	[CompilerGenerated]
	internal static DatActiveSkillWrapper smethod_4(DatActiveSkillWrapper.Struct101 struct101_0, long long_6, int int_2)
	{
		return null;
	}

	internal static bool smethod_5()
	{
		return true;
	}

	internal static ActiveSkillsDat smethod_6()
	{
		return null;
	}

	static ActiveSkillsDat()
	{
		Class200.smethod_34();
	}
}
