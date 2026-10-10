using System.Runtime.CompilerServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Elements;

public class GenericComboBoxEntry
{
	private Element element_0;

	private readonly long long_0;

	private readonly Memory memory_0;

	private PerFrameCachedValue<Struct166> perFrameCachedValue_0;

	private static GenericComboBoxEntry genericComboBoxEntry_0;

	public bool IsVisible => true;

	public string Name => null;

	public string Ping => null;

	public float DeltaYMax => 0f;

	public float DeltaYMin => 0f;

	public float CellHeight => 0f;

	public float CellWidth => 0f;

	public Vector2i ClickPosition => (Vector2i)(object)null;

	public GenericComboBoxEntry(long address, Memory m, Element element)
	{
	}

	[SpecialName]
	private Struct166 method_0()
	{
		return (Struct166)(object)null;
	}

	private Struct166 method_1()
	{
		return (Struct166)(object)null;
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static GenericComboBoxEntry smethod_1()
	{
		return null;
	}

	static GenericComboBoxEntry()
	{
		Class200.smethod_34();
	}
}
