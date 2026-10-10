using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Common;
using log4net;
using ns0;

namespace DreamPoeBot.Loki;

public abstract class FileInMemory
{
	internal struct Struct28
	{
		internal long long_0;

		internal long long_1;
	}

	protected static readonly ILog Log;

	internal readonly Memory memory_0;

	private readonly Dictionary<long, Dictionary<long, int>> dictionary_0;

	[CompilerGenerated]
	private readonly string string_0;

	[CompilerGenerated]
	private readonly long long_0;

	private static FileInMemory fileInMemory_0;

	public string Filename
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	public long Address
	{
		[CompilerGenerated]
		get
		{
			return 0L;
		}
		[CompilerGenerated]
		protected init
		{
		}
	}

	protected internal FileInMemory(string fileName)
	{
	}

	protected internal FileInMemory(Memory m, string fileName)
	{
	}

	protected internal FileInMemory(Memory m, long address)
	{
	}

	private protected int? method_0(Struct28 struct28_0)
	{
		return null;
	}

	static FileInMemory()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		Log = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static FileInMemory smethod_1()
	{
		return null;
	}
}
public abstract class FileInMemory<TRecord> : FileInMemory
{
	private readonly Stopwatch stopwatch_0;

	private readonly int int_0;

	private readonly long long_1;

	private readonly long long_2;

	private readonly long long_3;

	private readonly long long_4;

	private readonly bool bool_0;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private long long_5;

	[CompilerGenerated]
	private TRecord[] gparam_0;

	[CompilerGenerated]
	private readonly int int_1;

	[CompilerGenerated]
	private Dictionary<long, TRecord> dictionary_1;

	private static object object_0;

	public bool IsValid
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
		[CompilerGenerated]
		private protected set
		{
		}
	}

	public long ApproxStructSize
	{
		[CompilerGenerated]
		get
		{
			return 0L;
		}
		[CompilerGenerated]
		private protected set
		{
		}
	}

	public TRecord[] Records
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

	public int RecordCount
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		init
		{
		}
	}

	public Dictionary<long, TRecord> RecordsByAddress
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

	private protected FileInMemory(Memory m, long address, int dataLength = 24, bool parallel = true)
	{
	}

	private protected FileInMemory()
	{
	}

	public TRecord? GetRecordByAddress(long address)
	{
		return (TRecord?)null;
	}

	private (T[], int) method_1<T>() where T : unmanaged
	{
		return ((T[], int))null;
	}

	private protected void method_2<T>(Func<T, long, int, TRecord> func_0) where T : unmanaged
	{
	}

	private protected abstract long vmethod_0(TRecord record);

	private protected virtual void vmethod_1()
	{
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static object smethod_3()
	{
		return null;
	}

	static FileInMemory()
	{
		Class200.smethod_34();
	}
}
