using System;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using log4net;
using log4net.Appender;
using log4net.Core;
using ns0;

namespace DreamPoeBot.Loki.Common;

public class CustomLogger
{
	[CompilerGenerated]
	private readonly string string_0;

	private Level level_0;

	private Level level_1;

	private Level level_2;

	private Level level_3;

	private readonly string string_1;

	private WpfRtfAppender wpfRtfAppender_0;

	private FileAppender fileAppender_0;

	internal static CustomLogger customLogger_0;

	public Level WindowMinLevel => null;

	public Level WindowMaxLevel => null;

	public Level FileMinLevel => null;

	public Level FileMaxLevel => null;

	public WpfRtfAppender WindowLogAppender => null;

	public FileAppender FileLogAppender => null;

	public string FileName
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public CustomLogger(string path, string prefix, Level minLevel, Level maxLevel, Func<int> getDropRepeatMessageDelayMs)
	{
	}

	public void ChangeFileLogFilterLevel(Level minLevel = null, Level maxLevel = null)
	{
	}

	public void ChangeWindowLogFilterLevel(Level minLevel = null, Level maxLevel = null)
	{
	}

	public void ChangeLogFilterLevel(Level minLevel = null, Level maxLevel = null)
	{
	}

	public void Clear()
	{
	}

	public void AddWpfListener(ScrollViewer scrollViewer, RichTextBox rtbLog, Func<int> getDropRepeatMessageDelayMs)
	{
	}

	public ILog GetLoggerInstanceForType()
	{
		return null;
	}

	public ILog GetLoggerInstanceForName(string name)
	{
		return null;
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static CustomLogger smethod_1()
	{
		return null;
	}

	static CustomLogger()
	{
		Class200.smethod_34();
	}
}
