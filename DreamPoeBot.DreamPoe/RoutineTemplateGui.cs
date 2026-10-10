using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Markup;
using DreamPoeBot.Loki.Bot;
using DreamPoeBot.Loki.Common;
using log4net;
using ns0;

namespace DreamPoeBot.DreamPoe;

public partial class RoutineTemplateGui : UserControl, IComponentConnector
{
	private static readonly ILog ilog_0;

	private IRoutine iroutine_0;

	internal CheckBox RoutineTemplateGuiRoutineActiveCheckBox;

	internal TextBlock RoutineTemplateGuiRoutineGuideTextBlock;

	internal Hyperlink RoutineTemplateGuiRoutineGuideHyperlink;

	internal Label RoutineTemplateGuiRoutineAuthorLabel;

	internal Label RoutineTemplateGuiRoutineVersionLabel;

	internal Label RoutineTemplateGuiRoutineDescriptionLabel;

	internal UserControl RoutineTemplateGuiContentUserControl;

	private bool bool_0;

	private static RoutineTemplateGui routineTemplateGui_0;

	internal void method_0(IRoutine iroutine_1)
	{
	}

	private void method_1(object sender, RoutedEventArgs e)
	{
	}

	static RoutineTemplateGui()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static RoutineTemplateGui smethod_1()
	{
		return null;
	}
}
