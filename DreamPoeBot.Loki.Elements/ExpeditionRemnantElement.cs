using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.Std;
using ns0;

namespace DreamPoeBot.Loki.Elements;

public class ExpeditionRemnantElement : Element
{
	[StructLayout(LayoutKind.Explicit)]
	public struct Expedition2EncounterDataStruct
	{
		[FieldOffset(16)]
		public long NetworkObject;

		[FieldOffset(40)]
		public long FixedRuneDat;

		[FieldOffset(56)]
		public int RuneCount;

		[FieldOffset(60)]
		public int FixedRunePosition;

		[FieldOffset(64)]
		public NativeVector PropagatedRunePositionsVector;

		[FieldOffset(88)]
		internal int int_0;

		[FieldOffset(96)]
		public long SelectedExpedition2RecipeDat;
	}

	private static ExpeditionRemnantElement expeditionRemnantElement_0;

	[SpecialName]
	internal Element method_29()
	{
		return null;
	}

	[SpecialName]
	internal Element method_30()
	{
		return null;
	}

	[SpecialName]
	internal Element method_31()
	{
		return null;
	}

	[SpecialName]
	internal Element method_32()
	{
		return null;
	}

	[SpecialName]
	internal Element method_33()
	{
		return null;
	}

	[SpecialName]
	internal Expedition2EncounterDataStruct method_34()
	{
		return (Expedition2EncounterDataStruct)(object)null;
	}

	[SpecialName]
	internal List<string> method_35()
	{
		return null;
	}

	internal static bool smethod_11()
	{
		return true;
	}

	internal static ExpeditionRemnantElement smethod_12()
	{
		return null;
	}

	static ExpeditionRemnantElement()
	{
		Class200.smethod_34();
	}
}
