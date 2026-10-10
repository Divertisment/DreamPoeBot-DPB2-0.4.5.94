using System.Collections.Generic;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game;
using ns0;

namespace DreamPoeBot.Loki.Elements;

public class CurrencyExchangeElement : Element
{
	public class CurrencySelectionElement : Element
	{
		private static CurrencySelectionElement currencySelectionElement_0;

		public Element SearchBoxElement => null;

		public Element ClearSearchBoxButtonElement => null;

		public Element ListOfCatecoryElement => null;

		public Element CurrencyScrollBarElement => null;

		public Element CurrencyPannelElement => null;

		public List<LokiPoe.InGameState.CurrencyExchangeUi.CurrencyEntry> CurrencyEntryList => null;

		internal static bool smethod_11()
		{
			return true;
		}

		internal static CurrencySelectionElement smethod_12()
		{
			return null;
		}

		static CurrencySelectionElement()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct StructPoe2ExchangeOrder
	{
		[FieldOffset(44)]
		public uint SellingBaseItemTypeHash32;

		[FieldOffset(48)]
		public uint BuyingBaseItemTypeHash32;

		[FieldOffset(52)]
		public int SellingTotal;

		[FieldOffset(56)]
		public int SellingRemaining;

		[FieldOffset(60)]
		public int Bought;

		[FieldOffset(64)]
		public uint OrderTaxGold;

		[FieldOffset(72)]
		public short SellingQuantity;

		[FieldOffset(74)]
		public short BuyingQuantity;
	}

	private static CurrencyExchangeElement currencyExchangeElement_0;

	public Element IWantElement => null;

	public LokiPoe.InGameState.CurrencyExchangeUi.CurrencyEntry IWantSelected => null;

	public Element NumberIWantElement => null;

	public Element IHaveElement => null;

	public LokiPoe.InGameState.CurrencyExchangeUi.CurrencyEntry IHaveSelected => null;

	public Element NumberIHaveElement => null;

	public Element CurrentRatioElement => null;

	public Element PlaceOrderElement => null;

	public Element GoldElement => null;

	public Element MarketRatioElement => null;

	public List<Element> OrdersElements => null;

	public CurrencySelectionElement CurrencySelectionPannelElement => null;

	internal static bool smethod_11()
	{
		return true;
	}

	internal static CurrencyExchangeElement smethod_12()
	{
		return null;
	}

	static CurrencyExchangeElement()
	{
		Class200.smethod_34();
	}
}
