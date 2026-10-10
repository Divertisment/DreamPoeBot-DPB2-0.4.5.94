using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Game.GameData;
using ns0;

namespace DreamPoeBot.Loki.FilesInMemory;

public class StatsDat : FileInMemory<DatStatWrapper>
{
	public Dictionary<string, DatStatWrapper> RecordsById;

	public Dictionary<uint, DatStatWrapper> RecordsByHash32;

	internal static StatsDat statsDat_0;

	public StatsDat(Memory m, long address, int dataLength = 24, bool parallel = true)
	{
	}

	private protected override long vmethod_0(DatStatWrapper record)
	{
		return 0L;
	}

	private protected override void vmethod_1()
	{
	}

	[CompilerGenerated]
	private DatStatWrapper method_3(DatStatWrapper.Struct125 struct125_0, long long_6, int int_2)
	{
		return null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static StatsDat smethod_5()
	{
		return null;
	}

	static StatsDat()
	{
		Class200.smethod_34();
	}
}
