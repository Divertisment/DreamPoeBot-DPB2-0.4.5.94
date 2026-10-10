using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Common;
using DreamPoeBot.Loki.Game.Std;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class Player : Component
{
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	internal struct Struct239
	{
		[FieldOffset(432)]
		public GStruct2 gstruct2_0;

		[FieldOffset(464)]
		public uint uint_0;

		[FieldOffset(472)]
		public uint AdQlhhksHmn;

		[FieldOffset(476)]
		public int int_0;

		[FieldOffset(480)]
		public int int_1;

		[FieldOffset(484)]
		public int int_2;

		[FieldOffset(488)]
		public int int_3;

		[FieldOffset(492)]
		public int int_4;

		[FieldOffset(496)]
		public int int_5;

		[FieldOffset(500)]
		public int int_6;

		[FieldOffset(504)]
		public int int_7;

		[FieldOffset(508)]
		public int int_8;

		[FieldOffset(516)]
		public byte Level;
	}

	private static readonly ILog ilog_0;

	internal static Player player_0;

	public int Strength => 0;

	public int Dexterity => 0;

	public int Intelligence => 0;

	public int Level => 0;

	public uint Experience => 0u;

	public string Name => null;

	public uint AllocatedLootId => 0u;

	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	private Struct239 method_2()
	{
		return (Struct239)(object)null;
	}

	private Struct239 method_3()
	{
		return (Struct239)(object)null;
	}

	static Player()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static Player smethod_5()
	{
		return null;
	}
}
