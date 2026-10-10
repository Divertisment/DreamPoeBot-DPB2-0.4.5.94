namespace DreamPoeBot.Loki.Bot;

public interface IPlugin : IConfigurable, IMessageHandler, IAuthored, IBase, IEnableable, ILogicProvider
{
}
