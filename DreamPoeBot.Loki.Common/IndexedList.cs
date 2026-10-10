using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ns0;

namespace DreamPoeBot.Loki.Common;

public class IndexedList<T> : List<T>
{
	[CompilerGenerated]
	private bool bool_0;

	private int int_0;

	private static object object_0;

	public bool IsCyclic
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public int Index
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsAtEnd => true;

	public T CurrentOrDefault => (T)null;

	public T Current => (T)null;

	public IndexedList()
	{
	}

	public IndexedList(bool isCyclic = false)
	{
	}

	public IndexedList(int capacity, bool isCyclic = false)
	{
	}

	public IndexedList(IEnumerable<T> collection, bool isCyclic = false)
	{
	}

	public bool Next()
	{
		return true;
	}

	public bool Previous()
	{
		return true;
	}

	private void method_0()
	{
	}

	private static int smethod_0(int int_1, int int_2, int int_3)
	{
		return 0;
	}

	internal static bool smethod_1()
	{
		return true;
	}

	internal static object smethod_2()
	{
		return null;
	}

	static IndexedList()
	{
		Class200.smethod_34();
	}
}
