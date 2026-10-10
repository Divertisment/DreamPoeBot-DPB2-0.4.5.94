using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class NPC : Component
{
	[StructLayout(LayoutKind.Explicit)]
	public struct NpcComponentStructure
	{
		[FieldOffset(32)]
		public byte byte_4IsIgnoreHidden;

		[FieldOffset(33)]
		public byte byte_5IsMinimapLabelVisible;

		[FieldOffset(72)]
		public long intptr_3HasIconOverHead;
	}

	private PerFrameCachedValue<NpcComponentStructure> perFrameCachedValue_0;

	private static NPC npc_0;

	public bool HasIconOverHead => true;

	public bool IsIgnoreHidden => true;

	public bool IsMinimapLabelVisible => true;

	[SpecialName]
	internal NpcComponentStructure method_2()
	{
		return (NpcComponentStructure)(object)null;
	}

	private NpcComponentStructure method_3()
	{
		return (NpcComponentStructure)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static NPC smethod_5()
	{
		return null;
	}

	static NPC()
	{
		Class200.smethod_34();
	}
}
