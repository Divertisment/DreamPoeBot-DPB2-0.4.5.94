using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Markup;
using DreamPoeBot.Loki.Bot;
using DreamPoeBot.Loki.Common;
using log4net;
using ns0;

namespace DreamPoeBot.DreamPoe;

public partial class ContentTemplateGui : UserControl, IComponentConnector
{
	private static readonly ILog ilog_0;

	private IContent icontent_0;

	internal Grid ContentTemplateGrid;

	internal TextBlock ContentTemplateGuiContentGuideTextBlock;

	internal Hyperlink ContentTemplateGuiContentGuideHyperlink;

	internal Label ContentTemplateGuiContentAuthorLabel;

	internal Label ContentTemplateGuiContentVersionLabel;

	internal Label ContentTemplateGuiContentDescriptionLabel;

	internal UserControl ContentTemplateGuiContentUserControl;

	private bool bool_0;

	internal static ContentTemplateGui contentTemplateGui_0;

	internal void method_0(IContent icontent_1)
	{
	}

	private void method_1(object sender, RoutedEventArgs e)
	{
	}

	static ContentTemplateGui()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static ContentTemplateGui smethod_1()
	{
		return null;
	}
}
