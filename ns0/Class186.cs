using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ns0;

internal sealed class Class186
{
	internal static readonly Class186 Empty;

	[CompilerGenerated]
	private readonly Class185 class185_0;

	[CompilerGenerated]
	private readonly IReadOnlyList<Class185> ireadOnlyList_0;

	[CompilerGenerated]
	private readonly bool bool_0;

	[CompilerGenerated]
	private readonly Task<IReadOnlyList<Class185>> task_0;

	private static Class186 class186_0;

	internal Class186(Class185 class185_1, IReadOnlyList<Class185> ireadOnlyList_1, bool bool_1, Task<IReadOnlyList<Class185>> task_1)
	{
	}

	[SpecialName]
	[CompilerGenerated]
	internal Class185 method_0()
	{
		return null;
	}

	[SpecialName]
	[CompilerGenerated]
	internal IReadOnlyList<Class185> method_1()
	{
		return null;
	}

	[SpecialName]
	[CompilerGenerated]
	internal bool method_2()
	{
		return true;
	}

	[SpecialName]
	[CompilerGenerated]
	internal Task<IReadOnlyList<Class185>> method_3()
	{
		return null;
	}

	static Class186()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		Empty = new Class186(null, Array.Empty<Class185>(), bool_1: false, Task.FromResult((IReadOnlyList<Class185>)Array.Empty<Class185>()));
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static Class186 smethod_1()
	{
		return null;
	}
}
