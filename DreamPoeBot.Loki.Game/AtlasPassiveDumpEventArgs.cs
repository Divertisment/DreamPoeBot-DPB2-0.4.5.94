using System;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Game.GameData;
using ns0;

namespace DreamPoeBot.Loki.Game;

public class AtlasPassiveDumpEventArgs : EventArgs
{
	[CompilerGenerated]
	private DatPassiveSkillWrapper datPassiveSkillWrapper_0;

	private static AtlasPassiveDumpEventArgs atlasPassiveDumpEventArgs_0;

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

	internal AtlasPassiveDumpEventArgs(DatPassiveSkillWrapper passiveSkill)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static AtlasPassiveDumpEventArgs smethod_1()
	{
		return null;
	}

	static AtlasPassiveDumpEventArgs()
	{
		Class200.smethod_34();
	}
}
