namespace DreamPoeBot.Loki.Bot;

public interface IRoutine : IConfigurable, IMessageHandler, IStartStopEvents, ITickEvents, IAuthored, IBase, ILogicProvider
{
}
