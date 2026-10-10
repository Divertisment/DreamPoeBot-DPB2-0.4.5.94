using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Game.GameData;
using ns0;

namespace DreamPoeBot.Loki.FilesInMemory;

public class RitualAtlaslineModsDat : FileInMemory<DatRitualAtlaslineModsWrapper>
{
	internal static RitualAtlaslineModsDat ritualAtlaslineModsDat_0;

	internal RitualAtlaslineModsDat(Memory m, long address, int dataLength = 24, bool parallel = true)
	{
	}

	private protected override long vmethod_0(DatRitualAtlaslineModsWrapper record)
	{
		return 0L;
	}

	[CompilerGenerated]
	internal static DatRitualAtlaslineModsWrapper smethod_4(DatRitualAtlaslineModsWrapper.Struct122 struct122_0, long long_6, int int_2)
	{
		return null;
	}

	internal static bool smethod_5()
	{
		return true;
	}

	internal static RitualAtlaslineModsDat smethod_6()
	{
		return null;
	}

	static RitualAtlaslineModsDat()
	{
		Class200.smethod_34();
	}
}
