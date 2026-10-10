using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.RemoteMemoryObjects;

public class Aura : RemoteMemoryObject
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct34
	{
		public ushort ushort_0;

		private ushort ushort_1;

		private int int_0;

		public long long_0;

		private NativeVector nativeVector_0;

		private NativeVector nativeVector_1;

		private long long_1;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct35
	{
		public readonly long long_0;

		public readonly long long_1;

		private readonly long long_2;

		public readonly float float_0;

		public readonly float float_1;

		private readonly float float_2;

		private readonly int int_0;

		public readonly int int_1;

		private readonly int int_2;

		private readonly long long_3;

		private readonly int int_3;

		private readonly ushort ushort_0;

		private readonly ushort ushort_1;

		public readonly short short_0;

		public readonly ushort ushort_2;

		public readonly uint uint_0;

		private readonly ushort ushort_3;

		public readonly ushort ushort_4;

		private readonly ushort ushort_5;

		private readonly ushort ushort_6;

		private readonly long long_4;

		private readonly long long_5;

		private readonly long long_6;

		private readonly long long_7;

		private readonly long long_8;

		private readonly long long_9;

		private readonly long long_10;

		private readonly long long_11;

		private readonly long long_12;

		private readonly long long_13;

		public readonly long long_14;

		public readonly long long_15;

		public readonly long long_16;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct36
	{
		public int int_0;

		public int int_1;

		public int IsActive;
	}

	private PerFrameCachedValue<Struct35> perFrameCachedValue_0;

	private PerFrameCachedValue<Struct36> perFrameCachedValue_1;

	private PerFrameCachedValue<DatBuffDefinitionWrapper.Struct105> perFrameCachedValue_2;

	private PerFrameCachedValue<int> perFrameCachedValue_3;

	private PerFrameCachedValue<int> perFrameCachedValue_4;

	private PerFrameCachedValue<ushort> perFrameCachedValue_5;

	private PerFrameCachedValue<int> perFrameCachedValue_6;

	private PerFrameCachedValue<TimeSpan> rlWysuYqNP;

	private PerFrameCachedValue<TimeSpan> perFrameCachedValue_7;

	private PerFrameCachedValue<int> jeMyUkXkHT;

	private PerFrameCachedValue<string> perFrameCachedValue_8;

	private PerFrameCachedValue<bool> perFrameCachedValue_9;

	private PerFrameCachedValue<bool> perFrameCachedValue_10;

	private PerFrameCachedValue<string> perFrameCachedValue_11;

	private PerFrameCachedValue<string> perFrameCachedValue_12;

	private PerFrameCachedValue<int> perFrameCachedValue_13;

	private PerFrameCachedValue<int> perFrameCachedValue_14;

	private PerFrameCachedValue<bool> perFrameCachedValue_15;

	private PerFrameCachedValue<int> perFrameCachedValue_16;

	private PerFrameCachedValue<short> iEbymYltEW;

	private PerFrameCachedValue<string> perFrameCachedValue_17;

	private PerFrameCachedValue<AuraDisplayInfo> perFrameCachedValue_18;

	internal static Aura aura_0;

	public bool IsCasterMe => true;

	public int CasterId => 0;

	public int OwnerId => 0;

	public ushort SkillOwnerId => 0;

	public int BuffType => 0;

	public TimeSpan MaxTimeLeft => (TimeSpan)(object)null;

	public uint SkillOwnerId32 => 0u;

	public TimeSpan TimeLeft => (TimeSpan)(object)null;

	public string Implementation => null;

	public int MergeMode => 0;

	public int UIStackMode => 0;

	public int Charges => 0;

	public string Name => null;

	public bool IsInvisible => true;

	public bool IsRemovable => true;

	public string InternalName => null;

	public string Description => null;

	public int Stacks => 0;

	public int MaxStacks => 0;

	public int StacksPct => 0;

	public bool IsPlagueActive => true;

	public int FlaskSlot => 0;

	public short Effectiveness => 0;

	public Aura(long address)
	{
	}

	private TimeSpan method_0()
	{
		return (TimeSpan)(object)null;
	}

	private static TimeSpan jOkySooeUr(float float_0)
	{
		return (TimeSpan)(object)null;
	}

	private int method_1()
	{
		return 0;
	}

	private TimeSpan timeLeft()
	{
		return (TimeSpan)(object)null;
	}

	public bool TryGetDisplayInfo(out AuraDisplayInfo displayInfo)
	{
		return true;
	}

	private int method_2()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	internal Struct35 method_3()
	{
		return (Struct35)(object)null;
	}

	[SpecialName]
	internal Struct36 method_4()
	{
		return (Struct36)(object)null;
	}

	private Struct36 method_5()
	{
		return (Struct36)(object)null;
	}

	[SpecialName]
	internal DatBuffDefinitionWrapper.Struct105 method_6()
	{
		return (DatBuffDefinitionWrapper.Struct105)(object)null;
	}

	[CompilerGenerated]
	private int method_7()
	{
		return 0;
	}

	[CompilerGenerated]
	private ushort method_8()
	{
		return 0;
	}

	[CompilerGenerated]
	private int method_9()
	{
		return 0;
	}

	[CompilerGenerated]
	private string method_10()
	{
		return null;
	}

	[CompilerGenerated]
	private AuraDisplayInfo method_11()
	{
		return null;
	}

	[CompilerGenerated]
	private int method_12()
	{
		return 0;
	}

	[CompilerGenerated]
	private string method_13()
	{
		return null;
	}

	[CompilerGenerated]
	private bool method_14()
	{
		return true;
	}

	[CompilerGenerated]
	private bool method_15()
	{
		return true;
	}

	[CompilerGenerated]
	private string method_16()
	{
		return null;
	}

	[CompilerGenerated]
	private string method_17()
	{
		return null;
	}

	[CompilerGenerated]
	private int method_18()
	{
		return 0;
	}

	[CompilerGenerated]
	private int method_19()
	{
		return 0;
	}

	[CompilerGenerated]
	private bool method_20()
	{
		return true;
	}

	[CompilerGenerated]
	private short method_21()
	{
		return 0;
	}

	[CompilerGenerated]
	private Struct35 method_22()
	{
		return (Struct35)(object)null;
	}

	[CompilerGenerated]
	private DatBuffDefinitionWrapper.Struct105 method_23()
	{
		return (DatBuffDefinitionWrapper.Struct105)(object)null;
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static Aura smethod_3()
	{
		return null;
	}

	static Aura()
	{
		Class200.smethod_34();
	}
}
