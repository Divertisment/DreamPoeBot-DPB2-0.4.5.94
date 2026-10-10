using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Components;
using ns0;

namespace DreamPoeBot.Loki.Elements;

public class GrandHeistContractElement : Element
{
	public class Job
	{
		private Element element_0;

		internal static Job job_0;

		public HeistJobs HeistJob => (HeistJobs)(object)null;

		public int Level => 0;

		public bool Assigned => true;

		public Job(Element element)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Job smethod_1()
		{
			return null;
		}

		static Job()
		{
			Class200.smethod_34();
		}
	}

	public enum HeistJobs
	{
		Lockpicking,
		BruteForce,
		Perception,
		Demolition,
		CounterThaumaturge,
		TrapDisarmament,
		Agility,
		Deception,
		Engineering,
		None
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct167
	{
		public long long_0;

		public long long_1;

		public long long_2;

		public int int_0;

		public int int_1;

		public IncursionTemple.Struct_rooms struct_rooms_0;
	}

	internal static GrandHeistContractElement grandHeistContractElement_0;

	public Element ContractFeesElement => null;

	public Element ConfirmPlanElement => null;

	public Element ItemElement => null;

	public Element AgentsElement => null;

	[SpecialName]
	private int method_29()
	{
		return 0;
	}

	[SpecialName]
	private int method_30()
	{
		return 0;
	}

	[SpecialName]
	private int method_31()
	{
		return 0;
	}

	[SpecialName]
	private int method_32()
	{
		return 0;
	}

	internal static bool smethod_11()
	{
		return true;
	}

	internal static GrandHeistContractElement smethod_12()
	{
		return null;
	}

	static GrandHeistContractElement()
	{
		Class200.smethod_34();
	}
}
