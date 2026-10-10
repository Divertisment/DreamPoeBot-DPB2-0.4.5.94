using System;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Game.GameData;
using ns0;

namespace DreamPoeBot.Loki.Game;

public class PassiveDumpEventArgs : EventArgs
{
	[CompilerGenerated]
	private DatPassiveSkillWrapper datPassiveSkillWrapper_0;

	private static PassiveDumpEventArgs passiveDumpEventArgs_0;

	public DatPassiveSkillWrapper PassiveSkill
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

	internal PassiveDumpEventArgs(DatPassiveSkillWrapper passiveSkill)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static PassiveDumpEventArgs smethod_1()
	{
		return null;
	}

	static PassiveDumpEventArgs()
	{
		Class200.smethod_34();
	}
}
