using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Markup;
using DreamPoeBot.Loki.Bot;
using DreamPoeBot.Loki.Common;
using log4net;
using ns0;

namespace DreamPoeBot.DreamPoe;

public partial class PluginTemplateGui : UserControl, IComponentConnector
{
	private static readonly ILog ilog_0;

	private IPlugin iplugin_0;

	internal Grid PluginTemplateGrid;

	internal CheckBox PluginTemplateGuiPluginEnabledCheckBox;

	internal TextBlock PluginTemplateGuiPluginGuideTextBlock;

	internal Hyperlink PluginTemplateGuiPluginGuideHyperlink;

	internal Label PluginTemplateGuiPluginAuthorLabel;

	internal Label PluginTemplateGuiPluginVersionLabel;

	internal Label PluginTemplateGuiPluginDescriptionLabel;

	internal UserControl PluginTemplateGuiContentUserControl;

	private bool bool_0;

	private static PluginTemplateGui pluginTemplateGui_0;

	internal void method_0(IPlugin iplugin_1)
	{
	}

	private void method_1(object sender, RoutedEventArgs e)
	{
	}

	static PluginTemplateGui()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static PluginTemplateGui smethod_1()
	{
		return null;
	}
}
