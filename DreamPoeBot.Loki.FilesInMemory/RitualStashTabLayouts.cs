using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Loki.FilesInMemory;

public class RitualStashTabLayouts : FileInMemory<RitualStashTabLayouts.RitualStashTabLayoutHardcoded>
{
	public class RitualStashTabLayoutHardcoded
	{
		[CompilerGenerated]
		private long long_0;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private short? nullable_0;

		[CompilerGenerated]
		private short short_0;

		[CompilerGenerated]
		private short short_1;

		[CompilerGenerated]
		private short short_2;

		[CompilerGenerated]
		private bool bool_0;

		private static RitualStashTabLayoutHardcoded ritualStashTabLayoutHardcoded_0;

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

		public string Metadata
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

		public short? StoredItem
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

		public short PosX
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

		public short PosY
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

		public short FirstSlotIndex
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

		public bool ShowIfEmpty
		{
			[CompilerGenerated]
			get
			{
				return true;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public RitualStashTabLayoutHardcoded(string metadata, short? storedItem, short posX, short posY, short firstSlotIndex, bool showIfEmpty)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static RitualStashTabLayoutHardcoded smethod_1()
		{
			return null;
		}

		static RitualStashTabLayoutHardcoded()
		{
			Class200.smethod_34();
		}
	}

	public class RitualStashTabLayoutJson
	{
		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private short? nullable_0;

		[CompilerGenerated]
		private short short_0;

		[CompilerGenerated]
		private short short_1;

		[CompilerGenerated]
		private short short_2;

		[CompilerGenerated]
		private short short_3;

		[CompilerGenerated]
		private short short_4;

		[CompilerGenerated]
		private bool bool_0;

		internal static RitualStashTabLayoutJson ritualStashTabLayoutJson_0;

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

		public short? StoredItem
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

		public short XOffset
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

		public short YOffset
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

		public short FirstSlotIndex
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

		public short Width
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

		public short Height
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

		public bool ShowIfEmpty
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

		internal static RitualStashTabLayoutJson smethod_1()
		{
			return null;
		}

		static RitualStashTabLayoutJson()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct Struct151
	{
		internal long Id;

		internal Struct28 struct28_0;

		internal int int_0;

		internal int int_1;

		internal int int_2;

		internal int Width;

		internal int int_3;

		internal byte byte_0;

		internal int int_4;

		internal Struct28 struct28_1;

		internal long long_0;
	}

	private Dictionary<string, RitualStashTabLayoutHardcoded> dictionary_2;

	private static RitualStashTabLayouts ritualStashTabLayouts_0;

	public Dictionary<string, RitualStashTabLayoutHardcoded> Data => null;

	public RitualStashTabLayouts(Memory m, long address)
	{
	}

	private protected override long vmethod_0(RitualStashTabLayoutHardcoded record)
	{
		return 0L;
	}

	private protected override void vmethod_1()
	{
	}

	[CompilerGenerated]
	private RitualStashTabLayoutHardcoded method_3(Struct151 struct151_0, long long_6, int int_2)
	{
		return null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static RitualStashTabLayouts smethod_5()
	{
		return null;
	}

	static RitualStashTabLayouts()
	{
		Class200.smethod_34();
	}
}
