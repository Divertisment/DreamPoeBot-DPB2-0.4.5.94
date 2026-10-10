using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Common;
using ns0;

namespace DreamPoeBot.Loki.Elements;

public class PartyHudUIElement : Element
{
	public class PartyInfo
	{
		[CompilerGenerated]
		private Element element_0;

		internal static PartyInfo partyInfo_0;

		public string Name => null;

		public string Zone => null;

		public bool IsInSameZone => true;

		public Vector2i GotoZoneClickPos => (Vector2i)(object)null;

		public Vector2i OpenContextMenuClickPos => (Vector2i)(object)null;

		public PartyInfo(Element ele, PartyHudUIElement hud)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static PartyInfo smethod_1()
		{
			return null;
		}

		static PartyInfo()
		{
			Class200.smethod_34();
		}
	}

	private static PartyHudUIElement partyHudUIElement_0;

	public List<PartyInfo> PartyList => null;

	[SpecialName]
	private Element method_29()
	{
		return null;
	}

	[CompilerGenerated]
	private PartyInfo senjhtpKpj(Element element_2)
	{
		return null;
	}

	internal static bool smethod_11()
	{
		return true;
	}

	internal static PartyHudUIElement smethod_12()
	{
		return null;
	}

	static PartyHudUIElement()
	{
		Class200.smethod_34();
	}
}
