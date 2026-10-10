using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Common;
using DreamPoeBot.Loki.Game.Objects;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.Game.Utilities;
using DreamPoeBot.Loki.RemoteMemoryObjects;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class Actor : Component
{
	public class ActionWrapper : RemoteMemoryObject
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1)]
		internal struct Struct178
		{
			[FieldOffset(256)]
			public long long_0;

			[FieldOffset(328)]
			public long long_1;

			[FieldOffset(336)]
			public Vector2i vector2i_0;
		}

		private Struct178 struct178_0;

		private Actor actor_0;

		internal static ActionWrapper actionWrapper_0;

		public Vector2i Destination => (Vector2i)(object)null;

		public NetworkObject Target => null;

		public Skill Skill => null;

		internal ActionWrapper(long address, Struct178 native, Actor actor)
		{
		}

		public override string ToString()
		{
			return null;
		}

		internal static bool smethod_2()
		{
			return true;
		}

		internal static ActionWrapper smethod_3()
		{
			return null;
		}

		static ActionWrapper()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct179
	{
		private Struct14 struct14_0;

		private byte byte_0;

		private byte byte_1;

		private byte byte_2;

		private byte byte_3;

		private int int_0;

		private long long_0;

		private long long_1;

		private long long_2;

		private long long_3;

		private long long_4;

		private long long_5;

		private long long_6;

		private long long_7;

		private long long_8;

		private long long_9;

		private long long_10;

		public long long_11;

		private long long_12;

		private long long_13;

		private long long_14;

		private long long_15;

		private long long_16;

		private long long_17;

		private long bQnlaEecGhW;

		private long long_18;

		private long long_19;

		private long long_20;

		private long long_21;

		private long long_22;

		private long long_23;

		private long WvLlafIvCrR;

		private NativeVector nativeVector_0;

		private long long_24;

		private long long_25;

		private long long_26;

		private long long_27;

		private long long_28;

		private long long_29;

		private long long_30;

		private long long_31;

		private long long_32;

		private long long_33;

		private long long_34;

		private long long_35;

		private long long_36;

		private long long_37;

		private long long_38;

		private long long_39;

		private long long_40;

		private long long_41;

		private long long_42;

		private long long_43;

		private long long_44;

		private long long_45;

		public long long_46;

		private long long_47;

		private long long_48;

		private long long_49;

		private int int_1;

		private int int_2;

		private int int_3;

		private int int_4;

		public NativeVector nativeVector_1;

		private NativeVector nativeVector_2;

		public short short_0;

		private short short_1;

		private short short_2;

		private short short_3;

		private long long_50;

		private long long_51;

		private long long_52;

		private long long_53;

		private byte byte_4;

		private byte OeOlstiTejQ;

		private byte byte_5;

		private byte byte_6;

		private int int_5;

		private int mGolsofSavQ;

		private Vector2i vector2i_0;

		private int int_6;

		private long long_54;

		public float float_0;

		public float float_1;

		private long uqIlsgvbdiR;

		private long long_55;

		private byte byte_7;

		private byte byte_8;

		private byte byte_9;

		private byte byte_10;

		private int int_7;

		private Struct13 struct13_0;

		private Struct13 struct13_1;

		private Struct13 struct13_2;

		private Struct13 struct13_3;

		private long long_56;

		private long long_57;

		private long long_58;

		private long long_59;

		private long long_60;

		private long long_61;

		private long long_62;

		private long long_63;

		private long long_64;

		private long long_65;

		private long long_66;

		private long long_67;

		private long long_68;

		private long long_69;

		private long long_70;

		private long long_71;

		private long long_72;

		private long long_73;

		private long long_74;

		private long long_75;

		private long long_76;

		private long long_77;

		private long long_78;

		private long long_79;

		private int int_8;

		private int int_9;

		private long long_80;

		private long long_81;

		private long rlAlsmfgNog;

		private long long_82;

		private long long_83;

		private long long_84;

		private long long_85;

		private long long_86;

		private long long_87;

		private long long_88;

		private long long_89;

		private long long_90;

		private long long_91;

		private long long_92;

		private long long_93;

		private long long_94;

		private long long_95;

		private long long_96;

		private long long_97;

		private long long_98;

		private long long_99;

		private long long_100;

		private long long_101;

		private long long_102;

		private long long_103;

		private long long_104;

		private long long_105;

		private long long_106;

		private long long_107;

		private long long_108;

		private long long_109;

		private long long_110;

		private long long_111;

		private long long_112;

		private long long_113;

		private long meYlBrxubMg;

		private long long_114;

		private long long_115;

		private long long_116;

		private long long_117;

		private long long_118;

		private long long_119;

		private long long_120;

		private long long_121;

		private long long_122;

		private long long_123;

		private long long_124;

		private long long_125;

		public NativeVector nativeVector_3;

		public NativeVector nativeVector_4;

		public NativeVector nativeVector_5;

		public NativeVector nativeVector_6;
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ActorStruct137
	{
		[FieldOffset(8)]
		public long intptr_Owner;

		[FieldOffset(568)]
		public long intptr_9ActionWrapperStruct276;

		[FieldOffset(576)]
		public long intptr_9ActionWrapperStruct276MoveOnly;

		[FieldOffset(624)]
		public NativeVector nativeVector_0Effects;

		[FieldOffset(672)]
		public short short_0Flags;

		[FieldOffset(688)]
		public float float_1TimeSinceLastAction;

		[FieldOffset(700)]
		public ushort float_0TimeSinceLastMove;

		[FieldOffset(2824)]
		public NativeVector nativeVector_3AvailableSkills;

		[FieldOffset(2848)]
		public NativeVector nativeVector_4List_0CoolDownSkills;

		[FieldOffset(2872)]
		public NativeVector nativeVector_5List_1VaalSkills;

		[FieldOffset(3112)]
		public NativeVector nativeVector_7List_2DeployedObjects;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct180
	{
		public Struct10 struct10_0;

		public int int_0;

		public int int_1;

		private int int_2;

		private byte byte_0;

		private byte byte_1;

		private byte byte_2;

		private byte byte_3;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct CoolDownDataStructure
	{
		private short short_0;

		private short short_1;

		private short short_2;

		private short short_3;

		public int Index;

		private int int_0;

		public NativeVector nativeVector_0;

		private long long_0;

		public int int_5CoolDownCount;

		private int int_1;

		private int int_2;

		private short short_4;

		private short short_5;

		private int int_3;

		private short short_6;

		private short short_7;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 24)]
	internal struct Struct181
	{
		public int int_0;

		public uint uint_0;

		public ushort ushort_0;

		private ushort ushort_1;

		private int int_1;
	}

	private static readonly ILog ilog_0;

	private PerFrameCachedValue<ActorStruct137> perFrameCachedValue_0;

	private SlowCacheValue<List<Skill>> hbPzrmdtVy;

	internal static Actor actor_0;

	public long OwnerAddress => 0L;

	public List<Skill> AvailableSkills => null;

	public ActionWrapper CurrentAction => null;

	public ActionWrapper CurrentMoveAction => null;

	public List<long> ListOfDeployedEffect => null;

	public List<NetworkObject> DeployedObjects => null;

	public uint Flags => 0u;

	public bool HasCurrentAction => true;

	public bool HasCurrentMoveAction => true;

	public float TimeSinceLastAction => 0f;

	public float TimeSinceLastMove => 0f;

	private List<Skill> method_2()
	{
		return null;
	}

	public bool TryGetDeployedEffects(out IReadOnlyList<DeployedEffect> effects)
	{
		return true;
	}

	[SpecialName]
	internal List<CoolDownDataStructure> method_3()
	{
		return null;
	}

	[SpecialName]
	internal List<Struct180> method_4()
	{
		return null;
	}

	[SpecialName]
	internal List<Struct181> method_5()
	{
		return null;
	}

	[SpecialName]
	internal ActorStruct137 method_6()
	{
		return (ActorStruct137)(object)null;
	}

	public override string ToString()
	{
		return null;
	}

	static Actor()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	[CompilerGenerated]
	private ActorStruct137 method_7()
	{
		return (ActorStruct137)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static Actor smethod_5()
	{
		return null;
	}
}
