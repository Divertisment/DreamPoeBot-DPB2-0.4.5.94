using System.Collections.Generic;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.Std;
using ns0;

namespace DreamPoeBot.Loki.Game.NativeWrappers;

public class PartyInvite : RemoteMemoryObject
{
	[StructLayout(LayoutKind.Explicit)]
	internal struct Struct97
	{
		[FieldOffset(0)]
		public int int_0;

		[FieldOffset(8)]
		public GStruct2 gstruct2_0;

		[FieldOffset(40)]
		public GStruct2 gstruct2_1;

		[FieldOffset(72)]
		public GStruct2 gstruct2_2;

		[FieldOffset(104)]
		public GStruct2 gstruct2_3;

		[FieldOffset(136)]
		public NativeVector nativeVector_0;
	}

	private readonly Struct97? nullable_0;

	private static PartyInvite partyInvite_0;

	internal Struct97 Structure => (Struct97)(object)null;

	public int PartyId => 0;

	public string Unknown_04 => null;

	public string PartyDescription => null;

	public string LeaderCharacterName => null;

	public string InviterCharacterName => null;

	public List<PartyMember> PartyMembers => null;

	internal PartyInvite(long address)
	{
	}

	internal PartyInvite(long ptr, Struct97 native)
	{
	}

	public override string ToString()
	{
		return null;
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static PartyInvite smethod_3()
	{
		return null;
	}

	static PartyInvite()
	{
		Class200.smethod_34();
	}
}
