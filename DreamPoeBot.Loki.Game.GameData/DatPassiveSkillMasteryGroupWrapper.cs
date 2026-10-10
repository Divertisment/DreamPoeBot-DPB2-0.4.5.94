using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Loki.Game.GameData;

public class DatPassiveSkillMasteryGroupWrapper
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct PassiveSkillMasteryGroupStructure
	{
		public long Id;

		public int PassiveSkillMasteryCount;

		private int int_0;

		public long PassiveSkillMasteryEffects;
	}

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private List<DatPassiveSkillMasteryEffectsWrapper> list_0;

	private static DatPassiveSkillMasteryGroupWrapper datPassiveSkillMasteryGroupWrapper_0;

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

	public int MasterEffectsCount
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

	public List<DatPassiveSkillMasteryEffectsWrapper> PassiveSkillMasteryEffects
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

	public DatPassiveSkillMasteryGroupWrapper(long adr)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static DatPassiveSkillMasteryGroupWrapper smethod_1()
	{
		return null;
	}

	static DatPassiveSkillMasteryGroupWrapper()
	{
		Class200.smethod_34();
	}
}
