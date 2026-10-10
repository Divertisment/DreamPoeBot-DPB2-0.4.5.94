using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using ns0;

namespace DreamPoeBot.Loki.Game.GameData;

public record DatEndGameMapWrapper
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 241)]
	public struct DatEndGameMapStruct
	{
		[FieldOffset(0)]
		public long WorldAreadDat;

		[FieldOffset(124)]
		public int MinWaystoneTier;
	}

	[CompilerGenerated]
	protected virtual Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public long Address
	{
		[CompilerGenerated]
		get
		{
			return 0L;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	public int Index
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	public DatEndGameMapStruct _datEndGameMapStruct
	{
		[CompilerGenerated]
		get
		{
			return (DatEndGameMapStruct)(object)null;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	public DatWorldAreaWrapper WorldArea => null;

	public short MinWaystoneLevelRequired => 0;

	[CompilerGenerated]
	private readonly long long_0;

	[CompilerGenerated]
	private readonly int int_0;

	[CompilerGenerated]
	private readonly DatEndGameMapStruct datEndGameMapStruct_0;

	private static DatEndGameMapWrapper datEndGameMapWrapper_0;

	public DatEndGameMapWrapper(long address, DatEndGameMapStruct s, int index)
	{
	}

	public override string ToString()
	{
		return null;
	}

	[CompilerGenerated]
	protected virtual bool PrintMembers(StringBuilder builder)
	{
		return true;
	}

	[CompilerGenerated]
	protected DatEndGameMapWrapper(DatEndGameMapWrapper original)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static DatEndGameMapWrapper smethod_1()
	{
		return null;
	}

	static DatEndGameMapWrapper()
	{
		Class200.smethod_34();
	}
}
