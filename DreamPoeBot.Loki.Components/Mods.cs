using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.FilesInMemory;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Objects;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.Game.Utilities;
using DreamPoeBot.Loki.RemoteMemoryObjects;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class Mods : Component
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct229
	{
		private int int_0;

		private long long_0;

		private int int_1;

		private int int_2;

		private long long_1;

		private int int_3;

		private int int_4;

		private long long_2;

		private ushort ushort_0;

		private ushort ushort_1;

		public long long_3;

		private long long_4;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 624)]
	internal struct Struct230
	{
		public Struct14 struct14_0;

		public long long_0;

		public NativeVector nativeVector_0;

		public GStruct2 gstruct2_0;

		public GStruct2 gstruct2_1;

		public GStruct2 gstruct2_2;

		public byte byte_0;

		private byte byte_1;

		public byte byte_2;

		private byte byte_3;

		public Rarity rarity_0;

		private int int_0;

		private int int_1;

		public NativeVector nativeVector_1;

		public NativeVector nativeVector_2;

		public NativeVector nativeVector_3;

		public NativeVector nativeVector_4;

		public NativeVector nativeVector_5;

		private long long_1;

		private long long_2;

		private long long_3;

		private long long_4;

		private long long_5;

		private long long_6;

		public NativeVector UkclKtudtiL;

		public NativeVector nativeVector_6;

		private NativeVector nativeVector_7;

		private NativeVector nativeVector_8;

		private NativeVector nativeVector_9;

		public long long_7;

		public long long_8;

		public int int_2;

		private byte byte_4;

		private byte byte_5;

		private byte byte_6;

		private byte PfPlKyGmxuy;

		public long long_9;

		private long long_10;

		private long long_11;

		public NativeVector nativeVector_10;

		private long long_12;

		public NativeVector nativeVector_11;

		private long long_13;

		private long long_14;

		private long long_15;

		public int int_3;

		public int int_4;

		internal long long_16;

		public long long_17;

		private long long_18;

		private short short_0;

		private byte byte_7;

		private byte byte_8;

		public byte byte_9;

		public byte byte_10;

		private byte byte_11;

		private byte byte_12;

		public byte byte_13;

		public byte byte_14;

		public byte byte_15;

		public byte byte_16;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct231
	{
		public long long_0;

		public uint uint_0;

		public NativeVector nativeVector_0;

		public NativeHashMap nativeHashMap_0;

		public int int_0;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct232
	{
		public long long_0;

		public long long_1;

		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;

		public int int_5;

		public int int_6;

		public int int_7;

		public InventoryType inventoryType_0;

		public int int_8;

		public long long_2;

		public long long_3;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct233
	{
		public long long_0;

		public GStruct2 gstruct2_0;

		public int int_0;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct234
	{
		public NativeVector nativeVector_0;

		private int int_0;

		private int int_1;

		private int int_2;

		private int int_3;

		public Struct10 struct10_0;

		private int int_4;

		private int int_5;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct235
	{
		private int int_0;

		private int int_1;

		public NativeVector nativeVector_0;

		private long long_0;

		private long long_1;

		private long long_2;

		private long long_3;

		private long long_4;

		public NativeVector nativeVector_1;

		private long long_5;

		private long long_6;

		private long long_7;

		private long long_8;

		private long long_9;

		public NativeVector nativeVector_2;

		private long long_10;

		private long pthlmqumjYp;

		private long long_11;

		private long long_12;

		private long long_13;

		public NativeVector nativeVector_3;

		private long long_14;

		private long long_15;

		private long long_16;

		private long long_17;

		private long long_18;

		public NativeVector QbJlmacPyNR;

		private long QyLlmsBckyA;

		private long long_19;

		private long long_20;

		private long long_21;

		private long long_22;

		public NativeVector nativeVector_4;

		private long long_23;

		private long long_24;

		private long long_25;

		private long long_26;

		private long long_27;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct236
	{
		public long long_0;

		public long long_1;

		public long Description;

		public long long_2;

		public long nqvlmFiwBu8;

		public long long_3;

		public long long_4;
	}

	[CompilerGenerated]
	private sealed class _003Cget_CrucibleAffixes_003Ed__50 : IEnumerable<ModAffix>, IEnumerable, IEnumerator<ModAffix>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private ModAffix _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public Mods _003C_003E4__this;

		private Struct234[] _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		internal static _003Cget_CrucibleAffixes_003Ed__50 _003Cget_CrucibleAffixes_003Ed__50_0;

		ModAffix IEnumerator<ModAffix>.Current => null;

		object IEnumerator.Current => null;

		public _003Cget_CrucibleAffixes_003Ed__50(int _003C_003E1__state)
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

		IEnumerator<ModAffix> IEnumerable<ModAffix>.GetEnumerator()
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

		internal static _003Cget_CrucibleAffixes_003Ed__50 smethod_1()
		{
			return null;
		}

		static _003Cget_CrucibleAffixes_003Ed__50()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private sealed class _003Cget_EnchantmentsAffixes_003Ed__46 : IEnumerable<ModAffix>, IEnumerable, IEnumerator<ModAffix>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private ModAffix _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public Mods _003C_003E4__this;

		private Struct234[] _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		private static _003Cget_EnchantmentsAffixes_003Ed__46 _003Cget_EnchantmentsAffixes_003Ed__46_0;

		ModAffix IEnumerator<ModAffix>.Current => null;

		object IEnumerator.Current => null;

		public _003Cget_EnchantmentsAffixes_003Ed__46(int _003C_003E1__state)
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

		IEnumerator<ModAffix> IEnumerable<ModAffix>.GetEnumerator()
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

		internal static _003Cget_EnchantmentsAffixes_003Ed__46 smethod_1()
		{
			return null;
		}

		static _003Cget_EnchantmentsAffixes_003Ed__46()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private sealed class _003Cget_ExplicitAffixes_003Ed__44 : IEnumerable<ModAffix>, IEnumerable, IEnumerator<ModAffix>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private ModAffix _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public Mods _003C_003E4__this;

		private int _003Cindex_003E5__2;

		private Struct234[] _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private static _003Cget_ExplicitAffixes_003Ed__44 _003Cget_ExplicitAffixes_003Ed__44_0;

		ModAffix IEnumerator<ModAffix>.Current => null;

		object IEnumerator.Current => null;

		public _003Cget_ExplicitAffixes_003Ed__44(int _003C_003E1__state)
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

		IEnumerator<ModAffix> IEnumerable<ModAffix>.GetEnumerator()
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

		internal static _003Cget_ExplicitAffixes_003Ed__44 smethod_1()
		{
			return null;
		}

		static _003Cget_ExplicitAffixes_003Ed__44()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private sealed class _003Cget_IEnumerable_0FullName_003Ed__82 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private string _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public Mods _003C_003E4__this;

		private List<KeyValuePair<long, long>>.Enumerator _003C_003E7__wrap1;

		private static _003Cget_IEnumerable_0FullName_003Ed__82 _003Cget_IEnumerable_0FullName_003Ed__82_0;

		string IEnumerator<string>.Current => null;

		object IEnumerator.Current => null;

		public _003Cget_IEnumerable_0FullName_003Ed__82(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}

		IEnumerator<string> IEnumerable<string>.GetEnumerator()
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

		internal static _003Cget_IEnumerable_0FullName_003Ed__82 smethod_1()
		{
			return null;
		}

		static _003Cget_IEnumerable_0FullName_003Ed__82()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private sealed class _003Cget_ImplicitAffixes_003Ed__42 : IEnumerable<ModAffix>, IEnumerable, IEnumerator<ModAffix>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private ModAffix _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public Mods _003C_003E4__this;

		private Struct234[] _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		internal static _003Cget_ImplicitAffixes_003Ed__42 _003Cget_ImplicitAffixes_003Ed__42_0;

		ModAffix IEnumerator<ModAffix>.Current => null;

		object IEnumerator.Current => null;

		public _003Cget_ImplicitAffixes_003Ed__42(int _003C_003E1__state)
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

		IEnumerator<ModAffix> IEnumerable<ModAffix>.GetEnumerator()
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

		internal static _003Cget_ImplicitAffixes_003Ed__42 smethod_1()
		{
			return null;
		}

		static _003Cget_ImplicitAffixes_003Ed__42()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private sealed class _003Cget_MergedStatsEnumerable_003Ed__52 : IEnumerable<KeyValuePair<StatTypeGGG, int>>, IEnumerable, IEnumerator<KeyValuePair<StatTypeGGG, int>>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private KeyValuePair<StatTypeGGG, int> _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public Mods _003C_003E4__this;

		private List<KeyValuePair<StatTypeGGG, int>>.Enumerator _003C_003E7__wrap1;

		private static _003Cget_MergedStatsEnumerable_003Ed__52 _003Cget_MergedStatsEnumerable_003Ed__52_0;

		KeyValuePair<StatTypeGGG, int> IEnumerator<KeyValuePair<StatTypeGGG, int>>.Current => (KeyValuePair<StatTypeGGG, int>)null;

		object IEnumerator.Current => null;

		public _003Cget_MergedStatsEnumerable_003Ed__52(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}

		IEnumerator<KeyValuePair<StatTypeGGG, int>> IEnumerable<KeyValuePair<StatTypeGGG, int>>.GetEnumerator()
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

		internal static _003Cget_MergedStatsEnumerable_003Ed__52 smethod_1()
		{
			return null;
		}

		static _003Cget_MergedStatsEnumerable_003Ed__52()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private sealed class _003Cget_ScourgeAffixes_003Ed__48 : IEnumerable<ModAffix>, IEnumerable, IEnumerator<ModAffix>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private ModAffix _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public Mods _003C_003E4__this;

		private Struct234[] _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		private static _003Cget_ScourgeAffixes_003Ed__48 _003Cget_ScourgeAffixes_003Ed__48_0;

		ModAffix IEnumerator<ModAffix>.Current => null;

		object IEnumerator.Current => null;

		public _003Cget_ScourgeAffixes_003Ed__48(int _003C_003E1__state)
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

		IEnumerator<ModAffix> IEnumerable<ModAffix>.GetEnumerator()
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

		internal static _003Cget_ScourgeAffixes_003Ed__48 smethod_1()
		{
			return null;
		}

		static _003Cget_ScourgeAffixes_003Ed__48()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private sealed class _003Cget_SkillsGranted_003Ed__38 : IEnumerable<ModAffix>, IEnumerable, IEnumerator<ModAffix>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private ModAffix _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public Mods _003C_003E4__this;

		private Struct234[] _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		internal static _003Cget_SkillsGranted_003Ed__38 _003Cget_SkillsGranted_003Ed__38_0;

		ModAffix IEnumerator<ModAffix>.Current => null;

		object IEnumerator.Current => null;

		public _003Cget_SkillsGranted_003Ed__38(int _003C_003E1__state)
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

		IEnumerator<ModAffix> IEnumerable<ModAffix>.GetEnumerator()
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

		internal static _003Cget_SkillsGranted_003Ed__38 smethod_1()
		{
			return null;
		}

		static _003Cget_SkillsGranted_003Ed__38()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private sealed class _003Cget_Stats_BC_003Ed__76 : IEnumerable<KeyValuePair<StatTypeGGG, int>>, IEnumerable, IEnumerator<KeyValuePair<StatTypeGGG, int>>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private KeyValuePair<StatTypeGGG, int> _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public Mods _003C_003E4__this;

		private List<KeyValuePair<StatTypeGGG, int>>.Enumerator _003C_003E7__wrap1;

		internal static _003Cget_Stats_BC_003Ed__76 _003Cget_Stats_BC_003Ed__76_0;

		KeyValuePair<StatTypeGGG, int> IEnumerator<KeyValuePair<StatTypeGGG, int>>.Current => (KeyValuePair<StatTypeGGG, int>)null;

		object IEnumerator.Current => null;

		public _003Cget_Stats_BC_003Ed__76(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}

		IEnumerator<KeyValuePair<StatTypeGGG, int>> IEnumerable<KeyValuePair<StatTypeGGG, int>>.GetEnumerator()
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

		internal static _003Cget_Stats_BC_003Ed__76 smethod_1()
		{
			return null;
		}

		static _003Cget_Stats_BC_003Ed__76()
		{
			Class200.smethod_34();
		}
	}

	private List<DatTagWrapper> list_0;

	private PerFrameCachedValue<Struct230> perFrameCachedValue_0;

	private PerFrameCachedValue<Struct235> perFrameCachedValue_1;

	private PerFrameCachedValue<Struct232> perFrameCachedValue_2;

	private PerFrameCachedValue<Struct233> perFrameCachedValue_3;

	private PerFrameCachedValue<Struct236> perFrameCachedValue_4;

	internal static Mods mods_0;

	public bool HasIncubator => true;

	public List<ItemMod> ItemMods => null;

	public List<ItemMod> ImplicitMods => null;

	public List<ItemMod> ExplicitMods => null;

	public List<DatTagWrapper> Tags => null;

	public bool IsRelic => true;

	public int RequireLevel => 0;

	public int BaseRequiredLevel => 0;

	public int ItemLevel => 0;

	public bool Identified => true;

	public byte UnidentifiedTier => 0;

	public Rarity Rarity => (Rarity)(object)null;

	public bool IsUsable => true;

	public bool IsMirrored => true;

	public bool IsSynthesized => true;

	public bool IsFractured => true;

	public IEnumerable<ModAffix> SkillsGranted
	{
		[IteratorStateMachine(typeof(_003Cget_SkillsGranted_003Ed__38))]
		get
		{
			return null;
		}
	}

	public IEnumerable<ModAffix> Affixes => null;

	public IEnumerable<ModAffix> ImplicitAffixes
	{
		[IteratorStateMachine(typeof(_003Cget_ImplicitAffixes_003Ed__42))]
		get
		{
			return null;
		}
	}

	public IEnumerable<ModAffix> ExplicitAffixes
	{
		[IteratorStateMachine(typeof(_003Cget_ExplicitAffixes_003Ed__44))]
		get
		{
			return null;
		}
	}

	public IEnumerable<ModAffix> EnchantmentsAffixes
	{
		[IteratorStateMachine(typeof(_003Cget_EnchantmentsAffixes_003Ed__46))]
		get
		{
			return null;
		}
	}

	public IEnumerable<ModAffix> ScourgeAffixes
	{
		[IteratorStateMachine(typeof(_003Cget_ScourgeAffixes_003Ed__48))]
		get
		{
			return null;
		}
	}

	public IEnumerable<ModAffix> CrucibleAffixes
	{
		[IteratorStateMachine(typeof(_003Cget_CrucibleAffixes_003Ed__50))]
		get
		{
			return null;
		}
	}

	public IEnumerable<KeyValuePair<StatTypeGGG, int>> MergedStatsEnumerable
	{
		[IteratorStateMachine(typeof(_003Cget_MergedStatsEnumerable_003Ed__52))]
		get
		{
			return null;
		}
	}

	public IEnumerable<KeyValuePair<DatStatWrapper, int>> ImplicitStatsEnumerable => null;

	public IEnumerable<KeyValuePair<DatStatWrapper, int>> ExplicitStatsEnumerable => null;

	public IEnumerable<KeyValuePair<DatStatWrapper, int>> EnchantmentsEnumerable => null;

	public IEnumerable<KeyValuePair<DatStatWrapper, int>> ScourgeEnumerable => null;

	public IEnumerable<KeyValuePair<DatStatWrapper, int>> CrucibleEnumerable => null;

	public Dictionary<DatStatWrapper, int> EnchantmentsStats => null;

	public Dictionary<DatStatWrapper, int> ImplicitStats => null;

	public Dictionary<DatStatWrapper, int> ExplicitStats => null;

	public Dictionary<DatStatWrapper, int> ScourgeStats => null;

	public Dictionary<DatStatWrapper, int> CrucibleStats => null;

	public Dictionary<StatTypeGGG, int> MergedStats => null;

	public IEnumerable<KeyValuePair<StatTypeGGG, int>> Stats_BC
	{
		[IteratorStateMachine(typeof(_003Cget_Stats_BC_003Ed__76))]
		get
		{
			return null;
		}
	}

	public int ModLevel => 0;

	public InventoryType ItemType => (InventoryType)(object)null;

	public bool IsTooltipBuilt => true;

	public string AlternateQualityType => null;

	public int AlternateQualityTypeValue => 0;

	public List<string> EnchantmentsString => null;

	public List<string> ImplicitStrings => null;

	public List<string> ExplicitStrings => null;

	public List<string> ScourgeStrings => null;

	public List<string> CrucibleStrings => null;

	public List<string> CraftedStrings => null;

	public List<string> MergedStrings => null;

	private List<ItemMod> method_2(int int_0)
	{
		return null;
	}

	private static int smethod_4(NativeVector nativeVector_0)
	{
		return 0;
	}

	private void method_3(int int_0, NativeVector nativeVector_0)
	{
	}

	private Struct234[] method_4(int int_0)
	{
		return null;
	}

	[SpecialName]
	[IteratorStateMachine(typeof(_003Cget_IEnumerable_0FullName_003Ed__82))]
	internal IEnumerable<string> method_5()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	internal Struct233 method_6()
	{
		return (Struct233)(object)null;
	}

	private Struct233 method_7()
	{
		return (Struct233)(object)null;
	}

	[SpecialName]
	internal Struct236 method_8()
	{
		return (Struct236)(object)null;
	}

	private Struct236 method_9()
	{
		return (Struct236)(object)null;
	}

	[SpecialName]
	internal Struct232 method_10()
	{
		return (Struct232)(object)null;
	}

	[SpecialName]
	internal Struct230 method_11()
	{
		return (Struct230)(object)null;
	}

	[SpecialName]
	internal Struct235 method_12()
	{
		return (Struct235)(object)null;
	}

	private Struct230 method_13()
	{
		return (Struct230)(object)null;
	}

	private Struct232 method_14()
	{
		return (Struct232)(object)null;
	}

	[CompilerGenerated]
	private Struct235 method_15()
	{
		return (Struct235)(object)null;
	}

	internal static bool smethod_5()
	{
		return true;
	}

	internal static Mods smethod_6()
	{
		return null;
	}

	static Mods()
	{
		Class200.smethod_34();
	}
}
