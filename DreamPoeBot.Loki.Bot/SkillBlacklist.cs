using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Controls;
using DreamPoeBot.Loki.Bot.Implementation.Content.SkillBlacklist;
using DreamPoeBot.Loki.Common;
using DreamPoeBot.Loki.RemoteMemoryObjects;
using ns0;

namespace DreamPoeBot.Loki.Bot;

public class SkillBlacklist : IConfigurable, IContent, IMessageHandler, IAuthored, IBase, ILogicProvider, IUrlProvider, IHidable
{
	[Serializable]
	private sealed class Class134
	{
		public static readonly Class134 class134_0;

		private static Class134 class134_1;

		internal bool method_0(IContent icontent_0)
		{
			return true;
		}

		internal ushort method_1(SkillId skillId_0)
		{
			return 0;
		}

		internal string method_2(SkillName skillName_0)
		{
			return null;
		}

		static Class134()
		{
			Class200.smethod_34();
			Class204.smethod_0();
			class134_0 = new Class134();
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class134 smethod_1()
		{
			return null;
		}
	}

	private sealed class Class135
	{
		public string string_0;

		internal static Class135 class135_0;

		internal bool method_0(string string_1)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class135 smethod_1()
		{
			return null;
		}

		static Class135()
		{
			Class200.smethod_34();
		}
	}

	private sealed class Class136
	{
		public int int_0;

		public Func<SkillId, bool> func_0;

		internal static Class136 class136_0;

		internal void method_0()
		{
		}

		internal bool method_1(SkillId skillId_0)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class136 smethod_1()
		{
			return null;
		}

		static Class136()
		{
			Class200.smethod_34();
		}
	}

	private sealed class Class137
	{
		public string string_0;

		public Func<SkillName, bool> func_0;

		internal static Class137 class137_0;

		internal void method_0()
		{
		}

		internal bool method_1(SkillName skillName_0)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class137 smethod_1()
		{
			return null;
		}

		static Class137()
		{
			Class200.smethod_34();
		}
	}

	private sealed class Class138
	{
		public int int_0;

		public Func<SkillId, bool> func_0;

		internal static Class138 class138_0;

		internal void method_0()
		{
		}

		internal bool method_1(SkillId skillId_0)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class138 smethod_1()
		{
			return null;
		}

		static Class138()
		{
			Class200.smethod_34();
		}
	}

	private sealed class Class139
	{
		public string string_0;

		public Func<SkillName, bool> func_0;

		private static Class139 class139_0;

		internal void method_0()
		{
		}

		internal bool method_1(SkillName skillName_0)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class139 smethod_1()
		{
			return null;
		}

		static Class139()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLogic_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<LogicResult> _003C_003Et__builder;

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

		static _003CLogic_003Ed__17()
		{
			Class200.smethod_34();
		}
	}

	private static SkillBlacklist skillBlacklist_0;

	private Gui gui_0;

	private static object object_0;

	private static List<ushort> list_0;

	private static List<string> list_1;

	internal static SkillBlacklist skillBlacklist_1;

	public static SkillBlacklist Instance => null;

	public string Name => null;

	public string Author => null;

	public string Description => null;

	public string Version => null;

	public JsonSettings Settings => null;

	public UserControl Control => null;

	public string Url => null;

	public void Initialize()
	{
	}

	public void Deinitialize()
	{
	}

	public MessageResult Message(Message message)
	{
		return (MessageResult)(object)null;
	}

	[AsyncStateMachine(typeof(_003CLogic_003Ed__17))]
	public Task<LogicResult> Logic(Logic logic)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	internal static void smethod_0(List<SkillId> list_2)
	{
	}

	internal static void smethod_1(List<SkillName> list_2)
	{
	}

	private static bool smethod_2(string string_0)
	{
		return true;
	}

	private static bool smethod_3(int int_0)
	{
		return true;
	}

	public static bool IsBlacklisted(string name)
	{
		return true;
	}

	public static bool IsBlacklisted(int id)
	{
		return true;
	}

	public static bool IsBlacklisted(Skill skill)
	{
		return true;
	}

	public static bool Add(int id)
	{
		return true;
	}

	public static bool Add(string name)
	{
		return true;
	}

	public static bool Remove(int id)
	{
		return true;
	}

	public static bool Remove(string name)
	{
		return true;
	}

	public bool ShouldHide()
	{
		return true;
	}

	static SkillBlacklist()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		object_0 = new object();
		list_0 = new List<ushort>();
		list_1 = new List<string>();
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static SkillBlacklist smethod_5()
	{
		return null;
	}
}
