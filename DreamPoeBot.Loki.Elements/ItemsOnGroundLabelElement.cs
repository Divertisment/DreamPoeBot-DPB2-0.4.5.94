using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Game.Std;
using ns0;

namespace DreamPoeBot.Loki.Elements;

public class ItemsOnGroundLabelElement : Element
{
	[CompilerGenerated]
	private sealed class _003Cget_ChildrenDictionary_003Ed__25 : IEnumerable<KeyValuePair<int, ItemsOnGroundLabelElement>>, IEnumerable, IEnumerator<KeyValuePair<int, ItemsOnGroundLabelElement>>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private KeyValuePair<int, ItemsOnGroundLabelElement> _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public ItemsOnGroundLabelElement _003C_003E4__this;

		private NativeMap _003Cmap_003E5__2;

		private long _003Caddress_003E5__3;

		private int _003Ccount_003E5__4;

		private long _003CnextAddress_003E5__5;

		internal static _003Cget_ChildrenDictionary_003Ed__25 _003Cget_ChildrenDictionary_003Ed__25_0;

		KeyValuePair<int, ItemsOnGroundLabelElement> IEnumerator<KeyValuePair<int, ItemsOnGroundLabelElement>>.Current => (KeyValuePair<int, ItemsOnGroundLabelElement>)null;

		object IEnumerator.Current => null;

		public _003Cget_ChildrenDictionary_003Ed__25(int _003C_003E1__state)
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

		IEnumerator<KeyValuePair<int, ItemsOnGroundLabelElement>> IEnumerable<KeyValuePair<int, ItemsOnGroundLabelElement>>.GetEnumerator()
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

		internal static _003Cget_ChildrenDictionary_003Ed__25 smethod_1()
		{
			return null;
		}

		static _003Cget_ChildrenDictionary_003Ed__25()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private sealed class _003Cget_Labels_003Ed__21 : IEnumerable<ItemsOnGroundLabelElement>, IEnumerable, IEnumerator<ItemsOnGroundLabelElement>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private ItemsOnGroundLabelElement _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public ItemsOnGroundLabelElement _003C_003E4__this;

		private NativeMap _003Cmap_003E5__2;

		private long _003Caddress_003E5__3;

		private int _003Ccount_003E5__4;

		private long _003CnextAddress_003E5__5;

		internal static _003Cget_Labels_003Ed__21 _003Cget_Labels_003Ed__21_0;

		ItemsOnGroundLabelElement IEnumerator<ItemsOnGroundLabelElement>.Current => null;

		object IEnumerator.Current => null;

		public _003Cget_Labels_003Ed__21(int _003C_003E1__state)
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

		IEnumerator<ItemsOnGroundLabelElement> IEnumerable<ItemsOnGroundLabelElement>.GetEnumerator()
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

		internal static _003Cget_Labels_003Ed__21 smethod_1()
		{
			return null;
		}

		static _003Cget_Labels_003Ed__21()
		{
			Class200.smethod_34();
		}
	}

	private static long long_5;

	private readonly Lazy<long> lazy_0;

	public long _labelAddress;

	[Obsolete("Not in game anymore, use ItemOnGroundId, and retrieve it from the Object Manager by Id.", false)]
	public long _itemOnGroundAddress;

	public Element _labelElement;

	public int _itemOnGroundId;

	internal static ItemsOnGroundLabelElement itemsOnGroundLabelElement_0;

	public Element Label => null;

	public int ItemOnGroundId => 0;

	public bool CanPickUp => true;

	public TimeSpan TimeLeft => (TimeSpan)(object)null;

	public TimeSpan MaxTimeForPickUp => (TimeSpan)(object)null;

	public new bool IsVisible => true;

	public IEnumerable<ItemsOnGroundLabelElement> Labels
	{
		[IteratorStateMachine(typeof(_003Cget_Labels_003Ed__21))]
		get
		{
			return null;
		}
	}

	public Dictionary<int, ItemsOnGroundLabelElement> ChildrenDictionaryNew => null;

	public IEnumerable<KeyValuePair<int, ItemsOnGroundLabelElement>> ChildrenDictionary
	{
		[IteratorStateMachine(typeof(_003Cget_ChildrenDictionary_003Ed__25))]
		get
		{
			return null;
		}
	}

	public ItemsOnGroundLabelElement()
	{
	}

	public ItemsOnGroundLabelElement(long labelAddress, long itemOnGroundAddress, int itemOnGroundId)
	{
	}

	private long method_29()
	{
		return 0L;
	}

	static ItemsOnGroundLabelElement()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		long_5 = 1008L;
	}

	internal static bool smethod_11()
	{
		return true;
	}

	internal static ItemsOnGroundLabelElement smethod_12()
	{
		return null;
	}
}
