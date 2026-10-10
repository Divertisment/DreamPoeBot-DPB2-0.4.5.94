using System.Collections.Generic;
using DreamPoeBot.Loki.Game.GameData;
using ns0;

namespace DreamPoeBot.Loki.RemoteMemoryObjects;

public class QuestReward : FileInMemory
{
	public List<Dat.NativeQuestStaticReward> list;

	internal static QuestReward questReward_0;

	public QuestReward(Memory m, long address)
	{
	}

	private void method_1()
	{
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static QuestReward smethod_3()
	{
		return null;
	}

	static QuestReward()
	{
		Class200.smethod_34();
	}
}
