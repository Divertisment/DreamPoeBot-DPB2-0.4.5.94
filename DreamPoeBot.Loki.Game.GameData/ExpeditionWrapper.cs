using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Components;
using DreamPoeBot.Loki.Game.Objects;
using ns0;

namespace DreamPoeBot.Loki.Game.GameData;

public class ExpeditionWrapper
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct136
	{
		public readonly long long_0;

		public readonly long long_1;

		public readonly int X;

		public readonly int int_0;

		public int int_1;

		public int int_2;

		public long long_2;

		public int jsLlfHneLu5;

		public int int_3;

		public long long_3;

		public byte byte_0;

		public long long_4;

		public long long_5;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct137
	{
		public readonly long Id;

		public readonly long Name;

		public readonly long long_0;
	}

	[CompilerGenerated]
	private sealed class _003Cget_ExpeditionAreaSpecificModsString_003Ed__7 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private string _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public ExpeditionWrapper _003C_003E4__this;

		private long _003Ci_003E5__2;

		internal static _003Cget_ExpeditionAreaSpecificModsString_003Ed__7 _003Cget_ExpeditionAreaSpecificModsString_003Ed__7_0;

		string IEnumerator<string>.Current => null;

		object IEnumerator.Current => null;

		public _003Cget_ExpeditionAreaSpecificModsString_003Ed__7(int _003C_003E1__state)
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

		internal static _003Cget_ExpeditionAreaSpecificModsString_003Ed__7 smethod_1()
		{
			return null;
		}

		static _003Cget_ExpeditionAreaSpecificModsString_003Ed__7()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private sealed class _003Cget_ExpeditionAreaSpecificModsStringExtended_003Ed__9 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private string _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public ExpeditionWrapper _003C_003E4__this;

		private long _003Ci_003E5__2;

		internal static _003Cget_ExpeditionAreaSpecificModsStringExtended_003Ed__9 _003Cget_ExpeditionAreaSpecificModsStringExtended_003Ed__9_0;

		string IEnumerator<string>.Current => null;

		object IEnumerator.Current => null;

		public _003Cget_ExpeditionAreaSpecificModsStringExtended_003Ed__9(int _003C_003E1__state)
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

		internal static _003Cget_ExpeditionAreaSpecificModsStringExtended_003Ed__9 smethod_1()
		{
			return null;
		}

		static _003Cget_ExpeditionAreaSpecificModsStringExtended_003Ed__9()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private sealed class _003Cget_ExpeditionMods_003Ed__5 : IEnumerable<ModAffix>, IEnumerable, IEnumerator<ModAffix>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private ModAffix _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public ExpeditionWrapper _003C_003E4__this;

		private Mods.Struct234[] _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		private static _003Cget_ExpeditionMods_003Ed__5 _003Cget_ExpeditionMods_003Ed__5_0;

		ModAffix IEnumerator<ModAffix>.Current => null;

		object IEnumerator.Current => null;

		public _003Cget_ExpeditionMods_003Ed__5(int _003C_003E1__state)
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

		internal static _003Cget_ExpeditionMods_003Ed__5 smethod_1()
		{
			return null;
		}

		static _003Cget_ExpeditionMods_003Ed__5()
		{
			Class200.smethod_34();
		}
	}

	private DatWorldAreaWrapper datWorldAreaWrapper_0;

	private string string_0;

	private ExpeditionSaga.ExpeditionDataStructure expeditionDataStructure_0;

	internal static ExpeditionWrapper expeditionWrapper_0;

	public IEnumerable<ModAffix> ExpeditionMods
	{
		[IteratorStateMachine(typeof(_003Cget_ExpeditionMods_003Ed__5))]
		get
		{
			return null;
		}
	}

	public IEnumerable<string> ExpeditionAreaSpecificModsString
	{
		[IteratorStateMachine(typeof(_003Cget_ExpeditionAreaSpecificModsString_003Ed__7))]
		get
		{
			return null;
		}
	}

	public IEnumerable<string> ExpeditionAreaSpecificModsStringExtended
	{
		[IteratorStateMachine(typeof(_003Cget_ExpeditionAreaSpecificModsStringExtended_003Ed__9))]
		get
		{
			return null;
		}
	}

	public DatWorldAreaWrapper WorldArea => null;

	public string ExpeditionFaction => null;

	internal ExpeditionWrapper(ExpeditionSaga.ExpeditionDataStructure expeditionStructure)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static ExpeditionWrapper smethod_1()
	{
		return null;
	}

	static ExpeditionWrapper()
	{
		Class200.smethod_34();
	}
}
