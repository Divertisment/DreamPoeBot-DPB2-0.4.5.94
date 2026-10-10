using System.Collections;
using System.Runtime.CompilerServices;
using ns0;

namespace DreamPoeBot.Framework;

public abstract class YieldBase : IEnumerable, IEnumerator
{
	[CompilerGenerated]
	private object object_0;

	internal static YieldBase yieldBase_0;

	public object Current
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public bool MoveNext()
	{
		return true;
	}

	public void Reset()
	{
	}

	public abstract IEnumerator GetEnumerator();

	internal static bool smethod_0()
	{
		return true;
	}

	internal static YieldBase smethod_1()
	{
		return null;
	}

	static YieldBase()
	{
		Class200.smethod_34();
	}
}
