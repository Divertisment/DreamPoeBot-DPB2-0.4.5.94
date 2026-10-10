using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using ns0;

namespace DreamPoeBot.Loki.Game.GameData;

public record DatPassiveSkillWrapper
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 487)]
	internal struct Struct121
	{
		[FieldOffset(0)]
		public long long_0;

		[FieldOffset(8)]
		public long long_1;

		[FieldOffset(16)]
		private long long_2;

		[FieldOffset(24)]
		public long long_3;

		[FieldOffset(32)]
		public int int_0;

		[FieldOffset(36)]
		public int int_1;

		[FieldOffset(40)]
		public int int_2;

		[FieldOffset(44)]
		public int int_3;

		[FieldOffset(48)]
		public ushort ushort_0;

		[FieldOffset(50)]
		public long long_4;

		[FieldOffset(74)]
		public bool bool_0;

		[FieldOffset(75)]
		public bool bool_1;

		[FieldOffset(118)]
		public bool bool_2;

		[FieldOffset(172)]
		public long long_5;

		[FieldOffset(435)]
		public long long_6;

		private static object object_0;

		[SpecialName]
		public int method_0()
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

		static Struct121()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 343)]
	public struct PassiveSkillDatStruct
	{
		[FieldOffset(0)]
		public long intptr_0Id;

		[FieldOffset(16)]
		public int int_0StatListCount;

		[FieldOffset(24)]
		public long intptr_2StatListAddress;

		[FieldOffset(32)]
		public int int_1Stat1Value;

		[FieldOffset(36)]
		public int int_2Stat2Value;

		[FieldOffset(40)]
		public int int_3Stat3Value;

		[FieldOffset(44)]
		public int int_4Stat1Value;

		[FieldOffset(48)]
		public ushort ushort_5PassiveId;

		[FieldOffset(50)]
		public long intptr_3Name;

		[FieldOffset(118)]
		public int int_IsAcendance;

		[FieldOffset(172)]
		public long PassiveSkillMasteryGroupData;

		[FieldOffset(387)]
		public long PassiveSkillVariationData;
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

	public string Id
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

	public string Name
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

	public ushort PassiveId
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

	public ushort PassiveSkillGraphId
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

	public DatPassiveSkillMasteryGroupWrapper PassiveSkillMasteryGroup
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

	public List<ushort> PassiveSkillVariants => null;

	public List<KeyValuePair<DatStatWrapper, int>> Stats
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

	[CompilerGenerated]
	private readonly long long_0;

	[CompilerGenerated]
	private readonly int int_0;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly string string_1;

	[CompilerGenerated]
	private readonly ushort ushort_0;

	[CompilerGenerated]
	private readonly ushort ushort_1;

	[CompilerGenerated]
	private readonly DatPassiveSkillMasteryGroupWrapper akOawpmkUP;

	[CompilerGenerated]
	private readonly List<KeyValuePair<DatStatWrapper, int>> list_0;

	private static DatPassiveSkillWrapper datPassiveSkillWrapper_0;

	[SpecialName]
	internal Memory method_0()
	{
		return null;
	}

	internal DatPassiveSkillWrapper()
	{
	}

	[CompilerGenerated]
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
	protected DatPassiveSkillWrapper(DatPassiveSkillWrapper original)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static DatPassiveSkillWrapper smethod_1()
	{
		return null;
	}

	static DatPassiveSkillWrapper()
	{
		Class200.smethod_34();
	}
}
