using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ns0;

namespace DreamPoeBot.Loki.Game.GameData;

public class PantheonGodsWrapper
{
	[CompilerGenerated]
	private readonly PantheonGod pantheonGod_0;

	[CompilerGenerated]
	private readonly bool bool_0;

	[CompilerGenerated]
	private readonly List<PantheonSouls> list_0;

	public PantheonGod Name
	{
		[CompilerGenerated]
		get
		{
			return (PantheonGod)(object)null;
		}
	}

	public bool IsUnlocked
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
	}

	public List<PantheonSouls> Souls
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public PantheonGodsWrapper(PantheonGod name, bool isUnlocked, List<PantheonSouls> souls)
	{
	}

	static PantheonGodsWrapper()
	{
		Class200.smethod_34();
	}
}
