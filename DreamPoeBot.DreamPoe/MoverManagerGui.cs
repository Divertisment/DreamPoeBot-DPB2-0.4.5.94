using System;
using System.Windows.Controls;
using System.Windows.Markup;
using DreamPoeBot.Loki.Bot;
using DreamPoeBot.Loki.Common;
using log4net;
using ns0;

namespace DreamPoeBot.DreamPoe;

public partial class MoverManagerGui : UserControl, IComponentConnector
{
	private sealed class Class171
	{
		public string string_0;

		internal static Class171 class171_0;

		internal bool method_0(IPlayerMover iplayerMover_0)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class171 smethod_1()
		{
			return null;
		}

		static Class171()
		{
			Class200.smethod_34();
		}
	}

	private sealed class Class172
	{
		public string string_0;

		private static Class172 class172_0;

		internal bool method_0(IPlayerMover iplayerMover_0)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class172 smethod_1()
		{
			return null;
		}

		static Class172()
		{
			Class200.smethod_34();
		}
	}

	[Serializable]
	private sealed class Class173
	{
		public static readonly Class173 class173_0;

		private static Class173 class173_1;

		internal bool method_0(IPlayerMover iplayerMover_0)
		{
			return true;
		}

		static Class173()
		{
			Class200.smethod_34();
			Class204.smethod_0();
			class173_0 = new Class173();
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class173 smethod_1()
		{
			return null;
		}
	}

	private sealed class Class174
	{
		public MoverManagerGui moverManagerGui_0;

		public PlayerMoverChangedEventArgs playerMoverChangedEventArgs_0;

		internal static Class174 class174_0;

		internal void method_0()
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class174 smethod_1()
		{
			return null;
		}

		static Class174()
		{
			Class200.smethod_34();
		}
	}

	private static readonly ILog ilog_0;

	internal ComboBox MoversComboBox;

	private bool bool_0;

	private static MoverManagerGui moverManagerGui_0;

	private void method_0(object sender, PlayerMoverChangedEventArgs e)
	{
	}

	private void method_1(object sender, SelectionChangedEventArgs e)
	{
	}

	private void method_2()
	{
	}

	static MoverManagerGui()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static MoverManagerGui smethod_1()
	{
		return null;
	}
}
