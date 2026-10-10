namespace DreamPoeBot.Loki.Bot;

public interface IBot : IConfigurable, IMessageHandler, IStartStopEvents, ITickEvents, IAuthored, IBase, ILogicProvider
{
}
