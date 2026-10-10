using System.IO;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Common;

public static class IO
{
	private static readonly ILog ilog_0;

	internal static IO io_0;

	public static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs, bool deleteFile = false)
	{
	}

	private static bool smethod_0(FileInfo fileInfo_0, FileInfo fileInfo_1)
	{
		return true;
	}

	public static void Terminate()
	{
	}

	static IO()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_1()
	{
		return true;
	}

	internal static IO smethod_2()
	{
		return null;
	}
}
