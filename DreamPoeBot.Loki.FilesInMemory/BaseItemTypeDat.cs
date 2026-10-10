using System.Collections.Generic;
using DreamPoeBot.Loki.Game.GameData;
using ns0;

namespace DreamPoeBot.Loki.FilesInMemory;

public class BaseItemTypeDat : FileInMemory<DatBaseItemTypeWrapper>
{
	public Dictionary<uint, DatBaseItemTypeWrapper> RecordsByHash;

	public Dictionary<string, DatBaseItemTypeWrapper> RecordsByMetadata;

	public Dictionary<string, DatBaseItemTypeWrapper> RecordsByName;

	public Dictionary<int, uint> RecordRidToHash;

	private static BaseItemTypeDat baseItemTypeDat_0;

	internal BaseItemTypeDat(Memory m, long address, int dataLength = 24, bool parallel = true)
	{
	}

	public DatBaseItemTypeWrapper Translate(string metadata)
	{
		return null;
	}

	private protected override long vmethod_0(DatBaseItemTypeWrapper record)
	{
		return 0L;
	}

	private protected override void vmethod_1()
	{
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static BaseItemTypeDat smethod_5()
	{
		return null;
	}

	static BaseItemTypeDat()
	{
		Class200.smethod_34();
	}
}
