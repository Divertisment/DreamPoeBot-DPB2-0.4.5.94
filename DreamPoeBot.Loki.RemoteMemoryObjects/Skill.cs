using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DreamPoeBot.Loki.Common;
using DreamPoeBot.Loki.Components;
using DreamPoeBot.Loki.Game;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Objects;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.Game.Utilities;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.RemoteMemoryObjects;

public class Skill : RemoteMemoryObject
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct51
	{
		public Struct10 struct10_0;

		private nint intptr_0;

		private Struct10 struct10_1;

		private nint intptr_1;

		private nint intptr_2;

		private nint intptr_3;

		private nint intptr_4;

		private nint intptr_5;

		private nint intptr_6;

		private nint intptr_7;

		private nint intptr_8;

		private nint intptr_9;

		private nint intptr_10;
	}

	[StructLayout(LayoutKind.Explicit, Size = 496)]
	internal struct Struct52
	{
		[FieldOffset(0)]
		public long long_0;

		[FieldOffset(80)]
		public uint uint_0;

		[FieldOffset(104)]
		public Struct10 struct10_0;

		[FieldOffset(232)]
		public int int_0;

		[FieldOffset(244)]
		public int int_1;

		[FieldOffset(248)]
		public int int_2;

		[FieldOffset(256)]
		public int int_3;

		[FieldOffset(260)]
		public int int_4;

		[FieldOffset(280)]
		public long long_1;

		[FieldOffset(360)]
		public NativeVector nativeVector_0;

		[FieldOffset(384)]
		public long long_2;

		[FieldOffset(408)]
		public readonly byte byte_0;

		[FieldOffset(416)]
		public readonly byte byte_1;

		[FieldOffset(417)]
		public readonly byte byte_2;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct53
	{
		public readonly float float_0;

		public readonly float float_1;

		public readonly float float_2;

		public readonly float float_3;
	}

	public enum SkillCostType
	{
		Life,
		Mana
	}

	private static ILog bbqnmsNoXp;

	private string string_0;

	private PerFrameCachedValue<Item> perFrameCachedValue_0;

	private readonly ActiveSkillsEnum xEcnFyojWr;

	private readonly DreamPoeBot.Loki.Components.Actor actor_0;

	private readonly DatActiveSkillWrapper datActiveSkillWrapper_0;

	private readonly DatGrantedEffectsPerLevelWrapper datGrantedEffectsPerLevelWrapper_0;

	private List<string> list_0;

	private bool? nullable_0;

	private bool? nullable_1;

	private bool? nullable_2;

	private bool? nullable_3;

	private bool? nullable_4;

	private PerFrameCachedValue<Dictionary<StatTypeGGG, int>> perFrameCachedValue_1;

	private PerFrameCachedValue<Dictionary<StatTypeGGG, int>> perFrameCachedValue_2;

	private PerFrameCachedValue<Struct52> perFrameCachedValue_3;

	private readonly string string_1;

	private readonly string string_2;

	private readonly string string_3;

	private readonly string string_4;

	private string string_5;

	private string string_6;

	private string string_7;

	private long? nullable_5;

	private long? nullable_6;

	private PerFrameCachedValue<float> perFrameCachedValue_4;

	private PerFrameCachedValue<float> perFrameCachedValue_5;

	private PerFrameCachedValue<float> perFrameCachedValue_6;

	private PerFrameCachedValue<float> perFrameCachedValue_7;

	private PerFrameCachedValue<float> perFrameCachedValue_8;

	private PerFrameCachedValue<float> perFrameCachedValue_9;

	private static Skill skill_0;

	public int SpiritReservation => 0;

	public float SpiritReservationPercent => 0f;

	public int MinionsWithoutBaseSpiritReservation => 0;

	public bool SupportsMinionCount => true;

	public int ConfiguredCount => 0;

	public DatActiveSkillWrapper ActiveSkill => null;

	public ActiveSkillsEnum ActiveSkillsEnum => (ActiveSkillsEnum)(object)null;

	public Dictionary<StatTypeGGG, int> AllStats => null;

	public bool AmICursingWithThis => true;

	public bool AmIUsingConsideredAuraWithThis => true;

	public Keys BoundKey => (Keys)(object)null;

	public IEnumerable<Keys> BoundKeys => null;

	public bool CastingSpell => true;

	public TimeSpan CastTime => (TimeSpan)(object)null;

	public TimeSpan Cooldown => (TimeSpan)(object)null;

	public int CooldownsActive => 0;

	public int Cost => 0;

	public SkillCostType CostType => (SkillCostType)(object)null;

	public bool CurrentlyRequiresPercentPower => true;

	public int CurrentSouls => 0;

	public List<NetworkObject> DeployedObjects => null;

	public string Description => null;

	public string DisplayString => null;

	public string DisplayStringNoId => null;

	public float Dps => 0f;

	public DatGrantedEffectsPerLevelWrapper GrantedEffectsPerLevel => null;

	public int HundredTimesAttacksPerSecond => 0;

	public uint Id => 0u;

	public uint Id2 => 0u;

	public string InternalId => null;

	public string InternalName => null;

	public InventorySlot InventorySlot => (InventorySlot)(object)null;

	public InventoryType InventoryType => (InventoryType)(object)null;

	public bool IsAurifiedCurse => true;

	public bool IsCastable => true;

	public bool IsConsideredAura => true;

	public bool IsManaReserving => true;

	public bool IsMine => true;

	public bool IsOnCooldown => true;

	public bool IsOnSkillBar => true;

	public bool IsTotem => true;

	public bool IsTrap => true;

	public bool IsVaalSkill => true;

	public string LinkedDisplayString => null;

	public List<Item> LinkedGems => null;

	public int MaxUses => 0;

	public int CurrentBolts => 0;

	public int MaxBolts => 0;

	public string Name => null;

	public int SkillActiveToken => 0;

	public int NumberDeployed => 0;

	public bool RequiresPercentPower => true;

	public bool RequiresReservedPower => true;

	public int Seals => 0;

	public bool SkillBelongsToMe => true;

	public Item SkillGem => null;

	public Item GetSkillGem => null;

	public List<string> SkillTags => null;

	public List<string> SkillType => null;

	public int Slot => 0;

	public IEnumerable<int> Slots => null;

	public uint SocketIndex => 0u;

	public int SoulsPerUse => 0;

	public Dictionary<StatTypeGGG, int> Stats => null;

	public List<DatGrantedEffectsPerLevelWrapper> Supports => null;

	public float TimeSinceLastAction => 0f;

	public float TimeSinceLastMove => 0f;

	public int TotalUses => 0;

	public int TotalVaalUses => 0;

	public int UsesAvailable => 0;

	public Skill(long address, DreamPoeBot.Loki.Components.Actor actor)
	{
	}

	public bool CanUse(bool logError = false, bool ignoreOnSkillBar = false, bool checkCharges = true)
	{
		return true;
	}

	public bool CanUseEx(out string error, bool ignoreOnSkillBar = false, bool checkCharges = true)
	{
		return true;
	}

	public static Keys GetKeyForSlot(int slot)
	{
		return (Keys)(object)null;
	}

	public static LokiPoe.Input.KeysCombo GetKeyComboForSlot(int slot)
	{
		return null;
	}

	public int GetStat(StatTypeGGG stat)
	{
		return 0;
	}

	public int GetConfiguredCount(int weaponSet)
	{
		return 0;
	}

	public int GetStatFromAll(StatTypeGGG stat)
	{
		return 0;
	}

	private Dictionary<StatTypeGGG, int> method_0()
	{
		return null;
	}

	private Dictionary<StatTypeGGG, int> method_1()
	{
		return null;
	}

	private Dictionary<StatTypeGGG, int> method_2(bool bool_0)
	{
		return null;
	}

	public float SpellCost()
	{
		return 0f;
	}

	public float FinalSpellCost(bool dontTruncate = false)
	{
		return 0f;
	}

	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	private uint XdonuLhoRZ()
	{
		return 0u;
	}

	[SpecialName]
	private long? method_3()
	{
		return null;
	}

	[SpecialName]
	private long method_4()
	{
		return 0L;
	}

	private string method_5()
	{
		return null;
	}

	[SpecialName]
	private float method_6()
	{
		return 0f;
	}

	[SpecialName]
	private float method_7()
	{
		return 0f;
	}

	[SpecialName]
	private float method_8()
	{
		return 0f;
	}

	[SpecialName]
	private float method_9()
	{
		return 0f;
	}

	[SpecialName]
	private float method_10()
	{
		return 0f;
	}

	[SpecialName]
	private float method_11()
	{
		return 0f;
	}

	[SpecialName]
	private Struct52 method_12()
	{
		return (Struct52)(object)null;
	}

	static Skill()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		bbqnmsNoXp = Logger.GetLoggerInstanceForType();
	}

	[CompilerGenerated]
	private bool method_13(DreamPoeBot.Loki.Components.Actor.CoolDownDataStructure coolDownDataStructure_0)
	{
		return true;
	}

	[CompilerGenerated]
	private bool method_14(DreamPoeBot.Loki.Components.Actor.Struct181 struct181_0)
	{
		return true;
	}

	[CompilerGenerated]
	private bool method_15(DreamPoeBot.Loki.Components.Actor.CoolDownDataStructure coolDownDataStructure_0)
	{
		return true;
	}

	[CompilerGenerated]
	private bool method_16(long long_1)
	{
		return true;
	}

	[CompilerGenerated]
	private bool method_17(DreamPoeBot.Loki.Components.Actor.Struct181 struct181_0)
	{
		return true;
	}

	[CompilerGenerated]
	private bool method_18(Aura aura_0)
	{
		return true;
	}

	[CompilerGenerated]
	private Item method_19()
	{
		return null;
	}

	[CompilerGenerated]
	private float method_20()
	{
		return 0f;
	}

	[CompilerGenerated]
	private float method_21()
	{
		return 0f;
	}

	[CompilerGenerated]
	private float method_22()
	{
		return 0f;
	}

	[CompilerGenerated]
	private float method_23()
	{
		return 0f;
	}

	[CompilerGenerated]
	private float method_24()
	{
		return 0f;
	}

	[CompilerGenerated]
	private float method_25()
	{
		return 0f;
	}

	[CompilerGenerated]
	private Struct52 UawnkgkJar()
	{
		return (Struct52)(object)null;
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static Skill smethod_3()
	{
		return null;
	}
}
