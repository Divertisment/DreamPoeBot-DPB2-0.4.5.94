using System.Collections.Generic;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Game;
using ns0;

namespace DreamPoeBot.Loki.Elements;

public class NotificationHudElement : Element
{
	public class NotificationInfo
	{
		private NotificationHudElement notificationHudElement_0;

		private Element element_0;

		private LokiPoe.InGameState.NotificationType? nullable_0;

		private string string_0;

		internal static NotificationInfo notificationInfo_0;

		public bool IsVisible => true;

		public string Type => null;

		public string AccountName => null;

		public string CharName => null;

		public string CharLevel => null;

		public string CharArea => null;

		public Vector2i AcceptPos => (Vector2i)(object)null;

		public Vector2i DeclinePos => (Vector2i)(object)null;

		public string GuildName => null;

		public LokiPoe.InGameState.NotificationType NotificationTypeEnum => (LokiPoe.InGameState.NotificationType)(object)null;

		public NotificationInfo(NotificationHudElement _hud, Element ele)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static NotificationInfo smethod_1()
		{
			return null;
		}

		static NotificationInfo()
		{
			Class200.smethod_34();
		}
	}

	private static NotificationHudElement notificationHudElement_0;

	public List<NotificationInfo> NotificationList => null;

	private string method_29(Element element_2)
	{
		return null;
	}

	private string method_30(Element element_2)
	{
		return null;
	}

	private string method_31(Element element_2)
	{
		return null;
	}

	private string method_32(Element element_2)
	{
		return null;
	}

	private string method_33(Element element_2)
	{
		return null;
	}

	public Element AcceptElement(Element element)
	{
		return null;
	}

	private Vector2i method_34(Element element_2)
	{
		return (Vector2i)(object)null;
	}

	public Element DeclineElement(Element element)
	{
		return null;
	}

	private Vector2i method_35(Element element_2)
	{
		return (Vector2i)(object)null;
	}

	internal static bool smethod_11()
	{
		return true;
	}

	internal static NotificationHudElement smethod_12()
	{
		return null;
	}

	static NotificationHudElement()
	{
		Class200.smethod_34();
	}
}
