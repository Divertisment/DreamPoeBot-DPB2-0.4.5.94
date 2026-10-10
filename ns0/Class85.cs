using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Game;
using DreamPoeBot.Loki.Game.Objects;

namespace ns0;

internal class Class85 : MemoryObject
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct19
	{
		public readonly long long_0;

		public readonly Vector2i vector2i_0;

		public readonly Vector2i muxAkUsGgFa;
	}

	[CompilerGenerated]
	private readonly int int_0;

	private static Class85 class85_0;

	public int LocalId
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
	}

	internal Class85(long long_0, int int_1)
	{
	}

	[SpecialName]
	internal Struct19 method_1()
	{
		return (Struct19)(object)null;
	}

	[SpecialName]
	public Vector2i method_2()
	{
		return (Vector2i)(object)null;
	}

	[SpecialName]
	public Vector2i method_3()
	{
		return (Vector2i)(object)null;
	}

	[SpecialName]
	public Vector2i method_4()
	{
		return (Vector2i)(object)null;
	}

	[SpecialName]
	public Item method_5()
	{
		return null;
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static Class85 smethod_3()
	{
		return null;
	}

	static Class85()
	{
		Class200.smethod_34();
	}
}
