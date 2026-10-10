using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Loki.Game.GameData;

public class DatWordsWrapper
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct131
	{
		public int int_0;

		public long long_0;

		public int int_1;

		public int int_2;

		public long long_1;

		public int int_3;

		public int int_4;

		public long long_2;

		public uint uint_0;

		public long long_3;

		public long long_4;
	}

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private Struct131 struct131_0;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private uint uint_0;

	private readonly List<string> list_0;

	internal static DatWordsWrapper datWordsWrapper_0;

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

	public string OriginalName
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

	public string RealName
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

	public uint Hash
	{
		[CompilerGenerated]
		get
		{
			return 0u;
		}
		[CompilerGenerated]
		internal set
		{
		}
	}

	public List<string> Tags => null;

	[SpecialName]
	internal Memory method_0()
	{
		return null;
	}

	[SpecialName]
	[CompilerGenerated]
	internal Struct131 method_1()
	{
		return (Struct131)(object)null;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_2(Struct131 struct131_1)
	{
	}

	internal DatWordsWrapper(Struct131 native, int index)
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

	internal static DatWordsWrapper smethod_1()
	{
		return null;
	}

	static DatWordsWrapper()
	{
		Class200.smethod_34();
	}
}
