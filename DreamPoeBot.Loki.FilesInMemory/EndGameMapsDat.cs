using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Game.GameData;
using ns0;

namespace DreamPoeBot.Loki.FilesInMemory;

public class EndGameMapsDat : FileInMemory<DatEndGameMapWrapper>
{
	internal static EndGameMapsDat endGameMapsDat_0;

	public EndGameMapsDat(Memory m, long address, int dataLength = 24, bool parallel = true)
	{
	}

	private protected override long vmethod_0(DatEndGameMapWrapper record)
	{
		return 0L;
	}

	[CompilerGenerated]
	internal static DatEndGameMapWrapper smethod_4(DatEndGameMapWrapper.DatEndGameMapStruct datEndGameMapStruct_0, long long_6, int int_2)
	{
		return null;
	}

	internal static bool smethod_5()
	{
		return true;
	}

	internal static EndGameMapsDat smethod_6()
	{
		return null;
	}

	static EndGameMapsDat()
	{
		Class200.smethod_34();
	}
}
