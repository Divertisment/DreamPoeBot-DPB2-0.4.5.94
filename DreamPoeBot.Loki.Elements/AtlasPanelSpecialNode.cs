using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Elements;

public class AtlasPanelSpecialNode : Element
{
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	internal struct Struct164
	{
		[FieldOffset(704)]
		internal Vector2i vector2i_0;

		[FieldOffset(776)]
		public long long_0;

		[FieldOffset(792)]
		public Vector2i vector2i_1;
	}

	private PerFrameCachedValue<Struct164> perFrameCachedValue_6;

	internal static AtlasPanelSpecialNode atlasPanelSpecialNode_0;

	[SpecialName]
	internal Struct164 method_29()
	{
		return (Struct164)(object)null;
	}

	[CompilerGenerated]
	private Struct164 method_30()
	{
		return (Struct164)(object)null;
	}

	internal static bool smethod_11()
	{
		return true;
	}

	internal static AtlasPanelSpecialNode smethod_12()
	{
		return null;
	}

	static AtlasPanelSpecialNode()
	{
		Class200.smethod_34();
	}
}
