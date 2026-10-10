using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class MinimapIcon : Component
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct228
	{
		private long long_0;

		public long long_1;

		private byte byte_0;

		private byte byte_1;

		private byte byte_2;

		private byte byte_3;

		private int int_0;

		private long long_2;

		public long long_3;

		private long long_4;

		private int int_1;

		public byte byte_4;

		private byte byte_5;

		private byte byte_6;

		private byte byte_7;

		private long long_5;

		private long long_6;

		private long long_7;
	}

	private PerFrameCachedValue<Struct228> perFrameCachedValue_0;

	private static MinimapIcon minimapIcon_0;

	public DatMinimapIconWrapper Minimapicon => null;

	public bool IsVisible => true;

	public string Metadata => null;

	[SpecialName]
	private Struct228 method_2()
	{
		return (Struct228)(object)null;
	}

	public override string ToString()
	{
		return null;
	}

	private Struct228 method_3()
	{
		return (Struct228)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static MinimapIcon smethod_5()
	{
		return null;
	}

	static MinimapIcon()
	{
		Class200.smethod_34();
	}
}
