using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class StateMachine : Component
{
	public class StageState
	{
		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private bool bool_0;

		[CompilerGenerated]
		private int int_0;

		private static StageState stageState_0;

		public string Name
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

		public bool IsActive
		{
			[CompilerGenerated]
			get
			{
				return true;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int Value
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

		public StageState(string name, bool isActive, int value)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static StageState smethod_1()
		{
			return null;
		}

		static StageState()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct255
	{
		private long long_0;

		private long long_1;

		private byte byte_0;

		private byte byte_1;

		private byte byte_2;

		private byte byte_3;

		private int int_0;

		private long long_2;

		private NativeVector LyUplPopuAS;

		private long long_3;

		private long long_4;

		private long long_5;

		private long long_6;

		private long long_7;

		private long long_8;

		private long long_9;

		private long long_10;

		private long long_11;

		private long long_12;

		private long long_13;

		private long long_14;

		private long long_15;

		private long long_16;

		private long long_17;

		private long long_18;

		private NativeVector nativeVector_0;

		private long long_19;

		private long long_20;

		private long long_21;

		private long long_22;

		private long iekplLogtuH;

		private long long_23;

		private long long_24;

		private long long_25;

		private long long_26;

		private long long_27;

		private long long_28;

		private long long_29;

		private long long_30;

		private long long_31;

		private long long_32;

		private long long_33;

		private long long_34;

		public long long_35;

		public NativeVector nativeVector_1;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct256
	{
		private long long_0;

		private long long_1;

		public NativeVector nativeVector_0;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct StatesStructure
	{
		public GStruct2 description;

		private int int_0;

		private int int_1;

		private int int_2;

		private int bxAplmdGlsf;

		private long long_0;

		private int int_3;

		private int int_4;

		private long odcplhynyb7;

		private int BpaplzYdcXe;

		private int int_5;

		private long long_1;

		private int int_6;

		private int int_7;

		private long long_2;

		private long long_3;

		private long long_4;

		private long long_5;

		private long long_6;

		private long long_7;

		private long long_8;

		private long long_9;

		private long HuXppPetdmT;

		private long long_10;

		private long long_11;

		private long long_12;
	}

	private PerFrameCachedValue<Struct255> GpyAwrOicPv;

	private PerFrameCachedValue<Struct256> oegAwHkjJqw;

	internal static StateMachine stateMachine_0;

	public bool HasState => true;

	public int Stage => 0;

	public bool IsRitualActive => true;

	public bool Encounter_Started => true;

	public bool Encounter_Finished => true;

	public List<StageState> StageStates => null;

	[SpecialName]
	internal Struct255 method_2()
	{
		return (Struct255)(object)null;
	}

	[SpecialName]
	internal Struct256 method_3()
	{
		return (Struct256)(object)null;
	}

	[SpecialName]
	private Dictionary<int, StatesStructure> method_4()
	{
		return null;
	}

	[CompilerGenerated]
	private Struct255 method_5()
	{
		return (Struct255)(object)null;
	}

	[CompilerGenerated]
	private Struct256 method_6()
	{
		return (Struct256)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static StateMachine smethod_5()
	{
		return null;
	}

	static StateMachine()
	{
		Class200.smethod_34();
	}
}
