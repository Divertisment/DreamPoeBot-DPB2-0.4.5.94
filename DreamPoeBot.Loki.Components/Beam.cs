using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class Beam : Component
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct189
	{
		private long long_0;

		private long long_1;

		private long long_2;

		private long long_3;

		private long long_4;

		private long long_5;

		private long long_6;

		private long long_7;

		public int uaXlCbBvsUu;

		public int int_0;

		private long long_8;

		public Vector3 vector3_0;

		public Vector3 vector3_1;
	}

	private PerFrameCachedValue<Struct189> perFrameCachedValue_0;

	internal static Beam beam_0;

	public Vector3 BeamStart => (Vector3)(object)null;

	public Vector3 BeamEnd => (Vector3)(object)null;

	public int Unknown1 => 0;

	public int Unknown2 => 0;

	[SpecialName]
	internal Struct189 method_2()
	{
		return (Struct189)(object)null;
	}

	private Struct189 method_3()
	{
		return (Struct189)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static Beam smethod_5()
	{
		return null;
	}

	static Beam()
	{
		Class200.smethod_34();
	}
}
