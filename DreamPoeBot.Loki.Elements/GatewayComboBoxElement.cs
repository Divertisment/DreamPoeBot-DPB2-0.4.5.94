using System.Runtime.CompilerServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Elements;

public class GatewayComboBoxElement : GenericComboBoxElement
{
	public enum GatewayEnum
	{
		Unknown = -1,
		Auto,
		Texas,
		Washington,
		California,
		Amsterdam,
		London,
		Frankfurt,
		Milan,
		Singapore,
		Australia,
		Stockholm,
		SanPaulo,
		Paris,
		Moscow,
		Auckland,
		Japan,
		Canada,
		SouthAfrica,
		Hongkong
	}

	public class GatewayComboBoxEntry
	{
		private Element element_0;

		private readonly long long_0;

		private readonly Memory memory_0;

		private PerFrameCachedValue<Struct166> perFrameCachedValue_0;

		private static GatewayComboBoxEntry gatewayComboBoxEntry_0;

		public bool IsVisible => true;

		public string Name => null;

		public string Ping => null;

		public float DeltaYMax => 0f;

		public float DeltaYMin => 0f;

		public float CellHeight => 0f;

		public float CellWidth => 0f;

		public Vector2i ClickPosition => (Vector2i)(object)null;

		public GatewayComboBoxEntry(long address, Memory m, Element element)
		{
		}

		[SpecialName]
		private Struct166 method_0()
		{
			return (Struct166)(object)null;
		}

		private Struct166 method_1()
		{
			return (Struct166)(object)null;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static GatewayComboBoxEntry smethod_1()
		{
			return null;
		}

		static GatewayComboBoxEntry()
		{
			Class200.smethod_34();
		}
	}

	private static GatewayComboBoxElement gatewayComboBoxElement_0;

	public string CurrentSelectedGateway => null;

	internal static bool smethod_13()
	{
		return true;
	}

	internal static GatewayComboBoxElement smethod_14()
	{
		return null;
	}

	static GatewayComboBoxElement()
	{
		Class200.smethod_34();
	}
}
