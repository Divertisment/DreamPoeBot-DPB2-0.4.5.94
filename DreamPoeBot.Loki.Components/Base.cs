using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.FilesInMemory;
using DreamPoeBot.Loki.Game.GameData;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.Components;

public class Base : Component
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct187
	{
		private Struct14 struct14_0;

		public long long_0;

		private long long_1;

		private long long_2;

		private long long_3;

		private long long_4;

		private long long_5;

		private GStruct2 gstruct2_0;

		public GStruct2 gstruct2_1;

		public NativeVector nativeVector_0;

		private long long_6;

		private NativeVector nativeVector_1;

		private long long_7;

		private int VoRlUzhmDg0;

		private byte byte_0;

		public byte byte_1;

		public byte byte_2;

		public byte byte_3;

		public int int_0;

		public int int_1;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct188
	{
		private long long_0;

		private long long_1;

		public byte byte_0;

		public byte byte_1;

		public byte byte_2;

		private byte byte_3;

		private short short_0;

		private short short_1;

		private int int_0;

		private int int_1;

		private int int_2;

		private int int_3;

		private int int_4;

		private int int_5;

		public GStruct2 gstruct2_0;

		public Struct10 struct10_0;

		public NativeVector nativeVector_0;

		public GStruct2 gstruct2_1;
	}

	private int int_0;

	private int int_1;

	private List<DatTagWrapper> list_0;

	private PerFrameCachedValue<Struct187> perFrameCachedValue_0;

	private PerFrameCachedValue<string> perFrameCachedValue_1;

	private PerFrameCachedValue<string> perFrameCachedValue_2;

	private PerFrameCachedValue<string> perFrameCachedValue_3;

	private DatBaseItemTypeWrapper datBaseItemTypeWrapper_0;

	internal static Base base_0;

	public string Name => null;

	public string DescriptionText => null;

	public string DisplayNote => null;

	public int BaseLevel => 0;

	public int Level => 0;

	public Vector2i Size => (Vector2i)(object)null;

	public int WorldObjectSize => 0;

	public bool IsCorrupted => true;

	public bool IsShaperItem => true;

	public bool IsElderItem => true;

	public bool IsHunterItem => true;

	public bool IsWarlordItem => true;

	public bool IsCrusaderItem => true;

	public bool IsRedeemerItem => true;

	public bool IsTradeAndModifiedLocked => true;

	public int AbsorbedCorruption => 0;

	public int ScourgedTier => 0;

	public List<string> MicrotransactionAttachments => null;

	public List<DatTagWrapper> Tags => null;

	public DatBaseItemTypeWrapper BaseItemType => null;

	private Struct187 method_2()
	{
		return (Struct187)(object)null;
	}

	private string method_3()
	{
		return null;
	}

	private string method_4()
	{
		return null;
	}

	private string method_5()
	{
		return null;
	}

	[SpecialName]
	internal Struct188 method_6()
	{
		return (Struct188)(object)null;
	}

	[SpecialName]
	internal Struct187 method_7()
	{
		return (Struct187)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static Base smethod_5()
	{
		return null;
	}

	static Base()
	{
		Class200.smethod_34();
	}
}
