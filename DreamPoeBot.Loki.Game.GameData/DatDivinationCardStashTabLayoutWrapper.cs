using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Loki.Game.GameData;

public class DatDivinationCardStashTabLayoutWrapper
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct107
	{
		public long long_0;

		public long long_1;

		public byte byte_0;
	}

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private DatBaseItemTypeWrapper datBaseItemTypeWrapper_0;

	[CompilerGenerated]
	private Struct107 struct107_0;

	internal static DatDivinationCardStashTabLayoutWrapper datDivinationCardStashTabLayoutWrapper_0;

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

	public DatBaseItemTypeWrapper BaseItemTypeWrapper
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

	[SpecialName]
	internal Memory method_0()
	{
		return null;
	}

	[SpecialName]
	[CompilerGenerated]
	internal Struct107 method_1()
	{
		return (Struct107)(object)null;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_2(Struct107 struct107_1)
	{
	}

	internal DatDivinationCardStashTabLayoutWrapper(Struct107 native, int index)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static DatDivinationCardStashTabLayoutWrapper smethod_1()
	{
		return null;
	}

	static DatDivinationCardStashTabLayoutWrapper()
	{
		Class200.smethod_34();
	}
}
