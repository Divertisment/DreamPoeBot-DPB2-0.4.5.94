using System;

namespace DreamPoeBot.Loki.Game;

[Flags]
public enum InventoryControlFlagEnum
{
	FlaskLife = 1,
	FlaskMana = 2,
	Charm1 = 4,
	Charm2 = 8,
	Charm3 = 0x10,
	Reward = 0x20,
	Blight = 0x40,
	Curency = 0x80,
	Divination = 0x100,
	Delirium = 0x200,
	Delve = 0x400,
	Essence = 0x800,
	ExpeditionLocker = 0x1000,
	HeistLocker = 0x2000,
	Fragment = 0x4000,
	Metamorph = 0x8000,
	FiveSlotMapDavice = 0x10000,
	SingleSlot = 0x20000,
	EquippableItemOverride = 0x40000,
	Ritual = 0x80000,
	Tablets = 0x100000,
	Waystones = 0x200000,
	Breach = 0x400000,
	Expedition2 = 0x800000,
	Abyss = 0x1000000,
	Socketable = 0x2000000
}
