using System;
using System.Runtime.CompilerServices;
using DreamPoeBot.Common;
using ns0;

namespace DreamPoeBot.Loki.Game;

public class MemoryObject : IEquatable<MemoryObject>, IMemoryObject
{
	[CompilerGenerated]
	private long UgxrbQkWn2;

	internal static MemoryObject memoryObject_0;

	public long BaseAddress
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

	public virtual bool IsValid => true;

	public bool Equals(MemoryObject other)
	{
		return true;
	}

	public override bool Equals(object obj)
	{
		return true;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator ==(MemoryObject left, MemoryObject right)
	{
		return true;
	}

	public static bool operator !=(MemoryObject left, MemoryObject right)
	{
		return true;
	}

	protected MemoryObject(long ptr)
	{
	}

	public bool UpdatePointer(long ptr)
	{
		return true;
	}

	protected virtual void OnPointerChanged()
	{
	}

	public static implicit operator long(MemoryObject @object)
	{
		return 0L;
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static MemoryObject smethod_1()
	{
		return null;
	}

	static MemoryObject()
	{
		Class200.smethod_34();
	}
}
