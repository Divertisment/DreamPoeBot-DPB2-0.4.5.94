using System.Collections.Generic;
using DreamPoeBot.Loki.Common;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Bot;

public static class ContentManager
{
	private static readonly ILog ilog_0;

	private static readonly List<IContent> list_0;

	private static ContentManager contentManager_0;

	public static IReadOnlyList<IContent> Contents => null;

	internal static void smethod_0(IReadOnlyList<ThirdPartyInstance> ireadOnlyList_0, List<string> list_1)
	{
	}

	static ContentManager()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
		list_0 = new List<IContent>();
	}

	internal static bool smethod_1()
	{
		return true;
	}

	internal static ContentManager smethod_2()
	{
		return null;
	}
}
