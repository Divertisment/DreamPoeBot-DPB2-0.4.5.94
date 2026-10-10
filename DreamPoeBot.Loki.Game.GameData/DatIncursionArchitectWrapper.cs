using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Loki.Game.GameData;

public class DatIncursionArchitectWrapper
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct115
	{
		public Struct10 struct10_0;

		public int int_0;
	}

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	private long long_0;

	[CompilerGenerated]
	private Struct115 struct115_0;

	private static DatIncursionArchitectWrapper datIncursionArchitectWrapper_0;

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

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public string Metadata
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int MonsterId
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

	public long BaseAddress
	{
		[CompilerGenerated]
		get
		{
			return 0L;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	[SpecialName]
	internal Memory method_0()
	{
		return null;
	}

	[SpecialName]
	[CompilerGenerated]
	internal Struct115 method_1()
	{
		return (Struct115)(object)null;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_2(Struct115 struct115_1)
	{
	}

	private void method_3(Struct115 struct115_1)
	{
	}

	internal DatIncursionArchitectWrapper(long address, Struct115 native, int index)
	{
	}

	internal DatIncursionArchitectWrapper(long ptr)
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

	internal static DatIncursionArchitectWrapper smethod_1()
	{
		return null;
	}

	static DatIncursionArchitectWrapper()
	{
		Class200.smethod_34();
	}
}
