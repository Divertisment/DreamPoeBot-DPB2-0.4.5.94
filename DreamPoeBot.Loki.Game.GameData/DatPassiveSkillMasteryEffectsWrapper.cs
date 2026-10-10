using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Loki.Game.GameData;

public class DatPassiveSkillMasteryEffectsWrapper
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct PassiveSkillMasteryEffectsStructure
	{
		public long Id;

		public int MasteryId;

		public int StatsCount;

		private int int_0;

		public long Stats;

		public int Stat1;

		public int Stat2;

		public int Stat3;

		private long long_0;

		private long fXolYgceuyL;
	}

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	private List<KeyValuePair<DatStatWrapper, int>> list_0;

	[CompilerGenerated]
	private int int_2;

	[CompilerGenerated]
	private int fUpcvxpLx3;

	[CompilerGenerated]
	private int int_3;

	internal static DatPassiveSkillMasteryEffectsWrapper datPassiveSkillMasteryEffectsWrapper_0;

	public string Id
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

	public int PassiveSkillMasteryId
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int StatsCount
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public List<KeyValuePair<DatStatWrapper, int>> Stats
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

	public int Stat1
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int Stat2
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int Stat3
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public DatPassiveSkillMasteryEffectsWrapper(long adr)
	{
	}

	public DatPassiveSkillMasteryEffectsWrapper(PassiveSkillMasteryEffectsStructure str)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static DatPassiveSkillMasteryEffectsWrapper smethod_1()
	{
		return null;
	}

	static DatPassiveSkillMasteryEffectsWrapper()
	{
		Class200.smethod_34();
	}
}
