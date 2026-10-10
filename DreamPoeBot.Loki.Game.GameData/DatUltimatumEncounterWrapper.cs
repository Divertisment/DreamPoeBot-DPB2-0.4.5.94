using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Loki.Game.GameData;

public class DatUltimatumEncounterWrapper
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct127
	{
		public long long_0;

		public long long_1;

		public int int_0;

		private int int_1;

		public long long_2;

		public long long_3;

		public long long_4;

		private long long_5;

		public long long_6;

		public int int_2;

		private byte byte_0;

		private int int_3;

		private byte byte_1;
	}

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private List<DatUltimatumModifierTypeWrapper> list_0;

	[CompilerGenerated]
	private string string_2;

	[CompilerGenerated]
	private DatUltimatumEncounterTypeWrapper datUltimatumEncounterTypeWrapper_0;

	[CompilerGenerated]
	private Struct127 struct127_0;

	[CompilerGenerated]
	private long long_0;

	internal static DatUltimatumEncounterWrapper datUltimatumEncounterWrapper_0;

	public string Id
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public List<DatUltimatumModifierTypeWrapper> ModType
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public string BossARMFile
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public DatUltimatumEncounterTypeWrapper EncounterTypeType
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	internal long Address
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

	[SpecialName]
	internal Memory method_0()
	{
		return null;
	}

	[SpecialName]
	[CompilerGenerated]
	internal Struct127 method_1()
	{
		return (Struct127)(object)null;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_2(Struct127 struct127_1)
	{
	}

	public DatUltimatumEncounterWrapper(long address)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static DatUltimatumEncounterWrapper smethod_1()
	{
		return null;
	}

	static DatUltimatumEncounterWrapper()
	{
		Class200.smethod_34();
	}
}
