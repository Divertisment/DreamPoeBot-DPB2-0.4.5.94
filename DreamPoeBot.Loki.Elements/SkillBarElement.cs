using System.Collections.Generic;
using DreamPoeBot.Loki.Common;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Elements;

public class SkillBarElement : Element
{
	private static readonly ILog ilog_1;

	private static readonly Dictionary<string, long> dictionary_0;

	internal static SkillBarElement skillBarElement_0;

	public long TotalSkills => 0L;

	public SkillElement this[int k] => null;

	public Dictionary<Element, KeyValuePair<long, ushort>> SkillsDictionary => null;

	public Dictionary<Element, KeyValuePair<long, ushort>> ControlSkillsDictionary => null;

	public List<Element> SkillsElements => null;

	public List<Element> ControlSkillsElements => null;

	private List<Element> method_29()
	{
		return null;
	}

	internal static void smethod_11(string string_0, long long_5, string string_1)
	{
	}

	internal static bool smethod_12(Element element_2, out long long_5, out uint uint_0)
	{
		return true;
	}

	internal static bool smethod_13(Element element_2, out bool bool_0)
	{
		return true;
	}

	internal static bool smethod_14(Element element_2)
	{
		return true;
	}

	private static Dictionary<Element, KeyValuePair<long, ushort>> smethod_15(List<Element> list_0)
	{
		return null;
	}

	static SkillBarElement()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_1 = Logger.GetLoggerInstanceForType();
		dictionary_0 = new Dictionary<string, long>();
	}

	internal static bool smethod_16()
	{
		return true;
	}

	internal static SkillBarElement smethod_17()
	{
		return null;
	}
}
