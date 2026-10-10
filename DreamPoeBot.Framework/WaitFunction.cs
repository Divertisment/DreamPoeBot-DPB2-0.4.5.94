using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ns0;

namespace DreamPoeBot.Framework;

public class WaitFunction : YieldBase
{
	[CompilerGenerated]
	private sealed class _003CGetEnumerator_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private static _003CGetEnumerator_003Ed__1 _003CGetEnumerator_003Ed__1_0;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CGetEnumerator_003Ed__1(int _003C_003E1__state)
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

		internal static bool smethod_0()
		{
			return true;
		}

		internal static _003CGetEnumerator_003Ed__1 smethod_1()
		{
			return null;
		}

		static _003CGetEnumerator_003Ed__1()
		{
			Class200.smethod_34();
		}
	}

	public WaitFunction(Func<bool> fn)
	{
	}

	[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__1))]
	public sealed override IEnumerator GetEnumerator()
	{
		return null;
	}

	static WaitFunction()
	{
		Class200.smethod_34();
	}
}
