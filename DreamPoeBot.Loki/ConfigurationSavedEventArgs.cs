using System;
using System.Runtime.CompilerServices;
using ns0;

namespace DreamPoeBot.Loki;

public class ConfigurationSavedEventArgs : EventArgs
{
	[CompilerGenerated]
	private Configuration configuration_0;

	private static ConfigurationSavedEventArgs configurationSavedEventArgs_0;

	public Configuration Configuration
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

	internal ConfigurationSavedEventArgs(Configuration configuration)
	{
	}

	internal ConfigurationSavedEventArgs()
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static ConfigurationSavedEventArgs smethod_1()
	{
		return null;
	}

	static ConfigurationSavedEventArgs()
	{
		Class200.smethod_34();
	}
}
