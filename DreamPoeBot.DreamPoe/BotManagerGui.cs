using System;
using System.Windows.Controls;
using System.Windows.Markup;
using DreamPoeBot.Loki.Bot;
using DreamPoeBot.Loki.Common;
using log4net;
using ns0;

namespace DreamPoeBot.DreamPoe;

public partial class BotManagerGui : UserControl, IComponentConnector
{
	private sealed class Class159
	{
		public string string_0;

		internal static Class159 class159_0;

		internal bool method_0(IBot ibot_0)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class159 smethod_1()
		{
			return null;
		}

		static Class159()
		{
			Class200.smethod_34();
		}
	}

	private sealed class Class160
	{
		public string string_0;

		private static Class160 class160_0;

		internal bool method_0(IBot ibot_0)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class160 smethod_1()
		{
			return null;
		}

		static Class160()
		{
			Class200.smethod_34();
		}
	}

	[Serializable]
	private sealed class Class161
	{
		public static readonly Class161 class161_0;

		internal static Class161 class161_1;

		internal bool method_0(IBot ibot_0)
		{
			return true;
		}

		static Class161()
		{
			Class200.smethod_34();
			Class204.smethod_0();
			class161_0 = new Class161();
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class161 smethod_1()
		{
			return null;
		}
	}

	private sealed class Class162
	{
		public BotManagerGui botManagerGui_0;

		public BotChangedEventArgs botChangedEventArgs_0;

		internal static Class162 class162_0;

		internal void method_0()
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class162 smethod_1()
		{
			return null;
		}

		static Class162()
		{
			Class200.smethod_34();
		}
	}

	private static readonly ILog ilog_0;

	internal ComboBox BotsComboBox;

	private bool bool_0;

	private static BotManagerGui botManagerGui_0;

	private void method_0(object sender, BotChangedEventArgs e)
	{
	}

	private void method_1(object sender, SelectionChangedEventArgs e)
	{
	}

	private void method_2()
	{
	}

	static BotManagerGui()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static BotManagerGui smethod_1()
	{
		return null;
	}
}
