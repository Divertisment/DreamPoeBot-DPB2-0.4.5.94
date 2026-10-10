using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using ns0;

namespace DreamPoeBot.Loki.Models;

public record QuestFlags
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 12)]
	internal struct Struct54
	{
		[FieldOffset(0)]
		public long long_0;

		[FieldOffset(8)]
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

	public long Hash32
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

	[CompilerGenerated]
	private readonly long long_0;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly long long_1;

	[CompilerGenerated]
	private readonly int int_0;

	internal static QuestFlags questFlags_0;

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
	protected QuestFlags(QuestFlags original)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static QuestFlags smethod_1()
	{
		return null;
	}

	static QuestFlags()
	{
		Class200.smethod_34();
	}
}
