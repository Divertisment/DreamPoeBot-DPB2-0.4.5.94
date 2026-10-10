using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Game.GameData;
using ns0;

namespace DreamPoeBot.Loki.FilesInMemory;

public class MinimapIconsDat : FileInMemory<DatMinimapIconWrapper>
{
	public Dictionary<string, DatMinimapIconWrapper> RecordsByName;

	internal static MinimapIconsDat minimapIconsDat_0;

	public MinimapIconsDat(Memory m, long address, int dataLength = 24, bool parallel = true)
	{
	}

	private protected override long vmethod_0(DatMinimapIconWrapper record)
	{
		return 0L;
	}

	private protected override void vmethod_1()
	{
	}

	[CompilerGenerated]
	private DatMinimapIconWrapper method_3(DatMinimapIconWrapper.Struct118 struct118_0, long long_6, int int_2)
	{
		return null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static MinimapIconsDat smethod_5()
	{
		return null;
	}

	static MinimapIconsDat()
	{
		Class200.smethod_34();
	}
}
