using System;
using System.IO;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Common;
using log4net;
using ns0;

namespace DreamPoeBot.Framework.Helpers;

public static class Misc
{
	private class Class158
	{
		[CompilerGenerated]
		private string string_0;

		internal static Class158 class158_0;

		public string Name
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

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class158 smethod_1()
		{
			return null;
		}

		static Class158()
		{
			Class200.smethod_34();
		}
	}

	private static readonly string string_0;

	private static readonly ILog ilog_0;

	internal static Misc misc_0;

	public static string ToBytesCount(this long bytes)
	{
		return null;
	}

	public static string GetRandomSelectedProfile()
	{
		return null;
	}

	private static string smethod_0()
	{
		return null;
	}

	public static void SetRandomSelectedProfile(string profile)
	{
	}

	private static void smethod_1(string string_1)
	{
	}

	static Misc()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		string_0 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Class200.smethod_20(79950));
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static Misc smethod_3()
	{
		return null;
	}
}
