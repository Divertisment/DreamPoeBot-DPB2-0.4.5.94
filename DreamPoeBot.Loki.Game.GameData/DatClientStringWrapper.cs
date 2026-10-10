using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using ns0;

namespace DreamPoeBot.Loki.Game.GameData;

public record DatClientStringWrapper
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 52)]
	internal struct Struct106
	{
		[FieldOffset(0)]
		public long long_0;

		[FieldOffset(8)]
		public long long_1;

		[FieldOffset(16)]
		private long long_2;

		[FieldOffset(24)]
		private long long_3;

		[FieldOffset(32)]
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

	public required string Key
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

	public required string Value
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

	public required uint Hash32
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

	[CompilerGenerated]
	private readonly int int_0;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly string string_1;

	[CompilerGenerated]
	private readonly uint uint_0;

	[CompilerGenerated]
	private readonly long long_0;

	internal static DatClientStringWrapper datClientStringWrapper_0;

	[CompilerGenerated]
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
	protected DatClientStringWrapper(DatClientStringWrapper original)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static DatClientStringWrapper smethod_1()
	{
		return null;
	}

	static DatClientStringWrapper()
	{
		Class200.smethod_34();
	}
}
