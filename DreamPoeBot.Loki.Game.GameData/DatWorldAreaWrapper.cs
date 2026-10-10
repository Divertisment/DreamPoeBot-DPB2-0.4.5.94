using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.FilesInMemory;
using ns0;

namespace DreamPoeBot.Loki.Game.GameData;

public class DatWorldAreaWrapper
{
	[StructLayout(LayoutKind.Explicit, Size = 736)]
	internal struct Struct132
	{
		[FieldOffset(0)]
		public long Id;

		[FieldOffset(8)]
		public long long_0;

		[FieldOffset(16)]
		public int int_0;

		[FieldOffset(20)]
		public bool bool_0;

		[FieldOffset(21)]
		public bool bool_1;

		[FieldOffset(22)]
		private long long_1;

		[FieldOffset(30)]
		public long long_2;

		[FieldOffset(38)]
		public int int_1;

		[FieldOffset(42)]
		public ushort ushort_0;

		[FieldOffset(156)]
		private long long_3;

		[FieldOffset(164)]
		public long long_4;

		[FieldOffset(220)]
		public bool bool_2;

		[FieldOffset(269)]
		public Struct133 struct133_0;

		[FieldOffset(298)]
		public bool bool_3;

		[FieldOffset(307)]
		private long long_5;

		[FieldOffset(315)]
		public long long_6;

		internal static object object_0;

		[SpecialName]
		public int method_0()
		{
			return 0;
		}

		[SpecialName]
		public int method_1()
		{
			return 0;
		}

		[SpecialName]
		public int method_2()
		{
			return 0;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static object smethod_1()
		{
			return null;
		}

		static Struct132()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
	internal struct Struct133
	{
		public readonly int int_0;

		private readonly int Padding;

		public readonly long long_0;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 704)]
	internal struct Struct134
	{
		public long Id;

		public long long_0;

		public int int_0;

		public bool bool_0;

		public bool bool_1;

		public int int_1;

		private int int_2;

		public long long_1;

		public int int_3;

		public ushort ushort_0;

		private short short_0;

		private int int_4;

		private int int_5;

		private int int_6;

		private short short_1;

		private long long_2;

		private long long_3;

		private long long_4;

		private long long_5;

		private long long_6;

		private int int_7;

		private int int_8;

		private int int_9;

		private long long_7;

		private long long_8;

		private int int_10;

		private long long_9;

		private long long_10;

		private long long_11;

		private long long_12;

		public int int_11;

		private int int_12;

		public long long_13;

		private int int_13;

		private int int_14;

		private long long_14;

		private int int_15;

		private int int_16;

		private long long_15;

		private int int_17;

		private int int_18;

		private long long_16;

		public bool bool_2;

		private int int_19;

		private int int_20;

		private long long_17;

		private long long_18;

		private int int_21;

		private int int_22;

		private int int_23;

		private int int_24;

		private int int_25;

		private int int_26;

		private long long_19;

		private int int_27;

		private byte byte_0;

		private int int_28;

		private int int_29;

		public bool bool_3;
	}

	[CompilerGenerated]
	private sealed class _003Cget_Connections_003Ed__88 : IEnumerable<DatWorldAreaWrapper>, IEnumerable, IEnumerator<DatWorldAreaWrapper>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private DatWorldAreaWrapper _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public DatWorldAreaWrapper _003C_003E4__this;

		private long[] _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		internal static _003Cget_Connections_003Ed__88 _003Cget_Connections_003Ed__88_0;

		DatWorldAreaWrapper IEnumerator<DatWorldAreaWrapper>.Current => null;

		object IEnumerator.Current => null;

		public _003Cget_Connections_003Ed__88(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}

		IEnumerator<DatWorldAreaWrapper> IEnumerable<DatWorldAreaWrapper>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static _003Cget_Connections_003Ed__88 smethod_1()
		{
			return null;
		}

		static _003Cget_Connections_003Ed__88()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private readonly long long_0;

	[CompilerGenerated]
	private readonly int int_0;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly string string_1;

	[CompilerGenerated]
	private readonly int int_1;

	[CompilerGenerated]
	private readonly bool bool_0;

	[CompilerGenerated]
	private readonly bool bool_1;

	[CompilerGenerated]
	private bool bool_2;

	[CompilerGenerated]
	private readonly bool bool_3;

	[CompilerGenerated]
	private readonly ushort ushort_0;

	[CompilerGenerated]
	private readonly int int_2;

	[CompilerGenerated]
	private long[] long_1;

	[CompilerGenerated]
	private long[] long_2;

	[CompilerGenerated]
	private long[] long_3;

	[CompilerGenerated]
	private long[] long_4;

	internal static DatWorldAreaWrapper datWorldAreaWrapper_0;

	public long Address
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

	public int Index
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

	public string Id
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

	public string Name
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

	public int Act
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

	public bool IsTown
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

	public bool HasWaypoint
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

	public bool IsMap
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
		[CompilerGenerated]
		internal set
		{
		}
	}

	public bool IsAtlasMap => true;

	public bool IsMapWorlds => true;

	public bool IsCorruptedArea => true;

	public bool IsMissionArea => true;

	public bool IsDenArea => true;

	public bool IsDailyArea => true;

	public bool IsRelicArea => true;

	public required bool IsHideoutArea
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

	public bool IsMyHideoutArea => true;

	public bool IsMyGuildHideoutArea => true;

	public bool IsLabyrinthArea => true;

	public bool IsMenagerieArea => true;

	public bool IsMapRoom => true;

	public bool IsMapTrialArea => true;

	public bool IsAbyssArea => true;

	public bool IsOverworldArea => true;

	public required ushort WorldAreaId
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

	public required int MonsterLevel
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

	public bool IsCombatArea => true;

	public bool IsTempleOfAtzoatl => true;

	public DatWorldAreaWrapper GoverningTown => null;

	public List<DatMonsterVarietyWrapper> Bosses => null;

	public List<DatModsWrapper> AreaMods => null;

	public IEnumerable<DatWorldAreaWrapper> Connections
	{
		[IteratorStateMachine(typeof(_003Cget_Connections_003Ed__88))]
		get
		{
			return null;
		}
	}

	public List<DatTagWrapper> Tags => null;

	internal DatWorldAreaWrapper()
	{
	}

	[SpecialName]
	private string method_0()
	{
		return null;
	}

	[SpecialName]
	internal Memory method_1()
	{
		return null;
	}

	[SpecialName]
	[CompilerGenerated]
	internal long[] method_2()
	{
		return null;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_3(long[] long_5)
	{
	}

	[SpecialName]
	[CompilerGenerated]
	internal long[] method_4()
	{
		return null;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_5(long[] long_5)
	{
	}

	[SpecialName]
	[CompilerGenerated]
	internal long[] method_6()
	{
		return null;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_7(long[] long_5)
	{
	}

	[SpecialName]
	[CompilerGenerated]
	internal long[] method_8()
	{
		return null;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_9(long[] long_5)
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

	internal static DatWorldAreaWrapper smethod_1()
	{
		return null;
	}

	static DatWorldAreaWrapper()
	{
		Class200.smethod_34();
	}
}
