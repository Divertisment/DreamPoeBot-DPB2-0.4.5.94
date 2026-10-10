using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Game.GameData;
using ns0;

namespace DreamPoeBot.Loki.FilesInMemory;

public class Expedition2RecipesDat : FileInMemory<DatExpedition2RecipesWrapper>
{
	[CompilerGenerated]
	private static readonly Expedition2RecipesDat expedition2RecipesDat_0;

	private static Expedition2RecipesDat expedition2RecipesDat_1;

	public static Expedition2RecipesDat Empty
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public Expedition2RecipesDat()
	{
	}

	public Expedition2RecipesDat(Memory m, long address, int dataLength = 24, bool parallel = true)
	{
	}

	private protected override long vmethod_0(DatExpedition2RecipesWrapper record)
	{
		return 0L;
	}

	static Expedition2RecipesDat()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		expedition2RecipesDat_0 = new Expedition2RecipesDat();
	}

	[CompilerGenerated]
	private DatExpedition2RecipesWrapper method_3(DatExpedition2RecipesWrapper.Struct108 struct108_0, long long_6, int int_2)
	{
		return null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static Expedition2RecipesDat smethod_5()
	{
		return null;
	}
}
