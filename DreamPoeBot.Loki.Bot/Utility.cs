using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using DreamPoeBot.Loki.Common;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Bot;

public static class Utility
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBroadcastLogicRequest_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Logic> _003C_003Et__builder;

		public string id;

		public object sender;

		public object[] input;

		private Logic _003Clogic_003E5__2;

		private IEnumerator<IContent> _003C_003E7__wrap2;

		private TaskAwaiter<LogicResult> _003C_003Eu__1;

		private List<IPlugin>.Enumerator _003C_003E7__wrap3;

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

		static _003CBroadcastLogicRequest_003Ed__1()
		{
			Class200.smethod_34();
		}
	}

	private static readonly ILog ilog_0;

	internal static Utility utility_0;

	public static Message BroadcastMessage(object sender, string id, params dynamic[] input)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CBroadcastLogicRequest_003Ed__1))]
	public static Task<Logic> BroadcastLogicRequest(object sender, string id, params dynamic[] input)
	{
		return null;
	}

	internal static bool smethod_0(ILog ilog_1, IPlayerMover iplayerMover_0)
	{
		return true;
	}

	internal static bool smethod_1(ILog ilog_1, IContent icontent_0)
	{
		return true;
	}

	internal static bool smethod_2(ILog ilog_1, IPlugin iplugin_0)
	{
		return true;
	}

	internal static bool smethod_3(ILog ilog_1, IRoutine iroutine_0)
	{
		return true;
	}

	internal static bool smethod_4(ILog ilog_1, IBot ibot_0)
	{
		return true;
	}

	private static bool smethod_5(ILog ilog_1, object object_0, bool bool_0)
	{
		return true;
	}

	internal static void smethod_6(object object_0)
	{
	}

	internal static void smethod_7(object object_0)
	{
	}

	static Utility()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_8()
	{
		return true;
	}

	internal static Utility smethod_9()
	{
		return null;
	}
}
