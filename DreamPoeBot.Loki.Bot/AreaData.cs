using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ns0;

namespace DreamPoeBot.Loki.Bot;

public abstract class AreaData
{
	[CompilerGenerated]
	private readonly uint uint_0;

	private readonly Stopwatch stopwatch_0;

	private readonly Stopwatch stopwatch_1;

	internal static AreaData areaData_0;

	public uint AreaHash
	{
		[CompilerGenerated]
		get
		{
			return 0u;
		}
	}

	public TimeSpan Lifetime => (TimeSpan)(object)null;

	public TimeSpan Activity => (TimeSpan)(object)null;

	internal void method_0()
	{
	}

	internal void method_1()
	{
	}

	internal void method_2()
	{
	}

	internal void method_3()
	{
	}

	internal void method_4()
	{
	}

	protected AreaData(uint hash)
	{
	}

	public abstract void Start(bool isActive);

	public abstract void Tick(bool isActive);

	public abstract void Stop(bool isActive);

	internal static bool smethod_0()
	{
		return true;
	}

	internal static AreaData smethod_1()
	{
		return null;
	}

	static AreaData()
	{
		Class200.smethod_34();
	}
}
