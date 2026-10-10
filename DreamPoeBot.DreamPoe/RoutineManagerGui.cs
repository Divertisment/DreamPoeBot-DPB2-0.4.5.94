using System;
using System.Windows.Controls;
using System.Windows.Markup;
using DreamPoeBot.Loki.Bot;
using DreamPoeBot.Loki.Common;
using log4net;
using ns0;

namespace DreamPoeBot.DreamPoe;

public partial class RoutineManagerGui : UserControl, IComponentConnector
{
	private sealed class Class175
	{
		public string string_0;

		private static Class175 class175_0;

		internal bool method_0(IRoutine iroutine_0)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class175 smethod_1()
		{
			return null;
		}

		static Class175()
		{
			Class200.smethod_34();
		}
	}

	private sealed class Class176
	{
		public string string_0;

		private static Class176 class176_0;

		internal bool method_0(IRoutine iroutine_0)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class176 smethod_1()
		{
			return null;
		}

		static Class176()
		{
			Class200.smethod_34();
		}
	}

	[Serializable]
	private sealed class Class177
	{
		public static readonly Class177 class177_0;

		internal static Class177 class177_1;

		internal bool method_0(IRoutine iroutine_0)
		{
			return true;
		}

		static Class177()
		{
			Class200.smethod_34();
			Class204.smethod_0();
			class177_0 = new Class177();
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class177 smethod_1()
		{
			return null;
		}
	}

	private sealed class Class178
	{
		public RoutineManagerGui routineManagerGui_0;

		public RoutineChangedEventArgs routineChangedEventArgs_0;

		internal static Class178 class178_0;

		internal void method_0()
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class178 smethod_1()
		{
			return null;
		}

		static Class178()
		{
			Class200.smethod_34();
		}
	}

	private static readonly ILog ilog_0;

	internal ComboBox RoutinesComboBox;

	private bool bool_0;

	private static RoutineManagerGui routineManagerGui_0;

	private void method_0(object sender, RoutineChangedEventArgs e)
	{
	}

	private void method_1(object sender, SelectionChangedEventArgs e)
	{
	}

	private void method_2()
	{
	}

	static RoutineManagerGui()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static RoutineManagerGui smethod_1()
	{
		return null;
	}
}
