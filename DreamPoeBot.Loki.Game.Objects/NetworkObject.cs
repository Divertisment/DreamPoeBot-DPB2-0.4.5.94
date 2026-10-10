using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Common;
using DreamPoeBot.Loki.Components;
using DreamPoeBot.Loki.FilesInMemory;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.Game.Utilities;
using DreamPoeBot.Loki.Models;
using DreamPoeBot.Loki.RemoteMemoryObjects;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

public class NetworkObject : IEquatable<NetworkObject>
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct94
	{
		public nint intptr_0;

		public NativeVector nativeVector_0;

		public NativeVector nativeVector_1;

		public nint intptr_1;

		public int int_0;

		public byte byte_0;

		internal byte byte_1;

		internal byte byte_2;

		internal byte byte_3;

		public uint uint_0;

		public nint intptr_2;

		public nint intptr_3;

		public nint intptr_4;

		internal Struct13 struct13_0;

		internal Struct13 SlmlAfVunq7;

		internal Struct13 struct13_1;
	}

	internal sealed class Class104
	{
		private readonly StringBuilder stringBuilder_0;

		private int int_0;

		internal static Class104 class104_0;

		internal void Section(string title, Action read)
		{
		}

		internal void method_0(string string_0, object object_0)
		{
		}

		internal void method_1<T>(string string_0, Func<T> func_0)
		{
		}

		internal void Values<T>(string name, Func<IEnumerable<T>> read, Action<T> format)
		{
		}

		internal void Text(string value)
		{
		}

		public override string ToString()
		{
			return null;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class104 smethod_1()
		{
			return null;
		}

		static Class104()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private EntityWrapper entityWrapper_0;

	private bool? nullable_0;

	private readonly EntityComponentInformation entityComponentInformation_0;

	private static readonly ILog ilog_0;

	private bool? nullable_1;

	private string string_0;

	private Positioned positioned_0;

	private string string_1;

	private bool? nullable_2;

	private bool? nullable_3;

	private bool? nullable_4;

	private bool? nullable_5;

	private bool? nullable_6;

	private bool? nullable_7;

	private bool? nullable_8;

	private bool? nullable_9;

	private bool? nullable_10;

	private bool? nullable_11;

	private bool? nullable_12;

	private bool? nullable_13;

	private bool? nullable_14;

	private bool? MqeLraDoAh;

	private bool? nullable_15;

	private bool? nullable_16;

	private bool? nullable_17;

	private bool? nullable_18;

	private bool? nullable_19;

	private bool? nullable_20;

	private bool? nullable_21;

	private bool? nullable_22;

	private bool? nullable_23;

	private bool? nullable_24;

	private PerFrameCachedValue<bool> perFrameCachedValue_0;

	private PerFrameCachedValue<bool> perFrameCachedValue_1;

	private PerFrameCachedValue<EntityComponentInformation> perFrameCachedValue_2;

	private PerFrameCachedValue<Reaction> perFrameCachedValue_3;

	private static NetworkObject networkObject_0;

	public EntityWrapper _entity
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public EntityWrapper Entity => null;

	public Element Ui => null;

	public string AnimatedPropertiesMetadata => null;

	public NetworkObject AnimatedProperties => null;

	public bool BaseHashChanged => true;

	public int CharacterSize => 0;

	public Vector2i Position => (Vector2i)(object)null;

	public Vector2 WorldPosition => (Vector2)(object)null;

	public float Distance => 0f;

	public float DistanceSqr => 0f;

	public bool HasNpcFloatingIcon => true;

	public bool HasFaustusRewardIcon => true;

	public int Id => 0;

	public Vector3 InteractCenterWorld => (Vector3)(object)null;

	[Obsolete("Legacy Abyss API: not supported for the reworked encounter; retained for compatibility.", false)]
	public bool IsAbyssCrackSpawner => true;

	[Obsolete("Legacy Abyss API: not supported for the reworked encounter; retained for compatibility.", false)]
	public bool IsAbyssFinalNodeChest => true;

	[Obsolete("Legacy Abyss API: not supported for the reworked encounter; retained for compatibility.", false)]
	public bool IsAbyssFinalNodeSubArea => true;

	public bool IsAbyssNodeLarge => true;

	[Obsolete("Legacy Abyss API: not supported for the reworked encounter; retained for compatibility.", false)]
	public bool IsAbyssNodeSmall => true;

	[Obsolete("Legacy Abyss API: not supported for the reworked encounter; retained for compatibility.", false)]
	public bool IsAbyssStartNode => true;

	[Obsolete("Legacy Abyss API: not supported for the reworked encounter; retained for compatibility.", false)]
	public bool IsAbyssNodeMini => true;

	public bool IsLegionInitiator => true;

	public bool IsBeyondPortal => true;

	public bool IsBlightDefensiveTower => true;

	public bool IsNecropolisCorpse => true;

	public bool IsAbyssCraftingDevice => true;

	public bool IsUltimatumChallengeInteractable => true;

	public bool IsEffigyOfTheKing => true;

	public bool IsRiteOfTheNameless => true;

	public bool IsPrecursorReactor => true;

	public bool IsBurningMonolithSealedPassageway => true;

	public bool ArchnemesisIsTrapped => true;

	public bool IsAflictionInitiator => true;

	public bool IsBarrierKeyHole => true;

	public bool IsChayulaTree => true;

	public bool IsGrottoMirror => true;

	public bool IsBreach => true;

	public bool IsDoor => true;

	public bool IsHighlightable => true;

	public bool IsIgnoreHidden => true;

	public bool IsMinimapLabelVisible => true;

	public bool IsTargetable => true;

	public bool IsValid => true;

	public bool IsExpeditionRemnant => true;

	public bool HasHull => true;

	public Hull Hull => null;

	public string Metadata => null;

	public virtual string Name => null;

	public Reaction Reaction => (Reaction)(object)null;

	public bool IsFriendly => true;

	public bool IsHostile => true;

	public string Type => null;

	public float WorldDistance => 0f;

	public float WorldDistanceSqr => 0f;

	public EntityComponentInformation Components => null;

	public static implicit operator EntityWrapper(NetworkObject @object)
	{
		return null;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	static NetworkObject()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	public NetworkObject(EntityWrapper entity)
	{
	}

	public NetworkObject(Entity player)
	{
	}

	public NetworkObject(long address)
	{
	}

	public NetworkObject(long address, int id)
	{
	}

	private bool method_0()
	{
		return true;
	}

	private bool AnIqkPkPiJ()
	{
		return true;
	}

	private Reaction method_1()
	{
		return (Reaction)(object)null;
	}

	public bool Equals(NetworkObject other)
	{
		return true;
	}

	public override bool Equals(object obj)
	{
		return true;
	}

	public static bool operator ==(NetworkObject left, NetworkObject right)
	{
		return true;
	}

	public static bool operator !=(NetworkObject left, NetworkObject right)
	{
		return true;
	}

	internal NetworkObject method_2()
	{
		return null;
	}

	[SpecialName]
	internal Positioned method_3()
	{
		return null;
	}

	public string Dump()
	{
		return null;
	}

	private static void smethod_0(Class104 class104_0, string string_2, DreamPoeBot.Loki.Components.Actor.ActionWrapper actionWrapper_0)
	{
	}

	private static void smethod_1(Class104 class104_0, DreamPoeBot.Loki.Components.Actor actor_0)
	{
	}

	private void method_4(Class104 class104_0)
	{
	}

	private void method_5(Class104 class104_0, string string_2)
	{
	}

	private bool method_6(Class104 class104_0, string string_2)
	{
		return true;
	}

	private static void smethod_2(Class104 class104_0, DatBaseItemTypeWrapper datBaseItemTypeWrapper_0)
	{
	}

	private static void smethod_3(Class104 class104_0, DatTagWrapper datTagWrapper_0)
	{
	}

	private static void smethod_4(Class104 class104_0, InventoryVisual inventoryVisual_0)
	{
	}

	private static void smethod_5(Class104 class104_0, Item item_0)
	{
	}

	private static void smethod_6(Class104 class104_0, Entity entity_0)
	{
	}

	private static void smethod_7(Class104 class104_0, ItemMod itemMod_0)
	{
	}

	private static void smethod_8(Class104 class104_0, ModAffix modAffix_0)
	{
	}

	private static void smethod_9(Class104 class104_0, DatModsWrapper datModsWrapper_0)
	{
	}

	private static void smethod_10(Class104 class104_0, StatContainer statContainer_0)
	{
	}

	private static void smethod_11(Class104 class104_0, DatStatWrapper datStatWrapper_0)
	{
	}

	private bool oqqqjtbnmo(Class104 class104_0, string string_2)
	{
		return true;
	}

	private static void smethod_12(Class104 class104_0, NetworkObject networkObject_1)
	{
	}

	private static void smethod_13(Class104 class104_0, Aura aura_0)
	{
	}

	private static void smethod_14(Class104 class104_0, DatMinimapIconWrapper datMinimapIconWrapper_0)
	{
	}

	private static void smethod_15(Class104 class104_0, ExpeditionWrapper expeditionWrapper_0)
	{
	}

	private static void smethod_16(Class104 class104_0, DatUltimatumEncounterWrapper datUltimatumEncounterWrapper_0)
	{
	}

	private static void smethod_17(Class104 class104_0, DatUltimatumItemisedRewardWrapper datUltimatumItemisedRewardWrapper_0)
	{
	}

	private static void smethod_18(Class104 class104_0, DatUltimatumModifiersWrapper datUltimatumModifiersWrapper_0)
	{
	}

	private static void smethod_19(Class104 class104_0, AnimationStageList animationStageList_0)
	{
	}

	private static void smethod_20(Class104 class104_0, AnimationStage animationStage_0)
	{
	}

	private static void smethod_21(Class104 class104_0, ActiveAnimationData activeAnimationData_0)
	{
	}

	public bool ClickUi()
	{
		return true;
	}

	private bool tFuLlRrmi2(out Element element_0, out Vector2i vector2i_0)
	{
		return true;
	}

	internal static bool smethod_22()
	{
		return true;
	}

	internal static NetworkObject smethod_23()
	{
		return null;
	}
}
