using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Loki.FilesInMemory;

public class FragmentStashTabLayouts : FileInMemory<FragmentStashTabLayouts.FragmentStashTabLayoutHardcoded>
{
	public class FragmentStashTabLayoutHardcoded
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
		private short short_2;

		[CompilerGenerated]
		private byte byte_0;

		[CompilerGenerated]
		private short? nullable_0;

		[CompilerGenerated]
		private bool bool_0;

		[CompilerGenerated]
		private bool bool_1;

		[CompilerGenerated]
		private int int_0;

		private static FragmentStashTabLayoutHardcoded fragmentStashTabLayoutHardcoded_0;

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

		public short Order
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

		public byte Tab
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

		public bool HideIfEmpty
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

		public bool NotInGame
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

		public int SlotSize
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

		public FragmentStashTabLayoutHardcoded(string metadata, short posX, short posY, short order, byte tab, short? baseItemTypes, bool hideIfEmpty, int slotsize, bool notInGame)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static FragmentStashTabLayoutHardcoded smethod_1()
		{
			return null;
		}

		static FragmentStashTabLayoutHardcoded()
		{
			Class200.smethod_34();
		}
	}

	public class FragmentStashTabLayoutJson
	{
		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private short short_0;

		[CompilerGenerated]
		private short short_1;

		[CompilerGenerated]
		private short short_2;

		[CompilerGenerated]
		private int int_1;

		[CompilerGenerated]
		private int int_2;

		[CompilerGenerated]
		private bool bool_0;

		[CompilerGenerated]
		private byte byte_0;

		[CompilerGenerated]
		private int int_3;

		[CompilerGenerated]
		private short? nullable_0;

		[CompilerGenerated]
		private bool bool_1;

		[CompilerGenerated]
		private int int_4;

		internal static FragmentStashTabLayoutJson fragmentStashTabLayoutJson_0;

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

		public int Width
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

		public int Height
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

		public bool HideIfEmpty
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

		public byte Tab
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

		public int SlotSize
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

		public short? BaseItemType
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

		public bool Unknown11
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

		public int SlotStyle
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

		internal static bool smethod_0()
		{
			return true;
		}

		internal static FragmentStashTabLayoutJson smethod_1()
		{
			return null;
		}

		static FragmentStashTabLayoutJson()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct Struct147
	{
		internal long Id;

		internal int int_0;

		internal int int_1;

		internal int int_2;

		internal int Width;

		internal int int_3;

		internal byte byte_0;

		internal int Tab;

		internal int int_4;

		internal Struct28 struct28_0;

		internal byte byte_1;

		internal Struct28 struct28_1;
	}

	private Dictionary<string, FragmentStashTabLayoutHardcoded> dictionary_2;

	internal static FragmentStashTabLayouts fragmentStashTabLayouts_0;

	public Dictionary<string, FragmentStashTabLayoutHardcoded> Data => null;

	public FragmentStashTabLayouts(Memory m, long address)
	{
	}

	private protected override long vmethod_0(FragmentStashTabLayoutHardcoded record)
	{
		return 0L;
	}

	private protected override void vmethod_1()
	{
	}

	[CompilerGenerated]
	private FragmentStashTabLayoutHardcoded method_3(Struct147 struct147_0, long long_6, int int_2)
	{
		return null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static FragmentStashTabLayouts smethod_5()
	{
		return null;
	}

	static FragmentStashTabLayouts()
	{
		Class200.smethod_34();
	}
}
