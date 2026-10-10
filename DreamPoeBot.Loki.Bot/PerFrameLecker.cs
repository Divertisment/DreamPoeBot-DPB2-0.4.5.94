using System;
using ns0;

namespace DreamPoeBot.Loki.Bot;

public class PerFrameLecker : IDisposable
{
	public uint PreviousFrameCount;

	internal static PerFrameLecker perFrameLecker_0;

	public bool CanRelease => true;

	public void Dispose()
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static PerFrameLecker smethod_1()
	{
		return null;
	}

	static PerFrameLecker()
	{
		Class200.smethod_34();
	}
}
