using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class IncursionTemple : Component
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct220
	{
		public long long_0;

		public long long_1;

		public long yjnljnQvfFr;

		public int int_0;

		public int int_1;

		public Struct_rooms struct_rooms_0;
	}

	[StructLayout(LayoutKind.Sequential, Size = 22)]
	[UnsafeValueType]
	public struct Struct_rooms
	{
		public unsafe fixed short byte_0[11];
	}

	private PerFrameCachedValue<Struct220> perFrameCachedValue_0;

	private static IncursionTemple incursionTemple_0;

	public int AreaLevel => 0;

	[SpecialName]
	internal Struct220 method_2()
	{
		return (Struct220)(object)null;
	}

	[CompilerGenerated]
	private Struct220 method_3()
	{
		return (Struct220)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static IncursionTemple smethod_5()
	{
		return null;
	}

	static IncursionTemple()
	{
		Class200.smethod_34();
	}
}
