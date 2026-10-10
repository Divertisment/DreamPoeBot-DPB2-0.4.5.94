using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Objects;
using ns0;

namespace DreamPoeBot.Loki.Game.NativeWrappers;

public class MinimapIconWrapper
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 192)]
	internal struct Struct96
	{
		[FieldOffset(0)]
		public readonly Struct10 struct10_0;

		[FieldOffset(20)]
		public readonly Vector2i vector2i_0;

		[FieldOffset(176)]
		public readonly int int_0;
	}

	[CompilerGenerated]
	private DatMinimapIconWrapper datMinimapIconWrapper_0;

	[CompilerGenerated]
	private int nrsknMfvLe;

	[CompilerGenerated]
	private Vector2i vector2i_0;

	private static MinimapIconWrapper minimapIconWrapper_0;

	public DatMinimapIconWrapper MinimapIcon
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int ObjectId
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

	public NetworkObject NetworkObject => null;

	public Vector2i LastSeenPosition
	{
		[CompilerGenerated]
		get
		{
			return (Vector2i)(object)null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	internal MinimapIconWrapper(Struct96 native)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static MinimapIconWrapper smethod_1()
	{
		return null;
	}

	static MinimapIconWrapper()
	{
		Class200.smethod_34();
	}
}
