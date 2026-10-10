using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.Game.Utilities;
using DreamPoeBot.Loki.RemoteMemoryObjects;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class Buffs : Component
{
	[StructLayout(LayoutKind.Explicit, Size = 384)]
	public struct BuffsStructure
	{
		[FieldOffset(352)]
		public NativeVector BuffVector;
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	[Obsolete("Legacy mixed DAT/runtime layout; use Aura and DatBuffDefinitionWrapper. DA RITESTARE before use.")]
	public struct BuffOffsets
	{
		[FieldOffset(0)]
		public long Name;

		[FieldOffset(16)]
		public byte IsInvisible;

		[FieldOffset(17)]
		public byte IsRemovable;

		[FieldOffset(62)]
		public byte Charges;

		[FieldOffset(16)]
		public float MaxTime;

		[FieldOffset(20)]
		public float Timer;
	}

	private PerFrameCachedValue<List<Aura>> perFrameCachedValue_0;

	private PerFrameCachedValue<BuffsStructure> perFrameCachedValue_1;

	private static Buffs buffs_0;

	public List<Aura> Auras => null;

	public bool HasBuff(string buff)
	{
		return true;
	}

	private List<Aura> method_2()
	{
		return null;
	}

	private List<Aura> method_3(long long_2, long long_3)
	{
		return null;
	}

	[SpecialName]
	internal BuffsStructure method_4()
	{
		return (BuffsStructure)(object)null;
	}

	private BuffsStructure method_5()
	{
		return (BuffsStructure)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static Buffs smethod_5()
	{
		return null;
	}

	static Buffs()
	{
		Class200.smethod_34();
	}
}
