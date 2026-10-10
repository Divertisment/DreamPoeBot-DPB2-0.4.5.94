using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Loki.Game.GameData;

public class DatClassPassiveSkillOverridesWrapper
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 48)]
	public struct DatClassPassiveSkillOverridesWrapperStruct
	{
		[FieldOffset(0)]
		public long CharactersDat;

		[FieldOffset(16)]
		public long PassiveSkillsDatFrom;

		[FieldOffset(32)]
		public long PassiveSkillsDatTo;
	}

	[CompilerGenerated]
	private readonly long long_0;

	[CompilerGenerated]
	private readonly int int_0;

	[CompilerGenerated]
	private readonly CharacterClass characterClass_0;

	[CompilerGenerated]
	private readonly int int_1;

	[CompilerGenerated]
	private readonly int int_2;

	private static DatClassPassiveSkillOverridesWrapper datClassPassiveSkillOverridesWrapper_0;

	public long Address
	{
		[CompilerGenerated]
		get
		{
			return 0L;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	public int Index
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	public CharacterClass Class
	{
		[CompilerGenerated]
		get
		{
			return (CharacterClass)(object)null;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	public int FromRowId
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	public int ToRowId
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static DatClassPassiveSkillOverridesWrapper smethod_1()
	{
		return null;
	}

	static DatClassPassiveSkillOverridesWrapper()
	{
		Class200.smethod_34();
	}
}
