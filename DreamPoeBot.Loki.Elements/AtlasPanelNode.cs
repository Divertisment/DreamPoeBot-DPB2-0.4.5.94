using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Elements;

public class AtlasPanelNode : Element
{
	[StructLayout(LayoutKind.Auto)]
	[InlineArray(1)]
	internal struct Struct162<T>
	{
		private T gparam_0;
	}

	public enum AtlasPassiveSkillSubtreeType : byte
	{
		Breach = 0,
		Expedition = 1,
		Delirium = 2,
		Ritual = 3,
		Abyss = 4,
		Incursion = 5,
		Generic = 254,
		Unknown = byte.MaxValue
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1)]
	internal struct Struct163
	{
		[FieldOffset(640)]
		internal Vector2i vector2i_0;

		[FieldOffset(752)]
		public long long_0;

		[FieldOffset(768)]
		public long long_1;

		[FieldOffset(784)]
		public Vector2i vector2i_1;

		[FieldOffset(799)]
		public byte byte_0;

		[FieldOffset(832)]
		internal byte byte_1;

		[FieldOffset(833)]
		internal byte byte_2;

		[FieldOffset(798)]
		public byte byte_3;

		[FieldOffset(872)]
		public NativeVector nativeVector_0;
	}

	private PerFrameCachedValue<Struct163> perFrameCachedValue_6;

	private static AtlasPanelNode atlasPanelNode_0;

	public bool IsVisited => true;

	public bool IsUnlocked => true;

	public bool IsTower => true;

	public bool IsCorrupted => true;

	public bool IsCorruptedNexus => true;

	public bool IsPowerfulMapBoss => true;

	public bool IsIrradiated => true;

	public bool IsCompleted => true;

	public bool IsUnique => true;

	public bool CanBeUsed => true;

	public bool Uncharted => true;

	public DatWorldAreaWrapper Area => null;

	public DatEndGameMapWrapper EndgameMap => null;

	public AtlasPanel2.BiomeEnum BiomeEnum => (AtlasPanel2.BiomeEnum)(object)null;

	public List<EndgameMapContentWrapper> Content => null;

	public AtlasNodeIconElement OverNodeIcon => null;

	public DatPassiveSkillWrapper AtlasPassiveEffect => null;

	public AtlasPassiveSkillSubtreeType ExtraAtlasPassiveGrantedType => (AtlasPassiveSkillSubtreeType)(object)null;

	public byte ExtraAtlasPassiveGranted => 0;

	public byte MinWaystoneTierRequired => 0;

	[SpecialName]
	internal List<bool> method_29()
	{
		return null;
	}

	public new Vector2i CenterClickLocation()
	{
		return (Vector2i)(object)null;
	}

	internal Vector2i method_30()
	{
		return (Vector2i)(object)null;
	}

	[SpecialName]
	internal Struct163 method_31()
	{
		return (Struct163)(object)null;
	}

	[CompilerGenerated]
	private Struct163 method_32()
	{
		return (Struct163)(object)null;
	}

	internal static bool smethod_11()
	{
		return true;
	}

	internal static AtlasPanelNode smethod_12()
	{
		return null;
	}

	static AtlasPanelNode()
	{
		Class200.smethod_34();
	}
}
