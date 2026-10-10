using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class Timer : Component
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct259
	{
		public Struct14 struct14_0;

		public long long_0;

		public float float_0;

		public long long_1;
	}

	private PerFrameCachedValue<Struct259> perFrameCachedValue_0;

	internal static Timer timer_0;

	public float TimeLeft => 0f;

	[SpecialName]
	internal Struct259 method_2()
	{
		return (Struct259)(object)null;
	}

	private Struct259 method_3()
	{
		return (Struct259)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static Timer smethod_5()
	{
		return null;
	}

	static Timer()
	{
		Class200.smethod_34();
	}
}
