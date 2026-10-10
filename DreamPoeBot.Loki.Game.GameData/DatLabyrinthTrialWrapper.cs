using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Loki.Game.GameData;

public class DatLabyrinthTrialWrapper
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct117
	{
		public Struct10 struct10_0;

		public int int_0;

		public int int_1;

		public int int_2;

		private Struct10 struct10_1;

		public long long_0;

		public long long_1;

		private long long_2;

		private long long_3;
	}

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private Struct117 struct117_0;

	[CompilerGenerated]
	private readonly int int_1;

	[CompilerGenerated]
	private readonly DatWorldAreaWrapper datWorldAreaWrapper_0;

	internal static DatLabyrinthTrialWrapper datLabyrinthTrialWrapper_0;

	public int Index
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int Id
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
	}

	public DatWorldAreaWrapper WorldArea
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[SpecialName]
	internal Memory method_0()
	{
		return null;
	}

	[SpecialName]
	[CompilerGenerated]
	internal Struct117 method_1()
	{
		return (Struct117)(object)null;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_2(Struct117 struct117_1)
	{
	}

	internal DatLabyrinthTrialWrapper(Struct117 native, int index)
	{
	}

	public override string ToString()
	{
		return null;
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static DatLabyrinthTrialWrapper smethod_1()
	{
		return null;
	}

	static DatLabyrinthTrialWrapper()
	{
		Class200.smethod_34();
	}
}
