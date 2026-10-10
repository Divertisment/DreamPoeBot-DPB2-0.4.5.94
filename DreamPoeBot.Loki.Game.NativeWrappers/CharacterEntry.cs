using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Std;
using ns0;

namespace DreamPoeBot.Loki.Game.NativeWrappers;

public class CharacterEntry
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct95
	{
		public readonly GStruct2 gstruct2_0;

		public readonly GStruct2 gstruct2_1;

		private readonly uint uint_0;

		private readonly byte byte_0;

		private readonly byte byte_1;

		private readonly byte byte_2;

		private readonly byte byte_3;

		private readonly byte byte_4;

		private readonly byte byte_5;

		private readonly byte byte_6;

		private readonly byte byte_7;

		public readonly byte byte_8;

		private readonly byte byte_9;

		public readonly byte byte_10;

		private readonly byte byte_11;

		private readonly short short_0;

		private readonly short short_1;

		private readonly short short_2;

		private readonly short short_3;
	}

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly string string_1;

	[CompilerGenerated]
	private readonly int int_0;

	[CompilerGenerated]
	private readonly CharacterClass characterClass_0;

	[CompilerGenerated]
	private readonly AscendancyClass ascendancyClass_0;

	private static CharacterEntry characterEntry_0;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public string League
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public int Level
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
	}

	public CharacterClass CharacterClass
	{
		[CompilerGenerated]
		get
		{
			return (CharacterClass)(object)null;
		}
	}

	public AscendancyClass AscendancyClass
	{
		[CompilerGenerated]
		get
		{
			return (AscendancyClass)(object)null;
		}
	}

	internal CharacterEntry(Struct95 native)
	{
	}

	public override string ToString()
	{
		return null;
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static CharacterEntry smethod_1()
	{
		return null;
	}

	static CharacterEntry()
	{
		Class200.smethod_34();
	}
}
