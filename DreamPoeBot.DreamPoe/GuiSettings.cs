using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Controls;
using DreamPoeBot.Loki;
using DreamPoeBot.Loki.Common;
using ns0;

namespace DreamPoeBot.DreamPoe;

public class GuiSettings : JsonSettings
{
	private static GuiSettings guiSettings_0;

	private string string_1;

	private string string_2;

	private string string_3;

	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	private int int_4;

	private int int_5;

	private int int_6;

	private int int_7;

	private string string_4;

	private string string_5;

	private string string_6;

	private string string_7;

	private List<string> list_0;

	private ObservableCollection<StringEntry> observableCollection_0;

	private ObservableCollection<StringEntry> observableCollection_1;

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

	private bool bool_4;

	private static GuiSettings guiSettings_1;

	public static GuiSettings Instance => null;

	[DefaultValue(true)]
	public bool CompileAsynchronously
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[DefaultValue(false)]
	public bool ExitOnLoadErrors
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[DefaultValue(false)]
	public bool ExitOnCompileErrors
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[DefaultValue(false)]
	public bool NoHideOnMinimize
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[DefaultValue(0)]
	public int WindowX
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[DefaultValue(0)]
	public int WindowY
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[DefaultValue(627)]
	public int WindowWidth
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[DefaultValue(477)]
	public int WindowHeight
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[DefaultValue(0)]
	public int SettingsWindowX
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[DefaultValue(0)]
	public int SettingsWindowY
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[DefaultValue(627)]
	public int SettingsWindowWidth
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[DefaultValue(477)]
	public int SettingsWindowHeight
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[DefaultValue("124*")]
	public string TopRowDefinitionHeight
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[DefaultValue("292*")]
	public string BottomRowDefinitionHeight
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[DefaultValue("Auto")]
	public string SplitterRowDefinitionHeight
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[DefaultValue("")]
	public string LastBot
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[DefaultValue("")]
	public string LastRoutine
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[DefaultValue("")]
	public string LastMover
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[DefaultValue("Full")]
	public string LogLevel
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<string> EnabledPlugins
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ObservableCollection<StringEntry> ContentOrder
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ObservableCollection<StringEntry> DisabledContent
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public void LoadRowDefinitions(RowDefinition topRowDefinition, RowDefinition splitterRowDefinition, RowDefinition bottomRowDefinition)
	{
	}

	public void SaveRowDefinitions(RowDefinition topRowDefinition, RowDefinition splitterRowDefinition, RowDefinition bottomRowDefinition)
	{
	}

	internal static bool smethod_5()
	{
		return true;
	}

	internal static GuiSettings smethod_6()
	{
		return null;
	}

	static GuiSettings()
	{
		Class200.smethod_34();
	}
}
