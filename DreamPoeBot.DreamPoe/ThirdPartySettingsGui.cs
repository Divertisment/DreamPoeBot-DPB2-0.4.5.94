using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using DreamPoeBot.Loki.Common;
using log4net;
using ns0;

namespace DreamPoeBot.DreamPoe;

public partial class ThirdPartySettingsGui : UserControl, IComponentConnector
{
	private static readonly ILog ilog_0;

	internal DataGrid InstanceDataGrid;

	private bool bool_0;

	private static ThirdPartySettingsGui thirdPartySettingsGui_0;

	private void method_0(object sender, RoutedEventArgs e)
	{
	}

	static ThirdPartySettingsGui()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static ThirdPartySettingsGui smethod_1()
	{
		return null;
	}
}
