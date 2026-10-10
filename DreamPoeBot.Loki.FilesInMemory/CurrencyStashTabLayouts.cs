using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Loki.FilesInMemory;

public class CurrencyStashTabLayouts : FileInMemory<CurrencyStashTabLayouts.CurrencyStashTabLayoutHardcoded>
{
	public class CurrencyStashTabLayoutHardcoded
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
		private bool bool_0;

		[CompilerGenerated]
		private short? nullable_0;

		private static CurrencyStashTabLayoutHardcoded currencyStashTabLayoutHardcoded_0;

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

		public CurrencyStashTabLayoutHardcoded(string metadata, short posX, short posY, short order, byte category, bool showIfEmpty, short? storedItem)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static CurrencyStashTabLayoutHardcoded smethod_1()
		{
			return null;
		}

		static CurrencyStashTabLayoutHardcoded()
		{
			Class200.smethod_34();
		}
	}

	public class CurrencyStashTabLayoutJson
	{
		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private string iYilHhfysmA;

		[CompilerGenerated]
		private short? nullable_0;

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

		internal static CurrencyStashTabLayoutJson currencyStashTabLayoutJson_0;

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

		public byte SlotGroup
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

		internal static CurrencyStashTabLayoutJson smethod_1()
		{
			return null;
		}

		static CurrencyStashTabLayoutJson()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct Struct141
	{
		internal long long_0;

		internal Struct28 struct28_0;

		internal int int_0;

		internal int int_1;

		internal int int_2;

		internal int Width;

		internal int int_3;

		internal byte byte_0;

		internal int int_4;

		internal int int_5;

		internal Struct28 struct28_1;
	}

	private Dictionary<string, CurrencyStashTabLayoutHardcoded> dictionary_2;

	internal static CurrencyStashTabLayouts currencyStashTabLayouts_0;

	public Dictionary<string, CurrencyStashTabLayoutHardcoded> Data => null;

	public CurrencyStashTabLayouts(Memory m, long address)
	{
	}

	private void method_3(int int_2, int int_3, int int_4, int int_5, string string_1)
	{
	}

	private protected override long vmethod_0(CurrencyStashTabLayoutHardcoded record)
	{
		return 0L;
	}

	private protected override void vmethod_1()
	{
	}

	[CompilerGenerated]
	private CurrencyStashTabLayoutHardcoded method_4(Struct141 struct141_0, long long_6, int int_2)
	{
		return null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static CurrencyStashTabLayouts smethod_5()
	{
		return null;
	}

	static CurrencyStashTabLayouts()
	{
		Class200.smethod_34();
	}
}
