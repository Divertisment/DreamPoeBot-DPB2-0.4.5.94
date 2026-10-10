using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ns0;

namespace DreamPoeBot.Framework;

public class WaitRender : YieldBase
{
	[CompilerGenerated]
	private sealed class _003CGetEnumerator_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WaitRender _003C_003E4__this;

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
	private readonly long long_0;

	internal static WaitRender waitRender_0;

	public long HowManyRenderCountWait
	{
		[CompilerGenerated]
		get
		{
			return 0L;
		}
	}

	public WaitRender(long howManyRenderCountWait = 1L)
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

	internal static WaitRender smethod_3()
	{
		return null;
	}

	static WaitRender()
	{
		Class200.smethod_34();
	}
}
