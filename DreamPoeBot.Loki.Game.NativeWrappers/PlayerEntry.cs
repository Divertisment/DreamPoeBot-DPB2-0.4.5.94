using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Std;
using ns0;

namespace DreamPoeBot.Loki.Game.NativeWrappers;

public class PlayerEntry : RemoteMemoryObject
{
	[StructLayout(LayoutKind.Explicit, Size = 528)]
	internal struct Struct99
	{
		[FieldOffset(0)]
		public GStruct2 gstruct2_0;

		[FieldOffset(32)]
		public GStruct2 gstruct2_1;

		[FieldOffset(64)]
		public GStruct2 hgFlXirYnnI;

		[FieldOffset(96)]
		public GStruct2 gstruct2_2;

		[FieldOffset(496)]
		public ushort ushort_0;

		[FieldOffset(500)]
		public ushort ushort_1;

		[FieldOffset(32)]
		public byte byte_0;

		[FieldOffset(33)]
		public byte byte_1;

		[FieldOffset(514)]
		public byte byte_2;
	}

	private readonly Struct99? nullable_0;

	internal static PlayerEntry playerEntry_0;

	public string AccountName => null;

	public DatWorldAreaWrapper Area => null;

	[Obsolete("character class enum is not up to date")]
	public CharacterClass Class => (CharacterClass)(object)null;

	public bool IsOnline => true;

	public string League => null;

	public int Level => 0;

	public string Name => null;

	public string StatusMessage => null;

	internal PlayerEntry(long address)
	{
	}

	internal PlayerEntry(Struct99 native)
	{
	}

	internal PlayerEntry(long address, Struct99 native)
	{
	}

	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	private Struct99 method_0()
	{
		return (Struct99)(object)null;
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static PlayerEntry smethod_3()
	{
		return null;
	}

	static PlayerEntry()
	{
		Class200.smethod_34();
	}
}
