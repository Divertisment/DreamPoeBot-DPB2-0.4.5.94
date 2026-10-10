using System;
using System.Runtime.CompilerServices;
using ns0;

namespace DreamPoeBot.Loki.Bot.Pathfinding.RDWrapper.Types;

public class RecastMeshSettings
{
	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private float float_0;

	[CompilerGenerated]
	private float float_1;

	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	private int int_2;

	[CompilerGenerated]
	private int int_3;

	[CompilerGenerated]
	private int int_4;

	[CompilerGenerated]
	private float float_2;

	[CompilerGenerated]
	private int int_5;

	[CompilerGenerated]
	private int int_6;

	[CompilerGenerated]
	private float float_3;

	[CompilerGenerated]
	private float float_4;

	[CompilerGenerated]
	private int int_7;

	[CompilerGenerated]
	private AgentSettings agentSettings_0;

	[CompilerGenerated]
	private int int_8;

	public static readonly RecastMeshSettings PathOfExile;

	public static readonly RecastMeshSettings RectangleOptimized;

	private static RecastMeshSettings recastMeshSettings_0;

	public int TileSizeVoxels
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

	public float TileSize => 0f;

	public float CellSize
	{
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public float CellHeight
	{
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public int WalkableHeight
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

	public int WalkableRadius
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

	public int WalkableClimb
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

	public int MaxEdgeLength
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

	public float MaxSimplificationError
	{
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public int MinRegionSize
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

	public int MergeRegionSize
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

	public float DetailSampleDist
	{
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public float DetailSampleMaxError
	{
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public int BorderSize
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

	public AgentSettings Agent
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

	public int MaxVertsPerPoly
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

	static RecastMeshSettings()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		float height = 2f;
		float radius = 1f;
		float maxClimb = 0.9f;
		float maxSlope = 45f;
		AgentSettings agentSettings = new AgentSettings
		{
			Height = height,
			Radius = radius,
			MaxSlope = maxSlope,
			MaxClimb = maxClimb
		};
		float cellSize = 1f / 3f;
		float num = 1f / 6f;
		PathOfExile = new RecastMeshSettings
		{
			Agent = agentSettings,
			CellSize = cellSize,
			CellHeight = num,
			WalkableRadius = 0,
			BorderSize = (int)(agentSettings.Radius + 1f),
			DetailSampleDist = 2f,
			DetailSampleMaxError = 1f / 6f,
			MaxEdgeLength = 500,
			TileSizeVoxels = 32,
			MaxSimplificationError = 1.3f,
			MergeRegionSize = 4000,
			MinRegionSize = 1,
			WalkableClimb = (int)Math.Ceiling(agentSettings.MaxClimb / num),
			WalkableHeight = (int)Math.Ceiling(agentSettings.Height / num),
			MaxVertsPerPoly = 6
		};
		AgentSettings agent = new AgentSettings
		{
			Height = 1f,
			Radius = 15f,
			MaxSlope = 90f,
			MaxClimb = 0.1f
		};
		RectangleOptimized = new RecastMeshSettings
		{
			Agent = agent,
			CellSize = 1f,
			CellHeight = 1f,
			WalkableRadius = 1,
			WalkableHeight = 1,
			WalkableClimb = 1,
			TileSizeVoxels = 24,
			BorderSize = 5,
			MaxEdgeLength = 12,
			MaxSimplificationError = 1f,
			DetailSampleDist = 6f,
			DetailSampleMaxError = 1f,
			MinRegionSize = 8,
			MergeRegionSize = 20,
			MaxVertsPerPoly = 6
		};
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static RecastMeshSettings smethod_1()
	{
		return null;
	}
}
