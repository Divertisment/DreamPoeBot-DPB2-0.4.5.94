using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.RemoteMemoryObjects;
using ns0;

namespace DreamPoeBot.Loki.Models;

public sealed class AreaInstance
{
	[CompilerGenerated]
	private readonly int int_0;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly int int_1;

	[CompilerGenerated]
	private readonly bool bool_0;

	[CompilerGenerated]
	private readonly bool bool_1;

	[CompilerGenerated]
	private readonly bool bool_2;

	[CompilerGenerated]
	private readonly uint uint_0;

	[CompilerGenerated]
	private int int_2;

	[CompilerGenerated]
	private int int_3;

	public DateTime TimeEntered;

	[CompilerGenerated]
	private readonly AreaMap areaMap_0;

	private readonly string[] string_1;

	internal static AreaInstance areaInstance_0;

	public int RealLevel
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public int Act
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
	}

	public bool IsTown
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
	}

	public bool IsHideout
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
	}

	public bool HasWaypoint
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
	}

	public uint Hash
	{
		[CompilerGenerated]
		get
		{
			return 0u;
		}
	}

	public int Rows
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int Cols
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public AreaMap AreaMap
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public string DisplayName => null;

	public AreaInstance(AreaTemplate area, AreaMap areaMap, uint hash, int realLevel)
	{
	}

	public override string ToString()
	{
		return null;
	}

	public static string GetTimeString(TimeSpan timeSpent)
	{
		return null;
	}

	private List<AreaTilesData> method_0()
	{
		return null;
	}

	private Color method_1(AreaTilesData areaTilesData_0)
	{
		return (Color)(object)null;
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static AreaInstance smethod_1()
	{
		return null;
	}

	static AreaInstance()
	{
		Class200.smethod_34();
	}
}
