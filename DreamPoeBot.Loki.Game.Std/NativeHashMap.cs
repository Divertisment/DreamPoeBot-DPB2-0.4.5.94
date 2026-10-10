using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Loki.Game.Std;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct NativeHashMap
{
	public readonly int Proxy;

	public readonly int unusedInt0;

	public readonly NativeList List;

	public readonly NativeVector Vector;

	public readonly int Mask;

	public readonly int unusedInt1;

	public readonly int MaxIdx;

	public readonly int unusedInt2;

	private static object object_0;

	public override string ToString()
	{
		return null;
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static object smethod_1()
	{
		return null;
	}

	static NativeHashMap()
	{
		Class200.smethod_34();
	}
}
