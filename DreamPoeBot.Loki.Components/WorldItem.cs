using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.Utilities;
using DreamPoeBot.Loki.Models;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class WorldItem : Component
{
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	internal struct Struct269
	{
		[FieldOffset(40)]
		public long long_0;

		[FieldOffset(64)]
		public uint uint_0;

		[FieldOffset(68)]
		public int int_0;

		[FieldOffset(72)]
		public int int_1;
	}

	private PerFrameCachedValue<Struct269> perFrameCachedValue_0;

	private PerFrameCachedValue<Entity> perFrameCachedValue_1;

	private static WorldItem worldItem_0;

	public bool IsPermanentlyAllocated => true;

	public int AllocatedToOtherTime => 0;

	public bool AllocatedToSomeoneElse => true;

	public uint AllocatedToPlayer => 0u;

	public DateTime DroppedTime => (DateTime)(object)null;

	public DateTime PublicTime => (DateTime)(object)null;

	public Entity ItemEntity => null;

	private static DateTime smethod_4(int int_0)
	{
		return (DateTime)(object)null;
	}

	private Struct269 method_2()
	{
		return (Struct269)(object)null;
	}

	private EntityWrapper method_3()
	{
		return null;
	}

	[SpecialName]
	private Struct269 method_4()
	{
		return (Struct269)(object)null;
	}

	internal static bool smethod_5()
	{
		return true;
	}

	internal static WorldItem smethod_6()
	{
		return null;
	}

	static WorldItem()
	{
		Class200.smethod_34();
	}
}
