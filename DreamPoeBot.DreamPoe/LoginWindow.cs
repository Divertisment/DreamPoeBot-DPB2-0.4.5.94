using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using DreamPoeBot.Loki.Common;
using log4net;
using MahApps.Metro.Controls;
using ns0;

namespace DreamPoeBot.DreamPoe;

public partial class LoginWindow : UserControl, IComponentConnector
{
	private static readonly ILog ilog_0;

	private readonly MainWindow mainWindow_0;

	internal MetroProgressBar metroProgressBar_0;

	internal TextBox KeyTextBox;

	internal ComboBox AuthRegionComboBox;

	internal Button AuthLoginButton;

	internal TextBlock AuthLoginTextBlock;

	private bool bool_0;

	internal static LoginWindow loginWindow_0;

	public LoginWindow(MainWindow mainWindow)
	{
	}

	private void method_0(object sender, RoutedEventArgs e)
	{
	}

	private void method_1(object object_0)
	{
	}

	private void method_2()
	{
	}

	private void method_3(object sender, RoutedEventArgs e)
	{
	}

	internal void method_4()
	{
	}

	internal void method_5()
	{
	}

	internal void method_6()
	{
	}

	static LoginWindow()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static LoginWindow smethod_1()
	{
		return null;
	}
}
