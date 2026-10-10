using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Common;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.Game.Utilities;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class Flask : Component
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 64)]
	private struct Struct202
	{
		private Struct14 struct14_0;

		private NativeVector nativeVector_0;

		public long long_0;

		public long long_1;

		public long long_2;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct Struct203
	{
		private long long_0;

		private long long_1;

		public long long_2;

		public long long_3;

		public int int_0;

		public short short_0;

		public short short_1;

		private long long_4;

		private long long_5;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 80)]
	private struct Struct204
	{
		public long long_0;

		private long long_1;

		public long Name;

		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		private int int_4;

		public long long_2;

		public long long_3;

		public int int_5;

		public long long_4;

		public long long_5;
	}

	private static readonly ILog ilog_0;

	private LocalStats localStats_0;

	private PerFrameCachedValue<Struct202> perFrameCachedValue_0;

	private PerFrameCachedValue<Struct203> perFrameCachedValue_1;

	private PerFrameCachedValue<Struct204> perFrameCachedValue_2;

	private Quality quality_0;

	private static Flask flask_0;

	public bool IsInstantRecovery => true;

	public int LifeRecover => 0;

	public int ManaRecover => 0;

	public TimeSpan RecoveryTime => (TimeSpan)(object)null;

	[SpecialName]
	private LocalStats method_2()
	{
		return null;
	}

	[SpecialName]
	private Quality method_3()
	{
		return null;
	}

	[SpecialName]
	private Struct202 method_4()
	{
		return (Struct202)(object)null;
	}

	[SpecialName]
	private Struct203 method_5()
	{
		return (Struct203)(object)null;
	}

	[SpecialName]
	private Struct204 method_6()
	{
		return (Struct204)(object)null;
	}

	private Struct202 method_7()
	{
		return (Struct202)(object)null;
	}

	private Struct203 method_8()
	{
		return (Struct203)(object)null;
	}

	private Struct204 method_9()
	{
		return (Struct204)(object)null;
	}

	static Flask()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static Flask smethod_5()
	{
		return null;
	}
}
