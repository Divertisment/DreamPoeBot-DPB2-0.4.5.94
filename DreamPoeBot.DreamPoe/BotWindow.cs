using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Threading;
using DreamPoeBot.Loki.Bot;
using DreamPoeBot.Loki.Common;
using log4net;
using ns0;

namespace DreamPoeBot.DreamPoe;

public partial class BotWindow : UserControl, IComponentConnector
{
	[Serializable]
	private sealed class Class163
	{
		public static readonly Class163 class163_0;

		internal static Class163 class163_1;

		internal void method_0(Hotkey hotkey_0)
		{
		}

		internal void method_1(Hotkey hotkey_0)
		{
		}

		internal void method_2(Hotkey hotkey_0)
		{
		}

		internal void method_3()
		{
		}

		internal void method_4(Hotkey hotkey_0)
		{
		}

		internal void method_5(Hotkey hotkey_0)
		{
		}

		internal void method_6(Hotkey hotkey_0)
		{
		}

		internal void method_7(Hotkey hotkey_0)
		{
		}

		internal void method_8(Hotkey hotkey_0)
		{
		}

		internal void method_9(Hotkey hotkey_0)
		{
		}

		private void method_10(long long_0)
		{
		}

		internal void method_11(Hotkey hotkey_0)
		{
		}

		static Class163()
		{
			Class200.smethod_34();
			Class204.smethod_0();
			class163_0 = new Class163();
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class163 smethod_1()
		{
			return null;
		}
	}

	private DispatcherTimer dispatcherTimer_0;

	private static readonly ILog ilog_0;

	private readonly MainWindow mainWindow_0;

	private DispatcherTimer dispatcherTimer_1;

	private bool bool_0;

	private DispatcherTimer dispatcherTimer_2;

	internal RowDefinition TopRowDefinition;

	internal RowDefinition SplitterRowDefinition;

	internal RowDefinition BottomRowDefinition;

	internal GridSplitter GridSplitter;

	internal ComboBox LogLevelComboBox;

	internal TextBox TextboxLogFileName;

	internal MenuItem CopyNameToClipboardButton;

	internal MenuItem ZipButton;

	internal ScrollViewer ScrollLog;

	internal RichTextBox LogRichTextBox;

	internal MenuItem ClearLogButton;

	internal ComboBox BotsComboBox;

	internal ComboBox RoutinesComboBox;

	internal ComboBox MoverComboBox;

	internal Button StartStopButton;

	internal Button ForceStopButton;

	internal CheckBox renderCb;

	internal Button TimeLeftButton;

	private bool bool_1;

	internal static BotWindow botWindow_0;

	internal void method_0(object sender, EventArgs e)
	{
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	public BotWindow(MainWindow mainWindow)
	{
	}

	internal void method_2()
	{
	}

	internal void method_3(object sender, EventArgs e)
	{
	}

	private void method_4(object sender, RoutedEventArgs e)
	{
	}

	private void method_5(object sender, RoutedEventArgs e)
	{
	}

	private void method_6(object sender, RoutedEventArgs e)
	{
	}

	private void method_7(object sender, RoutedEventArgs e)
	{
	}

	private void method_8(IBot ibot_0)
	{
	}

	internal void method_9(object sender, RoutedEventArgs e)
	{
	}

	private void method_10(object sender, RoutedEventArgs e)
	{
	}

	private void method_11(object sender, RoutedEventArgs e)
	{
	}

	private void method_12(object sender, RoutedEventArgs e)
	{
	}

	private void method_13(object sender, EventArgs e)
	{
	}

	private void method_14()
	{
	}

	private void method_15()
	{
	}

	private void method_16(object sender, SelectionChangedEventArgs e)
	{
	}

	private void method_17(object sender, SelectionChangedEventArgs e)
	{
	}

	private void method_18(object sender, SelectionChangedEventArgs e)
	{
	}

	private void method_19(object sender, SelectionChangedEventArgs e)
	{
	}

	private void method_20(object sender, BotChangedEventArgs e)
	{
	}

	private void method_21(object sender, RoutineChangedEventArgs e)
	{
	}

	private void method_22(object sender, PlayerMoverChangedEventArgs e)
	{
	}

	private void method_23(object sender, RoutedEventArgs e)
	{
	}

	private void method_24()
	{
	}

	private void method_25(object object_0)
	{
	}

	private void method_26()
	{
	}

	private void method_27()
	{
	}

	private void method_28()
	{
	}

	private void method_29()
	{
	}

	private void method_30()
	{
	}

	private void method_31()
	{
	}

	private void method_32()
	{
	}

	private void method_33()
	{
	}

	private void method_34(object sender, RoutedEventArgs e)
	{
	}

	private void method_35(object sender, RoutedEventArgs e)
	{
	}

	static BotWindow()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	[CompilerGenerated]
	private void ModAnyksaXK()
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static BotWindow smethod_1()
	{
		return null;
	}
}
