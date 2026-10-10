using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class Targetable : Component
{
	[StructLayout(LayoutKind.Explicit)]
	public struct TargetableComponentStructure
	{
		[FieldOffset(105)]
		public byte CanTarget;

		[FieldOffset(106)]
		public byte CanHighlight;

		[FieldOffset(107)]
		public byte IsTargeted;
	}

	private PerFrameCachedValue<TargetableComponentStructure> perFrameCachedValue_0;

	private static Targetable targetable_0;

	public bool CanTarget => true;

	public bool CanHighlight => true;

	public bool IsTargeted => true;

	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	internal TargetableComponentStructure method_2()
	{
		return (TargetableComponentStructure)(object)null;
	}

	private TargetableComponentStructure ifmAwbmnvZR()
	{
		return (TargetableComponentStructure)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static Targetable smethod_5()
	{
		return null;
	}

	static Targetable()
	{
		Class200.smethod_34();
	}
}
