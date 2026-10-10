using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Markup;
using DreamPoeBot.Loki.Bot;
using DreamPoeBot.Loki.Common;
using log4net;
using ns0;

namespace DreamPoeBot.DreamPoe;

public partial class BotTemplateGui : UserControl, IComponentConnector
{
	private static readonly ILog ilog_0;

	private IBot ibot_0;

	internal CheckBox BotTemplateGuiBotActiveCheckBox;

	internal TextBlock BotTemplateGuiBotGuideTextBlock;

	internal Hyperlink BotTemplateGuiBotGuideHyperlink;

	internal Label BotTemplateGuiBotAuthorLabel;

	internal Label BotTemplateGuiBotVersionLabel;

	internal Label BotTemplateGuiBotDescriptionLabel;

	internal UserControl BotTemplateGuiContentUserControl;

	private bool bool_0;

	internal static BotTemplateGui botTemplateGui_0;

	internal void method_0(IBot ibot_1)
	{
	}

	private void method_1(object sender, RoutedEventArgs e)
	{
	}

	static BotTemplateGui()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static BotTemplateGui smethod_1()
	{
		return null;
	}
}
