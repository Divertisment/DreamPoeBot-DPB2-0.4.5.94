using System.Collections.Generic;
using DreamPoeBot.Loki.Components;
using DreamPoeBot.Loki.Game.Objects;
using DreamPoeBot.Loki.Models;
using ns0;

namespace DreamPoeBot.Loki.Game.Utilities;

public class EntityComponentInformation : RemoteMemoryObject
{
	private readonly Entity entity_0;

	internal static EntityComponentInformation entityComponentInformation_0;

	public Entity Entity => null;

	public DreamPoeBot.Loki.Components.Actor ActorComponent => null;

	public Animated AnimatedComponent => null;

	public ArchnemesisMod ArchnemesisModComponent => null;

	public DreamPoeBot.Loki.Components.AreaTransition AreaTransitionComponent => null;

	public Armour ArmourComponent => null;

	public AttributeRequirements AttributeRequirementsComponent => null;

	public Base BaseComponent => null;

	public BaseEvents BaseEventsComponent => null;

	public Beam BeamComponent => null;

	public BlightTower BlightTowerComponent => null;

	public BreachObject BreachObject => null;

	public BrequelFruit BrequelFruitComponent => null;

	public Buffs BuffsComponent => null;

	public Charges ChargesComponent => null;

	public DreamPoeBot.Loki.Components.Chest ChestComponent => null;

	public ClientBetrayalChoice ClientBetrayalChoiceComponent => null;

	public Counter CounterComponent => null;

	public CurrencyInfo CurrencyInfoComponent => null;

	public DelveLight DelveLightComponent => null;

	public DelveNode DelveNodeComponent => null;

	public DiesAfterTime DiesAfterTimeComponent => null;

	public ExpeditionSaga ExpeditionSagaComponent => null;

	public Flask FlaskComponent => null;

	public GroundEffect GroundEffectComponent => null;

	public HeistBlueprint HeistBlueprintComponent => null;

	public HeistContract HeistContractComponent => null;

	public HeistRewardDisplay HeistRewardDisplayComponent => null;

	public Hull HullComponent => null;

	public IncursionTemple IncursionTempleComponent => null;

	public Inventories InventoriesComponent => null;

	public Life LifeComponent => null;

	public LimitedLifespan LimitedLifespanComponent => null;

	public LocalStats LocalStatsComponent => null;

	public Magnetic MagneticComponent => null;

	public Map MapComponent => null;

	public MinimapIcon MinimapIconComponent => null;

	public Mods ModsComponent => null;

	public DreamPoeBot.Loki.Components.Monolith MonolithComponent => null;

	public DreamPoeBot.Loki.Components.Monster MonsterComponent => null;

	public Movement Movement => null;

	public NPC NpcComponent => null;

	public ObjectMagicProperties ObjectMagicPropertiesComponent => null;

	public ObjectSpawner ObjectSpawnerComponent => null;

	public Pathfinding PathfindingComponent => null;

	public DreamPoeBot.Loki.Components.Player PlayerComponent => null;

	public PlayerClass PlayerClassComponent => null;

	public Pointer PointerComponent => null;

	public DreamPoeBot.Loki.Components.Portal PortalComponent => null;

	public Positioned PositionedComponent => null;

	public Preload PreloadComponent => null;

	public DreamPoeBot.Loki.Components.Projectile ProjectileComponent => null;

	public ProximityTrigger ProximityTrigger => null;

	public Quality QualityComponent => null;

	public Quest QuestComponent => null;

	public Render RenderComponent => null;

	public RenderItem RenderItemComponent => null;

	public SentinelDrone SentinelDroneComponent => null;

	public Shield ShieldComponent => null;

	public DreamPoeBot.Loki.Components.Shrine ShrineComponent => null;

	public SkillGem SkillGemComponent => null;

	public Sockets SocketsComponent => null;

	public Stack StackComponent => null;

	public StateMachine StateMachineComponent => null;

	public Stats StatsComponent => null;

	public Targetable TargetableComponent => null;

	public Timer Timer => null;

	public Tincture TinctureComponent => null;

	public Toggleable ToggleableComponent => null;

	public Transitionable TransitionableComponent => null;

	public DreamPoeBot.Loki.Components.TriggerableBlockage TriggerableBlockageComponent => null;

	public UltimatumTrial UltimatumTrialComponent => null;

	public Usable UsableComponent => null;

	public Weapon WeaponComponent => null;

	public WorldDescription WorldDescriptionComponent => null;

	public DreamPoeBot.Loki.Components.WorldItem WorldItemComponent => null;

	public EntityComponentInformation(EntityWrapper entity)
	{
	}

	public EntityComponentInformation(Entity entity)
	{
	}

	public EntityComponentInformation(Item entity)
	{
	}

	public EntityComponentInformation(long address)
	{
	}

	public bool HasComponent<T>() where T : Component, new()
	{
		return true;
	}

	public T GetComponent<T>() where T : Component, new()
	{
		return null;
	}

	public bool TryGetComponent<T>(out T component) where T : Component, new()
	{
		return true;
	}

	internal Dictionary<string, long> method_0()
	{
		return null;
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static EntityComponentInformation smethod_3()
	{
		return null;
	}

	static EntityComponentInformation()
	{
		Class200.smethod_34();
	}
}
