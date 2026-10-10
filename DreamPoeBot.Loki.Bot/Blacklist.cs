using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Common;
using DreamPoeBot.Loki.Game.Objects;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Bot;

public static class Blacklist
{
	private class Class128
	{
		public int int_0;

		public DateTime dateTime_0;

		private static Class128 class128_0;

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class128 smethod_1()
		{
			return null;
		}

		static Class128()
		{
			Class200.smethod_34();
		}
	}

	private static readonly ILog ilog_0;

	private static readonly Dictionary<uint, Dictionary<int, Class128>> dictionary_0;

	private static Blacklist blacklist_0;

	public static IEnumerable<int> Ids => null;

	public static IEnumerable<NetworkObject> Objects => null;

	public static void Reset()
	{
	}

	[SpecialName]
	private static Dictionary<int, Class128> smethod_0()
	{
		return null;
	}

	public static void Add(int id, TimeSpan duration, string reason = "")
	{
	}

	public static void AddWithNoLog(int id, TimeSpan duration)
	{
	}

	public static bool Remove(int id)
	{
		return true;
	}

	public static bool Contains(int id)
	{
		return true;
	}

	public static bool Contains(NetworkObject entity)
	{
		return true;
	}

	public static void Clear()
	{
	}

	static Blacklist()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
		dictionary_0 = new Dictionary<uint, Dictionary<int, Class128>>();
	}

	internal static bool smethod_1()
	{
		return true;
	}

	internal static Blacklist smethod_2()
	{
		return null;
	}
}
