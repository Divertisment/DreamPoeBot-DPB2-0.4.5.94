using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Loki.FilesInMemory;

public class DeliriumStashTabLayouts : FileInMemory<DeliriumStashTabLayouts.DeliriumStashTabLayoutHardcoded>
{
	public class DeliriumStashTabLayoutHardcoded
	{
		[CompilerGenerated]
		private long long_0;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private short short_0;

		[CompilerGenerated]
		private short short_1;

		[CompilerGenerated]
		private short? nullable_0;

		[CompilerGenerated]
		private short short_2;

		[CompilerGenerated]
		private byte byte_0;

		[CompilerGenerated]
		private bool bool_0;

		[CompilerGenerated]
		private short short_3;

		[CompilerGenerated]
		private short short_4;

		private static DeliriumStashTabLayoutHardcoded deliriumStashTabLayoutHardcoded_0;

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

		public byte CategoryIndex
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

		public short SlotSize
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

		public short SlotStyle
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

		public DeliriumStashTabLayoutHardcoded(string metadata, short posX, short posY, short firstSlotIndex, short? storedItem, byte categoryIndex, bool showIfEmpty, short slotSize, short slotStyle)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static DeliriumStashTabLayoutHardcoded smethod_1()
		{
			return null;
		}

		static DeliriumStashTabLayoutHardcoded()
		{
			Class200.smethod_34();
		}
	}

	public class DeliriumStashTabLayoutJson
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
		private short short_5;

		[CompilerGenerated]
		private byte byte_0;

		[CompilerGenerated]
		private short short_6;

		[CompilerGenerated]
		private bool bool_0;

		internal static DeliriumStashTabLayoutJson deliriumStashTabLayoutJson_0;

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

		public short SlotSize
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

		public byte Unknown9
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

		public short SlotStyle
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

		internal static DeliriumStashTabLayoutJson smethod_1()
		{
			return null;
		}

		static DeliriumStashTabLayoutJson()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct Struct142
	{
		internal long Id;

		internal Struct28 struct28_0;

		internal int int_0;

		internal int int_1;

		internal int int_2;

		internal int Width;

		internal int int_3;

		internal int int_4;

		internal int int_5;

		internal Struct28 struct28_1;

		internal byte byte_0;
	}

	private Dictionary<string, DeliriumStashTabLayoutHardcoded> dictionary_2;

	internal static DeliriumStashTabLayouts deliriumStashTabLayouts_0;

	public Dictionary<string, DeliriumStashTabLayoutHardcoded> Data => null;

	public DeliriumStashTabLayouts(Memory m, long address)
	{
	}

	private protected override long vmethod_0(DeliriumStashTabLayoutHardcoded record)
	{
		return 0L;
	}

	private protected override void vmethod_1()
	{
	}

	[CompilerGenerated]
	private DeliriumStashTabLayoutHardcoded method_3(Struct142 struct142_0, long long_6, int int_2)
	{
		return null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static DeliriumStashTabLayouts smethod_5()
	{
		return null;
	}

	static DeliriumStashTabLayouts()
	{
		Class200.smethod_34();
	}
}
