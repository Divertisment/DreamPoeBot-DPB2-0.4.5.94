using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Loki.Game.GameData;

public class DatExpedition2RunesWrapper
{
	[StructLayout(LayoutKind.Explicit, Size = 104)]
	internal struct Struct109
	{
		[FieldOffset(0)]
		public long Id;

		[FieldOffset(24)]
		public long long_0;

		[FieldOffset(40)]
		public long long_1;

		[FieldOffset(72)]
		public long long_2;
	}

	[CompilerGenerated]
	private readonly long long_0;

	[CompilerGenerated]
	private readonly int int_0;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly long long_1;

	[CompilerGenerated]
	private readonly long long_2;

	[CompilerGenerated]
	private readonly long long_3;

	private static DatExpedition2RunesWrapper datExpedition2RunesWrapper_0;

	public long Address
	{
		[CompilerGenerated]
		get
		{
			return 0L;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	public int Index
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

	public string Id
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

	public DatModsWrapper ArchnemesisMod => null;

	public DatModsWrapper ArchnemesisModPower => null;

	public DatModsWrapper Mod => null;

	[SpecialName]
	internal Memory method_0()
	{
		return null;
	}

	[SpecialName]
	[CompilerGenerated]
	internal long method_1()
	{
		return 0L;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_2(long long_4)
	{
	}

	[SpecialName]
	[CompilerGenerated]
	internal long method_3()
	{
		return 0L;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_4(long long_4)
	{
	}

	[SpecialName]
	[CompilerGenerated]
	internal long method_5()
	{
		return 0L;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_6(long long_4)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static DatExpedition2RunesWrapper smethod_1()
	{
		return null;
	}

	static DatExpedition2RunesWrapper()
	{
		Class200.smethod_34();
	}
}
