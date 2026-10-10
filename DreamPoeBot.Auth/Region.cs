using System.ComponentModel;

namespace DreamPoeBot.Auth;

public enum Region
{
	[Description("Auto (Recommended)")]
	BestLatency,
	[Description("Europe")]
	Europe,
	[Description("North America")]
	NorthAmerica,
	[Description("China")]
	China,
	[Description("Southeast Asia")]
	SoutheastAsia,
	[Description("Russia")]
	Russia
}
