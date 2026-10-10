using System;
using System.Net;
using System.Runtime.CompilerServices;
using ns0;

namespace DreamPoeBot.Structures.CustomAClient;

public class CustomWebClient : WebClient
{
	[CompilerGenerated]
	private int gfaobhvung;

	internal static CustomWebClient customWebClient_0;

	public int Timeout
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public CustomWebClient()
	{
	}

	public CustomWebClient(int timeout)
	{
	}

	protected override WebRequest GetWebRequest(Uri address)
	{
		return null;
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static CustomWebClient smethod_1()
	{
		return null;
	}

	static CustomWebClient()
	{
		Class200.smethod_34();
	}
}
