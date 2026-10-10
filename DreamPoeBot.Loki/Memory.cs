using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using DreamPoeBot.Common;
using DreamPoeBot.Loki.Game.Std;
using log4net;
using ns0;

namespace DreamPoeBot.Loki;

[SuppressUnmanagedCodeSecurity]
public class Memory : IDisposable
{
	public struct ListDoublePointerIntNode
	{
		public long PreviousPtr;

		public long NextPtr;

		public long Ptr2_Key;

		public long Ptr1_Unused;

		public int Value;
	}

	private readonly ILog ilog_0;

	private int int_0;

	public readonly long AddressOfProcess;

	public readonly int SizeOfProcess;

	public readonly long EndOfProcess;

	private readonly Dictionary<string, int> dictionary_0;

	private bool bool_0;

	public Offsets offsets;

	public nint procHandle;

	public long procHandleAsLong;

	internal Class42 class42_0;

	[CompilerGenerated]
	private readonly Process process_0;

	public string DebugStr;

	internal static readonly Dictionary<string, int> dictionary_1;

	private static Memory memory_0;

	public Process Process
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public Memory(Offsets offs, int pId)
	{
	}

	public void Dispose()
	{
	}

	~Memory()
	{
	}

	public bool IsStaticMemoryLocation(long address)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public T Read<T>(long address) where T : unmanaged
	{
		return (T)null;
	}

	public int ReadInt(long addr)
	{
		return 0;
	}

	public int[] ReadArrayInt(long start, int count)
	{
		return null;
	}

	public int ReadInt(long addr, params long[] offsets)
	{
		return 0;
	}

	public float ReadFloat(long addr)
	{
		return 0f;
	}

	public long ReadLong(long addr)
	{
		return 0L;
	}

	public ulong method_0(long addr)
	{
		return 0uL;
	}

	public long ReadLong(long addr, params long[] offsets)
	{
		return 0L;
	}

	public uint ReadUInt(long addr)
	{
		return 0u;
	}

	public ushort method_1(long addr)
	{
		return 0;
	}

	public short ReadShort(long addr)
	{
		return 0;
	}

	public string ReadString(long addr, int length = 512, bool replaceNull = true)
	{
		return null;
	}

	internal static string smethod_0(string string_0)
	{
		return null;
	}

	public string ReadNativeString(long addr)
	{
		return null;
	}

	public NativeVector ReadNativeVector(long addr)
	{
		return (NativeVector)(object)null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public string ReadStringU(long addr, int length = 1024, bool replaceNull = true)
	{
		return null;
	}

	[Obsolete("See NewMode.ReadStringU instead")]
	internal string method_2(long long_0, int int_1 = 512, bool bool_1 = true)
	{
		return null;
	}

	public byte ReadByte(long addr)
	{
		return 0;
	}

	public sbyte method_3(long addr)
	{
		return 0;
	}

	public byte[] ReadBytes(long addr, int length)
	{
		return null;
	}

	private void method_4()
	{
	}

	[SuppressUnmanagedCodeSecurity]
	internal byte[] method_5(long long_0, int int_1)
	{
		return null;
	}

	[SuppressUnmanagedCodeSecurity]
	internal byte[] method_6(long long_0, int int_1)
	{
		return null;
	}

	[SuppressUnmanagedCodeSecurity]
	internal byte[] method_7(long long_0, int int_1)
	{
		return null;
	}

	[SuppressUnmanagedCodeSecurity]
	internal byte[] method_8(long long_0, int int_1)
	{
		return null;
	}

	[SuppressUnmanagedCodeSecurity]
	internal byte[] method_9(long long_0, int int_1)
	{
		return null;
	}

	[SuppressUnmanagedCodeSecurity]
	internal byte[] method_10(long long_0, int int_1)
	{
		return null;
	}

	[SuppressUnmanagedCodeSecurity]
	internal byte[] method_11(long long_0, int int_1)
	{
		return null;
	}

	[SuppressUnmanagedCodeSecurity]
	internal Dictionary<int, long> method_12(long long_0, uint uint_0)
	{
		return null;
	}

	[SuppressUnmanagedCodeSecurity]
	internal bool method_13(long long_0)
	{
		return true;
	}

	[SuppressUnmanagedCodeSecurity]
	internal bool method_14(long long_0)
	{
		return true;
	}

	public bool WriteVector2(long addr, Vector2 data)
	{
		return true;
	}

	public bool WriteVector2i(long addr, Vector2i data)
	{
		return true;
	}

	public bool WriteByte(long addr, byte data)
	{
		return true;
	}

	public bool WriteShort(long addr, short data)
	{
		return true;
	}

	public bool WriteInt(long addr, int data)
	{
		return true;
	}

	public bool WriteuInt(long addr, uint data)
	{
		return true;
	}

	public bool WriteFloat(long addr, float data)
	{
		return true;
	}

	public bool Writelong(long addr, long data)
	{
		return true;
	}

	public bool Writeulong(long addr, ulong data)
	{
		return true;
	}

	public bool WriteMem(long addr, byte[] data)
	{
		return true;
	}

	public List<T> ReadStructsArray<T>(long startAddress, long endAddress, int structSize, int maxCountLimit) where T : RemoteMemoryObject, new()
	{
		return null;
	}

	public Vector3 ReadVector3(long address)
	{
		return (Vector3)(object)null;
	}

	public Vector2 ReadVector2(long address)
	{
		return (Vector2)(object)null;
	}

	public Vector2i ReadVector2i(long address)
	{
		return (Vector2i)(object)null;
	}

	public List<T> ReadDoublePtrVectorClasses<T>(long address, bool noNullPointers = false) where T : RemoteMemoryObject, new()
	{
		return null;
	}

	public List<long> ReadPointersArray(long startAddress, long endAddress, int offset = 8)
	{
		return null;
	}

	public List<long> ReadFirstPointerArray_Count(long startAddress, int count)
	{
		return null;
	}

	public List<long> ReadSecondPointerArray_Count(long startAddress, int count)
	{
		return null;
	}

	public T[] IntptrToStructArray<T>(long start, int count, int structureSize) where T : unmanaged
	{
		return null;
	}

	public T IntptrToStruct<T>(byte[] data) where T : unmanaged
	{
		return (T)null;
	}

	public List<Tuple<long, int>> ReadDoublePointerIntList(long address)
	{
		return null;
	}

	private ListDoublePointerIntNode method_15(long long_0)
	{
		return (ListDoublePointerIntNode)(object)null;
	}

	public T GetObject<T>(long address) where T : RemoteMemoryObject, new()
	{
		return null;
	}

	internal T method_16<T>(long long_0, int int_1 = 0) where T : unmanaged
	{
		return (T)null;
	}

	static Memory()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		dictionary_1 = new Dictionary<string, int>();
	}

	internal static bool smethod_1()
	{
		return true;
	}

	internal static Memory smethod_2()
	{
		return null;
	}
}
