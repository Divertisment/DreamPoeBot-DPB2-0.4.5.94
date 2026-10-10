using System;
using DreamPoeBot.Loki.Common;
using DreamPoeBot.Loki.Game.Objects;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Bot;

public static class ItemEvaluator
{
	private static readonly ILog ilog_0;

	private static IItemEvaluator iitemEvaluator_0;

	private static EventHandler<ItemEvaluatorRefreshedEventArgs> eventHandler_0;

	internal static ItemEvaluator itemEvaluator_0;

	public static IItemEvaluator Instance
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static event EventHandler<ItemEvaluatorRefreshedEventArgs> OnRefreshed
	{
		add
		{
		}
		remove
		{
		}
	}

	public static bool Match(Item item, EvaluationType type)
	{
		return true;
	}

	public static void Refresh()
	{
	}

	static ItemEvaluator()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static ItemEvaluator smethod_1()
	{
		return null;
	}
}
