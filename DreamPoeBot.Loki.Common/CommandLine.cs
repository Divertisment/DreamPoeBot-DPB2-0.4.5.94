using System;
using System.Runtime.CompilerServices;
using ns0;

namespace DreamPoeBot.Loki.Common;

public static class CommandLine
{
	[CompilerGenerated]
	private static Arguments arguments_0;

	internal static CommandLine commandLine_0;

	public static Arguments Arguments
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	static CommandLine()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		arguments_0 = new Arguments(Environment.GetCommandLineArgs());
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static CommandLine smethod_1()
	{
		return null;
	}
}
