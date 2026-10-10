using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Models;
using ns0;

namespace DreamPoeBot.Loki.FilesInMemory;

public class QuestFlagsDat : FileInMemory<QuestFlags>
{
	internal static QuestFlagsDat questFlagsDat_0;

	public QuestFlagsDat(Memory m, long address)
	{
	}

	private protected override long vmethod_0(QuestFlags record)
	{
		return 0L;
	}

	[CompilerGenerated]
	private QuestFlags method_3(QuestFlags.Struct54 struct54_0, long long_6, int int_2)
	{
		return null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static QuestFlagsDat smethod_5()
	{
		return null;
	}

	static QuestFlagsDat()
	{
		Class200.smethod_34();
	}
}
