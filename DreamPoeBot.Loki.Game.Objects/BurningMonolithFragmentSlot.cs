using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Game.GameData;
using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

public sealed class BurningMonolithFragmentSlot
{
	private readonly Element element_0;

	private readonly Element element_1;

	[CompilerGenerated]
	private readonly int int_0;

	private static BurningMonolithFragmentSlot burningMonolithFragmentSlot_0;

	public int Index
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
	}

	public string Name => null;

	public IReadOnlyList<string> AcceptedItemMetadata => null;

	public bool IsFilled => true;

	public bool CanInsert => true;

	internal BurningMonolithFragmentSlot(Element element, Element panel, int index)
	{
	}

	public bool InsertFromCursor()
	{
		return true;
	}

	private ushort method_0()
	{
		return 0;
	}

	private DatBaseItemTypeWrapper.Struct102[] method_1()
	{
		return null;
	}

	[CompilerGenerated]
	private string method_2(DatBaseItemTypeWrapper.Struct102 struct102_0)
	{
		return null;
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static BurningMonolithFragmentSlot smethod_1()
	{
		return null;
	}

	static BurningMonolithFragmentSlot()
	{
		Class200.smethod_34();
	}
}
