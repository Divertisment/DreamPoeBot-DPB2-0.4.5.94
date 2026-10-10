using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class ObjectMagicProperties : Component
{
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct Struct185ObgectMagicProperties
	{
		[FieldOffset(320)]
		public byte byte_4IsIdentified;

		[FieldOffset(324)]
		public Rarity rarity_0;

		[FieldOffset(336)]
		public NativeVector nativeVector_1ImpAfex;

		[FieldOffset(360)]
		public NativeVector nativeVector_2ExpAfex;

		[FieldOffset(504)]
		public NativeVector nativeVector_3StatDict;

		[FieldOffset(552)]
		public NativeVector nativeVector_3MonsterVariety;

		[FieldOffset(720)]
		public byte corrupted;
	}

	private PerFrameCachedValue<Struct185ObgectMagicProperties> perFrameCachedValue_0;

	private PerFrameCachedValue<List<string>> perFrameCachedValue_1;

	private PerFrameCachedValue<List<string>> perFrameCachedValue_2;

	private PerFrameCachedValue<Dictionary<StatTypeGGG, int>> perFrameCachedValue_3;

	private static ObjectMagicProperties objectMagicProperties_0;

	public Rarity Rarity => (Rarity)(object)null;

	public bool IsIdentified => true;

	public bool IsCorrupted => true;

	public List<string> Mods => null;

	public IEnumerable<DatModsWrapper> Affixes => null;

	public List<DatModsWrapper> Affixes2 => null;

	public List<DatModsWrapper> ImplicitAffixes => null;

	public List<DatModsWrapper> ExplicitAffixes => null;

	public IEnumerable<StatContainer> ExplicitStats => null;

	public IEnumerable<StatContainer> ImplicitStats => null;

	internal Dictionary<StatTypeGGG, int> StatDictionary => null;

	public Dictionary<StatTypeGGG, int> StatDictionary_1()
	{
		return null;
	}

	[SpecialName]
	internal List<string> method_2()
	{
		return null;
	}

	public List<string> ImpMods_1()
	{
		return null;
	}

	[SpecialName]
	internal List<string> method_3()
	{
		return null;
	}

	public List<string> ExpMods_1()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	internal Struct185ObgectMagicProperties method_4()
	{
		return (Struct185ObgectMagicProperties)(object)null;
	}

	[CompilerGenerated]
	private Struct185ObgectMagicProperties method_5()
	{
		return (Struct185ObgectMagicProperties)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static ObjectMagicProperties smethod_5()
	{
		return null;
	}

	static ObjectMagicProperties()
	{
		Class200.smethod_34();
	}
}
