using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ns0;

namespace DreamPoeBot.Loki.Elements;

public class UiQuestStatesElement : Element
{
	public class MapObjective
	{
		private Element element_0;

		[CompilerGenerated]
		private string string_0;

		internal static MapObjective mapObjective_0;

		public string Description
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

		public MapObjective(Element element)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static MapObjective smethod_1()
		{
			return null;
		}

		static MapObjective()
		{
			Class200.smethod_34();
		}
	}

	public class MapContent
	{
		private Element element_0;

		[CompilerGenerated]
		private string string_0;

		private static MapContent mapContent_0;

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

		public bool Completed => true;

		public MapContent(Element element)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static MapContent smethod_1()
		{
			return null;
		}

		static MapContent()
		{
			Class200.smethod_34();
		}
	}

	internal static UiQuestStatesElement uiQuestStatesElement_0;

	public List<(string Title, string Content)> QuestStates => null;

	public List<MapObjective> MapObjectives => null;

	public List<MapContent> MapContents => null;

	[SpecialName]
	private Element method_29()
	{
		return null;
	}

	[SpecialName]
	private Element method_30()
	{
		return null;
	}

	[SpecialName]
	private Element method_31()
	{
		return null;
	}

	[SpecialName]
	private Element method_32()
	{
		return null;
	}

	internal static bool smethod_11()
	{
		return true;
	}

	internal static UiQuestStatesElement smethod_12()
	{
		return null;
	}

	static UiQuestStatesElement()
	{
		Class200.smethod_34();
	}
}
