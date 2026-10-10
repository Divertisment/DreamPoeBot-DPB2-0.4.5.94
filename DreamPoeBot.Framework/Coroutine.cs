using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ns0;

namespace DreamPoeBot.Framework;

public class Coroutine
{
	[CompilerGenerated]
	private sealed class Class157 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action a;

		public Coroutine _003C_003E4__this;

		private static Class157 class157_0;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public Class157(int _003C_003E1__state)
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

		internal static Class157 smethod_1()
		{
			return null;
		}

		static Class157()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private sealed class _003CWait_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Coroutine _003C_003E4__this;

		internal static _003CWait_003Ed__49 _003CWait_003Ed__49_0;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWait_003Ed__49(int _003C_003E1__state)
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

		internal static _003CWait_003Ed__49 smethod_1()
		{
			return null;
		}

		static _003CWait_003Ed__49()
		{
			Class200.smethod_34();
		}
	}

	private readonly IEnumerator ienumerator_0;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private bool bool_2;

	[CompilerGenerated]
	private string string_2;

	[CompilerGenerated]
	private long long_0;

	[CompilerGenerated]
	private CoroutinePriority coroutinePriority_0;

	[CompilerGenerated]
	private DateTime dateTime_0;

	[CompilerGenerated]
	private readonly Action action_0;

	[CompilerGenerated]
	private YieldBase yieldBase_0;

	private static Coroutine coroutine_0;

	public bool IsDone
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
		[CompilerGenerated]
		private set
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
		set
		{
		}
	}

	public string Owner
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

	public bool DoWork
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool AutoResume
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

	public string TimeoutForAction
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

	public long Ticks
	{
		[CompilerGenerated]
		get
		{
			return 0L;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public CoroutinePriority Priority
	{
		[CompilerGenerated]
		get
		{
			return (CoroutinePriority)(object)null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public DateTime Started
	{
		[CompilerGenerated]
		get
		{
			return (DateTime)(object)null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public Action Action
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public YieldBase Condition
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

	public bool ThisIsSimple => true;

	public Coroutine(Action action, YieldBase condition, string owner, string name = null, bool autoStart = true)
	{
	}

	public Coroutine(Action action, int waitMilliseconds, string owner, string name = null, bool autoStart = true)
	{
	}

	public Coroutine(IEnumerator enumerator, string owner, string name = null, bool autoStart = true)
	{
	}

	[IteratorStateMachine(typeof(_003CWait_003Ed__49))]
	public IEnumerator Wait()
	{
		return null;
	}

	public void UpdateCondtion(YieldBase condition)
	{
	}

	public Coroutine GetCopy(Coroutine cor)
	{
		return null;
	}

	public IEnumerator GetEnumerator()
	{
		return null;
	}

	public void UpdateTicks(int tick)
	{
	}

	public void Resume()
	{
	}

	public void Pause(bool force = false)
	{
	}

	public bool Done(bool force = false)
	{
		return true;
	}

	public bool MoveNext()
	{
		return true;
	}

	private bool method_0(IEnumerator ienumerator_1)
	{
		return true;
	}

	[CompilerGenerated]
	[IteratorStateMachine(typeof(Class157))]
	private IEnumerator method_1(Action action_1)
	{
		return null;
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static Coroutine smethod_1()
	{
		return null;
	}

	static Coroutine()
	{
		Class200.smethod_34();
	}
}
