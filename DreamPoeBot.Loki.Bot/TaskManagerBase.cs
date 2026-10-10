using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using DreamPoeBot.Loki.Common;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Bot;

public abstract class TaskManagerBase<T> where T : IAuthored
{
	public delegate void TaskEvent(T task);

	[CompilerGenerated]
	private sealed class Class464
	{
		public T gparam_0;

		private static object object_0;

		internal bool method_0(T gparam_1)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static object smethod_1()
		{
			return null;
		}

		static Class464()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private sealed class Class465
	{
		public T gparam_0;

		private static object object_0;

		internal bool method_0(T gparam_1)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static object smethod_1()
		{
			return null;
		}

		static Class465()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private sealed class Class466
	{
		public T gparam_0;

		private static object object_0;

		internal bool method_0(T gparam_1)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static object smethod_1()
		{
			return null;
		}

		static Class466()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private sealed class Class467
	{
		public T gparam_0;

		internal static object object_0;

		internal bool method_0(T gparam_1)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static object smethod_1()
		{
			return null;
		}

		static Class467()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private sealed class Class468
	{
		public string string_0;

		internal static object object_0;

		internal bool method_0(T gparam_0)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static object smethod_1()
		{
			return null;
		}

		static Class468()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private sealed class Class469
	{
		public string string_0;

		internal static object object_0;

		internal bool method_0(T gparam_0)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static object smethod_1()
		{
			return null;
		}

		static Class469()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private bool bool_0;

	private static readonly ILog ilog_0;

	private readonly List<T> list_0;

	private readonly Dictionary<T, bool> dictionary_0;

	[CompilerGenerated]
	private TaskEvent taskEvent_0;

	[CompilerGenerated]
	private TaskEvent taskEvent_1;

	[CompilerGenerated]
	private bool bool_1;

	internal static object object_0;

	public bool IsFrozen
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

	public ReadOnlyCollection<T> TaskList => null;

	public event TaskEvent TaskEnabled
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event TaskEvent TaskDisabled
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void method_0(T gparam_0)
	{
	}

	public bool IsEnabled(T task)
	{
		return true;
	}

	public void Enable(T task)
	{
	}

	public void Disable(T task)
	{
	}

	private static void smethod_0(T gparam_0, TaskEvent taskEvent_2)
	{
	}

	public void Freeze()
	{
	}

	public bool AddBefore(T task, string name)
	{
		return true;
	}

	public bool AddAfter(T task, string name)
	{
		return true;
	}

	public bool SwapTasks(string name1, string name2)
	{
		return true;
	}

	public bool Add(T task)
	{
		return true;
	}

	public bool AddAtFront(T task)
	{
		return true;
	}

	public bool Remove(string name)
	{
		return true;
	}

	public T GetTaskByName(string name)
	{
		return (T)null;
	}

	public bool Replace(string name, T task)
	{
		return true;
	}

	public abstract void Start();

	public abstract void Tick();

	public abstract void Stop();

	public void Reset()
	{
	}

	public abstract MessageResult SendMessage(TaskGroup group, Message message);

	public abstract Task<RunTasksResult> Run(TaskGroup group, RunBehavior behavior);

	public abstract Task<LogicResult> ProvideLogic(TaskGroup group, RunBehavior behavior, Logic logic);

	static TaskManagerBase()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForName(Class200.smethod_20(2911072) + typeof(T).Name + Class200.smethod_20(2911108));
	}

	internal static bool smethod_1()
	{
		return true;
	}

	internal static object smethod_2()
	{
		return null;
	}
}
