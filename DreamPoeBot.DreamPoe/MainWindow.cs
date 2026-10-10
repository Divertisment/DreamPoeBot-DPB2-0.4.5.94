using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media.Imaging;
using System.Windows.Shell;
using DreamPoeBot.Localization;
using DreamPoeBot.Loki.Common;
using log4net;
using MahApps.Metro.Controls;
using ns0;

namespace DreamPoeBot.DreamPoe;

public partial class MainWindow : MetroWindow, IComponentConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCheckForUpdate_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public MainWindow _003C_003E4__this;

		private TaskAwaiter<string> _003C_003Eu__1;

		internal static object object_0;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static object smethod_1()
		{
			return null;
		}

		static _003CCheckForUpdate_003Ed__27()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSelectBestDomain_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		private TaskAwaiter<Class186> _003C_003Eu__1;

		private static object object_0;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static object smethod_1()
		{
			return null;
		}

		static _003CSelectBestDomain_003Ed__26()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private NewSettingsWindow newSettingsWindow_0;

	private bool bool_0;

	private static readonly ILog ilog_0;

	private readonly NotifyIcon notifyIcon_0;

	private BotWindow botWindow_0;

	private TaskbarItemInfo taskbarItemInfo_0;

	private ThumbButtonInfo thumbButtonInfo_0;

	private ConfigSelection configSelection_0;

	private LoginWindow loginWindow_0;

	private UpdateWindow updateWindow_0;

	private DownloadWindow downloadWindow_0;

	private ProcessSelectorWindow processSelectorWindow_0;

	internal Mutex mutex_0;

	internal Process process_0;

	private BitmapSource bitmapSource_0;

	private BitmapSource bitmapSource_1;

	public static RoutedCommand OpenSettingsWindow;

	internal System.Windows.Controls.Label StatusBarLeftLabel;

	internal System.Windows.Controls.Label StatusBarRightLabel;

	internal TransitioningContentControl transitioningContentControl_0;

	internal System.Windows.Controls.ComboBox InterfaceLanguageComboBox;

	internal System.Windows.Controls.Button SettingsButton;

	internal System.Windows.Controls.Button TitleButton;

	internal System.Windows.Controls.Button ProcessButton;

	private bool bool_1;

	internal static MainWindow mainWindow_0;

	[SpecialName]
	[CompilerGenerated]
	internal NewSettingsWindow method_0()
	{
		return null;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_1(NewSettingsWindow newSettingsWindow_1)
	{
	}

	protected override void OnSourceInitialized(EventArgs e)
	{
	}

	public bool IsAdministrator()
	{
		return true;
	}

	private nint method_2(nint intptr_0, int int_0, nint intptr_1, nint intptr_2, ref bool bool_2)
	{
		return (nint)(object)null;
	}

	private void method_3(object sender, ExecutedRoutedEventArgs e)
	{
	}

	internal NewSettingsWindow method_4()
	{
		return null;
	}

	internal void method_5(string string_0 = null)
	{
	}

	internal void method_6(NewSettingsWindow newSettingsWindow_1)
	{
	}

	private void method_7()
	{
	}

	private static void smethod_0<T>(ref T gparam_0) where T : System.Windows.Controls.UserControl
	{
	}

	private static void smethod_1(DependencyObject dependencyObject_0)
	{
	}

	private void method_8()
	{
	}

	private void method_9(object sender, CultureChangedEventArgs e)
	{
	}

	private void method_10(object sender, SelectionChangedEventArgs e)
	{
	}

	protected override void OnStateChanged(EventArgs e)
	{
	}

	internal void method_11()
	{
	}

	internal void method_12()
	{
	}

	internal void method_13()
	{
	}

	internal void method_14(string string_0)
	{
	}

	internal void method_15(string string_0)
	{
	}

	internal Tuple<long, string> method_16(string string_0)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CSelectBestDomain_003Ed__26))]
	internal Task<string> method_17()
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CCheckForUpdate_003Ed__27))]
	internal void method_18()
	{
	}

	internal void method_19(Process process_1)
	{
	}

	internal bool method_20()
	{
		return true;
	}

	internal void method_21()
	{
	}

	internal void method_22()
	{
	}

	private void method_23(object sender, EventArgs e)
	{
	}

	private void method_24(object sender, RoutedEventArgs e)
	{
	}

	internal void method_25(string string_0)
	{
	}

	private void method_26(object sender, RoutedEventArgs e)
	{
	}

	private void method_27(object sender, RoutedEventArgs e)
	{
	}

	private void method_28(object sender, RoutedEventArgs e)
	{
	}

	private void method_29(object sender, CancelEventArgs e)
	{
	}

	private void method_30(object sender, EventArgs e)
	{
	}

	private void method_31(object sender, EventArgs e)
	{
	}

	private void method_32()
	{
	}

	internal void method_33()
	{
	}

	static MainWindow()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
		OpenSettingsWindow = new RoutedCommand();
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static MainWindow smethod_3()
	{
		return null;
	}
}
