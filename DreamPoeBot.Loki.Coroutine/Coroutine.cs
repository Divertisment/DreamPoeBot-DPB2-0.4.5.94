using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ns0;

namespace DreamPoeBot.Loki.Coroutine;

public sealed class Coroutine : IDisposable
{
	private class Class114 : INotifyCompletion
	{
		[CompilerGenerated]
		private bool bool_0;

		internal static Class114 class114_0;

		[SpecialName]
		[CompilerGenerated]
		public bool method_0()
		{
			return true;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_1(bool bool_1)
		{
		}

		[SpecialName]
		public bool method_2()
		{
			return true;
		}

		public Class114 method_3()
		{
			return null;
		}

		public void method_4()
		{
		}

		public void OnCompleted(Action action_0)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class114 smethod_1()
		{
			return null;
		}

		static Class114()
		{
			Class200.smethod_34();
		}
	}

	private sealed class Class115
	{
		public Func<Task<object>> func_0;

		public Coroutine coroutine_0;

		private static Class115 class115_0;

		internal void method_0()
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class115 smethod_1()
		{
			return null;
		}

		static Class115()
		{
			Class200.smethod_34();
		}
	}

	private struct Struct174 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		private object object_0;

		internal static object object_1;

		void IAsyncStateMachine.MoveNext()
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine iasyncStateMachine_0)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static object smethod_1()
		{
			return null;
		}

		static Struct174()
		{
			Class200.smethod_34();
		}
	}

	private struct Struct175 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public TimeSpan timeSpan_0;

		private Stopwatch XdUlctLfIbT;

		private object object_0;

		private static object object_1;

		void IAsyncStateMachine.MoveNext()
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine iasyncStateMachine_0)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static object smethod_1()
		{
			return null;
		}

		static Struct175()
		{
			Class200.smethod_34();
		}
	}

	private struct Struct176 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		public TimeSpan timeSpan_0;

		public Func<bool> rOtlcimFbgw;

		private Stopwatch stopwatch_0;

		private object object_0;

		private static object object_1;

		void IAsyncStateMachine.MoveNext()
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine iasyncStateMachine_0)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static object smethod_1()
		{
			return null;
		}

		static Struct176()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003Csmethod_10_003Ed__47<T> : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ExternalTaskWaitResult<T>> _003C_003Et__builder;

		public Task<T> task_1;

		public TimeSpan timeSpan_0;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static object smethod_1()
		{
			return null;
		}

		static _003Csmethod_10_003Ed__47()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003Csmethod_3_003Ed__59 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		private TaskAwaiter _003C_003Eu__1;

		private static object object_0;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static object smethod_1()
		{
			return null;
		}

		static _003Csmethod_3_003Ed__59()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003Csmethod_4_003Ed__48 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public TimeSpan timeSpan_0;

		private TaskAwaiter _003C_003Eu__1;

		private static object object_0;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static object smethod_1()
		{
			return null;
		}

		static _003Csmethod_4_003Ed__48()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003Csmethod_5_003Ed__49 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public TimeSpan timeSpan_0;

		public Func<bool> func_0;

		private TaskAwaiter<bool> _003C_003Eu__1;

		internal static object object_0;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static object smethod_1()
		{
			return null;
		}

		static _003Csmethod_5_003Ed__49()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003Csmethod_7_003Ed__51 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public TimeSpan timeSpan;

		public Task task;

		private TaskAwaiter<object> _003C_003Eu__1;

		private Stopwatch _003Cstopwatch_003E5__2;

		private static object object_0;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static object smethod_1()
		{
			return null;
		}

		static _003Csmethod_7_003Ed__51()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003Csmethod_8_003Ed__52<T> : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

		public Task<ExternalTaskWaitResult<T>> task_1;

		private TaskAwaiter<ExternalTaskWaitResult<T>> _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static object smethod_1()
		{
			return null;
		}

		static _003Csmethod_8_003Ed__52()
		{
			Class200.smethod_34();
		}
	}

	private readonly Class114 class114_0;

	private Task<object> task_0;

	private Action action_0;

	[ThreadStatic]
	private static Coroutine coroutine_0;

	[CompilerGenerated]
	private CoroutineException coroutineException_0;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private object FllvsnvByb;

	[CompilerGenerated]
	private CoroutineStatus coroutineStatus_0;

	[CompilerGenerated]
	private int int_0;

	private static Coroutine coroutine_1;

	public static Coroutine Current => null;

	public CoroutineException FaultingException
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

	public bool IsDisposed
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

	public bool IsFinished => true;

	public object Result
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

	public CoroutineStatus Status
	{
		[CompilerGenerated]
		get
		{
			return (CoroutineStatus)(object)null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int Ticks
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

	public Coroutine(Func<Task> taskProducer)
	{
	}

	public Coroutine(Func<Task<object>> taskProducer)
	{
	}

	public void Dispose()
	{
	}

	public static Task ExternalTask(Func<Task> taskProducer)
	{
		return null;
	}

	public static Task ExternalTask(Task externalTask)
	{
		return null;
	}

	[Obsolete("Timeouts should be handled in the external task, not by this method. Use the overloads with infinite timeouts instead.")]
	public static Task<bool> ExternalTask(Task externalTask, TimeSpan timeout)
	{
		return null;
	}

	[Obsolete("Timeouts should be handled in the external task, not by this method. Use the overloads with infinite timeouts instead.")]
	public static Task<bool> ExternalTask(Task externalTask, int millisecondsTimeout)
	{
		return null;
	}

	public static Task<T> ExternalTask<T>(Func<Task<T>> taskProducer)
	{
		return null;
	}

	public static Task<T> ExternalTask<T>(Task<T> externalTask)
	{
		return null;
	}

	[Obsolete("Timeouts should be handled in the external task, not by this method. Use the overloads with infinite timeouts instead.")]
	public static Task<ExternalTaskWaitResult<T>> ExternalTask<T>(Task<T> externalTask, int millisecondsTimeout)
	{
		return null;
	}

	[Obsolete("Timeouts should be handled in the external taks, not by this method. Use the overloads with infinite timeouts instead.")]
	public static Task<ExternalTaskWaitResult<T>> ExternalTask<T>(Task<T> externalTask, TimeSpan timeout)
	{
		return null;
	}

	public void Resume()
	{
	}

	private void method_0(bool bool_1)
	{
	}

	private void method_1(bool bool_1)
	{
	}

	private Exception method_2(CoroutineException coroutineException_1)
	{
		return null;
	}

	public static Task Sleep(TimeSpan timeout)
	{
		return null;
	}

	public static Task Sleep(int milliseconds)
	{
		return null;
	}

	private static Func<Task<object>> smethod_0(Func<Task> func_0)
	{
		return null;
	}

	internal static Exception smethod_1()
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003Csmethod_10_003Ed__47<>))]
	private static Task<ExternalTaskWaitResult<T>> smethod_2<T>(Task<T> task_1, TimeSpan timeSpan_0)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003Csmethod_4_003Ed__48))]
	private static Task smethod_3(TimeSpan timeSpan_0)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003Csmethod_5_003Ed__49))]
	private static Task<bool> smethod_4(TimeSpan timeSpan_0, Func<bool> func_0)
	{
		return null;
	}

	private static Task<bool> smethod_5(Task task_1, TimeSpan timeSpan_0)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003Csmethod_7_003Ed__51))]
	private static Task<bool> smethod_6(Task task_1, TimeSpan timeSpan_0)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003Csmethod_8_003Ed__52<>))]
	private static Task<T> smethod_7<T>(Task<ExternalTaskWaitResult<T>> task_1)
	{
		return null;
	}

	private static Task<ExternalTaskWaitResult<T>> smethod_8<T>(Task<T> task_1, TimeSpan timeSpan_0)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	public static Task<bool> Wait(TimeSpan maxWaitTimeout, Func<bool> condition)
	{
		return null;
	}

	public static Task<bool> Wait(int maxWaitMs, Func<bool> condition)
	{
		return null;
	}

	public static Task Yield()
	{
		return null;
	}

	private static void smethod_9()
	{
	}

	[AsyncStateMachine(typeof(_003Csmethod_3_003Ed__59))]
	private static Task smethod_10()
	{
		return null;
	}

	internal static bool smethod_11()
	{
		return true;
	}

	internal static Coroutine smethod_12()
	{
		return null;
	}

	static Coroutine()
	{
		Class200.smethod_34();
	}
}
