using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using DreamPoeBot.Loki.Common;
using log4net;
using ns0;

namespace DreamPoeBot.DreamPoe;

public partial class ConfigSelection : UserControl, IComponentConnector
{
	private sealed class Class164
	{
		public static readonly Class164 class164_0;

		internal static Class164 class164_1;

		internal void method_0()
		{
		}

		internal void method_1()
		{
		}

		static Class164()
		{
			Class200.smethod_34();
			Class204.smethod_0();
			class164_0 = new Class164();
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class164 smethod_1()
		{
			return null;
		}
	}

	private static readonly ILog ilog_0;

	private readonly MainWindow mainWindow_0;

	internal CheckBox AutoSelectConfigCheckBox;

	internal ComboBox ConfigComboBox;

	internal Button ChooseConfigButton;

	internal TextBlock ConfigInstructionsTextBlock;

	private bool bool_0;

	private static ConfigSelection configSelection_0;

	private void method_0()
	{
	}

	public ConfigSelection(MainWindow mainWindow)
	{
	}

	private void method_1(object sender, RoutedEventArgs e)
	{
	}

	private void method_2(object sender, RoutedEventArgs e)
	{
	}

	private void method_3(object sender, KeyEventArgs e)
	{
	}

	static ConfigSelection()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static ConfigSelection smethod_1()
	{
		return null;
	}
}
