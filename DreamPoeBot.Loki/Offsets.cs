using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Common;
using DreamPoeBot.Loki.Models;
using log4net;
using ns0;

namespace DreamPoeBot.Loki;

public class Offsets
{
	public static Offsets Regular;

	public static Offsets Steam;

	private static readonly Pattern pattern_0;

	private static readonly string string_0;

	private static readonly Pattern pattern_1;

	private static readonly string string_1;

	private static readonly string string_2;

	private static readonly Pattern pattern_2;

	private static readonly Pattern pattern_3;

	private static readonly Pattern pattern_4;

	private static readonly string string_3;

	private static readonly string string_4;

	private static readonly Pattern pattern_5;

	private static readonly string string_5;

	[CompilerGenerated]
	private long long_0;

	[CompilerGenerated]
	private string string_6;

	[CompilerGenerated]
	private long long_1;

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private int UhlgqTsyxJ;

	[CompilerGenerated]
	private long long_2;

	[CompilerGenerated]
	private long long_3;

	[CompilerGenerated]
	private byte[] byte_0;

	[CompilerGenerated]
	private byte[] byte_1;

	[CompilerGenerated]
	private long long_4;

	[CompilerGenerated]
	private long long_5;

	private static ILog Log;

	internal static Offsets offsets_0;

	public long Base
	{
		[CompilerGenerated]
		get
		{
			return 0L;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public string ExeName
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public long FileRoot
	{
		[CompilerGenerated]
		get
		{
			return 0L;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int IgsDelta
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

	public int IgsOffset
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

	public int IgsOffsetDelta => 0;

	public long GameStateOffset
	{
		[CompilerGenerated]
		get
		{
			return 0L;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public long DiagnosticElementOffset
	{
		[CompilerGenerated]
		get
		{
			return 0L;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public byte[] TerrainRotationHelper
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

	public byte[] TerrainRotationSelector
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

	public long GlobalUIScaleOffset
	{
		[CompilerGenerated]
		get
		{
			return 0L;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal long method_0()
	{
		return 0L;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_1(long long_6)
	{
	}

	internal void method_2(Memory memory_0)
	{
	}

	static Offsets()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		Regular = new Offsets
		{
			IgsOffset = 0,
			IgsDelta = 0,
			ExeName = Class200.smethod_20(11248)
		};
		Steam = new Offsets
		{
			IgsOffset = 40,
			IgsDelta = 0,
			ExeName = Class200.smethod_20(11282)
		};
		pattern_0 = new Pattern(new byte[16]
		{
			72, 137, 92, 0, 0, 87, 72, 131, 236, 32,
			232, 0, 0, 0, 0, 243
		}, Class200.smethod_20(11326));
		string_0 = Class200.smethod_20(11362);
		pattern_1 = new Pattern(new byte[31]
		{
			72, 131, 236, 56, 101, 72, 139, 4, 37, 88,
			0, 0, 0, 185, 16, 0, 0, 0, 72, 139,
			0, 139, 12, 1, 57, 13, 0, 0, 0, 0,
			15
		}, Class200.smethod_20(11460));
		string_1 = Class200.smethod_20(11526);
		string_2 = Class200.smethod_20(11666);
		pattern_2 = new Pattern(new byte[20]
		{
			72, 0, 0, 0, 0, 0, 0, 0, 65, 0,
			0, 0, 57, 0, 0, 0, 0, 0, 15, 142
		}, Class200.smethod_20(11710));
		pattern_3 = new Pattern(new byte[13]
		{
			255, 0, 0, 0, 0, 0, 232, 0, 0, 0,
			0, 255, 5
		}, Class200.smethod_20(11754));
		pattern_4 = new Pattern(new byte[12]
		{
			72, 139, 241, 51, 237, 72, 57, 45, 0, 0,
			0, 0
		}, Class200.smethod_20(11784));
		string_3 = Class200.smethod_20(11812);
		string_4 = Class200.smethod_20(12000);
		pattern_5 = new Pattern(new byte[11]
		{
			15, 182, 13, 0, 0, 0, 0, 58, 193, 116,
			37
		}, Class200.smethod_20(12086));
		string_5 = Class200.smethod_20(12112);
		Log = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static Offsets smethod_1()
	{
		return null;
	}
}
