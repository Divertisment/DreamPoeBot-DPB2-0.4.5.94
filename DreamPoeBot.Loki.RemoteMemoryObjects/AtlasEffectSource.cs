using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Elements;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Std;
using ns0;

namespace DreamPoeBot.Loki.RemoteMemoryObjects;

public class AtlasEffectSource : RemoteMemoryObject
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 32)]
	internal struct Struct31
	{
		public Vector2i vector2i_0;

		public NativeVector nativeVector_0;
	}

	public class EffectSourceMod : RemoteMemoryObject
	{
		[CompilerGenerated]
		private Struct32 struct32_0;

		private static EffectSourceMod effectSourceMod_0;

		public DatStatWrapper Stat => null;

		public int StatValue => 0;

		[SpecialName]
		[CompilerGenerated]
		private Struct32 method_0()
		{
			return (Struct32)(object)null;
		}

		[SpecialName]
		[CompilerGenerated]
		private void method_1(Struct32 struct32_1)
		{
		}

		internal EffectSourceMod(long address, Struct32 structure)
		{
		}

		internal static bool smethod_2()
		{
			return true;
		}

		internal static EffectSourceMod smethod_3()
		{
			return null;
		}

		static EffectSourceMod()
		{
			Class200.smethod_34();
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 4)]
	internal struct Struct32
	{
		public int int_0;
	}

	[CompilerGenerated]
	private Struct31 struct31_0;

	internal static AtlasEffectSource atlasEffectSource_0;

	public Vector2i Coordinate => (Vector2i)(object)null;

	public List<EffectSourceMod> Effects => null;

	public AtlasPanel2.AtlasNode AtlasNode => null;

	[SpecialName]
	[CompilerGenerated]
	private Struct31 method_0()
	{
		return (Struct31)(object)null;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_1(Struct31 struct31_1)
	{
	}

	internal AtlasEffectSource(long address, Struct31 structure)
	{
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static AtlasEffectSource smethod_3()
	{
		return null;
	}

	static AtlasEffectSource()
	{
		Class200.smethod_34();
	}
}
