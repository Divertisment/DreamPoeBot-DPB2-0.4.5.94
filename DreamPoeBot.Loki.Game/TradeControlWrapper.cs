using ns0;

namespace DreamPoeBot.Loki.Game;

public class TradeControlWrapper : RemoteMemoryObject
{
	private TradeControlType tradeControlType_0;

	internal readonly InventoryControlWrapper inventoryControlWrapper_0;

	internal readonly InventoryControlWrapper inventoryControlWrapper_1;

	internal static TradeControlWrapper tradeControlWrapper_0;

	public string AcceptButtonText => null;

	public bool IsAcceptButtonEnabled => true;

	public string ConfirmLabelText => null;

	public InventoryControlWrapper InventoryControl_OtherOffer => null;

	public InventoryControlWrapper InventoryControl_YourOffer => null;

	public bool IsConfirmLabelVisible => true;

	public bool OtherAcceptedTheOffert => true;

	public bool MeAcceptedTheOffert => true;

	public string OtherName => null;

	public TradeControlWrapper()
	{
	}

	public TradeControlWrapper(long control, TradeControlType type)
	{
	}

	public TradeResult Accept(bool actuallyAccept = true)
	{
		return (TradeResult)(object)null;
	}

	public TradeResult Cancel(bool actuallyCancel = true)
	{
		return (TradeResult)(object)null;
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static TradeControlWrapper smethod_3()
	{
		return null;
	}

	static TradeControlWrapper()
	{
		Class200.smethod_34();
	}
}
