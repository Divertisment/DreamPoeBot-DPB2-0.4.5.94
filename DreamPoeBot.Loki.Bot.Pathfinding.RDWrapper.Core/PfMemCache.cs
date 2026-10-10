using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using DreamPoeBot.Loki.Bot.Pathfinding.RDWrapper.Types;
using DreamPoeBot.Loki.Game;
using ns0;

namespace DreamPoeBot.Loki.Bot.Pathfinding.RDWrapper.Core;

public static class PfMemCache
{
	private sealed class Class153
	{
		public long long_0;

		public Lazy<Pathfinder> lazy_0;

		private static Class153 class153_0;

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class153 smethod_1()
		{
			return null;
		}

		static Class153()
		{
			Class200.smethod_34();
		}
	}

	private static readonly ConcurrentDictionary<uint, Class153> concurrentDictionary_0;

	private static readonly object object_0;

	private static readonly TimeSpan timeSpan_0;

	private static volatile bool bool_0;

	private static Timer timer_0;

	[CompilerGenerated]
	private static TimeSpan timeSpan_1;

	internal static PfMemCache pfMemCache_0;

	public static TimeSpan EntryTtl
	{
		[CompilerGenerated]
		get
		{
			return (TimeSpan)(object)null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static void Initialize()
	{
	}

	public static Pathfinder GetOrCreateForAreaHash(CachedTerrainData ctd, RecastMeshSettings rms = null)
	{
		return null;
	}

	public static bool RemoveForAreaHash(uint areaHash)
	{
		return true;
	}

	public static void ClearAll()
	{
	}

	private static void smethod_0(uint? nullable_0 = null)
	{
	}

	private static List<Pathfinder> smethod_1(long long_0, uint? nullable_0 = null)
	{
		return null;
	}

	private static TimeSpan smethod_2(long long_0, long long_1)
	{
		return (TimeSpan)(object)null;
	}

	private static void smethod_3(IEnumerable<Pathfinder> ienumerable_0)
	{
	}

	private static void smethod_4(Pathfinder pathfinder_0)
	{
	}

	static PfMemCache()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		concurrentDictionary_0 = new ConcurrentDictionary<uint, Class153>();
		object_0 = new object();
		timeSpan_0 = TimeSpan.FromMinutes(1.0);
		timeSpan_1 = TimeSpan.FromMinutes(15.0);
	}

	internal static bool smethod_5()
	{
		return true;
	}

	internal static PfMemCache smethod_6()
	{
		return null;
	}
}
