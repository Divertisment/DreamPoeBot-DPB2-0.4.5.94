using System;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Game.GameData;
using ns0;

namespace DreamPoeBot.Loki.Game;

public class PassiveMasteryDumpEventArgs : EventArgs
{
	[CompilerGenerated]
	private DatPassiveSkillMasteryWrapper datPassiveSkillMasteryWrapper_0;

	private static PassiveMasteryDumpEventArgs passiveMasteryDumpEventArgs_0;

	public DatPassiveSkillMasteryWrapper PassiveSkill
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

	internal PassiveMasteryDumpEventArgs(DatPassiveSkillMasteryWrapper passiveSkill)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static PassiveMasteryDumpEventArgs smethod_1()
	{
		return null;
	}

	static PassiveMasteryDumpEventArgs()
	{
		Class200.smethod_34();
	}
}
