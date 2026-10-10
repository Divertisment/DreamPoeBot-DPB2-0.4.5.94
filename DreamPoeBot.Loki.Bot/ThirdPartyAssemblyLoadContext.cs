using System.Reflection;
using System.Runtime.Loader;
using ns0;

namespace DreamPoeBot.Loki.Bot;

public class ThirdPartyAssemblyLoadContext : AssemblyLoadContext
{
	private readonly string string_0;

	private readonly bool bool_0;

	private readonly AssemblyDependencyResolver assemblyDependencyResolver_0;

	private int int_0;

	internal static ThirdPartyAssemblyLoadContext thirdPartyAssemblyLoadContext_0;

	public ThirdPartyAssemblyLoadContext(string pluginAssemblyLocation, bool loadFromStream)
	{
	}

	private Assembly method_0(AssemblyLoadContext assemblyLoadContext_0, AssemblyName assemblyName_0)
	{
		return null;
	}

	private nint method_1(Assembly assembly_0, string string_1)
	{
		return (nint)(object)null;
	}

	public void UnloadOnce()
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static ThirdPartyAssemblyLoadContext smethod_1()
	{
		return null;
	}

	static ThirdPartyAssemblyLoadContext()
	{
		Class200.smethod_34();
	}
}
