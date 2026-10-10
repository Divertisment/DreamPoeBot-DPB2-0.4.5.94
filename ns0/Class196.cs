using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace ns0;

[Serializable]
[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[KnownType(typeof(Class197))]
[DataContract(Name = "r0", Namespace = "http://schemas.datacontract.org/2004/07/")]
[DebuggerStepThrough]
internal class Class196 : INotifyPropertyChanged, IExtensibleDataObject
{
	[NonSerialized]
	private ExtensionDataObject extensionDataObject_0;

	[OptionalField]
	private string string_0;

	[OptionalField]
	private bool bool_0;

	internal static Class196 class196_0;

	[Browsable(false)]
	public ExtensionDataObject ExtensionData
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
	public string Body
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
	public bool Success
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	protected void method_0(string string_1)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static Class196 smethod_1()
	{
		return null;
	}

	static Class196()
	{
		Class200.smethod_34();
	}
}
