using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class Stack : Component
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct253
	{
		public Struct14 struct14_0;

		public long long_0;

		public int int_0;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct254
	{
		public long long_0;

		public long long_1;

		public long long_2;

		public long long_3;

		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public GStruct2 gstruct2_0;
	}

	private PerFrameCachedValue<Struct253> OpmAwgybkQS;

	private PerFrameCachedValue<Struct254> perFrameCachedValue_0;

	internal static Stack stack_0;

	public int MaxCurrencyTabStackCount => 0;

	public int MaxStackCount => 0;

	public int StackCount => 0;

	public string Description => null;

	[SpecialName]
	internal Struct253 method_2()
	{
		return (Struct253)(object)null;
	}

	[CompilerGenerated]
	private Struct253 method_3()
	{
		return (Struct253)(object)null;
	}

	[SpecialName]
	internal Struct254 method_4()
	{
		return (Struct254)(object)null;
	}

	[CompilerGenerated]
	private Struct254 method_5()
	{
		return (Struct254)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static Stack smethod_5()
	{
		return null;
	}

	static Stack()
	{
		Class200.smethod_34();
	}
}
