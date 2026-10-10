namespace DreamPoeBot.Loki.Game;

public enum GetItemGoldSellPriceResult
{
	None,
	GetItemByIdFailed,
	ItemIsDivinationCardType,
	CouldNotFindControlForItem,
	NoTooltip,
	CostTextNotFound,
	ErrorParsingText,
	InternalError1,
	InternalError2,
	InternalError3,
	InternalError4
}
