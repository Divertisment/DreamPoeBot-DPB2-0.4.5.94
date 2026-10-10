using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Bot;
using DreamPoeBot.Loki.Common;
using log4net;
using ns0;
using SharpDX;

namespace DreamPoeBot.BotFramework;

public static class MouseManager
{
	public delegate void MouseMoverDelegate(Vector2i destination, Vector2i normalizedDestination, Vector2i currentPosition);

	private enum Enum19
	{
		None = 0,
		Left = 1,
		Top = 3,
		Bottom = 4
	}

	private class Class182
	{
		[CompilerGenerated]
		private Vector2i vector2i_0;

		[CompilerGenerated]
		private int int_0;

		internal static Class182 class182_0;

		public Vector2i Pos
		{
			[CompilerGenerated]
			get
			{
				return (Vector2i)(object)null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int Delay
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

		public Class182(int int_1, int int_2, int int_3)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class182 smethod_1()
		{
			return null;
		}

		static Class182()
		{
			Class200.smethod_34();
		}
	}

	private static readonly ILog ilog_0;

	public static MouseMoverDelegate ThisMouseMoverDelegate;

	private static int int_0;

	[CompilerGenerated]
	private static int int_1;

	[CompilerGenerated]
	private static int int_2;

	private static Stopwatch stopwatch_0;

	private static readonly double double_0;

	private static readonly double double_1;

	private static readonly double double_2;

	public static bool DebugCursor;

	[CompilerGenerated]
	private static bool bool_0;

	[CompilerGenerated]
	private static IMouseHandler imouseHandler_0;

	private static Thread thread_0;

	private static volatile bool bool_1;

	private static volatile float float_0;

	private static volatile float float_1;

	private static volatile float float_2;

	private static volatile string string_0;

	private static MouseManager mouseManager_0;

	public static int MouseActionDelayMs
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static bool LogEvents
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static IMouseHandler Instance
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

	[SpecialName]
	[CompilerGenerated]
	private static int smethod_0()
	{
		return 0;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void smethod_1(int int_3)
	{
	}

	[SpecialName]
	[CompilerGenerated]
	private static int smethod_2()
	{
		return 0;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void smethod_3(int int_3)
	{
	}

	private static Vector2i smethod_4(int int_3, int int_4)
	{
		return (Vector2i)(object)null;
	}

	private static void smethod_5(int int_3, int int_4, bool bool_2 = true)
	{
	}

	public static Vector2i NormalizePosition(Vector2i position)
	{
		return (Vector2i)(object)null;
	}

	internal static Vector2i smethod_6(Vector2i vector2i_0, RectangleF rectangleF_0)
	{
		return (Vector2i)(object)null;
	}

	private static bool smethod_7(DreamPoeBot.Common.Vector2 vector2_0, DreamPoeBot.Common.Vector2 vector2_1, DreamPoeBot.Common.Vector2 vector2_2, DreamPoeBot.Common.Vector2 vector2_3, out DreamPoeBot.Common.Vector2 vector2_4)
	{
		return true;
	}

	private static double smethod_8(double double_3, double double_4)
	{
		return 0.0;
	}

	private static void smethod_9(Vector2i vector2i_0, double double_3 = 1.0)
	{
	}

	internal static void smethod_10(string string_1, int int_3, int int_4)
	{
	}

	internal static void smethod_11(string string_1, DreamPoeBot.Common.Vector3 vector3_0, bool bool_2 = true)
	{
	}

	internal static void smethod_12(string string_1, int int_3, int int_4, bool bool_2 = true)
	{
	}

	public static void PostMouseMovement(int x, int y, bool sleep = true)
	{
	}

	public static Vector2i GetMousePosition()
	{
		return (Vector2i)(object)null;
	}

	public static void SetMouseHookPosition(Vector2i pos)
	{
	}

	public static void ResetMousePosition()
	{
	}

	public static void SetMousePos(string reason, Vector2i destination, bool actualymove = true)
	{
	}

	public static void SetMousePos(string reason, DreamPoeBot.Common.Vector2 destination, bool actualymove = true)
	{
	}

	private static void smethod_13(string string_1, DreamPoeBot.Common.Vector2 vector2_0, int int_3, int int_4)
	{
	}

	public static void SetMousePos(string reason, DreamPoeBot.Common.Vector3 destination, bool actualymove = true)
	{
	}

	public static void SetMousePosition(int posX, int posY, bool sleep = true)
	{
	}

	public static void SetMousePosition(Vector2i pos, bool useRandomPos = true)
	{
	}

	public static void SetMousePosition(DreamPoeBot.Common.Vector2 pos, bool sleep = true)
	{
	}

	public static void ClickLMB(int cx = 0, int cy = 0)
	{
	}

	internal static bool smethod_14(int int_3, int int_4, Func<bool> func_0, bool bool_2 = false)
	{
		return true;
	}

	public static void smethod_15(int cx, int cy)
	{
	}

	public static void PressLMB(int cx, int cy)
	{
	}

	public static void smethod_16(int cx, int cy)
	{
	}

	public static void ClickRMB(int cx, int cy)
	{
	}

	public static void smethod_17(int cx, int cy)
	{
	}

	public static void PressRMB(int cx, int cy)
	{
	}

	public static void smethod_18(int cx, int cy)
	{
	}

	public static void ClickMMB(int cx, int cy)
	{
	}

	public static void smethod_19(int cx, int cy)
	{
	}

	public static void PressMMB(int cx, int cy)
	{
	}

	public static void smethod_20(int cx, int cy)
	{
	}

	public static void ScrollMouseDown(int clicks = 1, int cx = 0, int cy = 0)
	{
	}

	public static void ScrollMouseUp(int clicks = 1, int cx = 0, int cy = 0)
	{
	}

	public static void ClickXB1(int cx, int cy)
	{
	}

	public static void smethod_21(int cx, int cy)
	{
	}

	public static void PressXB1(int cx, int cy)
	{
	}

	public static void smethod_22(int cx, int cy)
	{
	}

	public static void ClickXB2(int cx, int cy)
	{
	}

	public static void smethod_23(int cx, int cy)
	{
	}

	public static void PressXB2(int cx, int cy)
	{
	}

	public static void smethod_24(int cx, int cy)
	{
	}

	private static void smethod_25()
	{
	}

	static MouseManager()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
		ThisMouseMoverDelegate = null;
		int_0 = 50;
		stopwatch_0 = Stopwatch.StartNew();
		double_0 = Math.Sqrt(2.0);
		double_1 = Math.Sqrt(3.0);
		double_2 = Math.Sqrt(5.0);
		DebugCursor = false;
		bool_1 = false;
		float_0 = 0f;
		float_1 = 0f;
		float_2 = 0f;
	}

	internal static bool smethod_26()
	{
		return true;
	}

	internal static MouseManager smethod_27()
	{
		return null;
	}
}
