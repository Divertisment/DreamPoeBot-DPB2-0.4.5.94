using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Common;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.RemoteMemoryObjects;

public class DiagnosticElementNew
{
	[StructLayout(LayoutKind.Explicit, Size = 5144)]
	[UnsafeValueType]
	public struct RowGraphData
	{
		[FieldOffset(0)]
		public unsafe fixed float data[1280];

		[FieldOffset(5128)]
		public long OldestIndex;

		[FieldOffset(5136)]
		public long Count;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct39
	{
		public Struct40 struct40_0;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct40
	{
		public float float_0;

		public float float_1;

		public float float_2;

		public float float_3;

		public float float_4;

		public float float_5;

		public float float_6;

		public float float_7;

		public float float_8;

		public float float_9;

		public float float_10;

		public float float_11;

		public float float_12;

		public float float_13;

		public float float_14;

		public float float_15;

		public float float_16;
	}

	private Memory memory_0;

	private static readonly ILog ilog_0;

	private static long long_0;

	internal static DiagnosticElementNew diagnosticElementNew_0;

	public List<float> LatencyValues => null;

	public List<float> FrameTimeValues => null;

	public List<float> FPSValues => null;

	private RowGraphData method_0()
	{
		return (RowGraphData)(object)null;
	}

	static DiagnosticElementNew()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static DiagnosticElementNew smethod_1()
	{
		return null;
	}
}
