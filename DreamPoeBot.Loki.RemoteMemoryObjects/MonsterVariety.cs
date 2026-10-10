using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Game.GameData;
using ns0;

namespace DreamPoeBot.Loki.RemoteMemoryObjects;

public class MonsterVariety : RemoteMemoryObject
{
	[CompilerGenerated]
	private int int_0;

	private string string_0;

	internal static MonsterVariety monsterVariety_0;

	public int Id
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		internal set
		{
		}
	}

	public string VarietyId => null;

	public int ObjectSize => 0;

	public int MinimumAttackDistance => 0;

	public int MaximumAttackDistance => 0;

	public string ACTFile => null;

	public string AOFile => null;

	public string BaseMonsterTypeIndex => null;

	public List<DatModsWrapper> Mods => null;

	public int ModelSizeMultiplier => 0;

	public int ExperienceMultiplier => 0;

	[Obsolete("CriticalStrikeChance DAT non ricostruito; restituisce 0 come fallback, non come valore verificato.")]
	public int CriticalStrikeChance => 0;

	public string AISFile => null;

	public string MonsterName => null;

	public int DamageMultiplier => 0;

	public int LifeMultiplier => 0;

	public int AttackSpeed => 0;

	private string method_0(int int_1)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static MonsterVariety smethod_3()
	{
		return null;
	}

	static MonsterVariety()
	{
		Class200.smethod_34();
	}
}
