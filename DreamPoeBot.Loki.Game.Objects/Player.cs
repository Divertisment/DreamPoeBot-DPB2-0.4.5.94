using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Models;
using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

public class Player : Actor
{
	internal static Player player_0;

	public int Level => 0;

	public CharacterClass Class => (CharacterClass)(object)null;

	public AscendancyClass AscendencyClass => (AscendancyClass)(object)null;

	public uint Experience => 0u;

	public uint ExperienceNextLevel => 0u;

	public uint ExperienceLastLevel => 0u;

	public uint ExperienceGainedThisLevel => 0u;

	public uint ExperienceLeftThisLevel => 0u;

	public float ExperiencePercent => 0f;

	internal Player(EntityWrapper entry)
	{
	}

	public override string ToString()
	{
		return null;
	}

	internal static bool smethod_26()
	{
		return true;
	}

	internal static Player smethod_27()
	{
		return null;
	}

	static Player()
	{
		Class200.smethod_34();
	}
}
