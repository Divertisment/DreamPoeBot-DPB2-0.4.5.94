using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class Quality : Component
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct243
	{
		public Struct14 struct14_0;

		public long long_0;

		public int int_0;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct244
	{
		public long xGclzYoffcd;

		public long long_0;

		public int int_0;
	}

	private PerFrameCachedValue<Struct243> perFrameCachedValue_0;

	private PerFrameCachedValue<Struct244> perFrameCachedValue_1;

	internal static Quality quality_0;

	public int ItemQuality => 0;

	public int MaxQuality => 0;

	public Quality()
	{
	}

	public Quality(long address)
	{
	}

	[SpecialName]
	internal Struct243 method_2()
	{
		return (Struct243)(object)null;
	}

	[SpecialName]
	internal Struct244 method_3()
	{
		return (Struct244)(object)null;
	}

	public override string ToString()
	{
		return null;
	}

	private Struct243 method_4()
	{
		return (Struct243)(object)null;
	}

	private Struct244 method_5()
	{
		return (Struct244)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static Quality smethod_5()
	{
		return null;
	}

	static Quality()
	{
		Class200.smethod_34();
	}
}
