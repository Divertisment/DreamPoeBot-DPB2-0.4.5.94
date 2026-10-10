using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Loader;
using System.Text;
using DreamPoeBot.Loki.Common;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Bot;

public static class ThirdPartyLoader
{
	internal enum Enum14
	{
		Zip
	}

	internal class Class140
	{
		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private Enum14 enum14_0;

		[CompilerGenerated]
		private string string_1;

		[CompilerGenerated]
		private string string_2;

		[CompilerGenerated]
		private string string_3;

		[CompilerGenerated]
		private bool bool_0;

		[CompilerGenerated]
		private List<string> list_0;

		[CompilerGenerated]
		private List<string> list_1;

		[CompilerGenerated]
		private List<string> list_2;

		internal static Class140 class140_0;

		public string Name
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[SpecialName]
		[CompilerGenerated]
		public Enum14 method_0()
		{
			return (Enum14)(object)null;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_1(Enum14 enum14_1)
		{
		}

		[SpecialName]
		[CompilerGenerated]
		public string method_2()
		{
			return null;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_3(string string_4)
		{
		}

		[SpecialName]
		[CompilerGenerated]
		public string method_4()
		{
			return null;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_5(string string_4)
		{
		}

		[SpecialName]
		[CompilerGenerated]
		public string method_6()
		{
			return null;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_7(string string_4)
		{
		}

		[SpecialName]
		[CompilerGenerated]
		public bool method_8()
		{
			return true;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_9(bool bool_1)
		{
		}

		[SpecialName]
		[CompilerGenerated]
		public List<string> method_10()
		{
			return null;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_11(List<string> list_3)
		{
		}

		[SpecialName]
		[CompilerGenerated]
		public List<string> method_12()
		{
			return null;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_13(List<string> list_3)
		{
		}

		[SpecialName]
		[CompilerGenerated]
		public List<string> method_14()
		{
			return null;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_15(List<string> list_3)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class140 smethod_1()
		{
			return null;
		}

		static Class140()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		public AssemblyDependencyResolver assemblyDependencyResolver_0;

		private static _003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_0_0;

		internal Assembly? method_0(AssemblyLoadContext context, AssemblyName name)
		{
			return null;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static _003C_003Ec__DisplayClass1_0 smethod_1()
		{
			return null;
		}

		static _003C_003Ec__DisplayClass1_0()
		{
			Class200.smethod_34();
		}
	}

	private static List<string> list_0;

	private static readonly ILog ilog_0;

	private static readonly Dictionary<string, ThirdPartyInstance> dictionary_0;

	private static Dictionary<string, Class140> dictionary_1;

	private static readonly List<CompilerErrorCollection> list_1;

	private static readonly List<Exception> list_2;

	private static readonly List<string> list_3;

	private static readonly List<string> list_4;

	internal static ThirdPartyLoader thirdPartyLoader_0;

	public static string PluginFolderPath => null;

	public static string ThirdPartyPath => null;

	public static string RootPath => null;

	public static string ProfileConfigPath => null;

	public static IReadOnlyList<string> CleanupPaths => null;

	public static IReadOnlyList<CompilerErrorCollection> CompileErrors => null;

	public static IReadOnlyList<Exception> CompileExceptions => null;

	public static IReadOnlyList<string> LoadErrors => null;

	public static IReadOnlyList<ThirdPartyInstance> Instances => null;

	static ThirdPartyLoader()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		list_0 = new List<string>();
		ilog_0 = Logger.GetLoggerInstanceForName(Class200.smethod_20(2911154));
		dictionary_0 = new Dictionary<string, ThirdPartyInstance>();
		list_1 = new List<CompilerErrorCollection>();
		list_2 = new List<Exception>();
		list_3 = new List<string>();
		list_4 = new List<string>();
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals1.assemblyDependencyResolver_0 = new AssemblyDependencyResolver(null);
		AssemblyLoadContext.Default.Resolving += (AssemblyLoadContext context, AssemblyName name) => (Assembly?)null;
	}

	[SpecialName]
	private static string smethod_0()
	{
		return null;
	}

	public static ThirdPartyInstance GetInstance(string name)
	{
		return null;
	}

	private static string smethod_1(string string_0)
	{
		return null;
	}

	private static void smethod_2(string string_0, string string_1)
	{
	}

	private static void smethod_3(string string_0, string string_1)
	{
	}

	public static void RedirectAssembly()
	{
	}

	internal static bool smethod_4(KeyValuePair<string, byte[]> keyValuePair_0)
	{
		return true;
	}

	internal static bool smethod_5(Dictionary<string, Class140> dictionary_2, string string_0)
	{
		return true;
	}

	private static void smethod_6(string string_0, Dictionary<string, Class140> dictionary_2, List<string> list_5)
	{
	}

	public static T Deserialize<T>(byte[] data, Encoding encoding = null) where T : class
	{
		return null;
	}

	private static void smethod_7(string string_0, Dictionary<string, Class140> dictionary_2, List<string> list_5)
	{
	}

	internal static void smethod_8(List<string> list_5, bool bool_0)
	{
	}

	internal static bool smethod_9()
	{
		return true;
	}

	internal static ThirdPartyLoader smethod_10()
	{
		return null;
	}
}
