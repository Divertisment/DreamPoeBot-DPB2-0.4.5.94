using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Common;
using DreamPoeBot.Loki.Game.Objects;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Bot;

public class DefaultItemEvaluator : IItemEvaluator
{
	[CompilerGenerated]
	private static readonly DefaultItemEvaluator defaultItemEvaluator_0;

	private static readonly ILog ilog_0;

	private static DefaultItemEvaluator defaultItemEvaluator_1;

	public string Name => null;

	public static DefaultItemEvaluator Instance
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public bool Match(Item item, EvaluationType type)
	{
		return true;
	}

	static DefaultItemEvaluator()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		defaultItemEvaluator_0 = new DefaultItemEvaluator();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static DefaultItemEvaluator smethod_1()
	{
		return null;
	}
}
