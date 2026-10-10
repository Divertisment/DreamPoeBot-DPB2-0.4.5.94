using ns0;

namespace DreamPoeBot.Loki.RemoteMemoryObjects;

public class QuestState : RemoteMemoryObject
{
	private static QuestState questState_0;

	public long QuestPtr => 0L;

	public Quest Quest => null;

	public int QuestStateId => 0;

	public int TestOffset => 0;

	public string QuestStateText => null;

	public string QuestProgressText => null;

	public override string ToString()
	{
		return null;
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static QuestState smethod_3()
	{
		return null;
	}

	static QuestState()
	{
		Class200.smethod_34();
	}
}
