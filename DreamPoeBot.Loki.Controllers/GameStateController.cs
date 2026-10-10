using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Common;
using DreamPoeBot.Loki.Elements;
using DreamPoeBot.Loki.RemoteMemoryObjects;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Controllers;

public class GameStateController : RemoteMemoryObject
{
	private class Class52 : RemoteMemoryObject
	{
		internal static Class52 class52_0;

		public GameStateEnum Key => (GameStateEnum)(object)null;

		public GameState Value1 => null;

		internal static bool smethod_2()
		{
			return true;
		}

		internal static Class52 smethod_3()
		{
			return null;
		}

		static Class52()
		{
			Class200.smethod_34();
		}
	}

	private static readonly ILog Log;

	private long long_1;

	public static long PreGameStatePtr;

	public static long LoginStatePtr;

	public static long SelectCharacterStatePtr;

	private static long long_2;

	public static long EscapeStatePtr;

	private static long long_3;

	private static long long_4;

	public static long LoadingStatePtr;

	private static GameStateController gameStateController_0;

	public readonly Dictionary<GameStateEnum, GameState> AllGameStates;

	[CompilerGenerated]
	private static AreaLoadingState areaLoadingState_0;

	[CompilerGenerated]
	private static LoginStateClass loginStateClass_0;

	[CompilerGenerated]
	private static SelectCharacterStateClass selectCharacterStateClass_0;

	[CompilerGenerated]
	private static EscapeStateClass escapeStateClass_0;

	[CompilerGenerated]
	private static CreateCharacterStateClass createCharacterStateClass_0;

	[CompilerGenerated]
	private static IngameState ingameState_0;

	private static GameStateController gameStateController_1;

	public static AreaLoadingState AreaLoadingState
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

	public static LoginStateClass LoginState
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

	public static SelectCharacterStateClass SelectCharacterState
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

	public static EscapeStateClass EscapeState
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

	public static CreateCharacterStateClass CreateCharacterState
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

	public static IngameState IngameState
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

	public static List<GameState> CurrentGameStates => null;

	public static List<GameState> ActiveGameStates => null;

	public List<GameState> _CurrentGameStates => null;

	public List<GameState> _ActiveGameStates => null;

	public static bool IsPreGame => true;

	public static bool IsLoginState => true;

	public static bool IsSelectCharacterState => true;

	public static bool IsCreateCharacterStateActive => true;

	public static bool IsWaitingState => true;

	public static bool IsInGameState => true;

	public static bool IsAreaLoading => true;

	public static bool IsLoading => true;

	public static bool IsEscapeState => true;

	public LoginPannelElement LogInPannel => null;

	public ClassSelectionElement CaracterCreationPannel => null;

	public long createstartptr => 0L;

	internal static bool smethod_2(Memory memory_0, long long_5)
	{
		return true;
	}

	private static bool smethod_3(long long_5)
	{
		return true;
	}

	private Dictionary<GameStateEnum, GameState> method_0(long long_5)
	{
		return null;
	}

	private List<GameState> method_1(int int_0)
	{
		return null;
	}

	private byte[] method_2(long long_5, int int_0)
	{
		return null;
	}

	private static bool smethod_4(long long_5)
	{
		return true;
	}

	static GameStateController()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		Log = Logger.GetLoggerInstanceForType();
		PreGameStatePtr = -1L;
		LoginStatePtr = -1L;
		SelectCharacterStatePtr = -1L;
		long_2 = -1L;
		EscapeStatePtr = -1L;
		long_3 = -1L;
		long_4 = -1L;
		LoadingStatePtr = -1L;
	}

	internal static bool smethod_5()
	{
		return true;
	}

	internal static GameStateController smethod_6()
	{
		return null;
	}
}
