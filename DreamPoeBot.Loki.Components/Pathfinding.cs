using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class Pathfinding : Component
{
	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	public struct PathfindingComponentOffsets
	{
		public static int PathNodeStart;

		[FieldOffset(212)]
		public Vector2i WasInThisPosition;

		[FieldOffset(1304)]
		public int DestinationNodes;

		[FieldOffset(1376)]
		public byte IsMoving;

		[FieldOffset(1384)]
		public Vector2i WantMoveToPosition;

		[FieldOffset(1396)]
		public float StayTime;

		internal static object object_0;

		static PathfindingComponentOffsets()
		{
			Class200.smethod_34();
			Class204.smethod_0();
			PathNodeStart = 212;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static object smethod_1()
		{
			return null;
		}
	}

	private readonly PerFrameCachedValue<PathfindingComponentOffsets> perFrameCachedValue_0;

	internal static Pathfinding pathfinding_0;

	public Vector2i PreviousMovePos => (Vector2i)(object)null;

	public Vector2i WantMoveToPosition => (Vector2i)(object)null;

	public bool IsMoving => true;

	public int DestinationNodes => 0;

	public float StayTime => 0f;

	public IList<Vector2i> PathingNodes => null;

	[SpecialName]
	private PathfindingComponentOffsets method_2()
	{
		return (PathfindingComponentOffsets)(object)null;
	}

	[CompilerGenerated]
	private PathfindingComponentOffsets method_3()
	{
		return (PathfindingComponentOffsets)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static Pathfinding smethod_5()
	{
		return null;
	}

	static Pathfinding()
	{
		Class200.smethod_34();
	}
}
