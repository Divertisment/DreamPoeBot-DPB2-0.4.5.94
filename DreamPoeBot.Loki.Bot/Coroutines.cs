using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Common;
using DreamPoeBot.Loki.Game;
using DreamPoeBot.Loki.Game.Objects;
using DreamPoeBot.Loki.RemoteMemoryObjects;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Bot;

public static class Coroutines
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass40_0<T>
	{
		public Skill skill_0;

		internal static object object_0;

		internal void method_0()
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

		static _003C_003Ec__DisplayClass40_0()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCloseBlockingWindows_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		private bool _003CshouldRepeat_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<int> _003C_003Eu__2;

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

		static _003CCloseBlockingWindows_003Ed__28()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CExInteractWith_003Ed__38 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Vector2i> _003C_003Et__builder;

		public NetworkObject obj;

		public bool holdCtrl;

		public int timeout;

		private TaskAwaiter<Vector2i> _003C_003Eu__1;

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

		static _003CExInteractWith_003Ed__38()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CExInteractWith_003Ed__39<T> : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Vector2i> _003C_003Et__builder;

		public NetworkObject obj;

		public bool holdCtrl;

		public int timeout;

		private TaskAwaiter<Vector2i> _003C_003Eu__1;

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

		static _003CExInteractWith_003Ed__39()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CExInteractWith_003Ed__40<T> : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Vector2i> _003C_003Et__builder;

		public NetworkObject obj;

		public bool holdCtrl;

		public int timeout;

		public bool autoEquip;

		private _003C_003Ec__DisplayClass40_0<T> _003C_003E8__1;

		private Thread _003Cstupid_003E5__2;

		private TaskAwaiter<Class78> _003C_003Eu__1;

		private TaskAwaiter<int> _003C_003Eu__2;

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

		static _003CExInteractWith_003Ed__40()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CFinishCurrentAction_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public bool resetInput;

		private bool _003CshouldLog_003E5__2;

		private Stopwatch _003ClogStopwatch_003E5__3;

		private Stopwatch _003CactionStopwatch_003E5__4;

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

		static _003CFinishCurrentAction_003Ed__26()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CFinishCurrentMoveAction_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public bool resetInput;

		private bool _003CshouldLog_003E5__2;

		private Stopwatch _003ClogStopwatch_003E5__3;

		private Stopwatch _003CactionStopwatch_003E5__4;

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

		static _003CFinishCurrentMoveAction_003Ed__27()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInteractWith_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public NetworkObject obj;

		public bool holdCtrl;

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

		static _003CInteractWith_003Ed__33()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInteractWith_003Ed__34<T> : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public NetworkObject obj;

		public bool holdCtrl;

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

		static _003CInteractWith_003Ed__34()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInteractWith_003Ed__35<T> : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public NetworkObject obj;

		public bool holdCtrl;

		public bool autoEquip;

		private TaskAwaiter<Class78> _003C_003Eu__1;

		private TaskAwaiter<bool> _003C_003Eu__2;

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

		static _003CInteractWith_003Ed__35()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLatencyWait_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

		private int _003Cnum_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

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

		static _003CLatencyWait_003Ed__23()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLatencyWait_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

		public float factor;

		private int _003Cnum_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

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

		static _003CLatencyWait_003Ed__24()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLegacyInteractWith_003Ed__36 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public NetworkObject obj;

		public bool holdCtrl;

		private int _003Cid_003E5__2;

		private int _003CritualState_003E5__3;

		private int _003CritualEnabled_003E5__4;

		private uint _003CritualArea_003E5__5;

		private long _003CritualAddress_003E5__6;

		private Stopwatch _003Cwait_003E5__7;

		private TaskAwaiter _003C_003Eu__1;

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

		static _003CLegacyInteractWith_003Ed__36()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoot_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<LootResult> _003C_003Et__builder;

		public NetworkObject obj;

		public bool shouldMove;

		public int tmeout;

		private TaskAwaiter<LootResult> _003C_003Eu__1;

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

		static _003CLoot_003Ed__31()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoot_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<LootResult> _003C_003Et__builder;

		public NetworkObject obj;

		public bool shouldMove;

		public int tmeout;

		public bool autoEquip;

		private TaskAwaiter<Class78> _003C_003Eu__1;

		private TaskAwaiter<bool> _003C_003Eu__2;

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

		static _003CLoot_003Ed__32()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CReactionWait_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

		private int _003Cnum_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

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

		static _003CReactionWait_003Ed__25()
		{
			Class200.smethod_34();
		}
	}

	private static int int_0;

	private static int int_1;

	private static float float_0;

	private static int int_2;

	private static int int_3;

	private static readonly ILog Log;

	private static long long_0;

	private static int int_4;

	private static Vector2i vector2i_0;

	private static bool bool_0;

	internal static Coroutines coroutines_0;

	public static float LatencyFactor
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static int ReactionMaxSleepDelay
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int ReactionMinSleepDelay
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int FinishCurrentActionTimeout
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int FinishCurrentMoveActionTimeout
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[AsyncStateMachine(typeof(_003CLatencyWait_003Ed__23))]
	public static Task<int> LatencyWait()
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CLatencyWait_003Ed__24))]
	public static Task<int> LatencyWait(float factor)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CReactionWait_003Ed__25))]
	public static Task<int> ReactionWait()
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CFinishCurrentAction_003Ed__26))]
	public static Task FinishCurrentAction(bool resetInput = true)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CFinishCurrentMoveAction_003Ed__27))]
	public static Task FinishCurrentMoveAction(bool resetInput = true)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CCloseBlockingWindows_003Ed__28))]
	public static Task CloseBlockingWindows()
	{
		return null;
	}

	internal static Enum0 smethod_0(NetworkObject networkObject_0)
	{
		return (Enum0)(object)null;
	}

	internal static Task<Class78> smethod_1(NetworkObject networkObject_0, bool bool_1, int int_5, bool bool_2)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CLoot_003Ed__31))]
	public static Task<LootResult> Loot(NetworkObject obj, bool shouldMove, int tmeout)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CLoot_003Ed__32))]
	public static Task<LootResult> Loot(NetworkObject obj, bool shouldMove = true, int tmeout = 250, bool autoEquip = true)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CInteractWith_003Ed__33))]
	public static Task<bool> InteractWith(NetworkObject obj, bool holdCtrl = false)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CInteractWith_003Ed__34<>))]
	public static Task<bool> InteractWith<T>(NetworkObject obj, bool holdCtrl)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CInteractWith_003Ed__35<>))]
	public static Task<bool> InteractWith<T>(NetworkObject obj, bool holdCtrl = false, bool autoEquip = true)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CLegacyInteractWith_003Ed__36))]
	private static Task<bool> smethod_2(NetworkObject networkObject_0, bool bool_1)
	{
		return null;
	}

	internal static bool smethod_3(int int_5, int int_6, int int_7, int int_8, int int_9, int int_10)
	{
		return true;
	}

	[AsyncStateMachine(typeof(_003CExInteractWith_003Ed__38))]
	public static Task<Vector2i> ExInteractWith(NetworkObject obj, bool holdCtrl = false, int timeout = 1000)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CExInteractWith_003Ed__39<>))]
	public static Task<Vector2i> ExInteractWith<T>(NetworkObject obj, bool holdCtrl, int timeout)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CExInteractWith_003Ed__40<>))]
	public static Task<Vector2i> ExInteractWith<T>(NetworkObject obj, bool holdCtrl = false, int timeout = 1000, bool autoEquip = true)
	{
		return null;
	}

	internal static void smethod_4(Skill skill_0, int int_5)
	{
	}

	static Coroutines()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		int_0 = 300;
		int_1 = 250;
		float_0 = 1.5f;
		int_2 = 1000;
		int_3 = 1000;
		Log = Logger.GetLoggerInstanceForType();
		int_4 = 1000;
		vector2i_0 = Vector2i.Zero;
		bool_0 = false;
	}

	internal static bool smethod_5()
	{
		return true;
	}

	internal static Coroutines smethod_6()
	{
		return null;
	}
}
