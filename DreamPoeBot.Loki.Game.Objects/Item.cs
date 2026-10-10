using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Components;
using DreamPoeBot.Loki.FilesInMemory;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Utilities;
using DreamPoeBot.Loki.RemoteMemoryObjects;
using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

public class Item : RemoteMemoryObject
{
	[CompilerGenerated]
	private sealed class _003Cget_Affixes_003Ed__356 : IEnumerable<ModAffix>, IEnumerable, IEnumerator<ModAffix>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private ModAffix _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public Item _003C_003E4__this;

		private IEnumerator<ModAffix> _003C_003E7__wrap1;

		private static _003Cget_Affixes_003Ed__356 _003Cget_Affixes_003Ed__356_0;

		ModAffix IEnumerator<ModAffix>.Current => null;

		object IEnumerator.Current => null;

		public _003Cget_Affixes_003Ed__356(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}

		IEnumerator<ModAffix> IEnumerable<ModAffix>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static _003Cget_Affixes_003Ed__356 smethod_1()
		{
			return null;
		}

		static _003Cget_Affixes_003Ed__356()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private sealed class _003Cget_ExplicitAffixes_003Ed__350 : IEnumerable<ModAffix>, IEnumerable, IEnumerator<ModAffix>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private ModAffix _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public Item _003C_003E4__this;

		private IEnumerator<ModAffix> _003C_003E7__wrap1;

		private static _003Cget_ExplicitAffixes_003Ed__350 _003Cget_ExplicitAffixes_003Ed__350_0;

		ModAffix IEnumerator<ModAffix>.Current => null;

		object IEnumerator.Current => null;

		public _003Cget_ExplicitAffixes_003Ed__350(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}

		IEnumerator<ModAffix> IEnumerable<ModAffix>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static _003Cget_ExplicitAffixes_003Ed__350 smethod_1()
		{
			return null;
		}

		static _003Cget_ExplicitAffixes_003Ed__350()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private sealed class _003Cget_ImplicitAffixes_003Ed__352 : IEnumerable<ModAffix>, IEnumerable, IEnumerator<ModAffix>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private ModAffix _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public Item _003C_003E4__this;

		private IEnumerator<ModAffix> _003C_003E7__wrap1;

		internal static _003Cget_ImplicitAffixes_003Ed__352 _003Cget_ImplicitAffixes_003Ed__352_0;

		ModAffix IEnumerator<ModAffix>.Current => null;

		object IEnumerator.Current => null;

		public _003Cget_ImplicitAffixes_003Ed__352(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}

		IEnumerator<ModAffix> IEnumerable<ModAffix>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static _003Cget_ImplicitAffixes_003Ed__352 smethod_1()
		{
			return null;
		}

		static _003Cget_ImplicitAffixes_003Ed__352()
		{
			Class200.smethod_34();
		}
	}

	private int? nullable_0;

	private List<Item[]> list_0;

	private List<SocketColor[]> list_1;

	private byte[] byte_0;

	private SocketColor[] socketColor_0;

	private string string_0;

	private int? nullable_1;

	private string string_1;

	private string string_2;

	private bool? nullable_2;

	private bool? nullable_3;

	private int? nullable_4;

	private int? nullable_5;

	private int? wQrWisvHuw;

	private int? nullable_6;

	private int? nullable_7;

	private int? nullable_8;

	private int? nullable_9;

	private int? nullable_10;

	private InventoryTabMapSeries? nullable_11;

	private int? nullable_12;

	private int? nullable_13;

	private int? nullable_14;

	private int? nullable_15;

	private int? nullable_16;

	private int? nullable_17;

	private int? nullable_18;

	private int? nullable_19;

	private int? nullable_20;

	private int? nullable_21;

	private int? nullable_22;

	private int? nullable_23;

	private int? nullable_24;

	private int? xceWqvmihI;

	private int? nullable_25;

	private int? nullable_26;

	private int? nullable_27;

	private int? nullable_28;

	private int? nullable_29;

	private int? nullable_30;

	private int? nullable_31;

	private int? nullable_32;

	private int? nullable_33;

	private int? nullable_34;

	private int? nullable_35;

	private int? nullable_36;

	private int? nullable_37;

	private double? nullable_38;

	private double? nullable_39;

	private double? nullable_40;

	private double? nullable_41;

	private int? nullable_42;

	private int? nullable_43;

	private int? nullable_44;

	private int? nullable_45;

	private bool? nullable_46;

	private int? nullable_47;

	private int? nullable_48;

	private float? nullable_49;

	private float? nullable_50;

	private bool? nullable_51;

	private TimeSpan? nullable_52;

	private bool? nullable_53;

	private int? nullable_54;

	private int? nullable_55;

	private int? nullable_56;

	private double? nullable_57;

	private int? nullable_58;

	private uint? nullable_59;

	private SocketColor? nullable_60;

	private int? nullable_61;

	private GemQualityType? nullable_62;

	private List<ExpeditionWrapper> list_2;

	private int? OkrqohkNo0;

	private DatBaseItemTypeWrapper datBaseItemTypeWrapper_0;

	private int? nullable_63;

	private HashSet<MetadataFlags> hashSet_0;

	private CompositeItemType compositeItemType_0;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private Vector2i vector2i_0;

	[CompilerGenerated]
	private Vector2i vector2i_1;

	private EntityComponentInformation entityComponentInformation_0;

	private static Item item_0;

	public bool HasInventoryLocation
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
		[CompilerGenerated]
		internal set
		{
		}
	}

	public Vector2i LocationBottomRight
	{
		[CompilerGenerated]
		get
		{
			return (Vector2i)(object)null;
		}
		[CompilerGenerated]
		internal set
		{
		}
	}

	public Vector2i LocationTopLeft
	{
		[CompilerGenerated]
		get
		{
			return (Vector2i)(object)null;
		}
		[CompilerGenerated]
		internal set
		{
		}
	}

	public string Metadata => null;

	public new bool IsValid => true;

	public int Id => 0;

	public int InventoryId => 0;

	public bool HasCurrentAction => true;

	public DreamPoeBot.Loki.Components.Actor.ActionWrapper CurrentAction => null;

	public bool HasCurrentMoveAction => true;

	public DreamPoeBot.Loki.Components.Actor.ActionWrapper CurrentMoveAction => null;

	public bool IsDead => true;

	public int LocalId => 0;

	public string Name => null;

	public string FullName => null;

	public bool AppliesToCurrentAreaByLevel => true;

	public List<DatTagWrapper> Tags => null;

	public int AbsorbedCorruption => 0;

	public int ScourgedTier => 0;

	public int BaseWeaponType => 0;

	public int StackCount => 0;

	public int MaxStackCount => 0;

	public bool IsStackable => true;

	public int MaxCharges => 0;

	public double MaxChargesModifier => 0.0;

	public int MaxQuality => 0;

	public int MinMonsterLevel => 0;

	public int MaxMonsterLevel => 0;

	public int MinMonsterLevelPrefix => 0;

	public int MinMonsterLevelSuffix => 0;

	public Dictionary<StatTypeGGG, int> LocalStats => null;

	public Positioned PositionedComp => null;

	public bool IsHostile => true;

	public EntityComponentInformation Components => null;

	public DatBaseItemTypeWrapper BaseItemType => null;

	public bool FitsEquipRequirements => true;

	public int RequiredStr => 0;

	public int RequiredStrForNextLevel => 0;

	public int RequiredDex => 0;

	public int RequiredDexForNextLevel => 0;

	public int RequiredInt => 0;

	public int RequiredIntForNextLevel => 0;

	public string Class => null;

	public Rarity Rarity => (Rarity)(object)null;

	public int Quality => 0;

	public string AlternateQualityType => null;

	public int AlternateQualityTypeValue => 0;

	public int ItemLevel => 0;

	public bool IsIdentified => true;

	public Vector2i Size => (Vector2i)(object)null;

	public Skill Skill => null;

	public int SkillGemLevel => 0;

	public GemQualityType SkillGemQualityType => (GemQualityType)(object)null;

	public CompositeItemType CompositeType => null;

	public HashSet<MetadataFlags> Flags => null;

	public string SocketedDisplayString => null;

	public SocketColor SocketColor => (SocketColor)(object)null;

	public SocketColor[] SocketColors => null;

	public List<SocketColor[]> LinkedSocketColors => null;

	public uint SkillSocketIndex => 0u;

	public string DisplayNote => null;

	public int HivebloodRequired => 0;

	public int DroneCurrentCharges => 0;

	public int DroneMaxCharges => 0;

	public int SentinelDroneMaxDuration => 0;

	public int SentinelDroneEmpowerments => 0;

	public int SentinelDroneEmpowers => 0;

	public bool IsMirrored => true;

	public bool IsSynthesized => true;

	public bool IsFractured => true;

	public bool IsCorrupted => true;

	public int MaxCurrencyTabStackCount => 0;

	public bool HasFullStack => true;

	public Element UiElement => null;

	public string RenderArt => null;

	public bool HasSkillGemsEquipped => true;

	public bool HasMicrotransitionAttachment => true;

	public bool IsUsable => true;

	public int BaseRequiredLevel => 0;

	public int RequiredLevel => 0;

	public int RequiredLevelForNextLevel => 0;

	public bool IsChromatic => true;

	public byte[] SocketLinks => null;

	public int SocketCount => 0;

	public Item[] SocketedGems => null;

	public List<Item[]> SocketedSkillGemsByLinks => null;

	public int MaxLinkCount => 0;

	public int WorldItemId => 0;

	public bool IsShaperItem => true;

	public bool IsElderItem => true;

	public bool IsHunterItem => true;

	public bool IsWarlordItem => true;

	public bool IsCrusaderItem => true;

	public bool IsRedeemerItem => true;

	public bool IsRelic => true;

	public Vector2i WorldItemPosition => (Vector2i)(object)null;

	public Dictionary<StatTypeGGG, int> Stats => null;

	public Dictionary<StatTypeGGG, int> ImplicitStats => null;

	public Dictionary<StatTypeGGG, int> ExplicitStats => null;

	public int HighestImplicitValue => 0;

	public List<string> GemTypes => null;

	public bool IsInstantRecovery => true;

	public TimeSpan RecoveryTime => (TimeSpan)(object)null;

	public bool CanUse => true;

	public int CurrentCharges => 0;

	public int ChargesPerUse => 0;

	public int ChargesPerUseBase => 0;

	public int HealthRecover => 0;

	public float HealthRecoveredPerSecond => 0f;

	public int ManaRecover => 0;

	public float ManaRecoveredPerSecond => 0f;

	public List<ExpeditionWrapper> Expeditions => null;

	public int MapItemQuantity => 0;

	public int MapItemRarity => 0;

	public int MapLevel => 0;

	public int MapMonsterPackSize => 0;

	public int MapRawItemQuantity => 0;

	public int MapRawItemRarity => 0;

	public InventoryTabMapSeries MapSeries => (InventoryTabMapSeries)(object)null;

	public int MapTier => 0;

	public IEnumerable<ModAffix> ExplicitAffixes
	{
		[IteratorStateMachine(typeof(_003Cget_ExplicitAffixes_003Ed__350))]
		get
		{
			return null;
		}
	}

	public IEnumerable<ModAffix> ImplicitAffixes
	{
		[IteratorStateMachine(typeof(_003Cget_ImplicitAffixes_003Ed__352))]
		get
		{
			return null;
		}
	}

	public bool HasIncubator => true;

	public IEnumerable<ModAffix> Affixes
	{
		[IteratorStateMachine(typeof(_003Cget_Affixes_003Ed__356))]
		get
		{
			return null;
		}
	}

	public InventoryType ItemType => (InventoryType)(object)null;

	public int BaseMinPhysicalDamage => 0;

	public int BaseMaxPhysicalDamage => 0;

	public int MinPhysicalDamage => 0;

	public int MaxPhysicalDamage => 0;

	public double BaseAttacksPerSecond => 0.0;

	public double AttacksPerSecond => 0.0;

	public int MinDamage => 0;

	public int MaxDamage => 0;

	public int MinDps => 0;

	public int MaxDps => 0;

	public int MinChaosDamage => 0;

	public int MaxChaosDamage => 0;

	public int MinFireDamage => 0;

	public int MaxFireDamage => 0;

	public int MinLightningDamage => 0;

	public int MaxLightningDamage => 0;

	public int MinColdDamage => 0;

	public int MaxColdDamage => 0;

	public int MinElementalDamage => 0;

	public int MaxElementalDamage => 0;

	public double BaseCritialStrikeChance => 0.0;

	public double CritialStrikeChance => 0.0;

	public int BaseArmor => 0;

	public int ArmorValue => 0;

	public int BaseEnergyShield => 0;

	public int EnergyShieldValue => 0;

	public int BaseEvasion => 0;

	public int EvasionValue => 0;

	public bool IsActivated => true;

	public Item()
	{
	}

	public Item(long address, int localId)
	{
	}

	public Item(long address, int localId, int worldItemId)
	{
	}

	public Item(long address, bool hasInventoryLocation, Vector2i locationBottomRight, Vector2i locationTopLeft)
	{
	}

	public Item(long address, bool hasInventoryLocation, Vector2i locationBottomRight, Vector2i locationTopLeft, int id)
	{
	}

	internal Item(Class85 ii)
	{
	}

	public Item(Item item, bool hasInventoryLocation, Vector2i locationBottomRight, Vector2i locationTopLeft)
	{
	}

	public string Dump()
	{
		return null;
	}

	[SpecialName]
	private bool method_0()
	{
		return true;
	}

	[SpecialName]
	private bool method_1()
	{
		return true;
	}

	private int method_2(int int_0)
	{
		return 0;
	}

	public static int CalcGemStatReq(string name, int level, int multi)
	{
		return 0;
	}

	public int RequiredStrForLevel(int level)
	{
		return 0;
	}

	public int RequiredDexForLevel(int level)
	{
		return 0;
	}

	public int RequiredIntForLevel(int level)
	{
		return 0;
	}

	public bool HasMetadataFlags(params MetadataFlags[] flags)
	{
		return true;
	}

	public bool AnyMetadataFlags(params MetadataFlags[] flags)
	{
		return true;
	}

	public Item GetGemInSocket(int index)
	{
		return null;
	}

	public int GetSocketIndexForSkilGem(Item sg)
	{
		return 0;
	}

	public int GetSocketIndexOfGem(Item gem)
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	public int RequiredLevelForLevel(int level)
	{
		return 0;
	}

	[CompilerGenerated]
	private bool method_3(Skill skill_0)
	{
		return true;
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static Item smethod_3()
	{
		return null;
	}

	static Item()
	{
		Class200.smethod_34();
	}
}
