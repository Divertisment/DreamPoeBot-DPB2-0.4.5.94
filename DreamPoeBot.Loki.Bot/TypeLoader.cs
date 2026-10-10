using System;
using System.Collections.Generic;
using System.Reflection;
using DreamPoeBot.Loki.Common;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Bot;

public class TypeLoader<T> : List<T>
{
	private static readonly ILog ilog_0;

	private readonly Assembly assembly_0;

	private Func<object[]> func_0;

	internal static object object_0;

	internal object[] method_0()
	{
		return null;
	}

	public TypeLoader(Assembly asm = null, Func<object[]> constructorArguments = null)
	{
	}

	private void method_1(params Assembly[] assembly_1)
	{
	}

	public void Reload()
	{
	}

	static TypeLoader()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static object smethod_1()
	{
		return null;
	}
}
