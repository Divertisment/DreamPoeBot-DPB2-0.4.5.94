using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using log4net;
using log4net.Core;
using ns0;

namespace DreamPoeBot.Loki.Common;

public static class Logger
{
	[Serializable]
	private sealed class Class124
	{
		public static readonly Class124 class124_0;

		private static Class124 class124_1;

		internal int method_0()
		{
			return 0;
		}

		internal int method_1()
		{
			return 0;
		}

		internal int method_2()
		{
			return 0;
		}

		static Class124()
		{
			Class200.smethod_34();
			Class204.smethod_0();
			class124_0 = new Class124();
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class124 smethod_1()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private static int int_0;

	private static readonly CustomLogger VsiAebfffJl;

	private static readonly Stopwatch stopwatch_0;

	private static Logger logger_0;

	public static CustomLogger Instance => null;

	public static int DropRepeatMessageDelayMs
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static string FileName => null;

	public static void DebugWriteLine(string message)
	{
	}

	public static void OpenLogFile()
	{
	}

	public static ILog GetLoggerInstanceForType()
	{
		return null;
	}

	public static ILog GetLoggerInstanceForName(string name)
	{
		return null;
	}

	static Logger()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		int_0 = 1000;
		stopwatch_0 = new Stopwatch();
		if (!CommandLine.Arguments.Exists(Class200.smethod_20(2895774)))
		{
			VsiAebfffJl = new CustomLogger(Class200.smethod_20(2895794), Class200.smethod_20(2895806), Level.All, Level.Emergency, Class124.class124_0.method_1);
			return;
		}
		string path = CommandLine.Arguments.Single(Class200.smethod_20(2895774));
		VsiAebfffJl = new CustomLogger(Path.Combine(Class200.smethod_20(2895794), path), Class200.smethod_20(2895806), Level.All, Level.Emergency, Class124.class124_0.method_0);
	}

	public static void Clear()
	{
	}

	public static void AddWpfListener(ScrollViewer scrollViewer, RichTextBox rtbLog)
	{
	}

	public static void ChangeFileLogFilterLevel(Level minLevel = null, Level maxLevel = null)
	{
	}

	public static void ChangeWindowLogFilterLevel(Level minLevel = null, Level maxLevel = null)
	{
	}

	public static void ChangeLogFilterLevel(Level minLevel = null, Level maxLevel = null)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static Logger smethod_1()
	{
		return null;
	}
}
