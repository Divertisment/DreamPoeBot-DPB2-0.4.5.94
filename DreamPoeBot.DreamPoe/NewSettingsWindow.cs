using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using DreamPoeBot.Loki.Bot;
using DreamPoeBot.Loki.Common;
using log4net;
using MahApps.Metro.Controls;
using ns0;

namespace DreamPoeBot.DreamPoe;

public partial class NewSettingsWindow : MetroWindow, IComponentConnector
{
	private static readonly ILog ilog_0;

	private readonly MainWindow mainWindow_0;

	private readonly BotTemplateGui botTemplateGui_0;

	private readonly RoutineTemplateGui routineTemplateGui_0;

	private readonly MoverTemplateGui moverTemplateGui_0;

	private readonly PluginTemplateGui pluginTemplateGui_0;

	private readonly ContentTemplateGui contentTemplateGui_0;

	private Dictionary<IBot, BotForegroundBindingHelper> dictionary_0;

	private Dictionary<IRoutine, RoutineForegroundBindingHelper> dictionary_1;

	private Dictionary<IPlayerMover, MoverForegroundBindingHelper> dictionary_2;

	private Dictionary<IPlugin, PluginForegroundBindingHelper> dictionary_3;

	private GlobalSettingsWrapper globalSettingsWrapper_0;

	private CurrentConfigurationSettingsWrapper currentConfigurationSettingsWrapper_0;

	private GuiSettingsWrapper guiSettingsWrapper_0;

	private ThirdPartyWrapper thirdPartyWrapper_0;

	private PremiumContentManagerWrapper premiumContentManagerWrapper_0;

	private BotManagerWrapper botManagerWrapper_0;

	private RoutineManagerWrapper routineManagerWrapper_0;

	private MoverManagerWrapper moverManagerWrapper_0;

	private bool bool_0;

	internal TreeView NewSettingsTreeView;

	internal GridSplitter NewSettingsGridSplitter;

	internal UserControl NewSettingsContentUserControl;

	private bool bool_1;

	internal static NewSettingsWindow newSettingsWindow_0;

	public NewSettingsWindow(MainWindow mainWindow)
	{
	}

	private void method_0()
	{
	}

	private void method_1()
	{
	}

	private void method_2(object sender, PlayerMoverChangedEventArgs e)
	{
	}

	private void method_3(object sender, RoutineChangedEventArgs e)
	{
	}

	private void method_4()
	{
	}

	private void method_5(object sender, BotChangedEventArgs e)
	{
	}

	private void method_6(IPlugin iplugin_0)
	{
	}

	private void method_7(IPlugin iplugin_0)
	{
	}

	private void method_8(IPlugin iplugin_0)
	{
	}

	private void method_9(object sender, CancelEventArgs e)
	{
	}

	private void method_10()
	{
	}

	internal void method_11(string string_0)
	{
	}

	internal TreeViewItem method_12(string string_0, ref TreeViewItem treeViewItem_0)
	{
		return null;
	}

	internal void method_13()
	{
	}

	internal bool method_14(out TreeViewItem treeViewItem_0, object object_0, string string_0, TreeViewItem treeViewItem_1)
	{
		return true;
	}

	private static bool smethod_0(TreeViewItem treeViewItem_0, string string_0)
	{
		return true;
	}

	private static void smethod_1(TreeViewItem treeViewItem_0, string string_0)
	{
	}

	internal TreeViewItem method_15(params string[] string_0)
	{
		return null;
	}

	private void method_16(object sender, RoutedPropertyChangedEventArgs<object> e)
	{
	}

	static NewSettingsWindow()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static NewSettingsWindow smethod_3()
	{
		return null;
	}
}
