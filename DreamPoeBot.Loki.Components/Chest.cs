using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class Chest : Component
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct195
	{
		private Struct14 struct14_0;

		private long long_0;

		private long long_1;

		public long long_2;

		private NativeVector nativeVector_0;

		private long long_3;

		private long long_4;

		private long long_5;

		private long long_6;

		private long long_7;

		private long long_8;

		private long long_9;

		private long long_10;

		private long long_11;

		private long long_12;

		private long fOmlDjwcoiR;

		private long long_13;

		private long long_14;

		private long jZvlDmuewdg;

		private long long_15;

		private long long_16;

		private NativeVector nativeVector_1;

		private long long_17;

		private long long_18;

		private long long_19;

		private long vVnlxAbhbUd;

		private long long_20;

		private long OrTlxpbsHd1;

		private long long_21;

		private long long_22;

		private long long_23;

		private long long_24;

		private long long_25;

		private long long_26;

		private long CnwlxShhMyj;

		private long long_27;

		private long long_28;

		private long long_29;

		private long long_30;

		public long long_31;

		public byte byte_0;

		public byte byte_1;

		private byte byte_2;

		private byte byte_3;

		private byte byte_4;

		public byte byte_5;

		private ushort ushort_0;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct196
	{
		private long long_0;

		private long long_1;

		private long long_2;

		private long long_3;

		public byte byte_0;

		public byte byte_1;

		public byte byte_2;

		public byte byte_3;

		private byte byte_4;

		public byte byte_5;

		private byte byte_6;

		private byte byte_7;

		public byte byte_8;

		private byte byte_9;

		private byte byte_10;

		private byte FeblxbygetV;

		private int int_0;

		private long long_4;

		private long long_5;

		private long AftlxaUtuw2;

		private long NwmlxsSyByf;

		private long long_6;

		private long long_7;

		public int int_1;

		private int int_2;

		private int int_3;

		private int int_4;

		private int int_5;

		private int int_6;

		private int int_7;
	}

	private bool? nullable_0;

	private int? nullable_1;

	private bool? nullable_2;

	private bool? nullable_3;

	private bool? nullable_4;

	private bool? nullable_5;

	private bool? nullable_6;

	private PerFrameCachedValue<Struct195> perFrameCachedValue_0;

	private PerFrameCachedValue<Struct196> perFrameCachedValue_1;

	private static Chest chest_0;

	public int DropSlots => 0;

	public bool OpenOnDamage => true;

	public bool OpeningDestroys => true;

	public bool AxisAligned => true;

	public bool Stompable => true;

	public bool IsLarge => true;

	public bool OpenChestWhenDemonsDie => true;

	public bool IsOpened => true;

	public bool IsLocked => true;

	public int Quality => 0;

	public Vector2i Position => (Vector2i)(object)null;

	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	internal Struct195 method_2()
	{
		return (Struct195)(object)null;
	}

	[SpecialName]
	internal Struct196 method_3()
	{
		return (Struct196)(object)null;
	}

	[CompilerGenerated]
	private Struct195 method_4()
	{
		return (Struct195)(object)null;
	}

	[CompilerGenerated]
	private Struct196 method_5()
	{
		return (Struct196)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static Chest smethod_5()
	{
		return null;
	}

	static Chest()
	{
		Class200.smethod_34();
	}
}
