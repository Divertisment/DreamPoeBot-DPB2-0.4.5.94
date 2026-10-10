using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class PlayerClass : Component
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct240
	{
		public byte byte_0;
	}

	private PerFrameCachedValue<Struct240> perFrameCachedValue_0;

	private static PlayerClass playerClass_0;

	public CharacterClass Class => (CharacterClass)(object)null;

	public AscendancyClass AscendencyClass => (AscendancyClass)(object)null;

	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	private Struct240 method_2()
	{
		return (Struct240)(object)null;
	}

	private Struct240 method_3()
	{
		return (Struct240)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static PlayerClass smethod_5()
	{
		return null;
	}

	static PlayerClass()
	{
		Class200.smethod_34();
	}
}
