using System.Runtime.CompilerServices;
using ns0;

namespace DreamPoeBot.Loki.Bot;

public static class Explorer
{
	public delegate IExplorer CreateExplorerDelegate();

	public delegate IExplorer GetExplorerDelegate(params dynamic[] user);

	[CompilerGenerated]
	private static CreateExplorerDelegate createExplorerDelegate_0;

	[CompilerGenerated]
	private static GetExplorerDelegate getExplorerDelegate_0;

	private static Explorer explorer_0;

	public static CreateExplorerDelegate CreateDelegate
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

	public static GetExplorerDelegate CurrentDelegate
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

	public static IExplorer GetCurrent(params dynamic[] user)
	{
		return null;
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static Explorer smethod_1()
	{
		return null;
	}

	static Explorer()
	{
		Class200.smethod_34();
	}
}
