using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Game.GameData;
using ns0;

namespace DreamPoeBot.Loki.Game;

public sealed class RiteOfTheNamelessNode
{
	[CompilerGenerated]
	private readonly Vector2i vector2i_0;

	[CompilerGenerated]
	private readonly IReadOnlyList<DatModsWrapper> ireadOnlyList_0;

	[CompilerGenerated]
	private readonly IReadOnlyList<RiteOfTheNamelessNode> ireadOnlyList_1;

	public Vector2i Coordinate
	{
		[CompilerGenerated]
		get
		{
			return (Vector2i)(object)null;
		}
	}

	public IReadOnlyList<DatModsWrapper> Modifiers
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public IReadOnlyList<RiteOfTheNamelessNode> Children
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	internal RiteOfTheNamelessNode(Vector2i coordinate, IReadOnlyList<DatModsWrapper> modifiers, IReadOnlyList<RiteOfTheNamelessNode> children)
	{
	}

	static RiteOfTheNamelessNode()
	{
		Class200.smethod_34();
	}
}
