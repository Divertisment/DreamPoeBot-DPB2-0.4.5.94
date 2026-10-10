using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using DreamPoeBot.Loki.Common;
using log4net;
using MahApps.Metro.Controls;
using ns0;

namespace DreamPoeBot.DreamPoe;

public partial class DownloadWindow : UserControl, IComponentConnector
{
	private static readonly ILog ilog_0;

	private readonly string string_0;

	private readonly string string_1;

	internal TextBlock DownloadTextBlock;

	internal ProgressRing progressRing_0;

	private bool bool_0;

	internal static DownloadWindow downloadWindow_0;

	public DownloadWindow(MainWindow mainWindow, string filter)
	{
	}

	private void method_0(object sender, RoutedEventArgs e)
	{
	}

	private static string smethod_0(string[] string_2)
	{
		return null;
	}

	private void method_1(object object_0)
	{
	}

	static DownloadWindow()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_1()
	{
		return true;
	}

	internal static DownloadWindow smethod_2()
	{
		return null;
	}
}
