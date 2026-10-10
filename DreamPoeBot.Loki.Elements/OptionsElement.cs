using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ns0;

namespace DreamPoeBot.Loki.Elements;

public class OptionsElement : Element
{
	public class UICategories : Element
	{
		internal static UICategories uicategories_0;

		public string Name => null;

		public List<GenericGameOption> Options => null;

		internal static bool smethod_11()
		{
			return true;
		}

		internal static UICategories smethod_12()
		{
			return null;
		}

		static UICategories()
		{
			Class200.smethod_34();
		}
	}

	public class GenericGameOption : Element
	{
		private static GenericGameOption genericGameOption_0;

		public string Name => null;

		internal static bool smethod_11()
		{
			return true;
		}

		internal static GenericGameOption smethod_12()
		{
			return null;
		}

		static GenericGameOption()
		{
			Class200.smethod_34();
		}
	}

	public class ComboboxGameOption : GenericGameOption
	{
		internal static ComboboxGameOption comboboxGameOption_0;

		public string SelectedOption => null;

		public List<string> Options => null;

		[SpecialName]
		internal GenericComboBoxElement method_29()
		{
			return null;
		}

		public bool SelectOption(string option)
		{
			return true;
		}

		internal static bool smethod_13()
		{
			return true;
		}

		internal static ComboboxGameOption smethod_14()
		{
			return null;
		}

		static ComboboxGameOption()
		{
			Class200.smethod_34();
		}
	}

	public class CheckboxGameOption : GenericGameOption
	{
		private static CheckboxGameOption checkboxGameOption_0;

		public bool IsChecked => true;

		[SpecialName]
		internal GenericCheckbox method_29()
		{
			return null;
		}

		public void ClickCheckBox()
		{
		}

		internal static bool smethod_13()
		{
			return true;
		}

		internal static CheckboxGameOption smethod_14()
		{
			return null;
		}

		static CheckboxGameOption()
		{
			Class200.smethod_34();
		}
	}

	internal static OptionsElement optionsElement_0;

	public Element InputBindPanel => null;

	public bool IsAlwaysHighligthEnabled => true;

	public byte InputMethod => 0;

	[SpecialName]
	internal long method_29()
	{
		return 0L;
	}

	[SpecialName]
	internal Element method_30()
	{
		return null;
	}

	[SpecialName]
	internal Element hHxjsyOxYR()
	{
		return null;
	}

	[SpecialName]
	internal Element YuXjUccgUC()
	{
		return null;
	}

	[SpecialName]
	internal Element method_31()
	{
		return null;
	}

	[SpecialName]
	internal Element method_32()
	{
		return null;
	}

	[SpecialName]
	internal List<UICategories> method_33()
	{
		return null;
	}

	[SpecialName]
	internal Element method_34()
	{
		return null;
	}

	[SpecialName]
	internal Element method_35()
	{
		return null;
	}

	[SpecialName]
	internal Element method_36()
	{
		return null;
	}

	internal static bool smethod_11()
	{
		return true;
	}

	internal static OptionsElement smethod_12()
	{
		return null;
	}

	static OptionsElement()
	{
		Class200.smethod_34();
	}
}
