using System;
using ns0;

namespace DreamPoeBot.Loki.Controllers;

public class AreaLoadingState : GameState
{
	private static AreaLoadingState areaLoadingState_0;

	public bool IsLoading => true;

	[Obsolete("Does not seem to be ingame anymore")]
	public string AreaName => null;

	[Obsolete("Does not seem to be ingame anymore")]
	public uint TotalLoadingScreenTimeMs => 0u;

	[Obsolete("Does not seem to be ingame anymore")]
	public float TotalLoadingScreenTimeMsFloat => 0f;

	public override string ToString()
	{
		return null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static AreaLoadingState smethod_5()
	{
		return null;
	}

	static AreaLoadingState()
	{
		Class200.smethod_34();
	}
}
