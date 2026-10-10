using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Elements;

public class SocialPanelElement : Element
{
	public class PartyOption
	{
		private Element element_0;

		[CompilerGenerated]
		private string string_0;

		internal static PartyOption partyOption_0;

		public string Name
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

		public Element comboboxOpenButton => null;

		public GenericComboBoxElement Combobox => null;

		public PartyOption(Element element)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static PartyOption smethod_1()
		{
			return null;
		}

		static PartyOption()
		{
			Class200.smethod_34();
		}
	}

	public class SocialPannelGroupInvitation : Element
	{
		private readonly Element element_2;

		internal static SocialPannelGroupInvitation socialPannelGroupInvitation_0;

		public Element AcceptButton => null;

		public Element DeclineButton => null;

		public string AccountName => null;

		public string CharName => null;

		public string CharCurrentZone => null;

		public override string ToString()
		{
			return null;
		}

		public SocialPannelGroupInvitation(Element mainElement)
		{
		}

		internal static bool smethod_11()
		{
			return true;
		}

		internal static SocialPannelGroupInvitation smethod_12()
		{
			return null;
		}

		static SocialPannelGroupInvitation()
		{
			Class200.smethod_34();
		}
	}

	private PerAreaCachedValue<Element> perAreaCachedValue_0;

	internal static SocialPanelElement socialPanelElement_0;

	public Element MainControl => null;

	public bool IsOpened => true;

	public List<SocialPannelGroupInvitation> AllGroupInviteElements => null;

	public byte VisibleTabIndex => 0;

	public string VisibleTabName => null;

	public List<PartyOption> PartyOptions => null;

	private Element GetMainControl()
	{
		return null;
	}

	[SpecialName]
	private List<Element> method_29()
	{
		return null;
	}

	[SpecialName]
	internal List<string> method_30()
	{
		return null;
	}

	internal Element method_31(string string_0)
	{
		return null;
	}

	private List<Element> method_32()
	{
		return null;
	}

	private Element method_33()
	{
		return null;
	}

	private Element method_34(string string_0)
	{
		return null;
	}

	private Element method_35(string string_0)
	{
		return null;
	}

	[SpecialName]
	internal Element method_36()
	{
		return null;
	}

	[SpecialName]
	internal Element method_37()
	{
		return null;
	}

	[SpecialName]
	internal Element method_38()
	{
		return null;
	}

	internal static bool smethod_11()
	{
		return true;
	}

	internal static SocialPanelElement smethod_12()
	{
		return null;
	}

	static SocialPanelElement()
	{
		Class200.smethod_34();
	}
}
