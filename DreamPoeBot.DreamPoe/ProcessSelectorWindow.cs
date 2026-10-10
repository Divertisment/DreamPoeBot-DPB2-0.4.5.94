using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Threading;
using DreamPoeBot.Loki.Common;
using log4net;
using ns0;

namespace DreamPoeBot.DreamPoe;

public partial class ProcessSelectorWindow : UserControl, IComponentConnector
{
	private static readonly ILog Log;

	private readonly MainWindow mainWindow_0;

	private DispatcherTimer dispatcherTimer_0;

	private volatile bool bool_0;

	internal ListBox ProcessesListBox;

	internal Button SelectButton;

	internal Button RefreshButton;

	internal Button ActivateButton;

	private bool bool_1;

	private static ProcessSelectorWindow processSelectorWindow_0;

	public ProcessSelectorWindow(MainWindow mainWindow)
	{
	}

	private void method_0(object sender, RoutedEventArgs e)
	{
	}

	private void method_1(object sender, RoutedEventArgs e)
	{
	}

	private void method_2()
	{
	}

	private void method_3(object sender, RoutedEventArgs e)
	{
	}

	private void method_4(object sender, EventArgs e)
	{
	}

	private void method_5()
	{
	}

	private void method_6(object sender, SelectionChangedEventArgs e)
	{
	}

	private void method_7(object sender, RoutedEventArgs e)
	{
	}

	private void method_8(object sender, MouseButtonEventArgs e)
	{
	}

	private void method_9(object object_0)
	{
	}

	private void method_10(Process process_0, string string_0)
	{
	}

	internal void method_11()
	{
	}

	static ProcessSelectorWindow()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		Log = Logger.GetLoggerInstanceForType();
	}

	[CompilerGenerated]
	private void method_12(object? object_0)
	{
	}

	[CompilerGenerated]
	private void method_13()
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static ProcessSelectorWindow smethod_1()
	{
		return null;
	}
}
