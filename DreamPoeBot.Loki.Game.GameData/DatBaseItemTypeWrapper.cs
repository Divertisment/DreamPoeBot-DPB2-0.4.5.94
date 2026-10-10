using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using ns0;

namespace DreamPoeBot.Loki.Game.GameData;

public record DatBaseItemTypeWrapper
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 360)]
	internal struct Struct102
	{
		[FieldOffset(0)]
		public long long_0;

		[FieldOffset(8)]
		public long long_1;

		[FieldOffset(24)]
		public int Width;

		[FieldOffset(28)]
		public int int_0;

		[FieldOffset(32)]
		public long mjGlgelcDs8;

		[FieldOffset(40)]
		public long long_2;

		[FieldOffset(48)]
		public int int_1;

		[FieldOffset(68)]
		public long long_3;

		[FieldOffset(104)]
		public long long_4;

		[FieldOffset(112)]
		public long long_5;

		[FieldOffset(140)]
		public uint uint_0;
	}

	[CompilerGenerated]
	protected virtual Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public required long Address
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

	public required string Metadata
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

	public required string ItemClass
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

	public required string InheritsMetadata
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

	public required int Width
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

	public required int Height
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

	public required int DropLevel
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

	public string[] Tags
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		internal set
		{
		}
	}

	public string[] MoreTagsFromPath
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		internal set
		{
		}
	}

	public uint Hash32
	{
		[CompilerGenerated]
		get
		{
			return 0u;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	[CompilerGenerated]
	private readonly Enum0 enum0_0;

	[CompilerGenerated]
	private readonly long long_0;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly string string_1;

	[CompilerGenerated]
	private readonly string string_2;

	[CompilerGenerated]
	private readonly int int_0;

	[CompilerGenerated]
	private readonly int int_1;

	[CompilerGenerated]
	private readonly int int_2;

	[CompilerGenerated]
	private readonly string string_3;

	[CompilerGenerated]
	private readonly int int_3;

	[CompilerGenerated]
	private string[] string_4;

	[CompilerGenerated]
	private string[] string_5;

	[CompilerGenerated]
	private readonly uint uint_0;

	internal static DatBaseItemTypeWrapper datBaseItemTypeWrapper_0;

	[SpecialName]
	[CompilerGenerated]
	internal Enum0 method_0()
	{
		return (Enum0)(object)null;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_1(Enum0 enum0_1)
	{
	}

	[SpecialName]
	private Memory method_2()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	[CompilerGenerated]
	protected virtual bool PrintMembers(StringBuilder builder)
	{
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	protected DatBaseItemTypeWrapper(DatBaseItemTypeWrapper original)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static DatBaseItemTypeWrapper smethod_1()
	{
		return null;
	}

	static DatBaseItemTypeWrapper()
	{
		Class200.smethod_34();
	}
}
