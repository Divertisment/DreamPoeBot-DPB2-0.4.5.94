using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Game.GameData;
using ns0;

namespace DreamPoeBot.Loki.FilesInMemory;

public class ModsDat : FileInMemory<DatModsWrapper>
{
	[CompilerGenerated]
	private static readonly ModsDat modsDat_0;

	[CompilerGenerated]
	private Dictionary<ModTierKey, List<DatModsWrapper>> dictionary_2;

	[CompilerGenerated]
	private Dictionary<string, DatModsWrapper> dictionary_3;

	private static ModsDat modsDat_1;

	public static ModsDat Empty
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public Dictionary<ModTierKey, List<DatModsWrapper>> RecordsByTier
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

	public Dictionary<string, DatModsWrapper> RecordsByInternalName
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

	public ModsDat()
	{
	}

	internal ModsDat(Memory m, long address, int dataLength = 24, bool parallel = true)
	{
	}

	private protected override long vmethod_0(DatModsWrapper record)
	{
		return 0L;
	}

	private protected override void vmethod_1()
	{
	}

	static ModsDat()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		modsDat_0 = new ModsDat();
	}

	[CompilerGenerated]
	private string method_3(long long_6, int int_2, int int_3)
	{
		return null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static ModsDat smethod_5()
	{
		return null;
	}
}
