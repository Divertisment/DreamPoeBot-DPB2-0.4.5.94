using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Loki.Game.Std;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct NativeVector
{
	public long First;

	public long Last;

	public long End;

	internal static object object_0;

	public bool IsValid => true;

	public long DataSize => 0L;

	public override string ToString()
	{
		return null;
	}

	public int GetElementCount(uint elementSize)
	{
		return 0;
	}

	public bool CanContain(uint elementSize, int maxReasonableCount = 10000)
	{
		return true;
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static object smethod_1()
	{
		return null;
	}

	static NativeVector()
	{
		Class200.smethod_34();
	}
}
