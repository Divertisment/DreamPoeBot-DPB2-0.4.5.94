using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Game.GameData;
using ns0;

namespace DreamPoeBot.Loki.FilesInMemory;

public class ClientStringsDat : FileInMemory<DatClientStringWrapper>
{
	public Dictionary<uint, DatClientStringWrapper> RecordsByHash;

	[CompilerGenerated]
	private Dictionary<ClientStringsEnum, DatClientStringWrapper> dictionary_2;

	private static ClientStringsDat clientStringsDat_0;

	[Obsolete]
	public Dictionary<ClientStringsEnum, DatClientStringWrapper> ContentByClientStringEnum
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		internal set
		{
		}
	}

	public ClientStringsDat(Memory m, long address, int dataLength = 24, bool parallel = true)
	{
	}

	private protected override long vmethod_0(DatClientStringWrapper record)
	{
		return 0L;
	}

	private protected override void vmethod_1()
	{
	}

	[CompilerGenerated]
	private DatClientStringWrapper method_3(DatClientStringWrapper.Struct106 struct106_0, long long_6, int int_2)
	{
		return null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static ClientStringsDat smethod_5()
	{
		return null;
	}

	static ClientStringsDat()
	{
		Class200.smethod_34();
	}
}
