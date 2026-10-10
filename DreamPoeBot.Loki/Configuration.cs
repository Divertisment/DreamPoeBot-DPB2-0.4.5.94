using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Common;
using log4net;
using ns0;

namespace DreamPoeBot.Loki;

public class Configuration
{
	[CompilerGenerated]
	private string string_0;

	private static readonly ConfigurationSavedEventArgs configurationSavedEventArgs_0;

	private static EventHandler<ConfigurationSavedEventArgs> eventHandler_0;

	private static readonly ILog ilog_0;

	private static Configuration configuration_0;

	private readonly List<JsonSettings> list_0;

	internal static Configuration configuration_1;

	public static Configuration Instance => null;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		internal set
		{
		}
	}

	public string Path => null;

	public List<JsonSettings> Settings => null;

	public static event EventHandler<ConfigurationSavedEventArgs> OnSaveAll
	{
		add
		{
		}
		remove
		{
		}
	}

	public void AddSettings(JsonSettings settings)
	{
	}

	public void RemoveSettings(JsonSettings settings)
	{
	}

	public void SaveAll()
	{
	}

	static Configuration()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		configurationSavedEventArgs_0 = new ConfigurationSavedEventArgs();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static Configuration smethod_1()
	{
		return null;
	}
}
