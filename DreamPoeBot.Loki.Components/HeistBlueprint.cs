using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class HeistBlueprint : Component
{
	public class Room
	{
		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private int int_0;

		private static Room room_0;

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

		public int Revealed
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

		public Room(string id, int revealed)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Room smethod_1()
		{
			return null;
		}

		static Room()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct205
	{
		public long long_0;

		public long long_1;

		public long long_2;

		public int int_0;

		public byte byte_0;

		public byte byte_1;

		public byte byte_2;

		public byte byte_3;

		public NativeVector nativeVector_0;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct206
	{
		public NativeVector nativeVector_0;

		public byte byte_0;

		public byte byte_1;

		public byte byte_2;

		public byte byte_3;

		public int int_0;

		public NativeVector nativeVector_1;

		public NativeVector nativeVector_2;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct207
	{
		public long long_0;

		public long long_1;

		public byte byte_0;

		public byte byte_1;

		public byte byte_2;

		public byte byte_3;

		public byte byte_4;

		public byte byte_5;

		public byte byte_6;

		public byte byte_7;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct208
	{
		public long Id;

		public long Name;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct209
	{
		public long long_0;

		public long long_1;

		public byte byte_0;

		public byte byte_1;

		public byte byte_2;

		public byte byte_3;

		public byte byte_4;

		public byte byte_5;

		public byte byte_6;

		public byte byte_7;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct210
	{
		public long long_0;

		public long long_1;

		public long long_2;

		public long long_3;

		public long long_4;

		public int int_0;

		public int int_1;

		public int int_2;

		public long long_5;

		public int int_3;

		public int int_4;

		public long long_6;

		public int int_5;
	}

	private PerFrameCachedValue<Struct205> perFrameCachedValue_0;

	private PerFrameCachedValue<List<Struct206>> perFrameCachedValue_1;

	private PerFrameCachedValue<List<Struct207>> perFrameCachedValue_2;

	private PerFrameCachedValue<List<Struct209>> perFrameCachedValue_3;

	private static HeistBlueprint heistBlueprint_0;

	public int AreaLevel => 0;

	public int RevealedWings => 0;

	public int UnRevealedWings => 0;

	public string HeistTarget => null;

	public List<Room> Rooms => null;

	private string method_2(string string_0)
	{
		return null;
	}

	[SpecialName]
	internal Struct205 method_3()
	{
		return (Struct205)(object)null;
	}

	[SpecialName]
	internal List<Struct206> method_4()
	{
		return null;
	}

	[SpecialName]
	internal List<Struct207> method_5()
	{
		return null;
	}

	[SpecialName]
	internal List<Struct209> method_6()
	{
		return null;
	}

	private List<Struct206> method_7()
	{
		return null;
	}

	private List<Struct207> method_8()
	{
		return null;
	}

	private List<Struct209> method_9()
	{
		return null;
	}

	[CompilerGenerated]
	private Struct205 method_10()
	{
		return (Struct205)(object)null;
	}

	[CompilerGenerated]
	private List<Struct206> method_11()
	{
		return null;
	}

	[CompilerGenerated]
	private List<Struct207> method_12()
	{
		return null;
	}

	[CompilerGenerated]
	private List<Struct209> method_13()
	{
		return null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static HeistBlueprint smethod_5()
	{
		return null;
	}

	static HeistBlueprint()
	{
		Class200.smethod_34();
	}
}
