using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Game.GameData;
using ns0;

namespace DreamPoeBot.Loki.FilesInMemory;

public class WorldAreaDat : FileInMemory<DatWorldAreaWrapper>
{
	[CompilerGenerated]
	private static readonly WorldAreaDat worldAreaDat_0;

	[CompilerGenerated]
	private Dictionary<ushort, DatWorldAreaWrapper> dictionary_2;

	[CompilerGenerated]
	private Dictionary<string, DatWorldAreaWrapper> dictionary_3;

	[CompilerGenerated]
	private Dictionary<long, ushort> dictionary_4;

	private static WorldAreaDat worldAreaDat_1;

	public static WorldAreaDat Empty
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public Dictionary<ushort, DatWorldAreaWrapper> RecordsById
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public Dictionary<string, DatWorldAreaWrapper> RecordsByStrId
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public Dictionary<long, ushort> RecordsAddressToWorldAreaId
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	private WorldAreaDat()
	{
	}

	public WorldAreaDat(Memory m, long address, int dataLength = 24, bool parallel = true)
	{
	}

	private protected override long vmethod_0(DatWorldAreaWrapper record)
	{
		return 0L;
	}

	private protected override void vmethod_1()
	{
	}

	static WorldAreaDat()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		worldAreaDat_0 = new WorldAreaDat();
	}

	[CompilerGenerated]
	private DatWorldAreaWrapper method_3(DatWorldAreaWrapper.Struct132 struct132_0, long long_6, int int_2)
	{
		return null;
	}

	[CompilerGenerated]
	private long[] method_4(long long_6, int int_2, int int_3, string string_1)
	{
		return null;
	}

	[CompilerGenerated]
	private long[] method_5(long long_6, int int_2, int int_3, string string_1)
	{
		return null;
	}

	[CompilerGenerated]
	private void method_6(long long_6, int int_2, int int_3, string string_1)
	{
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static WorldAreaDat smethod_5()
	{
		return null;
	}
}
