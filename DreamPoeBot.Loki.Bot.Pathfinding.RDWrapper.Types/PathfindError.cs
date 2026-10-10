namespace DreamPoeBot.Loki.Bot.Pathfinding.RDWrapper.Types;

public enum PathfindError
{
	None,
	StartNotNavigable,
	EndNotNavigable,
	StartAndEndAreSame,
	AreaNotGenerated,
	NoPathAvailable
}
