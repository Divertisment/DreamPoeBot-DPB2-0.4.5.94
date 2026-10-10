using System;
using System.Globalization;
using System.Windows.Data;
using ns0;

namespace DreamPoeBot.DreamPoe;

public class MultiBoolEnabledConverter : IMultiValueConverter
{
	internal static MultiBoolEnabledConverter multiBoolEnabledConverter_0;

	public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
	{
		return null;
	}

	public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
	{
		return null;
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static MultiBoolEnabledConverter smethod_1()
	{
		return null;
	}

	static MultiBoolEnabledConverter()
	{
		Class200.smethod_34();
	}
}
