using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class ExpeditionSaga : Component
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct201
	{
		public readonly long long_0;

		public readonly long long_1;

		public readonly long long_2;

		public readonly NativeVector nativeVector_0;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ExpeditionDataStructure
	{
		public readonly long ExpeditioAreaAdr;

		public readonly long ExpeditionAreaDatFile;

		public readonly long ExpeditionFactionAdr;

		public readonly long ExpeditionFactionFile;

		public NativeVector Mods;

		private long long_0;

		public NativeVector StringMods1;

		public GStruct2 string1;

		private long long_1;

		public NativeVector StringMods2;

		public GStruct2 string2;

		private long long_2;
	}

	[CompilerGenerated]
	private sealed class _003Cget_Expeditions_003Ed__3 : IEnumerable<ExpeditionWrapper>, IEnumerable, IEnumerator<ExpeditionWrapper>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private ExpeditionWrapper _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public ExpeditionSaga _003C_003E4__this;

		private List<ExpeditionDataStructure>.Enumerator _003C_003E7__wrap1;

		internal static _003Cget_Expeditions_003Ed__3 _003Cget_Expeditions_003Ed__3_0;

		ExpeditionWrapper IEnumerator<ExpeditionWrapper>.Current => null;

		object IEnumerator.Current => null;

		public _003Cget_Expeditions_003Ed__3(int _003C_003E1__state)
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

		IEnumerator<ExpeditionWrapper> IEnumerable<ExpeditionWrapper>.GetEnumerator()
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

		internal static _003Cget_Expeditions_003Ed__3 smethod_1()
		{
			return null;
		}

		static _003Cget_Expeditions_003Ed__3()
		{
			Class200.smethod_34();
		}
	}

	private PerFrameCachedValue<Struct201> perFrameCachedValue_0;

	private PerFrameCachedValue<List<ExpeditionDataStructure>> perFrameCachedValue_1;

	internal static ExpeditionSaga expeditionSaga_0;

	public IEnumerable<ExpeditionWrapper> Expeditions
	{
		[IteratorStateMachine(typeof(_003Cget_Expeditions_003Ed__3))]
		get
		{
			return null;
		}
	}

	[SpecialName]
	internal Struct201 method_2()
	{
		return (Struct201)(object)null;
	}

	private Struct201 method_3()
	{
		return (Struct201)(object)null;
	}

	[SpecialName]
	internal List<ExpeditionDataStructure> method_4()
	{
		return null;
	}

	private List<ExpeditionDataStructure> method_5()
	{
		return null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static ExpeditionSaga smethod_5()
	{
		return null;
	}

	static ExpeditionSaga()
	{
		Class200.smethod_34();
	}
}
