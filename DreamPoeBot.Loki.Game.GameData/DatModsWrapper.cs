using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using DreamPoeBot.Loki.FilesInMemory;
using ns0;

namespace DreamPoeBot.Loki.Game.GameData;

public record DatModsWrapper
{
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

	public required string InternalName
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

	public required ushort Hash16
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

	public required int Level
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

	public required Domain Domain
	{
		[CompilerGenerated]
		get
		{
			return (Domain)(object)null;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	public required string DisplayName
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

	public required ModType ModType
	{
		[CompilerGenerated]
		get
		{
			return (ModType)(object)null;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	public required string Category
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

	public StatContainer[] Stats
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

	public DatTagWrapper[] Tags
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		internal init
		{
		}
	}

	public bool IsEssenceExclusive
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
	private readonly int int_0;

	[CompilerGenerated]
	private readonly long long_0;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly ushort ushort_0;

	[CompilerGenerated]
	private readonly int int_1;

	[CompilerGenerated]
	private readonly Domain domain_0;

	[CompilerGenerated]
	private readonly string string_1;

	[CompilerGenerated]
	private readonly ModType modType_0;

	[CompilerGenerated]
	private readonly string string_2;

	[CompilerGenerated]
	private StatContainer[] statContainer_0;

	[CompilerGenerated]
	private readonly DatTagWrapper[] datTagWrapper_0;

	[CompilerGenerated]
	private readonly bool bool_0;

	[CompilerGenerated]
	private readonly uint sQaRziQgvn;

	internal static DatModsWrapper datModsWrapper_0;

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

	[SetsRequiredMembers]
	[CompilerGenerated]
	protected DatModsWrapper(DatModsWrapper original)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static DatModsWrapper smethod_1()
	{
		return null;
	}

	static DatModsWrapper()
	{
		Class200.smethod_34();
	}
}
