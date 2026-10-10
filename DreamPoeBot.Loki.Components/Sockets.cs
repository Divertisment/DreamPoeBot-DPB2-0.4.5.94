using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Objects;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class Sockets : Component
{
	public class SocketedGem
	{
		public int SocketIndex;

		public Entity GemEntity;

		internal static SocketedGem socketedGem_0;

		internal static bool smethod_0()
		{
			return true;
		}

		internal static SocketedGem smethod_1()
		{
			return null;
		}

		static SocketedGem()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Struct212
	{
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		[UnsafeValueType]
		public struct Struct213
		{
			public int int_0;

			public int int_1;

			public int int_2;

			public int int_3;

			public int int_4;

			public int int_5;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		[UnsafeValueType]
		public struct Struct214
		{
			public long long_0;

			public long long_1;

			public long long_2;

			public long long_3;

			public long long_4;

			public long long_5;
		}

		private Struct14 struct14_0;

		private nint intptr_0;

		public Struct213 struct213_Colors;

		public Struct214 struct214_Gems;

		public NativeVector nativeVector_SocketLinks;

		private byte byte_0;

		private byte byte_1;

		private byte byte_2;

		private byte byte_3;
	}

	private PerFrameCachedValue<Struct212> perFrameCachedValue_0;

	private static Sockets sockets_0;

	public int LargestLinkSize => 0;

	public List<int[]> Links => null;

	public List<int> SocketList => null;

	public int NumberOfSockets => 0;

	public bool IsRGB => true;

	public List<string> SocketGroup => null;

	public List<SocketedGem> SocketedGems => null;

	public string DisplayString => null;

	public Item[] Gems => null;

	public SocketColor[] SocketColors => null;

	public List<Item[]> SocketedSkillGemsByLinks => null;

	public byte[] SocketLinks => null;

	private Struct212 method_2()
	{
		return (Struct212)(object)null;
	}

	[SpecialName]
	internal Struct212 method_3()
	{
		return (Struct212)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static Sockets smethod_5()
	{
		return null;
	}

	static Sockets()
	{
		Class200.smethod_34();
	}
}
