using System.Runtime.InteropServices;
using ns0;

namespace DreamPoeBot.Loki.RemoteMemoryObjects;

public class AtlasSkillGraphs : RemoteMemoryObject
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct33
	{
		public long long_0;

		public long Metadata;

		public long long_1;

		public int int_0;

		public int int_1;

		public long long_2;
	}

	internal static AtlasSkillGraphs atlasSkillGraphs_0;

	internal static bool smethod_2()
	{
		return true;
	}

	internal static AtlasSkillGraphs smethod_3()
	{
		return null;
	}

	static AtlasSkillGraphs()
	{
		Class200.smethod_34();
	}
}
