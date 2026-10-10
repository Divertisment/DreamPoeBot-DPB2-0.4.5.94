using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using DreamPoeBot.Framework;
using DreamPoeBot.Loki.Common;
using DreamPoeBot.Loki.RemoteMemoryObjects;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Controllers;

public class GameController
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRenderLoop_003Ed__45 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public GameController _003C_003E4__this;

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

		static _003CRenderLoop_003Ed__45()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CWhileLoop_003Ed__44 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public GameController _003C_003E4__this;

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

		static _003CWhileLoop_003Ed__44()
		{
			Class200.smethod_34();
		}
	}

	private static readonly ILog ilog_0;

	public static GameController Instance;

	[CompilerGenerated]
	private GameStateController gameStateController_0;

	internal bool bool_0;

	internal static volatile bool bool_1;

	[CompilerGenerated]
	private GameWindow gameWindow_0;

	[CompilerGenerated]
	private readonly TheGame theGame_0;

	[CompilerGenerated]
	private readonly AreaController areaController_0;

	[CompilerGenerated]
	private Memory memory_0;

	[CompilerGenerated]
	private readonly Stopwatch stopwatch_0;

	[CompilerGenerated]
	private bool bool_2;

	[CompilerGenerated]
	private FsController fsController_0;

	public readonly Runner CoroutineRunner;

	public readonly Runner CoroutineRunnerParallel;

	[CompilerGenerated]
	private long long_0;

	private static GameController gameController_0;

	public GameStateController GameStateController
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

	public static bool UseGameStateController => true;

	public GameWindow Window
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

	public TheGame Game
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public AreaController Area
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public Memory Memory
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

	public Stopwatch MainTimer
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public bool InGame
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

	public bool InGameReal => true;

	public FsController Files
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

	public long RenderCount
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

	public GameController(Memory memory)
	{
	}

	[AsyncStateMachine(typeof(_003CWhileLoop_003Ed__44))]
	public Task WhileLoop()
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CRenderLoop_003Ed__45))]
	public Task RenderLoop()
	{
		return null;
	}

	static GameController()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static GameController smethod_1()
	{
		return null;
	}
}
