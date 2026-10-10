using System.CodeDom.Compiler;
using System.ServiceModel;

namespace ns0;

[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[ServiceContract(ConfigurationName = "SR.IA")]
internal interface Interface12
{
	[ServiceKnownType(typeof(Class199))]
	[ServiceKnownType(typeof(string[]))]
	[ServiceKnownType(typeof(Class197))]
	[ServiceKnownType(typeof(object[]))]
	[OperationContract(Action = "http://tempuri.org/IA/Do", ReplyAction = "http://tempuri.org/IA/DoResponse")]
	[ServiceKnownType(typeof(Class196))]
	Class197 Do(byte b, object[] args);
}
