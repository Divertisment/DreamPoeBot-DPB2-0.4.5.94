using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DreamPoeBot.Loki.Common;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Bot;

public class TaskManager : TaskManagerBase<ITask>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CProvideLogic_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<LogicResult> _003C_003Et__builder;

		public TaskManager _003C_003E4__this;

		public TaskGroup group;

		public Logic logic;

		public RunBehavior behavior;

		private StringBuilder _003CstringBuilder_003E5__2;

		private LogicResult _003Cresult_003E5__3;

		private List<ITask>.Enumerator _003C_003E7__wrap3;

		private TaskAwaiter<LogicResult> _003C_003Eu__1;

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

		static _003CProvideLogic_003Ed__4()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRun_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<RunTasksResult> _003C_003Et__builder;

		public TaskManager _003C_003E4__this;

		public TaskGroup group;

		public RunBehavior behavior;

		private StringBuilder _003CstringBuilder_003E5__2;

		private RunTasksResult _003Cresult_003E5__3;

		private List<ITask>.Enumerator _003C_003E7__wrap3;

		private Stopwatch _003Csw_003E5__5;

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

		static _003CRun_003Ed__5()
		{
			Class200.smethod_34();
		}
	}

	private static readonly ILog ilog_1;

	private static TaskManager taskManager_0;

	public override void Start()
	{
	}

	public override void Tick()
	{
	}

	public override void Stop()
	{
	}

	public override MessageResult SendMessage(TaskGroup group, Message message)
	{
		return (MessageResult)(object)null;
	}

	[AsyncStateMachine(typeof(_003CProvideLogic_003Ed__4))]
	public override Task<LogicResult> ProvideLogic(TaskGroup group, RunBehavior behavior, Logic logic)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CRun_003Ed__5))]
	public override Task<RunTasksResult> Run(TaskGroup group, RunBehavior behavior)
	{
		return null;
	}

	static TaskManager()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_1 = Logger.GetLoggerInstanceForName(Class200.smethod_20(2908896));
	}

	internal static bool smethod_3()
	{
		return true;
	}

	internal static TaskManager smethod_4()
	{
		return null;
	}
}
