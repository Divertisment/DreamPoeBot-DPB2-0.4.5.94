using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Loki.FilesInMemory;

public class BlightStashTabLayouts : FileInMemory<BlightStashTabLayouts.BlightStashTabLayoutHardcoded>
{
	public class BlightStashTabLayoutHardcoded
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

		internal static BlightStashTabLayoutHardcoded blightStashTabLayoutHardcoded_0;

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

		public BlightStashTabLayoutHardcoded(string metadata, short posX, short posY, short order)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static BlightStashTabLayoutHardcoded smethod_1()
		{
			return null;
		}

		static BlightStashTabLayoutHardcoded()
		{
			Class200.smethod_34();
		}
	}

	public class BlightStashTabLayoutHardcodedJson
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
		private int int_1;

		[CompilerGenerated]
		private int int_2;

		[CompilerGenerated]
		private int int_3;

		[CompilerGenerated]
		private bool bool_0;

		[CompilerGenerated]
		private bool bool_1;

		[CompilerGenerated]
		private bool bool_2;

		[CompilerGenerated]
		private bool bool_3;

		private static BlightStashTabLayoutHardcodedJson blightStashTabLayoutHardcodedJson_0;

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

		public bool Unknown10
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

		public bool Unknown12
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

		internal static BlightStashTabLayoutHardcodedJson smethod_1()
		{
			return null;
		}

		static BlightStashTabLayoutHardcodedJson()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct Struct139
	{
		internal long Id;

		internal Struct28 struct28_0;

		internal int int_0;

		internal int int_1;

		internal int int_2;

		internal int Width;

		internal int int_3;

		internal int int_4;

		internal byte byte_0;

		internal byte byte_1;

		internal byte byte_2;

		internal byte byte_3;
	}

	private Dictionary<string, BlightStashTabLayoutHardcoded> dictionary_2;

	private static BlightStashTabLayouts blightStashTabLayouts_0;

	public Dictionary<string, BlightStashTabLayoutHardcoded> Data => null;

	public BlightStashTabLayouts(Memory m, long address)
	{
	}

	public BlightStashTabLayouts()
	{
	}

	private protected override long vmethod_0(BlightStashTabLayoutHardcoded record)
	{
		return 0L;
	}

	private protected override void vmethod_1()
	{
	}

	[CompilerGenerated]
	private BlightStashTabLayoutHardcoded method_3(Struct139 struct139_0, long long_6, int int_2)
	{
		return null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static BlightStashTabLayouts smethod_5()
	{
		return null;
	}

	static BlightStashTabLayouts()
	{
		Class200.smethod_34();
	}
}
