using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.RemoteMemoryObjects;
using ns0;

namespace DreamPoeBot.Loki.Elements;

public class CraftingBenchElement : Element
{
	public class Recipe
	{
		public class Price
		{
			public Element _element;

			private static Price price_0;

			public List<Cost> PriceList => null;

			public Price(Element element)
			{
			}

			public int GetQuantity(int idx)
			{
				return 0;
			}

			public string GetCurrency(int idx)
			{
				return null;
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static Price smethod_1()
			{
				return null;
			}

			static Price()
			{
				Class200.smethod_34();
			}
		}

		public class Cost
		{
			[CompilerGenerated]
			private int int_0;

			[CompilerGenerated]
			private string string_0;

			private static Cost cost_0;

			public int Quantity
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

			public string Currency
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

			internal static Cost smethod_1()
			{
				return null;
			}

			static Cost()
			{
				Class200.smethod_34();
			}
		}

		private Element element_0;

		public Element _element;

		private string string_0;

		private static Recipe recipe_0;

		public bool IsRecipeOpionsExpanded => true;

		public bool IsVisible => true;

		public bool IsSelected => true;

		public bool CanBeCrafted => true;

		public string Name => null;

		public string Category => null;

		public int Level => 0;

		public Price Prices => null;

		public Vector2i ClickLocation => (Vector2i)(object)null;

		public Recipe(string category, Element element, Element listElement)
		{
		}

		public bool Expand()
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Recipe smethod_1()
		{
			return null;
		}

		static Recipe()
		{
			Class200.smethod_34();
		}
	}

	internal static CraftingBenchElement craftingBenchElement_0;

	public Element CraftButtonElement => null;

	public Element SearchElement => null;

	public string SearchElementText => null;

	public Element ItemSlotElement => null;

	public Inventory ItemSlotInventory => null;

	public List<Element> RecipesListElement => null;

	public List<Recipe> RecipeList => null;

	internal static bool smethod_11()
	{
		return true;
	}

	internal static CraftingBenchElement smethod_12()
	{
		return null;
	}

	static CraftingBenchElement()
	{
		Class200.smethod_34();
	}
}
