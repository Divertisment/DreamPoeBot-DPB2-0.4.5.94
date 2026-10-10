using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Loki.RemoteMemoryObjects;

public class ActorVaalSkill : RemoteMemoryObject
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct29
	{
		public Struct10 struct10_0;

		public int int_0;

		public int int_1;

		public int int_2;

		public byte byte_0;

		public byte kGuAbqfspRG;

		public byte byte_1;

		public byte byte_2;
	}

	private static ActorVaalSkill actorVaalSkill_0;

	public string VaalSkillInternalName => null;

	public string VaalSkillDisplayName => null;

	public string VaalSkillDescription => null;

	public string VaalSkillSkillName => null;

	public string VaalSkillIcon => null;

	public int VaalMaxSouls => 0;

	public int VaalSoulsPerUse => 0;

	public int CurrVaalSouls => 0;

	[SpecialName]
	internal Struct29 method_0()
	{
		return (Struct29)(object)null;
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static ActorVaalSkill smethod_3()
	{
		return null;
	}

	static ActorVaalSkill()
	{
		Class200.smethod_34();
	}
}
