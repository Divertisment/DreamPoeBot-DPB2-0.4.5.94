using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using ns0;

namespace DreamPoeBot.Loki.FilesInMemory;

public class PantheonSoulsDatFileWrapper
{
	public class PantheonSoulsDatFileHardcoded
	{
		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private int int_1;

		[CompilerGenerated]
		private int int_2;

		[CompilerGenerated]
		private int int_3;

		[CompilerGenerated]
		private int int_4;

		internal static PantheonSoulsDatFileHardcoded pantheonSoulsDatFileHardcoded_0;

		public int WorldAreaId
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int BaseItemTypeId
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int QuestFlagId
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int MonsterVarietyId
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int PantheonPannelLayoutKey
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public PantheonSoulsDatFileHardcoded(int worldAreaId, int baseItemTypeId, int questFlagId, int monsterVarietyId, int pantheonPannelLayoutKey)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static PantheonSoulsDatFileHardcoded smethod_1()
		{
			return null;
		}

		static PantheonSoulsDatFileHardcoded()
		{
			Class200.smethod_34();
		}
	}

	public class PantheonSoulsDatFileHardcodedJson
	{
		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private int int_1;

		[CompilerGenerated]
		private int int_2;

		[CompilerGenerated]
		private int int_3;

		[CompilerGenerated]
		private List<int> list_0;

		[CompilerGenerated]
		private int int_4;

		[CompilerGenerated]
		private string string_0;

		private static PantheonSoulsDatFileHardcodedJson pantheonSoulsDatFileHardcodedJson_0;

		public int _rid
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int WorldArea
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int CapturedVessel
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("QuestFlagUpgrade")]
		public int QuestFlag
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public List<int> CapturedMonster
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int PanelLayout
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string CapturedMonsterDescription
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static PantheonSoulsDatFileHardcodedJson smethod_1()
		{
			return null;
		}

		static PantheonSoulsDatFileHardcodedJson()
		{
			Class200.smethod_34();
		}
	}

	private static Dictionary<int, PantheonSoulsDatFileHardcoded> dictionary_0;

	private static PantheonSoulsDatFileWrapper pantheonSoulsDatFileWrapper_0;

	public Dictionary<int, PantheonSoulsDatFileHardcoded> Data => null;

	internal static bool smethod_0()
	{
		return true;
	}

	internal static PantheonSoulsDatFileWrapper smethod_1()
	{
		return null;
	}

	static PantheonSoulsDatFileWrapper()
	{
		Class200.smethod_34();
	}
}
