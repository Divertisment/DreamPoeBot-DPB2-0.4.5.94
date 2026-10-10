using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Common;
using DreamPoeBot.Loki.Game;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.Game.Utilities;
using log4net;
using ns0;
using SharpDX;

namespace DreamPoeBot.Loki;

public class Element : RemoteMemoryObject
{
	[Flags]
	public enum ElementFlags : uint
	{
		[Obsolete("Scrollable semantics are not verified for the current native contract.")]
		Scrollable = 0x400u,
		IsVisibleLocal = 0x800u,
		IsActive = 0x2000u
	}

	[StructLayout(LayoutKind.Sequential, Size = 1)]
	internal struct Struct20
	{
	}

	[StructLayout(LayoutKind.Explicit, Size = 376)]
	internal struct Struct21
	{
		[FieldOffset(0)]
		public long long_0;

		[FieldOffset(8)]
		public long eJsAuurkjaj;

		[FieldOffset(16)]
		public NativeVector nativeVector_0;

		[FieldOffset(72)]
		public NativeVector nativeVector_1;

		[FieldOffset(136)]
		public int int_0;

		[FieldOffset(152)]
		public GStruct2 gstruct2_0;

		[FieldOffset(184)]
		public long long_1;

		[FieldOffset(256)]
		public DreamPoeBot.Common.Vector2 vector2_0;

		[FieldOffset(264)]
		public float float_0;

		[FieldOffset(268)]
		public float float_1;

		[FieldOffset(280)]
		public float float_2;

		[FieldOffset(288)]
		public NativeVector nativeVector_2;

		[FieldOffset(360)]
		public ElementFlags elementFlags_0;

		[FieldOffset(364)]
		public uint uint_0;

		[FieldOffset(375)]
		public byte byte_0;

		internal static object object_0;

		public bool IsActive => true;

		[SpecialName]
		public bool method_0()
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static object smethod_1()
		{
			return null;
		}

		static Struct21()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	[Obsolete("Legacy ABI only. Do not bulk-read this type from a native Element.")]
	public struct StructElement2
	{
		[FieldOffset(0)]
		public long vTable;

		[FieldOffset(8)]
		public long self_Pointer;

		[FieldOffset(16)]
		public NativeVector Vector_child1;

		[FieldOffset(72)]
		public NativeVector Vector_child2;

		[FieldOffset(136)]
		public int int0_ControlType;

		[FieldOffset(152)]
		public GStruct2 label;

		[FieldOffset(184)]
		public long parent;

		[FieldOffset(256)]
		public DreamPoeBot.Common.Vector2 position;

		[FieldOffset(264)]
		public float deltaX;

		[FieldOffset(268)]
		public float deltaY;

		[FieldOffset(280)]
		public float elementZoom;

		[FieldOffset(288)]
		public NativeVector Vector_tooltips;

		[FieldOffset(360)]
		public ElementFlags elementFlags;

		[FieldOffset(375)]
		public byte isEnable;

		[FieldOffset(624)]
		public DreamPoeBot.Common.Vector2 Size;

		[FieldOffset(848)]
		public bool isHighlighted;

		[FieldOffset(1216)]
		public GStruct2 ElementText;

		internal static object object_0;

		public bool isVisibleLocal => true;

		public bool IsActive => true;

		internal static bool smethod_0()
		{
			return true;
		}

		internal static object smethod_1()
		{
			return null;
		}

		static StructElement2()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[Obsolete("Legacy layout is not a native Element contract.")]
	public struct StructElement
	{
		public long vTable;

		public int int0_ControlType;

		private int int_0;

		private long long_0;

		private long long_1;

		private long long_2;

		private long long_3;

		public NativeVector Vector_child1;

		private long long_4;

		private long long_5;

		private long long_6;

		private long long_7;

		public NativeVector Vector_child2;

		private long long_8;

		public NativeVector Vector_1;

		private long long_9;

		public float deltaX;

		public float deltaY;

		private long long_10;

		public long parentold;

		public DreamPoeBot.Common.Vector2 position;

		private long long_11;

		private long long_12;

		public float elementZoom;

		private int int_1;

		public long tooltip;

		private long long_13;

		private long long_14;

		private long long_15;

		private int int_2;

		public float Scale;

		private long long_16;

		private long long_17;

		private long long_18;

		public GStruct2 label;

		private long long_19;

		public long parent;

		private byte byte_0;

		public byte isVisibleLocal;

		private byte byte_1;

		private byte byte_2;

		private byte byte_3;

		public byte isEnable;

		private byte byte_4;

		private byte byte_5;

		private long long_20;

		private long long_21;

		private long long_22;

		private long long_23;

		private long long_24;

		private long long_25;

		private long long_26;

		private long long_27;

		public DreamPoeBot.Common.Vector2 Size;
	}

	[CompilerGenerated]
	private sealed class _003CWalk_003Ed__120 : IEnumerable<Element>, IEnumerable, IEnumerator<Element>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private Element _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public Element _003C_003E4__this;

		private Stack<Element> _003Cpending_003E5__2;

		private HashSet<long> _003Cseen_003E5__3;

		private Element _003Ccurrent_003E5__4;

		internal static _003CWalk_003Ed__120 _003CWalk_003Ed__120_0;

		Element IEnumerator<Element>.Current => null;

		object IEnumerator.Current => null;

		public _003CWalk_003Ed__120(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}

		IEnumerator<Element> IEnumerable<Element>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static _003CWalk_003Ed__120 smethod_1()
		{
			return null;
		}

		static _003CWalk_003Ed__120()
		{
			Class200.smethod_34();
		}
	}

	internal static int int_0;

	internal static int int_1;

	internal static int int_2;

	[Obsolete("Legacy offset adjustment; not a current native Element contract.")]
	public const int OffsetBuffers = 0;

	private Memory memory_0;

	private long long_1;

	private PerFrameCachedValue<Struct21> perFrameCachedValue_0;

	private PerFrameCachedValue<string> perFrameCachedValue_1;

	private PerFrameCachedValue<(bool, DreamPoeBot.Common.Vector2)> perFrameCachedValue_2;

	private PerFrameCachedValue<(bool, GStruct2)> DuciJrFyjV;

	private PerFrameCachedValue<string> perFrameCachedValue_3;

	private PerFrameCachedValue<string> perFrameCachedValue_4;

	private PerFrameCachedValue<float> perFrameCachedValue_5;

	private PerFrameCachedValue<List<Element>> yIhivEpmDX;

	private PerFrameCachedValue<List<Element>> lPxiFmdOhG;

	private Element element_0;

	private static readonly ILog ilog_0;

	private static long long_2;

	private static long long_3;

	private static long long_4;

	internal static Element element_1;

	public override bool IsValid => true;

	public long vTable => 0L;

	public int ControlType => 0;

	public GuiControlType GuiControlType => (GuiControlType)(object)null;

	public long ChildCount => 0L;

	public string IdLabel => null;

	public Element Parent => null;

	public float X => 0f;

	public float Y => 0f;

	public float DeltaX => 0f;

	public float DeltaY => 0f;

	public long XAddress => 0L;

	public long YAddress => 0L;

	public long zoomAddress => 0L;

	public float ElementZoom => 0f;

	public float Scale => 0f;

	public float Width => 0f;

	public float Height => 0f;

	public string Text => null;

	public string Text2 => null;

	public bool IsEnable => true;

	public bool IsItemTransparent => true;

	public bool IsVisibleLocal => true;

	public bool IsVisible => true;

	public Element Root => null;

	public List<Element> Children => null;

	public List<Element> Tooltips => null;

	public Element Tooltip => null;

	private void method_0()
	{
	}

	private void method_1()
	{
	}

	[SpecialName]
	internal Struct21 method_2()
	{
		return (Struct21)(object)null;
	}

	private Struct21 method_3()
	{
		return (Struct21)(object)null;
	}

	private static bool smethod_2(long long_5)
	{
		return true;
	}

	private string method_4()
	{
		return null;
	}

	public bool TryGetSize(out DreamPoeBot.Common.Vector2 size)
	{
		return true;
	}

	private (bool, DreamPoeBot.Common.Vector2) method_5()
	{
		return ((bool, DreamPoeBot.Common.Vector2))null;
	}

	private DreamPoeBot.Common.Vector2 method_6()
	{
		return (DreamPoeBot.Common.Vector2)(object)null;
	}

	public bool TryGetText(out string text)
	{
		return true;
	}

	internal bool method_7(out string string_0, out ulong ulong_0)
	{
		return true;
	}

	private (bool, GStruct2) method_8(int int_3)
	{
		return ((bool, GStruct2))null;
	}

	internal ulong method_9()
	{
		return 0uL;
	}

	private string method_10()
	{
		return null;
	}

	private string method_11()
	{
		return null;
	}

	private string method_12(GStruct2 gstruct2_0, int int_3)
	{
		return null;
	}

	private void method_13(string string_0, int int_3)
	{
	}

	private List<Element> method_14()
	{
		return null;
	}

	protected List<T> GetChildren<T>() where T : Element, new()
	{
		return null;
	}

	private bool method_15(bool bool_0, out NativeVector nativeVector_0, out int int_3)
	{
		return true;
	}

	private List<T> method_16<T>(bool bool_0) where T : Element, new()
	{
		return null;
	}

	public Element GetChildAtIndex(int index)
	{
		return null;
	}

	public Element GetChildFromIndices(params int[] indices)
	{
		return null;
	}

	public DreamPoeBot.Common.Vector2 GetParentPos()
	{
		return (DreamPoeBot.Common.Vector2)(object)null;
	}

	public virtual RectangleF GetClientRect()
	{
		return (RectangleF)(object)null;
	}

	public Vector2i CenterClickLocation()
	{
		return (Vector2i)(object)null;
	}

	private Vector2i method_17(double double_0, double double_1)
	{
		return (Vector2i)(object)null;
	}

	internal Vector2i method_18(float float_0 = 0.2f, float float_1 = 0.8f)
	{
		return (Vector2i)(object)null;
	}

	public bool IsInFOV(float pct)
	{
		return true;
	}

	public void WriteVisibleFlag(int flag)
	{
	}

	public void ToggleVisibility()
	{
	}

	public void SetZoom(float zoom)
	{
	}

	internal void SetDeltaXY(DreamPoeBot.Common.Vector2 delta)
	{
	}

	private bool method_19(string string_0, out Struct21 struct21_0)
	{
		return true;
	}

	private void method_20(string string_0, int int_3, bool bool_0)
	{
	}

	private void method_21(string string_0, int int_3, string string_1)
	{
	}

	[IteratorStateMachine(typeof(_003CWalk_003Ed__120))]
	private IEnumerable<Element> method_22()
	{
		return null;
	}

	public Element FindElementWithTooltipText(string text, bool ignoreVisibility = false)
	{
		return null;
	}

	public Element FindTextInElementChildrens(string text)
	{
		return null;
	}

	public List<Element> FindElementsWithTextInElementChildrens(string text, ref List<Element> refElementList)
	{
		return null;
	}

	public Element FindIdLabelInElementChildrens(string text)
	{
		return null;
	}

	internal static void smethod_3(long long_5, string string_0, ref List<long> list_0)
	{
	}

	internal static long smethod_4(long long_5, string string_0)
	{
		return 0L;
	}

	internal static long smethod_5(long long_5, string string_0)
	{
		return 0L;
	}

	internal static string smethod_6(long long_5)
	{
		return null;
	}

	internal static long smethod_7(long long_5)
	{
		return 0L;
	}

	internal static string smethod_8(long long_5)
	{
		return null;
	}

	internal List<string> method_23()
	{
		return null;
	}

	internal void method_24(Element element_2, ref StringBuilder stringBuilder_0)
	{
	}

	public string Dump()
	{
		return null;
	}

	static Element()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		int_0 = 1912;
		int_1 = 768;
		int_2 = 952;
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	[CompilerGenerated]
	private float method_25()
	{
		return 0f;
	}

	[CompilerGenerated]
	private (bool, GStruct2) method_26()
	{
		return ((bool, GStruct2))null;
	}

	[CompilerGenerated]
	private (bool, GStruct2) method_27()
	{
		return ((bool, GStruct2))null;
	}

	[CompilerGenerated]
	private List<Element> method_28()
	{
		return null;
	}

	internal static bool smethod_9()
	{
		return true;
	}

	internal static Element smethod_10()
	{
		return null;
	}
}
