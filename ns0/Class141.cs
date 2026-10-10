using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki;
using DreamPoeBot.Loki.Components;
using DreamPoeBot.Loki.Game.Objects;

namespace ns0;

internal static class Class141
{
	private sealed class Class142
	{
		internal readonly List<Class144> list_0;

		private static Class142 class142_0;

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class142 smethod_1()
		{
			return null;
		}

		static Class142()
		{
			Class200.smethod_34();
		}
	}

	private sealed class Class143
	{
		internal Memory memory_0;

		internal long long_0;

		internal long long_1;

		internal long long_2;

		internal Vector2i vector2i_0;

		internal Vector2i vector2i_1;

		internal byte[] byte_0;

		internal static Class143 class143_0;

		internal bool method_0(Memory memory_1, long long_3, long long_4, long long_5, DreamPoeBot.Loki.Components.TriggerableBlockage.Struct264 struct264_0)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class143 smethod_1()
		{
			return null;
		}

		static Class143()
		{
			Class200.smethod_34();
		}
	}

	internal sealed class Class144
	{
		internal Entity entity_0;

		internal Vector2i vector2i_0;

		internal Vector2i vector2i_1;

		internal byte[] byte_0;

		internal byte[] byte_1;

		internal bool bool_0;

		internal bool bool_1;

		internal int int_0;

		internal static Class144 class144_0;

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class144 smethod_1()
		{
			return null;
		}

		static Class144()
		{
			Class200.smethod_34();
		}
	}

	private static readonly ConditionalWeakTable<Entity, Class143> conditionalWeakTable_0;

	private static readonly ConditionalWeakTable<byte[], Class142> conditionalWeakTable_1;

	internal static Class141 class141_0;

	internal static int smethod_0(byte[] byte_0, int int_0, Vector2i vector2i_0, Vector2i vector2i_1)
	{
		return 0;
	}

	private static long smethod_1(NetworkObject networkObject_0, Memory memory_0, long long_0)
	{
		return 0L;
	}

	internal static Class144 smethod_2(byte[] byte_0, int int_0, NetworkObject networkObject_0, bool bool_0 = false)
	{
		return null;
	}

	internal static bool smethod_3(byte[] byte_0, int int_0, Class144 class144_0, bool bool_0)
	{
		return true;
	}

	static Class141()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		conditionalWeakTable_0 = new ConditionalWeakTable<Entity, Class143>();
		conditionalWeakTable_1 = new ConditionalWeakTable<byte[], Class142>();
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static Class141 smethod_5()
	{
		return null;
	}
}
