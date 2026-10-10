using System.Collections.Generic;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Models;
using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

public class AreaTransition : NetworkObject
{
	private static AreaTransition areaTransition_0;

	public DatWorldAreaWrapper Destination => null;

	public TransitionTypes TransitionType => (TransitionTypes)(object)null;

	public Rarity Rarity => (Rarity)(object)null;

	public IEnumerable<DatModsWrapper> Affixes => null;

	public IEnumerable<DatModsWrapper> ImplicitAffixes => null;

	public IEnumerable<DatModsWrapper> ExplicitAffixes => null;

	public IEnumerable<StatContainer> ExplicitStats => null;

	public IEnumerable<StatContainer> ImplicitStats => null;

	internal AreaTransition(EntityWrapper entry)
	{
	}

	internal static bool smethod_24()
	{
		return true;
	}

	internal static AreaTransition smethod_25()
	{
		return null;
	}

	static AreaTransition()
	{
		Class200.smethod_34();
	}
}
