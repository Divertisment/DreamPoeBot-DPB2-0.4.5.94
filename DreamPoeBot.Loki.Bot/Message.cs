using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ns0;

namespace DreamPoeBot.Loki.Bot;

public class Message
{
	[CompilerGenerated]
	private static class OutputClass
	{
		public static CallSite<Func<CallSite, Type, IMessageHandler, object, string, Tuple<IMessageHandler, object, string>>> Target;

		static OutputClass()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private static class InputClass
	{
		public static CallSite<Func<CallSite, Type, object, string, Tuple<object, string>>> Target;

		static InputClass()
		{
			Class200.smethod_34();
		}
	}

	private readonly List<Tuple<object, string>> list_0;

	[CompilerGenerated]
	private readonly string string_0;

	private readonly List<Tuple<IMessageHandler, object, string>> list_1;

	[CompilerGenerated]
	private readonly object object_0;

	private static Message message_0;

	public string Id
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public IReadOnlyList<Tuple<object, string>> Inputs => null;

	public IReadOnlyList<Tuple<IMessageHandler, object, string>> Outputs => null;

	public object Sender
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public Message(string id, object sender = null)
	{
	}

	public Message(string id, object sender, params dynamic[] input)
	{
	}

	public void AddInput<T>(T input, string name)
	{
	}

	public void AddInputs(params dynamic[] input)
	{
	}

	public void AddOutput<T>(IMessageHandler handler, T output, string name = "")
	{
	}

	public void AddOutputs(IMessageHandler handler, params dynamic[] output)
	{
	}

	public T GetInput<T>(int index = 0)
	{
		return (T)null;
	}

	public T GetInput<T>(string name)
	{
		return (T)null;
	}

	public T GetOutput<T>(int index = 0)
	{
		return (T)null;
	}

	public T GetOutput<T>(string name)
	{
		return (T)null;
	}

	public bool TryGetInput<T>(int index, out T input)
	{
		return true;
	}

	public bool TryGetInput<T>(string name, out T input)
	{
		return true;
	}

	public bool TryGetOutput<T>(int index, out T input)
	{
		return true;
	}

	public bool TryGetOutput<T>(string name, out T output)
	{
		return true;
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static Message smethod_1()
	{
		return null;
	}

	static Message()
	{
		Class200.smethod_34();
	}
}
