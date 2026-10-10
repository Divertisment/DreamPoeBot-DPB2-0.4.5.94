using System.Collections.Generic;
using DreamPoeBot.Loki.FilesInMemory.Base;
using DreamPoeBot.Loki.RemoteMemoryObjects;
using ns0;

namespace DreamPoeBot.Loki.FilesInMemory;

public class MonsterVarieties : UniversalFileWrapper<MonsterVariety>
{
	private readonly Dictionary<string, MonsterVariety> dictionary_1;

	private static MonsterVarieties monsterVarieties_0;

	public MonsterVarieties(Memory m, long address)
	{
	}

	public MonsterVariety TranslateFromMetadata(string path)
	{
		return null;
	}

	protected override void EntryAdded(long addr, MonsterVariety entry)
	{
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static MonsterVarieties smethod_3()
	{
		return null;
	}

	static MonsterVarieties()
	{
		Class200.smethod_34();
	}
}
