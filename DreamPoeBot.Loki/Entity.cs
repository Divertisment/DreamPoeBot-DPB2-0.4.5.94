using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Common;
using DreamPoeBot.Loki.Components;
using DreamPoeBot.Loki.Game.Std;
using DreamPoeBot.Loki.Game.Utilities;
using log4net;
using ns0;

namespace DreamPoeBot.Loki;

public abstract class Entity : RemoteMemoryObject
{
	internal sealed class Class37
	{
		internal readonly Memory memory_0;

		private int int_0;

		internal static Class37 class37_0;

		internal Class37(Memory memory_1)
		{
		}

		[SpecialName]
		internal bool method_0()
		{
			return true;
		}

		internal void method_1()
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class37 smethod_1()
		{
			return null;
		}

		static Class37()
		{
			Class200.smethod_34();
		}
	}

	private sealed class Class38
	{
		private readonly Memory memory_0;

		private readonly object object_0;

		private readonly PerFrameCachedValue<bool> perFrameCachedValue_0;

		private bool bool_0;

		[CompilerGenerated]
		private Dictionary<string, int> dictionary_0;

		[CompilerGenerated]
		private int int_0;

		private static Class38 class38_0;

		public Class38(Dictionary<string, int> dictionary_1, int int_1, Memory memory_1, long long_0, NativeVector nativeVector_0, Struct25[] struct25_0)
		{
		}

		public bool method_0(Memory memory_1, bool bool_1 = false)
		{
			return true;
		}

		public void method_1()
		{
		}

		[SpecialName]
		[CompilerGenerated]
		public Dictionary<string, int> method_2()
		{
			return null;
		}

		[SpecialName]
		[CompilerGenerated]
		private void method_3(Dictionary<string, int> dictionary_1)
		{
		}

		[SpecialName]
		[CompilerGenerated]
		public int method_4()
		{
			return 0;
		}

		[SpecialName]
		[CompilerGenerated]
		private void method_5(int int_1)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class38 smethod_1()
		{
			return null;
		}

		static Class38()
		{
			Class200.smethod_34();
		}
	}

	private static class Class39<T> where T : Component, new()
	{
		public static readonly string Name;

		internal static object object_0;

		static Class39()
		{
			Class200.smethod_34();
			Class204.smethod_0();
			Name = typeof(T).Name;
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

	[StructLayout(LayoutKind.Explicit, Size = 112)]
	internal struct Struct22
	{
		[FieldOffset(0)]
		public long long_0;

		[FieldOffset(8)]
		public long long_1;

		[FieldOffset(16)]
		public long long_2;

		[FieldOffset(16)]
		public NativeVector nativeVector_0;

		[FieldOffset(88)]
		public NativeVector nativeVector_1;
	}

	[StructLayout(LayoutKind.Explicit, Size = 56)]
	internal struct Struct23
	{
		[FieldOffset(0)]
		private long long_0;

		[FieldOffset(8)]
		public GStruct2 Metadata;

		[FieldOffset(40)]
		public long long_1;
	}

	[StructLayout(LayoutKind.Explicit, Size = 88)]
	internal struct Struct24
	{
		[FieldOffset(0)]
		private long long_0;

		[FieldOffset(8)]
		private long long_1;

		[FieldOffset(16)]
		private long long_2;

		[FieldOffset(24)]
		private long long_3;

		[FieldOffset(32)]
		private long long_4;

		[FieldOffset(40)]
		public NativeVector nativeVector_0;

		[FieldOffset(64)]
		private long long_5;

		[FieldOffset(72)]
		private int int_0;

		[FieldOffset(76)]
		private int int_1;

		[FieldOffset(80)]
		public int int_2;

		[FieldOffset(84)]
		private int int_3;
	}

	[StructLayout(LayoutKind.Explicit, Size = 16)]
	internal struct Struct25
	{
		[FieldOffset(0)]
		public long Name;

		[FieldOffset(8)]
		public int int_0;

		[FieldOffset(12)]
		private int int_1;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct26
	{
		public byte byte_0;

		public byte byte_1;

		public byte byte_2;

		public byte byte_3;

		public byte byte_4;

		public byte byte_5;

		public byte byte_6;

		public byte byte_7;

		public Struct25 struct25_0;

		public Struct25 struct25_1;

		public Struct25 struct25_2;

		public Struct25 struct25_3;

		public Struct25 struct25_4;

		public Struct25 struct25_5;

		public Struct25 struct25_6;

		public Struct25 struct25_7;
	}

	[StructLayout(LayoutKind.Explicit, Size = 16)]
	internal struct Struct27
	{
		[FieldOffset(0)]
		public short Id;

		[FieldOffset(8)]
		public long long_0;
	}

	private static readonly ILog ilog_0;

	private static readonly ConcurrentDictionary<long, Class38> concurrentDictionary_0;

	private static readonly Struct27[] struct27_0;

	private int int_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private Positioned positioned_0;

	private Class37 class37_0;

	private long long_1;

	private long long_2;

	private int int_1;

	private Dictionary<string, long> dictionary_0;

	private long long_3;

	private Class38 class38_0;

	private PerFrameCachedValue<Struct22> perFrameCachedValue_0;

	private PerFrameCachedValue<Struct23> perFrameCachedValue_1;

	private PerFrameCachedValue<Struct24> perFrameCachedValue_2;

	private PerFrameCachedValue<Struct27[]> perFrameCachedValue_3;

	internal static Entity entity_0;

	public Dictionary<string, long> ComponentIndices => null;

	public Dictionary<string, long> BuildComponentIndices => null;

	public string Type => null;

	public string Metadata => null;

	public override bool IsValid => true;

	public int Id => 0;

	public string Name => null;

	public Vector2i Position => (Vector2i)(object)null;

	public Positioned PositionedComp => null;

	public byte Reaction => 0;

	public float Rotation => 0f;

	[SpecialName]
	internal bool method_0()
	{
		return true;
	}

	[SpecialName]
	internal bool method_1()
	{
		return true;
	}

	[SpecialName]
	internal bool method_2()
	{
		return true;
	}

	internal bool method_3(Class37 class37_1, int int_2)
	{
		return true;
	}

	internal void method_4()
	{
	}

	internal void method_5()
	{
	}

	internal bool method_6()
	{
		return true;
	}

	private bool method_7()
	{
		return true;
	}

	private bool method_8()
	{
		return true;
	}

	public Entity()
	{
	}

	public Entity(long address)
	{
	}

	public Entity(long address, int id)
	{
	}

	public static void ClearSharedCaches()
	{
	}

	public long GetEffectManager(short id)
	{
		return 0L;
	}

	public bool HasComponent<T>() where T : Component, new()
	{
		return true;
	}

	public T GetComponent<T>() where T : Component, new()
	{
		return null;
	}

	public bool TryGetComponent<T>(out T component) where T : Component, new()
	{
		return true;
	}

	private T method_9<T>(long long_4) where T : Component, new()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	internal Struct22 method_10()
	{
		return (Struct22)(object)null;
	}

	[SpecialName]
	internal Struct23 method_11()
	{
		return (Struct23)(object)null;
	}

	[SpecialName]
	internal Struct24 method_12()
	{
		return (Struct24)(object)null;
	}

	[SpecialName]
	private Struct27[] method_13()
	{
		return null;
	}

	private Struct27[] method_14()
	{
		return null;
	}

	private bool method_15<T>(out long long_4) where T : Component, new()
	{
		return true;
	}

	private bool method_16(out Class38 class38_1)
	{
		return true;
	}

	private Class38 method_17(long long_4)
	{
		return null;
	}

	private Dictionary<string, long> method_18()
	{
		return null;
	}

	private bool method_19(string string_3, bool bool_0 = true)
	{
		return true;
	}

	private static Dictionary<string, long> smethod_2()
	{
		return null;
	}

	private static bool smethod_3(NativeVector nativeVector_0, int int_2, int int_3, out int int_4)
	{
		return true;
	}

	static Entity()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_0 = Logger.GetLoggerInstanceForType();
		concurrentDictionary_0 = new ConcurrentDictionary<long, Class38>();
		struct27_0 = Array.Empty<Struct27>();
	}

	[CompilerGenerated]
	private Struct22 method_20()
	{
		return (Struct22)(object)null;
	}

	[CompilerGenerated]
	private Struct23 method_21()
	{
		return (Struct23)(object)null;
	}

	[CompilerGenerated]
	private Struct24 method_22()
	{
		return (Struct24)(object)null;
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static Entity smethod_5()
	{
		return null;
	}
}
