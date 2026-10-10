using System.Collections.Generic;
using ns0;

namespace DreamPoeBot.Loki.Game.GameData;

public static class BITC
{
	public static Dictionary<string, HashSet<MetadataFlags>> dictionary_0;

	private static BITC bitc_0;

	public static HashSet<MetadataFlags> GetFlagsForMetadata(string metadata)
	{
		return null;
	}

	public static bool HasMetadataFlag(string metadata, MetadataFlags token)
	{
		return true;
	}

	static BITC()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		dictionary_0 = new Dictionary<string, HashSet<MetadataFlags>>();
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static BITC smethod_1()
	{
		return null;
	}
}
