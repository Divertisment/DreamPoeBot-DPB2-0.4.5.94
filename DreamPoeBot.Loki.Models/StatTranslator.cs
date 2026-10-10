using System.Collections.Generic;
using DreamPoeBot.Loki.Models.Enums;
using DreamPoeBot.Loki.RemoteMemoryObjects;
using ns0;

namespace DreamPoeBot.Loki.Models;

public class StatTranslator
{
	private delegate void Delegate1(ItemStats stats, ItemMod m);

	private readonly Dictionary<string, Delegate1> dictionary_0;

	private static StatTranslator statTranslator_0;

	public void Translate(ItemStats stats, ItemMod m)
	{
	}

	private Delegate1 method_0(ItemStatEnum itemStatEnum_0)
	{
		return null;
	}

	private Delegate1 method_1(ItemStatEnum itemStatEnum_0)
	{
		return null;
	}

	private Delegate1 method_2(ItemStatEnum itemStatEnum_0, ItemStatEnum itemStatEnum_1)
	{
		return null;
	}

	private Delegate1 method_3(params ItemStatEnum[] stats)
	{
		return null;
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static StatTranslator smethod_1()
	{
		return null;
	}

	static StatTranslator()
	{
		Class200.smethod_34();
	}
}
