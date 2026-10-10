using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class ClientBetrayalChoice : Component
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct197
	{
		public long long_0;

		public long long_1;

		public long long_2;

		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public byte byte_0;

		public byte byte_1;

		public byte byte_2;

		public byte byte_3;

		public byte byte_4;

		public byte byte_5;

		public byte byte_6;

		public byte byte_7;
	}

	private PerFrameCachedValue<Struct197> perFrameCachedValue_0;

	private static ClientBetrayalChoice clientBetrayalChoice_0;

	[SpecialName]
	internal Struct197 method_2()
	{
		return (Struct197)(object)null;
	}

	private Struct197 method_3()
	{
		return (Struct197)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static ClientBetrayalChoice smethod_5()
	{
		return null;
	}

	static ClientBetrayalChoice()
	{
		Class200.smethod_34();
	}
}
