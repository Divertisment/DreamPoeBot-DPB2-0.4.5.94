using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class SkillGem : Component
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 64)]
	internal struct Struct249
	{
		[FieldOffset(0)]
		private Struct14 struct14_0;

		[FieldOffset(24)]
		public long long_0;

		[FieldOffset(32)]
		public uint uint_0;

		[FieldOffset(36)]
		public int int_0;

		[FieldOffset(40)]
		public uint uint_1;

		[FieldOffset(44)]
		public uint uint_2;

		[FieldOffset(60)]
		public byte byte_0;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct250
	{
		private long long_0;

		private long long_1;

		public int int_0;

		private int int_1;

		public long long_2;

		private long long_3;

		private int int_2;

		public int int_3;

		public int int_4;

		public int int_5;

		public int int_6;

		public int int_7;

		public int int_8;

		public int int_9;

		public int int_10;

		public int int_11;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 250)]
	internal struct Struct251
	{
		private long long_0;

		private long long_1;

		private int int_0;

		private int int_1;

		private int int_2;

		public long long_2;

		public long long_3;

		private byte byte_0;

		public long long_4;

		public long long_5;

		public long long_6;

		public long long_7;

		public long long_8;

		private byte byte_1;

		private byte byte_2;

		public int luDpAofeoFJ;

		public long long_9;

		public long long_10;

		public long long_11;

		public long long_12;

		private long long_13;

		public long long_14;

		private byte AjRpAyibmFj;

		private long long_15;

		public long long_16;

		internal static object object_0;

		[SpecialName]
		public int method_0()
		{
			return 0;
		}

		[SpecialName]
		public int method_1()
		{
			return 0;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static object smethod_1()
		{
			return null;
		}

		static Struct251()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 142)]
	internal struct Struct252
	{
		[FieldOffset(0)]
		private long Id;

		[FieldOffset(8)]
		private long Name;

		[FieldOffset(16)]
		public long long_0;

		[FieldOffset(24)]
		private long long_1;

		[FieldOffset(32)]
		private long long_2;

		[FieldOffset(40)]
		private long long_3;

		[FieldOffset(48)]
		private long long_4;

		[FieldOffset(56)]
		public long long_5;

		[FieldOffset(64)]
		public long long_6;

		[FieldOffset(72)]
		private long long_7;

		[FieldOffset(80)]
		private int int_0;

		private static object object_0;

		[SpecialName]
		public int method_0()
		{
			return 0;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static object smethod_1()
		{
			return null;
		}

		static Struct252()
		{
			Class200.smethod_34();
		}
	}

	private PerFrameCachedValue<Struct249> perFrameCachedValue_0;

	private int int_0;

	internal static SkillGem skillGem_0;

	public int GemLevel => 0;

	public float[] AttributeModifiers => null;

	public int AttributeModifiersStr => 0;

	public int AttributeModifiersDex => 0;

	public int AttributeModifiersInt => 0;

	public uint Experience => 0u;

	public uint ExperienceLastLevel => 0u;

	public uint ExperienceMaxLevel => 0u;

	public int RequiredDex => 0;

	public int RequiredInt => 0;

	public int RequiredLevel => 0;

	public int RequiredLevelForNextLevel => 0;

	public int RequiredStr => 0;

	public GemQualityType GemQualityType => (GemQualityType)(object)null;

	public SocketColor SocketColor => (SocketColor)(object)null;

	public long GetGrantedEffectAddress => 0L;

	public IEnumerable<string> GemTypes => null;

	public int RequiredLevelForLevel(int level)
	{
		return 0;
	}

	[SpecialName]
	private int method_2()
	{
		return 0;
	}

	private int method_3(bool bool_0)
	{
		return 0;
	}

	private int method_4(int int_1)
	{
		return 0;
	}

	[SpecialName]
	internal Struct249 KnbAwAqcgGy()
	{
		return (Struct249)(object)null;
	}

	[SpecialName]
	internal Struct250 method_5()
	{
		return (Struct250)(object)null;
	}

	private int method_6(int int_1, bool bool_0)
	{
		return 0;
	}

	private Struct249 method_7()
	{
		return (Struct249)(object)null;
	}

	internal static bool smethod_4(Memory memory_0, int int_1, long long_2, out Struct252 struct252_0)
	{
		return true;
	}

	internal static bool smethod_5()
	{
		return true;
	}

	internal static SkillGem smethod_6()
	{
		return null;
	}

	static SkillGem()
	{
		Class200.smethod_34();
	}
}
