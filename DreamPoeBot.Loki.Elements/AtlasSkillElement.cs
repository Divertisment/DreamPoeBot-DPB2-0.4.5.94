using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Elements;

public class AtlasSkillElement : Element
{
	public class MasteryUiElemet : Element
	{
		internal static MasteryUiElemet masteryUiElemet_0;

		public string Title => null;

		public string Body => null;

		public List<AtlasMasteryOption> Options => null;

		internal static bool smethod_11()
		{
			return true;
		}

		internal static MasteryUiElemet smethod_12()
		{
			return null;
		}

		static MasteryUiElemet()
		{
			Class200.smethod_34();
		}
	}

	public class AtlasMasteryOption : Element
	{
		internal static AtlasMasteryOption atlasMasteryOption_0;

		public DatPassiveSkillWrapper PassiveSkills => null;

		internal static bool smethod_11()
		{
			return true;
		}

		internal static AtlasMasteryOption smethod_12()
		{
			return null;
		}

		static AtlasMasteryOption()
		{
			Class200.smethod_34();
		}
	}

	private PerAreaCachedValue<Dictionary<int, long>> perAreaCachedValue_0;

	private PerAreaCachedValue<Dictionary<DatPassiveSkillWrapper, Element>> perAreaCachedValue_1;

	internal static AtlasSkillElement atlasSkillElement_0;

	public Element ApplyButton => null;

	public Element CancelButton => null;

	public Element AtlasPassiveMap => null;

	public MasteryUiElemet MasteryUi => null;

	public bool IsApplyEnabled => true;

	public bool IsApplyVisible => true;

	public bool IsCancelEnabled => true;

	public bool IsCancelVisible => true;

	public Dictionary<int, long> Dictionary_0AtlasPassive => null;

	public Dictionary<DatPassiveSkillWrapper, Element> PasDict => null;

	public Vector2i ClickLocationFor(long intPtr)
	{
		return (Vector2i)(object)null;
	}

	public Element GetElementAt(long intPtr)
	{
		return null;
	}

	internal void method_29(Element element_2)
	{
	}

	[CompilerGenerated]
	private Dictionary<int, long> method_30()
	{
		return null;
	}

	internal static bool smethod_11()
	{
		return true;
	}

	internal static AtlasSkillElement smethod_12()
	{
		return null;
	}

	static AtlasSkillElement()
	{
		Class200.smethod_34();
	}
}
