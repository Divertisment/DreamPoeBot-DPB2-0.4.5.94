using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Components;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.Game.Utilities;
using DreamPoeBot.Loki.Models;
using DreamPoeBot.Loki.RemoteMemoryObjects;
using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

public class Actor : NetworkObject
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct91
	{
		public readonly byte byte_0;

		private readonly byte byte_1;

		private readonly byte byte_2;

		private readonly byte byte_3;

		public readonly int int_0;

		public readonly int int_1;

		public readonly int int_2;

		public readonly NativeVector nativeVector_0;

		public readonly int int_3;

		public readonly int int_4;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct92
	{
		public readonly ushort ushort_0;

		public readonly ushort ushort_1;

		public readonly int int_0;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct93
	{
		public nint intptr_0;

		public NativeVector nativeVector_0;
	}

	private bool? nullable_25;

	private bool? nullable_26;

	private bool? nullable_27;

	private PerFrameCachedValue<bool> perFrameCachedValue_4;

	private PerFrameCachedValue<ActorFlags> perFrameCachedValue_5;

	private static Actor actor_0;

	public string LeftHandWeaponVisual => null;

	public string RightHandWeaponVisual => null;

	public string ChestVisual => null;

	public string HelmVisual => null;

	public string GlovesVisual => null;

	public string BootsVisual => null;

	public string UnknownVisual => null;

	public string LeftRingVisual => null;

	public string RightRingVisual => null;

	public string BeltVisual => null;

	public bool IsTargetingMe => true;

	public bool CorpseUsable => true;

	public Dictionary<StatTypeGGG, int> Stats => null;

	public Dictionary<StatTypeGGG, int> ModStats => null;

	public List<string> ModStatsList => null;

	public bool IsMoving => true;

	public bool IsUsingAbility => true;

	public bool IsAbilityCooldownActive => true;

	public bool InWashedUpState => true;

	public ActorFlags ActorFlags => (ActorFlags)(object)null;

	public List<Aura> Auras => null;

	public int Health => 0;

	public int MaxHealth => 0;

	public float HealthPercent => 0f;

	public float HealthPercentTotal => 0f;

	public int HealthReserved => 0;

	public int HealthReservedPercent => 0;

	public int Mana => 0;

	public int MaxMana => 0;

	public float ManaPercent => 0f;

	public float ManaPercentTotal => 0f;

	public int ManaReserved => 0;

	public float ManaReservedPercent => 0f;

	public int EnergyShield => 0;

	public int EnergyShieldMax => 0;

	public float EnergyShieldPercent => 0f;

	public float EnergyShieldPercentTotal => 0f;

	public int EnergyShieldReserved => 0;

	public float EnergyShieldReservedPercent => 0f;

	public IEnumerable<Skill> AvailableSkills => null;

	public bool IsDead => true;

	public IEnumerable<NetworkObject> DeployedObjects => null;

	public int BladeFlurryCharges => 0;

	public int FlameblastCharges => 0;

	public int ReaveCharges => 0;

	public int IncinerateCharges => 0;

	public int BladeVortexCharges => 0;

	public Aura PowerChargeAura => null;

	public int PowerCharges => 0;

	public Aura FrenzyChargeAura => null;

	public int FrenzyCharges => 0;

	public Aura EnduranceChargeAura => null;

	public int EnduranceCharges => 0;

	public Aura WinterOrbAura => null;

	public int WinterOrbCharges => 0;

	public bool HasCurrentAction => true;

	public DreamPoeBot.Loki.Components.Actor.ActionWrapper CurrentAction => null;

	public bool HasCurrentMoveAction => true;

	public DreamPoeBot.Loki.Components.Actor.ActionWrapper CurrentMoveAction => null;

	public bool TormentIsTouched => true;

	public bool TormentIsPossessed => true;

	public bool HasProximityShield => true;

	public bool HasContagion => true;

	public bool HasWither => true;

	public int MaxTotemCount => 0;

	public bool IsSpectating => true;

	public bool IsUsingHealthFlask => true;

	public bool IsUsingManaFlask => true;

	public bool IsUsingGraniteFlask => true;

	public bool IsUsingQuicksilverFlask => true;

	public bool IsUsingJadeFlask => true;

	public bool IsUsingDiamondFlask => true;

	public bool IsUsingSapphireFlask => true;

	public bool IsUsingAmethystFlask => true;

	public bool IsUsingRubyFlask => true;

	public bool IsUsingTopazFlask => true;

	public bool IsUsingQuartzFlask => true;

	public bool IsUsingBasaltFlask => true;

	public bool IsUsingAquamarineFlask => true;

	public bool IsUsingBismuthFlask => true;

	public bool IsUsingStibniteFlask => true;

	public bool IsUsingSulphurFlask => true;

	public bool IsUsingSilverFlask => true;

	public bool IsChilled => true;

	public bool IsFrozen => true;

	public bool IsIgnited => true;

	public bool IsBurning => true;

	public bool IsShocked => true;

	public bool IsBleeding => true;

	public bool HasLaviangasSpirit => true;

	public bool HasDivinationDistillate => true;

	public bool HasBloodOfTheKarui => true;

	public bool HasAtzirisPromise => true;

	public bool HasBloodRageBuff => true;

	public bool HasRighteousFireBuff => true;

	public bool HasArcticArmourBuff => true;

	public bool HasMoltenShellBuff => true;

	public bool HasTempestShieldBuff => true;

	public bool HasHeraldOfAshBuff => true;

	public bool HasHeraldOfIceBuff => true;

	public bool HasHeraldOfThunderBuff => true;

	public bool HasHeraldOfPurityBuff => true;

	public bool HasHeraldOfAgonyBuff => true;

	public bool HasPetrifiedBloodBuff => true;

	public bool HasSkitterbotsBuff => true;

	public bool HasClarityBuff => true;

	public bool HasVaalDeterminationBuff => true;

	public bool HasVaalVitalityBuff => true;

	public bool HasVaalClarityBuff => true;

	public bool HasVaalGraceBuff => true;

	public bool HasVaalDisciplineBuff => true;

	public bool HasVaalHasteBuff => true;

	public bool HasGluttonyOfElementsBuff => true;

	public bool HasAspectBirdBuff => true;

	public bool HasAspectCatBuff => true;

	public bool HasAspectCrabBuff => true;

	public bool HasAspectSpiderBuff => true;

	public bool HasEnduranceCharge => true;

	public bool HasPowerCharge => true;

	public bool HasFrenzyCharge => true;

	public bool HasWinterOrbCharge => true;

	public bool HasFleshOffering => true;

	public bool HasBoneOffering => true;

	public bool HasKaruiSpirit => true;

	public bool Invincible => true;

	public bool IsMissionAreaSpawn => true;

	public bool IsMissionMob => true;

	public bool IsCorruptedMissionBeast => true;

	public bool IsRelicInactive => true;

	public List<NetworkObject> DeployedMines => null;

	public List<NetworkObject> DeployedTraps => null;

	public List<NetworkObject> DeployedTotems => null;

	public List<NetworkObject> DeployedMinions => null;

	public float TimeSinceLastAction => 0f;

	public float TimeSinceLastMove => 0f;

	public bool IsCursedWithTemporalChains => true;

	public bool IsCursedWithNewPunishment => true;

	public bool IsCursedWithPunishment => true;

	public bool IsCursedWithAssassinsMark => true;

	public bool IsCursedWithPoachersMark => true;

	public bool IsCursedWithWarlordsMark => true;

	public bool IsCursedWithProjectileWeakness => true;

	public bool IsCursedWithConductivity => true;

	public bool IsCursedWithEnfeeble => true;

	public bool IsCursedWithFrostbite => true;

	public bool IsCursedWithFlammability => true;

	public bool IsCursedWithElementalWeakness => true;

	public bool IsCursedWithVulnerability => true;

	public bool IsCursedWithDespair => true;

	public bool IsCursingWithTemporalChains => true;

	public bool IsCursingWithNewPunishment => true;

	public bool IsCursingWithPunishment => true;

	public bool IsCursingWithAssassinsMark => true;

	public bool IsCursingWithPoachersMark => true;

	public bool IsCursingWithWarlordsMark => true;

	public bool IsCursingWithProjectileWeakness => true;

	public bool IsCursingWithConductivity => true;

	public bool IsCursingWithEnfeeble => true;

	public bool IsCursingWithFrostbite => true;

	public bool IsCursingWithFlammability => true;

	public bool IsCursingWithElementalWeakness => true;

	public bool IsCursingWithVulnerability => true;

	public bool IsCursingWithDespair => true;

	public int CurseCount => 0;

	public bool IsBreachMonster => true;

	public bool IsStrongboxMinion => true;

	public bool IsHarbingerMinion => true;

	internal Actor(EntityWrapper entity)
	{
	}

	private bool method_7()
	{
		return true;
	}

	public int GetStat(StatTypeGGG stat)
	{
		return 0;
	}

	public bool HasAura(string name)
	{
		return true;
	}

	public bool HasAura(IEnumerable<string> names)
	{
		return true;
	}

	public bool HasBuff(string aura)
	{
		return true;
	}

	public IEnumerable<Skill> GetSkillsByName(string name)
	{
		return null;
	}

	public bool HasSkillByName(string name)
	{
		return true;
	}

	public Skill GetSkillById(uint id)
	{
		return null;
	}

	public Skill GetSkillByName(string name)
	{
		return null;
	}

	private uint method_8(string string_2)
	{
		return 0u;
	}

	public bool HasCurseFrom(string skillName)
	{
		return true;
	}

	public bool HasConsideredAuraFrom(ActiveSkillsEnum @enum)
	{
		return true;
	}

	public bool HasCurseFrom(ActiveSkillsEnum @enum)
	{
		return true;
	}

	public bool IsCursingWith(ActiveSkillsEnum @enum)
	{
		return true;
	}

	public bool HasBuffFromSelf(BuffDefinitionsEnum @enum)
	{
		return true;
	}

	public bool HasBuffFromOther(BuffDefinitionsEnum @enum)
	{
		return true;
	}

	public IEnumerable<Aura> GetBuffs(BuffDefinitionsEnum @enum)
	{
		return null;
	}

	public Aura GetBuff(BuffDefinitionsEnum @enum)
	{
		return null;
	}

	public bool HasBuff(BuffDefinitionsEnum @enum)
	{
		return true;
	}

	public IEnumerable<Skill> GetSkills(ActiveSkillsEnum @enum)
	{
		return null;
	}

	public Skill GetSkill(ActiveSkillsEnum @enum)
	{
		return null;
	}

	public bool HasSkill(ActiveSkillsEnum @enum)
	{
		return true;
	}

	[CompilerGenerated]
	private bool method_9(Aura aura_0)
	{
		return true;
	}

	[CompilerGenerated]
	private bool method_10(Aura aura_0)
	{
		return true;
	}

	[CompilerGenerated]
	private bool method_11(Aura aura_0)
	{
		return true;
	}

	internal static bool smethod_24()
	{
		return true;
	}

	internal static Actor smethod_25()
	{
		return null;
	}

	static Actor()
	{
		Class200.smethod_34();
	}
}
