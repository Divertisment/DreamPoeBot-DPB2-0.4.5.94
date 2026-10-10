using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Loki.Game.Std;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct NativeList
{
	public readonly long Head;

	public readonly uint Size;

	public readonly int unusedInt0;

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

	static NativeList()
	{
		Class200.smethod_34();
	}
}
