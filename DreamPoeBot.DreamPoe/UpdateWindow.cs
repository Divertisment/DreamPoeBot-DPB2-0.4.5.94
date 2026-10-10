using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using DreamPoeBot.Loki.Common;
using log4net;
using ns0;

namespace DreamPoeBot.DreamPoe;

public partial class UpdateWindow : UserControl, IComponentConnector
{
	private static readonly ILog ilog_0;

	private readonly MainWindow mainWindow_0;

	private readonly string zvtArinTyYq;

	private bool bool_0;

	internal RichTextBox ChangelogTextBox;

	internal Button YesButton;

	internal Button NoButton;

	private bool bool_1;

	private static UpdateWindow updateWindow_0;

	public UpdateWindow(MainWindow mainWindow, string filter)
	{
	}

	private void method_0(object sender, RoutedEventArgs e)
	{
	}

	private void method_1(object sender, RoutedEventArgs e)
	{
	}

	private void method_2(object sender, RoutedEventArgs e)
	{
	}

	private void method_3(object sender, RoutedEventArgs e)
	{
	}

	static UpdateWindow()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static UpdateWindow smethod_1()
	{
		return null;
	}
}
