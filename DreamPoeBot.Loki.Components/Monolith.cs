using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Std;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class Monolith : Component
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct237
	{
		private readonly Struct14 struct14_0;

		private readonly NativeVector nativeVector_0;

		private readonly NativeVector nativeVector_1;

		private readonly NativeVector nativeVector_2;

		private readonly NativeVector nativeVector_3;

		private readonly NativeVector nativeVector_4;

		private readonly NativeVector nativeVector_5;

		private readonly NativeVector nativeVector_6;

		private readonly nint intptr_0;

		private readonly nint intptr_1;

		public readonly NativeVector nativeVector_7;

		public readonly long long_0;

		private readonly long long_1;

		public readonly byte byte_0;

		private readonly byte byte_1;

		private readonly byte byte_2;

		private readonly byte byte_3;

		private readonly int int_0;

		private readonly long long_2;

		public readonly byte byte_4;

		private readonly byte byte_5;

		private readonly byte byte_6;

		private readonly byte byte_7;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct238
	{
		internal readonly long long_0;

		internal readonly long long_1;

		private readonly long long_2;

		private readonly int int_0;

		private readonly int int_1;

		private readonly int int_2;

		private readonly int int_3;

		private readonly int int_4;

		private readonly int int_5;

		private readonly long long_3;

		private readonly byte byte_0;

		private readonly byte byte_1;

		private readonly byte byte_2;

		private readonly byte byte_3;

		private readonly int int_6;

		private readonly long long_4;

		private readonly long long_5;

		private readonly byte byte_4;

		private readonly byte byte_5;

		private readonly byte byte_6;

		private readonly byte byte_7;

		private readonly int int_7;

		private readonly long long_6;

		private readonly byte byte_8;

		private readonly byte byte_9;

		private readonly byte byte_10;

		private readonly byte byte_11;

		private readonly long long_7;

		private readonly long long_8;

		private readonly int int_8;

		private readonly int int_9;

		private readonly int int_10;

		private readonly int int_11;

		private readonly int int_12;

		private readonly int int_13;

		private readonly int int_14;

		private readonly int int_15;

		private readonly long long_9;

		private readonly int int_16;

		private readonly int int_17;

		private readonly int int_18;

		private readonly int int_19;

		private readonly int int_20;

		private readonly int int_21;

		private readonly int int_22;

		private readonly int int_23;

		private readonly int int_24;

		private readonly int int_25;

		private readonly int int_26;

		private readonly int int_27;

		private readonly long long_10;

		private readonly long long_11;

		private readonly int int_28;

		private readonly int int_29;

		private readonly int int_30;

		private readonly int int_31;

		private readonly long long_12;

		private readonly long long_13;

		private readonly long long_14;

		private readonly long long_15;

		private readonly int int_32;

		private readonly int int_33;

		private readonly int int_34;

		private int int_35;

		private readonly long long_16;

		private readonly long long_17;

		private readonly long long_18;

		private readonly long long_19;

		private readonly long long_20;

		private readonly long long_21;

		private readonly long long_22;

		private readonly long long_23;

		private readonly long long_24;

		private readonly long long_25;

		private readonly long long_26;

		private readonly long long_27;

		private readonly long long_28;

		private readonly long long_29;

		private readonly long long_30;

		private readonly long long_31;

		private readonly long long_32;

		private readonly long long_33;

		private readonly int int_36;

		private readonly int int_37;

		private readonly long long_34;

		private readonly int int_38;

		private readonly int int_39;

		private readonly int int_40;

		private readonly int int_41;

		private readonly int int_42;

		private readonly int int_43;

		private readonly int int_44;

		private readonly byte byte_12;

		private readonly byte guXlhGifjFI;

		private readonly long long_35;

		private readonly long long_36;

		private readonly long long_37;

		private readonly long iwDlheWeHvp;

		private readonly long long_38;

		private readonly long long_39;

		private readonly long long_40;

		private readonly long long_41;

		private readonly long long_42;

		private readonly long long_43;

		private readonly long long_44;

		private readonly long long_45;

		private readonly long long_46;

		private readonly long long_47;

		private readonly long long_48;

		private readonly long long_49;

		private readonly long long_50;

		private readonly long long_51;

		private readonly long long_52;

		private readonly long long_53;

		private readonly long long_54;

		private readonly long long_55;

		private readonly int int_45;

		private readonly long long_56;

		private readonly long long_57;

		private readonly long long_58;

		private readonly long long_59;

		private readonly long long_60;

		private readonly int int_46;

		private readonly long long_61;

		private readonly long long_62;

		private readonly long long_63;

		private readonly int int_47;

		private readonly int int_48;

		private readonly byte byte_13;

		private readonly byte byte_14;

		private readonly byte byte_15;
	}

	private string string_0;

	private string string_1;

	private List<DatBaseItemTypeWrapper> list_0;

	private static Monolith monolith_0;

	public List<DatBaseItemTypeWrapper> EssenceBaseItemTypes => null;

	public bool IsCorrupted => true;

	public string MonsterTypeId => null;

	public string MonsterTypeMetadata => null;

	public int OpenPhase => 0;

	[SpecialName]
	internal Monster.Struct273MonsteTypeComp method_2()
	{
		return (Monster.Struct273MonsteTypeComp)(object)null;
	}

	[SpecialName]
	internal Struct238 method_3()
	{
		return (Struct238)(object)null;
	}

	[SpecialName]
	internal Struct237 method_4()
	{
		return (Struct237)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static Monolith smethod_5()
	{
		return null;
	}

	static Monolith()
	{
		Class200.smethod_34();
	}
}
