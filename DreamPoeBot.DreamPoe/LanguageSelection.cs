using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using DreamPoeBot.Loki.Common;
using log4net;
using ns0;

namespace DreamPoeBot.DreamPoe;

public partial class LanguageSelection : UserControl, IComponentConnector
{
	[Serializable]
	private sealed class Class170
	{
		public static readonly Class170 class170_0;

		private static Class170 class170_1;

		internal void moUpXkmgOyd()
		{
		}

		internal void method_0()
		{
		}

		static Class170()
		{
			Class200.smethod_34();
			Class204.smethod_0();
			class170_0 = new Class170();
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class170 smethod_1()
		{
			return null;
		}
	}

	private static readonly ILog ilog_0;

	private readonly MainWindow mainWindow_0;

	internal ComboBox LanguageComboBox;

	internal Button ChooseLanguageButton;

	internal TextBlock LanguageInstructionsTextBlock;

	internal CheckBox AutoSelectLanguageCheckBox;

	private bool bool_0;

	internal static LanguageSelection languageSelection_0;

	public LanguageSelection(MainWindow mainWindow)
	{
	}

	private void method_0(object sender, RoutedEventArgs e)
	{
	}

	private void method_1(object sender, RoutedEventArgs e)
	{
	}

	static LanguageSelection()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static LanguageSelection smethod_1()
	{
		return null;
	}
}
