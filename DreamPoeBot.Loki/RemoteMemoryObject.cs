using System;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Components;
using DreamPoeBot.Loki.RemoteMemoryObjects;
using ns0;

namespace DreamPoeBot.Loki;

public abstract class RemoteMemoryObject : IEquatable<RemoteMemoryObject>
{
	[CompilerGenerated]
	private long long_0;

	private static RemoteMemoryObject remoteMemoryObject_0;

	public long Address
	{
		[CompilerGenerated]
		get
		{
			return 0L;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public TheGame Game => null;

	public virtual Memory M => null;

	protected Offsets Offsets => null;

	public virtual bool IsValid => true;

	public RemoteMemoryObject()
	{
	}

	public RemoteMemoryObject(long address)
	{
	}

	public bool Equals(RemoteMemoryObject other)
	{
		return true;
	}

	public override bool Equals(object obj)
	{
		return true;
	}

	public T ReadObjectAt<T>(int offset) where T : RemoteMemoryObject, new()
	{
		return null;
	}

	public Skill ReadObjectSkill(long addressPointer, Actor actor)
	{
		return null;
	}

	public T ReadObject<T>(long addressPointer) where T : RemoteMemoryObject, new()
	{
		return null;
	}

	public T CreateObject<T>(long addressPointer) where T : RemoteMemoryObject, new()
	{
		return null;
	}

	public T GetObjectAt<T>(int offset) where T : RemoteMemoryObject, new()
	{
		return null;
	}

	public T GetObjectAt<T>(long offset) where T : RemoteMemoryObject, new()
	{
		return null;
	}

	public T GetObject<T>(long address) where T : RemoteMemoryObject, new()
	{
		return null;
	}

	public T AsObject<T>() where T : RemoteMemoryObject, new()
	{
		return null;
	}

	public static bool operator ==(RemoteMemoryObject lhs, RemoteMemoryObject rhs)
	{
		return true;
	}

	public static bool operator !=(RemoteMemoryObject lhs, RemoteMemoryObject rhs)
	{
		return true;
	}

	public bool UpdatePointer(long ptr)
	{
		return true;
	}

	protected virtual void OnPointerChanged()
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static RemoteMemoryObject smethod_1()
	{
		return null;
	}

	static RemoteMemoryObject()
	{
		Class200.smethod_34();
	}
}
