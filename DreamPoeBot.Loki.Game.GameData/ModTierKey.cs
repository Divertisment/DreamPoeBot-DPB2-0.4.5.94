using System;
using System.Runtime.CompilerServices;
using ns0;

namespace DreamPoeBot.Loki.Game.GameData;

public readonly struct ModTierKey : IEquatable<ModTierKey>
{
	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly ModType modType_0;

	internal static object object_0;

	public string Category
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public ModType ModType
	{
		[CompilerGenerated]
		get
		{
			return (ModType)(object)null;
		}
	}

	public ModTierKey(string category, ModType modType)
	{
	}

	public bool Equals(ModTierKey other)
	{
		return true;
	}

	public override bool Equals(object obj)
	{
		return true;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static object smethod_1()
	{
		return null;
	}

	static ModTierKey()
	{
		Class200.smethod_34();
	}
}
