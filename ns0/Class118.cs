using System.Collections.Generic;
using System.Runtime.InteropServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki;
using DreamPoeBot.Loki.Components;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.RemoteMemoryObjects;

namespace ns0;

internal static class Class118
{
	private sealed class Class119
	{
		internal Skill.Struct52 struct52_0;

		internal string Name;

		internal string string_0;

		internal string string_1;

		internal int int_0;

		internal Dictionary<StatTypeGGG, int> dictionary_0;

		private static Class119 class119_0;

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class119 smethod_1()
		{
			return null;
		}

		static Class119()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	private struct Struct198
	{
		[FieldOffset(0)]
		public Actor.ActionWrapper.Struct178 Action;

		[FieldOffset(0)]
		public long long_0;

		[FieldOffset(240)]
		public long long_1;

		[FieldOffset(248)]
		public long long_2;

		internal static object object_0;

		internal bool method_0(Struct198 struct198_0)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static object smethod_1()
		{
			return null;
		}

		static Struct198()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Explicit, Size = 1360)]
	private struct Struct199
	{
		[FieldOffset(336)]
		public Vector2i vector2i_0;

		[FieldOffset(364)]
		public int int_0;

		[FieldOffset(412)]
		public byte byte_0;

		[FieldOffset(488)]
		public long long_0;

		[FieldOffset(496)]
		public long long_1;

		[FieldOffset(692)]
		public int int_1;

		[FieldOffset(696)]
		public int int_2;

		[FieldOffset(851)]
		public byte byte_1;

		[FieldOffset(898)]
		public byte byte_2;

		[FieldOffset(976)]
		public byte byte_3;

		[FieldOffset(1072)]
		public long long_2;

		[FieldOffset(1128)]
		public byte Active;

		[FieldOffset(1276)]
		public float float_0;

		[FieldOffset(1284)]
		public float float_1;

		[FieldOffset(1352)]
		public long long_3;

		internal static object object_0;

		internal bool method_0(Struct199 struct199_0)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static object smethod_1()
		{
			return null;
		}

		static Struct199()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 237)]
	private struct Struct200
	{
		[FieldOffset(0)]
		public int Id;

		[FieldOffset(36)]
		public int int_0;

		[FieldOffset(40)]
		public int int_1;

		[FieldOffset(48)]
		public int int_2;

		[FieldOffset(69)]
		public byte byte_0;

		[FieldOffset(122)]
		public int int_3;

		[FieldOffset(236)]
		public byte byte_1;
	}

	private static readonly int int_0;

	private static Class118 class118_0;

	internal static bool smethod_0(Actor actor_0, out IReadOnlyList<DeployedEffect> ireadOnlyList_0)
	{
		return true;
	}

	private static IReadOnlyList<DeployedEffect> smethod_1(Actor actor_0)
	{
		return null;
	}

	private static Class119 smethod_2(Memory memory_0, long long_0)
	{
		return null;
	}

	private static DeployedEffectGeometry smethod_3(Memory memory_0, long long_0, Class119 class119_0)
	{
		return null;
	}

	private static float? Radius(Memory m, Struct199 a, Struct200 row, Class119 skill)
	{
		return null;
	}

	private static T smethod_4<T>(Memory memory_0, long long_0) where T : unmanaged
	{
		return (T)null;
	}

	private static void smethod_5(bool bool_0, string string_0)
	{
	}

	private static bool smethod_6(float float_0)
	{
		return true;
	}

	private static bool smethod_7(byte[] byte_0, byte[] byte_1)
	{
		return true;
	}

	private static int smethod_8(NativeVector nativeVector_0, int int_1, int int_2)
	{
		return 0;
	}

	static Class118()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		int_0 = (int)Marshal.OffsetOf<Actor.ActorStruct137>(Class200.smethod_20(2887320));
	}

	internal static bool smethod_9()
	{
		return true;
	}

	internal static Class118 smethod_10()
	{
		return null;
	}
}
