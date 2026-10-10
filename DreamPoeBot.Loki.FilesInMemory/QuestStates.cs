using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.RemoteMemoryObjects;
using ns0;

namespace DreamPoeBot.Loki.FilesInMemory;

public class QuestStates : FileInMemory
{
	[CompilerGenerated]
	private sealed class _003CRecordAddresses_003Ed__15 : IEnumerable<long>, IEnumerable, IEnumerator<long>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private long _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public QuestStates _003C_003E4__this;

		private long _003CfirstRec_003E5__2;

		private int _003Ccnt_003E5__3;

		private long _003CrecLen_003E5__4;

		private int _003Ci_003E5__5;

		private static _003CRecordAddresses_003Ed__15 _003CRecordAddresses_003Ed__15_0;

		long IEnumerator<long>.Current => 0L;

		object IEnumerator.Current => null;

		public _003CRecordAddresses_003Ed__15(int _003C_003E1__state)
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

		internal static _003CRecordAddresses_003Ed__15 smethod_1()
		{
			return null;
		}

		static _003CRecordAddresses_003Ed__15()
		{
			Class200.smethod_34();
		}
	}

	private Dictionary<string, Dictionary<int, QuestState>> dictionary_1;

	[CompilerGenerated]
	private Dictionary<long, QuestState> dictionary_2;

	[CompilerGenerated]
	private List<QuestState> list_0;

	internal static QuestStates questStates_0;

	protected Dictionary<long, QuestState> EntriesAddressDictionary
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

	protected List<QuestState> CachedEntriesList
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

	public List<QuestState> EntriesList => null;

	public QuestStates(Memory m, long address)
	{
	}

	public QuestState GetQuestState(string questId, int stateId)
	{
		return null;
	}

	public void CheckCache()
	{
	}

	protected virtual void EntryAdded(long addr, QuestState entry)
	{
	}

	[IteratorStateMachine(typeof(_003CRecordAddresses_003Ed__15))]
	protected IEnumerable<long> RecordAddresses()
	{
		return null;
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static QuestStates smethod_3()
	{
		return null;
	}

	static QuestStates()
	{
		Class200.smethod_34();
	}
}
