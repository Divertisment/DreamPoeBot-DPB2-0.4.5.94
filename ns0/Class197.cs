using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace ns0;

[Serializable]
[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[DebuggerStepThrough]
[DataContract(Name = "d0", Namespace = "http://schemas.datacontract.org/2004/07/")]
internal class Class197 : Class196
{
	[OptionalField]
	private byte[] byte_0;

	[OptionalField]
	private string string_1;

	private static Class197 class197_0;

	[DataMember]
	public byte[] Data
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[DataMember]
	public string Info
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static Class197 smethod_3()
	{
		return null;
	}

	static Class197()
	{
		Class200.smethod_34();
	}
}
