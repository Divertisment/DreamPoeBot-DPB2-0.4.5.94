using System;
using System.Collections.Concurrent;
using System.IO;
using DreamPoeBot.Loki;
using DreamPoeBot.Loki.Game.Utilities;
using log4net;

namespace ns0;

internal static class Class120
{
	private static readonly ILog Log;

	private static readonly ConcurrentDictionary<string, long> concurrentDictionary_0;

	private static Class120 class120_0;

	internal static T smethod_0<T>(PerFrameCachedValue<T> perFrameCachedValue_0)
	{
		return (T)null;
	}

	internal static T smethod_1<T>(string string_0, Func<T> func_0)
	{
		return (T)null;
	}

	internal static T smethod_2<T>(string string_0, Func<T> func_0)
	{
		return (T)null;
	}

	private static T smethod_3<T>(string string_0, Func<T> func_0, int int_0)
	{
		return (T)null;
	}

	internal static InvalidDataException smethod_4(string string_0)
	{
		return null;
	}

	internal static T Structure<T>(Memory memory, long address) where T : unmanaged
	{
		return (T)null;
	}

	internal static byte[] smethod_5(Memory memory_0, long long_0, int int_0)
	{
		return null;
	}

	private unsafe static void smethod_6(Memory memory_0, long long_0, byte* pByte_0, int int_0)
	{
	}

	static Class120()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		Log = LogManager.GetLogger(typeof(Class120));
		concurrentDictionary_0 = new ConcurrentDictionary<string, long>();
	}

	internal static bool smethod_7()
	{
		return true;
	}

	internal static Class120 smethod_8()
	{
		return null;
	}
}
