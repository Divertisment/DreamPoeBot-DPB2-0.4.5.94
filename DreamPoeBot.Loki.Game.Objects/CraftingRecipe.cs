using DreamPoeBot.Loki.Models;
using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

public class CraftingRecipe : NetworkObject
{
	internal static CraftingRecipe craftingRecipe_0;

	public bool IsOpened => true;

	internal CraftingRecipe(EntityWrapper entity)
	{
	}

	internal static bool smethod_24()
	{
		return true;
	}

	internal static CraftingRecipe smethod_25()
	{
		return null;
	}

	static CraftingRecipe()
	{
		Class200.smethod_34();
	}
}
