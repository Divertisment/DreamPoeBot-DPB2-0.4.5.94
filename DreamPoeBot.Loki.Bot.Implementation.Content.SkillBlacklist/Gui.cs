using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using DreamPoeBot.Loki.Common;
using DreamPoeBot.Loki.RemoteMemoryObjects;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Bot.Implementation.Content.SkillBlacklist;

public partial class Gui : UserControl, IComponentConnector, IStyleConnector
{
	[CompilerGenerated]
	private sealed class Class507
	{
		public string string_0;

		internal static Class507 class507_0;

		internal bool method_0(SkillName skillName_0)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class507 smethod_1()
		{
			return null;
		}

		static Class507()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private sealed class Class508
	{
		public ushort ushort_0;

		internal static Class508 class508_0;

		internal bool method_0(SkillId skillId_0)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class508 smethod_1()
		{
			return null;
		}

		static Class508()
		{
			Class200.smethod_34();
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class Class509
	{
		public static readonly Class509 Class9;

		public static Func<Skill, bool> Method9__9_0;

		public static Func<Skill, ushort> Method9__9_1;

		public static Func<Skill, string> Method9__9_2;

		public static Func<Skill, bool> Method9__10_0;

		public static Func<Skill, ushort> Method9__10_1;

		public static Func<Skill, string> Method9__10_2;

		public static Func<KeyValuePair<ushort, string>, PlayerSkillWrapper> Method9__12_0;

		internal static Class509 class509_0;

		internal bool method_0(Skill skill_0)
		{
			return true;
		}

		internal uint method_1(Skill skill_0)
		{
			return 0u;
		}

		internal string method_2(Skill skill_0)
		{
			return null;
		}

		internal bool method_3(Skill skill_0)
		{
			return true;
		}

		internal uint method_4(Skill skill_0)
		{
			return 0u;
		}

		internal string method_5(Skill skill_0)
		{
			return null;
		}

		internal PlayerSkillWrapper method_6(KeyValuePair<ushort, string> keyValuePair_0)
		{
			return null;
		}

		static Class509()
		{
			Class200.smethod_34();
			Class204.smethod_0();
			Class9 = new Class509();
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class509 smethod_1()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class Class510
	{
		public string string_0;

		private static Class510 class510_0;

		internal bool method_0(SkillName skillName_0)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class510 smethod_1()
		{
			return null;
		}

		static Class510()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private sealed class Class511
	{
		public ushort ushort_0;

		internal static Class511 class511_0;

		internal bool method_0(SkillId skillId_0)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class511 smethod_1()
		{
			return null;
		}

		static Class511()
		{
			Class200.smethod_34();
		}
	}

	private static readonly ILog ilog_0;

	private DreamPoeBot.Loki.Bot.SkillBlacklist skillBlacklist_0;

	internal Button ButtonRefreshSkills;

	internal DataGrid PlayerSkillsDataGrid;

	internal Button ButtonRefreshBlacklist;

	internal DataGrid SkillBlacklistDataGrid;

	internal DataGrid SkillNameBlacklistDataGrid;

	private bool bool_0;

	internal static Gui gui_0;

	public Gui(DreamPoeBot.Loki.Bot.SkillBlacklist owner)
	{
	}

	private DataGridRow method_0(object object_0)
	{
		return null;
	}

	private static T smethod_0<T>(Visual visual_0) where T : Visual
	{
		return null;
	}

	public static DataGridRow GetRow(DataGrid dataGrid, int index)
	{
		return null;
	}

	public static DataGridCell GetCell(DataGrid dataGrid, DataGridRow rowContainer, int column)
	{
		return null;
	}

	private void eyrAyYkJvnx(object sender, RoutedEventArgs e)
	{
	}

	private void method_1(object sender, RoutedEventArgs e)
	{
	}

	private Dictionary<uint, string> method_2()
	{
		return null;
	}

	private Dictionary<uint, string> method_3()
	{
		return null;
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

	static Gui()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_1()
	{
		return true;
	}

	internal static Gui smethod_2()
	{
		return null;
	}
}
