using DreamPoeBot.Common;
using DreamPoeBot.Loki.Bot.Pathfinding.RDWrapper.Types;

namespace DreamPoeBot.Loki.Bot;

public interface IPlayerMover : IConfigurable, IStartStopEvents, ITickEvents, IBase, IAuthored, ILogicProvider, IMessageHandler
{
	PathResult? CurrentCommand { get; }

	bool MoveTowards(Vector2i position, params dynamic[] user);
}
