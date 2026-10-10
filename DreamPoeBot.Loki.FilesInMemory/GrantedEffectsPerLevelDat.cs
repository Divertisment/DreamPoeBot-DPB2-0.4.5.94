using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Models;
using ns0;

namespace DreamPoeBot.Loki.FilesInMemory;

public class GrantedEffectsPerLevelDat : FileInMemory<GrantedEffectsPerLevel>
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 116)]
	private struct Struct148
	{
		[FieldOffset(0)]
		public long long_0;

		[FieldOffset(16)]
		public int Level;
	}

	private long[] long_6;

	public Dictionary<long, List<GrantedEffectsPerLevel>> Content;

	internal static GrantedEffectsPerLevelDat grantedEffectsPerLevelDat_0;

	public GrantedEffectsPerLevelDat(Memory m, long address, int datalen = 32)
	{
	}

	private protected override long vmethod_0(GrantedEffectsPerLevel record)
	{
		return 0L;
	}

	private protected override void vmethod_1()
	{
	}

	[CompilerGenerated]
	private GrantedEffectsPerLevel method_3(Struct148 struct148_0, long long_7, int int_2)
	{
		return null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static GrantedEffectsPerLevelDat smethod_5()
	{
		return null;
	}

	static GrantedEffectsPerLevelDat()
	{
		Class200.smethod_34();
	}
}
