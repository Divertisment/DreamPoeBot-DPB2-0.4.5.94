using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using DreamPoeBot.Loki.Common;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Game.GameData;

public record DatActiveSkillWrapper
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 338)]
	internal struct Struct101
	{
		public long long_0;

		public long long_1;

		public long long_2;

		public long long_3;

		public long long_4;

		public long long_5;

		private long long_6;

		public long long_7;

		private long long_8;

		public long long_9;

		public long long_10;

		public long long_11;

		private byte byte_0;

		public long long_12;

		private byte byte_1;

		public int int_0;

		public byte byte_2;

		private long long_13;

		public long long_14;

		private long long_15;

		public long long_16;

		private long long_17;

		public long long_18;

		internal static object object_0;

		[SpecialName]
		public int method_0()
		{
			return 0;
		}

		[SpecialName]
		public int method_1()
		{
			return 0;
		}

		[SpecialName]
		public int method_2()
		{
			return 0;
		}

		[SpecialName]
		public int rtilZnRvgxe()
		{
			return 0;
		}

		[SpecialName]
		public int method_3()
		{
			return 0;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static object smethod_1()
		{
			return null;
		}

		static Struct101()
		{
			Class200.smethod_34();
		}
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

	public string InternalId
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	public string DisplayName
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	public string InternalName
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	public string BaseInternalName
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	public List<int> CastTypes
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	public List<int> MinionActiveSkillTypes
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	public List<int> SkillTypes
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	public bool SkillTypeRequiresPercentPower
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	public bool SkillTypeRequiresReservedPower
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	public List<DatStatWrapper> SkillStats
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	public List<DatStatWrapper> BaseStats
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		init
		{
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

	private static readonly ILog ilog_0;

	[CompilerGenerated]
	private readonly int int_0;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly string string_1;

	[CompilerGenerated]
	private readonly string string_2;

	[CompilerGenerated]
	private readonly string string_3;

	[CompilerGenerated]
	private readonly string string_4;

	[CompilerGenerated]
	private readonly List<int> list_0;

	[CompilerGenerated]
	private readonly List<int> list_1;

	[CompilerGenerated]
	private readonly List<int> lWvujljvm9;

	[CompilerGenerated]
	private readonly bool bool_0;

	[CompilerGenerated]
	private readonly bool bool_1;

	[CompilerGenerated]
	private readonly List<DatStatWrapper> list_2;

	[CompilerGenerated]
	private readonly List<DatStatWrapper> list_3;

	[CompilerGenerated]
	private readonly long long_0;

	private static DatActiveSkillWrapper datActiveSkillWrapper_0;

	public bool IsCastType(int index)
	{
		return true;
	}

	public bool IsSkillType(int index)
	{
		return true;
	}

	internal DatActiveSkillWrapper(long address, Struct101 s, int index)
	{
	}

	private static List<int> smethod_0(long long_1, int int_1)
	{
		return null;
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
	protected DatActiveSkillWrapper(DatActiveSkillWrapper original)
	{
	}

	static DatActiveSkillWrapper()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_1()
	{
		return true;
	}

	internal static DatActiveSkillWrapper smethod_2()
	{
		return null;
	}
}
