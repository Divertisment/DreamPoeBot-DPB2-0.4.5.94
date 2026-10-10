using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ns0;

namespace DreamPoeBot.Framework;

public class Runner
{
	[CompilerGenerated]
	private readonly string string_0;

	private readonly List<Coroutine> list_0;

	private readonly List<Tuple<string, string, long, DateTime, DateTime>> list_1;

	[CompilerGenerated]
	private int int_0;

	private readonly HashSet<Coroutine> hashSet_0;

	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	private int int_2;

	[CompilerGenerated]
	private int int_3;

	internal static Runner runner_0;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public bool IsRunning => true;

	public IEnumerable<Tuple<string, string, long, DateTime, DateTime>> FinishedCoroutines => null;

	public int FinishedCoroutineCount
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

	public IEnumerable<Coroutine> Coroutines => null;

	public IEnumerable<Coroutine> WorkingCoroutines => null;

	public IEnumerable<Coroutine> AutorestartCoroutines => null;

	public int CountAddCoroutines
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

	public int CountFalseAddCoroutines
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

	public int RunPerLoopIter
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public int Count => 0;

	public Coroutine GetCoroutineByname(string name)
	{
		return null;
	}

	public Runner(string name)
	{
	}

	public Coroutine Run(IEnumerator enumerator, string owner, string name = null)
	{
		return null;
	}

	public Coroutine Run(Coroutine routine)
	{
		return null;
	}

	public void StopCoroutines(IEnumerable<Coroutine> coroutines)
	{
	}

	public void ResumeCoroutines(IEnumerable<Coroutine> coroutines)
	{
	}

	public bool HasName(string name)
	{
		return true;
	}

	public bool Update()
	{
		return true;
	}

	public void AddToAutoupdate(Coroutine coroutine)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static Runner smethod_1()
	{
		return null;
	}

	static Runner()
	{
		Class200.smethod_34();
	}
}
