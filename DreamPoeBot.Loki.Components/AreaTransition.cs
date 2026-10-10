using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class AreaTransition : Component
{
	[StructLayout(LayoutKind.Explicit)]
	internal struct Struct184
	{
		[FieldOffset(40)]
		public ushort ushort_0;

		[FieldOffset(48)]
		public byte byte_0;
	}

	private PerFrameCachedValue<Struct184> perFrameCachedValue_0;

	private DatWorldAreaWrapper datWorldAreaWrapper_0;

	private static AreaTransition areaTransition_0;

	public DatWorldAreaWrapper Destination => null;

	public TransitionTypes TransitionType => (TransitionTypes)(object)null;

	[SpecialName]
	internal Struct184 method_2()
	{
		return (Struct184)(object)null;
	}

	private Struct184 method_3()
	{
		return (Struct184)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static AreaTransition smethod_5()
	{
		return null;
	}

	static AreaTransition()
	{
		Class200.smethod_34();
	}
}
