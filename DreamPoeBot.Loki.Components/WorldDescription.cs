using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class WorldDescription : Component
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct268
	{
		public Struct14 struct14_0;

		public long long_0;

		public long long_1;

		public long long_2;

		public long long_3;

		public long long_4;

		public long long_5;

		public long long_6;

		public long long_7;

		public long long_8;

		public long long_9;

		public long long_10;

		public long long_11;

		public long long_12;

		public long long_13;

		public long long_14;

		public long long_15;

		public long long_16;

		public GStruct2 gstruct2_0;

		public GStruct2 gstruct2_1;

		public GStruct2 gstruct2_2;

		public GStruct2 Title;

		public GStruct2 Text;
	}

	private PerFrameCachedValue<Struct268> perFrameCachedValue_0;

	private static WorldDescription worldDescription_0;

	public string Title => null;

	public string Text => null;

	[SpecialName]
	internal Struct268 method_2()
	{
		return (Struct268)(object)null;
	}

	private Struct268 method_3()
	{
		return (Struct268)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static WorldDescription smethod_5()
	{
		return null;
	}

	static WorldDescription()
	{
		Class200.smethod_34();
	}
}
