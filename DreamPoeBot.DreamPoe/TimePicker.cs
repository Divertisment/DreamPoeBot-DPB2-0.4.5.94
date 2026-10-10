using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using DreamPoeBot.Loki.Common.Controls;
using ns0;

namespace DreamPoeBot.DreamPoe;

[TemplatePart(Name = "PART_IncreaseTime", Type = typeof(ButtonBase))]
[TemplatePart(Name = "PART_Hours", Type = typeof(TextBox))]
[TemplatePart(Name = "PART_Minutes", Type = typeof(TextBox))]
[TemplatePart(Name = "PART_DecrementTime", Type = typeof(ButtonBase))]
[TemplatePart(Name = "PART_Seconds", Type = typeof(TextBox))]
public class TimePicker : Control
{
	public static class MathUtil
	{
		private static MathUtil mathUtil_0;

		public static int IncrementDecrementNumber(string num, int minValue, int maxVal, bool increment)
		{
			return 0;
		}

		public static int ValidateNumber(string newNum, int minValue, int maxValue)
		{
			return 0;
		}

		public static int ValidateNumber(int newNum, int minValue, int maxValue)
		{
			return 0;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static MathUtil smethod_1()
		{
			return null;
		}

		static MathUtil()
		{
			Class200.smethod_34();
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class Class19
	{
		public static readonly Class19 Class9;

		internal static Class19 class19_0;

		internal void method_0(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
		{
		}

		internal void method_1(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
		{
		}

		internal void method_2(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
		{
		}

		internal void method_3(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
		{
		}

		internal void method_4(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
		{
		}

		static Class19()
		{
			Class200.smethod_34();
			Class204.smethod_0();
			Class9 = new Class19();
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class19 smethod_1()
		{
			return null;
		}
	}

	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	private int int_4;

	private int int_5;

	private TextBox textBox_0;

	private TextBox textBox_1;

	private TextBox textBox_2;

	private TextBox textBox_3;

	public static readonly DependencyProperty MinTimeProperty;

	public static readonly DependencyProperty MaxTimeProperty;

	public static readonly DependencyProperty SelectedTimeProperty;

	public static readonly DependencyProperty SelectedHourProperty;

	public static readonly DependencyProperty SelectedMinuteProperty;

	public static readonly DependencyProperty SelectedSecondProperty;

	public static readonly RoutedEvent SelectedTimeChangedEvent;

	private bool bool_0;

	internal static TimePicker timePicker_0;

	public TimeSpan MinTime
	{
		get
		{
			return (TimeSpan)(object)null;
		}
		set
		{
		}
	}

	public TimeSpan MaxTime
	{
		get
		{
			return (TimeSpan)(object)null;
		}
		set
		{
		}
	}

	public TimeSpan SelectedTime
	{
		get
		{
			return (TimeSpan)(object)null;
		}
		set
		{
		}
	}

	public int SelectedHour
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int SelectedMinute
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int SelectedSecond
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public event TimeSelectedChangedEventHandler SelectedTimeChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	public static bool SetupSelectedTimeBinding(DependencyObject xamlRoot, string controlName, string bindingName, BindingMode bindingMode, object bindingSource)
	{
		return true;
	}

	private static object smethod_0(DependencyObject dependencyObject_0, object object_0)
	{
		return null;
	}

	private static void smethod_1(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
	}

	static TimePicker()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		MinTimeProperty = DependencyProperty.Register(Class200.smethod_20(2954424), typeof(TimeSpan), typeof(TimePicker), new UIPropertyMetadata(TimeSpan.MinValue, delegate
		{
		}));
		MaxTimeProperty = DependencyProperty.Register(Class200.smethod_20(2954442), typeof(TimeSpan), typeof(TimePicker), new UIPropertyMetadata(TimeSpan.MaxValue, delegate
		{
		}));
		SelectedTimeProperty = DependencyProperty.Register(Class200.smethod_20(2954460), typeof(TimeSpan), typeof(TimePicker), new UIPropertyMetadata(new TimeSpan(0, 0, 0), smethod_1, smethod_0));
		SelectedHourProperty = DependencyProperty.Register(Class200.smethod_20(2954488), typeof(int), typeof(TimePicker), new UIPropertyMetadata(0, delegate
		{
		}));
		SelectedMinuteProperty = DependencyProperty.Register(Class200.smethod_20(2954516), typeof(int), typeof(TimePicker), new UIPropertyMetadata(0, delegate
		{
		}));
		SelectedSecondProperty = DependencyProperty.Register(Class200.smethod_20(2954548), typeof(int), typeof(TimePicker), new UIPropertyMetadata(0, delegate
		{
		}));
		SelectedTimeChangedEvent = EventManager.RegisterRoutedEvent(Class200.smethod_20(2954580), RoutingStrategy.Bubble, typeof(TimeSelectedChangedEventHandler), typeof(TimePicker));
		FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(TimePicker), new FrameworkPropertyMetadata(typeof(TimePicker)));
	}

	public override void OnApplyTemplate()
	{
	}

	private void method_0(object sender, RoutedEventArgs e)
	{
	}

	private void method_1(object sender, TextCompositionEventArgs e)
	{
	}

	private void method_2(object sender, TextCompositionEventArgs e)
	{
	}

	private void method_3(object sender, TextCompositionEventArgs e)
	{
	}

	private bool method_4(Key key_0)
	{
		return true;
	}

	private void method_5(object sender, KeyEventArgs e)
	{
	}

	private void method_6(object sender, KeyEventArgs e)
	{
	}

	private void method_7(object sender, KeyEventArgs e)
	{
	}

	private void method_8(object sender, RoutedEventArgs e)
	{
	}

	private void HcgAfbOfAij(object sender, RoutedEventArgs e)
	{
	}

	private void method_9(bool bool_1)
	{
	}

	private int method_10(string string_0)
	{
		return 0;
	}

	private int method_11(string string_0)
	{
		return 0;
	}

	private int method_12(string string_0)
	{
		return 0;
	}

	private static void smethod_2(TextBox textBox_4, TextBox textBox_5, TextBox textBox_6, Key key_0)
	{
	}

	private static string smethod_3(TextBox textBox_4, string string_0)
	{
		return null;
	}

	private static void smethod_4(TextBox textBox_4, TextBox textBox_5)
	{
	}

	private static void smethod_5(TextBox textBox_4)
	{
	}

	private static void smethod_6(TimePicker timePicker_1)
	{
	}

	private void method_13()
	{
	}

	private void method_14()
	{
	}

	private void method_15(TimeSpan timeSpan_0, TimeSpan timeSpan_1)
	{
	}

	internal static bool smethod_7()
	{
		return true;
	}

	internal static TimePicker smethod_8()
	{
		return null;
	}
}
