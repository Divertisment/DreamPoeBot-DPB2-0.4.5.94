using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Loki.FilesInMemory;

public class EndGameMapContent : FileInMemory<EndGameMapContent.EndGameMapContentHardcoded>
{
	public class EndGameMapContentHardcoded
	{
		[CompilerGenerated]
		private long long_0;

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private List<string> list_0;

		[CompilerGenerated]
		private List<int> list_1;

		[CompilerGenerated]
		private string string_1;

		[CompilerGenerated]
		private string string_2;

		[CompilerGenerated]
		private int? nullable_0;

		[CompilerGenerated]
		private int? nullable_1;

		internal static EndGameMapContentHardcoded endGameMapContentHardcoded_0;

		internal long Address
		{
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int index
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

		public List<string> Stats
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

		public List<int> StatValues
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string Description
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

		public int? MapObjective
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

		public int? VisualIdentity
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

		public EndGameMapContentHardcoded(string id, List<string> stats, List<int> statsValues, string description, string name, int? mapObjective, int? visualIdentity)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static EndGameMapContentHardcoded smethod_1()
		{
			return null;
		}

		static EndGameMapContentHardcoded()
		{
			Class200.smethod_34();
		}
	}

	public class EndGameMapContentHardcodedJson
	{
		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private List<string> list_0;

		[CompilerGenerated]
		private List<int> list_1;

		[CompilerGenerated]
		private string string_1;

		[CompilerGenerated]
		private string string_2;

		[CompilerGenerated]
		private int int_1;

		[CompilerGenerated]
		private int? nullable_0;

		[CompilerGenerated]
		private int? nullable_1;

		[CompilerGenerated]
		private bool bool_0;

		private static EndGameMapContentHardcodedJson endGameMapContentHardcodedJson_0;

		public int _rid
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
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
			set
			{
			}
		}

		public List<string> Stats
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public List<int> StatValues
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string Description
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
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
			set
			{
			}
		}

		public int Unknown6
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int? MapObjective
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int? VisualIdentity
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool Unknown9
		{
			[CompilerGenerated]
			get
			{
				return true;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static EndGameMapContentHardcodedJson smethod_1()
		{
			return null;
		}

		static EndGameMapContentHardcodedJson()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct Struct143
	{
		internal long Id;

		internal long long_0;

		internal long long_1;

		internal long long_2;

		internal long long_3;

		internal long Description;

		internal long Name;

		internal int int_0;

		internal Struct28 struct28_0;

		internal Struct28 struct28_1;

		internal byte byte_0;
	}

	private Dictionary<int, EndGameMapContentHardcoded> dictionary_2;

	private static EndGameMapContent endGameMapContent_0;

	public Dictionary<int, EndGameMapContentHardcoded> Data => null;

	public EndGameMapContent(Memory m)
	{
	}

	public EndGameMapContent(Memory m, long address)
	{
	}

	private List<string> method_3(long long_6, long long_7, int int_2)
	{
		return null;
	}

	private List<int> method_4(long long_6, long long_7, int int_2, string string_1)
	{
		return null;
	}

	private int method_5(long long_6, long long_7, int int_2, string string_1)
	{
		return 0;
	}

	private string method_6(long long_6)
	{
		return null;
	}

	private protected override long vmethod_0(EndGameMapContentHardcoded record)
	{
		return 0L;
	}

	private protected override void vmethod_1()
	{
	}

	[CompilerGenerated]
	private EndGameMapContentHardcoded method_7(Struct143 struct143_0, long long_6, int int_2)
	{
		return null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static EndGameMapContent smethod_5()
	{
		return null;
	}

	static EndGameMapContent()
	{
		Class200.smethod_34();
	}
}
