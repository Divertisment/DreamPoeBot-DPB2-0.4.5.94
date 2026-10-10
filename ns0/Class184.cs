using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace ns0;

internal static class Class184
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public Class185 class185_0;

		private static _003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_0_0;

		internal bool method_0(Class185 result)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static _003C_003Ec__DisplayClass9_0 smethod_1()
		{
			return null;
		}

		static _003C_003Ec__DisplayClass9_0()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCompleteBackgroundSelectionAsync_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IReadOnlyList<Class185>> _003C_003Et__builder;

		public Class185 selected;

		public Task<Class185>[] candidates;

		private _003C_003Ec__DisplayClass9_0 _003C_003E8__1;

		private TaskAwaiter<Class185[]> _003C_003Eu__1;

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

		static _003CCompleteBackgroundSelectionAsync_003Ed__9()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSelectAsync_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Class186> _003C_003Et__builder;

		public IEnumerable<string> domains;

		private Task<Class185>[] _003Ccandidates_003E5__2;

		private List<Task<Class185>> _003Cpending_003E5__3;

		private List<Class185> _003Ccompleted_003E5__4;

		private Class185 _003Cselected_003E5__5;

		private TaskAwaiter<Task<Class185>> _003C_003Eu__1;

		private TaskAwaiter<Class185> _003C_003Eu__2;

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

		static _003CSelectAsync_003Ed__7()
		{
			Class200.smethod_34();
		}
	}

	private static readonly object object_0;

	private static string[] string_0;

	private static Class184 class184_0;

	[AsyncStateMachine(typeof(_003CSelectAsync_003Ed__7))]
	internal static Task<Class186> smethod_0(IEnumerable<string> ienumerable_0)
	{
		return null;
	}

	internal static IReadOnlyList<string> smethod_1()
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CCompleteBackgroundSelectionAsync_003Ed__9))]
	private static Task<IReadOnlyList<Class185>> smethod_2(Task<Class185>[] task_0, Class185 class185_0)
	{
		return null;
	}

	private static Class185 smethod_3(string string_1)
	{
		return null;
	}

	private static void smethod_4(Class185 class185_0)
	{
	}

	static Class184()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		object_0 = new object();
		string_0 = Array.Empty<string>();
	}

	internal static bool smethod_5()
	{
		return true;
	}

	internal static Class184 smethod_6()
	{
		return null;
	}
}
