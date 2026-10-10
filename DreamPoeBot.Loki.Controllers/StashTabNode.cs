using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.RemoteMemoryObjects;
using Newtonsoft.Json;
using ns0;

namespace DreamPoeBot.Loki.Controllers;

public class StashTabNode
{
	public const string EMPTYNAME = "-NoName-";

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private int grMziPhEuB;

	[CompilerGenerated]
	private bool bool_1;

	internal static StashTabNode stashTabNode_0;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public int VisibleIndex
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	[JsonIgnore]
	public bool Exist
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	[JsonIgnore]
	internal int Id
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	[JsonIgnore]
	public bool IsRemoveOnly
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public StashTabNode()
	{
	}

	public StashTabNode(string name, int visibleIndex)
	{
	}

	public StashTabNode(ServerStashTab serverTab, int id)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static StashTabNode smethod_1()
	{
		return null;
	}

	static StashTabNode()
	{
		Class200.smethod_34();
	}
}
