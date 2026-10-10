using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Elements;

public class PassiveTreeElement : Element
{
	public class AscendencyUi
	{
		internal static AscendencyUi ascendencyUi_0;

		public bool IsOpened => true;

		public bool IsUnlocked => true;

		[SpecialName]
		internal long method_0()
		{
			return 0L;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static AscendencyUi smethod_1()
		{
			return null;
		}

		static AscendencyUi()
		{
			Class200.smethod_34();
		}
	}

	public class AttributeSelectionUiElemet : Element
	{
		internal static AttributeSelectionUiElemet attributeSelectionUiElemet_0;

		public Element StrElement => null;

		public Element DexElement => null;

		public Element IntElement => null;

		internal static bool smethod_11()
		{
			return true;
		}

		internal static AttributeSelectionUiElemet smethod_12()
		{
			return null;
		}

		static AttributeSelectionUiElemet()
		{
			Class200.smethod_34();
		}
	}

	private static PerAreaCachedValue<Dictionary<int, long>> perAreaCachedValue_0;

	private static PerAreaCachedValue<Dictionary<int, long>> perAreaCachedValue_1;

	internal static int int_3;

	internal static int int_4;

	internal static int int_5;

	private static PerAreaCachedValue<Dictionary<DatPassiveSkillWrapper, Element>> perAreaCachedValue_2;

	private static PassiveTreeElement passiveTreeElement_0;

	public Element SkillsPassiveMap => null;

	public Element ConfirnCancelElement => null;

	public Element ApplyButtonElement => null;

	public Element CancelButtonElement => null;

	public Element ResetAllPassivesElement => null;

	public bool IsResetAllPassiveEnabled => true;

	public Element TitleElement => null;

	public long IntPtr_3_AscendUi => 0L;

	public Dictionary<int, long> Dictionary_Passive => null;

	public bool IsMaxZoomIn => true;

	public bool IsMaxZoomOut => true;

	public bool IsApplyEnabled => true;

	public bool IsApplyVisible => true;

	public bool IsCancelEnabled => true;

	public bool IsCancelVisible => true;

	public bool IsRefundPassivesEnabled => true;

	public Dictionary<DatPassiveSkillWrapper, Element> PasDict => null;

	[SpecialName]
	internal long method_29()
	{
		return 0L;
	}

	[SpecialName]
	internal AttributeSelectionUiElemet uYsJwaypyN()
	{
		return null;
	}

	private Dictionary<int, long> method_30(long long_5)
	{
		return null;
	}

	[SpecialName]
	internal Dictionary<int, long> method_31()
	{
		return null;
	}

	[SpecialName]
	private float method_32()
	{
		return 0f;
	}

	public Vector2i ClickLocationFor(long intPtr)
	{
		return (Vector2i)(object)null;
	}

	public Element GetElementAt(long intPtr)
	{
		return null;
	}

	static PassiveTreeElement()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		perAreaCachedValue_0 = null;
		perAreaCachedValue_1 = null;
		int_3 = 1608;
		int_4 = 1616;
		int_5 = 1612;
	}

	[CompilerGenerated]
	private Dictionary<int, long> method_33()
	{
		return null;
	}

	[CompilerGenerated]
	private Dictionary<int, long> method_34()
	{
		return null;
	}

	internal static bool smethod_11()
	{
		return true;
	}

	internal static PassiveTreeElement smethod_12()
	{
		return null;
	}
}
