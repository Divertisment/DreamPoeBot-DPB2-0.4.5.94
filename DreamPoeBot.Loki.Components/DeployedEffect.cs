using System.Runtime.CompilerServices;
using DreamPoeBot.Common;
using ns0;

namespace DreamPoeBot.Loki.Components;

public sealed class DeployedEffect
{
	[CompilerGenerated]
	private readonly long long_0;

	[CompilerGenerated]
	private readonly int int_0;

	[CompilerGenerated]
	private readonly uint? nullable_0;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly string string_1;

	[CompilerGenerated]
	private readonly string string_2;

	[CompilerGenerated]
	private readonly Vector2i vector2i_0;

	[CompilerGenerated]
	private readonly long long_1;

	[CompilerGenerated]
	private readonly DeployedEffectGeometry deployedEffectGeometry_0;

	internal static DeployedEffect deployedEffect_0;

	public long Address
	{
		[CompilerGenerated]
		get
		{
			return 0L;
		}
	}

	public int SourceId
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
	}

	public uint? SkillId
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public string GrantedEffectId
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public string InternalId
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public string ActionType
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public Vector2i Destination
	{
		[CompilerGenerated]
		get
		{
			return (Vector2i)(object)null;
		}
	}

	public long TargetAddress
	{
		[CompilerGenerated]
		get
		{
			return 0L;
		}
	}

	public DeployedEffectGeometry Geometry
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	internal DeployedEffect(long address, int sourceId, uint? skillId, string grantedEffectId, string internalId, string actionType, Vector2i destination, long targetAddress, DeployedEffectGeometry geometry)
	{
	}

	public override string ToString()
	{
		return null;
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static DeployedEffect smethod_1()
	{
		return null;
	}

	static DeployedEffect()
	{
		Class200.smethod_34();
	}
}
