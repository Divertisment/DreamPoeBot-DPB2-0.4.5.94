using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Loki.Game.GameData;

public class DatMinimapIconWrapper
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 42)]
	internal struct Struct118
	{
		[FieldOffset(0)]
		public long long_0;

		[FieldOffset(8)]
		public int int_0;

		[FieldOffset(12)]
		public int int_1;

		[FieldOffset(16)]
		public bool bool_0;

		[FieldOffset(17)]
		public bool bool_1;

		[FieldOffset(18)]
		public int int_2;

		[SpecialName]
		public bool method_0()
		{
			return true;
		}

		static Struct118()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private readonly int int_0;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly int int_1;

	[CompilerGenerated]
	private readonly int int_2;

	[CompilerGenerated]
	private readonly int int_3;

	[CompilerGenerated]
	private readonly bool bool_0;

	[CompilerGenerated]
	private readonly bool bool_1;

	[CompilerGenerated]
	private readonly bool bool_2;

	[CompilerGenerated]
	private readonly long long_0;

	internal static DatMinimapIconWrapper datMinimapIconWrapper_0;

	public required int Index
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

	public required string Name
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

	public required int LargeMinimapSize
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

	public required int SmallMinimapSize
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

	public required int MinimapIconPointerMaxDistance
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

	public required bool _B1
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	public required bool _B2
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	public required bool _B3
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	public required long BaseAddress
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

	internal DatMinimapIconWrapper()
	{
	}

	internal DatMinimapIconWrapper(long address)
	{
	}

	[SpecialName]
	internal static Memory smethod_0()
	{
		return null;
	}

	internal static bool smethod_1()
	{
		return true;
	}

	internal static DatMinimapIconWrapper smethod_2()
	{
		return null;
	}

	static DatMinimapIconWrapper()
	{
		Class200.smethod_34();
	}
}
