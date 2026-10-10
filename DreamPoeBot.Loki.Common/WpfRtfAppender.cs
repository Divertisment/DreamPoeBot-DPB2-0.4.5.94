using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Threading;
using log4net.Appender;
using log4net.Core;
using ns0;

namespace DreamPoeBot.Loki.Common;

public class WpfRtfAppender : AppenderSkeleton
{
	[CompilerGenerated]
	private SolidColorBrush solidColorBrush_0;

	[CompilerGenerated]
	private SolidColorBrush solidColorBrush_1;

	[CompilerGenerated]
	private SolidColorBrush solidColorBrush_2;

	[CompilerGenerated]
	private SolidColorBrush solidColorBrush_3;

	private readonly RichTextBox richTextBox_0;

	private readonly ScrollViewer scrollViewer_0;

	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	private DispatcherTimer dispatcherTimer_0;

	private Paragraph paragraph_0;

	private readonly ConcurrentQueue<LoggingEvent> concurrentQueue_0;

	internal static WpfRtfAppender wpfRtfAppender_0;

	public SolidColorBrush InfoBrush
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public SolidColorBrush DebugBrush
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public SolidColorBrush ErrorBrush
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public SolidColorBrush WarnBrush
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public WpfRtfAppender(ScrollViewer scrollViewer, RichTextBox rtb)
	{
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private SolidColorBrush method_1(string string_0)
	{
		return null;
	}

	private void method_2(StringBuilder stringBuilder_0, SolidColorBrush solidColorBrush_4)
	{
	}

	protected override void Append(LoggingEvent loggingEvent)
	{
	}

	public void Clear()
	{
	}

	private static int smethod_0(string string_0)
	{
		return 0;
	}

	private static string smethod_1(string string_0)
	{
		return null;
	}

	private void method_3(int int_4, int int_5, StringBuilder stringBuilder_0, SolidColorBrush solidColorBrush_4)
	{
	}

	private void method_4()
	{
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static WpfRtfAppender smethod_3()
	{
		return null;
	}

	static WpfRtfAppender()
	{
		Class200.smethod_34();
	}
}
