using DreamPoeBot.Loki.Common;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Std;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.RemoteMemoryObjects;

public class ItemMod : RemoteMemoryObject
{
	private static readonly ILog Log;

	private int int_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private StatTypeGGG statTypeGGG_0;

	private static ItemMod itemMod_0;

	public int Value1 => 0;

	public int Value2 => 0;

	public int Value3 => 0;

	public int Value4 => 0;

	public int[] Values => null;

	public string RawName => null;

	public string Name => null;

	public StatTypeGGG StatTypeGGG => (StatTypeGGG)(object)null;

	public string DisplayName => null;

	public int Level => 0;

	internal static int[] smethod_2(Memory memory_0, NativeVector nativeVector_0)
	{
		return null;
	}

	private void method_0()
	{
	}

	public override string ToString()
	{
		return null;
	}

	static ItemMod()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		Log = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_3()
	{
		return true;
	}

	internal static ItemMod smethod_4()
	{
		return null;
	}
}
