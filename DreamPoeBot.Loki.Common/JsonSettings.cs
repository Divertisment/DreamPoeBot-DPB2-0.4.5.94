using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Common.MVVM;
using log4net;
using Newtonsoft.Json;
using ns0;

namespace DreamPoeBot.Loki.Common;

public class JsonSettings : NotificationObject
{
	[CompilerGenerated]
	private string string_0;

	private static readonly ILog ilog_0;

	private readonly bool bool_0;

	private static JsonSettings jsonSettings_0;

	[JsonIgnore]
	public string FilePath
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

	public static string AssemblyPath => null;

	public static string SettingsPath => null;

	public bool HasProperty(string name)
	{
		return true;
	}

	public object GetProperty(string name)
	{
		return null;
	}

	public void SetProperty(string name, object value)
	{
	}

	public JsonSettings(string path)
	{
	}

	public void Save()
	{
	}

	protected T GetDefaultValue<T>(Expression<Func<T>> exp)
	{
		return (T)null;
	}

	public virtual bool Validate(out List<string> errors)
	{
		return true;
	}

	public void SaveAs(string file)
	{
	}

	protected void LoadFrom(string file)
	{
	}

	public static string GetSettingsFilePath(params string[] subPathParts)
	{
		return null;
	}

	static JsonSettings()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_3()
	{
		return true;
	}

	internal static JsonSettings smethod_4()
	{
		return null;
	}
}
