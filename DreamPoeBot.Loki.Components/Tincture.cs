using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class Tincture : Component
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct Struct260
	{
		private long long_0;

		public long lcwppaHeKfS;

		public long AeRppsItTl6;

		public long long_1;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct Struct261
	{
		private long long_0;

		private long long_1;

		public long long_2;

		public long long_3;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct Struct262
	{
		public long long_0;

		public long long_1;

		public int int_0;

		public int int_1;
	}

	private PerFrameCachedValue<Struct260> perFrameCachedValue_0;

	internal static Tincture tincture_0;

	public int BaseManaburnMsTick => 0;

	public int BaseMsCooldown => 0;

	[SpecialName]
	private Struct261 method_2()
	{
		return (Struct261)(object)null;
	}

	[SpecialName]
	private Struct262 method_3()
	{
		return (Struct262)(object)null;
	}

	[SpecialName]
	private Struct260 method_4()
	{
		return (Struct260)(object)null;
	}

	private Struct260 method_5()
	{
		return (Struct260)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static Tincture smethod_5()
	{
		return null;
	}

	static Tincture()
	{
		Class200.smethod_34();
	}
}
