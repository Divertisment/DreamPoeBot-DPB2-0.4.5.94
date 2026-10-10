using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Loki.Game.GameData;

public class DatStatWrapper
{
	public enum StatType
	{
		Unknown,
		Percents,
		Value2,
		IntValue,
		Boolean,
		Precents5
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 106)]
	internal struct Struct125
	{
		[FieldOffset(0)]
		public long long_0;

		[FieldOffset(11)]
		public uint uint_0;

		[FieldOffset(34)]
		public uint uint_1;

		[SpecialName]
		public long method_0()
		{
			return 0L;
		}

		static Struct125()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly string string_1;

	[CompilerGenerated]
	private readonly uint uint_0;

	[CompilerGenerated]
	private readonly int int_0;

	[CompilerGenerated]
	private readonly long long_0;

	[CompilerGenerated]
	private readonly StatType statType_0;

	private static DatStatWrapper datStatWrapper_0;

	[Obsolete("DO NOT USE")]
	public string ApiId => null;

	public string Description => null;

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

	public string InternalName => null;

	public string Name
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

	public string StatTypeGGG => null;

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

	public StatTypeGGG EnumType => (StatTypeGGG)(object)null;

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

	public StatType Type
	{
		[CompilerGenerated]
		get
		{
			return (StatType)(object)null;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	[Obsolete("SEE STATSDAT.cs instead.")]
	internal DatStatWrapper(long ptr)
	{
	}

	internal DatStatWrapper()
	{
	}

	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	private static Memory smethod_0()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static string flmsctvfw3(string string_2)
	{
		return null;
	}

	internal static bool smethod_1()
	{
		return true;
	}

	internal static DatStatWrapper smethod_2()
	{
		return null;
	}

	static DatStatWrapper()
	{
		Class200.smethod_34();
	}
}
