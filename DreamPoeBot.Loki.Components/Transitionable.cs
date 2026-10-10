using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class Transitionable : Component
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct263
	{
		public Struct13 struct13_0;

		public Struct13 struct13_1;

		public long long_0;

		public byte byte_0;

		public byte NoJppzdvrrt;

		public ushort ushort_0;

		public long long_1;
	}

	internal static Transitionable transitionable_0;

	public ushort Flag1 => 0;

	public byte Flag2 => 0;

	public byte Flag3 => 0;

	internal static bool smethod_4()
	{
		return true;
	}

	internal static Transitionable smethod_5()
	{
		return null;
	}

	static Transitionable()
	{
		Class200.smethod_34();
	}
}
