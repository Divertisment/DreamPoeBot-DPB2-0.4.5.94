using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Loki.Game.GameData;

public class DatArchnemesisModWrapper
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ArchnemesisModStruct
	{
		public long intptr_ModsDat;

		private long long_0;

		public int genericRewardCount;

		private int AqFlZxfdyba;

		public long intptr_GenericRewardInfo;

		private int int_0;

		private int int_1;

		private int int_2;

		private int int_3;

		private long long_1;

		private long long_2;

		private byte PbclZmyJtpx;

		private byte byte_0;

		private long long_3;

		private long long_4;

		private long long_5;

		private long long_6;

		private long long_7;

		private long long_8;

		private long long_9;

		private int int_4;
	}

	private Memory memory_0;

	[CompilerGenerated]
	private ArchnemesisModStruct archnemesisModStruct_0;

	[CompilerGenerated]
	private DatModsWrapper datModsWrapper_0;

	[CompilerGenerated]
	private List<string> list_0;

	internal static DatArchnemesisModWrapper datArchnemesisModWrapper_0;

	public DatModsWrapper Mod
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public List<string> RewardTypes
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal ArchnemesisModStruct method_0()
	{
		return (ArchnemesisModStruct)(object)null;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_1(ArchnemesisModStruct archnemesisModStruct_1)
	{
	}

	public DatArchnemesisModWrapper(ArchnemesisModStruct archnemesisModStruct)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static DatArchnemesisModWrapper smethod_1()
	{
		return null;
	}

	static DatArchnemesisModWrapper()
	{
		Class200.smethod_34();
	}
}
