using System;
using DreamPoeBot.Common;
using ns0;

namespace DreamPoeBot.Loki.Game.Utilities;

public class PerBoundsCachedValue<T> : PerCachedValue<T>
{
	private Vector2i vector2i_0;

	private Vector2i vector2i_1;

	internal static object object_1;

	public PerBoundsCachedValue(Func<T> producer, Vector2i size)
	{
	}

	protected override bool ShouldUpdateCache(bool force = false)
	{
		return true;
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static object smethod_3()
	{
		return null;
	}

	static PerBoundsCachedValue()
	{
		Class200.smethod_34();
	}
}
