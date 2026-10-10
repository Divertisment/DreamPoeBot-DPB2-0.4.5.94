using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Common;
using DreamPoeBot.Loki.Game.Std;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Game;

public class TabControlWrapper : RemoteMemoryObject
{
	internal class Class87
	{
		[CompilerGenerated]
		private readonly long long_0;

		[CompilerGenerated]
		private readonly long dXgAmUtiqa7;

		[CompilerGenerated]
		private readonly string string_0;

		internal static Class87 class87_0;

		public string Name
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[SpecialName]
		[CompilerGenerated]
		public long method_0()
		{
			return 0L;
		}

		[SpecialName]
		[CompilerGenerated]
		public long method_1()
		{
			return 0L;
		}

		internal Class87(Struct78 struct78_0)
		{
		}

		public new virtual bool Equals(object object_0)
		{
			return true;
		}

		public bool method_2(Class87 class87_1)
		{
			return true;
		}

		public new virtual int GetHashCode()
		{
			return 0;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class87 smethod_1()
		{
			return null;
		}

		static Class87()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct78
	{
		public readonly GStruct2 gstruct2_0;

		public readonly long long_0;

		public readonly long long_1;

		public readonly long long_2;

		public readonly long long_3;

		public readonly long long_4;

		public readonly long long_5;

		public readonly long long_6;

		public readonly long long_7;

		public readonly long long_8;

		public readonly long long_9;

		public readonly long plaAmhbuReQ;

		public readonly long long_10;

		public readonly long long_11;

		public readonly long long_12;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct TabControlStructure
	{
		private readonly long long_0;

		private readonly long long_1;

		private readonly long long_2;

		private readonly long long_3;

		private readonly long long_4;

		private readonly long long_5;

		private readonly long long_6;

		private readonly long long_7;

		private readonly long long_8;

		private readonly long long_9;

		private readonly long long_10;

		private readonly long long_11;

		public readonly NativeVector List_0;

		public readonly int CurrentTabIndex;

		public readonly byte byte_0;

		private readonly byte byte_1;

		private readonly byte byte_2;

		private readonly byte byte_3;

		public readonly int int_1;

		public readonly byte byte_4;

		private readonly byte byte_5;

		private readonly byte byte_6;

		private readonly byte byte_7;

		private static object object_0;

		internal TabControlStructure(NativeVector tabs, int selected, byte engaged, int value, byte flag)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static object smethod_1()
		{
			return null;
		}

		static TabControlStructure()
		{
			Class200.smethod_34();
		}
	}

	private static readonly ILog ilog_0;

	[CompilerGenerated]
	private TabControlType tabControlType_0;

	private static TabControlWrapper tabControlWrapper_0;

	public int CurrentTabIndex => 0;

	public string CurrentTabName => null;

	public bool IsOnFirstTab => true;

	public bool IsOnLastTab => true;

	public int LastTabIndex => 0;

	public List<string> TabNames => null;

	public bool IsTabsMenuVisible => true;

	public Element TabListButton => null;

	public bool IsTabListButtonVisible => true;

	public List<Element> UpperTabsContainer => null;

	public float UpperTabContainerXOffset => 0f;

	public Element RightTabsContainerElement => null;

	public float RightTabsContainerYOffset => 0f;

	public float RightTabsContainerHeight => 0f;

	public Element RightTabsContainerScrollUp => null;

	public Element RightTabsContainerScrollDown => null;

	public bool IsRightTabsContainerElementVisible => true;

	public List<Element> RightButtonContainer => null;

	public TabControlStructure _tabControlStructure => (TabControlStructure)(object)null;

	[SpecialName]
	[CompilerGenerated]
	private TabControlType method_0()
	{
		return (TabControlType)(object)null;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_1(TabControlType tabControlType_1)
	{
	}

	public TabControlWrapper(TabControlType type)
	{
	}

	internal void method_2(Vector2i vector2i_0)
	{
	}

	[SpecialName]
	private Element method_3()
	{
		return null;
	}

	internal TabControlWrapper(long control, TabControlType type)
	{
	}

	public bool IsTabVisible(string name)
	{
		return true;
	}

	public bool IsTabVisible(int index)
	{
		return true;
	}

	public SwitchToTabResult NextTabKeyboard()
	{
		return (SwitchToTabResult)(object)null;
	}

	public SwitchToTabResult PreviousTabKeyboard()
	{
		return (SwitchToTabResult)(object)null;
	}

	public SwitchToTabResult SwitchToTabKeyboard(int index)
	{
		return (SwitchToTabResult)(object)null;
	}

	public SwitchToTabResult SwitchToTabKeyboard(string name)
	{
		return (SwitchToTabResult)(object)null;
	}

	public SwitchToTabResult SwitchToTabMouse(int index)
	{
		return (SwitchToTabResult)(object)null;
	}

	public SwitchToTabResult SwitchToTabMouse(string name)
	{
		return (SwitchToTabResult)(object)null;
	}

	public OpenPremiumStashSettingResult OpenPremiumStashSetting(string name)
	{
		return (OpenPremiumStashSettingResult)(object)null;
	}

	public int GetTabIndexByName(string name)
	{
		return 0;
	}

	public string GetTabNameByIndex(int index)
	{
		return null;
	}

	private bool method_4(InventoryTabFlags inventoryTabFlags_0)
	{
		return true;
	}

	private bool IsHidden(InventoryTabFlags flag)
	{
		return true;
	}

	private void method_5(Element element_0)
	{
	}

	private SwitchToTabResult method_6(string string_0)
	{
		return (SwitchToTabResult)(object)null;
	}

	private int method_7(Class87 class87_0)
	{
		return 0;
	}

	private Class87 method_8(int int_0)
	{
		return null;
	}

	private Class87 method_9(string string_0)
	{
		return null;
	}

	[SpecialName]
	internal byte method_10()
	{
		return 0;
	}

	[SpecialName]
	internal int method_11()
	{
		return 0;
	}

	[SpecialName]
	internal byte method_12()
	{
		return 0;
	}

	[SpecialName]
	internal List<Struct78> method_13()
	{
		return null;
	}

	[SpecialName]
	private List<Class87> method_14()
	{
		return null;
	}

	static TabControlWrapper()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static TabControlWrapper smethod_3()
	{
		return null;
	}
}
