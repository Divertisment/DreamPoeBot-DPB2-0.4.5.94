using System;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using DreamPoeBot.Loki.Common;
using DreamUpdater.Core;
using log4net;

namespace ns0;

internal static class Class166
{
	private enum Enum18
	{
		Observe,
		Download,
		Apply
	}

	private static readonly Version version_0;

	private static readonly TimeSpan timeSpan_0;

	private static readonly TimeSpan timeSpan_1;

	private static readonly TimeSpan timeSpan_2;

	private static readonly UTF8Encoding utf8Encoding_0;

	private static readonly ILog Log;

	private static int int_0;

	private static int int_1;

	internal static Class166 class166_0;

	internal static bool IsEnabled => true;

	[SpecialName]
	internal static bool smethod_0()
	{
		return true;
	}

	[SpecialName]
	internal static bool smethod_1()
	{
		return true;
	}

	[SpecialName]
	private static bool smethod_2()
	{
		return true;
	}

	internal static bool smethod_3()
	{
		return true;
	}

	internal static void smethod_4(Class34 class34_0)
	{
	}

	private static void smethod_5(Class34 class34_0, Enum18 enum18_0)
	{
	}

	private static bool smethod_6(string string_0, ReleaseManifest releaseManifest_0, Class167 class167_0)
	{
		return true;
	}

	private static Class194 smethod_7(Class34 class34_0, SignedManifestVerifier signedManifestVerifier_0, Version version_1, Class194 class194_0, ReleaseManifest releaseManifest_0, string string_0, IProgress<long> iprogress_0, HttpClient httpClient_0, CancellationToken cancellationToken_0)
	{
		return null;
	}

	private static bool smethod_8(Exception exception_0, CancellationToken cancellationToken_0)
	{
		return true;
	}

	private static string smethod_9(Exception exception_0)
	{
		return null;
	}

	private static void smethod_10(ReleaseManifest releaseManifest_0, ReleaseManifest releaseManifest_1)
	{
	}

	private static void smethod_11(Class194 class194_0, ReleaseManifest releaseManifest_0)
	{
	}

	private static void smethod_12(string string_0, string string_1, string string_2, string string_3, string string_4, ReleaseManifest releaseManifest_0)
	{
	}

	private static string smethod_13(string string_0, string string_1)
	{
		return null;
	}

	private static void smethod_14()
	{
	}

	private static void smethod_15()
	{
	}

	private static void smethod_16(RollbackReceipt rollbackReceipt_0)
	{
	}

	private static void smethod_17(string string_0, string string_1)
	{
	}

	private static string smethod_18()
	{
		return null;
	}

	private static string smethod_19(string string_0)
	{
		return null;
	}

	private static string smethod_20()
	{
		return null;
	}

	private static bool smethod_21()
	{
		return true;
	}

	private static bool smethod_22(string string_0)
	{
		return true;
	}

	private static void smethod_23(string string_0)
	{
	}

	private static void smethod_24(string string_0)
	{
	}

	private static string smethod_25(string string_0, string string_1)
	{
		return null;
	}

	private static void smethod_26(string string_0, string string_1)
	{
	}

	private static void smethod_27(string string_0, string string_1)
	{
	}

	private static bool smethod_28(out Enum18 enum18_0)
	{
		return true;
	}

	static Class166()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		version_0 = new Version(1, 0, 0, 0);
		timeSpan_0 = TimeSpan.FromSeconds(75.0);
		timeSpan_1 = TimeSpan.FromSeconds(2.0);
		timeSpan_2 = TimeSpan.FromMinutes(10.0);
		utf8Encoding_0 = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);
		Log = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_29()
	{
		return true;
	}

	internal static Class166 smethod_30()
	{
		return null;
	}
}
