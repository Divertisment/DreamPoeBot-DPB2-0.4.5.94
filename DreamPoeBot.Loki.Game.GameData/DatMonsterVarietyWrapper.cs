using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Loki.Game.GameData;

public class DatMonsterVarietyWrapper
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1030)]
	public struct MonsterVarietyStruct
	{
		[FieldOffset(0)]
		public long Metadata;

		[FieldOffset(272)]
		public long Name;

		[FieldOffset(465)]
		public ushort Hash16;
	}

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	private MonsterVarietyStruct monsterVarietyStruct_0;

	internal static DatMonsterVarietyWrapper datMonsterVarietyWrapper_0;

	public int Index
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

	public string Metadata
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

	public string Name
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

	public int MonsterId
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

	[SpecialName]
	internal Memory method_0()
	{
		return null;
	}

	[SpecialName]
	[CompilerGenerated]
	internal MonsterVarietyStruct method_1()
	{
		return (MonsterVarietyStruct)(object)null;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void DbXcdtsIk0(MonsterVarietyStruct monsterVarietyStruct_1)
	{
	}

	internal DatMonsterVarietyWrapper(MonsterVarietyStruct native, int index)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static DatMonsterVarietyWrapper smethod_1()
	{
		return null;
	}

	static DatMonsterVarietyWrapper()
	{
		Class200.smethod_34();
	}
}
