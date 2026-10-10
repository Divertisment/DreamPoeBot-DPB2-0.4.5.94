using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ns0;

namespace DreamPoeBot.Loki.FilesInMemory.Base;

public class UniversalFileWrapper<RecordType> where RecordType : RemoteMemoryObject, new()
{
	[CompilerGenerated]
	private sealed class _003CRecordAddresses_003Ed__16 : IEnumerable<long>, IEnumerable, IEnumerator<long>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private long _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public UniversalFileWrapper<RecordType> _003C_003E4__this;

		private int datalenght;

		public int _003C_003E3__datalenght;

		private long _003CfirstRec_003E5__2;

		private int _003Ccnt_003E5__3;

		private long _003CrecLen_003E5__4;

		private int _003Cdataoffset_003E5__5;

		private int _003Ci_003E5__6;

		internal static object object_0;

		long IEnumerator<long>.Current => 0L;

		object IEnumerator.Current => null;

		public _003CRecordAddresses_003Ed__16(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}

		IEnumerator<long> IEnumerable<long>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static object smethod_1()
		{
			return null;
		}

		static _003CRecordAddresses_003Ed__16()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private Dictionary<long, RecordType> dictionary_0;

	[CompilerGenerated]
	private List<RecordType> list_0;

	public readonly long Address;

	internal readonly Memory memory_0;

	internal static object object_0;

	protected Dictionary<long, RecordType> EntriesAddressDictionary
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	protected List<RecordType> CachedEntriesList
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public List<RecordType> EntriesList => null;

	public UniversalFileWrapper(Memory m, long address)
	{
	}

	public RecordType GetByAddress(long address)
	{
		return null;
	}

	public void CheckCache()
	{
	}

	private int method_0(int int_0)
	{
		return 0;
	}

	[IteratorStateMachine(typeof(UniversalFileWrapper<>._003CRecordAddresses_003Ed__16))]
	protected IEnumerable<long> RecordAddresses(int datalenght = 24)
	{
		return null;
	}

	protected virtual void EntryAdded(long addr, RecordType entry)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static object smethod_1()
	{
		return null;
	}

	static UniversalFileWrapper()
	{
		Class200.smethod_34();
	}
}
