using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using DreamPoeBot.Loki.Common;
using DreamPoeBot.Loki.Components;
using DreamPoeBot.Loki.Game.GameData;
using log4net;
using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

public record ModAffix
{
	[CompilerGenerated]
	protected virtual Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public int Level => 0;

	public string Category => null;

	public string InternalName => null;

	public string DisplayName => null;

	public Domain Domain => (Domain)(object)null;

	public bool IsHidden => true;

	public bool IsPrefix => true;

	public bool IsSuffix => true;

	public bool IsFractured
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	public StatContainer[] Stats => null;

	public List<int> Values
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	public readonly DatModsWrapper Mod;

	[CompilerGenerated]
	private readonly bool bool_0;

	[CompilerGenerated]
	private readonly List<int> list_0;

	private static readonly ILog Log;

	private static ModAffix modAffix_0;

	internal ModAffix(Mods.Struct234 container, bool isFractured = false)
	{
	}

	public override string ToString()
	{
		return null;
	}

	[CompilerGenerated]
	protected virtual bool PrintMembers(StringBuilder builder)
	{
		return true;
	}

	[CompilerGenerated]
	protected ModAffix(ModAffix original)
	{
	}

	static ModAffix()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		Log = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static ModAffix smethod_1()
	{
		return null;
	}
}
