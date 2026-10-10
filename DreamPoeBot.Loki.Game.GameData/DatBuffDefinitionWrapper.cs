using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Loki.Game.GameData;

public class DatBuffDefinitionWrapper
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 351)]
	internal struct Struct105
	{
		[FieldOffset(0)]
		public long long_0;

		[FieldOffset(8)]
		public long long_1;

		[FieldOffset(16)]
		public byte byte_0;

		[FieldOffset(17)]
		public byte byte_1;

		[FieldOffset(18)]
		public long long_2;

		[FieldOffset(26)]
		public int int_0;

		[FieldOffset(30)]
		public int int_1;

		[FieldOffset(34)]
		public long long_3;

		[FieldOffset(43)]
		public int int_2;

		[FieldOffset(103)]
		public int int_3;

		[FieldOffset(116)]
		public long long_4;

		[FieldOffset(143)]
		public int int_4;
	}

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private string string_2;

	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	private string string_3;

	[CompilerGenerated]
	private int int_2;

	[CompilerGenerated]
	private int int_3;

	[CompilerGenerated]
	private Struct105 struct105_0;

	private static DatBuffDefinitionWrapper datBuffDefinitionWrapper_0;

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

	public string Desc
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

	public string Id
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

	public int BuffType
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

	public string Implementation
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

	public int MergeMode
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

	public int UIStackMode
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

	[SpecialName]
	internal Memory method_0()
	{
		return null;
	}

	[SpecialName]
	[CompilerGenerated]
	internal Struct105 method_1()
	{
		return (Struct105)(object)null;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_2(Struct105 struct105_1)
	{
	}

	internal DatBuffDefinitionWrapper(Struct105 native, int index)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static DatBuffDefinitionWrapper smethod_1()
	{
		return null;
	}

	static DatBuffDefinitionWrapper()
	{
		Class200.smethod_34();
	}
}
