using System.Threading.Tasks;

namespace DreamPoeBot.Loki.Bot;

public interface ITask : IMessageHandler, IStartStopEvents, ITickEvents, IAuthored, ILogicProvider
{
	Task<bool> Run();
}
