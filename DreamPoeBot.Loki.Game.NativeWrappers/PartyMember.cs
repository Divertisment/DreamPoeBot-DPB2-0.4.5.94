using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Std;
using ns0;

namespace DreamPoeBot.Loki.Game.NativeWrappers;

public class PartyMember : RemoteMemoryObject
{
	internal struct Struct98
	{
		internal byte byte_0;

		internal byte byte_1;

		internal byte byte_2;

		internal byte byte_3;

		internal byte byte_4;

		internal byte byte_5;

		internal byte byte_6;

		internal byte byte_7;

		internal GStruct2 gstruct2_0;

		internal GStruct2 gstruct2_1;

		internal byte byte_8;

		internal byte byte_9;

		internal byte byte_10;

		internal byte byte_11;

		internal byte byte_12;

		internal byte byte_13;

		internal byte awvlXedAhGD;

		internal byte byte_14;
	}

	private readonly Struct98? nullable_0;

	internal static PartyMember partyMember_0;

	public PartyStatus MemberStatus => (PartyStatus)(object)null;

	public string AccountName => null;

	public string CharacterName => null;

	internal PartyMember(long address)
	{
	}

	internal PartyMember(long ptr, Struct98 native)
	{
	}

	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	private Struct98 method_0()
	{
		return (Struct98)(object)null;
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static PartyMember smethod_3()
	{
		return null;
	}

	static PartyMember()
	{
		Class200.smethod_34();
	}
}
