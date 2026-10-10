using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Threading;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Common;
using DreamPoeBot.Loki.Components;
using DreamPoeBot.Loki.Elements;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.NativeWrappers;
using DreamPoeBot.Loki.Game.Objects;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.Game.Utilities;
using DreamPoeBot.Loki.RemoteMemoryObjects;
using log4net;
using ns0;
using SharpDX;

namespace DreamPoeBot.Loki.Game;

public static class LokiPoe
{
	public static class ObjectManager
	{
		public enum PoeObjectEnum
		{
			Unknown,
			Tarkleigh,
			Nessa,
			Bestel,
			Doorman,
			Captain_Fairgraves,
			Dying_Exile,
			Brutus_the_Warden,
			Merveil,
			Eramir,
			Yeena,
			Greust,
			Silk,
			Alira,
			Kraityn,
			Oak,
			Hargan,
			Lady_Dialla,
			Maramoa,
			Grigor,
			Clarissa,
			Shavronnes_Journal,
			Helena,
			Siosa,
			Piety,
			Gravicius,
			Dominus,
			King_Kaom,
			Maligaro_the_Inquisitor,
			Shavronne,
			Malachai,
			Daresso,
			Oba,
			Arteris_Letter,
			Letters_of_Exile,
			Weathered_Carving,
			Ancient_Graffiti,
			Ancient_Notebook,
			Sailors_Skin,
			Damp_Diary,
			Scion,
			Reverie_Device,
			Ancient_Reverie_Device,
			Transmutia_Device,
			The_Purity_Chronicles,
			Victarios_Writings,
			The_Ancients,
			Plaque,
			Etchings_on_Wood_IV,
			Etchings_on_Wood_III,
			Etchings_on_Wood_I,
			Etchings_on_Wood_II,
			Note,
			Proclamation,
			Chest_1,
			Chest_2,
			Lioneyes_Standard,
			Resonator_Instructions,
			Volls_Confession,
			Malachais_Notebook,
			Malachais_Dedication,
			Kira,
			Oyun,
			Petarus_and_Vanja,
			Dialla,
			Tasuni,
			Tora_Master_of_the_Hunt,
			Catarina_Master_of_the_Dead,
			Haku_Armourmaster,
			Vorici_Master_Assassin,
			Vagan_Weaponmaster,
			Elreon_Loremaster,
			Zana_Master_Cartographer,
			Leo_Master_of_the_Arena,
			Krillson_Master_Fisherman,
			Bronze_Monograph,
			Bronze_Plaque,
			Bronze_Inscription,
			Izaro,
			Poem,
			Letter_of_Instruction,
			Official_Orders,
			Journal_Entry,
			Malachais_Journal,
			Letter_to_Chitus,
			Rigwald,
			Inscription,
			Cadiro_Perandus,
			Navali,
			Dark_Tome,
			The_Cursed_King,
			Lycius_Midnights_Howl,
			Balek_Dawn,
			Einhar_Frey,
			The_Shaper,
			Lani,
			Vilenta,
			Utula,
			Bannon,
			Sin,
			Lilly_Roth,
			Weylam_Roth,
			Yama_the_White,
			Tukohama,
			Vaal_Letter,
			Tolman,
			Avarius,
			Innocence,
			Ode_to_Ralakesh,
			Love_Letter,
			Maligaros_Manifesto,
			Shrine_to_Arakaali,
			Kitavas_Hunger_I,
			Kitavas_Hunger_II,
			Kitavas_Hunger_III,
			Order_of_Protection,
			Shavronnes_Manifesto,
			Primitive_Carving,
			Worn_Carving,
			Karui_Carving,
			Message_in_a_Bottle,
			Leatherbound_Logbook,
			Letter_Fragment,
			Templar_Report,
			Shrine_to_the_Brine_King,
			Doedres_Manifesto,
			Solaris_Statue,
			Lunaris_Statue,
			Research_Journal,
			Triumph_of_Innocence,
			Stained_Glass_Window,
			Irasha,
			Cultist_Tract,
			Book_of_Memories,
			Memory_Fragment,
			Alva_Valai,
			Calaf_Headstaver,
			Merciless_Killer,
			Callow_Sniper,
			Kraityns_Scout,
			Kraityns_Sentry,
			Kraityns_Sniper,
			Aliras_Deadeye,
			Shadow_Archer,
			Targa_Beast_Poacher,
			Aliras_Blood_Hand,
			Kraityns_Stalwart,
			Guard_Stalwart,
			Oaks_Fist,
			Oaks_Guardian,
			Treacherous_Deserter,
			Guard_Archer,
			Kraityns_High_Guard,
			Aliras_Souleye,
			Alira_Darktongue,
			Kraityn_Scarbearer,
			Oak_Skullbreaker,
			Aliras_Martyr,
			Crazed_Martyr,
			Martyrs_Devoted,
			Doedres_Fanatic,
			Aliras_Blood_Guard,
			Callow_Thug,
			Shadow_Stalker,
			Heartless_Deserter,
			Kraityns_Thrall,
			Highwayman,
			ElderBlessed_Highwayman,
			Kraityns_Aspirant,
			Oaks_Devoted,
			Oaks_Brute,
			ElderBlessed_Brute,
			Ryslathas_Devoted,
			Ryslathas_Brute,
			Devoted_Bandit,
			Enterprising_Bandit,
			Lasar_the_Ambitious,
			Sumter_the_Twisted,
			Flarus,
			Frosis,
			Wolfpack_Ranger,
			Wolfpack_Guard,
			Stag_Acolyte,
			Greusts_Horn,
			ElderBlessed_Acolyte,
			Fallen_Azmeri,
			Bear_Acolyte,
			Greusts_Claw,
			Boar_Acolyte,
			Greusts_Tusk,
			ALIRA_SPECTATOR,
			OAK_SPECTATOR,
			KRAITYN_SPECTATOR,
			The_Animal_Pack,
			Rotting_Stalwart,
			Cave_Beast,
			Enraptured_Beast,
			Primal_Beast,
			The_Alpha_Beast,
			The_Great_White_Beast,
			The_Great_White_Bones,
			Primordius,
			Kartarus,
			Pallid_Vision,
			Bone_Cruncher,
			Hairy_Bonecruncher,
			Shaggy_Monstrosity,
			Thicket_Hulk,
			Skeletal_Beast,
			Corrupted_Beast,
			Doomed_Hibernator,
			Tyrannursus_Maximus,
			Armour_Cruncher,
			Forest_Beast,
			Brutus_Lord_Incarcerator,
			Fidelitas_the_Mourning,
			Kruug_the_Frayed,
			Vaal_Oversoul,
			Jikshah,
			Merveil_the_Siren,
			Merveil_the_Twisted,
			Spectral_Corsair,
			Spectral_Scoundrel,
			Ashen_Buccaneer,
			Forgotten_Buccaneer,
			Spectral_Swashbuckler,
			Cursed_Mariner,
			Spectral_Bowman,
			Phantom_Occultist,
			Grave_Corsair,
			Soulless_Mariner,
			Deathless_Buccaneer,
			Revenant_Purser_,
			Charging_Corsair,
			First_Mate_Crastus,
			Telvar_the_Inebriated,
			Spectral_Mage,
			Spectral_Buccaneer,
			Spectral_Captain,
			Spectral_Ordnance,
			Daemon,
			Fairgraves_Corsair,
			Savvy_Mariner,
			Deadly_Buccaneer,
			Lost_Corsair,
			Borboss_the_Bruiser,
			Lost_Mariner,
			Lost_Buccaneer,
			Fairgraves_Purser,
			Goatman,
			ElderBlessed_Goatman,
			Goatman_Stomper,
			Abberaths_Elite,
			Mephods_Elite,
			Bearded_Devil,
			Alpine_Devil,
			Gavuum_Goldhoof,
			Venmur_the_Bloodgrin,
			Mortumus_the_Second,
			Mortumus_the_Third,
			Gururu_the_Growler,
			Kulgul_Mortalbane,
			Shivrul_Goatqueen,
			Mortumus_the_Other_One,
			Rektar_the_Breaker,
			The_Faun,
			Goatman_Shaman,
			Goatman_Fireraiser,
			Bearded_Shaman,
			Bearded_Skycaller,
			Alpine_Shaman,
			Hill_Devil,
			Colossus_Crusher,
			Ungulath,
			Ancient_Construct,
			Ancient_Sentry_Apparatus,
			Fragment_Boss,
			Cairn_Annihilator,
			Vaal_Construct,
			Vaal_Soul,
			Archaic_Construct,
			Flame_Hellion,
			Dune_Hellion,
			Highland_Hellion,
			Demonic_Hellion,
			Wolf,
			Arctic_Wolf,
			Snow_Wolf,
			Freezing_Wolf,
			Wolf_of_the_First_Ones,
			Dire_Wolf,
			Winterfang,
			Storm_Eye,
			Solus_Pack_Alpha,
			Spectral_Wolf_Companion,
			Enthralled_Dire_Wolf,
			The_Burning_Menace,
			Menacing_Vision,
			Hellion,
			ElderBlessed_Hellion,
			Ruins_Hellion,
			Mountain_Hellion,
			Mountain_Hellion_Alpha,
			Enslaved_Hellion,
			Brood_Pup,
			Enraptured_Hellion,
			Shackled_Hellion,
			Blood_Ape,
			Dread_Primate,
			Stygian_Ape,
			Nadia_the_Soothing,
			Aidan_the_Frenzied,
			Shadow_Ape,
			Infested_Ape,
			Blood_Chieftain,
			Carnage_Chieftain,
			Stygian_Silverback,
			Aboriginal_Chieftain,
			Prime_Ape,
			Host_Chieftain,
			Hollowskull_the_Willing_Host,
			Carnage_Ape,
			Barrow_Ape,
			Primitive_Ape,
			Ruined_Titan,
			Stalag_Nightmare,
			Rumbling_Mass,
			Hulking_Titan,
			Gneiss,
			ROCK_OUT,
			Churning_Titan,
			King_Rollem,
			Fiery_Rollem,
			Icey_Rollem,
			Chaotic_Rollem,
			Erosive_Rubble,
			Frozen_Titan,
			Mountain_Fragment,
			Fiery_Rubble,
			Panicked_Rubble,
			Rubble_Golem,
			Necromancer,
			Kadavrus_the_Defiler,
			Sawbones,
			Sin_Master,
			Defiler,
			Diabolist,
			Sin_Lord,
			Thunder_Whisperer,
			Fated_Necromancer,
			Doedres_Animator,
			The_Bone_Sculptor,
			Bringer_of_Souls,
			Rhoa_Scavenger,
			ElderBlessed_Rhoa,
			Adolescent_Rhoa,
			Primordial_Rhoa,
			The_First_Rhoa,
			Albino_Rhoa,
			Great_Rhoa,
			Murk_Runner,
			Charmed_Charger,
			Summoned_Rhoa,
			Oozeback_Bloom,
			Pestilent_Vision,
			Bone_Rhoa,
			Corrupted_Rhoa,
			Bone_Scavenger,
			Zombie_Rhoa,
			Ventarus,
			Infested_Rhoa,
			Gravel_Eater,
			Fossil_Eater,
			Colossal_Spitter,
			Sand_Spitter,
			Scrabbling_Spitter,
			Granite_Eater,
			Rock_Spitter,
			Crustacean_Sniper,
			Crustacean_Pelter,
			Infested_Sniper,
			Obsidian_Eater,
			The_Deep_Dweller,
			Charmed_Spitter,
			Merveils_Favoured,
			Ambrosia_Daughter_of_Merveil,
			Amarissa_Daughter_of_Merveil,
			Merveils_Daughter,
			Merveils_Attendant,
			Merveils_Chosen,
			Merveils_Retainer,
			Brood_Princess,
			Brood_Child,
			Singing_Siren,
			Merveils_Blessed,
			Fated_Siren,
			Scrabbling_Menace,
			Cave_Crustacean,
			Invading_Crustacean,
			Infested_Crustacean,
			Deep_Crustacean,
			Shield_Crab,
			Bleached_Crustacean,
			Brittle_Mage,
			Archbishop_Geofri_the_Abashed,
			Fairgraves_Never_Dying,
			Chatters,
			Ironpoint_the_Forsaken,
			Fated_Archer,
			Ancient_Archer,
			Timeless_Hunter,
			Brittle_Lookout,
			Brittle_Bornagain,
			Brittle_Poacher,
			Sandy_Lookout,
			Burning_Bowman,
			Weathered_Watchman,
			Vault_Hunter,
			Brittle_Archer,
			Sin_Archer,
			Thunder_Thrall,
			Plagued_Bowman,
			Brittle_Bleeder,
			Disbanded_Dead,
			Vexing_Archer,
			Bonewarped_Archer,
			Bloodstained_Archer,
			Azmeri_Ancestor,
			Bone_Archer,
			Axiom_Frostguard,
			Frost_Archmage,
			Frost_Bishop,
			Frost_Priest,
			Frost_Keeper,
			Frost_Preacher,
			Frost_Rattler,
			Frost_Harbinger,
			Malachais_Enlightened,
			Gleaming_Saint,
			Desecrated_Saint,
			Brittle_Arsonist,
			Flame_Archmage,
			Flame_Bishop,
			Smouldering_Embermage,
			Flame_Priest,
			Flame_Harbinger,
			Smouldering_Infernomage,
			Flame_Rattler,
			Flame_Preacher,
			Axiom_Thunderguard,
			Servant_of_Rukuku,
			Thunder_Archmage,
			Thunder_Bishop,
			Thunder_Harbinger,
			Thunder_Priest,
			Thunder_Keeper,
			Thunder_Preacher,
			Thunder_Champion,
			Thunder_Rattler,
			Sparking_Mage,
			Ancient_Bonestalker,
			Brittle_Cleric,
			Brittle_Thief,
			Rattling_Bones,
			Vault_Guardian,
			Timeless_Wanderer,
			Sandworn_Watchman,
			Ash_Harvester,
			Angered_Remains,
			Risen_Saint,
			Sandy_Guardian,
			Ancient_Worker,
			Brittle_Gladiator,
			Risen_Gladiator,
			Brittle_Bandit,
			Brittle_Farmer,
			Smouldering_Farmer,
			Nightmarish_Farmer,
			Bonewarped_Warrior,
			Bloodstained_Warrior,
			Ancient_Convict,
			Colossal_Bonestalker,
			Awoken_Giant,
			Frost_Guardian,
			Frost_Champion,
			Frost_Relicguard,
			Volkuurs_Frostguard,
			Flame_Guardian,
			Flame_Champion,
			Flame_Relicguard,
			Volkuurs_Flameguard,
			Fairgraves_Crewman,
			Lost_Crewman,
			Pirate_Lords_Crewman,
			Bone_Warden,
			Sparking_Bones,
			Thunder_Guardian,
			Thunder_Relicguard,
			Volkuurs_Stormguard,
			Shavronnes_Admirer,
			Vaal_Fallen,
			Colossal_Vaal_Fallen,
			Vaal_Gargantuan,
			Blightblade,
			Vaal_Frost_Guardian,
			Vaal_Flame_Guardian,
			Vaal_Bone_Warden,
			Vaal_Slayer,
			Vaal_Arsonist,
			Vaal_Frostguard,
			Vaal_Thunderguard,
			Bravalo,
			Skeleton_Engineer,
			Undead_Engineer,
			Cinder_Bones,
			Icy_Bones,
			Crackling_Bones,
			Brittle_Flametosser,
			Brittle_Chillcaller,
			Brittle_Stormtouched,
			Scarecrow,
			Crow_Keeper,
			Effigy_of_Fear,
			Slitherskin,
			Brush_Viper,
			Night_Adder,
			Host_Adder,
			Serpentine_Construct,
			Spine_Construct,
			Wiraqucha_Ancient_Guardian,
			Bramble_Cobra,
			ElderBlessed_Cobra,
			Host_Cobra,
			Seleslatha,
			Acid_Slitherer,
			Crypt_Stalker,
			Glade_Mamba,
			Charmed_Cobra,
			Summoned_Cobra,
			Cursed_Spawn,
			Fathom_Screamer,
			Flesh_Eater,
			Sirens_Spawn,
			Slimy_Bloodsucker,
			Foreseen_Spawn,
			DrTestopus,
			EleReflectopus,
			PhysReflectopus,
			Spawn_Boss,
			Unstable_Larva,
			Brood_Larva,
			Slimy_Nemesis,
			Venomous_Spawn,
			Broodling,
			Black_Death,
			Deathly_Vision,
			The_Weaver,
			Balah_Duke,
			Great_Webmother,
			Lurking_Venom,
			Nesting_Spider,
			Nesting_Venom,
			Vaal_Recluse,
			Noxious_Tarantula,
			Deadly_Tarantula,
			Leaping_Spider,
			Arakaalis_Daughter,
			Webbed_Spider,
			Virulent_Spider,
			Ink_Spinner,
			Cave_Arach,
			Corrupted_Arach,
			Crypt_Spinner,
			Crypt_Weaver,
			Mutant_Arach,
			Crypt_Ambusher,
			Corrupted_Spitter,
			Cave_Skitterer,
			Spindle_Spider,
			Hatchling,
			Adolescent_Arachnid,
			Mature_Arachnid,
			Davnalleous,
			Brooding_Tarantula,
			Buried_Tarantula,
			Maligaros_Inspiration,
			Enraptured_Arachnid,
			Essence_Tarantula,
			Widows_Hatchling,
			Widows_Skitterer,
			Soulmourn,
			Suncaller_Asha,
			Talin_Faithbreaker,
			Petrification_Statue,
			Kuduku_the_False_God,
			Rukuku_the_Pagan_God,
			Kadaka_the_Goddess_of_Luck,
			Grinning_Totem,
			Vaal_Totem,
			Carnage_Pillar,
			Charging_Totem,
			Fuming_Totem,
			Billowing_Totem,
			Humming_Totem,
			Whispering_Totem,
			Puruna_the_Challenger,
			Poporo_the_Highest_Spire,
			Crystal_Ice_Spires,
			RENAME_ME,
			Totem,
			Seething_Brine,
			Stranglecharm,
			Captain_Pollution,
			Crashing_Brine,
			Tide_Strider,
			Flood_Strider,
			Boiling_Ambusher,
			Boiling_Strider,
			Sand_Strider,
			Bubbling_Gold,
			Clearwater_Strider,
			Bubbling_Wave,
			Crashing_Wave,
			Riptide,
			Brine_Princess,
			Sulphuric_Strider,
			Burning_Essence,
			Freezing_Essence,
			Crackling_Essence,
			Hungry_Corpse,
			Hillock,
			Jaesyn,
			placeholder_boss,
			Plague_Retch,
			Aliras_Dearest,
			Cauldron_Zombie,
			Avatar_of_Rot,
			Towering_Aberration,
			Lingering_Aberration,
			Volatile_Awakened,
			Drowned,
			Unthinking,
			Unstable_Drowned,
			Drowned_Champion,
			Dripping_Dead,
			Unstable_Aberration,
			Tolman_the_Exhumer,
			Sleepy_Dead,
			Awakened,
			Darktongue_Thrall,
			Darktongue_Servant,
			Darktongue_Slave,
			Darktongue_Risen,
			Pale_Husk,
			Shambling_Cadaver,
			Devout_Dead,
			Sewage_Cadaver,
			Doedres_Loyal,
			Sutured_Aberration,
			Rotting_Damned,
			Withered_Husk,
			Fetid_Shambler,
			Oozing_Dead,
			Wrapped_Nobleman,
			Dessicated_Maraketh,
			Rotten_Gladiator,
			Rotten_Veteran_Gladiator,
			Child_of_Lunaris,
			Captain_Aurelianus,
			Fleshrend_Grand_Inquisitor,
			Blackguard_Mage,
			Blackguard_Arcmage,
			ElderBlessed_Arcmage,
			Solarsworn_Infernomage,
			Lunarsworn_Wintermage,
			Solarsworn_Archmage,
			Lunarsworn_Archmage,
			Compulsor_Octavia_Sparkfist,
			Oriaths_Virtue,
			Blackguard_Firemage,
			Blackguard_Stormmage,
			Blackguard_Chaplain,
			Blackguard_Scout_Commander,
			Blackguard_Elite,
			Solaris_Elite,
			Lunaris_Elite,
			Solaris_Champion,
			Lunaris_Champion,
			Draconarius_Wilhelm_Flamebrand,
			Imperator_Stantinus_Bitterblade_,
			Oriaths_Vengeance,
			Oriaths_Vigil,
			Gravicius_Elite_Guard,
			Praetorian_Guard,
			Mortality_Experimenter,
			Reanimator,
			Flesh_Sculptor,
			Blackguard_Scout,
			ElderBlessed_Scout,
			Blackguard_Soldier,
			Lunar_Scout,
			Solar_Scout,
			General_Gravicius,
			Regulus_Suns_Herald,
			Aloris_the_First_Light,
			Nightbringer_Lucius,
			Nebria_the_Last_Light,
			Guard,
			Guard_Captain,
			Captain_Arteri,
			Piety_the_Abomination,
			Nightmare_Manifest,
			Blackguard_of_Hatred,
			Blackguard_of_Wrath,
			Blackguard_Spectre,
			Blackguard_Enforcer,
			Blackguard_Interrogator,
			Legius_Garhall,
			Temple_Scholar,
			Cato_Scholar_of_Light,
			Barthol_the_Pure,
			Cato_Defiler_of_Light,
			Barthol_the_Corruptor,
			Crimson_Scholar,
			Shadow_Scholar,
			Elite_Bodyguard,
			Kole,
			Maker_of_Mires,
			The_Brute,
			Pietys_Miscreation,
			Miscreation,
			Sacrificial_Demon,
			ElderBlessed_Miscreation,
			Lunar_Miscreation,
			Slashed_Miscreation,
			Shavronnes_Student,
			Orcus_the_Reaver,
			The_Broken_Prince,
			Drenched_Miscreation,
			Moontouched_Miscreation,
			Burned_Miscreation,
			Shocked_Miscreation,
			Augmented_Dead,
			Shavronnes_Legacy,
			Spinecrack,
			Horror_Archon,
			Whipping_Miscreation,
			ElderBlessed_Torturer,
			Night_Horror,
			Dusk_Horror,
			Student_of_Pain,
			Alal_the_Terrifying,
			The_Fallen_Queen,
			Tentacle_Miscreation,
			ElderBlessed_Abberation,
			Lunaris_Concubine,
			Student_of_Torture,
			Kali_the_Crazed,
			The_Hollow_Lady,
			Fated_Miscreation,
			Demonic_Martyr,
			Fetid_Maw,
			Murk_Fiend,
			Filth_Maw,
			Gloomglut,
			Bestial_Maw,
			Great_Maw,
			Infested_Maw,
			Plumed_Chimeral,
			Vibrant_Chimeral,
			Feral_Chimeral,
			Chrometouched_Chimeral,
			Chromeinfused_Chimeral,
			Wild_Chimeral,
			Clutch_Queen,
			Paradisae_Venenum,
			Sallazzang,
			Chimeric_Croaker,
			Prized_Croaker,
			Vaulting_Croaker,
			Chrometouched_Croaker,
			Chromeinfused_Croaker,
			Banner_of_Passion,
			Banner_of_Knowledge,
			Banner_of_Action,
			The_Infernal_Seal,
			The_Voltaic_Seal,
			Galvanic_Ribbon,
			Flame_Sentinel,
			Infernal_Sentinel,
			Assault_Ribbon,
			Rime_Sentinel,
			Frost_Sentinel,
			Carrion_Queen,
			Ryslatha_the_Puppet_Mistress,
			Gorulis_WillThief,
			Carrion_Minion,
			Carrion_Swarmer,
			Carrion_Burrower,
			Carrion_Raider,
			Scum_Crawler,
			Explosive_Crawler,
			Explosive_Horror,
			Nightmarish_Carrion,
			Nightmarish_Crawler,
			Testling,
			THIS_IS_A_BUG,
			Avian_Retch,
			ElderBlessed_Retch,
			Vassal_of_Inti,
			Gluttonous_Gull,
			Blooddrinker,
			Tyranny_Archon,
			Sire_of_the_Falling_Skies,
			Frozen_Locustcaller,
			Fiery_Locustcaller,
			Thundering_Locustcaller,
			Locust_Swarm,
			Voidbearer,
			Fiend_Archon,
			The_Shipyard_Terror,
			Harbinger,
			Flame_Beast,
			Nightbearer,
			Maligaros_Passion,
			Maligaros_Cruelty,
			Cinder_Elemental,
			Living_Fury,
			Hatebeat,
			Hatestorm,
			Ash_Prophet,
			Death_Bishop,
			Undying_Incinerator,
			Undying_Alchemist,
			Traitorous_Incinerator,
			Dominus_High_Templar,
			The_High_Templar,
			Gods_Chosen,
			Dominus_Ascendant,
			The_Hallowed_Husk,
			Sewage_Crawler,
			Toxic_Crawler,
			Flayed_Warrior,
			Restless_Labourer,
			Restless_Archer,
			Flayed_Archer,
			Scorched_Guard,
			Scorched_Mage,
			Incinerated_Mage,
			Enlightened_Vicar,
			Bleak_Aspirant,
			Crackling_Acolyte,
			Bleak_Vicar,
			Crackling_Vicar,
			Spine_Serpent,
			Infested_Serpent,
			Barb_Serpent,
			Sand_Serpent,
			Crypt_Arachnid,
			Porcupine_Goliath,
			Thistleback_Goliath,
			Chrometouched_Goliath,
			Chromeinfused_Goliath,
			Thistlesage,
			The_Goddess_of_Purity,
			Purity_Restored,
			Marceus_the_Defaced,
			Marceus_the_Hidden,
			Fencer_Statue,
			Maul_Statue,
			Brittle_Fencer,
			Brittle_Maul_Statue,
			Archer_Statue,
			Figment_of_Swords,
			Figment_of_Destruction,
			Figment_of_Winds,
			Idolised_Saint,
			Aurate_Warrior,
			Aurate_Archer,
			Embezzlers_Offer,
			Embezzlers_Own,
			Giant_Gladiator_Statue,
			Towering_Figment,
			Overgrown_Colossus,
			Auric_Champion,
			Auric_Colossus,
			Martial_Statue,
			Giant_Statue,
			Majestic_Statue,
			Auric_Lion,
			Molten_Lion,
			Blood_Elemental,
			Aggravated_Wound,
			Crimson_Ichor,
			Coagulated_Elemental,
			Fevered_Clot,
			Doedres_Ichor,
			Tainted_Water,
			Mephitic_Maiden,
			Noxious_Maiden,
			Doedres_Vitriol,
			Congealed_Blood,
			Unstable_Clot,
			Purged_Fluids,
			Vengeful_Blood,
			Congealed_Mud,
			Fated_Coagulate,
			Holy_Water,
			Undying_Untouchable,
			Undying_Subject,
			Undying_Inductor,
			Undying_Shredder,
			Undying_Champion,
			Undying_Engineer,
			Ancient_Sculptor,
			Ancient_Architect,
			Undying_Worker,
			Undying_Labourer,
			Undying_Operator,
			Undying_Archivist,
			Stinking_Undying,
			Undying_Cultist,
			Undying_Degenerate,
			Undying_Wretch,
			Undying_Evangelist,
			Student_of_Brutality,
			Maligaros_Acolyte,
			Trinian_Intellectus_Prime,
			The_Arbiter_of_Knowledge,
			Undying_Aristocrat,
			Undying_Socialite,
			Undying_Initiate,
			Undying_Patrician,
			Undying_Shade,
			Undying_Dreg,
			Caliga_Imperatrix,
			Excellis_Aurafix,
			Shavronnes_Envy,
			Shavronnes_Greed,
			Riftwalker,
			The_Uncreated,
			The_Unshaped,
			Agent_of_the_Void,
			Void_Remnant,
			Abhorred_Elitist,
			The_Stockkeeper,
			Undying_Grappler,
			Shavronnes_Gemling,
			Augmented_Grappler,
			Perpetus,
			Undying_Outcast,
			Undying_Impaler,
			Undying_Ravager,
			Dockhand_Wraith,
			Labourer_Wraith,
			Foreman,
			Brittle_Longshoreman,
			Brittle_Corsair,
			Raised_Zombie,
			Shadow_Minion,
			Summoned_Skeleton,
			Summoned_Phantasm,
			Volatile_Phantasm,
			Energised_Phantasm,
			Summoned_Skeleton_Soldier,
			Summoned_Skeleton_Archer,
			Summoned_Skeleton_Caster,
			Summoned_Skeleton_Colossus,
			Summoned_Skeleton_General,
			Summoned_Skeleton_Sniper,
			Summoned_Skeleton_Deathmage,
			Profane_Thrall,
			Desecrated_Thrall,
			Champion_of_the_Feast,
			Shaman_of_the_Feast,
			Guardian_of_the_Feast,
			Spawn,
			Molten_Skeleton,
			Unearthly_Skeleton,
			Pure_Water,
			Pagan_Bishop_of_Agony,
			Litanius_the_Black_Prayer,
			Penitentiary_Incarcerator,
			Penitentiary_Incarcerator_,
			Fire_and_Fury,
			Loathe,
			The_Blacksmith,
			DroughtMaddened_Rhoa,
			Titan_of_the_Grove,
			Megaera,
			Beast_of_the_Pits,
			Steelpoint_the_Avenger,
			Champion_of_Frost,
			Thunderskull,
			Belcer_the_Pirate_Lord,
			Enticer_of_Rot,
			Witch_of_the_Cauldron,
			Xixic_High_Necromancer,
			Shock_and_Horror,
			Lady_of_the_Brood,
			Glace,
			The_Idol_Beyond,
			Achioc_the_Glacier,
			Levioc_the_Volcano,
			Zorioc_the_Storm,
			Izioc_the_Abyss,
			Olmec_the_All_Stone,
			Flame_of_Truth,
			Merveil_the_Reflection,
			Merveil_the_Returned,
			Master_of_the_Blade,
			Leif_the_SwiftHanded,
			Plaguebringer,
			Lord_of_the_Bow,
			Lord_of_the_Ashen_Arrow,
			Massier,
			Spirit_of_Nadia,
			Spirit_of_Aidan,
			Spinner_of_False_Hope,
			Queen_of_the_Great_Tangle,
			Oak_the_Mighty,
			Aulen_Greychain,
			Shadow_of_the_Vaal,
			Atziris_Chosen,
			Asphyxia,
			Mother_Phyia,
			Avatar_of_the_Tempest,
			Blood_Progenitor,
			The_Primal_One,
			Skullbeak,
			Volcanus,
			Herald_of_Ashes,
			Herald_of_Thunder,
			The_Reaver,
			Blackguard_Avenger,
			Blackguard_Tempest,
			The_Wicked_One,
			Piety_the_Empyrean,
			Carnage,
			Diallas_Anger,
			Diallas_Hatred,
			Diallas_Wrath,
			Emperor_Radiant,
			Lady_Stormflay,
			Warmonger,
			Tyrant,
			Bramblemist,
			Arachnoxia,
			Hybrid_Widow,
			Mistress_of_Flame,
			Infector_of_Dreams,
			Rose,
			Thorn,
			Mistress_Hyseria,
			Burning_Totem,
			Chilling_Totem,
			Shocking_Totem,
			Diamond_Totem,
			Warping_Totem,
			Detonation_Totem,
			Frenzy_Totem,
			Endurance_Totem,
			Power_Totem,
			Ice_Totem,
			Necromantic_Totem,
			Shockwave_Totem,
			Healing_Totem,
			VaalInfused_Totem,
			Fickle_Totem,
			Burning_Portal,
			Chilling_Portal,
			Orra_Greengate,
			Thena_Moga,
			Thena_Moga_the_Crimson_Storm,
			Antalie_Napora,
			Silva_Fearsting,
			Ailentia_Rac,
			Torr_Olgosso,
			Armios_Bell,
			Antonio_Bravadi,
			Zacharie_Desmarais,
			Oyra_Ona,
			Minara_Anemina,
			Igna_Phoenix,
			Aria_Vindicia,
			Dena_Lorenni,
			Ultima_Thule,
			Kirmes_Olli,
			Jonah_Unchained,
			Damoi_Tui,
			Xandro_Blooddrinker,
			Haki_Karukaru,
			Vickas_Giantbone,
			Bolt_Brownfur,
			Bolt_Brownfur_Earth_Churner,
			Ohne_Trix,
			Eoin_Greyfur,
			Tinevin_Highdove,
			Doven_Falsetongue,
			Magnus_Stonethorn,
			Aurelio_Voidsinger,
			Baracus_Phraxisanct,
			Ion_Darkshroud,
			Ion_Darkshroud_the_Hungering_Blade,
			Ash_Lessard,
			Jarek_Irontrap,
			Wilorin_Demontamer,
			Ulysses_Morvant,
			Jade,
			Augustina_Solaria,
			Lael_Furia,
			Vanth_Agiel,
			Shade_of_a_Scion,
			Shade_of_a_Templar,
			Shade_of_a_Duelist,
			Shade_of_a_Marauder,
			Shade_of_a_Shadow,
			Shade_of_a_Witch,
			Shade_of_a_Ranger,
			Darbel_LePage,
			Elusive_Twin,
			Phantasmal_Twin,
			Nightmarish_Twin,
			Blood_Sister,
			Guardian_of_the_South,
			Guardian_of_the_North,
			Guardian_of_the_West,
			Guardian_of_the_East,
			Revived_Guardian,
			Tormented_Temptress,
			Devourer,
			Tunnelworm,
			Unstable_Devourer,
			Captive_Devourer,
			Ancient_Devourer,
			Elder_Devourer,
			The_Conqueror_Wurm,
			Tunneltrap,
			Mystic_Devourer,
			Cannibal,
			Cannibals_Devoted,
			Fire_Fury,
			Bameth_Cultist,
			Lunaris_Zealot,
			Moontouched_Zealot,
			Harbinger_Fanatic,
			Harbinger_Worshipper,
			Lunar_Devotee,
			Harbinger_Puppet,
			Hailrake,
			Herald_of_Bameth,
			Cannibal_Fireeater,
			Shrine_Daemon,
			Nemesis_Daemon,
			Boss_Daemon,
			Tempest_Daemon,
			Trap_Daemon,
			Animated_Guardian,
			Animated_Weapon,
			Animated_Axe,
			Animated_Sword,
			Animated_Staff,
			Collector,
			The_Steel_Soul,
			Ghostly_Steel,
			Nightmare_Steel,
			Mutilators_Blade,
			Mutilators_Hatchet,
			Mutilators_Knife,
			Mutilators_Claw,
			Mutilators_Needle,
			Kinslayers_Sword,
			Kinslayers_Axe,
			Kinslayers_Dagger,
			Kinslayers_Claw,
			Kinslayers_Rapier,
			Aspect_of_Rage,
			Aspect_of_Fury,
			Aspect_of_Violence,
			Living_Memorial,
			Living_Relic,
			Marchaks_Eviscerator,
			Marchaks_Impaler,
			Marchaks_Annihilator,
			Aspect_of_Destruction,
			Aspect_of_Annihilation,
			Aspect_of_Ruination,
			Soulless_Watcher,
			Drifting_Eye,
			Cavern_Drifter,
			Sewer_Drifter,
			Infected_Watcher,
			Avatar_of_Ash,
			Avatar_of_Winter,
			Avatar_of_Silence,
			Avatar_of_Apocalypse,
			Raging_Spirit,
			Bloodwings_Raven,
			Raven,
			Blood_Raven,
			Ancestral_Spirit,
			Death_Raven,
			Creeping_Fire,
			Desecrated_Bonestalker,
			Plummeting_Ursa,
			Tunnelfiend,
			Infested_Tunnelfiend,
			Birthed_Ursa,
			Woods_Ursa,
			Infested_Ursa,
			Scourge_of_the_Wilds,
			Quru,
			It_That_Fell,
			Spectral_Ursa,
			Summoned_Ursa,
			Kaoms_Primacy,
			Kaoms_Sign,
			Kaoms_Heart,
			Kaoms_Roots,
			Qura,
			Yaraaz,
			Aalai,
			Kaj_Qura,
			Kaj_Yaraaz,
			Kaj_Aalai,
			Slithering_Servant,
			Frozen_Supplicant,
			Storming_Supplicant,
			Vaal_Unknowable,
			Lost_Unknowable,
			Vaal_Unthinkable,
			Lost_Unthinkable,
			Atziris_Devoted,
			Vaal_Unspeakable,
			Lost_Unspeakable,
			Vessel_of_the_Vaal,
			The_Chaos_Engine,
			Atziri_Queen_of_the_Vaal,
			The_Allseeing_Eye,
			Konu_Maker_of_Wind,
			Coniraya_Shadow_of_Malice,
			Atziris_Pride,
			Sheaq_Maker_of_Floods,
			Ossecati_Boneshaper,
			Kamaq_Soilmaker,
			Inti_of_the_Blood_Moon,
			Shrapnelbearer,
			Cava_Artist_of_Pain,
			Curator_Miem,
			Simi_the_Nature_Touched,
			Aspect_of_Simi,
			The_Sunburst_Queen,
			Mgaska_the_Living_Pyre,
			Cintiq_the_Inescapable,
			Thornrunner,
			Perquil_the_Lucky,
			Haviri_Vaal_Metalsmith,
			Kutec_Vaal_Fleshsmith,
			Shadow_of_Vengeance,
			Beheader_Ataguchu,
			Wiraq_the_Impaler,
			Chaska_Maker_of_Rain,
			Mother_of_the_Hive,
			Rima_Deep_Temptress,
			Torrent_of_Fear,
			Commander_of_Flesh,
			Captain_of_the_Damned,
			Quetzerxi,
			Agnerax,
			Agnerix,
			Calxipher,
			Evocata_Apocalyptica,
			Docere_Incarnatis,
			Corrector_Draconides,
			Whisperers_Attendant,
			Dario_the_Living_Void,
			Balus_Stoneskull,
			Kall_Foxfly,
			Marrowcrush,
			The_Cadaver_Bull,
			Junglemare,
			The_Sanguine_Wave,
			Blood_Stasis_,
			Blood_Morpher,
			Graveblood,
			Nighteater,
			The_Book_Burner,
			The_Bolt_Juggler,
			Avatar_of_Pain,
			Rancor,
			Hatespitter,
			Bluntslag,
			The_Revenant,
			Judgement_Apparatus,
			Spinesnap,
			Genesis_Paradisae,
			Death_from_Above,
			Guardian_of_the_Mound,
			Wonderwalker,
			The_Raging_Mask,
			The_Teetering_Mask,
			The_Furious_Mask,
			The_Callous_Mask,
			The_Capricious_Mask,
			Alpha_Paradisae,
			Mother_of_the_Swarm,
			Deathflutter,
			Bladetooth,
			Granitecrush,
			Corpsestitch,
			The_Firestarter,
			Wrigglechaw,
			Blinkflame,
			The_Duchess,
			Shivershell,
			Mammothcage,
			Harbinger_of_Elements,
			Nightsight,
			Tailsinger,
			Razorleaf,
			Stranglecreep,
			Pewterfang,
			Bladeback_Guardian,
			Strangledrift,
			Jikeji,
			Ghostram,
			Stranglecrawl,
			Mirageblast,
			The_Walking_Waste,
			Glassmaul,
			Grath,
			Burtok_Conjurer_of_Bones,
			The_Spiritless,
			Droolscar,
			Double,
			Flesh_of_Bameth,
			Blood_of_Haast,
			Eye_of_Tzteosh,
			Hand_of_Naem,
			Worshipper_of_Bameth,
			Hound_of_Tzteosh,
			Servant_of_Haast,
			Mouth_of_Ephij,
			Fanatic_of_Ephij,
			Disciple_of_Haast,
			Zealot_of_Tzteosh,
			Tzteosh_Hungering_Flame,
			Ephij_Crackling_Sky,
			Haast_Unrelenting_Frost,
			Bameth_Shifting_Darkness,
			Naem_Bending_Stone,
			Abaxoth_the_End_of_All_That_Is,
			Blood_of_Bameth,
			Eye_of_Bameth,
			Vagans_Companion,
			Relic,
			Resplendent_Construct,
			Heir_of_Flame,
			Heir_of_Storm,
			Merveils_Blade,
			Target_Dummy,
			_____________________________________,
			Placeholder_1,
			Placeholder_2,
			Placeholder_3,
			Placeholder_4,
			Corrupted_Horde,
			Corrupted_Miscreation,
			Corrupted_Undying_Worshipper,
			Corrupted_Settler,
			Corrupted_Brood_Nurse,
			Corrupted_Furyfoot_Devil,
			Corrupted_Fire_Thrower,
			Corrupted_Bone_Lord,
			Corrupted_Python,
			Corrupted_Invader,
			Elite_Mercenary,
			Mage_Mercenary,
			Hired_Ruffian,
			Hired_Thug,
			Captive_Agent,
			Charred_Totem,
			Glistening_Totem,
			Rugged_Totem,
			Tahi,
			Boka,
			Necribrae,
			Blightraise,
			Rua,
			Wha,
			Toru,
			Magma_Elemental,
			Ice_Elemental,
			Storm_Elemental,
			Corrupted_Crawler,
			Corrupted_Swarmer,
			Corrupted_Ashweaver,
			Corrupted_Iceweaver,
			Corrupted_Martyr,
			Corrupted_Larva,
			Scion_of_Corruption,
			Corrupted_Wretch,
			Corrupted_Bonestalker,
			Rotting_Corrupted,
			Corrupted_Hound,
			Corrupted_Skullbearer,
			Corrupted_Deadeye,
			Corrupted_Thug,
			Corrupted_Guard,
			Corrupted_Bonereaver,
			Corrupted_Fireshot,
			Corrupted_Gull,
			Corrupted_Incinerator,
			Corrupted_Undying,
			Corrupted_Tarantula,
			Corrupted_Spider,
			Corrupted_Daughter,
			Corrupted_Spawn,
			Corrupted_Experimenter,
			Corrupted_Blackguard,
			Sickly_Spinner,
			Infected_Spiker,
			Infected_Beast,
			Infested_Beast,
			Risen_Infested_Beast,
			Crawling_Infestation,
			Rabid_Broodqueen,
			Rabid_Minion,
			Crazed_Chieftain,
			Putrid_Chimeral,
			Infected_Ambusher,
			Mutated_Ursa,
			Crazed_Flamebeast,
			Infected_Rhoa,
			Rabid_Rhoa,
			Putrid_Weaver,
			Infected_Adder,
			Surging_Adder,
			Putrid_Serpent,
			Rabid_Maw,
			Fused_Crawler,
			Shock_Spitter,
			Mutated_Watcher,
			Mutated_Broodqueen,
			Mutated_Croaker,
			Mutated_Arachnid,
			Twisted_Chimeral,
			Mutated_Flamebeast,
			Mutated_Winterclaw,
			Mutated_Chieftain,
			Mutated_Rhoa,
			Mutated_Adder,
			Mutated_Maw,
			Rotting_Zombie,
			Rotting_Mummy,
			Bone_Bird,
			Rotting_Outcast,
			Rotting_Weaver,
			Charred_Skeleton,
			Reanimated_Skeleton,
			Bound_Reaver,
			Bound_Seeker,
			Test_Trap,
			Fire_Trap,
			Storm_Call_Trap,
			Ice_Storm_Trap,
			Ball_Lightning_Trap,
			Blast_Rain_Trap,
			Ethereal_Knives_Trap,
			Blade_Blossom,
			Boring,
			Grandmaster,
			Tormented_Storm_Cultist,
			Tormented_Blasphemer,
			Tormented_Necromancer,
			Tormented_Arsonist,
			Tormented_Thief,
			Tormented_Mutilator,
			Tormented_Charlatan,
			Tormented_Cannibal,
			Tormented_Alchemist,
			Tormented_Vaal_Cultist,
			Tormented_Thug,
			Tormented_Rogue,
			Tormented_Illegal_Fisherman,
			Tormented_Seditionist,
			Tormented_Cutthroat,
			Tormented_Spy,
			Tormented_Martyr,
			Tormented_Embezzler,
			Tormented_Forger,
			Tormented_Warlord,
			Tormented_Aurora_Cultist,
			Tormented_Smuggler,
			Tormented_Bootlegger,
			Tormented_Buccaneer,
			Echo_of_Shavronne,
			Wraith,
			Doedres_Suffering,
			Doedres_Torment,
			Torment_Daemon,
			Clone,
			Mirage,
			Pale_Blackguard,
			Thrall_of_Lunaris,
			Pale_Commander,
			Mindless_Scavenger,
			Scavenging_Vulture,
			Rotting_Vulture,
			Infested_Vulture,
			The_Hundred_Foot_Shadow,
			The_Winged_Death,
			Meritarus,
			Volls_Fallen,
			Eternal_Woe,
			Fallen_Horror,
			Digested_Bones,
			Impure_Soldier,
			Crystallised_Fallen,
			Sun_Bleached_Fallen,
			Bloodstained_Fallen,
			Dreadmore,
			Bloodsoaked_Fallen,
			Impure_Archer,
			Volls_Vanguard,
			Crystallised_Sentry,
			Sun_Bleached_Vanguard,
			Bloodstained_Vanguard,
			Bloodsoaked_Vanguard,
			Nightwane,
			Mirage_of_Bones,
			Splinter_Liege,
			const_1532,
			Muck_Vortex,
			Blood_Vortex,
			Blackwater,
			Legion_of_Lost_Souls,
			const_1537,
			Whispering_Spiral,
			Flood_Orb,
			Vortex,
			Voll_Emperor_of_Purity,
			The_Brittle_Emperor,
			Planus_Hollow_Soul,
			Corrupted_Elite,
			Dust_Scrabbler,
			Spiritflicker,
			Ululat_MaggotBearer,
			LeapLeapLeap,
			Dirt_Scrabbler,
			Infested_Skitterer,
			Lowlands_Hopper,
			Sand_Skitterer,
			Sand_Leaper,
			Knitted_Horror,
			Timeless_Horror,
			Tangled_Remains,
			Bleached_Horror,
			Bonestilts,
			Bundle_of_Woe,
			Unravelling_Horror,
			Embers_of_the_Past,
			Shrieker,
			Voidscream,
			Shrieker_Eihal,
			Howler,
			Screecher,
			Pocked_Miner,
			Pocked_Mason,
			Pocked_Plunderer,
			Pikerivet,
			Lord_of_the_Hollows,
			Pocked_Lanternbearer,
			Pocked_Flamebringer,
			Pocked_Illuminator,
			The_Burning_Man,
			Messenger_of_the_Hollows,
			Tunneler,
			Crawler,
			Burrower,
			Hammerstorm,
			Breaker_Toruul,
			Pocked_Goliath,
			Pocked_Giant,
			Pocked_Behemoth,
			Sewer_Goliath,
			Large_Miner,
			Champion_of_the_Hollows,
			Chaos_Sentinel,
			Chaos_Guardian,
			Muruk_the_Awakened,
			Void_Anomaly,
			Avatar_of_Undoing,
			Chaos_Golem,
			Protective_Golem,
			Ebers_Colossus,
			Guardian_Golem,
			The_Dreadstone,
			Hyrris_Sister,
			Hyrris_Ambusher,
			Kaoms_Chosen,
			Laviangas_Acolyte,
			Tukohamas_Scout,
			Tukohamas_Warrior,
			Tukohamas_Vanguard,
			Fury_Hound,
			War_Hound,
			Jawchaw,
			Raihara_Tukohamas_Loyal,
			Inua_Totem,
			Traitorous_Totem,
			Flameweeper,
			Vakali_Totem,
			Torchoak_Grove,
			Forest_of_Flames,
			Sapling,
			Tukohamas_Rage,
			Seedling,
			Rakango,
			Triskeriaki,
			War_Rakango,
			The_Infernal_King,
			Pitbull_Demon,
			Vicious_Hound,
			Steelchaw,
			Gnar_Eater_of_Carrion,
			Pit_Butcher,
			Rooster_Fiend,
			Rooster_Demon,
			Talon_Archer,
			Eyepecker,
			Stonebeak_Battle_Fowl,
			Talon_Demon,
			Feral_Fowl,
			Barkhul,
			Tore_Towering_Ancient,
			Olof_Son_of_the_Headsman,
			Avatar_of_Thunder,
			Mad_Gladiator,
			Bringer_of_Blood,
			Fighting_Bull,
			Avalanche_Rider,
			Grazing_Taurus,
			Battlecharger,
			Crusher_of_Gladiators,
			Boulderback,
			Shredder_of_Gladiators,
			Daresso_King_of_Swords,
			Ambrius_Legion_Slayer,
			Echo_of_Daresso,
			Wandering_Eye,
			Wideeyed_Assemblage,
			Pain_Witness,
			Strabismal_Sentry,
			Static_Eye,
			Doedres_Sight,
			Eye_Hatchery,
			The_Mother_of_Pus,
			Gut_Flayer,
			Arranged_Anatomy,
			Boiled_Dead,
			Gut_Spiker,
			Noisome_Ophidian,
			Death_Blossom,
			Maligaro_The_Inquisitor,
			Prodigy_of_Pain,
			He_of_Many_Pieces,
			Echo_of_Maligaro,
			Doedre_Darktongue,
			Prodigy_of_Hexes,
			Erythrophagia,
			Echo_of_Doedre,
			Headmistress_Braeta,
			Shavronne_of_Umbra,
			Prodigy_of_Darkness,
			Gisale_Thought_Thief,
			Malachai_The_Nightmare,
			Eater_of_Souls,
			Nightmares_Omen,
			Icy_Manifestation,
			Brittle_Shard,
			Window_Shard,
			Obsidian_Golem,
			Fragment_of_Winter,
			Volatile_Ice,
			Brittle_Ice,
			Ice_Golem,
			Lesser_Ice_Golem,
			Bound_Ice,
			Volatile_Fire,
			Flame_Golem,
			Lesser_Flame_Golem,
			Volcanic_Golem,
			Solarborn_Golem,
			Meteor_Golem,
			Bound_Flame,
			Hateful_Fire,
			Volatile_Poison,
			Stormstruck_Golem,
			Lightning_Golem,
			Jiquanis_Creation,
			Omnitects_Guard,
			Energy_Aberration,
			Bound_Storm,
			Stone_of_the_Currents,
			Blood_Worm,
			Writhing_Worm,
			Savage_Crab,
			Enraptured_Crab,
			Infested_Crawler,
			Infested_Crab,
			Crab_Champion,
			Bleached_Crawler,
			Primordial_Creation,
			TESTORATOR,
			Herald_of_Ash,
			Brinerot_Raider,
			Brinerot_Soothsayer,
			Brinerot_Stormhand,
			Musky_TwoEyes_Grenn,
			Susara_Siren_of_Pondium,
			Lussi_Rotmother_Roth,
			Mutewind_Wildrunner,
			Mutewind_Lynx,
			Mutewind_Hexbinder,
			Mutewind_Snowsinger,
			Yorishi_Aurorasage,
			Jeinei_Yuushu,
			Otesha_the_Giantslayer,
			Redblade_Skullbreaker,
			Redblade_Flamelord,
			Redblade_Warmonger,
			Uruk_Baleh,
			ElAbin_Bloodeater,
			Leli_Goya_Daughter_of_Ash,
			Binaia_Crimson_Rain,
			Rama_The_Kinslayer,
			Kalria_The_Fallen,
			Kalria_The_Risen,
			Risen_Legionnaire,
			Risen_Archer,
			Risen_Battlemage,
			Invari_The_Bloodshaper,
			Lokan_The_Deceiver,
			Marchak_The_Betrayer,
			Berrots_The_Breaker,
			Vessider_The_Unrivaled,
			Morgrants_The_Deafening,
			Gemling_Legionnaire,
			Ironclad_Arsonist,
			Ironclad_Demolisher,
			Ironclad_Decimator,
			Gemling_Captain,
			Captain_Tanner_Lightfoot,
			Heart_of_the_Beast,
			Stygian_Revenant,
			Escaped_Revenant,
			The_Bone_Queen,
			Thraxia,
			Dimachaeri_Cassius,
			Mevia,
			Rudiarius_Felix,
			Mevion,
			Avatar_of_the_Huntress,
			Avatar_of_the_Skies,
			Avatar_of_the_Forge,
			Argus,
			Hephaeus_The_Hammer,
			Dancing_Dervish,
			Grave_Spirit,
			Doedres_Hatred,
			Stone_Golem,
			Animated_Stone,
			Hill_Shard,
			Hill_Fragment,
			Hill_Remnant,
			Animated_Reef,
			Defiled_Proclamation,
			Arctic_Golem,
			The_Eroding_One,
			Guardian_of_the_Vault,
			Pirate_Treasure,
			Regenerative_Golem,
			Fiery_Crystal,
			Icy_Crystal,
			Talisman_Daemon,
			Wither_Daemon,
			AnimatedWeapon,
			Endless_Pain,
			Endless_Hazard,
			Endless_Drought,
			Endless_Sting,
			Unending_Lethargy,
			Unending_Frost,
			Unending_Fire,
			Unending_Storm,
			Goddess_of_Justice,
			The_Goddess,
			Vision_of_Justice,
			Lieutenant_of_Rage,
			Lieutenant_of_the_Bow,
			Lieutenant_of_the_Mace,
			Invisible,
			Banner_of_Hatred,
			Unbound_Rhoa,
			Unbound_Beast,
			Unbound_Hellion,
			Unbound_Primate_Chieftain,
			Unbound_Primate,
			Unbound_Cobra,
			Unbound_Arachnid,
			Unbound_Razormaw,
			Unbound_Chimeral,
			Unbound_Retch,
			Unbound_Ursa,
			Unbound_Gazer,
			Rigwald_the_Wolven_King,
			Relentless_Rhoa,
			Soul_of_Summer,
			Soul_of_Winter,
			Echo_of_the_Verdant,
			Charging_Bull,
			Charged_Engineer,
			Frozen_Builder,
			Immolator,
			Burning_Follower,
			Ryslathas_Nest,
			Gorulis_Nest,
			Burning_Ember,
			Guardian_of_the_Goddess,
			Cinder_Claimant,
			Burnt_Claimant,
			Ember_Claimant,
			Frost_Claimant,
			Rime_Claimant,
			Thundrous_Claimant,
			Storm_Claimant,
			Bitter_Deceiver,
			Seething_Deceiver,
			Fulminating_Deceiver,
			Accursed_Deceiver,
			Maze_Webspinner,
			Maze_Hatchling,
			Ancient_Contender,
			Putrescent_Contender,
			Rotting_Claimant,
			Eternal_Reanimator,
			Rotting_Contender,
			Eternal_Servant,
			Rime_Servant,
			Cinder_Servant,
			Shadow_Lurker,
			Molten_Shaker,
			Ancient_Combatant,
			Maze_Crusher,
			Undead_Guardian,
			Marionette,
			Spectral_Artisan,
			Skulking_Dweller,
			Maze_Needleback,
			Maze_Slitherer,
			Crushing_Mass,
			Muck_Elemental,
			Poisonous_Rat,
			Plague_Totem,
			Swarming_Rat,
			Overgrown_Rat,
			Bonechomp,
			Blue_Frog,
			Common_Frog,
			Strange_Frog,
			Karui_Spirit,
			Font_of_Lethargy,
			Font_of_Fragility,
			Font_of_Elements,
			SteelImbued_Gargoyle,
			QuicksilverImbued_Gargoyle,
			GraniteImbued_Gargoyle,
			Chromatic_Gargoyle,
			Chrometouched_Gargoyle,
			Threshold_of_Anger,
			Threshold_of_Hatred,
			Threshold_of_Wrath,
			Flame_Idol,
			Frost_Idol,
			Storm_Idol,
			Perandus_Daemon,
			Junith_Perandus_Keeper_of_Vaults,
			Platinia_Servant_of_Prospero,
			Platinia,
			Tantalo_Perandus_Seller_of_Secrets,
			Auriot_Prosperos_Furnace_Guardian,
			Auriot,
			Actaeo_Perandus_Master_of_Beasts,
			Rhodion_Servant_of_Prospero,
			Rhodion,
			Vitorica_Perandus_Maker_of_Marvels,
			Osmea_Servant_of_Prospero,
			Stasius_Perandus_Merchant_of_Corpses,
			Pallias_Servant_of_Prospero,
			Pallias,
			Darsia_Perandus_Collector_of_Debts,
			Argient_Servant_of_Prospero,
			Argient,
			Milo_Perandus_Handler_of_Swords,
			Rheniot_Servant_of_Prospero,
			Rheniot,
			Celona_Vault_Sentry,
			Hortus_Knee_Breaker,
			Kuto_Hired_Muscle,
			Luthis_Bounty_Hunter,
			Belatra_Hired_Assassin,
			Liana_Indebted_Peasant,
			Marius_Indebted_Smuggler,
			Vera_Indebted_Aristocrat,
			Percia_Indebted_Poacher,
			Sutrus_Vault_Binder,
			Otairo_Vault_Binder,
			Eiphirio_Vault_Binder,
			Artensia_Vault_Binder,
			Anaveli_Vault_Binder,
			Rothus_Vault_Binder,
			Arinea_Vault_Binder,
			Meritania_Vault_Binder,
			Shackled_Apparition,
			Guard_Hound,
			Phantom_Outcast,
			Phantom_Impaler,
			Phantom_Untouchable,
			Plumed_Apparition,
			Croaking_Apparition,
			Highborn_Evangelist,
			Highborn_Grappler,
			Devoted_Archer,
			Devoted_Thug,
			Devoted_Warrior,
			Indebted_Wretch,
			Indebted_Incinerator,
			Spectral_Hireling,
			Spectral_Mercenary,
			Perandus_Concubine,
			Perandus_Servant,
			Izaro_Charges,
			Parasite,
			Ravenous_Parasite,
			Broodspawn_Parasite,
			Vicious_Parasite,
			The_Encephelophage,
			Poisonous_Parasite,
			Plated_Parasite,
			Spitting_Parasite,
			Brine_Vassal,
			Swarthy_Mollusc,
			Eber_the_Plaguemaw,
			Inya_the_Unbearable_Whispers,
			Yriel_the_Feral_Lord,
			Volkuur_the_Unbreathing_Queen,
			Echo_of_the_Vaal,
			Remembered_Construct,
			Vaal_Memory,
			Prophecy_Daemon,
			Rania_Skyborne,
			Lora_the_Contender,
			Terese_Napora,
			Ancient_Hero,
			Ancient_Dead,
			Malachais_Laureate,
			Purge_Hound,
			Lola_the_Fierce,
			Rocco_the_Bloodthirsty,
			Volatile_Tome,
			Whispering_Tome,
			Wicker_Man,
			Avarius_Reassembled,
			Guardian_of_the_Phoenix,
			Phoenix,
			Guardian_of_the_Hydra,
			Guardians_Reflection,
			Guardian_of_the_Minotaur,
			Guardian_of_the_Chimera,
			Twisted_Effigy,
			Carius_the_Unnatural,
			Exartze_the_Woven_Stone,
			Slave_Driver,
			Crazed_Driver,
			Overseer_Krow,
			Arwyn_the_Houndmaster,
			Temple_Justicar,
			Twisted_Justicar,
			Depraved_Justicar,
			Justicar_Casticus,
			Executioner_Bloodwing,
			Blackguard_Stalker,
			Warped_Regurgitator,
			Slave_Catcher,
			Deranged_Slaver,
			Depraved_Slaver,
			Fleshmonster,
			Titan_Totem,
			Guardians_Goatman,
			Avatar_of_the_Goat,
			Guardians_Hellion,
			Avatar_of_the_Hellion,
			Guardians_Snake,
			Avatar_of_the_Snake,
			Anomaly,
			Volatile_Anomaly,
			Volatile_Core,
			WIP,
			Energy_Locus,
			Essence_Spirit,
			Shaped_Kaoms_Chosen,
			Shaped_Hyrris_Sister,
			Shaped_Rooster_Demon,
			Shaped_Pitbull_Demon,
			Shaped_Undying_Worker,
			Shaped_Undying_Archivist,
			Shaped_Undying_Grappler,
			Shaped_Vaal_Recluse,
			Shaped_Noxious_Tarantula,
			Shaped_Deadly_Tarantula,
			Shaped_Callow_Thug,
			Shaped_Shadow_Stalker,
			Shaped_Highwayman,
			Flame_Mother,
			The_Matriarch,
			Pileah_Corpse_Burner,
			The_Risen_Matriarch,
			Pileah_Burning_Corpse,
			The_Rotten_Matriarch,
			Kiln_Mother,
			Blessed_Sister,
			Sanguine_Sister,
			Temple_Ward,
			Temple_Guardian,
			Heretical_Ward,
			Heretical_Guardian,
			Xophs_Loyal,
			Displaced_Loyal,
			Xophs_Favoured,
			Chayulas_Perfected,
			They_of_Tul,
			Scale_of_Esh,
			Displaced_Scale,
			UulNetols_Trophy,
			UulNetols_Pet,
			It_That_Watches,
			It_of_Tul,
			It_That_Waits,
			It_That_Is_Displaced,
			It_That_Whispers,
			Chayulas_Ideal,
			It_That_Reaches,
			Xoph_Dark_Embers,
			Tul_Creeping_Avalanche,
			Esh_Forked_Thought,
			UulNetol_Unburdened_Flesh,
			Chayula_Who_Dreamt,
			High_Templar_Avarius,
			Konley_the_Unrepentant,
			Woad_Mockery_of_Man,
			Innocence_GodEmperor_of_Eternity,
			The_Cleansing_Light,
			Guardian_of_Eternity,
			Corrupted_Guardian_of_Eternity,
			Reassembled_Brutus,
			Bazur,
			Shavronne_the_Returned,
			Liantra,
			Tome_of_Thunder,
			Tsoagoth_The_Brine_King,
			Nassar_Lion_of_the_Seas,
			Brinespawn,
			Sulphurspawn,
			Vendigo,
			The_White_Death,
			Blackguard_Jaeger,
			Risen_Jaeger,
			Kitavas_Herald,
			Plaguewing,
			The_Grey_Plague,
			Rattling_Condemned,
			Sandworn_Slaves,
			Doedre_the_Vile,
			Portentia_the_Foul,
			Noble_Dead,
			Rhys_of_Abram,
			Experimented_Dead,
			Indoctrinated_Slave,
			Deformed_Slave,
			Truth_Extractor,
			Defiled_Extractor,
			Corrupted_Extractor,
			Seafloor_Maiden,
			Maiden_of_the_Black_Crest,
			Dreadwheel,
			Fleetfreak,
			Handmaiden,
			Stonefist,
			Prayer_Guard,
			Solar_Elemental,
			Solar_Guard,
			Spider_Minion,
			Temple_Adjudicator,
			Heretical_Adjudicator,
			Oriath_Enforcer,
			Enthralled_Enforcer,
			Depraved_Enforcer,
			Lunaris_Eternal_Moon,
			Selenia_the_Endless_Night,
			Dusk_Harbinger_of_Lunaris,
			Sebbert_Crescents_Point,
			Arteth_Selenias_Herald,
			Roaming_Gloom,
			Solaris_Eternal_Sun,
			Helial_the_Day_Unending,
			Dawn_Harbinger_of_Solaris,
			Jorus_Skys_Edge,
			Opid_Helials_Herald,
			Roaming_Embers,
			Maligaro_the_Artist,
			Visceris,
			Black_Death_Pain_Unending,
			Akaveesh,
			Fidelitas_Loyalty_Undying,
			Muneh,
			Plagued_Arachnid,
			Diseased_Arachnid,
			Maligaros_Muse,
			Arakaalis_Acolyte,
			Arakaalis_Creation,
			Hybrid_Arachnid,
			Scalding_Arachnid,
			Unholy_Aberration,
			Greust_Lord_of_the_Forest,
			Drek_Apex_Hunter,
			Greusts_Archer,
			Greusts_Bandit,
			Oaks_Archer,
			Oaks_Bandit,
			Aliras_Archer,
			Aliras_Bandit,
			Kraityns_Archer,
			Kraityns_Bandit,
			Arakaali_Spinner_of_Shadows,
			Armala_the_Widow,
			Kitava_the_Insatiable,
			Lord_of_the_Grey,
			Kitava_The_Destroyer,
			Kitavas_Heart,
			The_Lords_Heart,
			The_Destroyers_Heart,
			Utula_Stone_and_Steel,
			Calderus,
			Xuatl_Cutting_Wind,
			Daluatti_Stoneraiser,
			Anacuacotli_Deaths_Worship,
			Huitepa_the_Blind,
			Guraq_Daylights_Blade,
			Harbinger_of_Disorder,
			Tukohama_Karui_God_of_War,
			Tahsin_Warmaker,
			Tukohamas_Suffering,
			Tahsins_Suffering,
			Tukohamas_Servant,
			Tukohamas_Protection,
			Tukohamas_Frenzy,
			Soul_of_Prophecy,
			Soul_of_Breach,
			Soul_of_Essence,
			Soul_of_Perandus,
			Soul_of_Anarchy,
			Soul_of_Talisman,
			Soul_of_Tempest,
			Soul_of_Rampage,
			Soul_of_Beyond,
			Soul_of_Onslaught,
			Soul_of_Ambush,
			Soul_of_Bloodlines,
			Soul_of_Nemesis,
			Soul_of_Torment,
			Soul_of_Domination,
			Soul_of_Invasion,
			Soul_of_Warbands,
			__hbgm01__,
			__HRB1__,
			__HRB2__,
			__HRB3__,
			__HRB4__,
			__HRB5__,
			__HRB6__,
			__HRB7__,
			__HRB8__,
			__HRB9__,
			__HRB10__,
			__HRB11__,
			__HRB12__,
			__HRB13__,
			__HRB14__,
			__HRB15__,
			__HRB16__,
			__HRB17__,
			__HRB18__,
			__HRB19__,
			__HRB20__,
			__HRB21__,
			__HRB22__,
			__HRB23__,
			__HRB24__,
			__HRB25__,
			__HRB26__,
			__HRB27__,
			__HRB28__,
			TEST,
			__HRB30__,
			__HRB29__,
			Chest,
			Karui_Rebel,
			The_Dishonoured_Queen,
			Forgotten_Warrior,
			Frightened_Citizen,
			Kitava_Zealot,
			Feast_Attendant,
			Abstract_of_Judgement,
			Spectral_Soldier,
			Spectral_Officer,
			Spectral_Legionnaire,
			Spectral_Tactician,
			Ondar_the_Betrayer,
			Lightborne_Apostle,
			Lightborne_Elite,
			Lightborne_Faithful,
			Brinecrack,
			Waste_Lurcher,
			Abberath_the_Cloven_One,
			Mephod_the_Earth_Scorcher,
			Wailing_Widow,
			Shrieking_Witch,
			The_Sanguine_Siren,
			Iorphia_Dream_Eater,
			Vengeful_Soul,
			Desperate_Soul,
			Gruthkul_Mother_of_Despair,
			Erebix_Lights_Bane,
			Restless_Pauper,
			Yugul_Reflection_of_Terror,
			Varhesh_Shimmering_Aberration,
			Reflection_of_Yugul,
			Reflection_of_Varhesh,
			Silver_Orb,
			Silver_Pool,
			Egg_Sac,
			Arakaalis_Gift,
			Ryslathas_Brood_Egg,
			Bulbous_Growth,
			Yeena_Aspect_of_the_Fox,
			Bone_Husk,
			Hector_Titucius_Eternal_Servant,
			The_Forgotten_Soldier,
			Wild_Rhex,
			Maternal_Rhex,
			Adolescent_Rhex,
			Escaped_Rhex,
			Garukhan_Queen_of_the_Winds,
			Stalker_of_the_Endless_Dunes,
			Kira_Servant_of_Garukhan,
			The_Vulture_Queen,
			Preethi_EyePecker,
			Sand_Warrior,
			Sand_Goliath,
			Mummified_Maraketh,
			Black_Scorpion,
			Sulphuric_Scorpion,
			Sand_Scorpion,
			Tamulus,
			Predatory_Scorpion,
			Tamipin,
			The_Basilisk,
			The_Gorgon,
			Imperial_Legionaire,
			Imperial_Archer,
			Imperial_Vanguard,
			Doedre_Darksoul,
			Doedre_the_Defiler,
			Shavronne_Unbound,
			Shavronne_the_Sickening,
			Maligaro_The_Broken,
			Maligaro_the_Mutilator,
			The_Depraved_Trinity,
			Amalgam_of_Nightmares,
			Bone_Stalker,
			General_Adus,
			Pesquin_the_Mad_Baron,
			Refinery_Construct,
			Shavronnes_Vision,
			Void_Construct,
			Accursed_Monolith,
			Doedres_Monolith,
			Mountain_Lynx,
			Lightning_Orb,
			Tentacle_Fiend,
			Rhexback_Raider,
			Rhexback_Spearman,
			____,
			Harbingers_Panthera,
			Trio_Daemon,
			Doedre_Daemon,
			Shakari_Queen_of_the_Sands,
			Terror_of_the_Infinite_Drifts,
			Reliquarian,
			The_Grand_Antiquarian,
			Cauldron,
			Droolmaw,
			Primeval_Watcher,
			Risen_Watcher,
			Primeval_Hunter,
			Risen_Hunter,
			Corpse_Thief,
			Risen_Thief,
			Lightless_Terror,
			Wellwing,
			Deep_Stalker,
			Risen_Stalker,
			Thresher,
			Risen_Thresher,
			Pit_Maw,
			Risen_Maw,
			Lightless_Nightmare,
			Wellwing_Matriarch,
			Ulaman_Sovereign_of_the_Well,
			Amanamu_Liege_of_the_Lightless,
			Kurgal_the_Blackblooded,
			The_Enslaver,
			The_Eradicator,
			The_Constrictor,
			The_Purifier,
			The_Elder,
			Doedres_Effigy,
			Coconut_Crab,
			Bleached_Coconut_Crab,
			Graceful_Kelp_Crab,
			Bleached_Kelp_Crab,
			Nimble_Spray_Crab,
			Bleached_Spray_Crab,
			Spider_Crab,
			Bleached_Spider_Crab,
			Stygian_Spire,
			Stygian_Heart,
			Pitworm,
			Lightless_Grub,
			Well_Creeper,
			Null_Portal,
			Eldritch_Spawn,
			Madness_Propagator,
			Formless_Witness,
			Strange_Rabbit,
			Saqawine_Rhoa_Spirit,
			Saqawine_Rhex,
			Young_Saqawine_Rhex,
			Hungry_Saqawine_Rhex,
			Saqawal_First_of_the_Sky,
			Saqawine_Rhoa,
			Adolescent_Saqawine_Rhoa,
			Aggressive_Saqawine_Rhoa,
			Saqawine_Vulture,
			Hungry_Saqawine_Vulture,
			Young_Saqawine_Vulture,
			Saqawine_Retch,
			Saqawine_Retch_Scavenger,
			Saqawine_Retch_Flockmate,
			Saqawine_Retch_Spirit,
			Saqawine_Cobra,
			Saqawine_Slitherer,
			Saqawine_Asp,
			Saqawine_Cobra_Spirit,
			Saqawine_Blood_Viper,
			Saqawine_Adder,
			Saqawine_Flamescale,
			Saqawine_Chimeral,
			Saqawine_Plumespitter,
			Saqawine_Stonescale,
			Saqawine_Chimeral_Spirit,
			Farric_Flame_Hellion_Alpha,
			Farric_Ember_Hellion,
			Farric_Frost_Hellion_Alpha,
			Farric_Flame_Hellion,
			Farric_Flamespitting_Hellion,
			Farric_Frost_Hellion,
			Farric_Frostspewing_Hellion,
			Farric_Lynx_Alpha,
			Farric_Lynx,
			Farric_Shredder,
			Farruls_Pack,
			Farric_Tiger_Alpha,
			Farric_Tiger,
			Farric_Pouncer,
			Farrul_First_of_the_Plains,
			Farric_Wolf_Alpha,
			Farric_Wolf,
			Farric_Howler,
			Craiceann_First_of_the_Deep,
			Fenumal_Queen,
			Fenumal_Mother,
			Fenumal_Strider,
			Fenumal_Scrabbler,
			Fenumal_Drone,
			Fenumal_Leaper,
			Fenumal_Pouncer,
			Fenumal_Devourer,
			Fenumal_Burrower,
			Fenumal_Eartheater,
			Fenumus_Devoted,
			Fenumal_Ambusher,
			Fenumal_Scorpion,
			Fenumal_Stinger,
			Fenumal_Sandwhipper,
			Fenumal_Striker,
			Fenumal_Plagued_Arachnid,
			Fenumal_Plaguecrawler,
			Fenumal_Pus_Arachnid,
			Fenumal_Virulent_Arachnid,
			Fenumal_Hybrid_Arachnid,
			Fenumal_Monstrosity,
			Fenumal_Abomination,
			Fenumus_First_of_the_Night,
			Fenumal_Widow,
			Fenumal_Webweaver,
			Fenumal_Spinner,
			Farric_Goliath,
			Farric_Reaver,
			Farric_Spikeback,
			Farric_Thornback,
			Farric_Taurus,
			Farric_Bull,
			Farric_Charger,
			Farric_Chieftain,
			Farric_Brute,
			Farric_Follower,
			Farric_Ape,
			Farric_Simian,
			Farric_Monkey,
			Farric_Goatman,
			Farric_Devil,
			Farric_Satyr,
			Farric_Bleeter,
			Farric_Magma_Hound,
			Farric_Cerberon,
			Farric_Ember_Hound,
			Farric_Pit_Hound,
			Farric_Attack_Hound,
			Farric_Dismemberer,
			Farric_Hound_Alpha,
			Farric_Tracker,
			Farric_Packhound,
			Farric_Gargantuan,
			Farric_Lumberer,
			Farric_Beast,
			Farric_Ursa,
			Farric_Fury,
			Farric_Fleshrender,
			Craicic_Sand_Spitter,
			Craicic_Graveleater,
			Craicic_Rockchewer,
			Craicic_Shield_Crab,
			Craicic_Shelter_Crab,
			Craicic_Crustacean,
			Craicic_Savage_Crab,
			Craicic_Sandstrider,
			Craicic_Spiked_Crab,
			Craicic_Spider_Crab,
			Craicic_Strider_Crab,
			Craicic_Stilted_Crab,
			Craicic_Maw,
			Craicic_Stomper,
			Craicic_Horror,
			Craicic_Chimeral,
			Craicic_Hunter,
			Craicic_Predator,
			Craicic_Vassal,
			Craicic_Bodythief,
			Craicic_Inkskin,
			Craicic_Squid,
			Craicic_Cephalis,
			Craicic_Swarmer,
			Craicic_Watcher,
			Craicic_Strangler,
			Craicic_Drifter,
			Void_Sphere,
			Farruls_Devoted,
			Bestial_Spirit,
			Craicic_Sandspitter,
			Craicic_Reaver,
			Test_Subject,
			Alva_Cazar_Treasure_Hunter,
			Grizzled_Bear,
			The_Vaal_Omnitect,
			Vaal_Saucer_Turret,
			Vaal_Zealot,
			Vaal_Fanatic,
			Vaal_Advocate,
			Risen_Vaal_Zealot,
			Risen_Vaal_Fanatic,
			Risen_Vaal_Advocate,
			Tacati_Architect_of_Toxins,
			Ahuana_Architect_of_Ceremonies,
			Topotante_Architect_of_Storms,
			Matatl_Architect_of_Fortifications,
			Uromoti_Architect_of_Expansion,
			Xipocado_Royal_Architect,
			Juatalotli_Architect_of_the_Hoard,
			Paquate_Architect_of_Corruption,
			Hayoxi_Architect_of_Destruction,
			Atmohua_Architect_of_Iron,
			Ticaba_Architect_of_the_Arena,
			Cholotl_Architect_of_the_War,
			Zilquapa_Architect_of_the_Breach,
			Zalatl_Architect_of_Thaumaturgy,
			Estazunti_Architect_of_the_Vault,
			Azcapa_Architect_of_the_Guild,
			Jiquani_Architect_of_Industry,
			Quipolatl_Architect_of_the_Nexus,
			Guatelitzi_Architect_of_Flesh,
			Citaqualotl_Architect_of_the_Swarm,
			Puhuarte_Architect_of_the_Forge,
			Xopec_Architect_of_Power,
			Tzamoto_Architect_of_Torments,
			Zantipi_Architect_of_Concealment,
			Opiloti_Architect_of_Stone,
			Vaal_Manifestation,
			Returned_Voidwalker,
			Enhanced_Vaal_Fallen,
			Blood_Priest,
			Soulseeker,
			Shadow_Priest,
			Shadestalker,
			Bloodback_Hatchling,
			Augmented_Hatchling,
			Barrel,
			Basket,
			Bone_Pile,
			Boulder,
			Cairn,
			Bone_Chest,
			Copper_Chest,
			Large_Chest,
			Crate,
			Golden_Chest,
			Silver_Chest,
			Tribal_Chest,
			Sarcophagus,
			Egg,
			Pot,
			Urn,
			Trunk,
			Bundle,
			Sealed_Remains,
			Gold_Pot,
			Cocoon,
			Rotted_Cocoon,
			Decayed_Cocoon,
			Putrid_Cocoon,
			Silver_Pot,
			Corpse,
			Rhoa_Nest,
			Slave_Girl,
			Strange_Device,
			Altar,
			Plum,
			Ornate_Chest,
			Stash,
			Blackguard_Chest,
			Supply_Container,
			Book_Stand,
			Experimental_Supplies,
			Tomb_of_the_First_Templar,
			Karui_Relic_Case,
			Solaris_Throne,
			Storage_Chest,
			Flag_Chest,
			Container_of_Sins,
			Dirty_Lockbox,
			Kisharas_Lockbox,
			Firefly,
			Sealed_Casket,
			Tomb_of_Hector_Titucius,
			Theurgic_Precipitate_Machine,
			Sealed_Chest,
			Pearl_Case,
			Weapon_Rack,
			Armour_Rack,
			Scribes_Rack,
			Crucified_Corpse,
			Bound_Corpse,
			Impaled_Corpse,
			Booty_Chest,
			Pirate_Lords_Treasure,
			Treasure_Pile,
			Lost_Maraketh_Treasure,
			Warmongers_Stash,
			Shipwrecked_Treasure,
			Sculptors_Tools,
			Arcanists_Strongbox,
			Grandmasters_Cache,
			Armourers_Strongbox,
			Blacksmiths_Strongbox,
			Artisans_Strongbox,
			Cartographers_Strongbox,
			Chemists_Strongbox,
			Gemcutters_Strongbox,
			Jewellers_Strongbox,
			Large_Strongbox,
			Ornate_Strongbox,
			Strongbox,
			Diviners_Strongbox,
			Vaal_Vessel,
			Decorative_Chest,
			Locked_Chest,
			Perandus_Chest,
			Temple_Stash,
			Perandus_Cache,
			Perandus_Hoard,
			Perandus_Coffer,
			Perandus_Jewellery_Box,
			Perandus_Safe,
			Perandus_Treasury,
			Perandus_Wardrobe,
			Perandus_Catalogue,
			Perandus_Trove,
			Perandus_Locker,
			Perandus_Archive,
			Perandus_Tackle_Box,
			Cadiros_Locker,
			Cadiros_Treasury,
			Cadiros_Archive,
			Cadiros_Jewellery_Box,
			Cadiros_Catalogue,
			Grand_Perandus_Vault,
			Hidden_Coffer,
			Supply_Cache,
			Labyrinth_Trove,
			Ascendants_Treasures,
			Emperors_Gifts,
			Battle_Supplies,
			War_Spoils,
			Warmongers_Cache,
			Guard_Supplies,
			Guard_Vault,
			Guard_Treasury,
			Emperors_Trove,
			Emperors_Vault,
			Emperors_Treasury,
			Emperors_Charts,
			Curious_Lockbox,
			Intricate_Locker,
			Izaros_Treasure,
			Fortune_Tellers_Chest,
			Clasped_Hand,
			Xophs_Clasped_Hand,
			Tuls_Clasped_Hand,
			Eshs_Clasped_Hand,
			UulNetols_Clasped_Hand,
			Chayulas_Clasped_Hand,
			Relic_Vault,
			Hoard,
			Abyssal_Trove,
			Vase,
			XXX,
			Amphora,
			Supplies,
			Cache,
			Trove,
			War_Chest,
			Ancient_Hoard,
			Stockpile,
			Receptacle,
			Anomalous_Objects,
			Pulsating_Growth,
			Portentous_Trunk,
			Regal_Coffer,
			Shimmering_Vault,
			Sealed_Trunk,
			Ancient_Excavation,
			Augurs_Wares,
			Stolen_Remnants,
			Judicial_Offerings,
			Ritualist_Regalia,
			Heirloom_Vessel,
			Ancient_Cache,
			Dusty_Charts,
			Ceremonial_Adornments,
			Thaumaturgy_Vessel,
			War_Regalia,
			Ancient_Armaments,
			War_Vault,
			Glittering_Trove,
			Stone_Coffer,
			Pools_Coffer,
			Grove_Vessel,
			Fortified_Casket,
			Storm_Coffer,
			Thunder_Coffer,
			Fireproof_Chest,
			Experimental_Chest,
			Flashpowder_Cache
		}

		private sealed class Class56
		{
			public static readonly Class56 class56_0;

			private static Class56 class56_1;

			internal Dictionary<int, long> method_0()
			{
				return null;
			}

			internal Dictionary<int, long> uuapyJiuaXH()
			{
				return null;
			}

			internal bool method_1()
			{
				return true;
			}

			internal bool method_2()
			{
				return true;
			}

			internal int method_3(KeyValuePair<int, NetworkObject> keyValuePair_0)
			{
				return 0;
			}

			internal List<NetworkObject> method_4()
			{
				return null;
			}

			internal Dictionary<string, List<NetworkObject>> method_5()
			{
				return null;
			}

			internal Dictionary<int, NetworkObject> VrEpyhxLuHQ()
			{
				return null;
			}

			internal List<NetworkObject> method_6()
			{
				return null;
			}

			internal bool method_7(KeyValuePair<int, NetworkObject> keyValuePair_0)
			{
				return true;
			}

			internal NetworkObject method_8(KeyValuePair<int, NetworkObject> keyValuePair_0)
			{
				return null;
			}

			internal LocalPlayer method_9()
			{
				return null;
			}

			internal bool method_10(LocalPlayer localPlayer_0)
			{
				return true;
			}

			static Class56()
			{
				Class200.smethod_34();
				Class204.smethod_0();
				class56_0 = new Class56();
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static Class56 smethod_1()
			{
				return null;
			}
		}

		private sealed class Class57
		{
			public Dictionary<int, long> dictionary_0;

			internal static Class57 class57_0;

			internal bool method_0(KeyValuePair<int, NetworkObject> keyValuePair_0)
			{
				return true;
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static Class57 smethod_1()
			{
				return null;
			}

			static Class57()
			{
				Class200.smethod_34();
			}
		}

		private sealed class Class58
		{
			public Dictionary<int, long> dictionary_0;

			internal static Class58 class58_0;

			internal bool method_0(KeyValuePair<int, NetworkObject> keyValuePair_0)
			{
				return true;
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static Class58 smethod_1()
			{
				return null;
			}

			static Class58()
			{
				Class200.smethod_34();
			}
		}

		[Serializable]
		private sealed class Class59<T> where T : class
		{
			public static readonly Class59<T> class59_0;

			internal static object object_0;

			internal T method_0(NetworkObject networkObject_0)
			{
				return null;
			}

			static Class59()
			{
				Class200.smethod_34();
				Class204.smethod_0();
				class59_0 = new Class59<T>();
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static object smethod_1()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CGetMetadatas_003Ed__1 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private string _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private PoeObjectEnum[] enums;

			public PoeObjectEnum[] _003C_003E3__enums;

			private int _003Ci_003E5__2;

			private static _003CGetMetadatas_003Ed__1 _003CGetMetadatas_003Ed__1_0;

			string IEnumerator<string>.Current => null;

			object IEnumerator.Current => null;

			public _003CGetMetadatas_003Ed__1(int _003C_003E1__state)
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

			void IEnumerator.Reset()
			{
			}

			IEnumerator<string> IEnumerable<string>.GetEnumerator()
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

			internal static _003CGetMetadatas_003Ed__1 smethod_1()
			{
				return null;
			}

			static _003CGetMetadatas_003Ed__1()
			{
				Class200.smethod_34();
			}
		}

		private static object object_0;

		private static bool bool_0;

		private static Dictionary<int, NetworkObject> dictionary_0;

		private static Dictionary<int, NetworkObject> dictionary_1;

		private static Entity.Class37 class37_0;

		private static long long_0;

		private static uint uint_0;

		private static readonly Dictionary<int, long> dictionary_2;

		private static PerAreaCachedValue<bool> perAreaCachedValue_0;

		private static PerAreaCachedValue<bool> perAreaCachedValue_1;

		private static PerAreaCachedValue<Dictionary<int, long>> perAreaCachedValue_2;

		private static PerFrameCachedValue<Dictionary<int, long>> perFrameCachedValue_0;

		private static PerFrameCachedValue<Dictionary<int, long>> perFrameCachedValue_1;

		private static PerFrameCachedValue<List<NetworkObject>> perFrameCachedValue_2;

		private static PerFrameCachedValue<List<NetworkObject>> perFrameCachedValue_3;

		private static PerFrameCachedValue<Dictionary<string, List<NetworkObject>>> perFrameCachedValue_4;

		private static PerFrameCachedValue<Dictionary<string, List<NetworkObject>>> perFrameCachedValue_5;

		private static PerFrameCachedValue<LocalPlayer> perFrameCachedValue_6;

		internal static ObjectManager objectManager_0;

		public static bool AllObjectsOverride
		{
			get
			{
				return true;
			}
			set
			{
			}
		}

		public static List<NetworkObject> Objects => null;

		public static Dictionary<string, List<NetworkObject>> MetadataDictionary => null;

		public static List<NetworkObject> SleepingObjects => null;

		public static IEnumerable<DreamPoeBot.Loki.Game.Objects.TriggerableBlockage> AnyDoors => null;

		public static IEnumerable<UltimatumChallengeInteractable> UltimatumChallengeInteractables => null;

		public static IEnumerable<DreamPoeBot.Loki.Game.Objects.TriggerableBlockage> Doors => null;

		public static IEnumerable<DreamPoeBot.Loki.Game.Objects.Portal> InTownPortals => null;

		public static NetworkObject MapDevice => null;

		public static LocalPlayer Me => null;

		public static IEnumerable<DreamPoeBot.Loki.Game.Objects.Portal> Portals => null;

		public static IEnumerable<DreamPoeBot.Loki.Game.Objects.Shrine> Shrines => null;

		public static NetworkObject Stash => null;

		public static NetworkObject Waypoint => null;

		public static AflictionInitiator AflictionInitiator => null;

		public static AbyssWellOfSouls WellOfSouls => null;

		[IteratorStateMachine(typeof(_003CGetMetadatas_003Ed__1))]
		public static IEnumerable<string> GetMetadatas(params PoeObjectEnum[] enums)
		{
			return null;
		}

		private static void smethod_0(KeyValuePair<int, long> keyValuePair_0)
		{
		}

		private static void smethod_1(KeyValuePair<int, long> keyValuePair_0)
		{
		}

		private static bool smethod_2()
		{
			return true;
		}

		private static bool smethod_3()
		{
			return true;
		}

		private static bool smethod_4(Dictionary<int, NetworkObject> dictionary_3, Dictionary<int, long> dictionary_4, bool bool_1)
		{
			return true;
		}

		private static void smethod_5(Dictionary<int, NetworkObject> dictionary_3, Dictionary<int, long> dictionary_4)
		{
		}

		private static bool smethod_6(string string_0)
		{
			return true;
		}

		private static NetworkObject smethod_7(Dictionary<int, NetworkObject> dictionary_3, int int_0, long long_1, bool bool_1, bool bool_2 = true)
		{
			return null;
		}

		private static void smethod_8(Memory memory_0, long long_1, uint uint_1)
		{
		}

		private static void smethod_9()
		{
		}

		private static void smethod_10()
		{
		}

		private static List<NetworkObject> smethod_11(Dictionary<int, NetworkObject> dictionary_3)
		{
			return null;
		}

		[SpecialName]
		internal static Dictionary<int, long> smethod_12()
		{
			return null;
		}

		[SpecialName]
		private static Dictionary<int, long> smethod_13()
		{
			return null;
		}

		[SpecialName]
		private static Dictionary<int, long> smethod_14()
		{
			return null;
		}

		public static void ClearAwake()
		{
		}

		public static DreamPoeBot.Loki.Game.Objects.AreaTransition AreaTransition(string name)
		{
			return null;
		}

		public static DreamPoeBot.Loki.Game.Objects.AreaTransition CorruptedAreaTransition()
		{
			return null;
		}

		public static ExpeditionPlacementIndicator GetExpeditionPlacementIndicator()
		{
			return null;
		}

		public static NetworkObject GetObjectByAddress(long addr)
		{
			return null;
		}

		public static NetworkObject GetObjectById(long id)
		{
			return null;
		}

		public static T GetObjectById<T>(long id) where T : class
		{
			return null;
		}

		public static NetworkObject GetObjectByMetadata(string metadata)
		{
			return null;
		}

		public static NetworkObject GetObjectByName(string name)
		{
			return null;
		}

		public static T GetObjectByName<T>(string name) where T : class
		{
			return null;
		}

		public static T GetObjectByType<T>() where T : class
		{
			return null;
		}

		public static IEnumerable<NetworkObject> GetObjects(params PoeObjectEnum[] enums)
		{
			return null;
		}

		public static IEnumerable<NetworkObject> GetObjects(IEnumerable<PoeObjectEnum> enums)
		{
			return null;
		}

		public static IEnumerable<NetworkObject> GetObjectsByMetadata(string metadata)
		{
			return null;
		}

		public static IEnumerable<NetworkObject> GetObjectsByMetadatas(params string[] metadatas)
		{
			return null;
		}

		public static IEnumerable<NetworkObject> GetObjectsByMetadatas(IEnumerable<string> metadatas)
		{
			return null;
		}

		public static IEnumerable<NetworkObject> GetObjectsByName(string name)
		{
			return null;
		}

		public static IEnumerable<T> GetObjectsByName<T>(string name) where T : class
		{
			return null;
		}

		public static IEnumerable<T> GetObjectsByPosition<T>(Vector2i position) where T : NetworkObject
		{
			return null;
		}

		public static IEnumerable<T> GetObjectsByType<T>() where T : class
		{
			return null;
		}

		public static DreamPoeBot.Loki.Game.Objects.Portal TownPortal(string ownerName)
		{
			return null;
		}

		private static uint smethod_15(string string_0)
		{
			return 0u;
		}

		static ObjectManager()
		{
			Class200.smethod_34();
			Class204.smethod_0();
			object_0 = new object();
			bool_0 = false;
			dictionary_0 = new Dictionary<int, NetworkObject>();
			dictionary_1 = new Dictionary<int, NetworkObject>();
			dictionary_2 = new Dictionary<int, long>();
		}

		internal static bool smethod_16()
		{
			return true;
		}

		internal static ObjectManager smethod_17()
		{
			return null;
		}
	}

	public delegate void PasteTextFailedEvent();

	internal delegate byte[] Delegate2(string v, out string message);

	public class UiDumpData
	{
		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private string string_0;

		internal static UiDumpData uiDumpData_0;

		public int offset
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string text
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static UiDumpData smethod_1()
		{
			return null;
		}

		static UiDumpData()
		{
			Class200.smethod_34();
		}
	}

	private class Class60
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;

		public int int_5;

		public int int_6;

		public int int_7;

		public int int_8;

		public int int_9;

		public int int_10;

		internal static Class60 class60_0;

		public void method_0()
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class60 smethod_1()
		{
			return null;
		}

		static Class60()
		{
			Class200.smethod_34();
		}
	}

	public class MasterySkillIds
	{
		[CompilerGenerated]
		private ushort ushort_0;

		[CompilerGenerated]
		private ushort ushort_1;

		private static MasterySkillIds masterySkillIds_0;

		public ushort PassiveSkillId
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ushort PassiveSkillMasteryId
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static MasterySkillIds smethod_1()
		{
			return null;
		}

		static MasterySkillIds()
		{
			Class200.smethod_34();
		}
	}

	public enum PoeVersion
	{
		Unknown,
		Official,
		OfficialSteam,
		GarenaTw,
		GarenaCis,
		GarenaSg,
		TencentCn
	}

	public static class StateManager
	{
		public static bool IsEscapeStateActive => true;

		public static bool IsSelectCharacterStateActive => true;

		public static bool IsCreateCharacterStateActive => true;

		public static bool IsWaitingStateActive => true;

		public static bool IsInGameStateActive => true;

		public static bool IsAreaLoadingStateActive => true;

		public static bool IsLoadingStateActive => true;

		[SpecialName]
		internal static long smethod_0()
		{
			return 0L;
		}

		[SpecialName]
		internal static long smethod_1()
		{
			return 0L;
		}

		[SpecialName]
		internal static long smethod_2()
		{
			return 0L;
		}

		[SpecialName]
		internal static long smethod_3()
		{
			return 0L;
		}

		[SpecialName]
		internal static Element smethod_4()
		{
			return null;
		}

		[SpecialName]
		internal static Element smethod_5()
		{
			return null;
		}

		[SpecialName]
		internal static Element smethod_6()
		{
			return null;
		}

		[SpecialName]
		internal static Element smethod_7()
		{
			return null;
		}

		static StateManager()
		{
			Class200.smethod_34();
		}
	}

	public static class Utility
	{
		internal static Utility utility_0;

		private static bool smethod_0(Element element_0, string string_0)
		{
			return true;
		}

		private static Vector2i smethod_1(Element element_0)
		{
			return (Vector2i)(object)null;
		}

		internal static DreamPoeBot.Common.Vector2 smethod_2(Element element_0, string string_0)
		{
			return (DreamPoeBot.Common.Vector2)(object)null;
		}

		internal static DreamPoeBot.Common.Vector2 smethod_3(Element element_0, string string_0)
		{
			return (DreamPoeBot.Common.Vector2)(object)null;
		}

		internal static Vector2i smethod_4(Element element_0, bool bool_0 = false)
		{
			return (Vector2i)(object)null;
		}

		public static Vector2i MousePosToScreenPosAbsoluteDebug(Vector2i pos)
		{
			return (Vector2i)(object)null;
		}

		internal static bool smethod_5()
		{
			return true;
		}

		internal static Utility smethod_6()
		{
			return null;
		}

		static Utility()
		{
			Class200.smethod_34();
		}
	}

	public enum StashTabAffinitiesEnum
	{
		Corrency = 3,
		Unique = 4,
		Map = 5,
		Essence = 8,
		Fragment = 9,
		Breach = 14,
		Delirium = 15,
		Flask = 17,
		Gem = 18,
		Augment = 19,
		ExpeditionLocker = 20,
		Ritual = 21,
		Abyss = 0
	}

	public static class ClientFunctions
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass20_0
		{
			public uint uint_0;

			public nint intptr_0;

			private static _003C_003Ec__DisplayClass20_0 _003C_003Ec__DisplayClass20_0_0;

			internal uint method_0()
			{
				return 0u;
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static _003C_003Ec__DisplayClass20_0 smethod_1()
			{
				return null;
			}

			static _003C_003Ec__DisplayClass20_0()
			{
				Class200.smethod_34();
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass21_0
		{
			public uint uint_0;

			public nint intptr_0;

			internal static _003C_003Ec__DisplayClass21_0 _003C_003Ec__DisplayClass21_0_0;

			internal uint method_0()
			{
				return 0u;
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static _003C_003Ec__DisplayClass21_0 smethod_1()
			{
				return null;
			}

			static _003C_003Ec__DisplayClass21_0()
			{
				Class200.smethod_34();
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CAnimateAtlasAsync_003Ed__21 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public uint timeoutMs;

			public int y;

			public int x;

			private _003C_003Ec__DisplayClass21_0 _003C_003E8__1;

			private TaskAwaiter<uint> _003C_003Eu__1;

			private static object object_0;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static object smethod_1()
			{
				return null;
			}

			static _003CAnimateAtlasAsync_003Ed__21()
			{
				Class200.smethod_34();
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CDisableEntityRenderAsync_003Ed__20 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public uint timeoutMs;

			public Render renderComponent;

			private _003C_003Ec__DisplayClass20_0 _003C_003E8__1;

			private TaskAwaiter<uint> _003C_003Eu__1;

			private static object object_0;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static object smethod_1()
			{
				return null;
			}

			static _003CDisableEntityRenderAsync_003Ed__20()
			{
				Class200.smethod_34();
			}
		}

		private static Class88 class88_0;

		private static readonly object object_0;

		private static long long_0;

		private static readonly object object_1;

		private static int int_0;

		private static DateTime dateTime_0;

		internal static ClientFunctions clientFunctions_0;

		public static bool IsRenderEnabled => true;

		internal static Class88 smethod_0()
		{
			return null;
		}

		public static float GetHeightAt(int x, int y)
		{
			return 0f;
		}

		private static float[][] smethod_1(AreaMap areaMap_0, Memory memory_0)
		{
			return null;
		}

		private static void smethod_2(float float_0, float float_1, float float_2, out int int_1, out int int_2)
		{
		}

		public static void WorldToScreen(float x, float y, float z, out int cx, out int cy)
		{
		}

		public static void WorldToScreen(DreamPoeBot.Common.Vector3 position, out int cx, out int cy)
		{
		}

		public static Vector2i MousePosToScreenPos2(Vector2i pos)
		{
			return (Vector2i)(object)null;
		}

		private static Vector2i smethod_3(Vector2i vector2i_0, Vector2i vector2i_1, double double_0)
		{
			return (Vector2i)(object)null;
		}

		public static int GetBackgroundFps()
		{
			return 0;
		}

		public static void SetBackgroundFps(int fps, bool force = false)
		{
		}

		public static void DisableRender()
		{
		}

		public static void EnableRender()
		{
		}

		public static DatQuestStateWrapper UpdateQuestState(DatQuestWrapper quest)
		{
			return null;
		}

		public static DatQuestStateWrapper UpdateQuestState(string questId)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CDisableEntityRenderAsync_003Ed__20))]
		internal static Task<bool> smethod_4(Render render_0, uint uint_0 = 1000u)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CAnimateAtlasAsync_003Ed__21))]
		internal static Task<bool> smethod_5(int int_1, int int_2, uint uint_0 = 10000u)
		{
			return null;
		}

		internal static long smethod_6(string string_0)
		{
			return 0L;
		}

		static ClientFunctions()
		{
			Class200.smethod_34();
			Class204.smethod_0();
			object_0 = new object();
			object_1 = new object();
		}

		internal static bool smethod_7()
		{
			return true;
		}

		internal static ClientFunctions smethod_8()
		{
			return null;
		}
	}

	public enum InputMethod
	{
		MouseAndKeyboard,
		WASD,
		Controller,
		Unknown
	}

	public static class ConfigManager
	{
		public enum NetworkingType
		{
			Unknown,
			Auto,
			Lockstep,
			Predictive
		}

		public enum KeyPickupType
		{
			Unknown,
			Disabled,
			UseHighlightKey,
			UseBoundKey
		}

		public enum CorpseTargeting
		{
			Unknown,
			Always,
			UseBoundKey
		}

		public enum EngineMultithreadingType
		{
			Unknown,
			Disabled,
			Enabled
		}

		public enum LanguageType
		{
			Unknown,
			EN,
			BR,
			RU
		}

		private static ConfigManager configManager_0;

		public static bool IsAlwaysHighlightEnabled => true;

		public static KeyPickupType KeyPickup => (KeyPickupType)(object)null;

		public static NetworkingType NetworkingMode => (NetworkingType)(object)null;

		internal static bool smethod_0()
		{
			return true;
		}

		internal static ConfigManager smethod_1()
		{
			return null;
		}

		static ConfigManager()
		{
			Class200.smethod_34();
		}
	}

	public class Input
	{
		public class KeysCombo
		{
			[CompilerGenerated]
			private Keys keys_0;

			[CompilerGenerated]
			private Keys keys_1;

			private static KeysCombo keysCombo_0;

			public Keys Key
			{
				[CompilerGenerated]
				get
				{
					return (Keys)(object)null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public Keys Modifier
			{
				[CompilerGenerated]
				get
				{
					return (Keys)(object)null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			internal KeysCombo(Keys key, Keys modifier)
			{
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static KeysCombo smethod_1()
			{
				return null;
			}

			static KeysCombo()
			{
				Class200.smethod_34();
			}
		}

		public static class Binding
		{
			private static readonly Guid guid_0;

			private static readonly string[] string_0;

			[CompilerGenerated]
			private static ConfigManager.NetworkingType networkingType_0;

			[CompilerGenerated]
			private static ConfigManager.KeyPickupType keyPickupType_0;

			[CompilerGenerated]
			private static ConfigManager.CorpseTargeting corpseTargeting_0;

			[CompilerGenerated]
			private static KeysCombo keysCombo_0;

			[CompilerGenerated]
			private static KeysCombo keysCombo_1;

			[CompilerGenerated]
			private static KeysCombo keysCombo_2;

			[CompilerGenerated]
			private static KeysCombo keysCombo_3;

			[CompilerGenerated]
			private static KeysCombo keysCombo_4;

			[CompilerGenerated]
			private static KeysCombo CnupnmwEptS;

			[CompilerGenerated]
			private static KeysCombo ijDpnVwGdoj;

			[CompilerGenerated]
			private static KeysCombo keysCombo_5;

			[CompilerGenerated]
			private static KeysCombo keysCombo_6;

			[CompilerGenerated]
			private static KeysCombo keysCombo_7;

			[CompilerGenerated]
			private static KeysCombo keysCombo_8;

			[CompilerGenerated]
			private static KeysCombo keysCombo_9;

			[CompilerGenerated]
			private static KeysCombo keysCombo_10;

			[CompilerGenerated]
			private static KeysCombo keysCombo_11;

			[CompilerGenerated]
			private static KeysCombo keysCombo_12;

			[CompilerGenerated]
			private static KeysCombo keysCombo_13;

			[CompilerGenerated]
			private static KeysCombo keysCombo_14;

			[CompilerGenerated]
			private static KeysCombo keysCombo_15;

			[CompilerGenerated]
			private static KeysCombo keysCombo_16;

			[CompilerGenerated]
			private static KeysCombo keysCombo_17;

			[CompilerGenerated]
			private static KeysCombo keysCombo_18;

			[CompilerGenerated]
			private static KeysCombo keysCombo_19;

			[CompilerGenerated]
			private static KeysCombo keysCombo_20;

			[CompilerGenerated]
			private static KeysCombo keysCombo_21;

			[CompilerGenerated]
			private static KeysCombo keysCombo_22;

			[CompilerGenerated]
			private static KeysCombo keysCombo_23;

			[CompilerGenerated]
			private static KeysCombo keysCombo_24;

			[CompilerGenerated]
			private static KeysCombo keysCombo_25;

			[CompilerGenerated]
			private static KeysCombo keysCombo_26;

			[CompilerGenerated]
			private static KeysCombo keysCombo_27;

			[CompilerGenerated]
			private static KeysCombo keysCombo_28;

			[CompilerGenerated]
			private static KeysCombo keysCombo_29;

			[CompilerGenerated]
			private static KeysCombo keysCombo_30;

			[CompilerGenerated]
			private static KeysCombo keysCombo_31;

			[CompilerGenerated]
			private static KeysCombo keysCombo_32;

			[CompilerGenerated]
			private static KeysCombo keysCombo_33;

			[CompilerGenerated]
			private static KeysCombo keysCombo_34;

			[CompilerGenerated]
			private static KeysCombo keysCombo_35;

			[CompilerGenerated]
			private static KeysCombo keysCombo_36;

			[CompilerGenerated]
			private static KeysCombo keysCombo_37;

			[CompilerGenerated]
			private static KeysCombo keysCombo_38;

			[CompilerGenerated]
			private static KeysCombo keysCombo_39;

			[CompilerGenerated]
			private static KeysCombo keysCombo_40;

			[CompilerGenerated]
			private static KeysCombo keysCombo_41;

			[CompilerGenerated]
			private static KeysCombo keysCombo_42;

			[CompilerGenerated]
			private static KeysCombo keysCombo_43;

			[CompilerGenerated]
			private static KeysCombo keysCombo_44;

			[CompilerGenerated]
			private static KeysCombo keysCombo_45;

			[CompilerGenerated]
			private static KeysCombo keysCombo_46;

			[CompilerGenerated]
			private static KeysCombo keysCombo_47;

			[CompilerGenerated]
			private static KeysCombo keysCombo_48;

			[CompilerGenerated]
			private static KeysCombo keysCombo_49;

			[CompilerGenerated]
			private static KeysCombo keysCombo_50;

			[CompilerGenerated]
			private static KeysCombo keysCombo_51;

			[CompilerGenerated]
			private static KeysCombo keysCombo_52;

			[CompilerGenerated]
			private static KeysCombo keysCombo_53;

			[CompilerGenerated]
			private static KeysCombo keysCombo_54;

			[CompilerGenerated]
			private static KeysCombo keysCombo_55;

			[CompilerGenerated]
			private static KeysCombo keysCombo_56;

			[CompilerGenerated]
			private static KeysCombo keysCombo_57;

			[CompilerGenerated]
			private static KeysCombo ynMpYxRsRpm;

			internal static Binding binding_0;

			public static ConfigManager.NetworkingType NetworkingType
			{
				[CompilerGenerated]
				get
				{
					return (ConfigManager.NetworkingType)(object)null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static ConfigManager.KeyPickupType KeyPickup
			{
				[CompilerGenerated]
				get
				{
					return (ConfigManager.KeyPickupType)(object)null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static ConfigManager.CorpseTargeting CorpseTargetingType
			{
				[CompilerGenerated]
				get
				{
					return (ConfigManager.CorpseTargeting)(object)null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static Keys attack_in_place => (Keys)(object)null;

			public static Keys chat => (Keys)(object)null;

			public static Keys close_panels => (Keys)(object)null;

			public static Keys detonate_mines => (Keys)(object)null;

			public static Keys enable_corpse_targeting => (Keys)(object)null;

			public static Keys enable_key_pickup => (Keys)(object)null;

			public static Keys highlight => (Keys)(object)null;

			public static Keys highlight_toggle => (Keys)(object)null;

			public static Keys open_atlas_screen => (Keys)(object)null;

			public static Keys open_challenges_panel => (Keys)(object)null;

			public static Keys open_character_panel => (Keys)(object)null;

			public static Keys open_cosmetics_inventory => (Keys)(object)null;

			public static Keys open_events_panel => (Keys)(object)null;

			public static Keys open_guidebook_panel => (Keys)(object)null;

			public static Keys open_inventory_panel => (Keys)(object)null;

			public static Keys open_ladder_panel => (Keys)(object)null;

			public static Keys open_map => (Keys)(object)null;

			public static Keys open_microtransaction_panel => (Keys)(object)null;

			public static Keys open_mtx_stash => (Keys)(object)null;

			public static Keys open_options => (Keys)(object)null;

			public static Keys open_pantheon_panel => (Keys)(object)null;

			public static Keys open_passive_skills_panel => (Keys)(object)null;

			public static Keys open_social_panel => (Keys)(object)null;

			public static Keys open_world_panel => (Keys)(object)null;

			public static Keys performance_overlay => (Keys)(object)null;

			public static Keys skip_encounter_delay => (Keys)(object)null;

			public static Keys take_screenshot => (Keys)(object)null;

			public static Keys toggle_skill_bar => (Keys)(object)null;

			public static Keys generic_league_key => (Keys)(object)null;

			public static Keys use_bound_skill1 => (Keys)(object)null;

			public static Keys use_bound_skill2 => (Keys)(object)null;

			public static Keys use_bound_skill3 => (Keys)(object)null;

			public static Keys use_bound_skill4 => (Keys)(object)null;

			public static Keys use_bound_skill5 => (Keys)(object)null;

			public static Keys use_bound_skill6 => (Keys)(object)null;

			public static Keys use_bound_skill7 => (Keys)(object)null;

			public static Keys use_bound_skill8 => (Keys)(object)null;

			public static Keys use_bound_skill9 => (Keys)(object)null;

			public static Keys use_bound_skill10 => (Keys)(object)null;

			public static Keys use_bound_skill11 => (Keys)(object)null;

			public static Keys use_bound_skill12 => (Keys)(object)null;

			public static Keys use_bound_skill13 => (Keys)(object)null;

			public static Keys use_flask_in_slot1 => (Keys)(object)null;

			public static Keys use_flask_in_slot2 => (Keys)(object)null;

			public static Keys use_flask_in_slot3 => (Keys)(object)null;

			public static Keys use_flask_in_slot4 => (Keys)(object)null;

			public static Keys use_flask_in_slot5 => (Keys)(object)null;

			public static Keys weapon_swap => (Keys)(object)null;

			public static Keys zoom_in => (Keys)(object)null;

			public static Keys zoom_out => (Keys)(object)null;

			public static Keys use_temp_bound_skill1 => (Keys)(object)null;

			public static Keys use_temp_bound_skill2 => (Keys)(object)null;

			public static KeysCombo attack_in_place_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo chat_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo close_panels_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo detonate_mines_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo enable_corpse_targeting_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo enable_key_pickup_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo highlight_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo highlight_toggle_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo open_atlas_screen_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo open_challenges_panel_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo open_character_panel_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo open_cosmetics_inventory_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo open_events_panel_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo open_guidebook_panel_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo open_inventory_panel_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo open_ladder_panel_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo open_map_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo open_microtransaction_panel_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo open_mtx_stash_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo open_options_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo open_pantheon_panel_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo open_passive_skills_panel_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo open_social_panel_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo open_world_panel_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo performance_overlay_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo skip_encounter_delay_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo take_screenshot_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo toggle_skill_bar_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo generic_league_key_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo use_bound_skill1_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo use_bound_skill2_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo use_bound_skill3_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo use_bound_skill4_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo use_bound_skill5_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo use_bound_skill6_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo use_bound_skill7_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo use_bound_skill8_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo use_bound_skill9_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo use_bound_skill10_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo use_bound_skill11_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo use_bound_skill12_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo use_bound_skill13_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo use_flask_in_slot1_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo use_flask_in_slot2_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo use_flask_in_slot3_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo use_flask_in_slot4_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo use_flask_in_slot5_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo weapon_swap_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo zoom_in_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo zoom_out_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo use_temp_bound_skill1_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo use_temp_bound_skill2_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo use_stalker_sentinel_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo use_pandemonium_sentinel_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo use_apex_sentinel_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo sanctum_open_map_ui_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo use_portal_scroll_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo use_dodge_roll_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo ritual_rewards_window_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo open_skill_panel_combo
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public static KeysCombo direct_minions
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			private static string smethod_0(int int_0)
			{
				return null;
			}

			public static string GetUserProfilePath(string userName, string userSID = null)
			{
				return null;
			}

			public static string smethod_1(string userName)
			{
				return null;
			}

			[DllImport("kernel32.dll", SetLastError = true)]
			private static extern nint OpenProcess(uint uint_0, bool bool_0, int int_0);

			[DllImport("advapi32.dll", SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			private static extern bool OpenProcessToken(nint intptr_0, uint uint_0, out nint intptr_1);

			[DllImport("kernel32.dll", SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			private static extern bool CloseHandle(nint intptr_0);

			[DllImport("shell32.dll", CharSet = CharSet.Unicode)]
			private static extern int SHGetKnownFolderPath(ref Guid guid_1, uint uint_0, nint intptr_0, out nint intptr_1);

			private static bool smethod_2(int int_0, out string string_1)
			{
				return true;
			}

			private static bool smethod_3()
			{
				return true;
			}

			private static bool smethod_4(out string string_1)
			{
				return true;
			}

			private static string smethod_5(string string_1)
			{
				return null;
			}

			public static void Update(string path)
			{
			}

			private static ProductionConfig smethod_6(List<string> list_0)
			{
				return null;
			}

			public static void Update()
			{
			}

			private static InputMethod smethod_7(Element element_0)
			{
				return (InputMethod)(object)null;
			}

			private static void smethod_8()
			{
			}

			static Binding()
			{
				Class200.smethod_34();
				Class204.smethod_0();
				guid_0 = new Guid(Class200.smethod_20(3610566));
				string_0 = new string[2]
				{
					Class200.smethod_20(3610642),
					Class200.smethod_20(3610698)
				};
			}

			internal static bool smethod_9()
			{
				return true;
			}

			internal static Binding smethod_10()
			{
				return null;
			}
		}

		private sealed class Class61
		{
			public int int_0;

			public int int_1;

			internal static Class61 class61_0;

			internal bool method_0()
			{
				return true;
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static Class61 smethod_1()
			{
				return null;
			}

			static Class61()
			{
				Class200.smethod_34();
			}
		}

		private sealed class Class62
		{
			public bool bool_0;

			public int int_0;

			public bool bool_1;

			public bool bool_2;

			public bool bool_3;

			public nint intptr_0;

			public nint intptr_1;

			public Stopwatch stopwatch_0;

			internal static Class62 class62_0;

			internal void method_0()
			{
			}

			internal void method_1()
			{
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static Class62 smethod_1()
			{
				return null;
			}

			static Class62()
			{
				Class200.smethod_34();
			}
		}

		public class ProductionConfig
		{
			[CompilerGenerated]
			private Dictionary<string, CategorySettings> dictionary_0;

			internal static ProductionConfig productionConfig_0;

			public Dictionary<string, CategorySettings> CategorySettings
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static ProductionConfig smethod_1()
			{
				return null;
			}

			static ProductionConfig()
			{
				Class200.smethod_34();
			}
		}

		public class CategorySettings
		{
			[CompilerGenerated]
			private string string_0;

			[CompilerGenerated]
			private List<string> list_0;

			private static CategorySettings categorySettings_0;

			public string Category
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public List<string> Settings
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static CategorySettings smethod_1()
			{
				return null;
			}

			static CategorySettings()
			{
				Class200.smethod_34();
			}
		}

		private static Dictionary<nint, nint> dictionary_0;

		private static Dictionary<int, Stopwatch> dictionary_1;

		private static int int_0;

		private static List<string> list_0;

		private static ProductionConfig productionConfig_0;

		[CompilerGenerated]
		private static bool bool_0;

		[CompilerGenerated]
		private static bool bool_1;

		[CompilerGenerated]
		private static bool bool_2;

		public const int WM_PASTE = 770;

		private static readonly DreamPoeBot.Common.Vector3[] vector3_0;

		private static PerFrameCachedValue<byte> perFrameCachedValue_0;

		internal static Input input_0;

		public static int InitialInputEventDelayMs => 0;

		public static int InputEventDelayMs
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static InputMethod CurrentInputMethod => (InputMethod)(object)null;

		[DllImport("user32.dll", CharSet = CharSet.Unicode)]
		[SuppressUnmanagedCodeSecurity]
		private static extern short VkKeyScanEx(char char_0, nint intptr_0);

		private static Keys smethod_0(char char_0)
		{
			return (Keys)(object)null;
		}

		private static Stopwatch smethod_1(nint intptr_0, out bool bool_3)
		{
			return null;
		}

		internal static void smethod_2(nint intptr_0, nint intptr_1, bool bool_3, bool bool_4, bool bool_5)
		{
		}

		[SpecialName]
		[CompilerGenerated]
		internal static bool smethod_3()
		{
			return true;
		}

		[SpecialName]
		[CompilerGenerated]
		internal static void smethod_4(bool bool_3)
		{
		}

		[SpecialName]
		[CompilerGenerated]
		internal static bool smethod_5()
		{
			return true;
		}

		[SpecialName]
		[CompilerGenerated]
		internal static void smethod_6(bool bool_3)
		{
		}

		[SpecialName]
		[CompilerGenerated]
		internal static bool smethod_7()
		{
			return true;
		}

		[SpecialName]
		[CompilerGenerated]
		internal static void smethod_8(bool bool_3)
		{
		}

		public static void SimulateKeyEvent(char ch)
		{
		}

		public static void SimulateKeyEvent(Keys key, bool down = true, bool @char = false, bool up = false, Keys extraKey = Keys.None)
		{
		}

		public static void ResetKeysState()
		{
		}

		public static void PasteText(string msg)
		{
		}

		public static void PasteText(string msg, bool useSend)
		{
		}

		internal static bool smethod_9(string string_0, bool bool_3, out int int_1)
		{
			return true;
		}

		[Obsolete("Not used anymore, use MouseManager class to handle all mouse movments.", false)]
		public static void MoveMouse(float cx, float cy)
		{
		}

		[Obsolete("Not used anymore, use MouseManager class to handle all mouse movments.", false)]
		public static void MoveMouse(int cx, int cy)
		{
		}

		public static void MoveMouseToWorldPos(string reason, Vector2i destination)
		{
		}

		public static void MoveMouseToWorldPos(string reason, DreamPoeBot.Common.Vector2 destination)
		{
		}

		public static void MoveMouseToWorldPos(string reason, DreamPoeBot.Common.Vector3 destination)
		{
		}

		public static void MoveMouseToScreenPos(int posX, int posY, bool sleep = true)
		{
		}

		public static void MoveMouseToScreenPos(Vector2i pos)
		{
		}

		public static void MoveMouseToScreenPos(DreamPoeBot.Common.Vector2 pos)
		{
		}

		public static void ClickLMB(int cx = 0, int cy = 0)
		{
		}

		public static void ClickRMB(int cx = 0, int cy = 0)
		{
		}

		public static void ClickMMB(int cx = 0, int cy = 0)
		{
		}

		public static void smethod_10(int cx = 0, int cy = 0)
		{
		}

		public static void smethod_11(int cx = 0, int cy = 0)
		{
		}

		public static void smethod_12(int cx = 0, int cy = 0)
		{
		}

		public static bool HasVisibleHighlightLabel(NetworkObject obj)
		{
			return true;
		}

		public static DreamPoeBot.Common.Vector2 GetClickableHighlightLabelPosition(NetworkObject obj, bool onlyVisible = true)
		{
			return (DreamPoeBot.Common.Vector2)(object)null;
		}

		public static bool GetClickableHighlightLabelDimensions(NetworkObject obj, out DreamPoeBot.Common.Vector2 coords, out DreamPoeBot.Common.Vector2 size, bool onlyVisible = true)
		{
			return true;
		}

		private static bool smethod_13(long long_0)
		{
			return true;
		}

		private static bool smethod_14(DreamPoeBot.Loki.Game.Objects.WorldItem worldItem_0, int int_1)
		{
			return true;
		}

		public static bool HighlightObject(int objId)
		{
			return true;
		}

		public static bool HighlightObject(NetworkObject obj)
		{
			return true;
		}

		public static bool HighlightObject(NetworkObject obj, int WirldItemHighlightMethod)
		{
			return true;
		}

		private static bool smethod_15(NetworkObject networkObject_0, byte byte_0)
		{
			return true;
		}

		private static bool smethod_16(DreamPoeBot.Common.Vector3 vector3_1, long long_0, int int_1 = 2)
		{
			return true;
		}

		private static bool smethod_17(Vector2i vector2i_0, long long_0, int int_1 = 2)
		{
			return true;
		}

		private static bool smethod_18(DreamPoeBot.Common.Vector2 vector2_0, DreamPoeBot.Common.Vector2 vector2_1, long long_0)
		{
			return true;
		}

		public static bool GetKeyForAction(string action, out Keys key)
		{
			return true;
		}

		internal static Keys smethod_19(string string_0)
		{
			return (Keys)(object)null;
		}

		internal static KeysCombo smethod_20(string string_0)
		{
			return null;
		}

		internal static ConfigManager.KeyPickupType smethod_21()
		{
			return (ConfigManager.KeyPickupType)(object)null;
		}

		internal static ConfigManager.CorpseTargeting smethod_22()
		{
			return (ConfigManager.CorpseTargeting)(object)null;
		}

		internal static ConfigManager.NetworkingType smethod_23()
		{
			return (ConfigManager.NetworkingType)(object)null;
		}

		private static byte smethod_24()
		{
			return 0;
		}

		static Input()
		{
			Class200.smethod_34();
			Class204.smethod_0();
			dictionary_0 = new Dictionary<nint, nint>();
			dictionary_1 = new Dictionary<int, Stopwatch>();
			int_0 = Random.Next(30, 100);
			list_0 = new List<string>();
			productionConfig_0 = new ProductionConfig();
			bool_0 = false;
			bool_1 = true;
			bool_2 = true;
			vector3_0 = new DreamPoeBot.Common.Vector3[7]
			{
				new DreamPoeBot.Common.Vector3(-1f, -1f, -1f),
				new DreamPoeBot.Common.Vector3(-1f, 1f, -1f),
				new DreamPoeBot.Common.Vector3(-1f, 1f, 1f),
				new DreamPoeBot.Common.Vector3(1f, -1f, -1f),
				new DreamPoeBot.Common.Vector3(1f, -1f, 1f),
				new DreamPoeBot.Common.Vector3(1f, 1f, -1f),
				new DreamPoeBot.Common.Vector3(1f, 1f, 1f)
			};
		}

		internal static bool smethod_25()
		{
			return true;
		}

		internal static Input smethod_26()
		{
			return null;
		}
	}

	public static class InstanceInfo
	{
		public static class CurrencyExchange
		{
			public enum CurrencyExchangeOrderStatus
			{
				Listed,
				Complete,
				Partial,
				Cancelled
			}

			public class CurrencyExchangeOrder : RemoteMemoryObject
			{
				internal static CurrencyExchangeOrder currencyExchangeOrder_0;

				public CurrencyExchangeOrderStatus Status => (CurrencyExchangeOrderStatus)(object)null;

				internal static bool smethod_2()
				{
					return true;
				}

				internal static CurrencyExchangeOrder smethod_3()
				{
					return null;
				}

				static CurrencyExchangeOrder()
				{
					Class200.smethod_34();
				}
			}

			public static List<CurrencyExchangeOrder> CurrencyExchangeOrders => null;

			static CurrencyExchange()
			{
				Class200.smethod_34();
			}
		}

		public static class Ritual
		{
			internal static Ritual ritual_0;

			public static int Tributes => 0;

			public static bool IsRitualActive => true;

			public static int RitualsRemaining => 0;

			internal static bool smethod_0()
			{
				return true;
			}

			internal static Ritual smethod_1()
			{
				return null;
			}

			static Ritual()
			{
				Class200.smethod_34();
			}
		}

		public static class StashTabAffinities
		{
			internal static StashTabAffinities stashTabAffinities_0;

			private static bool smethod_0(StashTabAffinitiesEnum stashTabAffinitiesEnum_0)
			{
				return true;
			}

			public static bool IsAffinityActive(StashTabAffinitiesEnum stashTabAffinitiesEnum)
			{
				return true;
			}

			internal static bool smethod_1()
			{
				return true;
			}

			internal static StashTabAffinities smethod_2()
			{
				return null;
			}

			static StashTabAffinities()
			{
				Class200.smethod_34();
			}
		}

		public static class Delirium
		{
			private static Delirium delirium_0;

			public static int ActualRewardLevel => 0;

			internal static bool smethod_0()
			{
				return true;
			}

			internal static Delirium smethod_1()
			{
				return null;
			}

			static Delirium()
			{
				Class200.smethod_34();
			}
		}

		public static class Azmeri
		{
			private static PerAreaCachedValue<long> perAreaCachedValue_0;

			private static PerAreaCachedValue<int> perAreaCachedValue_1;

			internal static Azmeri azmeri_0;

			public static int MaxFuel => 0;

			public static int CurrentFuel => 0;

			public static double FuelPct => 0.0;

			public static int CurrentWildWisps => 0;

			public static int CurrentVividWisps => 0;

			public static int CurrentPrimalWisps => 0;

			public static int CurrentSacredWisps => 0;

			[SpecialName]
			private static long smethod_0()
			{
				return 0L;
			}

			internal static bool smethod_1()
			{
				return true;
			}

			internal static Azmeri smethod_2()
			{
				return null;
			}

			static Azmeri()
			{
				Class200.smethod_34();
			}
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct Struct55
		{
			[StructLayout(LayoutKind.Explicit)]
			[UnsafeValueType]
			public struct Struct56
			{
				[FieldOffset(0)]
				public unsafe fixed byte _003Cbyte_0_003Ee__FixedBuffer_0[130];
			}

			public short short_0;

			private short short_1;

			public uint uint_0;

			public uint uint_1;

			public uint uint_2;

			public ushort ushort_0;

			public byte byte_0;

			public byte byte_1;

			private byte byte_2;

			public byte byte_3;

			public Struct56 struct56_0;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct Struct57
		{
			private byte byte_0;

			private readonly byte byte_1;

			private ushort ushort_0;

			private int int_0;

			private NativeVector nativeVector_0;

			private Struct10 struct10_0;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct Struct58
		{
			public long long_0;

			public byte byte_0;

			private byte byte_1;

			private byte byte_2;

			private byte byte_3;

			private byte byte_4;
		}

		public static class Expedition
		{
			public sealed class Snapshot
			{
				[CompilerGenerated]
				private readonly uint uint_0;

				[CompilerGenerated]
				private readonly IReadOnlyList<Encounter> ireadOnlyList_0;

				[CompilerGenerated]
				private readonly Encounter encounter_0;

				[CompilerGenerated]
				private readonly PlacementGrid placementGrid_0;

				[CompilerGenerated]
				private readonly int int_0;

				internal static Snapshot snapshot_0;

				public uint AreaHash
				{
					[CompilerGenerated]
					get
					{
						return 0u;
					}
				}

				public IReadOnlyList<Encounter> Encounters
				{
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				public Encounter CurrentEncounter
				{
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				public PlacementGrid Grid
				{
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				public int MaxPlacementDistance
				{
					[CompilerGenerated]
					get
					{
						return 0;
					}
				}

				internal Snapshot(uint areaHash, Encounter[] encounters, int current, PlacementGrid grid, int distance)
				{
				}

				internal static bool smethod_0()
				{
					return true;
				}

				internal static Snapshot smethod_1()
				{
					return null;
				}

				static Snapshot()
				{
					Class200.smethod_34();
				}
			}

			public sealed class Encounter
			{
				[CompilerGenerated]
				private readonly int int_0;

				[CompilerGenerated]
				private readonly Vector2i vector2i_0;

				[CompilerGenerated]
				private readonly Vector2i vector2i_1;

				[CompilerGenerated]
				private readonly IReadOnlyList<Vector2i> ireadOnlyList_0;

				[CompilerGenerated]
				private readonly int int_1;

				[CompilerGenerated]
				private readonly byte byte_0;

				private static Encounter encounter_0;

				public int Index
				{
					[CompilerGenerated]
					get
					{
						return 0;
					}
				}

				public Vector2i DetonatorPosition
				{
					[CompilerGenerated]
					get
					{
						return (Vector2i)(object)null;
					}
				}

				public Vector2i ChainStartPosition
				{
					[CompilerGenerated]
					get
					{
						return (Vector2i)(object)null;
					}
				}

				public IReadOnlyList<Vector2i> PlacedExplosives
				{
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				public int MaxExplosives
				{
					[CompilerGenerated]
					get
					{
						return 0;
					}
				}

				public int ExplosivesRemaining => 0;

				public bool CanPlaceExplosives => true;

				internal Encounter(int index, Vector2i detonator, Vector2i start, int maximum, byte phase, Vector2i[] placed)
				{
				}

				[SpecialName]
				[CompilerGenerated]
				internal byte method_0()
				{
					return 0;
				}

				internal static bool smethod_0()
				{
					return true;
				}

				internal static Encounter smethod_1()
				{
					return null;
				}

				static Encounter()
				{
					Class200.smethod_34();
				}
			}

			[Flags]
			public enum Connections : byte
			{
				None = 0,
				North = 1,
				East = 2,
				South = 4,
				West = 8,
				NorthEast = 0x10,
				SouthEast = 0x20,
				SouthWest = 0x40,
				NorthWest = 0x80
			}

			public sealed class PlacementGrid
			{
				private readonly byte[] byte_0;

				[CompilerGenerated]
				private readonly int int_0;

				[CompilerGenerated]
				private readonly int int_1;

				[CompilerGenerated]
				private readonly Vector2i vector2i_0;

				[CompilerGenerated]
				private readonly IReadOnlyList<byte> ireadOnlyList_0;

				private static PlacementGrid placementGrid_0;

				public int Width
				{
					[CompilerGenerated]
					get
					{
						return 0;
					}
				}

				public int Height
				{
					[CompilerGenerated]
					get
					{
						return 0;
					}
				}

				public Vector2i Origin
				{
					[CompilerGenerated]
					get
					{
						return (Vector2i)(object)null;
					}
				}

				public IReadOnlyList<byte> Cells
				{
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				internal PlacementGrid(int width, int height, Vector2i origin, byte[] cells)
				{
				}

				public bool TryGetCell(Vector2i position, out Vector2i cell)
				{
					return true;
				}

				public Vector2i GetPosition(int x, int y)
				{
					return (Vector2i)(object)null;
				}

				public Connections GetConnections(int x, int y)
				{
					return (Connections)(object)null;
				}

				private void method_0(int int_2, int int_3)
				{
				}

				internal static bool smethod_0()
				{
					return true;
				}

				internal static PlacementGrid smethod_1()
				{
					return null;
				}

				static PlacementGrid()
				{
					Class200.smethod_34();
				}
			}

			public sealed class ForbiddenArea
			{
				[CompilerGenerated]
				private readonly Vector2i vector2i_0;

				[CompilerGenerated]
				private readonly Vector2i vector2i_1;

				internal static ForbiddenArea forbiddenArea_0;

				public Vector2i Minimum
				{
					[CompilerGenerated]
					get
					{
						return (Vector2i)(object)null;
					}
				}

				public Vector2i Maximum
				{
					[CompilerGenerated]
					get
					{
						return (Vector2i)(object)null;
					}
				}

				internal ForbiddenArea(Vector2i minimum, Vector2i maximum)
				{
				}

				public bool Contains(Vector2i position)
				{
					return true;
				}

				internal static bool smethod_0()
				{
					return true;
				}

				internal static ForbiddenArea smethod_1()
				{
					return null;
				}

				static ForbiddenArea()
				{
					Class200.smethod_34();
				}
			}

			public enum PlacementFailure
			{
				None,
				EncounterUnavailable,
				NoExplosivesRemaining,
				OutsideGrid,
				TooCloseToExplosive,
				ForbiddenArea,
				NoPath,
				BeyondChainDistance
			}

			public sealed class PlacementResult
			{
				[CompilerGenerated]
				private readonly PlacementFailure placementFailure_0;

				[CompilerGenerated]
				private readonly Vector2i vector2i_0;

				[CompilerGenerated]
				private readonly IReadOnlyList<Vector2i> ireadOnlyList_0;

				[CompilerGenerated]
				private readonly float float_0;

				private static PlacementResult placementResult_0;

				public bool CanPlace => true;

				public PlacementFailure Failure
				{
					[CompilerGenerated]
					get
					{
						return (PlacementFailure)(object)null;
					}
				}

				public Vector2i Position
				{
					[CompilerGenerated]
					get
					{
						return (Vector2i)(object)null;
					}
				}

				public IReadOnlyList<Vector2i> Path
				{
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				public float PathLength
				{
					[CompilerGenerated]
					get
					{
						return 0f;
					}
				}

				internal PlacementResult(PlacementFailure failure, Vector2i position, List<Vector2i> path = null, float length = 0f)
				{
				}

				internal static bool smethod_0()
				{
					return true;
				}

				internal static PlacementResult smethod_1()
				{
					return null;
				}

				static PlacementResult()
				{
					Class200.smethod_34();
				}
			}

			public sealed class PlacementPlanner
			{
				private readonly Class95 class95_0;

				[CompilerGenerated]
				private readonly Snapshot snapshot_0;

				[CompilerGenerated]
				private readonly IReadOnlyList<ForbiddenArea> ireadOnlyList_0;

				internal static PlacementPlanner placementPlanner_0;

				public Snapshot Snapshot
				{
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				public IReadOnlyList<ForbiddenArea> ForbiddenAreas
				{
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				internal PlacementPlanner(Snapshot snapshot, IReadOnlyList<ForbiddenArea> forbidden, byte[] terrain, int width, int height, int bpr)
				{
				}

				public PlacementResult EvaluatePosition(Vector2i position)
				{
					return null;
				}

				public PlacementResult EvaluatePosition(Vector2i chainStart, Vector2i position, IReadOnlyList<Vector2i> plannedExplosives)
				{
					return null;
				}

				private static bool smethod_0(Vector2i vector2i_0, Vector2i vector2i_1)
				{
					return true;
				}

				internal static bool smethod_1()
				{
					return true;
				}

				internal static PlacementPlanner smethod_2()
				{
					return null;
				}

				static PlacementPlanner()
				{
					Class200.smethod_34();
				}
			}

			internal static Expedition expedition_0;

			public static Encounter CurrentEncounter => null;

			public static PlacementGrid Grid => null;

			public static int? MaxPlacementDistance => null;

			public static bool TryGetSnapshot(out Snapshot snapshot)
			{
				return true;
			}

			public static bool TryGetForbiddenAreas(out IReadOnlyList<ForbiddenArea> areas)
			{
				return true;
			}

			public static bool TryCreatePlanner(out PlacementPlanner planner)
			{
				return true;
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static Expedition smethod_1()
			{
				return null;
			}

			static Expedition()
			{
				Class200.smethod_34();
			}
		}

		[CompilerGenerated]
		private sealed class _003Cget_AtlasPassiveSkills_003Ed__68 : IEnumerable<DatPassiveSkillWrapper>, IEnumerable, IEnumerator<DatPassiveSkillWrapper>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private DatPassiveSkillWrapper _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private List<uint>.Enumerator _003C_003E7__wrap1;

			internal static _003Cget_AtlasPassiveSkills_003Ed__68 _003Cget_AtlasPassiveSkills_003Ed__68_0;

			DatPassiveSkillWrapper IEnumerator<DatPassiveSkillWrapper>.Current => null;

			object IEnumerator.Current => null;

			public _003Cget_AtlasPassiveSkills_003Ed__68(int _003C_003E1__state)
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

			IEnumerator<DatPassiveSkillWrapper> IEnumerable<DatPassiveSkillWrapper>.GetEnumerator()
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

			internal static _003Cget_AtlasPassiveSkills_003Ed__68 smethod_1()
			{
				return null;
			}

			static _003Cget_AtlasPassiveSkills_003Ed__68()
			{
				Class200.smethod_34();
			}
		}

		[CompilerGenerated]
		private sealed class _003Cget_JewelsPassiveSkills_003Ed__115 : IEnumerable<DatPassiveSkillWrapper>, IEnumerable, IEnumerator<DatPassiveSkillWrapper>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private DatPassiveSkillWrapper _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private List<ushort>.Enumerator _003C_003E7__wrap1;

			internal static _003Cget_JewelsPassiveSkills_003Ed__115 _003Cget_JewelsPassiveSkills_003Ed__115_0;

			DatPassiveSkillWrapper IEnumerator<DatPassiveSkillWrapper>.Current => null;

			object IEnumerator.Current => null;

			public _003Cget_JewelsPassiveSkills_003Ed__115(int _003C_003E1__state)
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

			IEnumerator<DatPassiveSkillWrapper> IEnumerable<DatPassiveSkillWrapper>.GetEnumerator()
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

			internal static _003Cget_JewelsPassiveSkills_003Ed__115 smethod_1()
			{
				return null;
			}

			static _003Cget_JewelsPassiveSkills_003Ed__115()
			{
				Class200.smethod_34();
			}
		}

		[CompilerGenerated]
		private sealed class _003Cget_PassiveSkills_003Ed__107 : IEnumerable<DatPassiveSkillWrapper>, IEnumerable, IEnumerator<DatPassiveSkillWrapper>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private DatPassiveSkillWrapper _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private List<ushort>.Enumerator _003C_003E7__wrap1;

			private static _003Cget_PassiveSkills_003Ed__107 _003Cget_PassiveSkills_003Ed__107_0;

			DatPassiveSkillWrapper IEnumerator<DatPassiveSkillWrapper>.Current => null;

			object IEnumerator.Current => null;

			public _003Cget_PassiveSkills_003Ed__107(int _003C_003E1__state)
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

			IEnumerator<DatPassiveSkillWrapper> IEnumerable<DatPassiveSkillWrapper>.GetEnumerator()
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

			internal static _003Cget_PassiveSkills_003Ed__107 smethod_1()
			{
				return null;
			}

			static _003Cget_PassiveSkills_003Ed__107()
			{
				Class200.smethod_34();
			}
		}

		private static Dictionary<ushort, DatPassiveSkillWrapper> dictionary_0;

		private static PerFrameCachedValue<string> perFrameCachedValue_0;

		private static PerFrameCachedValue<List<MinimapIconWrapper>> perFrameCachedValue_1;

		private static SlowCacheValue<List<Skill>> slowCacheValue_0;

		private static Dictionary<ushort, ServerData.PassiveSkillGraphNode> dictionary_1;

		private static Dictionary<ushort, ServerData.PassiveSkillGraphNode> dictionary_2;

		internal static InstanceInfo instanceInfo_0;

		public static Dictionary<string, long> AreaLoadedFilesDictionary => null;

		public static List<SextantData> Sextants => null;

		public static List<MinimapIconWrapper> MinimapIcons => null;

		public static List<StashTabInfo> GuildStashTabs => null;

		public static List<StashTabInfo> StashTabs => null;

		public static List<PartyMember> PartyMembers => null;

		public static List<PlayerEntry> PlayerEntries => null;

		public static List<PartyInvite> PendingPartyInvites => null;

		public static string PartyLeaderName => null;

		public static string PartyDescription => null;

		public static ServerData.PartyAllocation PartyAllocationType => (ServerData.PartyAllocation)(object)null;

		public static bool LevelDownscalingEnabled => true;

		public static uint DialogDepth => 0u;

		public static uint PlayerGolds => 0u;

		public static uint PlayerHiveblood => 0u;

		public static List<Skill> SkillBarSkills => null;

		public static List<uint> SkillBarIds => null;

		public static Dictionary<string, DatWorldAreaWrapper> AvailableWaypoints => null;

		public static byte IsGamePausedFlag1 => 0;

		public static byte IsGamePausedFlag2 => 0;

		public static bool IsGamePaused => true;

		public static NetworkState NetworkState => (NetworkState)(object)null;

		public static int WeaponSet => 0;

		public static string League => null;

		public static List<uint> AtlasPassiveSkillIds => null;

		public static List<List<uint>> AtlasPassiveSkillIsTreesId => null;

		public static Dictionary<AtlasPanelNode.AtlasPassiveSkillSubtreeType, List<DatPassiveSkillWrapper>> AtlasPassiveSkillsTrees => null;

		public static IEnumerable<DatPassiveSkillWrapper> AtlasPassiveSkills
		{
			[IteratorStateMachine(typeof(_003Cget_AtlasPassiveSkills_003Ed__68))]
			get
			{
				return null;
			}
		}

		public static int GenericAtlasPassivePointsAvailable => 0;

		public static int TotalGenericAtlasPassivePoints => 0;

		public static int RitualAtlasPassivePointsAvailable => 0;

		public static int TotalRitualAtlasPassivePoints => 0;

		public static int ExpeditionAtlasPassivePointsAvailable => 0;

		public static int TotalExpeditionAtlasPassivePoints => 0;

		public static int TempleAtlasPassivePointsAvailable => 0;

		public static int TotalTempleAtlasPassivePoints => 0;

		public static int DeliriumAtlasPassivePointsAvailable => 0;

		public static int TotalDeliriumAtlasPassivePoints => 0;

		public static int BreachAtlasPassivePointsAvailable => 0;

		public static int TotalBreachAtlasPassivePoints => 0;

		public static int AbyssAtlasPassivePointsAvailable => 0;

		public static int TotalAbyssAtlasPassivePoints => 0;

		public static Dictionary<ushort, ServerData.PassiveSkillGraphNode> PassiveSkillGraph => null;

		public static Dictionary<ushort, ServerData.PassiveSkillGraphNode> AtlasSkillGraph => null;

		public static List<ushort> PassiveSkillIds => null;

		public static IEnumerable<DatPassiveSkillWrapper> PassiveSkills
		{
			[IteratorStateMachine(typeof(_003Cget_PassiveSkills_003Ed__107))]
			get
			{
				return null;
			}
		}

		public static List<ushort> NormalJewelsPassiveIds => null;

		public static Dictionary<ushort, Item> NormalJewelsPassiveIdItemDictionaly => null;

		public static List<ushort> JewelsPassiveSkillIds => null;

		public static IEnumerable<DatPassiveSkillWrapper> JewelsPassiveSkills
		{
			[IteratorStateMachine(typeof(_003Cget_JewelsPassiveSkills_003Ed__115))]
			get
			{
				return null;
			}
		}

		public static uint CharacterLevel => 0u;

		public static int ExtraPassiveSkillPoints => 0;

		public static int PassiveSkillPointsAvailable => 0;

		public static uint TotalAscendencyPoints => 0u;

		public static uint SpentAscendencyPoints => 0u;

		public static uint AscendencySkillPointsAvailable => 0u;

		public static string RawZoneDescription => null;

		public static ushort LastActionId => 0;

		public static Skill LastAction => null;

		public static int MonstersLevel => 0;

		public static int MonstersRemaining => 0;

		public static bool IsMapCompleted => true;

		internal static long Address => 0L;

		[SpecialName]
		private static IEnumerable<uint> smethod_0()
		{
			return null;
		}

		private static List<MinimapIconWrapper> smethod_1()
		{
			return null;
		}

		private static List<Skill> smethod_2()
		{
			return null;
		}

		private static string smethod_3()
		{
			return null;
		}

		public static List<Item> GetPlayerInventoryItemsBySlot(InventorySlot inventorySlot)
		{
			return null;
		}

		public static Inventory GetPlayerInventoryBySlot(InventorySlot inventoryType)
		{
			return null;
		}

		public static Inventory GetPlayerInventoryById(int id)
		{
			return null;
		}

		private static AtlasPanelNode.AtlasPassiveSkillSubtreeType smethod_4(string string_0)
		{
			return (AtlasPanelNode.AtlasPassiveSkillSubtreeType)(object)null;
		}

		public static bool HasAtlasPassive(string value)
		{
			return true;
		}

		public static bool HasPassive(string value)
		{
			return true;
		}

		internal static bool smethod_5()
		{
			return true;
		}

		internal static InstanceInfo smethod_6()
		{
			return null;
		}

		static InstanceInfo()
		{
			Class200.smethod_34();
		}
	}

	public static class LocalData
	{
		private static PerFrameCachedValue<DreamPoeBot.Common.Vector2> perFrameCachedValue_0;

		private static PerFrameCachedValue<Vector2i> perFrameCachedValue_1;

		private static PerFrameCachedValue<byte> perFrameCachedValue_2;

		private static PerFrameCachedValue<float> perFrameCachedValue_3;

		private static uint uint_0;

		private static DatWorldAreaWrapper datWorldAreaWrapper_0;

		private static LocalData localData_0;

		public static int MyId => 0;

		public static long MePtr => 0L;

		public static byte MyReaction => 0;

		public static float MyRotation => 0f;

		public static Vector2i MyPosition => (Vector2i)(object)null;

		public static float MyCharacterSize => 0f;

		public static DreamPoeBot.Common.Vector2 MyWorldPosition => (DreamPoeBot.Common.Vector2)(object)null;

		public static uint AreaHash => 0u;

		public static DatWorldAreaWrapper WorldArea => null;

		public static Dictionary<StatTypeGGG, int> MapMods => null;

		public static Dictionary<StatTypeGGG, int> SpecialMapMods => null;

		public static List<IngameData.PortalObject> TownPortals => null;

		internal static DreamPoeBot.Common.Vector2 smethod_0()
		{
			return (DreamPoeBot.Common.Vector2)(object)null;
		}

		internal static Vector2i smethod_1()
		{
			return (Vector2i)(object)null;
		}

		internal static byte smethod_2()
		{
			return 0;
		}

		internal static float smethod_3()
		{
			return 0f;
		}

		internal static bool smethod_4()
		{
			return true;
		}

		internal static LocalData smethod_5()
		{
			return null;
		}

		static LocalData()
		{
			Class200.smethod_34();
		}
	}

	public static class ProcessHookManager
	{
		public delegate void HookDisabledByIngecionEventHandler(object sender, HookDisabledByIngecionEventArgs e);

		public class HookDisabledByIngecionEventArgs : EventArgs
		{
			private string string_0;

			private static HookDisabledByIngecionEventArgs hookDisabledByIngecionEventArgs_0;

			public HookDisabledByIngecionEventArgs(string Text)
			{
			}

			public string GetInfo()
			{
				return null;
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static HookDisabledByIngecionEventArgs smethod_1()
			{
				return null;
			}

			static HookDisabledByIngecionEventArgs()
			{
				Class200.smethod_34();
			}
		}

		public enum StateEnum
		{
			None,
			Enabled,
			Disabled
		}

		private static readonly ILog ilog_0;

		internal static bool bool_0;

		public static HookDisabledByIngecionEventHandler OnInjectionDisabledByIngecion;

		internal static ProcessHookManager processHookManager_0;

		public static bool IsEnabled => true;

		public static StateEnum State => (StateEnum)(object)null;

		public static void DebugStateManager(bool state)
		{
		}

		public static void ClearAllKeyStates()
		{
		}

		public static void ClearAllKeyStatesBeside(HashSet<Keys> keys)
		{
		}

		public static void Enable()
		{
		}

		public static void Disable()
		{
		}

		public static void SetKeyState(Keys key, short value, bool sleep, Keys modifier = Keys.None)
		{
		}

		public static void SetKeyState(Keys key, short value, Keys modifier = Keys.None)
		{
		}

		public static short GetKeyState(Keys key)
		{
			return 0;
		}

		public static bool IsKeyDown(Keys key)
		{
			return true;
		}

		public static void Reset()
		{
		}

		public static void ResetCursor()
		{
		}

		public static void ReadCursorPos(out int x, out int y, out int result)
		{
		}

		public static void SetDebugPacchetto(byte[] value, byte[] trigger)
		{
		}

		public static float GetDataFromTheClient()
		{
			return 0f;
		}

		static ProcessHookManager()
		{
			Class200.smethod_34();
			Class204.smethod_0();
			ilog_0 = Logger.GetLoggerInstanceForType();
			bool_0 = false;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static ProcessHookManager smethod_1()
		{
			return null;
		}
	}

	public static class TemporaryPerformanceProfiler
	{
		private static readonly Dictionary<string, bool> dictionary_0;

		private static readonly Dictionary<string, bool> dictionary_1;

		private static readonly Dictionary<string, List<Tuple<uint, double>>> dictionary_2;

		private static readonly Dictionary<string, List<Tuple<uint, int, double>>> dictionary_3;

		private static readonly ConcurrentBag<Stopwatch> concurrentBag_0;

		internal static TemporaryPerformanceProfiler temporaryPerformanceProfiler_0;

		static TemporaryPerformanceProfiler()
		{
			Class200.smethod_34();
			Class204.smethod_0();
			dictionary_0 = new Dictionary<string, bool>
			{
				{
					Class200.smethod_20(2969730),
					false
				},
				{
					Class200.smethod_20(2969782),
					false
				},
				{
					Class200.smethod_20(2969840),
					false
				},
				{
					Class200.smethod_20(2969886),
					false
				},
				{
					Class200.smethod_20(2969928),
					false
				}
			};
			dictionary_1 = new Dictionary<string, bool>();
			dictionary_2 = new Dictionary<string, List<Tuple<uint, double>>>();
			dictionary_3 = new Dictionary<string, List<Tuple<uint, int, double>>>();
			concurrentBag_0 = new ConcurrentBag<Stopwatch>();
		}

		internal static void smethod_0(Stopwatch stopwatch_0)
		{
		}

		internal static void smethod_1(Stopwatch stopwatch_0)
		{
		}

		public static void Clear()
		{
		}

		public static void LogAndClear()
		{
		}

		internal static void smethod_2(AnnotatedContainerProfiler annotatedContainerProfiler_0)
		{
		}

		internal static void smethod_3(AnnotatedProfiler annotatedProfiler_0)
		{
		}

		public static bool IsCategoryProfilable(string category)
		{
			return true;
		}

		private static void smethod_4(string string_0, bool bool_0)
		{
		}

		public static void EnableCategoryForProfiling(string category)
		{
		}

		public static void DisableCategoryFromProfiling(string category)
		{
		}

		internal static bool smethod_5()
		{
			return true;
		}

		internal static TemporaryPerformanceProfiler smethod_6()
		{
			return null;
		}
	}

	public class AnnotatedContainerProfiler : IDisposable
	{
		[CompilerGenerated]
		private readonly Stopwatch stopwatch_0;

		[CompilerGenerated]
		private readonly string string_0;

		[CompilerGenerated]
		private readonly string string_1;

		[CompilerGenerated]
		private readonly uint uint_0;

		[CompilerGenerated]
		private int int_0;

		internal static AnnotatedContainerProfiler annotatedContainerProfiler_0;

		public int Count
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[SpecialName]
		[CompilerGenerated]
		internal Stopwatch method_0()
		{
			return null;
		}

		[SpecialName]
		[CompilerGenerated]
		internal string method_1()
		{
			return null;
		}

		[SpecialName]
		[CompilerGenerated]
		internal string method_2()
		{
			return null;
		}

		[SpecialName]
		[CompilerGenerated]
		internal uint method_3()
		{
			return 0u;
		}

		internal AnnotatedContainerProfiler(string category, string annotation)
		{
		}

		public void Dispose()
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static AnnotatedContainerProfiler smethod_1()
		{
			return null;
		}

		static AnnotatedContainerProfiler()
		{
			Class200.smethod_34();
		}
	}

	public class AnnotatedProfiler : IDisposable
	{
		[CompilerGenerated]
		private readonly Stopwatch stopwatch_0;

		[CompilerGenerated]
		private readonly string string_0;

		[CompilerGenerated]
		private readonly string string_1;

		[CompilerGenerated]
		private readonly uint uint_0;

		internal static AnnotatedProfiler annotatedProfiler_0;

		[SpecialName]
		[CompilerGenerated]
		internal Stopwatch method_0()
		{
			return null;
		}

		[SpecialName]
		[CompilerGenerated]
		internal string method_1()
		{
			return null;
		}

		[SpecialName]
		[CompilerGenerated]
		internal string method_2()
		{
			return null;
		}

		[SpecialName]
		[CompilerGenerated]
		internal uint method_3()
		{
			return 0u;
		}

		internal AnnotatedProfiler(string category, string annotation)
		{
		}

		public void Dispose()
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static AnnotatedProfiler smethod_1()
		{
			return null;
		}

		static AnnotatedProfiler()
		{
			Class200.smethod_34();
		}
	}

	public static class CaracterCreationState
	{
		public enum CharacterCreationResult
		{
			None,
			NoNameEntered,
			ProcessHookManagerNotEnabled,
			NoLeagueSelected,
			FailedTogetClassPosition,
			UnableToSetCharacterName,
			NameAlreadyExist
		}

		public enum League
		{
			Standard,
			League,
			HardcoreLeague
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CCreateNonRaceCharacter_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<CharacterCreationResult> _003C_003Et__builder;

			public string name;

			public League league;

			public CharacterClass characterClass;

			internal static object object_0;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static object smethod_1()
			{
				return null;
			}

			static _003CCreateNonRaceCharacter_003Ed__4()
			{
				Class200.smethod_34();
			}
		}

		private static readonly Dictionary<CharacterClass, Vector2i> dictionary_0;

		private static CaracterCreationState caracterCreationState_0;

		public static string SelectedLeague => null;

		public static CharacterClass SelectedCharacterClass => (CharacterClass)(object)null;

		[AsyncStateMachine(typeof(_003CCreateNonRaceCharacter_003Ed__4))]
		public static Task<CharacterCreationResult> CreateNonRaceCharacter(League league, CharacterClass characterClass, string name)
		{
			return null;
		}

		[SpecialName]
		private static string smethod_0()
		{
			return null;
		}

		[SpecialName]
		private static List<Element> smethod_1()
		{
			return null;
		}

		[SpecialName]
		private static Element smethod_2()
		{
			return null;
		}

		[SpecialName]
		private static Element smethod_3()
		{
			return null;
		}

		[SpecialName]
		private static Element smethod_4()
		{
			return null;
		}

		[SpecialName]
		private static Element smethod_5()
		{
			return null;
		}

		[SpecialName]
		private static Element smethod_6()
		{
			return null;
		}

		[SpecialName]
		private static LeagueSelectionElement smethod_7()
		{
			return null;
		}

		[SpecialName]
		private static string smethod_8()
		{
			return null;
		}

		private static void smethod_9(string string_0)
		{
		}

		static CaracterCreationState()
		{
			Class200.smethod_34();
			Class204.smethod_0();
			dictionary_0 = new Dictionary<CharacterClass, Vector2i>
			{
				{
					CharacterClass.Witch,
					new Vector2i(667, 402)
				},
				{
					CharacterClass.Duelist,
					new Vector2i(598, 396)
				},
				{
					CharacterClass.Ranger,
					new Vector2i(487, 422)
				},
				{
					CharacterClass.Sorceress,
					new Vector2i(413, 427)
				},
				{
					CharacterClass.Marauder,
					new Vector2i(345, 412)
				},
				{
					CharacterClass.Shadow,
					new Vector2i(287, 412)
				},
				{
					CharacterClass.Templar,
					new Vector2i(215, 412)
				},
				{
					CharacterClass.None,
					new Vector2i(0, 0)
				}
			};
		}

		internal static bool smethod_10()
		{
			return true;
		}

		internal static CaracterCreationState smethod_11()
		{
			return null;
		}
	}

	public static class SelectCharacterState
	{
		[StructLayout(LayoutKind.Explicit, Size = 200)]
		internal struct Struct59
		{
			[FieldOffset(16)]
			internal long long_0;

			[FieldOffset(24)]
			internal long long_1;

			[FieldOffset(32)]
			internal long long_2;

			[FieldOffset(72)]
			internal long long_3;

			[FieldOffset(88)]
			internal NativeVector nativeVector_0;

			[FieldOffset(112)]
			internal NativeVector nativeVector_1;

			[FieldOffset(136)]
			internal int int_0;

			[FieldOffset(144)]
			internal NativeVector nativeVector_2;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		[Obsolete("old")]
		internal struct Struct60
		{
			private long long_0;

			private byte byte_0;

			private byte byte_1;

			private byte byte_2;

			private byte byte_3;

			private int int_0;

			private long long_1;

			public long long_2;

			private long long_3;

			public long long_4;

			private long long_5;

			private NativeVector nativeVector_0;

			private NativeVector nativeVector_1;

			public NativeVector nativeVector_2;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		[Obsolete("old")]
		private struct Struct62
		{
			public long long_0;

			public int int_0;
		}

		public enum SelectCharacterError
		{
			None,
			ProcessHookManagerNotEnabled,
			NotInCharacterSelectionState,
			NotOnCharacterSelectionScreen,
			CharactersNotLoaded,
			UnableToShowAllCharacters,
			CouldNotFindCharacter,
			PlayButtonDisabled,
			OptionsDialogOpen,
			HighlightCharacterTimedOut,
			ClientBug,
			CouldNotFindCharacterIndex
		}

		private static PerFrameCachedValue<Struct59> perFrameCachedValue_0;

		internal static SelectCharacterState selectCharacterState_0;

		public static bool IsCharacterListLoaded => true;

		public static IEnumerable<CharacterEntry> Characters => null;

		public static SelectCharElement SelectCharacterElement => null;

		public static long IntPtr_PlayButton => 0L;

		public static bool IsLogInTownWarningDisplayed => true;

		private static Struct59 Structure => (Struct59)(object)null;

		public static SelectCharacterError SelectCharacter(string name)
		{
			return (SelectCharacterError)(object)null;
		}

		public static SelectCharacterError SelectCharacter(string name, bool forceTown)
		{
			return (SelectCharacterError)(object)null;
		}

		public static void PressCreateCharacter()
		{
		}

		public static SelectCharacterError CreateNonRaceCharacter()
		{
			return (SelectCharacterError)(object)null;
		}

		private static Struct59 smethod_0()
		{
			return (Struct59)(object)null;
		}

		internal static bool smethod_1()
		{
			return true;
		}

		internal static SelectCharacterState smethod_2()
		{
			return null;
		}

		static SelectCharacterState()
		{
			Class200.smethod_34();
		}
	}

	public static class EscapeState
	{
		public enum LogoutError
		{
			None,
			ProcessHookManagerNotEnabled,
			NotInGame,
			ActivateEscapeStateFailed,
			ControlNotVisible
		}

		internal static EscapeState escapeState_0;

		internal static bool smethod_0()
		{
			return true;
		}

		public static bool ActivateEscapeState()
		{
			return true;
		}

		public static LogoutError ExitGame()
		{
			return (LogoutError)(object)null;
		}

		public static LogoutError ExitGame(int delayBetweenMenuAndClickMs)
		{
			return (LogoutError)(object)null;
		}

		public static LogoutError LogoutToTitleScreen()
		{
			return (LogoutError)(object)null;
		}

		public static LogoutError LogoutToTitleScreen(int delayBetweenMenuAndClickMs)
		{
			return (LogoutError)(object)null;
		}

		public static LogoutError LogoutToCharacterSelection()
		{
			return (LogoutError)(object)null;
		}

		public static LogoutError LogoutToCharacterSelection(int delayBetweenMenuAndClickMs)
		{
			return (LogoutError)(object)null;
		}

		public static LogoutError RespawnAtCheckpoint(int delayBetweenMenuAndClickMs = 100)
		{
			return (LogoutError)(object)null;
		}

		private static Vector2i smethod_1(Element element_0)
		{
			return (Vector2i)(object)null;
		}

		internal static bool smethod_2()
		{
			return true;
		}

		internal static EscapeState smethod_3()
		{
			return null;
		}

		static EscapeState()
		{
			Class200.smethod_34();
		}
	}

	public static class InGameState
	{
		public static class ChatPanel
		{
			public class ChatEntry
			{
				private string string_0;

				private string string_1;

				[CompilerGenerated]
				private readonly string string_2;

				[CompilerGenerated]
				private readonly ulong ulong_0;

				[CompilerGenerated]
				private readonly MessageType messageType_0;

				[CompilerGenerated]
				private readonly byte byte_0;

				[CompilerGenerated]
				private readonly byte byte_1;

				internal long long_0;

				private static ChatEntry chatEntry_0;

				public string MD5 => null;

				public string RemoteName
				{
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				public string Message => null;

				public ulong MessageHash
				{
					[CompilerGenerated]
					get
					{
						return 0uL;
					}
				}

				public MessageType MessageType
				{
					[CompilerGenerated]
					get
					{
						return (MessageType)(object)null;
					}
				}

				public byte Flag1
				{
					[CompilerGenerated]
					get
					{
						return 0;
					}
				}

				public byte Flag2
				{
					[CompilerGenerated]
					get
					{
						return 0;
					}
				}

				internal ChatEntry(ChatMessageStruct native, Dictionary<int, string> idToName)
				{
				}

				internal static bool smethod_0()
				{
					return true;
				}

				internal static ChatEntry smethod_1()
				{
					return null;
				}

				static ChatEntry()
				{
					Class200.smethod_34();
				}
			}

			public static class Commands
			{
				internal static Commands commands_0;

				public static ChatResult destroy(bool actuallySend = true)
				{
					return (ChatResult)(object)null;
				}

				public static ChatResult hideout(bool actuallySend = true)
				{
					return (ChatResult)(object)null;
				}

				public static ChatResult menagerie(bool actuallySend = true)
				{
					return (ChatResult)(object)null;
				}

				public static ChatResult delve(bool actuallySend = true)
				{
					return (ChatResult)(object)null;
				}

				public static ChatResult dnd(bool actuallySend = true)
				{
					return (ChatResult)(object)null;
				}

				public static ChatResult dnd(string message, bool actuallySend = true)
				{
					return (ChatResult)(object)null;
				}

				internal static bool smethod_0()
				{
					return true;
				}

				internal static Commands smethod_1()
				{
					return null;
				}

				static Commands()
				{
					Class200.smethod_34();
				}
			}

			public class LazyChatEntry
			{
				private readonly ChatMessageStruct chatMessageStruct_0;

				private readonly Dictionary<int, string> dictionary_0;

				private static LazyChatEntry lazyChatEntry_0;

				internal LazyChatEntry(ChatMessageStruct native, Dictionary<int, string> idToName)
				{
				}

				public ChatEntry Resolve()
				{
					return null;
				}

				internal static bool smethod_0()
				{
					return true;
				}

				internal static LazyChatEntry smethod_1()
				{
					return null;
				}

				static LazyChatEntry()
				{
					Class200.smethod_34();
				}
			}

			public enum MessageType
			{
				Local,
				Global,
				Party,
				Whisper,
				System,
				Trade,
				Guild
			}

			[StructLayout(LayoutKind.Explicit)]
			public struct ChatMessageStruct
			{
				[FieldOffset(0)]
				public MessageType messageType_0;

				[FieldOffset(168)]
				public long intptr_1Message;

				[FieldOffset(176)]
				public int int_nameId;

				[FieldOffset(180)]
				public byte byte_flag1;

				[FieldOffset(182)]
				public byte byte_flag2;

				[FieldOffset(192)]
				public ulong intptr_messageHash;

				internal static object object_0;

				public byte[] GetByteArray => null;

				internal static bool smethod_0()
				{
					return true;
				}

				internal static object smethod_1()
				{
					return null;
				}

				static ChatMessageStruct()
				{
					Class200.smethod_34();
				}
			}

			[StructLayout(LayoutKind.Sequential, Size = 32)]
			[UnsafeValueType]
			public struct Struct61
			{
				public unsafe fixed byte byte_0[32];
			}

			internal static ChatPanel chatPanel_0;

			public static List<string> ActiveCharacterNames => null;

			public static int CurrentChatLines => 0;

			public static bool IsOpened => true;

			public static List<KeyValuePair<long, LazyChatEntry>> LazyMessages => null;

			public static List<ChatEntry> Messages => null;

			public static bool ToggleChat(bool actuallyToggle = true)
			{
				return true;
			}

			[SpecialName]
			internal static Dictionary<int, string> smethod_0()
			{
				return null;
			}

			[SpecialName]
			internal static long smethod_1()
			{
				return 0L;
			}

			[SpecialName]
			internal static long smethod_2()
			{
				return 0L;
			}

			[SpecialName]
			internal static long smethod_3()
			{
				return 0L;
			}

			public static ChatResult Chat(string message, bool actuallySend = true, bool clearchat = false)
			{
				return (ChatResult)(object)null;
			}

			private static bool smethod_4()
			{
				return true;
			}

			internal static bool smethod_5()
			{
				return true;
			}

			internal static ChatPanel smethod_6()
			{
				return null;
			}

			static ChatPanel()
			{
				Class200.smethod_34();
			}
		}

		public static class ContextMenu
		{
			internal static ContextMenu contextMenu_0;

			public static bool IsOpened => true;

			public static bool IsEnable => true;

			public static ContextMenuResult Close(bool actuallyPerform = true)
			{
				return (ContextMenuResult)(object)null;
			}

			public static ContextMenuResult InviteToParty(bool actuallyPerform = true)
			{
				return (ContextMenuResult)(object)null;
			}

			public static ContextMenuResult KickFromParty(bool actuallyPerform = true)
			{
				return (ContextMenuResult)(object)null;
			}

			public static ContextMenuResult LeaveCurrentParty(bool actuallyPerform = true)
			{
				return (ContextMenuResult)(object)null;
			}

			public static ContextMenuResult PromoteToPartyLeader(bool actuallyPerform = true)
			{
				return (ContextMenuResult)(object)null;
			}

			public static ContextMenuResult Trade(bool actuallyPerform = true)
			{
				return (ContextMenuResult)(object)null;
			}

			public static ContextMenuResult VisitHideout(bool actuallyPerform = true)
			{
				return (ContextMenuResult)(object)null;
			}

			public static ContextMenuResult VisitMenagerie(bool actuallyPerform = true)
			{
				return (ContextMenuResult)(object)null;
			}

			private static ContextMenuResult smethod_0(Vector2i vector2i_0, bool bool_0)
			{
				return (ContextMenuResult)(object)null;
			}

			internal static bool smethod_1()
			{
				return true;
			}

			internal static ContextMenu smethod_2()
			{
				return null;
			}

			static ContextMenu()
			{
				Class200.smethod_34();
			}
		}

		public static class DebugOverlay
		{
			internal static DebugOverlay debugOverlay_0;

			public static bool IsOpened => true;

			public static bool IsShowingFull => true;

			public static bool IsShowingMinimal => true;

			public static string LatencyText => null;

			public static List<float> LatencyValues => null;

			public static string FpsText => null;

			public static List<float> FpsValues => null;

			public static string FrameTimeText => null;

			public static List<float> FrameTimeValues => null;

			internal static bool smethod_0()
			{
				return true;
			}

			internal static DebugOverlay smethod_1()
			{
				return null;
			}

			static DebugOverlay()
			{
				Class200.smethod_34();
			}
		}

		public delegate bool ProcessNotification(string sender, NotificationType type);

		public delegate bool ProcessNotificationEx(NotificationData data, NotificationType type);

		public class NotificationData
		{
			[CompilerGenerated]
			private string string_0;

			[CompilerGenerated]
			private string string_1;

			[CompilerGenerated]
			private string string_2;

			[CompilerGenerated]
			private string string_3;

			[CompilerGenerated]
			private string string_4;

			[CompilerGenerated]
			private string string_5;

			[CompilerGenerated]
			private NotificationType notificationType_0;

			private static NotificationData notificationData_0;

			public string AccountName
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public string CharacterName
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public string CharacterLevel
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public string CharacterArea
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public string Information
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public string GuildName
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public NotificationType NotificationType
			{
				[CompilerGenerated]
				get
				{
					return (NotificationType)(object)null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static NotificationData smethod_1()
			{
				return null;
			}

			static NotificationData()
			{
				Class200.smethod_34();
			}
		}

		public static class NotificationHud
		{
			internal static class Class63
			{
				private static string string_0;

				private static string string_1;

				private static string string_2;

				private static string string_3;

				private static string string_4;

				private static string string_5;

				private static string string_6;

				private static Class63 class63_0;

				public static string Accept => null;

				public static string Decline => null;

				[SpecialName]
				public static string smethod_0()
				{
					return null;
				}

				[SpecialName]
				public static string smethod_1()
				{
					return null;
				}

				[SpecialName]
				public static string smethod_2()
				{
					return null;
				}

				[SpecialName]
				public static string smethod_3()
				{
					return null;
				}

				[SpecialName]
				public static string gdqpqZeKgtq()
				{
					return null;
				}

				internal static bool smethod_4()
				{
					return true;
				}

				internal static Class63 smethod_5()
				{
					return null;
				}

				static Class63()
				{
					Class200.smethod_34();
				}
			}

			internal static NotificationHud notificationHud_0;

			public static bool IsOpened => true;

			public static List<NotificationHudElement.NotificationInfo> NotificationList => null;

			[SpecialName]
			internal static long smethod_0()
			{
				return 0L;
			}

			private static HandleNotificationResult smethod_1(ProcessNotificationEx processNotificationEx_0, bool bool_0, Vector2i vector2i_0, Vector2i vector2i_1, NotificationData notificationData_0, NotificationType notificationType_0)
			{
				return (HandleNotificationResult)(object)null;
			}

			internal static bool smethod_2(string string_0, out string string_1)
			{
				return true;
			}

			public static HandleNotificationResult HandleNotificationEx(ProcessNotificationEx func, bool actuallyHandle = true)
			{
				return (HandleNotificationResult)(object)null;
			}

			internal static bool smethod_3()
			{
				return true;
			}

			internal static NotificationHud smethod_4()
			{
				return null;
			}

			static NotificationHud()
			{
				Class200.smethod_34();
			}
		}

		public static class ResurrectPanel
		{
			internal static ResurrectPanel resurrectPanel_0;

			public static bool IsOpened => true;

			public static string ResurrectText => null;

			public static bool IsWaitForPartyRezVisible => true;

			public static ResurrectResult Resurrect()
			{
				return (ResurrectResult)(object)null;
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static ResurrectPanel smethod_1()
			{
				return null;
			}

			static ResurrectPanel()
			{
				Class200.smethod_34();
			}
		}

		public class DockedWindowControlWrapper : InventoryElement
		{
			internal static DockedWindowControlWrapper dockedWindowControlWrapper_0;

			public string Title => null;

			public DockedWindowControlWrapper()
			{
			}

			public DockedWindowControlWrapper(long addres)
			{
			}

			internal static bool smethod_13()
			{
				return true;
			}

			internal static DockedWindowControlWrapper smethod_14()
			{
				return null;
			}

			static DockedWindowControlWrapper()
			{
				Class200.smethod_34();
			}
		}

		public static class AtlasWarningDialog
		{
			private static AtlasWarningDialog atlasWarningDialog_0;

			public static bool IsOpened => true;

			public static string BodyText => null;

			public static string ActionText => null;

			public static bool ConfirmDialog(bool actuallyConfirm = true)
			{
				return true;
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static AtlasWarningDialog smethod_1()
			{
				return null;
			}

			static AtlasWarningDialog()
			{
				Class200.smethod_34();
			}
		}

		public static class GlobalWarningDialog
		{
			internal static GlobalWarningDialog globalWarningDialog_0;

			public static bool IsOpened => true;

			public static bool IsMapBossEncounterWarningOpen => true;

			public static bool IsPassiveTreeResetWarningOverlayOpen => true;

			public static bool IsVendoringItemWithGemsOverlayOpen => true;

			public static bool IsVendoringItemWithIncubatorsOverlayOpen => true;

			public static bool IsTradingItemWithGemsOverlayOpen => true;

			public static bool IsDismissMasterWarningOverlayOpen => true;

			public static bool IsDestroyItemWarningOverlayOpen => true;

			public static bool IsSealProphecyOverlayOpen => true;

			public static bool IsAbandonLabyrintWarningOverlayOpen => true;

			public static bool IsPassiveTreeWarningOverlayOpen => true;

			public static bool IsPassiveWarningOverlayOpen => true;

			public static bool IsBetrayalLeaveZoneWarningOverlayOpen => true;

			public static string TitleText => null;

			public static string BodyText => null;

			public static string CancelText => null;

			public static string ActionText => null;

			[SpecialName]
			internal static long smethod_0()
			{
				return 0L;
			}

			[SpecialName]
			internal static long smethod_1()
			{
				return 0L;
			}

			[SpecialName]
			internal static long smethod_2()
			{
				return 0L;
			}

			[SpecialName]
			internal static long smethod_3()
			{
				return 0L;
			}

			[SpecialName]
			internal static long smethod_4()
			{
				return 0L;
			}

			[SpecialName]
			internal static long smethod_5()
			{
				return 0L;
			}

			public static bool ConfirmDialog(bool actuallyConfirm = true)
			{
				return true;
			}

			public static bool CancelDialog(bool actuallyCancel = true)
			{
				return true;
			}

			internal static bool smethod_6()
			{
				return true;
			}

			internal static GlobalWarningDialog smethod_7()
			{
				return null;
			}

			static GlobalWarningDialog()
			{
				Class200.smethod_34();
			}
		}

		public static class CursorItemOverlay
		{
			[StructLayout(LayoutKind.Sequential, Pack = 1)]
			internal struct Struct63
			{
				private long long_0;

				public CursorItemModes cursorItemModes_0;

				private int int_0;

				public long long_1;

				private int int_1;

				public int int_2;

				public int int_3;
			}

			internal static CursorItemOverlay cursorItemOverlay_0;

			public static bool IsOpened => true;

			public static CursorItemModes Mode => (CursorItemModes)(object)null;

			public static Vector2i ItemSize => (Vector2i)(object)null;

			public static Item Item => null;

			public static Inventory Inventory => null;

			[SpecialName]
			internal static long smethod_0()
			{
				return 0L;
			}

			[SpecialName]
			internal static Struct63 smethod_1()
			{
				return (Struct63)(object)null;
			}

			[SpecialName]
			internal static int smethod_2()
			{
				return 0;
			}

			[SpecialName]
			internal static int smethod_3()
			{
				return 0;
			}

			internal static bool smethod_4()
			{
				return true;
			}

			internal static CursorItemOverlay smethod_5()
			{
				return null;
			}

			static CursorItemOverlay()
			{
				Class200.smethod_34();
			}
		}

		public static class QuickFlaskHud
		{
			internal static InventoryControlWrapper inventoryControlWrapper_0;

			internal static QuickFlaskHud quickFlaskHud_0;

			public static bool IsOpened => true;

			public static InventoryControlWrapper InventoryControl => null;

			[SpecialName]
			internal static long smethod_0()
			{
				return 0L;
			}

			public static bool UseFlaskInSlot(int slot)
			{
				return true;
			}

			public static bool IsFlaskInCooldown(int slot)
			{
				return true;
			}

			static QuickFlaskHud()
			{
				Class200.smethod_34();
				Class204.smethod_0();
				inventoryControlWrapper_0 = new InventoryControlWrapper(0L);
			}

			internal static bool smethod_1()
			{
				return true;
			}

			internal static QuickFlaskHud smethod_2()
			{
				return null;
			}
		}

		public enum JoinInstanceResult
		{
			None,
			ProcessHookManagerNotEnabled,
			NewInstanceNotAllowed,
			UiNotOpen,
			EnterControlNotVisible,
			UnableToJoin
		}

		public enum SelectMasterMissionResult
		{
			None,
			ProcessHookManagerNotEnabled,
			MasterDeviceNotOpen,
			Failed
		}

		public enum HideoutEnum
		{
			Unknown,
			Backstreet,
			BattleScarred,
			Cartographer,
			Coastal,
			Enlightened,
			Immaculate,
			Lush,
			Skeletal,
			Unearthed,
			Baleful,
			Coral,
			Desert,
			Excavated,
			Luxurious,
			Stately,
			Undercity,
			Alpine,
			Arboreal,
			Brutal,
			Celestial,
			Divided,
			Glacial,
			Haunted,
			Overgrown,
			RobbersTrench,
			Sanguine,
			Sunken
		}

		public enum CursorItemModes
		{
			None = 0,
			PhysicalMove = 1,
			VirtualUse = 2,
			VirtualMove = 3,
			InGameInteraction = 5,
			EssenceUpgrade = 7,
			OilUpgrade = 8,
			ScarabUpgrade = 9,
			NecropolisModMove = 13,
			GenesisTreeCraft = 14
		}

		public enum TempleOfferingOpenResult
		{
			None,
			ProcessHookManagerNotEnabled
		}

		public enum RemoveTempleOfferingItemResult
		{
			None,
			ProcessHookManagerNotEnabled
		}

		public enum RemoveDistilledEmotionResult
		{
			None,
			ProcessHookManagerNotEnabled,
			SlotNotVisible,
			InvalidSlot
		}

		public enum FastMoveFromSlotResult
		{
			None,
			ProcessHookManagerNotEnabled,
			SlotNotVisible,
			InvalidSlot
		}

		public enum InstilResult
		{
			None,
			ProcessHookManagerNotEnabled,
			InvalidNumberOfDistilledEmotion,
			ButtonIsDisabled
		}

		public enum ReforgeResult
		{
			None,
			ProcessHookManagerNotEnabled,
			InvalidNumberOfDistilledEmotion,
			ButtonIsDisabled
		}

		public enum PlaceCursorInDistilledEmotionSlotResult
		{
			None,
			ProcessHookManagerNotEnabled,
			SlotNotVisible,
			InvalidSlot
		}

		public enum PlaceCursorInSlotResult
		{
			None,
			ProcessHookManagerNotEnabled,
			SlotNotVisible,
			InvalidSlot
		}

		public enum UseResult
		{
			None,
			ProcessHookManagerNotEnabled,
			InvalidSlot,
			NoSkill,
			SkillNotOnBar,
			UnboundKey,
			CouldNotHighlight,
			NetworkObjectIsNull
		}

		public enum ConverseResult
		{
			None,
			ProcessHookManagerNotEnabled,
			DialogNotFound,
			DialogNotVisible,
			UiNotOpen,
			IncorrectDialogWindowDepth,
			ChatEntryDisabled
		}

		public enum TakeWaypointResult
		{
			None,
			ProcessHookManagerNotEnabled,
			AreaNotFound,
			UiNotOpen,
			WaypointNotUsable,
			CouldNotSwitchToPart,
			CouldNotSwitchToAct,
			WaypointControlNotVisible,
			InstanceManagerDidNotOpen,
			CouldNotJoinNewInstance,
			TooManyInstances,
			HideoutControlNotVisible,
			NoHideout,
			NoHideoutTooltip,
			LabyrinthControlNotVisible,
			MenagerieControlNotVisible
		}

		public enum TalkToBanditResult
		{
			None,
			ProcessHookManagerNotEnabled,
			UiNotOpen,
			NoButtonFound,
			AlreadyChosen
		}

		public enum ActivateResult
		{
			None,
			ProcessHookManagerNotEnabled,
			UiNotOpen,
			NoItem,
			NotEnabled,
			NotVisible,
			ScrollFailed,
			OptionNotSelected,
			OptionNotFound,
			OptionUnaffordable,
			OptionUnusable
		}

		public enum OpenKiracMissionsResult
		{
			None,
			ProcessHookManagerNotEnabled,
			UiNotOpen,
			NoItem,
			NotEnabled,
			NotVisible,
			ScrollFailed,
			OptionNotSelected,
			OptionNotFound,
			OptionUnaffordable,
			OptionUnusable
		}

		public enum ActivateDeferResult
		{
			None,
			ProcessHookManagerNotEnabled,
			UiNotOpen,
			NotEnabled,
			NotVisible,
			Failed
		}

		public enum ConfirmDeferResult
		{
			None,
			ProcessHookManagerNotEnabled,
			UiNotOpen,
			NotEnabled,
			NotVisible,
			Failed,
			DeferNotActive
		}

		public enum OpenRitualRewardPannelResult
		{
			None,
			ProcessHookManagerNotEnabled,
			UiNotOpen,
			NotEnabled,
			NotVisible,
			Failed
		}

		public enum FavorRerollResult
		{
			None,
			ProcessHookManagerNotEnabled,
			UiNotOpen,
			NotEnabled,
			NotVisible,
			Failed
		}

		public enum OfferTributeToTheKingResult
		{
			None,
			ProcessHookManagerNotEnabled,
			UiNotOpen,
			NotEnabled,
			NotVisible,
			Failed,
			DeferActive
		}

		public enum OpenAtlasResult
		{
			None,
			ProcessHookManagerNotEnabled,
			UiNotOpen,
			NotEnabled
		}

		public enum ChatResult
		{
			None,
			Failed,
			ProcessHookManagerNotEnabled,
			UiNotOpen,
			ToggleChatFailed,
			BlockingWindowPresent,
			InvalidChatMessage
		}

		public enum SetSlotResult
		{
			None,
			ProcessHookManagerNotEnabled,
			UiNotOpen,
			SkillNotFound,
			SlotNotFound,
			InvalidSlot,
			OptionNotFound,
			OptionNotVisible,
			OptionNotEnabled,
			SkillIsNull
		}

		public enum ResurrectResult
		{
			None,
			ProcessHookManagerNotEnabled,
			ResurrectButtonNotShowing
		}

		public enum HandlePendingLevelUpResult
		{
			None,
			ProcessHookManagerNotEnabled,
			UiNotOpen,
			NoGemsToLevel,
			GemDismissed,
			GemLeveled
		}

		public enum SocketPassiveGemError
		{
			None,
			ProcessHookManagerNotEnabled,
			UiNotOpen,
			IdNotFound,
			Unselectable,
			NodeNotLoaded,
			AscendencyUiOpened,
			FailedToAssign
		}

		public enum RefundPassiveError
		{
			None,
			ProcessHookManagerNotEnabled,
			UiNotOpen,
			IdNotFound,
			NotSelected,
			RofundNotEnabled,
			NoRefundPointToUse,
			NotAllocatingPassives,
			FailedToRemove,
			PassiveCantBeRemoved
		}

		public enum ChoosePassiveError
		{
			None,
			ProcessHookManagerNotEnabled,
			UiNotOpen,
			IdNotFound,
			AlreadySelected,
			Unselectable,
			NoPassivesToUse,
			NotAllocatingPassives,
			NodeNotLoaded,
			AscendencyUiOpened,
			FailedToAssign,
			IdIsNotMasteryNode,
			FailedToOpenMasteryUi,
			MasteryIdNotFount,
			AllMasteryAlreadyAssigned
		}

		public enum PassiveAllocationActionError
		{
			None,
			ProcessHookManagerNotEnabled,
			UiNotOpen,
			NoOperation,
			AllocatingPassives,
			RefundingPassives,
			NoRefundsToUse
		}

		public enum NotificationType
		{
			Trade,
			Party,
			Friend,
			Guild,
			Info,
			SoloPvP,
			PartyPvP,
			Unknown
		}

		public enum HandleNotificationResult
		{
			Accepted,
			Declined,
			Dismissed,
			NoNotifications,
			ProcessHookManagerNotEnabled,
			UiNotOpen,
			TabNotSelected,
			Obstructed,
			InternalError,
			NoHandler
		}

		public enum HandlePendingPartyInviteResut
		{
			Accepted,
			Denied,
			NoPendingInvites,
			ProcessHookManagerNotEnabled,
			UiNotOpen,
			TabNotSelected,
			Obstructed,
			InternalError
		}

		public enum ChangeLevelDownscalingResult
		{
			None,
			ProcessHookManagerNotEnabled,
			UiNotOpen,
			TabNotSelected,
			Obstructed,
			SelectComboboxIndexError,
			InternalError,
			Failed
		}

		public enum LeaveCurrentPartyResult
		{
			None,
			ProcessHookManagerNotEnabled,
			UiNotOpen,
			TabNotSelected,
			LeaveNotFound,
			Obstructed
		}

		public enum InviteToPartyResult
		{
			None,
			ProcessHookManagerNotEnabled,
			UiNotOpen,
			TabNotSelected,
			InvalidCharacterName
		}

		public enum SplitResult
		{
			None,
			ProcessHookManagerNotEnabled,
			UiNotOpen
		}

		public enum OpenContextMenuResult
		{
			None,
			ProcessHookManagerNotEnabled,
			UiNotOpen,
			WindowBlocking,
			NotFound
		}

		public enum FastGoToZoneResult
		{
			None,
			ProcessHookManagerNotEnabled,
			PartyMumberNotFound,
			UiNotOpen,
			WindowBlocking
		}

		public enum ContextMenuResult
		{
			None,
			ProcessHookManagerNotEnabled,
			UiNotOpen,
			Failed
		}

		public enum ChangeToDifficultyResult
		{
			None,
			ProcessHookManagerNotEnabled,
			UiNotOpen,
			NotEnabled
		}

		public enum ApplyCursorToAtlasResult
		{
			None,
			ProcessHookManagerNotEnabled,
			UiNotOpen,
			AreaNotFound,
			AreaControlNotEnable,
			AreaControlNotVisible,
			AreaControlNotUnlocked,
			LeftOrRightUiOpen
		}

		public enum StartBlightEncounterResult
		{
			None,
			ProcessHookManagerNotEnabled,
			UiNotOpen
		}

		public enum FinishDeliriumEncounterResult
		{
			None,
			ProcessHookManagerNotEnabled,
			UiNotOpen
		}

		public enum SelectHideoutResult
		{
			None,
			ProcessHookManagerNotEnabled,
			UiNotOpen,
			HideoutLocked,
			HideoutDoNotExist
		}

		public enum AssignPantheonResult
		{
			None,
			ProcessHookManagerNotEnabled,
			UiNotOpen,
			GodNotUnlocked,
			GodNotFound
		}

		public enum SelectZanaMissionMapResult
		{
			ProcessHookManagerNotEnabled,
			SelectedItemIsnull,
			UiNotOpen,
			UnableToFindeSelectedMap,
			SelectionFailed,
			None
		}

		public enum SelectKiracMissionMapResult
		{
			ProcessHookManagerNotEnabled,
			SelectedItemIsnull,
			UiNotOpen,
			UnableToFindeSelectedMap,
			SelectionFailed,
			None
		}

		public enum ActivateZanaMissionResult
		{
			ProcessHookManagerNotEnabled,
			UiNotOpen,
			None
		}

		public enum ActivateKiracMissionResult
		{
			ProcessHookManagerNotEnabled,
			UiNotOpen,
			None
		}

		public enum SelectUnveilModResult
		{
			None,
			ProcessHookManagerNotEnabled,
			UiNotOpen,
			UnableToFindeSelectedMod,
			SelectedModIsnull,
			SelectionFailed
		}

		public enum UnveilResult
		{
			None,
			ProcessHookManagerNotEnabled,
			UiNotOpen,
			ButtonNotEnabled
		}

		public enum ConfirmUnveilResult
		{
			None,
			ProcessHookManagerNotEnabled,
			UiNotOpen,
			ButtonNotEnabled
		}

		public enum AscendClass
		{
			Necromancer,
			Occultist,
			Elementalist,
			Chieftain,
			Berserker,
			Juggernaut,
			Slayer,
			Gladiator,
			Champion,
			Assassin,
			Saboteur,
			Trickster,
			Deadeye,
			Raider,
			Pathfinder,
			Inquisitor,
			Hierophant,
			Guardian,
			Ascendant
		}

		public enum OpenTempleOfAtzoatResult
		{
			None,
			ProcessHookManagerNotEnabled,
			UiNotOpen,
			ElementNotFound,
			ButtonNotVisible,
			ButtonLocationError
		}

		public enum TakeTempleOfAtzoatChronicleResult
		{
			None,
			ProcessHookManagerNotEnabled,
			UiNotOpen,
			ElementNotFound,
			ButtonNotVisible,
			ButtonLocationError
		}

		public enum PremiumPriceTypeEnum
		{
			Unknown = -1,
			EachItemIndividuallyPriced,
			SetNegotiablePriceOnAllItems,
			SetExactPriceOnAllItems
		}

		public enum ItemPriceTypeEnum
		{
			Unknown = -1,
			Note,
			NegotiablePrice,
			ExactPrice,
			DoNotIndex
		}

		public enum PriceCurrencyEnum
		{
			Unknown = -1,
			OrbOfAlchemy,
			ExaltedOrb,
			OrbOfAnnulment,
			DivineOrb,
			RegalOrb,
			ChaosOrb,
			ArtificersOrb,
			MirrorOfKalandra,
			OrbOfAugmentation,
			OrbOfChance,
			OrbOfTrasmutation,
			ScrollOfWisdom,
			VaalOrb
		}

		public class PreLevelSkillGemEventArgs : EventArgs
		{
			[CompilerGenerated]
			private readonly Inventory inventory_0;

			[CompilerGenerated]
			private readonly Item item_0;

			[CompilerGenerated]
			private readonly Item item_1;

			[CompilerGenerated]
			private readonly bool bool_0;

			private static PreLevelSkillGemEventArgs preLevelSkillGemEventArgs_0;

			public Inventory Inventory
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public Item Item
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public Item SkillGem
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public bool Debug
			{
				[CompilerGenerated]
				get
				{
					return true;
				}
			}

			internal PreLevelSkillGemEventArgs(Inventory inv, Item item, Item skillGem, bool debug)
			{
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static PreLevelSkillGemEventArgs smethod_1()
			{
				return null;
			}

			static PreLevelSkillGemEventArgs()
			{
				Class200.smethod_34();
			}
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct Struct64
		{
			private long long_0;

			private long long_1;

			private long long_2;

			public int int_0;

			public int int_1;

			public int int_2;
		}

		public static class AscendancyUi
		{
			[StructLayout(LayoutKind.Auto)]
			[CompilerGenerated]
			private struct _003CAscend_003Ed__2 : IAsyncStateMachine
			{
				public int _003C_003E1__state;

				public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

				public AscendClass ascendClass;

				private static object object_0;

				private void MoveNext()
				{
				}

				void IAsyncStateMachine.MoveNext()
				{
					//ILSpy generated this explicit interface implementation from .override directive in MoveNext
					this.MoveNext();
				}

				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}

				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
					this.SetStateMachine(stateMachine);
				}

				internal static bool smethod_0()
				{
					return true;
				}

				internal static object smethod_1()
				{
					return null;
				}

				static _003CAscend_003Ed__2()
				{
					Class200.smethod_34();
				}
			}

			internal static AscendancyUi ascendancyUi_0;

			public static bool IsOpened => true;

			[AsyncStateMachine(typeof(_003CAscend_003Ed__2))]
			public static Task<bool> Ascend(AscendClass ascendClass)
			{
				return null;
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static AscendancyUi smethod_1()
			{
				return null;
			}

			static AscendancyUi()
			{
				Class200.smethod_34();
			}
		}

		public static class AtlasSkillsUi
		{
			internal enum Enum6
			{
				None
			}

			private static EventHandler<AtlasPassiveDumpEventArgs> eventHandler_0;

			private static AtlasSkillsUi atlasSkillsUi_0;

			public static Dictionary<int, long> Dictionary_AtlasPassive => null;

			public static long IntPtr_TreeMap => 0L;

			public static bool IsOpened => true;

			public static bool IsApplyEnabled => true;

			public static bool IsApplyVisible => true;

			public static bool IsCancelEnabled => true;

			public static bool IsCancelVisible => true;

			public static event EventHandler<AtlasPassiveDumpEventArgs> OnPassiveDump
			{
				add
				{
				}
				remove
				{
				}
			}

			[SpecialName]
			private static long smethod_0()
			{
				return 0L;
			}

			public static bool CanBeAllocate(int id)
			{
				return true;
			}

			public static ChoosePassiveError ChoosePassive(int id)
			{
				return (ChoosePassiveError)(object)null;
			}

			public static ChoosePassiveError ChoosePassiveMastery(int id, int acceptedMasteryId)
			{
				return (ChoosePassiveError)(object)null;
			}

			public static PassiveAllocationActionError ConfirmOperation()
			{
				return (PassiveAllocationActionError)(object)null;
			}

			public static bool IsAllocated(int id)
			{
				return true;
			}

			internal static Enum6 smethod_1(long long_0, int int_0)
			{
				return (Enum6)(object)null;
			}

			internal static void smethod_2(DatPassiveSkillWrapper datPassiveSkillWrapper_0)
			{
			}

			internal static DatPassiveSkillWrapper smethod_3(long long_0)
			{
				return null;
			}

			internal static bool smethod_4(long long_0)
			{
				return true;
			}

			internal static bool smethod_5(long long_0)
			{
				return true;
			}

			internal static bool smethod_6(long long_0)
			{
				return true;
			}

			private static DreamPoeBot.Common.Vector2 smethod_7(long long_0)
			{
				return (DreamPoeBot.Common.Vector2)(object)null;
			}

			internal static bool smethod_8()
			{
				return true;
			}

			internal static AtlasSkillsUi smethod_9()
			{
				return null;
			}

			static AtlasSkillsUi()
			{
				Class200.smethod_34();
			}
		}

		public static class AtlasUi
		{
			public static class BookmarksPanel
			{
				public class Bookmark
				{
					private Class50 class50_0;

					private static Bookmark bookmark_0;

					public string Name => null;

					public Vector2i AtlasNodeCoordinate => (Vector2i)(object)null;

					public void Navigate()
					{
					}

					public void Remove()
					{
					}

					internal Bookmark(Class50 bookmarkElement)
					{
					}

					internal static bool smethod_0()
					{
						return true;
					}

					internal static Bookmark smethod_1()
					{
						return null;
					}

					static Bookmark()
					{
						Class200.smethod_34();
					}
				}

				private static BookmarksPanel bookmarksPanel_0;

				public static bool IsOpened => true;

				public static List<Bookmark> Bookmarks => null;

				public static void Open()
				{
				}

				public static void Close()
				{
				}

				internal static bool smethod_0()
				{
					return true;
				}

				internal static BookmarksPanel smethod_1()
				{
					return null;
				}

				static BookmarksPanel()
				{
					Class200.smethod_34();
				}
			}

			public enum OpenNodeInventoryResult
			{
				None,
				NodeCanNotBeUsed,
				NodeNotInFieldOfView,
				AtlasMapDeviceElementNull,
				AtlasMapDeviceElementNotVisible,
				AtlasNotOpen,
				NodeElementIsNull
			}

			public enum BookmarkResult
			{
				None,
				NodeAlreadyBookmarked,
				FailedToFindNode,
				const_3,
				FailedToOpenBookmarkEditor
			}

			public static class AtlasMapDeviceUi
			{
				public enum TraverseResult
				{
					None,
					AtlasMapDeviceUiNull,
					TraverseButtonIsNull,
					TraverseButtonIsNotEnabled,
					AtlasMapDeviceNotVisible
				}

				private static AtlasMapDeviceUi atlasMapDeviceUi_0;

				public static bool IsOpened => true;

				public static string MapName => null;

				public static string Biome => null;

				public static string Stats => null;

				[Obsolete("Obsolete, use WaystoneSlot, TabletSlot1, TabletSlot2, TabletSlot3", false)]
				public static InventoryControlWrapper InventoryControl => null;

				public static InventoryControlWrapper Waystone_InventoryControl => null;

				public static InventoryControlWrapper TabletSlot1_InventoryControl => null;

				public static bool IsTableSlot1Enabled => true;

				public static InventoryControlWrapper TabletSlot2_InventoryControl => null;

				public static bool IsTableSlot2Enabled => true;

				public static InventoryControlWrapper TabletSlot3_InventoryControl => null;

				public static bool IsTableSlot3Enabled => true;

				public static InventoryControlWrapper TabletSlot4_InventoryControl => null;

				public static bool IsTableSlot4Enabled => true;

				public static bool IsTierSelectorVisible => true;

				public static int SelectedTier => 0;

				public static bool SelectTier(int tier)
				{
					return true;
				}

				public static TraverseResult Traverse()
				{
					return (TraverseResult)(object)null;
				}

				internal static bool smethod_0()
				{
					return true;
				}

				internal static AtlasMapDeviceUi smethod_1()
				{
					return null;
				}

				static AtlasMapDeviceUi()
				{
					Class200.smethod_34();
				}
			}

			internal static Vector2i vector2i_0;

			internal static AtlasUi atlasUi_0;

			public static bool IsOpened => true;

			public static bool IsMapLoaded => true;

			public static List<AtlasPanel2.AtlasNode> AtlasNodes => null;

			public static List<AtlasPanel2.AtlasSpecialNode> AtlasEndgameContentIcons => null;

			public static List<AtlasPanel2.AtlasTowerNode> AtlasTowerNodes => null;

			public static List<AtlasPanel2.AtlasSpecialNode> AtlasIslandsNodes => null;

			public static List<AtlasPanel2.AtlasNode> UsableAtlasNodes => null;

			public static List<AtlasPanel2.AtlasNode> CompletedAtlasNodes => null;

			public static List<AtlasEffectSource> LostTowerEffectSources => null;

			public static AtlasPanel2.AtlasNode CurrentAtlasNode => null;

			public static Vector2i CurrenctAtlasNodeCoordinates => (Vector2i)(object)null;

			internal static long Address => 0L;

			public static bool TryGetRiteOfTheNamelessTree(out IReadOnlyList<RiteOfTheNamelessNode> tree)
			{
				return true;
			}

			public static OpenNodeInventoryResult OpenNodeInventory(AtlasPanel2.AtlasNode node)
			{
				return (OpenNodeInventoryResult)(object)null;
			}

			public static bool MoveToNode(AtlasPanel2.AtlasNode node, int timeout = 5000)
			{
				return true;
			}

			internal static bool smethod_0(Vector2i vector2i_1, int int_0 = 5000)
			{
				return true;
			}

			public static bool MoveToNode(Vector2i coordinates, int timeout = 5000)
			{
				return true;
			}

			public static BookmarkResult BookmarkNode(Vector2i coordinate, string name)
			{
				return (BookmarkResult)(object)null;
			}

			public static TakeWaypointResult TakeWaypoint(WorldUi.EndGameRightWaypointType waypointType)
			{
				return (TakeWaypointResult)(object)null;
			}

			public static TakeWaypointResult TakeWaypoint(WorldUi.EndGameRightWaypointType waypointType, bool bool_0)
			{
				return (TakeWaypointResult)(object)null;
			}

			private static void smethod_1()
			{
			}

			private static void smethod_2(bool bool_0)
			{
			}

			private static void smethod_3(bool bool_0)
			{
			}

			private static void nSypfMujhHN(bool bool_0)
			{
			}

			[Obsolete("Not in game anymore", false)]
			private static void smethod_4()
			{
			}

			[Obsolete("Not in game anymore", false)]
			private static void smethod_5()
			{
			}

			private static void smethod_6(Element element_0)
			{
			}

			private static OpenNodeInventoryResult smethod_7(AtlasPanelNode atlasPanelNode_0)
			{
				return (OpenNodeInventoryResult)(object)null;
			}

			static AtlasUi()
			{
				Class200.smethod_34();
				Class204.smethod_0();
				vector2i_0 = new Vector2i(16, 16);
			}

			internal static bool smethod_8()
			{
				return true;
			}

			internal static AtlasUi smethod_9()
			{
				return null;
			}
		}

		public static class CheckPointUi
		{
			public sealed class Checkpoint
			{
				[CompilerGenerated]
				private readonly int int_0;

				[CompilerGenerated]
				private readonly Vector2i vector2i_0;

				[CompilerGenerated]
				private readonly bool bool_0;

				[CompilerGenerated]
				private readonly long long_0;

				internal static Checkpoint checkpoint_0;

				public int Id
				{
					[CompilerGenerated]
					get
					{
						return 0;
					}
				}

				public Vector2i Position
				{
					[CompilerGenerated]
					get
					{
						return (Vector2i)(object)null;
					}
				}

				public bool IsCurrent
				{
					[CompilerGenerated]
					get
					{
						return true;
					}
				}

				internal long Address
				{
					[CompilerGenerated]
					get
					{
						return 0L;
					}
				}

				internal Checkpoint(int id, Vector2i position, bool current, long address)
				{
				}

				internal static bool smethod_0()
				{
					return true;
				}

				internal static Checkpoint smethod_1()
				{
					return null;
				}

				static Checkpoint()
				{
					Class200.smethod_34();
				}
			}

			public enum TakeCheckpointResult
			{
				None,
				PanelClosed,
				CheckpointNotFound,
				AlreadyHere,
				NativeUnavailable,
				CheckpointChanged,
				Pending,
				InvalidLayout,
				Failed
			}

			internal static CheckPointUi checkPointUi_0;

			public static IReadOnlyList<Checkpoint> Checkpoints => null;

			public static bool IsOpened => true;

			[SpecialName]
			private static Element smethod_0()
			{
				return null;
			}

			public static TakeCheckpointResult TakeCheckpoint(int checkpointId)
			{
				return (TakeCheckpointResult)(object)null;
			}

			internal static TakeCheckpointResult smethod_1(Class78 class78_0)
			{
				return (TakeCheckpointResult)(object)null;
			}

			internal static IReadOnlyList<Checkpoint> smethod_2(Element element_0, Memory memory_0)
			{
				return null;
			}

			[CompilerGenerated]
			internal static long smethod_3(byte[] byte_0, int int_0 = 0)
			{
				return 0L;
			}

			internal static bool smethod_4()
			{
				return true;
			}

			internal static CheckPointUi smethod_5()
			{
				return null;
			}

			static CheckPointUi()
			{
				Class200.smethod_34();
			}
		}

		public static class CurrencyExchangeUi
		{
			public enum OrderStatus
			{
				Listed,
				Completed,
				Cancelled,
				Unknown
			}

			public enum SelectCurrencyError
			{
				None,
				CurrencySelectionPannelNotOpen,
				UnableToFindCurrency,
				FailedToSetTheCurrency,
				UiNotOpen
			}

			public enum SetQuantityError
			{
				None,
				CurrencySelectionPannelIsOpen,
				UiNotOpen
			}

			public class MarketRatio
			{
				[CompilerGenerated]
				private decimal decimal_0;

				[CompilerGenerated]
				private decimal decimal_1;

				[CompilerGenerated]
				private int int_0;

				[CompilerGenerated]
				private bool bool_0;

				internal static MarketRatio marketRatio_0;

				public decimal IWant
				{
					[CompilerGenerated]
					get
					{
						return (decimal)(object)null;
					}
					[CompilerGenerated]
					private set
					{
					}
				}

				public decimal IHave
				{
					[CompilerGenerated]
					get
					{
						return (decimal)(object)null;
					}
					[CompilerGenerated]
					private set
					{
					}
				}

				public int Stock
				{
					[CompilerGenerated]
					get
					{
						return 0;
					}
					[CompilerGenerated]
					private set
					{
					}
				}

				public bool IsConsolidatedStock
				{
					[CompilerGenerated]
					get
					{
						return true;
					}
					[CompilerGenerated]
					private set
					{
					}
				}

				internal MarketRatio(decimal iWant, decimal iHave, int stock, bool isConsolidatedStock)
				{
				}

				internal static bool smethod_0()
				{
					return true;
				}

				internal static MarketRatio smethod_1()
				{
					return null;
				}

				static MarketRatio()
				{
					Class200.smethod_34();
				}
			}

			public class CurrencyEntry
			{
				private readonly Element element_0;

				[CompilerGenerated]
				private string nyopLiDusHD;

				[CompilerGenerated]
				private readonly string string_0;

				internal static CurrencyEntry currencyEntry_0;

				public string Category
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

				public string Name
				{
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				public int OwnedQuantity => 0;

				public bool IsVisible => true;

				public Vector2i ClickPosition => (Vector2i)(object)null;

				internal CurrencyEntry(Element element, string category)
				{
				}

				internal static bool smethod_0()
				{
					return true;
				}

				internal static CurrencyEntry smethod_1()
				{
					return null;
				}

				static CurrencyEntry()
				{
					Class200.smethod_34();
				}
			}

			public class Order
			{
				public readonly Element _element;

				private string string_0;

				private string string_1;

				private static Order order_0;

				public OrderStatus OrderStatus => (OrderStatus)(object)null;

				public string BuyingName => null;

				public string SellingName => null;

				public int BuyingQuantity => 0;

				public int SellingQuantity => 0;

				public MarketRatio CheapestCompetingOrder => null;

				public MarketRatio MyOrderRatio => null;

				internal Order(Element element)
				{
				}

				public void CancelOrder()
				{
				}

				public void FillPairFromOrder()
				{
				}

				public void RetrieveBuyingCurrency(bool retrieveAll)
				{
				}

				public void RetrieveSellingCurrency(bool retrieveAll)
				{
				}

				internal static bool smethod_0()
				{
					return true;
				}

				internal static Order smethod_1()
				{
					return null;
				}

				static Order()
				{
					Class200.smethod_34();
				}
			}

			internal static CurrencyExchangeUi currencyExchangeUi_0;

			public static bool IsOpened => true;

			public static bool IsCurrencySelectionPanelOpen => true;

			public static List<CurrencyEntry> CurrencyEntryList => null;

			public static string SelectedCurrencyIWant => null;

			public static string SelectedCurrencyIHave => null;

			public static int SelectedQuantityIWant => 0;

			public static int SelectedQuantityIHave => 0;

			public static List<MarketRatio> MarketRatios => null;

			public static List<Order> Orders => null;

			[SpecialName]
			private static string smethod_0()
			{
				return null;
			}

			public static bool LockAndPlaceOrder()
			{
				return true;
			}

			public static bool LockOrder()
			{
				return true;
			}

			public static SelectCurrencyError smethod_1(string name)
			{
				return (SelectCurrencyError)(object)null;
			}

			public static SelectCurrencyError smethod_2(string name)
			{
				return (SelectCurrencyError)(object)null;
			}

			public static SetQuantityError SetQuantityIHave(int quantity)
			{
				return (SetQuantityError)(object)null;
			}

			public static SetQuantityError SetQuantityIWant(int quantity)
			{
				return (SetQuantityError)(object)null;
			}

			public static SetQuantityError smethod_3()
			{
				return (SetQuantityError)(object)null;
			}

			public static SetQuantityError smethod_4()
			{
				return (SetQuantityError)(object)null;
			}

			public static void SwapCurrencies()
			{
			}

			public static SetQuantityError ResetQuantity(bool isIWant)
			{
				return (SetQuantityError)(object)null;
			}

			private static SelectCurrencyError smethod_5(string string_0, bool bool_0)
			{
				return (SelectCurrencyError)(object)null;
			}

			private static SetQuantityError smethod_6(int int_0, bool bool_0)
			{
				return (SetQuantityError)(object)null;
			}

			private static void smethod_7(int int_0)
			{
			}

			private static void smethod_8(string string_0)
			{
			}

			private static bool smethod_9(string string_0, NumberStyles numberStyles_0, IFormatProvider iformatProvider_0, out decimal decimal_0)
			{
				return true;
			}

			private static bool smethod_10(string string_0, NumberStyles numberStyles_0, IFormatProvider iformatProvider_0, out int int_0)
			{
				return true;
			}

			internal static bool smethod_11()
			{
				return true;
			}

			internal static CurrencyExchangeUi smethod_12()
			{
				return null;
			}

			static CurrencyExchangeUi()
			{
				Class200.smethod_34();
			}
		}

		public static class DeliriumUi
		{
			private static DeliriumUi deliriumUi_0;

			public static bool IsDeliriumActive => true;

			public static FinishDeliriumEncounterResult FinishDelirium()
			{
				return (FinishDeliriumEncounterResult)(object)null;
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static DeliriumUi smethod_1()
			{
				return null;
			}

			static DeliriumUi()
			{
				Class200.smethod_34();
			}
		}

		public static class DisenchantUi
		{
			private static readonly TradeControlWrapper tradeControlWrapper_0;

			internal static DisenchantUi disenchantUi_0;

			public static bool IsOpened => true;

			public static TradeControlWrapper TradeControl => null;

			static DisenchantUi()
			{
				Class200.smethod_34();
				Class204.smethod_0();
				tradeControlWrapper_0 = new TradeControlWrapper(0L, TradeControlType.Disenchant);
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static DisenchantUi smethod_1()
			{
				return null;
			}
		}

		public static class DisplayNoteUi
		{
			private static DisplayNoteUi displayNoteUi_0;

			public static bool IsOpened => true;

			public static string Note
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public static ItemPriceTypeEnum SelectedPriceType => (ItemPriceTypeEnum)(object)null;

			public static PriceCurrencyEnum SelectedPriceCurrency => (PriceCurrencyEnum)(object)null;

			public static string GetPriceCurrencyQuantity => null;

			public static bool Accept()
			{
				return true;
			}

			public static bool Cancel()
			{
				return true;
			}

			public static bool SelectPriceCurrency(PriceCurrencyEnum priceType)
			{
				return true;
			}

			public static bool SelectPriceType(ItemPriceTypeEnum priceType)
			{
				return true;
			}

			public static bool SetPriceCurrencyQuantity(string quantity)
			{
				return true;
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static DisplayNoteUi smethod_1()
			{
				return null;
			}

			static DisplayNoteUi()
			{
				Class200.smethod_34();
			}
		}

		public static class EncounterDisplayUi
		{
			public static class BreachEncounterUi
			{
				internal static BreachEncounterUi breachEncounterUi_0;

				public static bool IsOpened => true;

				public static int ChargeLevelPct => 0;

				public static int ExaustionLevelPct => 0;

				public static int DefenceLevelPct => 0;

				public static string Waves => null;

				public static bool BreachComleteTextVisible => true;

				public static string BreachComleteText => null;

				internal static bool smethod_0()
				{
					return true;
				}

				internal static BreachEncounterUi smethod_1()
				{
					return null;
				}

				static BreachEncounterUi()
				{
					Class200.smethod_34();
				}
			}

			public static class DeliriumEncounterUi
			{
				public class DeliriumSpecialEvent
				{
					private long long_0;

					internal static DeliriumSpecialEvent deliriumSpecialEvent_0;

					public string Type => null;

					public bool Unlocked => true;

					internal DeliriumSpecialEvent(long address)
					{
					}

					internal static bool smethod_0()
					{
						return true;
					}

					internal static DeliriumSpecialEvent smethod_1()
					{
						return null;
					}

					static DeliriumSpecialEvent()
					{
						Class200.smethod_34();
					}
				}

				[StructLayout(LayoutKind.Explicit)]
				public struct DeliriumSpecialEventStructure
				{
					[FieldOffset(0)]
					public int Progress;

					[FieldOffset(4)]
					public int RewardType;

					[FieldOffset(8)]
					public int Threshold;

					[FieldOffset(12)]
					public int Reached;
				}

				private static DeliriumEncounterUi deliriumEncounterUi_0;

				public static bool IsOpened => true;

				public static List<DeliriumSpecialEvent> DeliriumEncounterEvents => null;

				internal static bool smethod_0()
				{
					return true;
				}

				internal static DeliriumEncounterUi smethod_1()
				{
					return null;
				}

				static DeliriumEncounterUi()
				{
					Class200.smethod_34();
				}
			}

			static EncounterDisplayUi()
			{
				Class200.smethod_34();
			}
		}

		public static class ExplosivePlacementUi
		{
			internal static ExplosivePlacementUi explosivePlacementUi_0;

			public static bool IsOpened => true;

			public static bool IsEnabled => true;

			public static bool IsPlacementActive => true;

			public static int ExplosiveRemaining => 0;

			public static bool IsUndoAvaiable => true;

			public static string ReadModifiers()
			{
				return null;
			}

			public static bool TogglePlacement()
			{
				return true;
			}

			public static bool Undo()
			{
				return true;
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static ExplosivePlacementUi smethod_1()
			{
				return null;
			}

			static ExplosivePlacementUi()
			{
				Class200.smethod_34();
			}
		}

		public static class Gemcutting
		{
			internal static class Class64
			{
				internal static Class64 class64_0;

				internal static string smethod_0(Element element_0)
				{
					return null;
				}

				internal static void smethod_1(Element element_0, string string_0)
				{
				}

				internal static bool smethod_2()
				{
					return true;
				}

				internal static Class64 smethod_3()
				{
					return null;
				}

				static Class64()
				{
					Class200.smethod_34();
				}
			}

			public class SkillCategory
			{
				private Element element_0;

				private readonly Func<Element> func_0;

				private readonly long long_0;

				[CompilerGenerated]
				private string string_0;

				internal static SkillCategory skillCategory_0;

				public string Name
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

				internal SkillCategory(Element element, string name, Func<Element> scrollAreaGetter = null)
				{
				}

				public void Select()
				{
				}

				internal static bool smethod_0()
				{
					return true;
				}

				internal static SkillCategory smethod_1()
				{
					return null;
				}

				static SkillCategory()
				{
					Class200.smethod_34();
				}
			}

			public class SkillUpgrade
			{
				public enum EngraveOrUpgradeResult
				{
					None,
					FailedToSetSearchText,
					SkillButtonNotFound,
					CaNotEngraveUpgrade,
					RootGetterNotFound
				}

				private readonly Func<Element> func_0;

				[CompilerGenerated]
				private Element element_0;

				private string string_0;

				private int int_0;

				private static SkillUpgrade skillUpgrade_0;

				public string Name => null;

				public int Level => 0;

				public bool IsVisible => true;

				public bool CanEngraveOrUpgrade => true;

				public EngraveOrUpgradeResult EngraveOrUpgrade()
				{
					return (EngraveOrUpgradeResult)(object)null;
				}

				[SpecialName]
				[CompilerGenerated]
				private Element method_0()
				{
					return null;
				}

				[SpecialName]
				[CompilerGenerated]
				private void method_1(Element element_1)
				{
				}

				private void method_2()
				{
				}

				internal SkillUpgrade(Element element, Func<Element> rootGetter)
				{
				}

				internal static bool smethod_0()
				{
					return true;
				}

				internal static SkillUpgrade smethod_1()
				{
					return null;
				}

				static SkillUpgrade()
				{
					Class200.smethod_34();
				}
			}

			public static class SkillGemcuttingUi
			{
				internal static SkillGemcuttingUi skillGemcuttingUi_0;

				public static bool IsOpened => true;

				public static List<SkillUpgrade> Skills => null;

				public static List<SkillCategory> Category => null;

				[SpecialName]
				internal static string smethod_0()
				{
					return null;
				}

				[SpecialName]
				internal static void smethod_1(string string_0)
				{
				}

				internal static bool smethod_2()
				{
					return true;
				}

				internal static SkillGemcuttingUi smethod_3()
				{
					return null;
				}

				static SkillGemcuttingUi()
				{
					Class200.smethod_34();
				}
			}

			public static class SpiritGemcuttingUi
			{
				internal static SpiritGemcuttingUi spiritGemcuttingUi_0;

				public static bool IsOpened => true;

				public static List<SkillUpgrade> Skills => null;

				public static List<SkillCategory> Category => null;

				[SpecialName]
				internal static string smethod_0()
				{
					return null;
				}

				[SpecialName]
				internal static void smethod_1(string string_0)
				{
				}

				internal static bool smethod_2()
				{
					return true;
				}

				internal static SpiritGemcuttingUi smethod_3()
				{
					return null;
				}

				static SpiritGemcuttingUi()
				{
					Class200.smethod_34();
				}
			}

			public static class SupportGemcuttingUi
			{
				internal static SupportGemcuttingUi supportGemcuttingUi_0;

				public static bool IsOpened => true;

				public static List<SkillCategory> Filters => null;

				public static List<SkillUpgrade> Skills => null;

				public static List<SkillCategory> Category => null;

				[SpecialName]
				internal static string smethod_0()
				{
					return null;
				}

				[SpecialName]
				internal static void smethod_1(string string_0)
				{
				}

				internal static bool smethod_2()
				{
					return true;
				}

				internal static SupportGemcuttingUi smethod_3()
				{
					return null;
				}

				static SupportGemcuttingUi()
				{
					Class200.smethod_34();
				}
			}

			static Gemcutting()
			{
				Class200.smethod_34();
			}
		}

		public static class GuildStashUi
		{
			public static class CurrencyTab
			{
				[CompilerGenerated]
				private sealed class _003Cget_NonCurrency_003Ed__13 : IEnumerable<InventoryControlWrapper>, IEnumerable, IEnumerator<InventoryControlWrapper>, IEnumerator, IDisposable
				{
					private int _003C_003E1__state;

					private InventoryControlWrapper _003C_003E2__current;

					private int _003C_003El__initialThreadId;

					private static _003Cget_NonCurrency_003Ed__13 _003Cget_NonCurrency_003Ed__13_0;

					InventoryControlWrapper IEnumerator<InventoryControlWrapper>.Current => null;

					object IEnumerator.Current => null;

					public _003Cget_NonCurrency_003Ed__13(int _003C_003E1__state)
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

					void IEnumerator.Reset()
					{
					}

					IEnumerator<InventoryControlWrapper> IEnumerable<InventoryControlWrapper>.GetEnumerator()
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

					internal static _003Cget_NonCurrency_003Ed__13 smethod_1()
					{
						return null;
					}

					static _003Cget_NonCurrency_003Ed__13()
					{
						Class200.smethod_34();
					}
				}

				[CompilerGenerated]
				private sealed class _003Cget_OnlyCurrency_003Ed__9 : IEnumerable<InventoryControlWrapper>, IEnumerable, IEnumerator<InventoryControlWrapper>, IEnumerator, IDisposable
				{
					private int _003C_003E1__state;

					private InventoryControlWrapper _003C_003E2__current;

					private int _003C_003El__initialThreadId;

					private Dictionary<string, DreamPoeBot.Loki.FilesInMemory.CurrencyStashTabLayouts.CurrencyStashTabLayoutHardcoded>.ValueCollection.Enumerator _003C_003E7__wrap1;

					internal static _003Cget_OnlyCurrency_003Ed__9 _003Cget_OnlyCurrency_003Ed__9_0;

					InventoryControlWrapper IEnumerator<InventoryControlWrapper>.Current => null;

					object IEnumerator.Current => null;

					public _003Cget_OnlyCurrency_003Ed__9(int _003C_003E1__state)
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

					IEnumerator<InventoryControlWrapper> IEnumerable<InventoryControlWrapper>.GetEnumerator()
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

					internal static _003Cget_OnlyCurrency_003Ed__9 smethod_1()
					{
						return null;
					}

					static _003Cget_OnlyCurrency_003Ed__9()
					{
						Class200.smethod_34();
					}
				}

				internal static Dictionary<string, Func<InventoryControlWrapper>> dictionary_0;

				private static Dictionary<string, Func<InventoryControlWrapper>> dictionary_1;

				private static Dictionary<string, Func<InventoryControlWrapper>> dictionary_2;

				private static CurrencyTab currencyTab_0;

				public static IEnumerable<InventoryControlWrapper> OnlyCurrency
				{
					[IteratorStateMachine(typeof(_003Cget_OnlyCurrency_003Ed__9))]
					get
					{
						return null;
					}
				}

				public static IEnumerable<InventoryControlWrapper> All => null;

				public static IEnumerable<InventoryControlWrapper> NonCurrency
				{
					[IteratorStateMachine(typeof(_003Cget_NonCurrency_003Ed__13))]
					get
					{
						return null;
					}
				}

				public static InventoryControlWrapper OrbOfTransmutation => null;

				public static InventoryControlWrapper GreaterOrbOfTransmutation => null;

				public static InventoryControlWrapper PerfectOrbOfTransmutation => null;

				public static InventoryControlWrapper OrbOfAugmentation => null;

				public static InventoryControlWrapper GreaterOrbOfAugmentation => null;

				public static InventoryControlWrapper PerfectOrbOfAugmentation => null;

				public static InventoryControlWrapper OrbOfAlchemy => null;

				public static InventoryControlWrapper RegalOrb => null;

				public static InventoryControlWrapper GreaterRegalOrb => null;

				public static InventoryControlWrapper PerfectRegalOrb => null;

				public static InventoryControlWrapper ChaosOrb => null;

				public static InventoryControlWrapper GreaterChaosOrb => null;

				public static InventoryControlWrapper PerfectChaosOrb => null;

				public static InventoryControlWrapper ExaltedOrb => null;

				public static InventoryControlWrapper GreaterExaltedOrb => null;

				public static InventoryControlWrapper PerfectExaltedOrb => null;

				public static InventoryControlWrapper VaalOrb => null;

				public static InventoryControlWrapper DivineOrb => null;

				public static InventoryControlWrapper HinekorasLock => null;

				public static InventoryControlWrapper OrbOfAnnulment => null;

				public static InventoryControlWrapper OrbOfChance => null;

				public static InventoryControlWrapper MirrorOfKalandra => null;

				public static InventoryControlWrapper ArcanistsEtcher => null;

				public static InventoryControlWrapper ArmourersScrap => null;

				public static InventoryControlWrapper BlacksmithsWhetstone => null;

				public static InventoryControlWrapper LesserJewellersOrb => null;

				public static InventoryControlWrapper GreaterJewellersOrb => null;

				public static InventoryControlWrapper PerfectJewellersOrb => null;

				public static InventoryControlWrapper ArtificersOrb => null;

				public static InventoryControlWrapper ScrollOfWisdom => null;

				public static InventoryControlWrapper GemcuttersPrism => null;

				public static InventoryControlWrapper GlassblowersBauble => null;

				public static InventoryControlWrapper ArtificersShard => null;

				public static InventoryControlWrapper TransmutationShard => null;

				public static InventoryControlWrapper RegalShard => null;

				public static InventoryControlWrapper ChanceShard => null;

				public static InventoryControlWrapper FracturingOrb => null;

				public static InventoryControlWrapper CraftingSlot => null;

				public static InventoryControlWrapper Generic1 => null;

				public static InventoryControlWrapper Generic2 => null;

				public static InventoryControlWrapper Generic3 => null;

				public static InventoryControlWrapper Generic4 => null;

				public static InventoryControlWrapper Generic5 => null;

				public static InventoryControlWrapper Generic6 => null;

				public static InventoryControlWrapper Generic7 => null;

				public static InventoryControlWrapper Generic8 => null;

				public static InventoryControlWrapper Generic9 => null;

				public static InventoryControlWrapper Generic10 => null;

				public static InventoryControlWrapper Generic11 => null;

				public static InventoryControlWrapper Generic12 => null;

				public static InventoryControlWrapper Generic13 => null;

				public static InventoryControlWrapper Generic14 => null;

				private static void smethod_0()
				{
				}

				private static InventoryControlWrapper smethod_1(string string_0, bool bool_0 = false)
				{
					return null;
				}

				private static void Load()
				{
				}

				public static InventoryControlWrapper GetByName(string name)
				{
					return null;
				}

				public static InventoryControlWrapper GetByMetadata(string metadata)
				{
					return null;
				}

				[Obsolete("Use GetByMetadata.", false)]
				public static InventoryControlWrapper GetInventoryControlForMetadata(string metadata)
				{
					return null;
				}

				internal static bool smethod_2()
				{
					return true;
				}

				internal static CurrencyTab smethod_3()
				{
					return null;
				}

				static CurrencyTab()
				{
					Class200.smethod_34();
				}
			}

			public static class EssenceTab
			{
				[CompilerGenerated]
				private sealed class _003Cget_NonEssences_003Ed__11 : IEnumerable<InventoryControlWrapper>, IEnumerable, IEnumerator<InventoryControlWrapper>, IEnumerator, IDisposable
				{
					private int _003C_003E1__state;

					private InventoryControlWrapper _003C_003E2__current;

					private int _003C_003El__initialThreadId;

					private static _003Cget_NonEssences_003Ed__11 _003Cget_NonEssences_003Ed__11_0;

					InventoryControlWrapper IEnumerator<InventoryControlWrapper>.Current => null;

					object IEnumerator.Current => null;

					public _003Cget_NonEssences_003Ed__11(int _003C_003E1__state)
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

					void IEnumerator.Reset()
					{
					}

					IEnumerator<InventoryControlWrapper> IEnumerable<InventoryControlWrapper>.GetEnumerator()
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

					internal static _003Cget_NonEssences_003Ed__11 smethod_1()
					{
						return null;
					}

					static _003Cget_NonEssences_003Ed__11()
					{
						Class200.smethod_34();
					}
				}

				[CompilerGenerated]
				private sealed class _003Cget_OnlyEssences_003Ed__9 : IEnumerable<InventoryControlWrapper>, IEnumerable, IEnumerator<InventoryControlWrapper>, IEnumerator, IDisposable
				{
					private int _003C_003E1__state;

					private InventoryControlWrapper _003C_003E2__current;

					private int _003C_003El__initialThreadId;

					private Dictionary<string, DreamPoeBot.Loki.FilesInMemory.EssenceStashTabLayouts.EssenceStashTabLayoutHardcoded>.ValueCollection.Enumerator _003C_003E7__wrap1;

					private static _003Cget_OnlyEssences_003Ed__9 _003Cget_OnlyEssences_003Ed__9_0;

					InventoryControlWrapper IEnumerator<InventoryControlWrapper>.Current => null;

					object IEnumerator.Current => null;

					public _003Cget_OnlyEssences_003Ed__9(int _003C_003E1__state)
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

					IEnumerator<InventoryControlWrapper> IEnumerable<InventoryControlWrapper>.GetEnumerator()
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

					internal static _003Cget_OnlyEssences_003Ed__9 smethod_1()
					{
						return null;
					}

					static _003Cget_OnlyEssences_003Ed__9()
					{
						Class200.smethod_34();
					}
				}

				private static Dictionary<string, Func<InventoryControlWrapper>> dictionary_0;

				private static Dictionary<string, Func<InventoryControlWrapper>> dictionary_1;

				private static EssenceTab essenceTab_0;

				public static IEnumerable<InventoryControlWrapper> All => null;

				public static IEnumerable<InventoryControlWrapper> OnlyEssences
				{
					[IteratorStateMachine(typeof(_003Cget_OnlyEssences_003Ed__9))]
					get
					{
						return null;
					}
				}

				public static IEnumerable<InventoryControlWrapper> NonEssences
				{
					[IteratorStateMachine(typeof(_003Cget_NonEssences_003Ed__11))]
					get
					{
						return null;
					}
				}

				public static InventoryControlWrapper EssenceOfTheBody => null;

				public static InventoryControlWrapper EssenceOfTheMind => null;

				public static InventoryControlWrapper EssenceOfEnhancement => null;

				public static InventoryControlWrapper EssenceOfTorment => null;

				public static InventoryControlWrapper EssenceOfFlames => null;

				public static InventoryControlWrapper EssenceOfIce => null;

				public static InventoryControlWrapper EssenceOfElectricity => null;

				public static InventoryControlWrapper EssenceOfRuin => null;

				public static InventoryControlWrapper EssenceOfBattle => null;

				public static InventoryControlWrapper EssenceOfSorcery => null;

				public static InventoryControlWrapper EssenceOfHaste => null;

				public static InventoryControlWrapper EssenceOfInfinite => null;

				public static InventoryControlWrapper GreaterEssenceOfTheBody => null;

				public static InventoryControlWrapper GreaterEssenceOfTheMind => null;

				public static InventoryControlWrapper GreaterEssenceOfEnhancement => null;

				public static InventoryControlWrapper GreaterEssenceOfTorment => null;

				public static InventoryControlWrapper GreaterEssenceOfFlames => null;

				public static InventoryControlWrapper GreaterEssenceOfIce => null;

				public static InventoryControlWrapper GreaterEssenceOfElectricity => null;

				public static InventoryControlWrapper GreaterEssenceOfRuin => null;

				public static InventoryControlWrapper GreaterEssenceOfBattle => null;

				public static InventoryControlWrapper GreaterEssenceOfSorcery => null;

				public static InventoryControlWrapper GreaterEssenceOfHaste => null;

				public static InventoryControlWrapper GreaterEssenceOfInfinite => null;

				public static InventoryControlWrapper Generic1 => null;

				public static InventoryControlWrapper Generic2 => null;

				public static InventoryControlWrapper Generic3 => null;

				public static InventoryControlWrapper Generic4 => null;

				public static InventoryControlWrapper CraftingSlot => null;

				private static InventoryControlWrapper smethod_0(string string_0)
				{
					return null;
				}

				private static void Load()
				{
				}

				public static InventoryControlWrapper GetByName(string name)
				{
					return null;
				}

				public static InventoryControlWrapper GetByMetadata(string metadata)
				{
					return null;
				}

				public static InventoryControlWrapper GetInventoryControlForMetadata(string metadata)
				{
					return null;
				}

				internal static bool smethod_1()
				{
					return true;
				}

				internal static EssenceTab smethod_2()
				{
					return null;
				}

				static EssenceTab()
				{
					Class200.smethod_34();
				}
			}

			public static class DeliriumTab
			{
				[CompilerGenerated]
				private sealed class _003Cget_AllCurrency_003Ed__9 : IEnumerable<InventoryControlWrapper>, IEnumerable, IEnumerator<InventoryControlWrapper>, IEnumerator, IDisposable
				{
					private int _003C_003E1__state;

					private InventoryControlWrapper _003C_003E2__current;

					private int _003C_003El__initialThreadId;

					private Dictionary<string, DreamPoeBot.Loki.FilesInMemory.DeliriumStashTabLayouts.DeliriumStashTabLayoutHardcoded>.ValueCollection.Enumerator _003C_003E7__wrap1;

					internal static _003Cget_AllCurrency_003Ed__9 _003Cget_AllCurrency_003Ed__9_0;

					InventoryControlWrapper IEnumerator<InventoryControlWrapper>.Current => null;

					object IEnumerator.Current => null;

					public _003Cget_AllCurrency_003Ed__9(int _003C_003E1__state)
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

					IEnumerator<InventoryControlWrapper> IEnumerable<InventoryControlWrapper>.GetEnumerator()
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

					internal static _003Cget_AllCurrency_003Ed__9 smethod_1()
					{
						return null;
					}

					static _003Cget_AllCurrency_003Ed__9()
					{
						Class200.smethod_34();
					}
				}

				private static Dictionary<string, Func<InventoryControlWrapper>> dictionary_0;

				private static Dictionary<string, Func<InventoryControlWrapper>> dictionary_1;

				internal static DeliriumTab deliriumTab_0;

				public static IEnumerable<InventoryControlWrapper> All => null;

				public static IEnumerable<InventoryControlWrapper> AllCurrency
				{
					[IteratorStateMachine(typeof(_003Cget_AllCurrency_003Ed__9))]
					get
					{
						return null;
					}
				}

				[Obsolete("Not in POE2", false)]
				public static List<InventoryControlWrapper> Maps => null;

				public static InventoryControlWrapper SimulacrumSplinter => null;

				public static InventoryControlWrapper Simulacrum => null;

				private static InventoryControlWrapper smethod_0(string string_0)
				{
					return null;
				}

				private static void Load()
				{
				}

				public static InventoryControlWrapper GetByName(string name)
				{
					return null;
				}

				public static InventoryControlWrapper GetByMetadata(string metadata)
				{
					return null;
				}

				public static InventoryControlWrapper GetInventoryControlForMetadata(string metadata)
				{
					return null;
				}

				internal static bool smethod_1()
				{
					return true;
				}

				internal static DeliriumTab smethod_2()
				{
					return null;
				}

				static DeliriumTab()
				{
					Class200.smethod_34();
				}
			}

			public static class RitualTab
			{
				[CompilerGenerated]
				private sealed class _003Cget_All_003Ed__7 : IEnumerable<InventoryControlWrapper>, IEnumerable, IEnumerator<InventoryControlWrapper>, IEnumerator, IDisposable
				{
					private int _003C_003E1__state;

					private InventoryControlWrapper _003C_003E2__current;

					private int _003C_003El__initialThreadId;

					private Dictionary<string, DreamPoeBot.Loki.FilesInMemory.RitualStashTabLayouts.RitualStashTabLayoutHardcoded>.ValueCollection.Enumerator _003C_003E7__wrap1;

					internal static _003Cget_All_003Ed__7 _003Cget_All_003Ed__7_0;

					InventoryControlWrapper IEnumerator<InventoryControlWrapper>.Current => null;

					object IEnumerator.Current => null;

					public _003Cget_All_003Ed__7(int _003C_003E1__state)
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

					IEnumerator<InventoryControlWrapper> IEnumerable<InventoryControlWrapper>.GetEnumerator()
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

					internal static _003Cget_All_003Ed__7 smethod_1()
					{
						return null;
					}

					static _003Cget_All_003Ed__7()
					{
						Class200.smethod_34();
					}
				}

				private static Dictionary<string, Func<InventoryControlWrapper>> dictionary_0;

				private static Dictionary<string, Func<InventoryControlWrapper>> dictionary_1;

				internal static RitualTab ritualTab_0;

				public static IEnumerable<InventoryControlWrapper> All
				{
					[IteratorStateMachine(typeof(_003Cget_All_003Ed__7))]
					get
					{
						return null;
					}
				}

				public static InventoryControlWrapper PepitionSplinter => null;

				public static InventoryControlWrapper OmenofHomogenisingCoronation => null;

				public static InventoryControlWrapper OmenofGambling => null;

				public static InventoryControlWrapper OmenofBartering => null;

				public static InventoryControlWrapper OmenofCorruption => null;

				public static InventoryControlWrapper OmenofSinistralExaltation => null;

				public static InventoryControlWrapper OmenofDextralExaltation => null;

				public static InventoryControlWrapper OmenofGreaterExaltation => null;

				public static InventoryControlWrapper OmenofSinistralErasure => null;

				public static InventoryControlWrapper OmenofDextralErasure => null;

				public static InventoryControlWrapper OmenofWhittling => null;

				public static InventoryControlWrapper OmenofHomogenisingExaltation => null;

				public static InventoryControlWrapper OmenofCatalysingExaltation => null;

				public static InventoryControlWrapper OmenofChaoticRarity => null;

				public static InventoryControlWrapper OmenofChaoticQuantity => null;

				public static InventoryControlWrapper OmenofChaoticMonsters => null;

				public static InventoryControlWrapper OmenofSinistralAnnulment => null;

				public static InventoryControlWrapper OmenofDextralAnnulment => null;

				public static InventoryControlWrapper OmenofChance => null;

				public static InventoryControlWrapper OmenoftheAncients => null;

				public static InventoryControlWrapper OmenoftheBlessed => null;

				public static InventoryControlWrapper OmenofSanctification => null;

				public static InventoryControlWrapper OmenofDextralCrystallisation => null;

				public static InventoryControlWrapper OmenofSinistralCrystallisation => null;

				public static InventoryControlWrapper OmenofRecombination => null;

				public static InventoryControlWrapper OmenofResurgence => null;

				public static InventoryControlWrapper OmenofAmelioration => null;

				public static InventoryControlWrapper OmenofRefreshment => null;

				public static InventoryControlWrapper OmenoftheHunt => null;

				public static InventoryControlWrapper OmenofAnsweredPrayers => null;

				public static InventoryControlWrapper OmenofSecretCompartments => null;

				public static InventoryControlWrapper OmenofReinforcements => null;

				private static InventoryControlWrapper smethod_0(string string_0)
				{
					return null;
				}

				private static void Load()
				{
				}

				public static InventoryControlWrapper GetByName(string name)
				{
					return null;
				}

				public static InventoryControlWrapper GetByMetadata(string metadata)
				{
					return null;
				}

				public static InventoryControlWrapper GetInventoryControlForMetadata(string metadata)
				{
					return null;
				}

				internal static bool smethod_1()
				{
					return true;
				}

				internal static RitualTab smethod_2()
				{
					return null;
				}

				static RitualTab()
				{
					Class200.smethod_34();
				}
			}

			public static class FragmentTab
			{
				public static class Tablets
				{
					internal static Tablets tablets_0;

					public static InventoryControlWrapper InventoryControl => null;

					public static TabControlWrapper TabControl => null;

					public static bool SelectTabletCategory(StashUi.FragmentTab.Tablets.TabletEnum category)
					{
						return true;
					}

					public static StashUi.FragmentTab.Tablets.TabletEnum SelectedTabletCategory()
					{
						return (StashUi.FragmentTab.Tablets.TabletEnum)(object)null;
					}

					public static int GetCountPerSubCategory(StashUi.FragmentTab.Tablets.TabletEnum category)
					{
						return 0;
					}

					internal static bool smethod_0()
					{
						return true;
					}

					internal static Tablets smethod_1()
					{
						return null;
					}

					static Tablets()
					{
						Class200.smethod_34();
					}
				}

				public static class Trials
				{
					private static Trials trials_0;

					public static InventoryControlWrapper InventoryControl => null;

					public static TabControlWrapper TabControl => null;

					public static bool SelectTabletCategory(StashUi.FragmentTab.Trials.TrialsEnum category)
					{
						return true;
					}

					public static StashUi.FragmentTab.Trials.TrialsEnum SelectedTabletCategory()
					{
						return (StashUi.FragmentTab.Trials.TrialsEnum)(object)null;
					}

					public static int GetCountPerSubCategory(StashUi.FragmentTab.Trials.TrialsEnum category)
					{
						return 0;
					}

					internal static bool smethod_0()
					{
						return true;
					}

					internal static Trials smethod_1()
					{
						return null;
					}

					static Trials()
					{
						Class200.smethod_34();
					}
				}

				private static class Class65
				{
					private static TabControlWrapper tabControlWrapper_0;

					internal static Class65 class65_0;

					[SpecialName]
					internal static InventoryControlWrapper smethod_0()
					{
						return null;
					}

					[SpecialName]
					internal static TabControlWrapper smethod_1()
					{
						return null;
					}

					internal static int smethod_2(int int_0, Element element_0)
					{
						return 0;
					}

					internal static void smethod_3(int int_0, Element element_0)
					{
					}

					internal static string smethod_4(long long_0 = 0L)
					{
						return null;
					}

					private static Element smethod_5()
					{
						return null;
					}

					static Class65()
					{
						Class200.smethod_34();
						Class204.smethod_0();
						tabControlWrapper_0 = new TabControlWrapper(0L, TabControlType.SubCategoryTabContainer);
					}

					internal static bool smethod_6()
					{
						return true;
					}

					internal static Class65 smethod_7()
					{
						return null;
					}
				}

				[CompilerGenerated]
				private sealed class _003Cget_Fragments_003Ed__6 : IEnumerable<InventoryControlWrapper>, IEnumerable, IEnumerator<InventoryControlWrapper>, IEnumerator, IDisposable
				{
					private int _003C_003E1__state;

					private InventoryControlWrapper _003C_003E2__current;

					private int _003C_003El__initialThreadId;

					private Dictionary<string, DreamPoeBot.Loki.FilesInMemory.FragmentStashTabLayouts.FragmentStashTabLayoutHardcoded>.ValueCollection.Enumerator _003C_003E7__wrap1;

					internal static _003Cget_Fragments_003Ed__6 _003Cget_Fragments_003Ed__6_0;

					InventoryControlWrapper IEnumerator<InventoryControlWrapper>.Current => null;

					object IEnumerator.Current => null;

					public _003Cget_Fragments_003Ed__6(int _003C_003E1__state)
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

					IEnumerator<InventoryControlWrapper> IEnumerable<InventoryControlWrapper>.GetEnumerator()
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

					internal static _003Cget_Fragments_003Ed__6 smethod_1()
					{
						return null;
					}

					static _003Cget_Fragments_003Ed__6()
					{
						Class200.smethod_34();
					}
				}

				private static Dictionary<string, Func<InventoryControlWrapper>> dictionary_0;

				private static Dictionary<string, Func<InventoryControlWrapper>> dictionary_1;

				internal static FragmentTab fragmentTab_0;

				public static IEnumerable<InventoryControlWrapper> Fragments
				{
					[IteratorStateMachine(typeof(_003Cget_Fragments_003Ed__6))]
					get
					{
						return null;
					}
				}

				public static IEnumerable<InventoryControlWrapper> All => null;

				private static void Load()
				{
				}

				public static InventoryControlWrapper GetByName(string name)
				{
					return null;
				}

				public static InventoryControlWrapper GetByMetadata(string metadata)
				{
					return null;
				}

				private static InventoryControlWrapper smethod_0(string string_0, StashUi.FragmentTab.FragmentTabCategory fragmentTabCategory_0)
				{
					return null;
				}

				private static bool smethod_1(StashUi.FragmentTab.FragmentTabCategory fragmentTabCategory_0, Element element_0)
				{
					return true;
				}

				private static StashUi.FragmentTab.FragmentTabCategory smethod_2(long long_0)
				{
					return (StashUi.FragmentTab.FragmentTabCategory)(object)null;
				}

				internal static bool smethod_3()
				{
					return true;
				}

				internal static FragmentTab smethod_4()
				{
					return null;
				}

				static FragmentTab()
				{
					Class200.smethod_34();
				}
			}

			public static class MapsTab
			{
				public enum SelectMapResult
				{
					None,
					InvalidControl,
					FailedToScroll,
					MapListNotLoaded
				}

				public enum SelectTierResult
				{
					None,
					InvalidTier,
					InvalidControl,
					TierListNotLoaded,
					SelectionNotConfirmed
				}

				public class MapInfo
				{
					[CompilerGenerated]
					private string string_0;

					[CompilerGenerated]
					private int int_0;

					[CompilerGenerated]
					private bool bool_0;

					internal static MapInfo mapInfo_0;

					public string Name
					{
						[CompilerGenerated]
						get
						{
							return null;
						}
						[CompilerGenerated]
						set
						{
						}
					}

					public int MapsCount
					{
						[CompilerGenerated]
						get
						{
							return 0;
						}
						[CompilerGenerated]
						set
						{
						}
					}

					public bool IsWitnessedByTheMaven
					{
						[CompilerGenerated]
						get
						{
							return true;
						}
						[CompilerGenerated]
						set
						{
						}
					}

					internal static bool smethod_0()
					{
						return true;
					}

					internal static MapInfo smethod_1()
					{
						return null;
					}

					static MapInfo()
					{
						Class200.smethod_34();
					}
				}

				private static MapsTab mapsTab_0;

				public static bool IsTierListLoaded => true;

				public static TabControlWrapper TabControl => null;

				public static InventoryControlWrapper InventoryControl => null;

				public static int SelectedTier => 0;

				public static int GetMapsCountPerTier(int tier)
				{
					return 0;
				}

				public static SelectTierResult SelectTier(int tier)
				{
					return (SelectTierResult)(object)null;
				}

				internal static bool smethod_0()
				{
					return true;
				}

				internal static MapsTab smethod_1()
				{
					return null;
				}

				static MapsTab()
				{
					Class200.smethod_34();
				}
			}

			public static class BreachTab
			{
				public enum BreachTabCategory : byte
				{
					Catalysts = 0,
					Wombgifts = 1,
					Unknown = byte.MaxValue
				}

				public static class Wombgifts
				{
					public enum WombgiftEnum : byte
					{
						CurrencyWombgift = 0,
						AmuletWombgift = 1,
						BeltWombgift = 2,
						RingWombgift = 3,
						BreachstoneWombgift = 4,
						TabletsUnknown = byte.MaxValue
					}

					private static Wombgifts wombgifts_0;

					public static InventoryControlWrapper InventoryControl => null;

					public static TabControlWrapper TabControl => null;

					public static bool SelectWombgiftCategory(WombgiftEnum category)
					{
						return true;
					}

					public static WombgiftEnum SelectedWombgiftCategory()
					{
						return (WombgiftEnum)(object)null;
					}

					public static int GetCountPerSubCategory(WombgiftEnum category)
					{
						return 0;
					}

					internal static bool smethod_0()
					{
						return true;
					}

					internal static Wombgifts smethod_1()
					{
						return null;
					}

					static Wombgifts()
					{
						Class200.smethod_34();
					}
				}

				private static class Class66
				{
					private static TabControlWrapper tabControlWrapper_0;

					private static Class66 class66_0;

					[SpecialName]
					internal static InventoryControlWrapper smethod_0()
					{
						return null;
					}

					[SpecialName]
					public static TabControlWrapper smethod_1()
					{
						return null;
					}

					internal static int smethod_2(int int_0, Element element_0)
					{
						return 0;
					}

					internal static void smethod_3(int int_0, Element element_0)
					{
					}

					internal static string smethod_4(long long_0 = 0L)
					{
						return null;
					}

					private static Element TgbpaveKkdi()
					{
						return null;
					}

					static Class66()
					{
						Class200.smethod_34();
						Class204.smethod_0();
						tabControlWrapper_0 = new TabControlWrapper(0L, TabControlType.SubCategoryTabContainer);
					}

					internal static bool smethod_5()
					{
						return true;
					}

					internal static Class66 smethod_6()
					{
						return null;
					}
				}

				[CompilerGenerated]
				private sealed class _003Cget_Catalysts_003Ed__6 : IEnumerable<InventoryControlWrapper>, IEnumerable, IEnumerator<InventoryControlWrapper>, IEnumerator, IDisposable
				{
					private int _003C_003E1__state;

					private InventoryControlWrapper _003C_003E2__current;

					private int _003C_003El__initialThreadId;

					private Dictionary<string, DreamPoeBot.Loki.FilesInMemory.BreachStashTabLayout.BreachStashTabLayoutHardcoded>.ValueCollection.Enumerator _003C_003E7__wrap1;

					private static _003Cget_Catalysts_003Ed__6 _003Cget_Catalysts_003Ed__6_0;

					InventoryControlWrapper IEnumerator<InventoryControlWrapper>.Current => null;

					object IEnumerator.Current => null;

					public _003Cget_Catalysts_003Ed__6(int _003C_003E1__state)
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

					IEnumerator<InventoryControlWrapper> IEnumerable<InventoryControlWrapper>.GetEnumerator()
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

					internal static _003Cget_Catalysts_003Ed__6 smethod_1()
					{
						return null;
					}

					static _003Cget_Catalysts_003Ed__6()
					{
						Class200.smethod_34();
					}
				}

				private static Dictionary<string, Func<InventoryControlWrapper>> dictionary_0;

				private static Dictionary<string, Func<InventoryControlWrapper>> dictionary_1;

				private static BreachTab breachTab_0;

				public static IEnumerable<InventoryControlWrapper> Catalysts
				{
					[IteratorStateMachine(typeof(_003Cget_Catalysts_003Ed__6))]
					get
					{
						return null;
					}
				}

				public static IEnumerable<InventoryControlWrapper> All => null;

				private static void Load()
				{
				}

				public static InventoryControlWrapper GetByName(string name)
				{
					return null;
				}

				public static InventoryControlWrapper GetByMetadata(string metadata)
				{
					return null;
				}

				private static InventoryControlWrapper smethod_0(string string_0, BreachTabCategory breachTabCategory_0)
				{
					return null;
				}

				private static bool smethod_1(BreachTabCategory breachTabCategory_0, Element element_0)
				{
					return true;
				}

				private static BreachTabCategory smethod_2(long long_0)
				{
					return (BreachTabCategory)(object)null;
				}

				internal static bool smethod_3()
				{
					return true;
				}

				internal static BreachTab smethod_4()
				{
					return null;
				}

				static BreachTab()
				{
					Class200.smethod_34();
				}
			}

			public static class AbyssTab
			{
				[CompilerGenerated]
				private sealed class _003Cget_All_003Ed__7 : IEnumerable<InventoryControlWrapper>, IEnumerable, IEnumerator<InventoryControlWrapper>, IEnumerator, IDisposable
				{
					private int _003C_003E1__state;

					private InventoryControlWrapper _003C_003E2__current;

					private int _003C_003El__initialThreadId;

					private Dictionary<string, DreamPoeBot.Loki.FilesInMemory.AbyssStashTabLayout.AbyssStashTabLayoutHardcoded>.ValueCollection.Enumerator _003C_003E7__wrap1;

					private static _003Cget_All_003Ed__7 _003Cget_All_003Ed__7_0;

					InventoryControlWrapper IEnumerator<InventoryControlWrapper>.Current => null;

					object IEnumerator.Current => null;

					public _003Cget_All_003Ed__7(int _003C_003E1__state)
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

					IEnumerator<InventoryControlWrapper> IEnumerable<InventoryControlWrapper>.GetEnumerator()
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

					internal static _003Cget_All_003Ed__7 smethod_1()
					{
						return null;
					}

					static _003Cget_All_003Ed__7()
					{
						Class200.smethod_34();
					}
				}

				private static Dictionary<string, Func<InventoryControlWrapper>> dictionary_0;

				private static Dictionary<string, Func<InventoryControlWrapper>> dictionary_1;

				private static AbyssTab abyssTab_0;

				public static IEnumerable<InventoryControlWrapper> All
				{
					[IteratorStateMachine(typeof(_003Cget_All_003Ed__7))]
					get
					{
						return null;
					}
				}

				private static InventoryControlWrapper smethod_0(string string_0)
				{
					return null;
				}

				private static void Load()
				{
				}

				public static InventoryControlWrapper GetByName(string name)
				{
					return null;
				}

				public static InventoryControlWrapper GetByMetadata(string metadata)
				{
					return null;
				}

				internal static bool smethod_1()
				{
					return true;
				}

				internal static AbyssTab smethod_2()
				{
					return null;
				}

				static AbyssTab()
				{
					Class200.smethod_34();
				}
			}

			public static class ExpeditionTab
			{
				[CompilerGenerated]
				private sealed class _003Cget_All_003Ed__7 : IEnumerable<InventoryControlWrapper>, IEnumerable, IEnumerator<InventoryControlWrapper>, IEnumerator, IDisposable
				{
					private int _003C_003E1__state;

					private InventoryControlWrapper _003C_003E2__current;

					private int _003C_003El__initialThreadId;

					private Dictionary<string, DreamPoeBot.Loki.FilesInMemory.ExpeditionStashTabLayout.ExpeditionStashTabLayoutHardcoded>.ValueCollection.Enumerator _003C_003E7__wrap1;

					private static _003Cget_All_003Ed__7 _003Cget_All_003Ed__7_0;

					InventoryControlWrapper IEnumerator<InventoryControlWrapper>.Current => null;

					object IEnumerator.Current => null;

					public _003Cget_All_003Ed__7(int _003C_003E1__state)
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

					IEnumerator<InventoryControlWrapper> IEnumerable<InventoryControlWrapper>.GetEnumerator()
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

					internal static _003Cget_All_003Ed__7 smethod_1()
					{
						return null;
					}

					static _003Cget_All_003Ed__7()
					{
						Class200.smethod_34();
					}
				}

				private static Dictionary<string, Func<InventoryControlWrapper>> dictionary_0;

				private static Dictionary<string, Func<InventoryControlWrapper>> dictionary_1;

				internal static ExpeditionTab expeditionTab_0;

				public static IEnumerable<InventoryControlWrapper> All
				{
					[IteratorStateMachine(typeof(_003Cget_All_003Ed__7))]
					get
					{
						return null;
					}
				}

				private static InventoryControlWrapper smethod_0(string string_0)
				{
					return null;
				}

				private static void Load()
				{
				}

				public static InventoryControlWrapper GetByName(string name)
				{
					return null;
				}

				public static InventoryControlWrapper GetByMetadata(string metadata)
				{
					return null;
				}

				internal static bool smethod_1()
				{
					return true;
				}

				internal static ExpeditionTab smethod_2()
				{
					return null;
				}

				static ExpeditionTab()
				{
					Class200.smethod_34();
				}
			}

			public static class SocketableTab
			{
				private enum Enum7 : byte
				{

				}

				[CompilerGenerated]
				private sealed class _003Cget_AncientAugments_003Ed__15 : IEnumerable<InventoryControlWrapper>, IEnumerable, IEnumerator<InventoryControlWrapper>, IEnumerator, IDisposable
				{
					private int _003C_003E1__state;

					private InventoryControlWrapper _003C_003E2__current;

					private int _003C_003El__initialThreadId;

					private Dictionary<string, DreamPoeBot.Loki.FilesInMemory.SocketableStashTabLayout.SocketableStashTabLayoutHardcoded>.ValueCollection.Enumerator _003C_003E7__wrap1;

					internal static _003Cget_AncientAugments_003Ed__15 _003Cget_AncientAugments_003Ed__15_0;

					InventoryControlWrapper IEnumerator<InventoryControlWrapper>.Current => null;

					object IEnumerator.Current => null;

					public _003Cget_AncientAugments_003Ed__15(int _003C_003E1__state)
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

					IEnumerator<InventoryControlWrapper> IEnumerable<InventoryControlWrapper>.GetEnumerator()
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

					internal static _003Cget_AncientAugments_003Ed__15 smethod_1()
					{
						return null;
					}

					static _003Cget_AncientAugments_003Ed__15()
					{
						Class200.smethod_34();
					}
				}

				[CompilerGenerated]
				private sealed class _003Cget_Idols_003Ed__13 : IEnumerable<InventoryControlWrapper>, IEnumerable, IEnumerator<InventoryControlWrapper>, IEnumerator, IDisposable
				{
					private int _003C_003E1__state;

					private InventoryControlWrapper _003C_003E2__current;

					private int _003C_003El__initialThreadId;

					private Dictionary<string, DreamPoeBot.Loki.FilesInMemory.SocketableStashTabLayout.SocketableStashTabLayoutHardcoded>.ValueCollection.Enumerator _003C_003E7__wrap1;

					internal static _003Cget_Idols_003Ed__13 _003Cget_Idols_003Ed__13_0;

					InventoryControlWrapper IEnumerator<InventoryControlWrapper>.Current => null;

					object IEnumerator.Current => null;

					public _003Cget_Idols_003Ed__13(int _003C_003E1__state)
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

					IEnumerator<InventoryControlWrapper> IEnumerable<InventoryControlWrapper>.GetEnumerator()
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

					internal static _003Cget_Idols_003Ed__13 smethod_1()
					{
						return null;
					}

					static _003Cget_Idols_003Ed__13()
					{
						Class200.smethod_34();
					}
				}

				[CompilerGenerated]
				private sealed class _003Cget_KalguuranRunes_003Ed__9 : IEnumerable<InventoryControlWrapper>, IEnumerable, IEnumerator<InventoryControlWrapper>, IEnumerator, IDisposable
				{
					private int _003C_003E1__state;

					private InventoryControlWrapper _003C_003E2__current;

					private int _003C_003El__initialThreadId;

					private Dictionary<string, DreamPoeBot.Loki.FilesInMemory.SocketableStashTabLayout.SocketableStashTabLayoutHardcoded>.ValueCollection.Enumerator _003C_003E7__wrap1;

					private static _003Cget_KalguuranRunes_003Ed__9 _003Cget_KalguuranRunes_003Ed__9_0;

					InventoryControlWrapper IEnumerator<InventoryControlWrapper>.Current => null;

					object IEnumerator.Current => null;

					public _003Cget_KalguuranRunes_003Ed__9(int _003C_003E1__state)
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

					IEnumerator<InventoryControlWrapper> IEnumerable<InventoryControlWrapper>.GetEnumerator()
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

					internal static _003Cget_KalguuranRunes_003Ed__9 smethod_1()
					{
						return null;
					}

					static _003Cget_KalguuranRunes_003Ed__9()
					{
						Class200.smethod_34();
					}
				}

				[CompilerGenerated]
				private sealed class _003Cget_Runes_003Ed__7 : IEnumerable<InventoryControlWrapper>, IEnumerable, IEnumerator<InventoryControlWrapper>, IEnumerator, IDisposable
				{
					private int _003C_003E1__state;

					private InventoryControlWrapper _003C_003E2__current;

					private int _003C_003El__initialThreadId;

					private Dictionary<string, DreamPoeBot.Loki.FilesInMemory.SocketableStashTabLayout.SocketableStashTabLayoutHardcoded>.ValueCollection.Enumerator _003C_003E7__wrap1;

					private static _003Cget_Runes_003Ed__7 _003Cget_Runes_003Ed__7_0;

					InventoryControlWrapper IEnumerator<InventoryControlWrapper>.Current => null;

					object IEnumerator.Current => null;

					public _003Cget_Runes_003Ed__7(int _003C_003E1__state)
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

					IEnumerator<InventoryControlWrapper> IEnumerable<InventoryControlWrapper>.GetEnumerator()
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

					internal static _003Cget_Runes_003Ed__7 smethod_1()
					{
						return null;
					}

					static _003Cget_Runes_003Ed__7()
					{
						Class200.smethod_34();
					}
				}

				[CompilerGenerated]
				private sealed class _003Cget_SoulCores_003Ed__11 : IEnumerable<InventoryControlWrapper>, IEnumerable, IEnumerator<InventoryControlWrapper>, IEnumerator, IDisposable
				{
					private int _003C_003E1__state;

					private InventoryControlWrapper _003C_003E2__current;

					private int _003C_003El__initialThreadId;

					private Dictionary<string, DreamPoeBot.Loki.FilesInMemory.SocketableStashTabLayout.SocketableStashTabLayoutHardcoded>.ValueCollection.Enumerator _003C_003E7__wrap1;

					internal static _003Cget_SoulCores_003Ed__11 _003Cget_SoulCores_003Ed__11_0;

					InventoryControlWrapper IEnumerator<InventoryControlWrapper>.Current => null;

					object IEnumerator.Current => null;

					public _003Cget_SoulCores_003Ed__11(int _003C_003E1__state)
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

					IEnumerator<InventoryControlWrapper> IEnumerable<InventoryControlWrapper>.GetEnumerator()
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

					internal static _003Cget_SoulCores_003Ed__11 smethod_1()
					{
						return null;
					}

					static _003Cget_SoulCores_003Ed__11()
					{
						Class200.smethod_34();
					}
				}

				private static Dictionary<string, Func<InventoryControlWrapper>> dictionary_0;

				private static Dictionary<string, Func<InventoryControlWrapper>> dictionary_1;

				internal static SocketableTab socketableTab_0;

				public static IEnumerable<InventoryControlWrapper> Runes
				{
					[IteratorStateMachine(typeof(_003Cget_Runes_003Ed__7))]
					get
					{
						return null;
					}
				}

				public static IEnumerable<InventoryControlWrapper> KalguuranRunes
				{
					[IteratorStateMachine(typeof(_003Cget_KalguuranRunes_003Ed__9))]
					get
					{
						return null;
					}
				}

				public static IEnumerable<InventoryControlWrapper> SoulCores
				{
					[IteratorStateMachine(typeof(_003Cget_SoulCores_003Ed__11))]
					get
					{
						return null;
					}
				}

				public static IEnumerable<InventoryControlWrapper> Idols
				{
					[IteratorStateMachine(typeof(_003Cget_Idols_003Ed__13))]
					get
					{
						return null;
					}
				}

				public static IEnumerable<InventoryControlWrapper> AncientAugments
				{
					[IteratorStateMachine(typeof(_003Cget_AncientAugments_003Ed__15))]
					get
					{
						return null;
					}
				}

				public static IEnumerable<InventoryControlWrapper> All => null;

				private static InventoryControlWrapper smethod_0(string string_0, byte byte_0)
				{
					return null;
				}

				private static void Load()
				{
				}

				public static InventoryControlWrapper GetByName(string name)
				{
					return null;
				}

				public static InventoryControlWrapper GetByMetadata(string metadata)
				{
					return null;
				}

				private static bool RdrpkiQiWaW(Enum7 enum7_0, Element element_0)
				{
					return true;
				}

				private static Enum7 smethod_1(Element element_0)
				{
					return (Enum7)(object)null;
				}

				internal static bool smethod_2()
				{
					return true;
				}

				internal static SocketableTab smethod_3()
				{
					return null;
				}

				static SocketableTab()
				{
					Class200.smethod_34();
				}
			}

			[StructLayout(LayoutKind.Sequential, Pack = 1)]
			internal struct Struct65
			{
				private long long_0;

				private ushort ushort_0;

				public ushort ushort_1;

				private ushort ushort_2;

				private ushort ushort_3;

				public GStruct2 gstruct2_0;

				private int int_0;

				private int int_1;

				private ushort ushort_4;

				private ushort ushort_5;

				private ushort wtypkHqhBkh;

				private ushort ushort_6;

				private long long_1;

				private long long_2;

				private long long_3;

				private long long_4;

				private long long_5;

				private long long_6;

				private int int_2;

				private int int_3;

				private long long_7;

				private long long_8;

				private long long_9;

				private long long_10;

				private long long_11;

				private long long_12;

				private long long_13;

				private long long_14;

				private long long_15;

				private long long_16;

				private long long_17;

				private long long_18;

				private long long_19;

				private long long_20;

				private long long_21;

				private long long_22;

				private long long_23;

				private int int_4;

				private int int_5;

				private long long_24;

				private long long_25;
			}

			[StructLayout(LayoutKind.Sequential, Pack = 1)]
			internal struct Struct66
			{
				private long long_0;

				private long long_1;

				private long long_2;

				private long long_3;

				private long long_4;

				private long long_5;

				private long long_6;

				private long long_7;

				private long long_8;

				public long long_9;

				private long long_10;

				private long GkApudwhdk7;

				private long long_11;

				private long long_12;

				private long long_13;

				private long long_14;

				private long long_15;

				private long long_16;
			}

			internal static int int_0;

			internal static int BvKpfbbiykv;

			internal static TabControlWrapper tabControlWrapper_0;

			private static GuildStashUi guildStashUi_0;

			public static bool IsOpened => true;

			public static StashTabInfo StashTabInfo => null;

			public static bool IsCurrentTabLoaded => true;

			public static InventoryControlWrapper InventoryControl => null;

			public static TabControlWrapper TabControl => null;

			public static List<Item> AllItems => null;

			[SpecialName]
			internal static bool smethod_0()
			{
				return true;
			}

			[SpecialName]
			internal static long ShypfHaypEx()
			{
				return 0L;
			}

			[SpecialName]
			internal static long smethod_1()
			{
				return 0L;
			}

			[SpecialName]
			internal static List<Struct65> smethod_2()
			{
				return null;
			}

			[SpecialName]
			internal static Struct66 smethod_3()
			{
				return (Struct66)(object)null;
			}

			[SpecialName]
			internal static Element smethod_4()
			{
				return null;
			}

			internal static bool smethod_5(out StashTabInfo stashTabInfo_0, out List<InventoryHolder> list_0)
			{
				return true;
			}

			private static StashTabInfo smethod_6()
			{
				return null;
			}

			private static InventoryControlWrapper smethod_7(InventoryControlWrapper inventoryControlWrapper_0, StashTabInfo stashTabInfo_0, bool bool_0 = false, Element element_0 = null)
			{
				return null;
			}

			public static void SetHighlightKeyword(string text)
			{
			}

			private static InventoryHolder smethod_8(long long_0)
			{
				return null;
			}

			private static Element smethod_9()
			{
				return null;
			}

			static GuildStashUi()
			{
				Class200.smethod_34();
				Class204.smethod_0();
				int_0 = 1080;
				BvKpfbbiykv = 1648;
				tabControlWrapper_0 = new TabControlWrapper(0L, TabControlType.Stash);
			}

			internal static bool smethod_10()
			{
				return true;
			}

			internal static GuildStashUi smethod_11()
			{
				return null;
			}
		}

		public static class GuiQuestStateUi
		{
			public static List<(string Title, string Content)> QuestStates => null;

			public static List<UiQuestStatesElement.MapContent> MapContent => null;

			public static List<UiQuestStatesElement.MapObjective> MapObjectives => null;

			static GuiQuestStateUi()
			{
				Class200.smethod_34();
			}
		}

		public static class HelpUi
		{
			public static bool IsOpened => true;

			static HelpUi()
			{
				Class200.smethod_34();
			}
		}

		public static class HideoutEditorUi
		{
			public enum ImportLayoutError
			{
				None,
				UiNotOpen
			}

			internal static HideoutEditorUi hideoutEditorUi_0;

			public static bool IsOpened => true;

			internal static bool smethod_0()
			{
				return true;
			}

			internal static HideoutEditorUi smethod_1()
			{
				return null;
			}

			static HideoutEditorUi()
			{
				Class200.smethod_34();
			}
		}

		public static class HideoutSelectionUi
		{
			public class HideoutTemplate
			{
				[CompilerGenerated]
				private readonly Element element_0;

				[CompilerGenerated]
				private HideoutEnum ysTpuLcsLsO;

				[CompilerGenerated]
				private string string_0;

				private static HideoutTemplate hideoutTemplate_0;

				public HideoutEnum HideoutType
				{
					[CompilerGenerated]
					get
					{
						return (HideoutEnum)(object)null;
					}
					[CompilerGenerated]
					set
					{
					}
				}

				public string Name
				{
					[CompilerGenerated]
					get
					{
						return null;
					}
					[CompilerGenerated]
					set
					{
					}
				}

				public bool IsEnabled => true;

				public HideoutTemplate()
				{
				}

				public HideoutTemplate(Element element)
				{
				}

				[SpecialName]
				[CompilerGenerated]
				private Element method_0()
				{
					return null;
				}

				[SpecialName]
				internal Vector2i method_1()
				{
					return (Vector2i)(object)null;
				}

				internal static bool smethod_0()
				{
					return true;
				}

				internal static HideoutTemplate smethod_1()
				{
					return null;
				}

				static HideoutTemplate()
				{
					Class200.smethod_34();
				}
			}

			internal static HideoutSelectionUi hideoutSelectionUi_0;

			public static bool IsOpened => true;

			public static IEnumerable<HideoutTemplate> UnlockedHideouts => null;

			public static IEnumerable<HideoutTemplate> AllHideouts => null;

			public static SelectHideoutResult SelectHideout(HideoutEnum hideout)
			{
				return (SelectHideoutResult)(object)null;
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static HideoutSelectionUi smethod_1()
			{
				return null;
			}

			static HideoutSelectionUi()
			{
				Class200.smethod_34();
			}
		}

		public static class HideoutUnlockedUi
		{
			internal static HideoutUnlockedUi hideoutUnlockedUi_0;

			public static bool IsOpened => true;

			internal static bool smethod_0()
			{
				return true;
			}

			internal static HideoutUnlockedUi smethod_1()
			{
				return null;
			}

			static HideoutUnlockedUi()
			{
				Class200.smethod_34();
			}
		}

		public static class InstanceManagerUi
		{
			internal static InstanceManagerUi instanceManagerUi_0;

			public static bool IsOpened => true;

			public static int InstanceCount => 0;

			public static JoinInstanceResult JoinNewInstance(bool actuallyJoin = true)
			{
				return (JoinInstanceResult)(object)null;
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static InstanceManagerUi smethod_1()
			{
				return null;
			}

			static InstanceManagerUi()
			{
				Class200.smethod_34();
			}
		}

		public static class InstillingUi
		{
			internal static readonly InventoryControlWrapper inventoryControlWrapper_0;

			private static InstillingUi instillingUi_0;

			public static bool IsOpened => true;

			public static bool IsDistilledEmotion1Visible => true;

			public static bool IsDistilledEmotion2Visible => true;

			public static bool IsDistilledEmotion3Visible => true;

			public static bool IsDistilledEmotion4Visible => true;

			public static string ModTitle => null;

			public static string ModError => null;

			public static InventoryControlWrapper InventoryControl_Main => null;

			public static Item DistilledEmotion1 => null;

			public static Item DistilledEmotion2 => null;

			public static Item DistilledEmotion3 => null;

			public static Item DistilledEmotion4 => null;

			[SpecialName]
			private static InventorySlotUiElement smethod_0()
			{
				return null;
			}

			[SpecialName]
			private static InventorySlotUiElement smethod_1()
			{
				return null;
			}

			[SpecialName]
			private static InventorySlotUiElement smethod_2()
			{
				return null;
			}

			[SpecialName]
			private static InventorySlotUiElement smethod_3()
			{
				return null;
			}

			public static InstilResult Instil()
			{
				return (InstilResult)(object)null;
			}

			public static RemoveDistilledEmotionResult FastRemoveDistilledEmotion(int slot)
			{
				return (RemoveDistilledEmotionResult)(object)null;
			}

			public static PlaceCursorInDistilledEmotionSlotResult PlaceCursorInDistilledEmotionSlot(int slot)
			{
				return (PlaceCursorInDistilledEmotionSlotResult)(object)null;
			}

			static InstillingUi()
			{
				Class200.smethod_34();
				Class204.smethod_0();
				inventoryControlWrapper_0 = new InventoryControlWrapper(0L);
			}

			internal static bool smethod_4()
			{
				return true;
			}

			internal static InstillingUi smethod_5()
			{
				return null;
			}
		}

		public static class InventoryUi
		{
			[CompilerGenerated]
			private sealed class _003Cget_AllInventoryControls_003Ed__21 : IEnumerable<InventoryControlWrapper>, IEnumerable, IEnumerator<InventoryControlWrapper>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private InventoryControlWrapper _003C_003E2__current;

				private int _003C_003El__initialThreadId;

				private static _003Cget_AllInventoryControls_003Ed__21 _003Cget_AllInventoryControls_003Ed__21_0;

				InventoryControlWrapper IEnumerator<InventoryControlWrapper>.Current => null;

				object IEnumerator.Current => null;

				public _003Cget_AllInventoryControls_003Ed__21(int _003C_003E1__state)
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

				void IEnumerator.Reset()
				{
				}

				IEnumerator<InventoryControlWrapper> IEnumerable<InventoryControlWrapper>.GetEnumerator()
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

				internal static _003Cget_AllInventoryControls_003Ed__21 smethod_1()
				{
					return null;
				}

				static _003Cget_AllInventoryControls_003Ed__21()
				{
					Class200.smethod_34();
				}
			}

			internal static InventoryControlWrapper inventoryControlWrapper_0;

			internal static InventoryControlWrapper inventoryControlWrapper_1;

			internal static InventoryControlWrapper inventoryControlWrapper_2;

			internal static InventoryControlWrapper inventoryControlWrapper_3;

			internal static InventoryControlWrapper inventoryControlWrapper_4;

			internal static InventoryControlWrapper inventoryControlWrapper_5;

			internal static InventoryControlWrapper inventoryControlWrapper_6;

			internal static InventoryControlWrapper inventoryControlWrapper_7;

			internal static InventoryControlWrapper inventoryControlWrapper_8;

			internal static InventoryControlWrapper inventoryControlWrapper_9;

			internal static InventoryControlWrapper inventoryControlWrapper_10;

			internal static InventoryControlWrapper inventoryControlWrapper_11;

			internal static InventoryControlWrapper inventoryControlWrapper_12;

			internal static InventoryControlWrapper inventoryControlWrapper_13;

			internal static InventoryControlWrapper inventoryControlWrapper_14;

			internal static InventoryControlWrapper inventoryControlWrapper_15;

			internal static InventoryControlWrapper inventoryControlWrapper_16;

			internal static InventoryControlWrapper inventoryControlWrapper_17;

			internal static InventoryUi inventoryUi_0;

			public static bool IsOpened => true;

			public static IEnumerable<InventoryControlWrapper> AllInventoryControls
			{
				[IteratorStateMachine(typeof(_003Cget_AllInventoryControls_003Ed__21))]
				get
				{
					return null;
				}
			}

			public static InventoryControlWrapper InventoryControl_Main => null;

			public static InventoryControlWrapper InventoryControl_Belt => null;

			public static InventoryControlWrapper InventoryControl_Boots => null;

			public static InventoryControlWrapper InventoryControl_Chest => null;

			public static InventoryControlWrapper InventoryControl_FlasksLife => null;

			public static InventoryControlWrapper InventoryControl_FlasksMana => null;

			public static InventoryControlWrapper InventoryControl_Gloves => null;

			public static InventoryControlWrapper InventoryControl_Head => null;

			public static InventoryControlWrapper InventoryControl_LeftRing => null;

			public static InventoryControlWrapper InventoryControl_Neck => null;

			public static InventoryControlWrapper InventoryControl_PrimaryMainHand => null;

			public static InventoryControlWrapper InventoryControl_PrimaryOffHand => null;

			public static InventoryControlWrapper InventoryControl_RightRing => null;

			public static InventoryControlWrapper InventoryControl_SecondaryMainHand => null;

			public static InventoryControlWrapper InventoryControl_SecondaryOffHand => null;

			public static InventoryControlWrapper InventoryControl_Charm1 => null;

			public static InventoryControlWrapper InventoryControl_Charm2 => null;

			public static InventoryControlWrapper InventoryControl_Charm3 => null;

			public static bool IsTatuedRuneInventoryOpen => true;

			public static void ClickTatuedRuneInventoryButton()
			{
			}

			static InventoryUi()
			{
				Class200.smethod_34();
				Class204.smethod_0();
				inventoryControlWrapper_0 = new InventoryControlWrapper(0L);
				inventoryControlWrapper_1 = new InventoryControlWrapper(0L);
				inventoryControlWrapper_2 = new InventoryControlWrapper(0L);
				inventoryControlWrapper_3 = new InventoryControlWrapper(0L);
				inventoryControlWrapper_4 = new InventoryControlWrapper(0L);
				inventoryControlWrapper_5 = new InventoryControlWrapper(0L);
				inventoryControlWrapper_6 = new InventoryControlWrapper(0L);
				inventoryControlWrapper_7 = new InventoryControlWrapper(0L);
				inventoryControlWrapper_8 = new InventoryControlWrapper(0L);
				inventoryControlWrapper_9 = new InventoryControlWrapper(0L);
				inventoryControlWrapper_10 = new InventoryControlWrapper(0L);
				inventoryControlWrapper_11 = new InventoryControlWrapper(0L);
				inventoryControlWrapper_12 = new InventoryControlWrapper(0L);
				inventoryControlWrapper_13 = new InventoryControlWrapper(0L);
				inventoryControlWrapper_14 = new InventoryControlWrapper(0L);
				inventoryControlWrapper_15 = new InventoryControlWrapper(0L);
				inventoryControlWrapper_16 = new InventoryControlWrapper(0L);
				inventoryControlWrapper_17 = new InventoryControlWrapper(0L);
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static InventoryUi smethod_1()
			{
				return null;
			}
		}

		public static class MapUi
		{
			internal static MapUi mapUi_0;

			public static bool IsMiniMapVisible => true;

			public static bool IsLargeMapVisible => true;

			public static float MiniMapZoom => 0f;

			public static float LargeMapZoom => 0f;

			public static System.Numerics.Vector2 LargeMapDefaultShift => (System.Numerics.Vector2)(object)null;

			public static System.Numerics.Vector2 LargeMapShift => (System.Numerics.Vector2)(object)null;

			public static System.Numerics.Vector2 MiniMapDefaultShift => (System.Numerics.Vector2)(object)null;

			public static System.Numerics.Vector2 MiniMapShift => (System.Numerics.Vector2)(object)null;

			public static Element MiniMapElement => null;

			public static Element LargeMapElement => null;

			public static bool IsMapModPanelVisibleAndExpanded => true;

			public static void ToggleMapModPanel()
			{
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static MapUi smethod_1()
			{
				return null;
			}

			static MapUi()
			{
				Class200.smethod_34();
			}
		}

		public static class MerchantUI
		{
			internal static TabControlWrapper tabControlWrapper_0;

			internal static TabControlWrapper tabControlWrapper_1;

			private static MerchantUI merchantUI_0;

			public static bool IsOpened => true;

			public static TabControlWrapper UpperTabControl => null;

			public static TabControlWrapper LowerTabControl => null;

			public static InventoryControlWrapper MerchantInventoryControl => null;

			public static List<Item> Earnings => null;

			[SpecialName]
			internal static long smethod_0()
			{
				return 0L;
			}

			[SpecialName]
			internal static long smethod_1()
			{
				return 0L;
			}

			[SpecialName]
			internal static long smethod_2()
			{
				return 0L;
			}

			[SpecialName]
			internal static StashUi.Struct68 smethod_3()
			{
				return (StashUi.Struct68)(object)null;
			}

			public static FastMoveResult FastMoveEarnings(int localId)
			{
				return (FastMoveResult)(object)null;
			}

			public static FastMoveResult FastMoveAllEarnings(int localId)
			{
				return (FastMoveResult)(object)null;
			}

			static MerchantUI()
			{
				Class200.smethod_34();
				Class204.smethod_0();
				tabControlWrapper_0 = new TabControlWrapper(0L, TabControlType.Merchant);
				tabControlWrapper_1 = new TabControlWrapper(0L, TabControlType.Merchant);
			}

			internal static bool smethod_4()
			{
				return true;
			}

			internal static MerchantUI smethod_5()
			{
				return null;
			}
		}

		public static class MicrotansactionShopPannelUi
		{
			private static MicrotansactionShopPannelUi microtansactionShopPannelUi_0;

			public static bool IsOpened => true;

			internal static bool smethod_0()
			{
				return true;
			}

			internal static MicrotansactionShopPannelUi smethod_1()
			{
				return null;
			}

			static MicrotansactionShopPannelUi()
			{
				Class200.smethod_34();
			}
		}

		public static class NPCBuyWindowUi
		{
			[StructLayout(LayoutKind.Explicit, Size = 12)]
			public struct StructHighlightItem
			{
				[FieldOffset(0)]
				public Vector2i Position;
			}

			internal static NPCBuyWindowUi npcbuyWindowUi_0;

			public static bool IsOpened => true;

			public static TabControlWrapper TabControl => null;

			public static InventoryControlWrapper InventoryControl => null;

			public static List<Item> HighlightedItems => null;

			internal static bool smethod_0()
			{
				return true;
			}

			internal static NPCBuyWindowUi smethod_1()
			{
				return null;
			}

			static NPCBuyWindowUi()
			{
				Class200.smethod_34();
			}
		}

		public static class NpcDialogUi
		{
			public class NpcDialogEntryWrapper
			{
				[CompilerGenerated]
				private Element element_0;

				[CompilerGenerated]
				private bool bool_0;

				[CompilerGenerated]
				private string JuJpIlfRoEs;

				[CompilerGenerated]
				private uint uint_0;

				[CompilerGenerated]
				private Vector2i vector2i_0;

				internal static NpcDialogEntryWrapper npcDialogEntryWrapper_0;

				public Element Element
				{
					[CompilerGenerated]
					get
					{
						return null;
					}
					[CompilerGenerated]
					set
					{
					}
				}

				public bool IsDialogChoice
				{
					[CompilerGenerated]
					get
					{
						return true;
					}
					[CompilerGenerated]
					set
					{
					}
				}

				public string Text
				{
					[CompilerGenerated]
					get
					{
						return null;
					}
					[CompilerGenerated]
					set
					{
					}
				}

				public uint Color
				{
					[CompilerGenerated]
					get
					{
						return 0u;
					}
					[CompilerGenerated]
					set
					{
					}
				}

				public Vector2i Position
				{
					[CompilerGenerated]
					get
					{
						return (Vector2i)(object)null;
					}
					[CompilerGenerated]
					set
					{
					}
				}

				public NpcDialogEntryWrapper(Element element, bool isDialogChoice, Vector2i position, uint color)
				{
				}

				internal static bool smethod_0()
				{
					return true;
				}

				internal static NpcDialogEntryWrapper smethod_1()
				{
					return null;
				}

				static NpcDialogEntryWrapper()
				{
					Class200.smethod_34();
				}
			}

			private static NpcDialogUi npcDialogUi_0;

			public static bool IsOpened => true;

			public static uint DialogDepth => 0u;

			public static string Title => null;

			public static NpcDialogEntryWrapper ContinueWrapper => null;

			public static NpcDialogEntryWrapper AcceptQuestWrapper => null;

			public static Element GetContinue => null;

			public static Element GetAcceptQuest => null;

			public static List<NpcDialogEntryWrapper> DialogEntries => null;

			[SpecialName]
			private static string smethod_0()
			{
				return null;
			}

			public static bool AcceptQuest()
			{
				return true;
			}

			[SpecialName]
			private static List<NpcDialogEntryWrapper> smethod_1()
			{
				return null;
			}

			public static bool CanConverse(string text)
			{
				return true;
			}

			public static ConverseResult Converse(string text, bool actuallyConverse = true)
			{
				return (ConverseResult)(object)null;
			}

			public static Element FindPannel(string text)
			{
				return null;
			}

			public static ConverseResult Goodbye()
			{
				return (ConverseResult)(object)null;
			}

			public static bool HasConversed(string text)
			{
				return true;
			}

			public static ConverseResult BuyorSellItems()
			{
				return (ConverseResult)(object)null;
			}

			private static NpcDialogEntryWrapper smethod_2(string string_0)
			{
				return null;
			}

			internal static bool smethod_3()
			{
				return true;
			}

			internal static NpcDialogUi smethod_4()
			{
				return null;
			}

			static NpcDialogUi()
			{
				Class200.smethod_34();
			}
		}

		public static class OptionsUi
		{
			internal static TabControlWrapper tabControlWrapper_0;

			internal static OptionsUi optionsUi_0;

			public static bool IsOpened => true;

			public static TabControlWrapper TabControl => null;

			public static List<OptionsElement.UICategories> UICategories => null;

			static OptionsUi()
			{
				Class200.smethod_34();
				Class204.smethod_0();
				tabControlWrapper_0 = new TabControlWrapper(0L, TabControlType.Options);
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static OptionsUi smethod_1()
			{
				return null;
			}
		}

		public static class PremiumStashSettingsUi
		{
			private static PremiumStashSettingsUi premiumStashSettingsUi_0;

			public static bool IsOpened => true;

			public static bool IsPublic => true;

			public static List<AffinitieCheckbox> Affinities => null;

			public static PremiumPriceTypeEnum SelectedPriceType => (PremiumPriceTypeEnum)(object)null;

			public static PriceCurrencyEnum SelectedPriceCurrency => (PriceCurrencyEnum)(object)null;

			public static string GetPriceCurrencyQuantity => null;

			public static bool ClickPublicButton()
			{
				return true;
			}

			public static bool Close()
			{
				return true;
			}

			public static bool SelectPriceCurrency(PriceCurrencyEnum priceType)
			{
				return true;
			}

			public static bool SelectPriceType(PremiumPriceTypeEnum priceType)
			{
				return true;
			}

			public static bool SetPriceCurrencyQuantity(string quantity)
			{
				return true;
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static PremiumStashSettingsUi smethod_1()
			{
				return null;
			}

			static PremiumStashSettingsUi()
			{
				Class200.smethod_34();
			}
		}

		public static class ReforgingBenchUi
		{
			public enum ReforgeSlotType
			{
				CraftSlot1,
				CraftSlot2,
				CraftSlot3,
				ResultSlot
			}

			internal static ReforgingBenchUi reforgingBenchUi_0;

			public static bool IsOpened => true;

			public static Item GetItemInSlot(ReforgeSlotType slot)
			{
				return null;
			}

			public static ReforgeResult Reforge()
			{
				return (ReforgeResult)(object)null;
			}

			public static bool CanReforge()
			{
				return true;
			}

			public static FastMoveFromSlotResult FastMoveFromSlot(ReforgeSlotType slot)
			{
				return (FastMoveFromSlotResult)(object)null;
			}

			public static PlaceCursorInSlotResult PlaceCursorInSlot(ReforgeSlotType slot)
			{
				return (PlaceCursorInSlotResult)(object)null;
			}

			[SpecialName]
			private static Item smethod_0()
			{
				return null;
			}

			[SpecialName]
			private static Item smethod_1()
			{
				return null;
			}

			[SpecialName]
			private static Item smethod_2()
			{
				return null;
			}

			[SpecialName]
			private static Item smethod_3()
			{
				return null;
			}

			[SpecialName]
			private static SingleSlotUiElement smethod_4()
			{
				return null;
			}

			[SpecialName]
			private static SingleSlotUiElement smethod_5()
			{
				return null;
			}

			[SpecialName]
			private static SingleSlotUiElement MyYprLvadnO()
			{
				return null;
			}

			[SpecialName]
			private static SingleSlotUiElement smethod_6()
			{
				return null;
			}

			internal static bool smethod_7()
			{
				return true;
			}

			internal static ReforgingBenchUi smethod_8()
			{
				return null;
			}

			static ReforgingBenchUi()
			{
				Class200.smethod_34();
			}
		}

		public static class RelicAltarUi
		{
			public enum ActionResult
			{
				None,
				UiNotOpen,
				ButtonNotAvailable,
				ProcessHookManagerNotEnabled
			}

			internal static RelicAltarUi relicAltarUi_0;

			public static bool IsOpened => true;

			public static InventoryControlWrapper InventoryControl_Key => null;

			public static InventoryControlWrapper InventoryControl_Relics => null;

			public static Item Key => null;

			public static bool CanConfirm => true;

			public static string ConfirmButtonText => null;

			[SpecialName]
			private static RelicAltarElement smethod_0()
			{
				return null;
			}

			public static ActionResult Confirm()
			{
				return (ActionResult)(object)null;
			}

			public static ActionResult OpenRelicLocker()
			{
				return (ActionResult)(object)null;
			}

			public static ActionResult Close()
			{
				return (ActionResult)(object)null;
			}

			private static bool Available(Element button)
			{
				return true;
			}

			private static ActionResult smethod_1(RelicAltarElement relicAltarElement_0, Element element_0)
			{
				return (ActionResult)(object)null;
			}

			internal static bool smethod_2()
			{
				return true;
			}

			internal static RelicAltarUi smethod_3()
			{
				return null;
			}

			static RelicAltarUi()
			{
				Class200.smethod_34();
			}
		}

		public static class RelicLockerUi
		{
			public enum ActionResult
			{
				None,
				UiNotOpen,
				ButtonNotAvailable,
				ProcessHookManagerNotEnabled
			}

			internal static RelicLockerUi relicLockerUi_0;

			public static bool IsOpened => true;

			public static InventoryControlWrapper InventoryControl => null;

			[SpecialName]
			private static RelicLockerElement smethod_0()
			{
				return null;
			}

			public static ActionResult Close()
			{
				return (ActionResult)(object)null;
			}

			internal static bool smethod_1()
			{
				return true;
			}

			internal static RelicLockerUi smethod_2()
			{
				return null;
			}

			static RelicLockerUi()
			{
				Class200.smethod_34();
			}
		}

		public static class RewardUi
		{
			internal static RewardUi rewardUi_0;

			public static bool IsOpened => true;

			public static List<InventoryControlWrapper> InventoryControls => null;

			[SpecialName]
			private static Element smethod_0()
			{
				return null;
			}

			internal static bool smethod_1()
			{
				return true;
			}

			internal static RewardUi smethod_2()
			{
				return null;
			}

			static RewardUi()
			{
				Class200.smethod_34();
			}
		}

		public static class RitualFavorsUi
		{
			internal static WindowControlWrapper windowControlWrapper_0;

			internal static readonly InventoryControlWrapper inventoryControlWrapper_0;

			private static RitualFavorsUi ritualFavorsUi_0;

			public static bool IsOpened => true;

			public static InventoryControlWrapper InventoryControl => null;

			public static bool IsDeferItemActive => true;

			public static string TributeRemainingAndTotalDeferCost => null;

			[SpecialName]
			internal static long smethod_0()
			{
				return 0L;
			}

			public static ActivateDeferResult ActivateDefer()
			{
				return (ActivateDeferResult)(object)null;
			}

			public static ConfirmDeferResult ConfirmDefer()
			{
				return (ConfirmDeferResult)(object)null;
			}

			public static FavorRerollResult RerollFavorItems()
			{
				return (FavorRerollResult)(object)null;
			}

			public static OfferTributeToTheKingResult OfferTributeToTheKing()
			{
				return (OfferTributeToTheKingResult)(object)null;
			}

			static RitualFavorsUi()
			{
				Class200.smethod_34();
				Class204.smethod_0();
				windowControlWrapper_0 = new WindowControlWrapper(0L);
				inventoryControlWrapper_0 = new InventoryControlWrapper(0L);
			}

			internal static bool smethod_1()
			{
				return true;
			}

			internal static RitualFavorsUi smethod_2()
			{
				return null;
			}
		}

		public static class RuneshapeConbinationsUi
		{
			public class RuneshapeRecipe
			{
				public class RewardDettails
				{
					[CompilerGenerated]
					private long long_0;

					[CompilerGenerated]
					private int int_0;

					[CompilerGenerated]
					private string string_0;

					[CompilerGenerated]
					private int int_1;

					private static RewardDettails rewardDettails_0;

					public int Count
					{
						[CompilerGenerated]
						get
						{
							return 0;
						}
						[CompilerGenerated]
						private set
						{
						}
					}

					public string GenericItem
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

					public int GemLevel
					{
						[CompilerGenerated]
						get
						{
							return 0;
						}
						[CompilerGenerated]
						private set
						{
						}
					}

					public DatBaseItemTypeWrapper Item => null;

					[SpecialName]
					[CompilerGenerated]
					private long method_0()
					{
						return 0L;
					}

					[SpecialName]
					[CompilerGenerated]
					private void method_1(long long_1)
					{
					}

					internal RewardDettails(int rewardCounts, long baseItemTypePtr, string description, int gemLevel)
					{
					}

					internal static bool smethod_0()
					{
						return true;
					}

					internal static RewardDettails smethod_1()
					{
						return null;
					}

					static RewardDettails()
					{
						Class200.smethod_34();
					}
				}

				private Element element_0;

				internal static RuneshapeRecipe runeshapeRecipe_0;

				public bool IsEnabled => true;

				public string Reward => null;

				public RewardDettails RewardInfo => null;

				public List<string> Runes => null;

				public RuneshapeRecipe(Element element)
				{
				}

				public void Click()
				{
				}

				internal static bool smethod_0()
				{
					return true;
				}

				internal static RuneshapeRecipe smethod_1()
				{
					return null;
				}

				static RuneshapeRecipe()
				{
					Class200.smethod_34();
				}
			}

			private static RuneshapeConbinationsUi runeshapeConbinationsUi_0;

			public static bool IsOpened => true;

			public static List<int> PropagatedRunePositions => null;

			public static List<RuneshapeRecipe> Recipes => null;

			internal static bool smethod_0()
			{
				return true;
			}

			internal static RuneshapeConbinationsUi smethod_1()
			{
				return null;
			}

			static RuneshapeConbinationsUi()
			{
				Class200.smethod_34();
			}
		}

		public static class ShopUi
		{
			internal static ShopUi shopUi_0;

			public static bool IsOpened => true;

			internal static bool smethod_0()
			{
				return true;
			}

			internal static ShopUi smethod_1()
			{
				return null;
			}

			static ShopUi()
			{
				Class200.smethod_34();
			}
		}

		public static class ShowRitualRewardUi
		{
			internal static ShowRitualRewardUi showRitualRewardUi_0;

			public static bool IsOpened => true;

			public static OpenRitualRewardPannelResult OpenRitualRewardPannel()
			{
				return (OpenRitualRewardPannelResult)(object)null;
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static ShowRitualRewardUi smethod_1()
			{
				return null;
			}

			static ShowRitualRewardUi()
			{
				Class200.smethod_34();
			}
		}

		public static class SkillGemPanelUi
		{
			public sealed class SkillGemEntry
			{
				private readonly long long_0;

				private readonly Element element_0;

				[CompilerGenerated]
				private readonly Item item_0;

				internal static SkillGemEntry skillGemEntry_0;

				public Item Item
				{
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				public Element Element => null;

				public IReadOnlyList<Element> SupportSockets => null;

				public bool CanToggle => true;

				public bool? IsActive => null;

				internal SkillGemEntry(long panel, Element element, Item item)
				{
				}

				[SpecialName]
				private Element JpOpIrXvmrr()
				{
					return null;
				}

				private bool method_0(out bool bool_0)
				{
					return true;
				}

				public bool SetActive(bool enabled)
				{
					return true;
				}

				[SpecialName]
				internal bool method_1()
				{
					return true;
				}

				internal bool method_2(int int_0, out Element element_1, bool bool_0 = false)
				{
					return true;
				}

				public bool BringIntoView(int socketIndex = -1)
				{
					return true;
				}

				internal bool method_3(int int_0, bool bool_0)
				{
					return true;
				}

				internal static bool smethod_0()
				{
					return true;
				}

				internal static SkillGemEntry smethod_1()
				{
					return null;
				}

				static SkillGemEntry()
				{
					Class200.smethod_34();
				}
			}

			internal static SkillGemPanelUi skillGemPanelUi_0;

			public static bool IsOpened => true;

			public static InventoryControlWrapper InventoryControl => null;

			public static List<SkillGemEntry> Gems => null;

			[SpecialName]
			internal static Element smethod_0()
			{
				return null;
			}

			[SpecialName]
			internal static Element smethod_1()
			{
				return null;
			}

			[SpecialName]
			internal static InventoryHolder YqkpHliumBE()
			{
				return null;
			}

			internal static bool smethod_2(int int_0, int int_1, bool bool_0, bool bool_1, Func<bool> func_0 = null, bool bool_2 = false)
			{
				return true;
			}

			internal static bool smethod_3(Vector2i vector2i_0, RectangleF rectangleF_0)
			{
				return true;
			}

			internal static RectangleF smethod_4(Element element_0)
			{
				return (RectangleF)(object)null;
			}

			internal static RectangleF smethod_5(Element element_0)
			{
				return (RectangleF)(object)null;
			}

			private static bool smethod_6(float float_0, float float_1)
			{
				return true;
			}

			private static int smethod_7(float float_0, float float_1, float float_2)
			{
				return 0;
			}

			internal static bool smethod_8(Func<bool> func_0, Func<Element> func_1, Func<Element> func_2)
			{
				return true;
			}

			public static bool IncreaseMinionCount(Skill skill)
			{
				return true;
			}

			public static bool DecreaseMinionCount(Skill skill)
			{
				return true;
			}

			private static bool smethod_9(Skill skill_0, int int_0)
			{
				return true;
			}

			internal static Element smethod_10(Skill skill_0)
			{
				return null;
			}

			private static bool smethod_11(Element element_0, out uint uint_0)
			{
				return true;
			}

			internal static bool smethod_12(byte[] byte_0, uint uint_0, out uint uint_1)
			{
				return true;
			}

			internal static bool smethod_13()
			{
				return true;
			}

			internal static SkillGemPanelUi smethod_14()
			{
				return null;
			}

			static SkillGemPanelUi()
			{
				Class200.smethod_34();
			}
		}

		public static class SkillsUi
		{
			public enum smethod_WildeResult
			{
				None,
				PassiveMapFileNotLoaded,
				IdNotFoundInPassiveMapFile,
				UnableToPlaceTheMouseOverTheNode,
				PassivemapIsNull,
				ConditionError
			}

			public enum AttributeEnum
			{
				Strength,
				Dexterity,
				Intelligence
			}

			public static class AscendencyUi
			{
				private static AscendencyUi ascendencyUi_0;

				public static long IntPtr_AscendUi => 0L;

				public static bool IsOpened => true;

				public static ChoosePassiveError ChooseAscendancyPassive(ushort id)
				{
					return (ChoosePassiveError)(object)null;
				}

				public static RefundPassiveError RefundAscendancyPassive(ushort id)
				{
					return (RefundPassiveError)(object)null;
				}

				internal static bool smethod_0()
				{
					return true;
				}

				internal static AscendencyUi smethod_1()
				{
					return null;
				}

				static AscendencyUi()
				{
					Class200.smethod_34();
				}
			}

			private static EventHandler<PassiveDumpEventArgs> eventHandler_0;

			internal static SkillsUi skillsUi_0;

			public static long IntPtr_TreeMap => 0L;

			public static long IntPtr_ApplyButton => 0L;

			public static Dictionary<int, long> Dictionary_Passive => null;

			public static Dictionary<int, long> Dictionary_Ascend => null;

			public static bool IsOpened => true;

			public static bool IsApplyEnabled => true;

			public static bool IsApplyVisible => true;

			public static bool IsCancelEnabled => true;

			public static bool IsCancelVisible => true;

			public static bool IsRefundPassivesEnabled => true;

			public static Element ResetAllPassivesElement => null;

			public static bool IsResetAllPassiveEnabled => true;

			public static event EventHandler<PassiveDumpEventArgs> OnPassiveDump
			{
				add
				{
				}
				remove
				{
				}
			}

			[SpecialName]
			private static long smethod_0()
			{
				return 0L;
			}

			public static PassiveAllocationActionError ResetAllPassives()
			{
				return (PassiveAllocationActionError)(object)null;
			}

			public static bool IsAllocated(ushort id)
			{
				return true;
			}

			public static bool CanBeAllocate(ushort id)
			{
				return true;
			}

			public static bool CanBeRemoved(ushort id)
			{
				return true;
			}

			public static long GetPassivePtr(ushort id)
			{
				return 0L;
			}

			public static bool IsAscendPassive(ushort id)
			{
				return true;
			}

			public static ChoosePassiveError ChoosePassive(ushort id, AttributeEnum attribute = AttributeEnum.Strength)
			{
				return (ChoosePassiveError)(object)null;
			}

			public static SocketPassiveGemError SocketPassiveGem(ushort id, Func<bool> condition)
			{
				return (SocketPassiveGemError)(object)null;
			}

			public static PassiveAllocationActionError ConfirmOperation()
			{
				return (PassiveAllocationActionError)(object)null;
			}

			public static void DumpPassive(DatPassiveSkillWrapper datPassiveSkillWrapper)
			{
			}

			public static RefundPassiveError RefundPassive(ushort id)
			{
				return (RefundPassiveError)(object)null;
			}

			public static DatPassiveSkillWrapper PassiveDumpEventFunction(long intptr)
			{
				return null;
			}

			internal static bool smethod_1(string string_0)
			{
				return true;
			}

			internal static DatPassiveSkillWrapper smethod_2(int int_0)
			{
				return null;
			}

			internal static Item smethod_3(ushort ushort_0)
			{
				return null;
			}

			internal static smethod_WildeResult smethod_4(long long_0, ushort ushort_0, Func<bool> func_0)
			{
				return (smethod_WildeResult)(object)null;
			}

			private static string smethod_5(DatPassiveSkillMasteryEffectsWrapper datPassiveSkillMasteryEffectsWrapper_0)
			{
				return null;
			}

			private static DreamPoeBot.Common.Vector2 smethod_6(long long_0)
			{
				return (DreamPoeBot.Common.Vector2)(object)null;
			}

			private static smethod_WildeResult smethod_7(long long_0, ushort ushort_0)
			{
				return (smethod_WildeResult)(object)null;
			}

			private static bool smethod_8(long long_0)
			{
				return true;
			}

			private static bool smethod_9(long long_0)
			{
				return true;
			}

			private static bool smethod_10(long long_0)
			{
				return true;
			}

			internal static bool smethod_11()
			{
				return true;
			}

			internal static SkillsUi smethod_12()
			{
				return null;
			}

			static SkillsUi()
			{
				Class200.smethod_34();
			}
		}

		public static class SocialUi
		{
			private static readonly DockedWindowControlWrapper dockedWindowControlWrapper_0;

			private static SocialUi socialUi_0;

			public static bool IsOpened => true;

			public static bool IsFriendsTabSelected => true;

			public static bool IsGuildTabSelected => true;

			public static bool IsPartyTabSelected => true;

			public static bool IsPublicPartiesTabSelected => true;

			public static TabControlWrapper TabControl => null;

			public static DockedWindowControlWrapper WindowControl => null;

			[SpecialName]
			internal static long smethod_0()
			{
				return 0L;
			}

			[SpecialName]
			internal static long smethod_1()
			{
				return 0L;
			}

			public static HandlePendingPartyInviteResut HandlePendingPartyInvite(ProcessNotification func, bool actuallyHandle = true)
			{
				return (HandlePendingPartyInviteResut)(object)null;
			}

			public static HandlePendingPartyInviteResut HandlePendingPartyInviteNew(string charNameToAccept, bool actuallyHandle = true)
			{
				return (HandlePendingPartyInviteResut)(object)null;
			}

			public static InviteToPartyResult InviteToParty(string name, bool actuallyInvite = true)
			{
				return (InviteToPartyResult)(object)null;
			}

			public static LeaveCurrentPartyResult LeaveCurrentParty(bool actuallyLeave = true)
			{
				return (LeaveCurrentPartyResult)(object)null;
			}

			public static SwitchToTabResult SwitchToFriendsTab()
			{
				return (SwitchToTabResult)(object)null;
			}

			public static SwitchToTabResult SwitchToGuildTab()
			{
				return (SwitchToTabResult)(object)null;
			}

			public static SwitchToTabResult SwitchToPartyTab()
			{
				return (SwitchToTabResult)(object)null;
			}

			public static SwitchToTabResult SwitchToPublicPartiesTab()
			{
				return (SwitchToTabResult)(object)null;
			}

			public static ChangeLevelDownscalingResult ChangeLevelDownscaling(bool enable)
			{
				return (ChangeLevelDownscalingResult)(object)null;
			}

			static SocialUi()
			{
				Class200.smethod_34();
				Class204.smethod_0();
				dockedWindowControlWrapper_0 = new DockedWindowControlWrapper(0L);
			}

			internal static bool smethod_2()
			{
				return true;
			}

			internal static SocialUi smethod_3()
			{
				return null;
			}
		}

		public static class SplitStackUi
		{
			private static SplitStackUi splitStackUi_0;

			public static bool IsOpened => true;

			public static int RemainingQuantity => 0;

			public static int SplitQuantity => 0;

			public static SplitResult Accept(bool actuallyAccept = true)
			{
				return (SplitResult)(object)null;
			}

			public static SplitResult Cancel(bool actuallyCancel = true)
			{
				return (SplitResult)(object)null;
			}

			public static SplitResult DecreaseSplitQuantity()
			{
				return (SplitResult)(object)null;
			}

			public static SplitResult IncreaseSplitQuantity()
			{
				return (SplitResult)(object)null;
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static SplitStackUi smethod_1()
			{
				return null;
			}

			static SplitStackUi()
			{
				Class200.smethod_34();
			}
		}

		public static class StashUi
		{
			public static class CurrencyTab
			{
				[CompilerGenerated]
				private sealed class _003Cget_NonCurrency_003Ed__13 : IEnumerable<InventoryControlWrapper>, IEnumerable, IEnumerator<InventoryControlWrapper>, IEnumerator, IDisposable
				{
					private int _003C_003E1__state;

					private InventoryControlWrapper _003C_003E2__current;

					private int _003C_003El__initialThreadId;

					private static _003Cget_NonCurrency_003Ed__13 _003Cget_NonCurrency_003Ed__13_0;

					InventoryControlWrapper IEnumerator<InventoryControlWrapper>.Current => null;

					object IEnumerator.Current => null;

					public _003Cget_NonCurrency_003Ed__13(int _003C_003E1__state)
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

					void IEnumerator.Reset()
					{
					}

					IEnumerator<InventoryControlWrapper> IEnumerable<InventoryControlWrapper>.GetEnumerator()
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

					internal static _003Cget_NonCurrency_003Ed__13 smethod_1()
					{
						return null;
					}

					static _003Cget_NonCurrency_003Ed__13()
					{
						Class200.smethod_34();
					}
				}

				[CompilerGenerated]
				private sealed class _003Cget_OnlyCurrency_003Ed__9 : IEnumerable<InventoryControlWrapper>, IEnumerable, IEnumerator<InventoryControlWrapper>, IEnumerator, IDisposable
				{
					private int _003C_003E1__state;

					private InventoryControlWrapper _003C_003E2__current;

					private int _003C_003El__initialThreadId;

					private Dictionary<string, DreamPoeBot.Loki.FilesInMemory.CurrencyStashTabLayouts.CurrencyStashTabLayoutHardcoded>.ValueCollection.Enumerator _003C_003E7__wrap1;

					private static _003Cget_OnlyCurrency_003Ed__9 _003Cget_OnlyCurrency_003Ed__9_0;

					InventoryControlWrapper IEnumerator<InventoryControlWrapper>.Current => null;

					object IEnumerator.Current => null;

					public _003Cget_OnlyCurrency_003Ed__9(int _003C_003E1__state)
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

					IEnumerator<InventoryControlWrapper> IEnumerable<InventoryControlWrapper>.GetEnumerator()
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

					internal static _003Cget_OnlyCurrency_003Ed__9 smethod_1()
					{
						return null;
					}

					static _003Cget_OnlyCurrency_003Ed__9()
					{
						Class200.smethod_34();
					}
				}

				internal static Dictionary<string, Func<InventoryControlWrapper>> dictionary_0;

				private static Dictionary<string, Func<InventoryControlWrapper>> dictionary_1;

				private static Dictionary<string, Func<InventoryControlWrapper>> dictionary_2;

				internal static CurrencyTab currencyTab_0;

				public static IEnumerable<InventoryControlWrapper> OnlyCurrency
				{
					[IteratorStateMachine(typeof(_003Cget_OnlyCurrency_003Ed__9))]
					get
					{
						return null;
					}
				}

				public static IEnumerable<InventoryControlWrapper> All => null;

				public static IEnumerable<InventoryControlWrapper> NonCurrency
				{
					[IteratorStateMachine(typeof(_003Cget_NonCurrency_003Ed__13))]
					get
					{
						return null;
					}
				}

				public static InventoryControlWrapper OrbOfTransmutation => null;

				public static InventoryControlWrapper GreaterOrbOfTransmutation => null;

				public static InventoryControlWrapper PerfectOrbOfTransmutation => null;

				public static InventoryControlWrapper OrbOfAugmentation => null;

				public static InventoryControlWrapper GreaterOrbOfAugmentation => null;

				public static InventoryControlWrapper PerfectOrbOfAugmentation => null;

				public static InventoryControlWrapper OrbOfAlchemy => null;

				public static InventoryControlWrapper RegalOrb => null;

				public static InventoryControlWrapper GreaterRegalOrb => null;

				public static InventoryControlWrapper PerfectRegalOrb => null;

				public static InventoryControlWrapper ChaosOrb => null;

				public static InventoryControlWrapper GreaterChaosOrb => null;

				public static InventoryControlWrapper PerfectChaosOrb => null;

				public static InventoryControlWrapper ExaltedOrb => null;

				public static InventoryControlWrapper GreaterExaltedOrb => null;

				public static InventoryControlWrapper PerfectExaltedOrb => null;

				public static InventoryControlWrapper VaalOrb => null;

				public static InventoryControlWrapper DivineOrb => null;

				public static InventoryControlWrapper HinekorasLock => null;

				public static InventoryControlWrapper OrbOfAnnulment => null;

				public static InventoryControlWrapper OrbOfChance => null;

				public static InventoryControlWrapper MirrorOfKalandra => null;

				public static InventoryControlWrapper ArcanistsEtcher => null;

				public static InventoryControlWrapper ArmourersScrap => null;

				public static InventoryControlWrapper BlacksmithsWhetstone => null;

				public static InventoryControlWrapper LesserJewellersOrb => null;

				public static InventoryControlWrapper GreaterJewellersOrb => null;

				public static InventoryControlWrapper PerfectJewellersOrb => null;

				public static InventoryControlWrapper ArtificersOrb => null;

				public static InventoryControlWrapper ScrollOfWisdom => null;

				public static InventoryControlWrapper GemcuttersPrism => null;

				public static InventoryControlWrapper GlassblowersBauble => null;

				public static InventoryControlWrapper ArtificersShard => null;

				public static InventoryControlWrapper TransmutationShard => null;

				public static InventoryControlWrapper RegalShard => null;

				public static InventoryControlWrapper ChanceShard => null;

				public static InventoryControlWrapper FracturingOrb => null;

				public static InventoryControlWrapper CraftingSlot => null;

				public static InventoryControlWrapper Generic1 => null;

				public static InventoryControlWrapper Generic2 => null;

				public static InventoryControlWrapper Generic3 => null;

				public static InventoryControlWrapper Generic4 => null;

				public static InventoryControlWrapper Generic5 => null;

				public static InventoryControlWrapper Generic6 => null;

				public static InventoryControlWrapper Generic7 => null;

				public static InventoryControlWrapper Generic8 => null;

				public static InventoryControlWrapper Generic9 => null;

				public static InventoryControlWrapper Generic10 => null;

				public static InventoryControlWrapper Generic11 => null;

				public static InventoryControlWrapper Generic12 => null;

				public static InventoryControlWrapper Generic13 => null;

				public static InventoryControlWrapper Generic14 => null;

				private static void smethod_0()
				{
				}

				private static InventoryControlWrapper smethod_1(string string_0, bool bool_0 = false)
				{
					return null;
				}

				private static void Load()
				{
				}

				public static InventoryControlWrapper GetByName(string name)
				{
					return null;
				}

				public static InventoryControlWrapper GetByMetadata(string metadata)
				{
					return null;
				}

				[Obsolete("Use GetByMetadata.", false)]
				public static InventoryControlWrapper GetInventoryControlForMetadata(string metadata)
				{
					return null;
				}

				internal static bool smethod_2()
				{
					return true;
				}

				internal static CurrencyTab smethod_3()
				{
					return null;
				}

				static CurrencyTab()
				{
					Class200.smethod_34();
				}
			}

			public static class EssenceTab
			{
				[CompilerGenerated]
				private sealed class _003Cget_NonEssences_003Ed__11 : IEnumerable<InventoryControlWrapper>, IEnumerable, IEnumerator<InventoryControlWrapper>, IEnumerator, IDisposable
				{
					private int _003C_003E1__state;

					private InventoryControlWrapper _003C_003E2__current;

					private int _003C_003El__initialThreadId;

					private static _003Cget_NonEssences_003Ed__11 _003Cget_NonEssences_003Ed__11_0;

					InventoryControlWrapper IEnumerator<InventoryControlWrapper>.Current => null;

					object IEnumerator.Current => null;

					public _003Cget_NonEssences_003Ed__11(int _003C_003E1__state)
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

					void IEnumerator.Reset()
					{
					}

					IEnumerator<InventoryControlWrapper> IEnumerable<InventoryControlWrapper>.GetEnumerator()
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

					internal static _003Cget_NonEssences_003Ed__11 smethod_1()
					{
						return null;
					}

					static _003Cget_NonEssences_003Ed__11()
					{
						Class200.smethod_34();
					}
				}

				[CompilerGenerated]
				private sealed class _003Cget_OnlyEssences_003Ed__9 : IEnumerable<InventoryControlWrapper>, IEnumerable, IEnumerator<InventoryControlWrapper>, IEnumerator, IDisposable
				{
					private int _003C_003E1__state;

					private InventoryControlWrapper _003C_003E2__current;

					private int _003C_003El__initialThreadId;

					private Dictionary<string, DreamPoeBot.Loki.FilesInMemory.EssenceStashTabLayouts.EssenceStashTabLayoutHardcoded>.ValueCollection.Enumerator _003C_003E7__wrap1;

					private static _003Cget_OnlyEssences_003Ed__9 _003Cget_OnlyEssences_003Ed__9_0;

					InventoryControlWrapper IEnumerator<InventoryControlWrapper>.Current => null;

					object IEnumerator.Current => null;

					public _003Cget_OnlyEssences_003Ed__9(int _003C_003E1__state)
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

					IEnumerator<InventoryControlWrapper> IEnumerable<InventoryControlWrapper>.GetEnumerator()
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

					internal static _003Cget_OnlyEssences_003Ed__9 smethod_1()
					{
						return null;
					}

					static _003Cget_OnlyEssences_003Ed__9()
					{
						Class200.smethod_34();
					}
				}

				private static Dictionary<string, Func<InventoryControlWrapper>> dictionary_0;

				private static Dictionary<string, Func<InventoryControlWrapper>> dictionary_1;

				private static EssenceTab essenceTab_0;

				public static IEnumerable<InventoryControlWrapper> All => null;

				public static IEnumerable<InventoryControlWrapper> OnlyEssences
				{
					[IteratorStateMachine(typeof(_003Cget_OnlyEssences_003Ed__9))]
					get
					{
						return null;
					}
				}

				public static IEnumerable<InventoryControlWrapper> NonEssences
				{
					[IteratorStateMachine(typeof(_003Cget_NonEssences_003Ed__11))]
					get
					{
						return null;
					}
				}

				public static InventoryControlWrapper EssenceOfTheBody => null;

				public static InventoryControlWrapper EssenceOfTheMind => null;

				public static InventoryControlWrapper EssenceOfEnhancement => null;

				public static InventoryControlWrapper EssenceOfTorment => null;

				public static InventoryControlWrapper EssenceOfFlames => null;

				public static InventoryControlWrapper EssenceOfIce => null;

				public static InventoryControlWrapper EssenceOfElectricity => null;

				public static InventoryControlWrapper EssenceOfRuin => null;

				public static InventoryControlWrapper EssenceOfBattle => null;

				public static InventoryControlWrapper EssenceOfSorcery => null;

				public static InventoryControlWrapper EssenceOfHaste => null;

				public static InventoryControlWrapper EssenceOfInfinite => null;

				public static InventoryControlWrapper GreaterEssenceOfTheBody => null;

				public static InventoryControlWrapper GreaterEssenceOfTheMind => null;

				public static InventoryControlWrapper GreaterEssenceOfEnhancement => null;

				public static InventoryControlWrapper GreaterEssenceOfTorment => null;

				public static InventoryControlWrapper GreaterEssenceOfFlames => null;

				public static InventoryControlWrapper GreaterEssenceOfIce => null;

				public static InventoryControlWrapper GreaterEssenceOfElectricity => null;

				public static InventoryControlWrapper GreaterEssenceOfRuin => null;

				public static InventoryControlWrapper GreaterEssenceOfBattle => null;

				public static InventoryControlWrapper GreaterEssenceOfSorcery => null;

				public static InventoryControlWrapper GreaterEssenceOfHaste => null;

				public static InventoryControlWrapper GreaterEssenceOfInfinite => null;

				public static InventoryControlWrapper Generic1 => null;

				public static InventoryControlWrapper Generic2 => null;

				public static InventoryControlWrapper Generic3 => null;

				public static InventoryControlWrapper Generic4 => null;

				public static InventoryControlWrapper CraftingSlot => null;

				private static InventoryControlWrapper smethod_0(string string_0)
				{
					return null;
				}

				private static void Load()
				{
				}

				public static InventoryControlWrapper GetByName(string name)
				{
					return null;
				}

				public static InventoryControlWrapper GetByMetadata(string metadata)
				{
					return null;
				}

				public static InventoryControlWrapper GetInventoryControlForMetadata(string metadata)
				{
					return null;
				}

				internal static bool smethod_1()
				{
					return true;
				}

				internal static EssenceTab smethod_2()
				{
					return null;
				}

				static EssenceTab()
				{
					Class200.smethod_34();
				}
			}

			public static class DeliriumTab
			{
				[CompilerGenerated]
				private sealed class _003Cget_AllCurrency_003Ed__9 : IEnumerable<InventoryControlWrapper>, IEnumerable, IEnumerator<InventoryControlWrapper>, IEnumerator, IDisposable
				{
					private int _003C_003E1__state;

					private InventoryControlWrapper _003C_003E2__current;

					private int _003C_003El__initialThreadId;

					private Dictionary<string, DreamPoeBot.Loki.FilesInMemory.DeliriumStashTabLayouts.DeliriumStashTabLayoutHardcoded>.ValueCollection.Enumerator _003C_003E7__wrap1;

					private static _003Cget_AllCurrency_003Ed__9 _003Cget_AllCurrency_003Ed__9_0;

					InventoryControlWrapper IEnumerator<InventoryControlWrapper>.Current => null;

					object IEnumerator.Current => null;

					public _003Cget_AllCurrency_003Ed__9(int _003C_003E1__state)
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

					IEnumerator<InventoryControlWrapper> IEnumerable<InventoryControlWrapper>.GetEnumerator()
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

					internal static _003Cget_AllCurrency_003Ed__9 smethod_1()
					{
						return null;
					}

					static _003Cget_AllCurrency_003Ed__9()
					{
						Class200.smethod_34();
					}
				}

				private static Dictionary<string, Func<InventoryControlWrapper>> dictionary_0;

				private static Dictionary<string, Func<InventoryControlWrapper>> dictionary_1;

				internal static DeliriumTab deliriumTab_0;

				public static IEnumerable<InventoryControlWrapper> All => null;

				public static IEnumerable<InventoryControlWrapper> AllCurrency
				{
					[IteratorStateMachine(typeof(_003Cget_AllCurrency_003Ed__9))]
					get
					{
						return null;
					}
				}

				[Obsolete("Not in POE2", false)]
				public static List<InventoryControlWrapper> Maps => null;

				public static InventoryControlWrapper SimulacrumSplinter => null;

				public static InventoryControlWrapper Simulacrum => null;

				private static InventoryControlWrapper smethod_0(string string_0)
				{
					return null;
				}

				private static void Load()
				{
				}

				public static InventoryControlWrapper GetByName(string name)
				{
					return null;
				}

				public static InventoryControlWrapper GetByMetadata(string metadata)
				{
					return null;
				}

				internal static bool smethod_1()
				{
					return true;
				}

				internal static DeliriumTab smethod_2()
				{
					return null;
				}

				static DeliriumTab()
				{
					Class200.smethod_34();
				}
			}

			public static class RitualTab
			{
				[CompilerGenerated]
				private sealed class _003Cget_All_003Ed__7 : IEnumerable<InventoryControlWrapper>, IEnumerable, IEnumerator<InventoryControlWrapper>, IEnumerator, IDisposable
				{
					private int _003C_003E1__state;

					private InventoryControlWrapper _003C_003E2__current;

					private int _003C_003El__initialThreadId;

					private Dictionary<string, DreamPoeBot.Loki.FilesInMemory.RitualStashTabLayouts.RitualStashTabLayoutHardcoded>.ValueCollection.Enumerator _003C_003E7__wrap1;

					internal static _003Cget_All_003Ed__7 _003Cget_All_003Ed__7_0;

					InventoryControlWrapper IEnumerator<InventoryControlWrapper>.Current => null;

					object IEnumerator.Current => null;

					public _003Cget_All_003Ed__7(int _003C_003E1__state)
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

					IEnumerator<InventoryControlWrapper> IEnumerable<InventoryControlWrapper>.GetEnumerator()
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

					internal static _003Cget_All_003Ed__7 smethod_1()
					{
						return null;
					}

					static _003Cget_All_003Ed__7()
					{
						Class200.smethod_34();
					}
				}

				private static Dictionary<string, Func<InventoryControlWrapper>> dictionary_0;

				private static Dictionary<string, Func<InventoryControlWrapper>> dictionary_1;

				private static RitualTab ritualTab_0;

				public static IEnumerable<InventoryControlWrapper> All
				{
					[IteratorStateMachine(typeof(_003Cget_All_003Ed__7))]
					get
					{
						return null;
					}
				}

				public static InventoryControlWrapper PepitionSplinter => null;

				public static InventoryControlWrapper OmenofHomogenisingCoronation => null;

				public static InventoryControlWrapper OmenofGambling => null;

				public static InventoryControlWrapper OmenofBartering => null;

				public static InventoryControlWrapper OmenofCorruption => null;

				public static InventoryControlWrapper OmenofSinistralExaltation => null;

				public static InventoryControlWrapper OmenofDextralExaltation => null;

				public static InventoryControlWrapper OmenofGreaterExaltation => null;

				public static InventoryControlWrapper OmenofSinistralErasure => null;

				public static InventoryControlWrapper OmenofDextralErasure => null;

				public static InventoryControlWrapper OmenofWhittling => null;

				public static InventoryControlWrapper OmenofHomogenisingExaltation => null;

				public static InventoryControlWrapper OmenofCatalysingExaltation => null;

				public static InventoryControlWrapper OmenofChaoticRarity => null;

				public static InventoryControlWrapper OmenofChaoticQuantity => null;

				public static InventoryControlWrapper OmenofChaoticMonsters => null;

				public static InventoryControlWrapper OmenofSinistralAnnulment => null;

				public static InventoryControlWrapper OmenofDextralAnnulment => null;

				public static InventoryControlWrapper OmenofChance => null;

				public static InventoryControlWrapper OmenoftheAncients => null;

				public static InventoryControlWrapper OmenoftheBlessed => null;

				public static InventoryControlWrapper OmenofSanctification => null;

				public static InventoryControlWrapper OmenofDextralCrystallisation => null;

				public static InventoryControlWrapper OmenofSinistralCrystallisation => null;

				public static InventoryControlWrapper OmenofRecombination => null;

				public static InventoryControlWrapper OmenofResurgence => null;

				public static InventoryControlWrapper OmenofAmelioration => null;

				public static InventoryControlWrapper OmenofRefreshment => null;

				public static InventoryControlWrapper OmenoftheHunt => null;

				public static InventoryControlWrapper OmenofAnsweredPrayers => null;

				public static InventoryControlWrapper OmenofSecretCompartments => null;

				public static InventoryControlWrapper OmenofReinforcements => null;

				private static InventoryControlWrapper smethod_0(string string_0)
				{
					return null;
				}

				private static void Load()
				{
				}

				public static InventoryControlWrapper GetByName(string name)
				{
					return null;
				}

				public static InventoryControlWrapper GetByMetadata(string metadata)
				{
					return null;
				}

				public static InventoryControlWrapper GetInventoryControlForMetadata(string metadata)
				{
					return null;
				}

				internal static bool smethod_1()
				{
					return true;
				}

				internal static RitualTab smethod_2()
				{
					return null;
				}

				static RitualTab()
				{
					Class200.smethod_34();
				}
			}

			public static class FragmentTab
			{
				public enum FragmentTabCategory : byte
				{
					Fragments = 0,
					Tablets = 1,
					Trials = 2,
					Unknown = byte.MaxValue
				}

				public static class Tablets
				{
					public enum TabletEnum : byte
					{
						TabletsPrecursor = 0,
						TabletsRitual = 1,
						TabletsExpedition = 2,
						TabletsDelirium = 3,
						TabletsBreach = 4,
						TabletsAbyss = 5,
						TabletsIncursion = 6,
						TabletsBoss = 7,
						TabletsUnique = 8,
						TabletsUnknown = byte.MaxValue
					}

					internal static Tablets tablets_0;

					public static InventoryControlWrapper InventoryControl => null;

					public static TabControlWrapper TabControl => null;

					public static bool SelectSubCategory(TabletEnum category)
					{
						return true;
					}

					public static TabletEnum SelectedSubCategory()
					{
						return (TabletEnum)(object)null;
					}

					public static int GetCountPerSubCategory(TabletEnum category)
					{
						return 0;
					}

					internal static bool smethod_0()
					{
						return true;
					}

					internal static Tablets smethod_1()
					{
						return null;
					}

					static Tablets()
					{
						Class200.smethod_34();
					}
				}

				public static class Trials
				{
					public enum TrialsEnum : byte
					{
						TrialsSekhemas = 0,
						TrialsChaos = 1,
						TabletsUnknown = byte.MaxValue
					}

					private static Trials trials_0;

					public static InventoryControlWrapper InventoryControl => null;

					public static TabControlWrapper TabControl => null;

					public static bool SelectSubCategory(TrialsEnum category)
					{
						return true;
					}

					public static TrialsEnum SelectedSubCategory()
					{
						return (TrialsEnum)(object)null;
					}

					public static int GetCountPerSubCategory(TrialsEnum category)
					{
						return 0;
					}

					internal static bool smethod_0()
					{
						return true;
					}

					internal static Trials smethod_1()
					{
						return null;
					}

					static Trials()
					{
						Class200.smethod_34();
					}
				}

				private static class Class67
				{
					private static TabControlWrapper tabControlWrapper_0;

					internal static Class67 class67_0;

					[SpecialName]
					internal static InventoryControlWrapper smethod_0()
					{
						return null;
					}

					[SpecialName]
					internal static TabControlWrapper smethod_1()
					{
						return null;
					}

					internal static int smethod_2(int int_0, Element element_0)
					{
						return 0;
					}

					internal static void smethod_3(int int_0, Element element_0)
					{
					}

					internal static string smethod_4(long long_0 = 0L)
					{
						return null;
					}

					private static Element smethod_5()
					{
						return null;
					}

					static Class67()
					{
						Class200.smethod_34();
						Class204.smethod_0();
						tabControlWrapper_0 = new TabControlWrapper(0L, TabControlType.SubCategoryTabContainer);
					}

					internal static bool smethod_6()
					{
						return true;
					}

					internal static Class67 smethod_7()
					{
						return null;
					}
				}

				[CompilerGenerated]
				private sealed class _003Cget_Fragments_003Ed__6 : IEnumerable<InventoryControlWrapper>, IEnumerable, IEnumerator<InventoryControlWrapper>, IEnumerator, IDisposable
				{
					private int _003C_003E1__state;

					private InventoryControlWrapper _003C_003E2__current;

					private int _003C_003El__initialThreadId;

					private Dictionary<string, DreamPoeBot.Loki.FilesInMemory.FragmentStashTabLayouts.FragmentStashTabLayoutHardcoded>.ValueCollection.Enumerator _003C_003E7__wrap1;

					private static _003Cget_Fragments_003Ed__6 _003Cget_Fragments_003Ed__6_0;

					InventoryControlWrapper IEnumerator<InventoryControlWrapper>.Current => null;

					object IEnumerator.Current => null;

					public _003Cget_Fragments_003Ed__6(int _003C_003E1__state)
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

					IEnumerator<InventoryControlWrapper> IEnumerable<InventoryControlWrapper>.GetEnumerator()
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

					internal static _003Cget_Fragments_003Ed__6 smethod_1()
					{
						return null;
					}

					static _003Cget_Fragments_003Ed__6()
					{
						Class200.smethod_34();
					}
				}

				private static Dictionary<string, Func<InventoryControlWrapper>> dictionary_0;

				private static Dictionary<string, Func<InventoryControlWrapper>> dictionary_1;

				internal static FragmentTab fragmentTab_0;

				public static IEnumerable<InventoryControlWrapper> Fragments
				{
					[IteratorStateMachine(typeof(_003Cget_Fragments_003Ed__6))]
					get
					{
						return null;
					}
				}

				public static IEnumerable<InventoryControlWrapper> All => null;

				private static void Load()
				{
				}

				public static InventoryControlWrapper GetByName(string name)
				{
					return null;
				}

				public static InventoryControlWrapper GetByMetadata(string metadata)
				{
					return null;
				}

				private static InventoryControlWrapper smethod_0(string string_0, FragmentTabCategory fragmentTabCategory_0)
				{
					return null;
				}

				private static bool smethod_1(FragmentTabCategory fragmentTabCategory_0, Element element_0)
				{
					return true;
				}

				private static FragmentTabCategory smethod_2(long long_0)
				{
					return (FragmentTabCategory)(object)null;
				}

				public static FragmentStashPage ReadCurrentPage()
				{
					return null;
				}

				internal static bool smethod_3()
				{
					return true;
				}

				internal static FragmentTab smethod_4()
				{
					return null;
				}

				static FragmentTab()
				{
					Class200.smethod_34();
				}
			}

			public static class MapsTab
			{
				public enum SelectMapResult
				{
					None,
					InvalidControl,
					FailedToScroll,
					MapListNotLoaded
				}

				public enum SelectTierResult
				{
					None,
					InvalidTier,
					InvalidControl,
					TierListNotLoaded,
					SelectionNotConfirmed
				}

				public class MapInfo
				{
					[CompilerGenerated]
					private string string_0;

					[CompilerGenerated]
					private int int_0;

					[CompilerGenerated]
					private bool bool_0;

					internal static MapInfo mapInfo_0;

					public string Name
					{
						[CompilerGenerated]
						get
						{
							return null;
						}
						[CompilerGenerated]
						set
						{
						}
					}

					public int MapsCount
					{
						[CompilerGenerated]
						get
						{
							return 0;
						}
						[CompilerGenerated]
						set
						{
						}
					}

					public bool IsWitnessedByTheMaven
					{
						[CompilerGenerated]
						get
						{
							return true;
						}
						[CompilerGenerated]
						set
						{
						}
					}

					internal static bool smethod_0()
					{
						return true;
					}

					internal static MapInfo smethod_1()
					{
						return null;
					}

					static MapInfo()
					{
						Class200.smethod_34();
					}
				}

				private static MapsTab mapsTab_0;

				public static bool IsTierListLoaded => true;

				public static TabControlWrapper TabControl => null;

				public static InventoryControlWrapper InventoryControl => null;

				public static int SelectedTier => 0;

				public static int GetMapsCountPerTier(int tier)
				{
					return 0;
				}

				public static SelectTierResult SelectTier(int tier)
				{
					return (SelectTierResult)(object)null;
				}

				public static MapStashPage ReadCurrentPage()
				{
					return null;
				}

				internal static bool smethod_0()
				{
					return true;
				}

				internal static MapsTab smethod_1()
				{
					return null;
				}

				static MapsTab()
				{
					Class200.smethod_34();
				}
			}

			public static class BreachTab
			{
				public enum BreachTabCategory : byte
				{
					Catalysts = 0,
					Wombgifts = 1,
					Unknown = byte.MaxValue
				}

				public static class Wombgifts
				{
					public enum WombgiftEnum : byte
					{
						CurrencyWombgift = 0,
						AmuletWombgift = 1,
						BeltWombgift = 2,
						RingWombgift = 3,
						BreachstoneWombgift = 4,
						TabletsUnknown = byte.MaxValue
					}

					internal static Wombgifts wombgifts_0;

					public static InventoryControlWrapper InventoryControl => null;

					public static TabControlWrapper TabControl => null;

					public static bool SelectWombgiftCategory(WombgiftEnum category)
					{
						return true;
					}

					public static WombgiftEnum SelectedWombgiftCategory()
					{
						return (WombgiftEnum)(object)null;
					}

					public static int GetCountPerSubCategory(WombgiftEnum category)
					{
						return 0;
					}

					internal static bool smethod_0()
					{
						return true;
					}

					internal static Wombgifts smethod_1()
					{
						return null;
					}

					static Wombgifts()
					{
						Class200.smethod_34();
					}
				}

				private static class Class68
				{
					private static TabControlWrapper tabControlWrapper_0;

					internal static Class68 class68_0;

					[SpecialName]
					internal static InventoryControlWrapper smethod_0()
					{
						return null;
					}

					[SpecialName]
					public static TabControlWrapper smethod_1()
					{
						return null;
					}

					internal static int smethod_2(int int_0, Element element_0)
					{
						return 0;
					}

					internal static void smethod_3(int int_0, Element element_0)
					{
					}

					internal static string smethod_4(long long_0 = 0L)
					{
						return null;
					}

					private static Element smethod_5()
					{
						return null;
					}

					static Class68()
					{
						Class200.smethod_34();
						Class204.smethod_0();
						tabControlWrapper_0 = new TabControlWrapper(0L, TabControlType.SubCategoryTabContainer);
					}

					internal static bool smethod_6()
					{
						return true;
					}

					internal static Class68 smethod_7()
					{
						return null;
					}
				}

				[CompilerGenerated]
				private sealed class _003Cget_Catalysts_003Ed__6 : IEnumerable<InventoryControlWrapper>, IEnumerable, IEnumerator<InventoryControlWrapper>, IEnumerator, IDisposable
				{
					private int _003C_003E1__state;

					private InventoryControlWrapper _003C_003E2__current;

					private int _003C_003El__initialThreadId;

					private Dictionary<string, DreamPoeBot.Loki.FilesInMemory.BreachStashTabLayout.BreachStashTabLayoutHardcoded>.ValueCollection.Enumerator _003C_003E7__wrap1;

					internal static _003Cget_Catalysts_003Ed__6 _003Cget_Catalysts_003Ed__6_0;

					InventoryControlWrapper IEnumerator<InventoryControlWrapper>.Current => null;

					object IEnumerator.Current => null;

					public _003Cget_Catalysts_003Ed__6(int _003C_003E1__state)
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

					IEnumerator<InventoryControlWrapper> IEnumerable<InventoryControlWrapper>.GetEnumerator()
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

					internal static _003Cget_Catalysts_003Ed__6 smethod_1()
					{
						return null;
					}

					static _003Cget_Catalysts_003Ed__6()
					{
						Class200.smethod_34();
					}
				}

				private static Dictionary<string, Func<InventoryControlWrapper>> dictionary_0;

				private static Dictionary<string, Func<InventoryControlWrapper>> dictionary_1;

				private static BreachTab breachTab_0;

				public static IEnumerable<InventoryControlWrapper> Catalysts
				{
					[IteratorStateMachine(typeof(_003Cget_Catalysts_003Ed__6))]
					get
					{
						return null;
					}
				}

				public static IEnumerable<InventoryControlWrapper> All => null;

				private static void Load()
				{
				}

				public static InventoryControlWrapper GetByName(string name)
				{
					return null;
				}

				public static InventoryControlWrapper GetByMetadata(string metadata)
				{
					return null;
				}

				private static InventoryControlWrapper smethod_0(string string_0, BreachTabCategory breachTabCategory_0)
				{
					return null;
				}

				private static bool smethod_1(BreachTabCategory breachTabCategory_0, Element element_0)
				{
					return true;
				}

				private static BreachTabCategory smethod_2(long long_0)
				{
					return (BreachTabCategory)(object)null;
				}

				internal static bool smethod_3()
				{
					return true;
				}

				internal static BreachTab smethod_4()
				{
					return null;
				}

				static BreachTab()
				{
					Class200.smethod_34();
				}
			}

			public static class AbyssTab
			{
				[CompilerGenerated]
				private sealed class _003Cget_All_003Ed__7 : IEnumerable<InventoryControlWrapper>, IEnumerable, IEnumerator<InventoryControlWrapper>, IEnumerator, IDisposable
				{
					private int _003C_003E1__state;

					private InventoryControlWrapper _003C_003E2__current;

					private int _003C_003El__initialThreadId;

					private Dictionary<string, DreamPoeBot.Loki.FilesInMemory.AbyssStashTabLayout.AbyssStashTabLayoutHardcoded>.ValueCollection.Enumerator _003C_003E7__wrap1;

					internal static _003Cget_All_003Ed__7 _003Cget_All_003Ed__7_0;

					InventoryControlWrapper IEnumerator<InventoryControlWrapper>.Current => null;

					object IEnumerator.Current => null;

					public _003Cget_All_003Ed__7(int _003C_003E1__state)
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

					IEnumerator<InventoryControlWrapper> IEnumerable<InventoryControlWrapper>.GetEnumerator()
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

					internal static _003Cget_All_003Ed__7 smethod_1()
					{
						return null;
					}

					static _003Cget_All_003Ed__7()
					{
						Class200.smethod_34();
					}
				}

				private static Dictionary<string, Func<InventoryControlWrapper>> dictionary_0;

				private static Dictionary<string, Func<InventoryControlWrapper>> dictionary_1;

				internal static AbyssTab abyssTab_0;

				public static IEnumerable<InventoryControlWrapper> All
				{
					[IteratorStateMachine(typeof(_003Cget_All_003Ed__7))]
					get
					{
						return null;
					}
				}

				private static InventoryControlWrapper smethod_0(string string_0)
				{
					return null;
				}

				private static void Load()
				{
				}

				public static InventoryControlWrapper GetByName(string name)
				{
					return null;
				}

				public static InventoryControlWrapper GetByMetadata(string metadata)
				{
					return null;
				}

				internal static bool smethod_1()
				{
					return true;
				}

				internal static AbyssTab smethod_2()
				{
					return null;
				}

				static AbyssTab()
				{
					Class200.smethod_34();
				}
			}

			public static class ExpeditionTab
			{
				[CompilerGenerated]
				private sealed class _003Cget_All_003Ed__7 : IEnumerable<InventoryControlWrapper>, IEnumerable, IEnumerator<InventoryControlWrapper>, IEnumerator, IDisposable
				{
					private int _003C_003E1__state;

					private InventoryControlWrapper _003C_003E2__current;

					private int _003C_003El__initialThreadId;

					private Dictionary<string, DreamPoeBot.Loki.FilesInMemory.ExpeditionStashTabLayout.ExpeditionStashTabLayoutHardcoded>.ValueCollection.Enumerator _003C_003E7__wrap1;

					private static _003Cget_All_003Ed__7 _003Cget_All_003Ed__7_0;

					InventoryControlWrapper IEnumerator<InventoryControlWrapper>.Current => null;

					object IEnumerator.Current => null;

					public _003Cget_All_003Ed__7(int _003C_003E1__state)
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

					IEnumerator<InventoryControlWrapper> IEnumerable<InventoryControlWrapper>.GetEnumerator()
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

					internal static _003Cget_All_003Ed__7 smethod_1()
					{
						return null;
					}

					static _003Cget_All_003Ed__7()
					{
						Class200.smethod_34();
					}
				}

				private static Dictionary<string, Func<InventoryControlWrapper>> dictionary_0;

				private static Dictionary<string, Func<InventoryControlWrapper>> dictionary_1;

				internal static ExpeditionTab expeditionTab_0;

				public static IEnumerable<InventoryControlWrapper> All
				{
					[IteratorStateMachine(typeof(_003Cget_All_003Ed__7))]
					get
					{
						return null;
					}
				}

				private static InventoryControlWrapper smethod_0(string string_0)
				{
					return null;
				}

				private static void Load()
				{
				}

				public static InventoryControlWrapper GetByName(string name)
				{
					return null;
				}

				public static InventoryControlWrapper GetByMetadata(string metadata)
				{
					return null;
				}

				internal static bool smethod_1()
				{
					return true;
				}

				internal static ExpeditionTab smethod_2()
				{
					return null;
				}

				static ExpeditionTab()
				{
					Class200.smethod_34();
				}
			}

			public static class SocketableTab
			{
				private enum Enum8 : byte
				{

				}

				[CompilerGenerated]
				private sealed class _003Cget_AncientAugments_003Ed__15 : IEnumerable<InventoryControlWrapper>, IEnumerable, IEnumerator<InventoryControlWrapper>, IEnumerator, IDisposable
				{
					private int _003C_003E1__state;

					private InventoryControlWrapper _003C_003E2__current;

					private int _003C_003El__initialThreadId;

					private Dictionary<string, DreamPoeBot.Loki.FilesInMemory.SocketableStashTabLayout.SocketableStashTabLayoutHardcoded>.ValueCollection.Enumerator _003C_003E7__wrap1;

					private static _003Cget_AncientAugments_003Ed__15 _003Cget_AncientAugments_003Ed__15_0;

					InventoryControlWrapper IEnumerator<InventoryControlWrapper>.Current => null;

					object IEnumerator.Current => null;

					public _003Cget_AncientAugments_003Ed__15(int _003C_003E1__state)
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

					IEnumerator<InventoryControlWrapper> IEnumerable<InventoryControlWrapper>.GetEnumerator()
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

					internal static _003Cget_AncientAugments_003Ed__15 smethod_1()
					{
						return null;
					}

					static _003Cget_AncientAugments_003Ed__15()
					{
						Class200.smethod_34();
					}
				}

				[CompilerGenerated]
				private sealed class _003Cget_Idols_003Ed__13 : IEnumerable<InventoryControlWrapper>, IEnumerable, IEnumerator<InventoryControlWrapper>, IEnumerator, IDisposable
				{
					private int _003C_003E1__state;

					private InventoryControlWrapper _003C_003E2__current;

					private int _003C_003El__initialThreadId;

					private Dictionary<string, DreamPoeBot.Loki.FilesInMemory.SocketableStashTabLayout.SocketableStashTabLayoutHardcoded>.ValueCollection.Enumerator _003C_003E7__wrap1;

					internal static _003Cget_Idols_003Ed__13 _003Cget_Idols_003Ed__13_0;

					InventoryControlWrapper IEnumerator<InventoryControlWrapper>.Current => null;

					object IEnumerator.Current => null;

					public _003Cget_Idols_003Ed__13(int _003C_003E1__state)
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

					IEnumerator<InventoryControlWrapper> IEnumerable<InventoryControlWrapper>.GetEnumerator()
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

					internal static _003Cget_Idols_003Ed__13 smethod_1()
					{
						return null;
					}

					static _003Cget_Idols_003Ed__13()
					{
						Class200.smethod_34();
					}
				}

				[CompilerGenerated]
				private sealed class _003Cget_KalguuranRunes_003Ed__9 : IEnumerable<InventoryControlWrapper>, IEnumerable, IEnumerator<InventoryControlWrapper>, IEnumerator, IDisposable
				{
					private int _003C_003E1__state;

					private InventoryControlWrapper _003C_003E2__current;

					private int _003C_003El__initialThreadId;

					private Dictionary<string, DreamPoeBot.Loki.FilesInMemory.SocketableStashTabLayout.SocketableStashTabLayoutHardcoded>.ValueCollection.Enumerator _003C_003E7__wrap1;

					internal static _003Cget_KalguuranRunes_003Ed__9 _003Cget_KalguuranRunes_003Ed__9_0;

					InventoryControlWrapper IEnumerator<InventoryControlWrapper>.Current => null;

					object IEnumerator.Current => null;

					public _003Cget_KalguuranRunes_003Ed__9(int _003C_003E1__state)
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

					IEnumerator<InventoryControlWrapper> IEnumerable<InventoryControlWrapper>.GetEnumerator()
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

					internal static _003Cget_KalguuranRunes_003Ed__9 smethod_1()
					{
						return null;
					}

					static _003Cget_KalguuranRunes_003Ed__9()
					{
						Class200.smethod_34();
					}
				}

				[CompilerGenerated]
				private sealed class _003Cget_Runes_003Ed__7 : IEnumerable<InventoryControlWrapper>, IEnumerable, IEnumerator<InventoryControlWrapper>, IEnumerator, IDisposable
				{
					private int _003C_003E1__state;

					private InventoryControlWrapper _003C_003E2__current;

					private int _003C_003El__initialThreadId;

					private Dictionary<string, DreamPoeBot.Loki.FilesInMemory.SocketableStashTabLayout.SocketableStashTabLayoutHardcoded>.ValueCollection.Enumerator _003C_003E7__wrap1;

					internal static _003Cget_Runes_003Ed__7 _003Cget_Runes_003Ed__7_0;

					InventoryControlWrapper IEnumerator<InventoryControlWrapper>.Current => null;

					object IEnumerator.Current => null;

					public _003Cget_Runes_003Ed__7(int _003C_003E1__state)
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

					IEnumerator<InventoryControlWrapper> IEnumerable<InventoryControlWrapper>.GetEnumerator()
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

					internal static _003Cget_Runes_003Ed__7 smethod_1()
					{
						return null;
					}

					static _003Cget_Runes_003Ed__7()
					{
						Class200.smethod_34();
					}
				}

				[CompilerGenerated]
				private sealed class _003Cget_SoulCores_003Ed__11 : IEnumerable<InventoryControlWrapper>, IEnumerable, IEnumerator<InventoryControlWrapper>, IEnumerator, IDisposable
				{
					private int _003C_003E1__state;

					private InventoryControlWrapper _003C_003E2__current;

					private int _003C_003El__initialThreadId;

					private Dictionary<string, DreamPoeBot.Loki.FilesInMemory.SocketableStashTabLayout.SocketableStashTabLayoutHardcoded>.ValueCollection.Enumerator _003C_003E7__wrap1;

					internal static _003Cget_SoulCores_003Ed__11 _003Cget_SoulCores_003Ed__11_0;

					InventoryControlWrapper IEnumerator<InventoryControlWrapper>.Current => null;

					object IEnumerator.Current => null;

					public _003Cget_SoulCores_003Ed__11(int _003C_003E1__state)
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

					IEnumerator<InventoryControlWrapper> IEnumerable<InventoryControlWrapper>.GetEnumerator()
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

					internal static _003Cget_SoulCores_003Ed__11 smethod_1()
					{
						return null;
					}

					static _003Cget_SoulCores_003Ed__11()
					{
						Class200.smethod_34();
					}
				}

				private static Dictionary<string, Func<InventoryControlWrapper>> dictionary_0;

				private static Dictionary<string, Func<InventoryControlWrapper>> dictionary_1;

				internal static SocketableTab socketableTab_0;

				public static IEnumerable<InventoryControlWrapper> Runes
				{
					[IteratorStateMachine(typeof(_003Cget_Runes_003Ed__7))]
					get
					{
						return null;
					}
				}

				public static IEnumerable<InventoryControlWrapper> KalguuranRunes
				{
					[IteratorStateMachine(typeof(_003Cget_KalguuranRunes_003Ed__9))]
					get
					{
						return null;
					}
				}

				public static IEnumerable<InventoryControlWrapper> SoulCores
				{
					[IteratorStateMachine(typeof(_003Cget_SoulCores_003Ed__11))]
					get
					{
						return null;
					}
				}

				public static IEnumerable<InventoryControlWrapper> Idols
				{
					[IteratorStateMachine(typeof(_003Cget_Idols_003Ed__13))]
					get
					{
						return null;
					}
				}

				public static IEnumerable<InventoryControlWrapper> AncientAugments
				{
					[IteratorStateMachine(typeof(_003Cget_AncientAugments_003Ed__15))]
					get
					{
						return null;
					}
				}

				public static IEnumerable<InventoryControlWrapper> All => null;

				private static InventoryControlWrapper smethod_0(string string_0, byte byte_0)
				{
					return null;
				}

				private static void Load()
				{
				}

				public static InventoryControlWrapper GetByName(string name)
				{
					return null;
				}

				public static InventoryControlWrapper GetByMetadata(string metadata)
				{
					return null;
				}

				private static bool smethod_1(Enum8 enum8_0, Element element_0)
				{
					return true;
				}

				private static Enum8 smethod_2(Element element_0)
				{
					return (Enum8)(object)null;
				}

				internal static bool smethod_3()
				{
					return true;
				}

				internal static SocketableTab smethod_4()
				{
					return null;
				}

				static SocketableTab()
				{
					Class200.smethod_34();
				}
			}

			[StructLayout(LayoutKind.Sequential, Pack = 1)]
			internal struct Struct67
			{
				private long long_0;

				private ushort ushort_0;

				public ushort ushort_1;

				private ushort ushort_2;

				private ushort ushort_3;

				public GStruct2 gstruct2_0;

				private int int_0;

				private int int_1;

				private ushort ushort_4;

				private ushort ushort_5;

				private ushort ushort_6;

				private ushort ushort_7;

				private long long_1;

				private long long_2;

				private long long_3;

				private long long_4;

				private long long_5;

				private long long_6;

				private int int_2;

				private int int_3;

				private long long_7;

				private long long_8;

				private long long_9;

				private long long_10;

				private long long_11;

				private long long_12;

				private long long_13;

				private long long_14;

				private long long_15;

				private long long_16;

				private long long_17;

				private long long_18;

				private long long_19;

				private long long_20;

				private long long_21;

				private long long_22;

				private long long_23;

				private int int_4;

				private int int_5;

				private long long_24;

				private long long_25;
			}

			[StructLayout(LayoutKind.Sequential, Pack = 1)]
			internal struct Struct68
			{
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

				public long long_10;

				private long long_11;

				private long long_12;

				private long long_13;

				private long long_14;

				private long long_15;

				private long long_16;

				private long long_17;

				private long long_18;
			}

			internal static int int_0;

			internal static int int_1;

			internal static TabControlWrapper tabControlWrapper_0;

			internal static StashUi stashUi_0;

			public static bool IsOpened => true;

			public static StashTabInfo StashTabInfo => null;

			public static InventoryControlWrapper InventoryControl => null;

			public static TabControlWrapper TabControl => null;

			public static List<Item> AllItems => null;

			[SpecialName]
			internal static bool smethod_0()
			{
				return true;
			}

			[SpecialName]
			internal static long smethod_1()
			{
				return 0L;
			}

			[SpecialName]
			internal static long smethod_2()
			{
				return 0L;
			}

			[SpecialName]
			internal static List<Struct67> smethod_3()
			{
				return null;
			}

			[SpecialName]
			internal static Struct68 smethod_4()
			{
				return (Struct68)(object)null;
			}

			[SpecialName]
			internal static Element smethod_5()
			{
				return null;
			}

			public static void SetHighlightKeyword(string text)
			{
			}

			internal static InventoryHolder smethod_6(long long_0)
			{
				return null;
			}

			internal static Element smethod_7()
			{
				return null;
			}

			static StashUi()
			{
				Class200.smethod_34();
				Class204.smethod_0();
				int_0 = 1080;
				int_1 = 1648;
				tabControlWrapper_0 = new TabControlWrapper(0L, TabControlType.Stash);
			}

			internal static bool smethod_8()
			{
				return true;
			}

			internal static StashUi smethod_9()
			{
				return null;
			}
		}

		public static class TempleOfferingUi
		{
			internal static TempleOfferingUi templeOfferingUi_0;

			public static bool IsOpened => true;

			public static Item TempleOfferingItem => null;

			public static TempleOfferingOpenResult Open()
			{
				return (TempleOfferingOpenResult)(object)null;
			}

			public static RemoveTempleOfferingItemResult FastRemoveTempleOfferingItem()
			{
				return (RemoveTempleOfferingItemResult)(object)null;
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static TempleOfferingUi smethod_1()
			{
				return null;
			}

			static TempleOfferingUi()
			{
				Class200.smethod_34();
			}
		}

		public static class TheGenesisTreeUi
		{
			public class Womb
			{
				private Element TkhpbmjFmAi;

				internal static Womb womb_0;

				public Item Item => null;

				public int ItemLevel => 0;

				public bool CanCraft => true;

				internal Womb(Element element)
				{
				}

				public void Craft()
				{
				}

				public void BeginCraft()
				{
				}

				internal static bool smethod_0()
				{
					return true;
				}

				internal static Womb smethod_1()
				{
					return null;
				}

				static Womb()
				{
					Class200.smethod_34();
				}
			}

			internal static TheGenesisTreeUi theGenesisTreeUi_0;

			public static bool IsOpened => true;

			public static Womb CurrencyWomb => null;

			public static Womb AmuletWomb => null;

			public static Womb BeltWomb => null;

			public static Womb RingWomb => null;

			public static Womb BreachstoneWomb => null;

			internal static bool smethod_0()
			{
				return true;
			}

			internal static TheGenesisTreeUi smethod_1()
			{
				return null;
			}

			static TheGenesisTreeUi()
			{
				Class200.smethod_34();
			}
		}

		public static class TradePriceItemDialogUi
		{
			private static TradePriceItemDialogUi tradePriceItemDialogUi_0;

			public static bool IsOpened => true;

			public static string Price
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public static string SelectedPriceType => null;

			public static void ListItem()
			{
			}

			public static bool SelectPriceCurrency(string priceType)
			{
				return true;
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static TradePriceItemDialogUi smethod_1()
			{
				return null;
			}

			static TradePriceItemDialogUi()
			{
				Class200.smethod_34();
			}
		}

		public static class TradeUi
		{
			internal static TabControlWrapper tabControlWrapper_0;

			private static readonly TradeControlWrapper tradeControlWrapper_0;

			internal static TradeUi tradeUi_0;

			public static bool IsOpened => true;

			public static TradeControlWrapper TradeControl => null;

			public static TabControlWrapper TabControl => null;

			[SpecialName]
			internal static long smethod_0()
			{
				return 0L;
			}

			[SpecialName]
			internal static long smethod_1()
			{
				return 0L;
			}

			[SpecialName]
			internal static StashUi.Struct68 smethod_2()
			{
				return (StashUi.Struct68)(object)null;
			}

			static TradeUi()
			{
				Class200.smethod_34();
				Class204.smethod_0();
				tabControlWrapper_0 = new TabControlWrapper(0L, TabControlType.Trade);
				tradeControlWrapper_0 = new TradeControlWrapper(0L, TradeControlType.Trade);
			}

			internal static bool smethod_3()
			{
				return true;
			}

			internal static TradeUi smethod_4()
			{
				return null;
			}
		}

		public static class TrialOfSeckhemasMapUi
		{
			public enum ActionResult
			{
				None,
				UiNotOpen,
				ControlNotAvailable,
				ProcessHookManagerNotEnabled
			}

			internal static TrialOfSeckhemasMapUi trialOfSeckhemasMapUi_0;

			public static bool IsOpened => true;

			public static string Title => null;

			public static IReadOnlyList<TrialOfSeckhemasRoom> Rooms => null;

			public static int? SacredWater => null;

			public static int? BronzeKeys => null;

			public static int? SilverKeys => null;

			public static int? GoldKeys => null;

			public static IReadOnlyList<string> RelicEffects => null;

			public static bool CanLeave => true;

			public static bool CanEnter => true;

			[SpecialName]
			private static TrialOfSeckhemasMapElement smethod_0()
			{
				return null;
			}

			public static ActionResult SelectRoom(int column, int row)
			{
				return (ActionResult)(object)null;
			}

			public static ActionResult Close()
			{
				return (ActionResult)(object)null;
			}

			public static ActionResult Leave()
			{
				return (ActionResult)(object)null;
			}

			public static ActionResult Enter()
			{
				return (ActionResult)(object)null;
			}

			private static bool Available(Element element)
			{
				return true;
			}

			private static ActionResult smethod_1(Func<TrialOfSeckhemasMapElement, Element> func_0)
			{
				return (ActionResult)(object)null;
			}

			internal static bool smethod_2()
			{
				return true;
			}

			internal static TrialOfSeckhemasMapUi smethod_3()
			{
				return null;
			}

			static TrialOfSeckhemasMapUi()
			{
				Class200.smethod_34();
			}
		}

		public static class TutorialUi
		{
			public static bool IsOpened => true;

			static TutorialUi()
			{
				Class200.smethod_34();
			}
		}

		public static class VaalTempleConsoleUi
		{
			public enum ActionResult
			{
				None,
				UiNotOpen,
				ElementNotAvailable,
				InvalidSelection,
				ProcessHookManagerNotEnabled,
				AlreadyOpen
			}

			public class TempleCard : TempleRoom
			{
				private byte byte_0;

				private static TempleCard templeCard_0;

				public bool Selected => true;

				internal TempleCard(Element templeRoomElement, byte idx)
				{
				}

				public void Select()
				{
				}

				public ActionResult SelectEx()
				{
					return (ActionResult)(object)null;
				}

				[CompilerGenerated]
				private bool method_0()
				{
					return true;
				}

				[CompilerGenerated]
				private bool method_1(Element element_1)
				{
					return true;
				}

				internal static bool smethod_2()
				{
					return true;
				}

				internal static TempleCard smethod_3()
				{
					return null;
				}

				static TempleCard()
				{
					Class200.smethod_34();
				}
			}

			public class TempleMedallion
			{
				private readonly Element element_0;

				private readonly long long_0;

				private readonly int int_0;

				[CompilerGenerated]
				private readonly int int_1;

				internal static TempleMedallion templeMedallion_0;

				public int SlotIndex
				{
					[CompilerGenerated]
					get
					{
						return 0;
					}
				}

				public string Name => null;

				public string Effect => null;

				public bool Selected => true;

				internal TempleMedallion(Element element, int slotIndex, long panelAddress)
				{
				}

				[SpecialName]
				private bool method_0()
				{
					return true;
				}

				public ActionResult SelectEx()
				{
					return (ActionResult)(object)null;
				}

				public ActionResult DiscardEx()
				{
					return (ActionResult)(object)null;
				}

				private bool method_1(out (double, double, double, double) valueTuple_0, out (double, double, double, double) valueTuple_1)
				{
					return true;
				}

				[CompilerGenerated]
				private bool method_2(Element element_1)
				{
					return true;
				}

				[CompilerGenerated]
				private bool method_3()
				{
					return true;
				}

				internal static bool smethod_0()
				{
					return true;
				}

				internal static TempleMedallion smethod_1()
				{
					return null;
				}

				static TempleMedallion()
				{
					Class200.smethod_34();
				}
			}

			public class MapTempleRoom : TempleRoom
			{
				internal static MapTempleRoom mapTempleRoom_0;

				public bool CanPlaceSelectedCard => true;

				public bool CanApplySelectedMedallion => true;

				public bool CanBeUgradeBySelectedRoom => true;

				internal MapTempleRoom(Element templeRoomElement)
				{
				}

				public void Select()
				{
				}

				public ActionResult SelectEx()
				{
					return (ActionResult)(object)null;
				}

				[CompilerGenerated]
				private bool method_0()
				{
					return true;
				}

				[CompilerGenerated]
				private bool method_1(Element element_1)
				{
					return true;
				}

				internal static bool smethod_2()
				{
					return true;
				}

				internal static MapTempleRoom smethod_3()
				{
					return null;
				}

				static MapTempleRoom()
				{
					Class200.smethod_34();
				}
			}

			public class TempleRoom
			{
				internal Element element_0;

				internal static TempleRoom templeRoom_0;

				public string RoomTitle => null;

				public string RoomType => null;

				public string RoomStats => null;

				public string RoomInfo => null;

				public Vector2i Coordinate => (Vector2i)(object)null;

				internal TempleRoom(Element templeRoomElement)
				{
				}

				internal static bool smethod_0()
				{
					return true;
				}

				internal static TempleRoom smethod_1()
				{
					return null;
				}

				static TempleRoom()
				{
					Class200.smethod_34();
				}
			}

			internal static VaalTempleConsoleUi vaalTempleConsoleUi_0;

			public static bool IsOpened => true;

			public static bool IsOpenMapButtonAvailable => true;

			public static int CrystalCount => 0;

			public static int CrystalCapacity => 0;

			public static int MedallionCount => 0;

			public static int MedallionCapacity => 0;

			public static bool IsRunTempleButtonEnabled => true;

			public static string RunTempleButtonText => null;

			public static MapTempleRoom[,] TempleMap => null;

			public static List<TempleCard> TempleCards => null;

			public static List<TempleMedallion> Medallions => null;

			[SpecialName]
			private static TempleConsoleElement smethod_0()
			{
				return null;
			}

			[SpecialName]
			private static Element smethod_1()
			{
				return null;
			}

			public static ActionResult Open()
			{
				return (ActionResult)(object)null;
			}

			private static string smethod_2(Element element_0)
			{
				return null;
			}

			private static int smethod_3(Element element_0, bool bool_0)
			{
				return 0;
			}

			public static void RunTemple()
			{
			}

			public static ActionResult RunTempleEx()
			{
				return (ActionResult)(object)null;
			}

			public static ActionResult Close()
			{
				return (ActionResult)(object)null;
			}

			private static bool Available(Element element)
			{
				return true;
			}

			private static ActionResult smethod_4(Element element_0, Func<bool> func_0 = null, bool bool_0 = true, Vector2i? nullable_0 = null)
			{
				return (ActionResult)(object)null;
			}

			internal static bool smethod_5()
			{
				return true;
			}

			internal static VaalTempleConsoleUi smethod_6()
			{
				return null;
			}

			static VaalTempleConsoleUi()
			{
				Class200.smethod_34();
			}
		}

		public static class VisibleTimersUi
		{
			private static VisibleTimersUi visibleTimersUi_0;

			public static bool IsOpened => true;

			public static TimeSpan Timer => (TimeSpan)(object)null;

			internal static bool smethod_0()
			{
				return true;
			}

			internal static VisibleTimersUi smethod_1()
			{
				return null;
			}

			static VisibleTimersUi()
			{
				Class200.smethod_34();
			}
		}

		public static class WorldUi
		{
			internal enum Enum9
			{

			}

			public enum EndGameRightWaypointType
			{
				TheZigguratRefuge,
				TheBurningMonolith,
				TheOriginTower,
				RuinsofKingsmarch,
				TheWitheredWillow,
				CaerTarth,
				MonasteryOfKeepers,
				VaalRuins,
				WellOfSoul
			}

			public class WaypointDataWrapper
			{
				public readonly bool IsValid;

				public readonly Element _elem;

				public readonly DatWorldAreaWrapper WorldArea;

				internal readonly long long_0;

				internal readonly long long_1;

				internal readonly long long_2;

				internal readonly long long_3;

				internal readonly long long_4;

				internal readonly string string_0;

				private static WaypointDataWrapper waypointDataWrapper_0;

				public bool IsVisible => true;

				public string AreaId => null;

				public Vector2i ClickLocation => (Vector2i)(object)null;

				internal bool method_0(float float_0)
				{
					return true;
				}

				internal WaypointDataWrapper(Element ctrl)
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

				internal static WaypointDataWrapper smethod_1()
				{
					return null;
				}

				static WaypointDataWrapper()
				{
					Class200.smethod_34();
				}
			}

			internal static WorldUi worldUi_0;

			public static bool IsOpened => true;

			public static List<WaypointDataWrapper> Waypoints => null;

			public static List<WaypointDataWrapper> CaravanWaypoints => null;

			public static TakeWaypointResult GoToHideout(bool guild = false)
			{
				return (TakeWaypointResult)(object)null;
			}

			public static TakeWaypointResult GoToTempleOfChaos()
			{
				return (TakeWaypointResult)(object)null;
			}

			public static TakeWaypointResult GoToSekhemaTrial()
			{
				return (TakeWaypointResult)(object)null;
			}

			public static TakeWaypointResult GoToWellOfSoul()
			{
				return (TakeWaypointResult)(object)null;
			}

			public static TakeWaypointResult GoToVaalRuins()
			{
				return (TakeWaypointResult)(object)null;
			}

			public static TakeWaypointResult SwitchAboveBelow()
			{
				return (TakeWaypointResult)(object)null;
			}

			public static SwitchToTabResult SwitchToActMouse(int act, int timeout = 15000)
			{
				return (SwitchToTabResult)(object)null;
			}

			public static TakeWaypointResult TakeWaypoint(string areaId, bool newInstance = false, int maxInstances = -1, bool actuallyTakeWaypoint = true)
			{
				return (TakeWaypointResult)(object)null;
			}

			[Obsolete("On hold till we see where the game go.")]
			public static SwitchToTabResult SwitchToPartMouse(int part)
			{
				return (SwitchToTabResult)(object)null;
			}

			private static void SetZoom(float zoom)
			{
			}

			internal static bool smethod_0(int int_0)
			{
				return true;
			}

			internal static void smethod_1(bool bool_0)
			{
			}

			[SpecialName]
			internal static List<Element> smethod_2()
			{
				return null;
			}

			[SpecialName]
			internal static List<Element> smethod_3()
			{
				return null;
			}

			[SpecialName]
			internal static Dictionary<string, WaypointDataWrapper> smethod_4()
			{
				return null;
			}

			internal static TakeWaypointResult smethod_5(int int_0, bool bool_0 = false, bool bool_1 = false)
			{
				return (TakeWaypointResult)(object)null;
			}

			internal static bool smethod_6()
			{
				return true;
			}

			internal static WorldUi smethod_7()
			{
				return null;
			}

			static WorldUi()
			{
				Class200.smethod_34();
			}
		}

		public static class PartyHud
		{
			internal static PartyHud partyHud_0;

			public static bool IsOpened => true;

			public static OpenContextMenuResult OpenContextMenu(string characterName, bool actuallyOpen = true)
			{
				return (OpenContextMenuResult)(object)null;
			}

			public static bool IsInSameZone(string characterName)
			{
				return true;
			}

			public static FastGoToZoneResult FastGoToZone(string characterName)
			{
				return (FastGoToZoneResult)(object)null;
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static PartyHud smethod_1()
			{
				return null;
			}

			static PartyHud()
			{
				Class200.smethod_34();
			}
		}

		public class PopupManager
		{
			private static PopupManager popupManager_0;

			public static bool IsOpened => true;

			public static void Close()
			{
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static PopupManager smethod_1()
			{
				return null;
			}

			static PopupManager()
			{
				Class200.smethod_34();
			}
		}

		public static class SkillBarHud
		{
			private static SlowCacheValue<Skill> slowCacheValue_0;

			[CompilerGenerated]
			private static bool bool_0;

			internal static SkillBarHud skillBarHud_0;

			public static bool IsSkillSelectorOpen => true;

			public static bool SkillUseLogging
			{
				[CompilerGenerated]
				get
				{
					return true;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public static Skill LastBoundMoveSkill => null;

			public static IEnumerable<Skill> Skills => null;

			public static List<Skill> SkillBarSkills => null;

			public static bool CanUseSlot1 => true;

			public static bool CanUseSlot2 => true;

			public static bool CanUseSlot3 => true;

			public static bool CanUseSlot4 => true;

			public static bool CanUseSlot5 => true;

			public static bool CanUseSlot6 => true;

			public static bool CanUseSlot7 => true;

			public static bool CanUseSlot8 => true;

			public static bool CanUseSlot9 => true;

			public static bool CanUseSlot10 => true;

			public static bool CanUseSlot11 => true;

			public static bool CanUseSlot12 => true;

			public static bool CanUseSlot13 => true;

			public static Skill Slot1 => null;

			public static Skill Slot2 => null;

			public static Skill Slot3 => null;

			public static Skill Slot4 => null;

			public static Skill Slot5 => null;

			public static Skill Slot6 => null;

			public static Skill Slot7 => null;

			public static Skill Slot8 => null;

			public static Skill Slot9 => null;

			public static Skill Slot10 => null;

			public static Skill Slot11 => null;

			public static Skill Slot12 => null;

			public static Skill Slot13 => null;

			public static Element GetElementForSlot(int int_0)
			{
				return null;
			}

			public static Element GetElementForExtraSlot(int int_0)
			{
				return null;
			}

			private static SetSlotResult smethod_0(Element element_0, Skill skill_0, bool bool_1 = false)
			{
				return (SetSlotResult)(object)null;
			}

			private static SetSlotResult smethod_1(Element element_0, bool bool_1 = false)
			{
				return (SetSlotResult)(object)null;
			}

			[SpecialName]
			private static Skill smethod_2()
			{
				return null;
			}

			public static SetSlotResult ClearSlot(int slot)
			{
				return (SetSlotResult)(object)null;
			}

			public static SetSlotResult SetSlot(int slot, Skill skill)
			{
				return (SetSlotResult)(object)null;
			}

			public static SetSlotResult SetSlot1(Skill skill)
			{
				return (SetSlotResult)(object)null;
			}

			public static SetSlotResult SetSlot2(Skill skill)
			{
				return (SetSlotResult)(object)null;
			}

			public static SetSlotResult SetSlot3(Skill skill)
			{
				return (SetSlotResult)(object)null;
			}

			public static SetSlotResult SetSlot4(Skill skill)
			{
				return (SetSlotResult)(object)null;
			}

			public static SetSlotResult SetSlot5(Skill skill)
			{
				return (SetSlotResult)(object)null;
			}

			public static SetSlotResult SetSlot6(Skill skill)
			{
				return (SetSlotResult)(object)null;
			}

			public static SetSlotResult SetSlot7(Skill skill)
			{
				return (SetSlotResult)(object)null;
			}

			public static SetSlotResult SetSlot8(Skill skill)
			{
				return (SetSlotResult)(object)null;
			}

			public static SetSlotResult SetSlot9(Skill skill)
			{
				return (SetSlotResult)(object)null;
			}

			public static SetSlotResult smethod_3(Skill skill)
			{
				return (SetSlotResult)(object)null;
			}

			public static SetSlotResult smethod_4(Skill skill)
			{
				return (SetSlotResult)(object)null;
			}

			public static SetSlotResult smethod_5(Skill skill)
			{
				return (SetSlotResult)(object)null;
			}

			public static SetSlotResult smethod_6(Skill skill)
			{
				return (SetSlotResult)(object)null;
			}

			public static Skill Slot(int slot)
			{
				return null;
			}

			public static bool CanUse(int slot)
			{
				return true;
			}

			public static UseResult Use(int slot, bool inPlace, bool clearKeys = true)
			{
				return (UseResult)(object)null;
			}

			public static UseResult UseAt(int slot, bool inPlace, DreamPoeBot.Common.Vector3 position, bool clearKeys = true)
			{
				return (UseResult)(object)null;
			}

			public static UseResult UseAt(int slot, bool inPlace, Vector2i position, bool clearKeys = true)
			{
				return (UseResult)(object)null;
			}

			public static UseResult UseAt(int slot, bool inPlace, DreamPoeBot.Common.Vector2 position, bool clearKeys = true)
			{
				return (UseResult)(object)null;
			}

			public static UseResult UseOn(int slot, bool inPlace, NetworkObject obj, bool clearKeys = true)
			{
				return (UseResult)(object)null;
			}

			public static UseResult BeginUse(int slot, bool inPlace)
			{
				return (UseResult)(object)null;
			}

			public static UseResult BeginUseAt(int slot, bool inPlace, DreamPoeBot.Common.Vector3 position)
			{
				return (UseResult)(object)null;
			}

			public static UseResult BeginUseAt(int slot, bool inPlace, Vector2i position)
			{
				return (UseResult)(object)null;
			}

			public static UseResult BeginUseAt(int slot, bool inPlace, DreamPoeBot.Common.Vector2 position)
			{
				return (UseResult)(object)null;
			}

			public static UseResult BeginUseAt(int slot, bool inPlace, NetworkObject obj)
			{
				return (UseResult)(object)null;
			}

			public static UseResult BeginUse(int slot, bool inPlace, bool clearKeys)
			{
				return (UseResult)(object)null;
			}

			public static UseResult BeginUseAt(int slot, bool inPlace, DreamPoeBot.Common.Vector3 position, bool clearKeys)
			{
				return (UseResult)(object)null;
			}

			public static UseResult BeginUseAt(int slot, bool inPlace, Vector2i position, bool clearKeys)
			{
				return (UseResult)(object)null;
			}

			public static UseResult BeginUseAt(int slot, bool inPlace, DreamPoeBot.Common.Vector2 position, bool clearKeys)
			{
				return (UseResult)(object)null;
			}

			public static UseResult BeginUseAt(int slot, bool inPlace, NetworkObject obj, bool clearKeys)
			{
				return (UseResult)(object)null;
			}

			internal static bool smethod_7()
			{
				return true;
			}

			internal static SkillBarHud smethod_8()
			{
				return null;
			}

			static SkillBarHud()
			{
				Class200.smethod_34();
			}
		}

		private static int int_0;

		private static EventHandler<PreLevelSkillGemEventArgs> eventHandler_0;

		internal static InGameState inGameState_0;

		public static long FrameUnderCursor => 0L;

		public static bool IsSkipCutscenePanelVisible => true;

		public static bool IsLeaveHideoutButtonShowing => true;

		public static bool IsEnteringAreaTextShown => true;

		public static string EnteringAreaText => null;

		[Obsolete("Always false, is not used anymore.", false)]
		public static bool IsTopMostOverlayActive => true;

		public static NetworkObject CurrentTarget => null;

		public static bool IsLeftPanelShown => true;

		public static bool IsRightPanelShown => true;

		public static DockedWindowControlWrapper WindowControl => null;

		public static bool CanOpenTownPortal => true;

		public static float HeavyStunPct => 0f;

		internal static HandlePendingLevelUpResult smethod_0(List<Element> list_0, Func<bool> func_0, bool bool_0, Func<Inventory, Item, Item, bool> func_1, bool bool_1)
		{
			return (HandlePendingLevelUpResult)(object)null;
		}

		internal static HandlePendingLevelUpResult smethod_1(List<Element> list_0, Func<bool> func_0, bool bool_0, Func<Inventory, Item, Item, bool> func_1, bool bool_1)
		{
			return (HandlePendingLevelUpResult)(object)null;
		}

		internal static void smethod_2(float float_0, float float_1, float float_2, out int int_1, out int int_2)
		{
		}

		public static DatQuestStateWrapper GetCurrentQuestState(DatQuestWrapper quest)
		{
			return null;
		}

		public static DatQuestStateWrapper GetCurrentQuestStateAccurate(string questId)
		{
			return null;
		}

		public static DatQuestStateWrapper GetCurrentQuestState(string questId, bool cruel = false)
		{
			return null;
		}

		public static Dictionary<string, KeyValuePair<DatQuestWrapper, DatQuestStateWrapper>> GetCurrentQuestStates()
		{
			return null;
		}

		public static Dictionary<string, KeyValuePair<DatQuestWrapper, DatQuestStateWrapper>> GetCurrentQuestStates(bool cruel = false)
		{
			return null;
		}

		public static bool LeaveHideout()
		{
			return true;
		}

		public static void OpenPortal()
		{
		}

		static InGameState()
		{
			Class200.smethod_34();
			Class204.smethod_0();
			int_0 = 488;
		}

		internal static bool smethod_3()
		{
			return true;
		}

		internal static InGameState smethod_4()
		{
			return null;
		}
	}

	public static class LoginState
	{
		public enum UnlockAccountUiResult
		{
			None,
			ProcessHookManagerNotEnabled,
			UiNotOpen,
			NotEnabled,
			NotVisible,
			InvalidCodeFormat,
			InvalidCode
		}

		public static class UnlockAccountUi
		{
			internal static UnlockAccountUi unlockAccountUi_0;

			public static bool IsOpened => true;

			[SpecialName]
			private static Element smethod_0()
			{
				return null;
			}

			public static UnlockAccountUiResult Cancel(bool actuallyClick = true)
			{
				return (UnlockAccountUiResult)(object)null;
			}

			public static UnlockAccountUiResult ResendEmail(bool actuallyClick = true)
			{
				return (UnlockAccountUiResult)(object)null;
			}

			public static UnlockAccountUiResult Unlock(string code, bool actuallyClick = true)
			{
				return (UnlockAccountUiResult)(object)null;
			}

			[SpecialName]
			private static Element smethod_1()
			{
				return null;
			}

			[SpecialName]
			private static Element smethod_2()
			{
				return null;
			}

			[SpecialName]
			private static Element smethod_3()
			{
				return null;
			}

			[SpecialName]
			private static Element smethod_4()
			{
				return null;
			}

			[SpecialName]
			private static Element smethod_5()
			{
				return null;
			}

			private static UnlockAccountUiResult smethod_6(Element element_0, bool bool_0 = true)
			{
				return (UnlockAccountUiResult)(object)null;
			}

			private static void smethod_7(string string_0)
			{
			}

			private static void smethod_8(Element element_0)
			{
			}

			internal static bool smethod_9()
			{
				return true;
			}

			internal static UnlockAccountUi smethod_10()
			{
				return null;
			}

			static UnlockAccountUi()
			{
				Class200.smethod_34();
			}
		}

		public enum LoginError
		{
			None,
			ProcessHookManagerNotEnabled,
			UnlockCodeRequired,
			TermsOfUsePresent,
			NotOnLoginScreen,
			LoginErrorWindowPresent,
			ControlNotVisible,
			ControlNotEnabled,
			InQueue,
			AlreadyConnecting,
			NoCredentials,
			GatewaySelectionFailed,
			NoGateway
		}

		internal static LoginState loginState_0;

		public static bool IsConnecting => true;

		public static string LoginTextboxText => null;

		public static string GatewayText => null;

		public static GatewayComboBoxElement.GatewayEnum GetGateway()
		{
			return (GatewayComboBoxElement.GatewayEnum)(object)null;
		}

		public static bool SetGateway(GatewayComboBoxElement.GatewayEnum gateway)
		{
			return true;
		}

		public static LoginError Login(string gateway)
		{
			return (LoginError)(object)null;
		}

		public static LoginError Login(string email, string password, string gateway)
		{
			return (LoginError)(object)null;
		}

		public static LoginError Login(string email, string password)
		{
			return (LoginError)(object)null;
		}

		public static LoginError Login(bool dryRun = false)
		{
			return (LoginError)(object)null;
		}

		public static void SetEmail(string email)
		{
		}

		public static void SetPassword(string pw)
		{
		}

		public static void ClickLogin()
		{
		}

		[SpecialName]
		internal static bool smethod_0()
		{
			return true;
		}

		[SpecialName]
		internal static long smethod_1()
		{
			return 0L;
		}

		[SpecialName]
		internal static long eujAjupReQJ()
		{
			return 0L;
		}

		internal static bool smethod_2()
		{
			return true;
		}

		internal static LoginState smethod_3()
		{
			return null;
		}

		static LoginState()
		{
			Class200.smethod_34();
		}
	}

	public static class PreGameState
	{
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct Struct69
		{
			public Struct9 struct9_0;

			public long long_0;

			public long long_1;

			public long long_2;

			public long long_3;

			public long long_4;

			public long long_5;

			public long long_6;

			public long long_7;
		}

		private static PerFrameCachedValue<Struct69> perFrameCachedValue_0;

		private static PreGameState preGameState_0;

		public static bool IsRealmRestartingMessageShown => true;

		public static string RealmRestartingMessage => null;

		public static bool IsLeagueInformationWindowOpen => true;

		public static bool IsTermsOfUseWindowOpen => true;

		public static bool IsOptionsDialogOpen => true;

		public static bool IsMessageBoxActive => true;

		public static string MessageBoxTitle => null;

		public static string MessageBoxText => null;

		public static List<string> LogEntries => null;

		public static Element ActionElement => null;

		public static Element CancelElement => null;

		public static Element RootControl => null;

		[SpecialName]
		private static Element smethod_0()
		{
			return null;
		}

		public static bool AcceptTermOfUse()
		{
			return true;
		}

		public static bool ConfirmMessageBox()
		{
			return true;
		}

		public static bool CancelMessageBox()
		{
			return true;
		}

		public static void ClickConfirm()
		{
		}

		public static void ClickCancel()
		{
		}

		[SpecialName]
		private static Struct69 smethod_1()
		{
			return (Struct69)(object)null;
		}

		internal static bool smethod_2()
		{
			return true;
		}

		internal static PreGameState smethod_3()
		{
			return null;
		}

		static PreGameState()
		{
			Class200.smethod_34();
		}
	}

	public static class TerrainData
	{
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct Struct70
		{
			private long long_0;

			private byte byte_0;

			private byte byte_1;

			private byte byte_2;

			private byte byte_3;

			private byte byte_4;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct Struct71
		{
			public long long_0;

			public long long_1;

			private NativeVector nativeVector_0;

			private long long_2;

			public short short_0;

			private ushort ushort_0;

			private ushort ushort_1;

			public byte byte_0;

			private byte byte_1;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct Struct72
		{
			public NativeVector nativeVector_0;

			private long long_0;

			private long long_1;

			private long long_2;

			private ushort ushort_0;

			private ushort ushort_1;

			private ushort ushort_2;

			private ushort ushort_3;

			private long long_3;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct Struct73
		{
			private long long_0;

			private long long_1;

			private long long_2;

			private long long_3;

			private long long_4;

			private long long_5;

			private ushort ushort_0;

			private ushort ushort_1;

			private ushort ushort_2;

			private ushort ushort_3;

			private long long_6;
		}

		private static PerAreaCachedValue<TerrainDataEntry[,]> perAreaCachedValue_0;

		private static PerAreaCachedValue<TerrainDataEntry[,]> perAreaCachedValue_1;

		private static CachedTerrainData cachedTerrainData_0;

		internal static TerrainData terrainData_0;

		public static Vector2i Size => (Vector2i)(object)null;

		public static int Cols => 0;

		public static int Rows => 0;

		public static Vector2i SizeInNavCells => (Vector2i)(object)null;

		public static int BytesPerRow => 0;

		public static TerrainDataEntry TgtUnderPlayer => null;

		public static TerrainDataEntry TdtUnderPlayer => null;

		public static TerrainDataEntry[,] TgtEntries => null;

		public static TerrainDataEntry[,] TdtEntries => null;

		public static byte[] Layer0 => null;

		public static byte[] Layer1 => null;

		public static CachedTerrainData Cache => null;

		static TerrainData()
		{
			Class200.smethod_34();
			Class204.smethod_0();
			cachedTerrainData_0 = new CachedTerrainData();
			cachedTerrainData_0 = new CachedTerrainData();
		}

		private static void smethod_0(FileStream fileStream_0, byte[] byte_0)
		{
		}

		private static TerrainDataEntry[,] smethod_1()
		{
			return null;
		}

		private static TerrainDataEntry[,] smethod_2()
		{
			return null;
		}

		private static TerrainDataEntry[,] Cachesmethod_2TerrainDataEntryArray()
		{
			return null;
		}

		private static TerrainDataEntry[,] Cachesmethod_2TdTDataEntryArray()
		{
			return null;
		}

		private static bool smethod_3(DreamPoeBot.Loki.Game.Objects.TriggerableBlockage triggerableBlockage_0)
		{
			return true;
		}

		public static void UnblockTriggerableBlockages(ref byte[] data, int bytesPerRow, Func<DreamPoeBot.Loki.Game.Objects.TriggerableBlockage, bool> shouldUnblock)
		{
		}

		public static void UnBlockBreachWalls(ref byte[] data, int bytesPerRow)
		{
		}

		[SpecialName]
		internal static CachedTerrainData nuhAjDmUobA()
		{
			return null;
		}

		internal static bool smethod_4()
		{
			return true;
		}

		internal static TerrainData smethod_5()
		{
			return null;
		}
	}

	public class TerrainDataEntry
	{
		private string string_0;

		private string string_1;

		private TerrainData.Struct72 struct72_0;

		internal static TerrainDataEntry terrainDataEntry_0;

		public string TgtName => null;

		public string TgtDetail => null;

		internal TerrainDataEntry(TerrainData.Struct72 native, string name, string detail)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static TerrainDataEntry smethod_1()
		{
			return null;
		}

		static TerrainDataEntry()
		{
			Class200.smethod_34();
		}
	}

	public class TerrainDataEntryWrapper
	{
		[CompilerGenerated]
		private TerrainDataEntry terrainDataEntry_0;

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private int int_1;

		private static TerrainDataEntryWrapper terrainDataEntryWrapper_0;

		public TerrainDataEntry Entry
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

		public int Col
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int Row
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal TerrainDataEntryWrapper(TerrainDataEntry entry, int col, int row)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static TerrainDataEntryWrapper smethod_1()
		{
			return null;
		}

		static TerrainDataEntryWrapper()
		{
			Class200.smethod_34();
		}
	}

	public static class AreaGraphs
	{
		private static uint uint_0;

		private static List<Topologie> list_0;

		public static List<Topologie> Topologies => null;

		static AreaGraphs()
		{
			Class200.smethod_34();
		}
	}

	public class Topologie
	{
		private List<TopologieRoom> list_0;

		private long long_0;

		private Struct74 struct74_0;

		private string string_0;

		private static Topologie topologie_0;

		public DatWorldAreaWrapper WorldArea => null;

		public List<TopologieRoom> TopologieRooms => null;

		public Vector2i MinCoord => (Vector2i)(object)null;

		public Vector2i MaxCoord => (Vector2i)(object)null;

		public string Name => null;

		public override string ToString()
		{
			return null;
		}

		internal Topologie(long ard)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Topologie smethod_1()
		{
			return null;
		}

		static Topologie()
		{
			Class200.smethod_34();
		}
	}

	public class TopologieRoom
	{
		private string string_0;

		private long long_0;

		private Struct75 struct75_0;

		private static TopologieRoom topologieRoom_0;

		public Vector2i MinCoord => (Vector2i)(object)null;

		public Vector2i MaxCoord => (Vector2i)(object)null;

		public string Name => null;

		public override string ToString()
		{
			return null;
		}

		internal TopologieRoom(long adr)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static TopologieRoom smethod_1()
		{
			return null;
		}

		static TopologieRoom()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct74
	{
		public readonly long long_0;

		public readonly long long_1;

		public readonly long long_2;

		public readonly long long_3;

		public readonly GStruct2 gstruct2_0;

		public readonly Vector2i vector2i_0;

		public readonly Vector2i vector2i_1;

		public readonly long long_4;

		public readonly NativeVector nativeVector_0;

		public readonly long long_5;

		private readonly long long_6;

		private readonly long long_7;

		private readonly long long_8;

		private readonly long long_9;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct75
	{
		public readonly long long_0;

		public readonly Vector2i vector2i_0;

		public readonly Vector2i vector2i_1;

		public readonly byte byte_0;

		public readonly byte byte_1;

		public readonly byte byte_2;

		public readonly byte byte_3;

		public readonly byte byte_4;

		public readonly byte byte_5;

		public readonly byte byte_6;

		public readonly byte byte_7;

		private readonly long long_1;

		private readonly long long_2;

		private readonly long long_3;
	}

	internal static class Class69
	{
		private static readonly Class82 class82_0;

		internal static Class69 class69_0;

		internal static Class78 smethod_0(uint uint_0, ulong ulong_0, int int_0, Enum0 enum0_0, bool bool_0)
		{
			return null;
		}

		[SpecialName]
		internal static bool smethod_1()
		{
			return true;
		}

		internal static Class78 smethod_2(uint uint_0, uint uint_1, uint uint_2)
		{
			return null;
		}

		private static Interface9 smethod_3()
		{
			return null;
		}

		static Class69()
		{
			Class200.smethod_34();
			Class204.smethod_0();
			class82_0 = new Class82(smethod_3);
		}

		internal static bool smethod_4()
		{
			return true;
		}

		internal static Class69 smethod_5()
		{
			return null;
		}
	}

	private sealed class Class70 : Interface9
	{
		private readonly Memory memory_0;

		private readonly long long_0;

		private readonly long long_1;

		internal static Class70 class70_0;

		internal Class70(Memory memory_1, long long_2)
		{
		}

		[SpecialName]
		public long imethod_0()
		{
			return 0L;
		}

		[SpecialName]
		public bool imethod_1()
		{
			return true;
		}

		[SpecialName]
		public ulong imethod_2()
		{
			return 0uL;
		}

		public bool imethod_3(int int_0, byte[] byte_0)
		{
			return true;
		}

		public bool imethod_4(int int_0, byte[] byte_0)
		{
			return true;
		}

		public void Delay(int milliseconds)
		{
		}

		[DllImport("kernel32.dll")]
		private static extern ulong GetTickCount64();

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class70 smethod_1()
		{
			return null;
		}

		static Class70()
		{
			Class200.smethod_34();
		}
	}

	internal static nint intptr_0;

	internal static readonly ILog ilog_0;

	internal static bool bool_0;

	private static readonly GuiTickEventArgs guiTickEventArgs_0;

	private static EventHandler<GuiTickEventArgs> eventHandler_0;

	[CompilerGenerated]
	private static PasteTextFailedEvent pasteTextFailedEvent_0;

	internal static int int_0;

	[CompilerGenerated]
	private static int int_1;

	internal static bool bool_1;

	public static bool bool_UseAnnotatedProfiler;

	private static Func<int, bool> func_0;

	internal static readonly StaticStringCache staticStringCache_0;

	private static readonly FrameReleaseEventArgs frameReleaseEventArgs_0;

	public static readonly Random Random;

	public static readonly Stopwatch ApplicationRuntime;

	[CompilerGenerated]
	private static Window window_0;

	[CompilerGenerated]
	private static nint intptr_1;

	[CompilerGenerated]
	private static bool bool_2;

	[CompilerGenerated]
	private static ApplicationExitCodes applicationExitCodes_0;

	[CompilerGenerated]
	private static bool bool_3;

	public static Dictionary<string, StatTypeGGG> StringStatTypeGGG;

	[CompilerGenerated]
	private static PoeVersion poeVersion_0;

	private static PerFrameCachedValue<Interop.WindowInfoWin32> perFrameCachedValue_0;

	private static uint uint_0;

	private static long long_0;

	private static PerAreaCachedValue<LocalPlayer> perAreaCachedValue_0;

	internal static LokiPoe lokiPoe_0;

	public static Window BotWindow
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		internal set
		{
		}
	}

	public static nint BotWindowHandle
	{
		[CompilerGenerated]
		get
		{
			return (nint)(object)null;
		}
		[CompilerGenerated]
		internal set
		{
		}
	}

	public static bool IsBotFullyLoaded
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

	public static bool Initialized
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static PoeVersion ClientVersion
	{
		[CompilerGenerated]
		get
		{
			return (PoeVersion)(object)null;
		}
		[CompilerGenerated]
		internal set
		{
		}
	}

	public static Memory Memory => null;

	[Obsolete("NO TO BE USED ANYMORE")]
	private static Dictionary<string, StatTypeGGG> xbn0seKUrX => null;

	public static nint ClientWindowHandle => (nint)(object)null;

	public static Interop.WindowInfoWin32 ClientWindowInfo => (Interop.WindowInfoWin32)(object)null;

	public static bool IsInCreateCharacterScreen => true;

	public static bool IsInLoginScreen => true;

	public static bool IsInCharacterSelectionScreen => true;

	public static bool IsInGame => true;

	public static float MyCharacterSize => 0f;

	public static DreamPoeBot.Common.Vector2 MyWorldPosition => (DreamPoeBot.Common.Vector2)(object)null;

	public static Vector2i MyPosition => (Vector2i)(object)null;

	public static float MyRotation => 0f;

	public static int MyId => 0;

	public static LocalPlayer Me => null;

	public static byte MyReaction => 0;

	public static DatWorldAreaWrapper CurrentWorldArea => null;

	public static event PasteTextFailedEvent OnPasteTextFailed
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event EventHandler<GuiTickEventArgs> OnGuiTick
	{
		add
		{
		}
		remove
		{
		}
	}

	public static void SignalPasteTextFailed()
	{
	}

	[SpecialName]
	[CompilerGenerated]
	private static int smethod_0()
	{
		return 0;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void smethod_1(int int_2)
	{
	}

	[SpecialName]
	private static string smethod_2()
	{
		return null;
	}

	[SpecialName]
	private static string smethod_3()
	{
		return null;
	}

	[SpecialName]
	private static bool smethod_4()
	{
		return true;
	}

	[SpecialName]
	private static void smethod_5(bool bool_4)
	{
	}

	[SpecialName]
	private static string smethod_6()
	{
		return null;
	}

	private static Dictionary<int, long> smethod_7(NativeMap nativeMap_0, string string_0, string string_1, bool bool_4 = false)
	{
		return null;
	}

	internal static bool smethod_8()
	{
		return true;
	}

	internal static bool smethod_9(Process process_0, out string string_0)
	{
		return true;
	}

	public static Element GetElement<Element>(long address) where Element : RemoteMemoryObject, new()
	{
		return null;
	}

	public static void ScrapUI()
	{
	}

	private static void smethod_10(List<Element> list_0, StringBuilder stringBuilder_0)
	{
	}

	private static void smethod_11(Element element_0, StringBuilder stringBuilder_0)
	{
	}

	private static void smethod_12(Offsets offsets_0, int int_2)
	{
	}

	internal static void smethod_13(Window window_1)
	{
	}

	private static void smethod_14()
	{
	}

	internal static string smethod_15(string string_0)
	{
		return null;
	}

	internal static string smethod_16(string string_0)
	{
		return null;
	}

	internal static string smethod_17(string string_0)
	{
		return null;
	}

	internal static string smethod_18(string string_0)
	{
		return null;
	}

	internal static string smethod_19(string string_0)
	{
		return null;
	}

	public static string GetDescriptionFromStatTypeGGG(StatTypeGGG stat)
	{
		return null;
	}

	private static bool smethod_20(List<Class60> list_0, List<Class60> list_1)
	{
		return true;
	}

	private static List<Class60> smethod_21(string string_0)
	{
		return null;
	}

	private static bool smethod_22(string string_0, string string_1)
	{
		return true;
	}

	private static void smethod_23(Type type_0, object object_0)
	{
	}

	private static void smethod_24(Type type_0, object object_0, StringBuilder stringBuilder_0, string string_0)
	{
	}

	static LokiPoe()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		intptr_0 = IntPtr.Zero;
		ilog_0 = Logger.GetLoggerInstanceForType();
		bool_0 = true;
		guiTickEventArgs_0 = new GuiTickEventArgs();
		int_0 = 8;
		bool_1 = false;
		func_0 = (int id) => true;
		staticStringCache_0 = new StaticStringCache();
		frameReleaseEventArgs_0 = new FrameReleaseEventArgs();
		applicationExitCodes_0 = ApplicationExitCodes.None;
		StringStatTypeGGG = new Dictionary<string, StatTypeGGG>();
		poeVersion_0 = PoeVersion.Unknown;
		uint_0 = 0u;
		DateTime now = DateTime.Now;
		Random = new Random(now.Millisecond * now.Second * now.Second * now.Minute * 9);
		ApplicationRuntime = Stopwatch.StartNew();
	}

	[SpecialName]
	[CompilerGenerated]
	internal static ApplicationExitCodes smethod_25()
	{
		return (ApplicationExitCodes)(object)null;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_26(ApplicationExitCodes applicationExitCodes_1)
	{
	}

	public static List<Element> GetGuiElements()
	{
		return null;
	}

	public static void InvokeEvent(Delegate d, params object[] args)
	{
	}

	public static void DispatchIfNecessary(Action action)
	{
	}

	public static void BeginDispatchIfNecessary(Action action)
	{
	}

	public static void DispatchIfNecessary(Dispatcher dispatcher, Action action)
	{
	}

	public static void BeginDispatchIfNecessary(Dispatcher dispatcher, Action action)
	{
	}

	[SpecialName]
	private static uint smethod_27()
	{
		return 0u;
	}

	private static Interop.WindowInfoWin32 smethod_28()
	{
		return (Interop.WindowInfoWin32)(object)null;
	}

	private static bool smethod_29(string string_0)
	{
		return true;
	}

	public static bool MatchesSocketLayout(Item item, string filterFormat)
	{
		return true;
	}

	public static bool MatchesSocketColors(string filterFormat, SocketColor[] itemSocketColors, byte[] itemSocketLinks)
	{
		return true;
	}

	internal static bool smethod_30()
	{
		return true;
	}

	internal static LokiPoe smethod_31()
	{
		return null;
	}
}
