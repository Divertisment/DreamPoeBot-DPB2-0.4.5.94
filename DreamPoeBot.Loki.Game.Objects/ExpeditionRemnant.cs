using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Common;
using DreamPoeBot.Loki.Elements;
using DreamPoeBot.Loki.Game.GameData;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

public class ExpeditionRemnant : NetworkObject
{
	public class Expedition2EncounterData
	{
		[CompilerGenerated]
		private readonly int int_0;

		[CompilerGenerated]
		private readonly DatExpedition2RunesWrapper datExpedition2RunesWrapper_0;

		[CompilerGenerated]
		private readonly int int_1;

		[CompilerGenerated]
		private readonly int int_2;

		[CompilerGenerated]
		private readonly List<int> list_0;

		[CompilerGenerated]
		private readonly DatExpedition2RecipesWrapper datExpedition2RecipesWrapper_0;

		internal static Expedition2EncounterData expedition2EncounterData_0;

		public DatExpedition2RunesWrapper FixedRune
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			init
			{
			}
		}

		public int FixedRunePosition
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			init
			{
			}
		}

		public int RuneCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			init
			{
			}
		}

		public List<int> PropagatedRunePositions
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			init
			{
			}
		}

		public DatExpedition2RecipesWrapper SelectedRecipe
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			init
			{
			}
		}

		[SpecialName]
		[CompilerGenerated]
		internal int method_0()
		{
			return 0;
		}

		[SpecialName]
		[CompilerGenerated]
		internal void method_1(int int_3)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Expedition2EncounterData smethod_1()
		{
			return null;
		}

		static Expedition2EncounterData()
		{
			Class200.smethod_34();
		}
	}

	private static readonly ILog ilog_1;

	private static ExpeditionRemnant expeditionRemnant_0;

	public new ExpeditionRemnantElement Ui => null;

	public Expedition2EncounterData EncounterData => null;

	public List<DatExpedition2RecipesWrapper> Recipes => null;

	public List<string> Infos => null;

	public bool CanReroll => true;

	public void OpenRecipeList()
	{
	}

	public void CombineRunes()
	{
	}

	public void ShatterorCollect()
	{
	}

	public bool Reroll()
	{
		return true;
	}

	public new string Dump()
	{
		return null;
	}

	internal ExpeditionRemnant(NetworkObject entry)
	{
	}

	static ExpeditionRemnant()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_1 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_24()
	{
		return true;
	}

	internal static ExpeditionRemnant smethod_25()
	{
		return null;
	}
}
