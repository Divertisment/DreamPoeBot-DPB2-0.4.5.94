using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.RemoteMemoryObjects;
using ns0;

namespace DreamPoeBot.Loki.Elements;

public class HorticraftingElement : Element
{
	public class Recipe
	{
		public class Price
		{
			public Element _element;

			private static Price price_0;

			public List<Lifeforce> PriceList => null;

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

		public Element _element;

		internal static Recipe recipe_0;

		public bool IsVisible => true;

		public bool IsSelected => true;

		public bool CanBeCrafted => true;

		public string Name => null;

		public Price Prices => null;

		public Vector2i ClickLocation => (Vector2i)(object)null;

		public Recipe(Element element)
		{
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

	public class Lifeforce
	{
		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private string string_0;

		internal static Lifeforce lifeforce_0;

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

		internal static Lifeforce smethod_1()
		{
			return null;
		}

		static Lifeforce()
		{
			Class200.smethod_34();
		}
	}

	internal static HorticraftingElement horticraftingElement_0;

	public Element CraftButtonElement => null;

	public List<Element> RecipesListElement => null;

	public Element SearchElement => null;

	public string SearchElementText => null;

	public Element ItemSlotElement => null;

	public Inventory ItemSlotInventory => null;

	public Element CurrencyInventory => null;

	public List<Lifeforce> AvailableLifeforces => null;

	public List<Recipe> RecipeList => null;

	internal static bool smethod_11()
	{
		return true;
	}

	internal static HorticraftingElement smethod_12()
	{
		return null;
	}

	static HorticraftingElement()
	{
		Class200.smethod_34();
	}
}
