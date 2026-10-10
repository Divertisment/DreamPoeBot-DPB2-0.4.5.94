using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Markup;
using DreamPoeBot.Loki.Bot;
using DreamPoeBot.Loki.Common;
using log4net;
using ns0;

namespace DreamPoeBot.DreamPoe;

public partial class MoverTemplateGui : UserControl, IComponentConnector
{
	private static readonly ILog ilog_0;

	private IPlayerMover iplayerMover_0;

	internal CheckBox MoverTemplateGuiMoverActiveCheckBox;

	internal TextBlock MoverTemplateGuiMoverGuideTextBlock;

	internal Hyperlink MoverTemplateGuiMoverGuideHyperlink;

	internal Label MoverTemplateGuiMoverAuthorLabel;

	internal Label MoverTemplateGuiMoverVersionLabel;

	internal Label MoverTemplateGuiMoverDescriptionLabel;

	internal UserControl MoverTemplateGuiContentUserControl;

	private bool bool_0;

	private static MoverTemplateGui moverTemplateGui_0;

	internal void method_0(IPlayerMover iplayerMover_1)
	{
	}

	private void method_1(object sender, RoutedEventArgs e)
	{
	}

	static MoverTemplateGui()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static MoverTemplateGui smethod_1()
	{
		return null;
	}
}
