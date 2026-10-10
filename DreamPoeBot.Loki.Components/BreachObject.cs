using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class BreachObject : Component
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct191
	{
		public Struct14 struct14_0;

		public byte byte_0;

		private byte byte_1;

		private byte byte_2;

		private byte byte_3;

		private int int_0;

		public long long_0;

		public GStruct2 gstruct2_0;

		public Vector2i vector2i_0;

		public float float_0;

		public float float_1;

		public float float_2;

		private int int_1;

		public BreachState breachState_0;

		public byte byte_4;

		private byte byte_5;

		private byte byte_6;

		private byte byte_7;
	}

	private PerFrameCachedValue<Struct191> perFrameCachedValue_0;

	internal static BreachObject breachObject_0;

	public string AttachedEffect => null;

	public Vector2i BreachPosition => (Vector2i)(object)null;

	public float Radius => 0f;

	public BreachState State => (BreachState)(object)null;

	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	internal Struct191 method_2()
	{
		return (Struct191)(object)null;
	}

	private Struct191 method_3()
	{
		return (Struct191)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static BreachObject smethod_5()
	{
		return null;
	}

	static BreachObject()
	{
		Class200.smethod_34();
	}
}
