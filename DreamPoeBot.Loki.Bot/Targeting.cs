using System.Collections.Generic;
using DreamPoeBot.Loki.Common;
using DreamPoeBot.Loki.Game.Objects;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Bot;

public class Targeting
{
	public class Entry
	{
		public int Id;

		public float Weight;

		private static Entry entry_0;

		public Entry(int id, float weight = 0f)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Entry smethod_1()
		{
			return null;
		}

		static Entry()
		{
			Class200.smethod_34();
		}
	}

	public delegate bool InclusionCalculator(NetworkObject entity);

	public delegate void WeightCalcuator(NetworkObject entity, ref float weight);

	private static readonly ILog ilog_0;

	private readonly List<Entry> list_0;

	private InclusionCalculator inclusionCalculator_0;

	private WeightCalcuator weightCalcuator_0;

	internal static Targeting targeting_0;

	public event InclusionCalculator InclusionCalcuation
	{
		add
		{
		}
		remove
		{
		}
	}

	public event WeightCalcuator WeightCalculation
	{
		add
		{
		}
		remove
		{
		}
	}

	public void ResetInclusionCalcuation()
	{
	}

	public void ResetWeightCalculation()
	{
	}

	public IEnumerable<T> Targets<T>() where T : class
	{
		return null;
	}

	public IEnumerable<NetworkObject> Targets()
	{
		return null;
	}

	public void Update()
	{
	}

	static Targeting()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static Targeting smethod_1()
	{
		return null;
	}
}
