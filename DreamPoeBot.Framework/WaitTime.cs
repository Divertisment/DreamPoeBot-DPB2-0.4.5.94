using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ns0;

namespace DreamPoeBot.Framework;

public class WaitTime : YieldBase
{
	[CompilerGenerated]
	private sealed class _003CGetEnumerator_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WaitTime _003C_003E4__this;

		private long _003Cwait_003E5__2;

		private static _003CGetEnumerator_003Ed__4 _003CGetEnumerator_003Ed__4_0;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CGetEnumerator_003Ed__4(int _003C_003E1__state)
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

		internal static _003CGetEnumerator_003Ed__4 smethod_1()
		{
			return null;
		}

		static _003CGetEnumerator_003Ed__4()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private readonly int int_0;

	internal static WaitTime waitTime_0;

	public int Milliseconds
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
	}

	public WaitTime(int milliseconds)
	{
	}

	[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__4))]
	public sealed override IEnumerator GetEnumerator()
	{
		return null;
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static WaitTime smethod_3()
	{
		return null;
	}

	static WaitTime()
	{
		Class200.smethod_34();
	}
}
