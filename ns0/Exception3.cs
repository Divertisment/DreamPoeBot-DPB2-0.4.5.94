using System;
using System.Net;
using System.Runtime.CompilerServices;

namespace ns0;

internal sealed class Exception3 : Exception
{
	[CompilerGenerated]
	private readonly HttpStatusCode httpStatusCode_0;

	[CompilerGenerated]
	private readonly string string_0;

	internal static Exception3 exception3_0;

	internal Exception3(HttpStatusCode httpStatusCode_1, string string_1)
	{
	}

	[SpecialName]
	[CompilerGenerated]
	internal HttpStatusCode method_0()
	{
		return (HttpStatusCode)(object)null;
	}

	[SpecialName]
	[CompilerGenerated]
	internal string method_1()
	{
		return null;
	}

	[SpecialName]
	internal bool method_2()
	{
		return true;
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static Exception3 smethod_1()
	{
		return null;
	}

	static Exception3()
	{
		Class200.smethod_34();
	}
}
