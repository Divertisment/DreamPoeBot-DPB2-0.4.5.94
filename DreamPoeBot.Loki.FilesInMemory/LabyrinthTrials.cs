using DreamPoeBot.Loki.FilesInMemory.Base;
using DreamPoeBot.Loki.Game.GameData;
using ns0;

namespace DreamPoeBot.Loki.FilesInMemory;

public class LabyrinthTrials : UniversalFileWrapper<LabyrinthTrial>
{
	public static string[] LabyrinthTrialAreaIds;

	internal static LabyrinthTrials labyrinthTrials_0;

	public LabyrinthTrials(Memory m, long address)
	{
	}

	public LabyrinthTrial GetLabyrinthTrialByAreaId(string id)
	{
		return null;
	}

	public LabyrinthTrial GetLabyrinthTrialById(int index)
	{
		return null;
	}

	public LabyrinthTrial GetLabyrinthTrialByArea(DatWorldAreaWrapper area)
	{
		return null;
	}

	static LabyrinthTrials()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		LabyrinthTrialAreaIds = new string[18]
		{
			Class200.smethod_20(501994),
			Class200.smethod_20(502012),
			Class200.smethod_20(502030),
			Class200.smethod_20(502048),
			Class200.smethod_20(502066),
			Class200.smethod_20(502080),
			Class200.smethod_20(502096),
			Class200.smethod_20(502114),
			Class200.smethod_20(502128),
			Class200.smethod_20(502146),
			Class200.smethod_20(502160),
			Class200.smethod_20(502174),
			Class200.smethod_20(502190),
			Class200.smethod_20(502256),
			Class200.smethod_20(502326),
			Class200.smethod_20(502402),
			Class200.smethod_20(502468),
			Class200.smethod_20(502536)
		};
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static LabyrinthTrials smethod_3()
	{
		return null;
	}
}
