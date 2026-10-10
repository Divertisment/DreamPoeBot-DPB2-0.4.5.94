using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Game;
using ns0;

namespace DreamPoeBot.Loki.Elements;

public class HideoutSelectionElement : Element
{
	[CompilerGenerated]
	private sealed class _003Cget_HideoutList_003Ed__1 : IEnumerable<LokiPoe.InGameState.HideoutSelectionUi.HideoutTemplate>, IEnumerable, IEnumerator<LokiPoe.InGameState.HideoutSelectionUi.HideoutTemplate>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private LokiPoe.InGameState.HideoutSelectionUi.HideoutTemplate _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public HideoutSelectionElement _003C_003E4__this;

		private List<Element>.Enumerator _003C_003E7__wrap1;

		internal static _003Cget_HideoutList_003Ed__1 _003Cget_HideoutList_003Ed__1_0;

		LokiPoe.InGameState.HideoutSelectionUi.HideoutTemplate IEnumerator<LokiPoe.InGameState.HideoutSelectionUi.HideoutTemplate>.Current => null;

		object IEnumerator.Current => null;

		public _003Cget_HideoutList_003Ed__1(int _003C_003E1__state)
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

		IEnumerator<LokiPoe.InGameState.HideoutSelectionUi.HideoutTemplate> IEnumerable<LokiPoe.InGameState.HideoutSelectionUi.HideoutTemplate>.GetEnumerator()
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

		internal static _003Cget_HideoutList_003Ed__1 smethod_1()
		{
			return null;
		}

		static _003Cget_HideoutList_003Ed__1()
		{
			Class200.smethod_34();
		}
	}

	private static HideoutSelectionElement hideoutSelectionElement_0;

	public IEnumerable<LokiPoe.InGameState.HideoutSelectionUi.HideoutTemplate> HideoutList
	{
		[IteratorStateMachine(typeof(_003Cget_HideoutList_003Ed__1))]
		get
		{
			return null;
		}
	}

	internal static bool smethod_11()
	{
		return true;
	}

	internal static HideoutSelectionElement smethod_12()
	{
		return null;
	}

	static HideoutSelectionElement()
	{
		Class200.smethod_34();
	}
}
