using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using DreamPoeBot.Loki.Common;
using DreamPoeBot.Loki.Game.Std;
using log4net;

namespace ns0;

internal static class Class187
{
	private static readonly TimeSpan timeSpan_0;

	private static readonly TimeSpan timeSpan_1;

	private static readonly TimeSpan timeSpan_2;

	private static readonly ILog Log;

	private static readonly object object_0;

	private static long long_0;

	private static long long_1;

	private static long long_2;

	private static CancellationTokenSource cancellationTokenSource_0;

	private static Task task_0;

	private static Class187 class187_0;

	private static void smethod_0(long long_3)
	{
	}

	private static void smethod_1(long long_3, CancellationToken cancellationToken_0)
	{
	}

	internal static void smethod_2(long long_3)
	{
	}

	private static void smethod_3(long long_3, ulong ulong_0, long long_4)
	{
	}

	internal static string smethod_4(Exception exception_0)
	{
		return null;
	}

	private static bool smethod_5(long long_3, long long_4, out byte[] byte_0, out byte[] byte_1)
	{
		return true;
	}

	private static byte[] smethod_6(long long_3)
	{
		return null;
	}

	private static void smethod_7(BinaryWriter binaryWriter_0, NativeVector nativeVector_0)
	{
	}

	private static long smethod_8()
	{
		return 0L;
	}

	private static string smethod_9()
	{
		return null;
	}

	private static bool smethod_10(long long_3)
	{
		return true;
	}

	private static void Clear(byte[] value)
	{
	}

	static Class187()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		timeSpan_0 = TimeSpan.FromSeconds(1.0);
		timeSpan_1 = TimeSpan.FromSeconds(5.0);
		timeSpan_2 = TimeSpan.FromSeconds(2.0);
		Log = Logger.GetLoggerInstanceForType();
		object_0 = new object();
	}

	internal static bool smethod_11()
	{
		return true;
	}

	internal static Class187 smethod_12()
	{
		return null;
	}
}
