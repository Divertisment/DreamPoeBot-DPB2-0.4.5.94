using System.Runtime.CompilerServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Common;
using ns0;

namespace DreamPoeBot.Loki.Components;

public sealed class AnimatedSnapshot
{
	internal static readonly AnimatedSnapshot Empty;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly bool bool_0;

	[CompilerGenerated]
	private readonly Vector3 vector3_0;

	[CompilerGenerated]
	private readonly Vector3 GiNzaOgGcD;

	[CompilerGenerated]
	private readonly Vector3 vector3_1;

	[CompilerGenerated]
	private readonly Vector3 vector3_2;

	[CompilerGenerated]
	private readonly Vector3 vector3_3;

	[CompilerGenerated]
	private readonly float float_0;

	[CompilerGenerated]
	private readonly bool bool_1;

	[CompilerGenerated]
	private readonly BoundingBox WiYzxMlQp6;

	[CompilerGenerated]
	private readonly BoundingBox boundingBox_0;

	[CompilerGenerated]
	private readonly BoundingBox boundingBox_1;

	[CompilerGenerated]
	private readonly float float_1;

	internal static AnimatedSnapshot animatedSnapshot_0;

	public string Metadata
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public bool HasTransform
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
	}

	public Vector3 WorldPosition
	{
		[CompilerGenerated]
		get
		{
			return (Vector3)(object)null;
		}
	}

	public Vector2i GridCenter => (Vector2i)(object)null;

	public Vector3 AxisX
	{
		[CompilerGenerated]
		get
		{
			return (Vector3)(object)null;
		}
	}

	public Vector3 AxisY
	{
		[CompilerGenerated]
		get
		{
			return (Vector3)(object)null;
		}
	}

	public Vector3 AxisZ
	{
		[CompilerGenerated]
		get
		{
			return (Vector3)(object)null;
		}
	}

	public Vector3 Scale
	{
		[CompilerGenerated]
		get
		{
			return (Vector3)(object)null;
		}
	}

	public float RotationRadians
	{
		[CompilerGenerated]
		get
		{
			return 0f;
		}
	}

	public bool HasLocalBounds
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
	}

	public BoundingBox LocalBounds
	{
		[CompilerGenerated]
		get
		{
			return (BoundingBox)(object)null;
		}
	}

	public bool HasWorldBounds => true;

	public BoundingBox WorldBounds
	{
		[CompilerGenerated]
		get
		{
			return (BoundingBox)(object)null;
		}
	}

	public BoundingBox NativeWorldBounds
	{
		[CompilerGenerated]
		get
		{
			return (BoundingBox)(object)null;
		}
	}

	public float EstimatedHorizontalRadius
	{
		[CompilerGenerated]
		get
		{
			return 0f;
		}
	}

	public float EstimatedGridRadius => 0f;

	public bool IsAvailable => true;

	private AnimatedSnapshot()
	{
	}

	internal AnimatedSnapshot(string metadata, Vector3 axisX, Vector3 axisY, Vector3 axisZ, Vector3 position, bool hasTransform, BoundingBox local, BoundingBox nativeWorld, bool hasBounds)
	{
	}

	public Vector3 TransformPoint(Vector3 localPoint)
	{
		return (Vector3)(object)null;
	}

	static AnimatedSnapshot()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		Empty = new AnimatedSnapshot();
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static AnimatedSnapshot smethod_1()
	{
		return null;
	}
}
