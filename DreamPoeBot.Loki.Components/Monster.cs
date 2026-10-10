using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class Monster : Component
{
	[StructLayout(LayoutKind.Explicit)]
	public struct GStruct3
	{
		[FieldOffset(16)]
		public long MonsteVarietyAddress;

		[FieldOffset(32)]
		public int Level;
	}

	[StructLayout(LayoutKind.Explicit, Size = 1030)]
	public struct Struct274MonsteVarietyComp
	{
		[FieldOffset(0)]
		public long intptr_0Metadata;

		[FieldOffset(8)]
		public long intptr_DatMosterTypeData;

		[FieldOffset(28)]
		public int int_0ObjectSiZe;

		[FieldOffset(32)]
		public int int_1MinAttackDistance;

		[FieldOffset(36)]
		public int int_2MaxAttackDistance;

		[FieldOffset(80)]
		public long int_15ModsCount;

		[FieldOffset(88)]
		public long intptr_8Mods;

		[FieldOffset(152)]
		public long int_30TagsCountMaybe;

		[FieldOffset(160)]
		public long intptr11_TaGS;

		[FieldOffset(272)]
		public long IntPtr_MonsterName;
	}

	[StructLayout(LayoutKind.Explicit, Size = 50)]
	public struct Struct273MonsteTypeComp
	{
		[FieldOffset(0)]
		public long TypeId;

		[FieldOffset(37)]
		public long MonsteResistanceStruct;

		[FieldOffset(29)]
		public long MonsteResistanceCount;
	}

	private string string_0;

	private string string_1;

	private readonly List<string> list_0;

	private string string_2;

	private static Monster monster_0;

	public int Level => 0;

	public List<string> Tags => null;

	public string MonsterTypeMetadata => null;

	public string MonsterTypeId => null;

	public List<string> BaseResistenceName => null;

	public string MonsterName => null;

	[SpecialName]
	private List<string> method_2()
	{
		return null;
	}

	[SpecialName]
	private long method_3()
	{
		return 0L;
	}

	[SpecialName]
	private Struct273MonsteTypeComp method_4()
	{
		return (Struct273MonsteTypeComp)(object)null;
	}

	[SpecialName]
	private long method_5()
	{
		return 0L;
	}

	[SpecialName]
	private Struct274MonsteVarietyComp method_6()
	{
		return (Struct274MonsteVarietyComp)(object)null;
	}

	[SpecialName]
	private GStruct3 method_7()
	{
		return (GStruct3)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static Monster smethod_5()
	{
		return null;
	}

	static Monster()
	{
		Class200.smethod_34();
	}
}
