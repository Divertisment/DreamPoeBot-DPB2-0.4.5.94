using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace ns0;

internal static class Class75
{
	private sealed class Class76
	{
		[CompilerGenerated]
		private readonly int int_0;

		[CompilerGenerated]
		private readonly DateTime dateTime_0;

		[CompilerGenerated]
		private readonly Dictionary<string, byte[]> dictionary_0;

		[CompilerGenerated]
		private readonly string string_0;

		[CompilerGenerated]
		private readonly long long_0;

		[CompilerGenerated]
		private readonly DateTime dateTime_1;

		[CompilerGenerated]
		private readonly Dictionary<string, long> dictionary_1;

		private static Class76 class76_0;

		internal int ProcessId
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		private Class76(int int_1, DateTime dateTime_2, string string_1, long long_1, DateTime dateTime_3, Dictionary<string, long> dictionary_2, Dictionary<string, byte[]> dictionary_3)
		{
		}

		[SpecialName]
		[CompilerGenerated]
		internal DateTime method_0()
		{
			return (DateTime)(object)null;
		}

		[SpecialName]
		[CompilerGenerated]
		internal Dictionary<string, byte[]> method_1()
		{
			return null;
		}

		[SpecialName]
		[CompilerGenerated]
		internal string method_2()
		{
			return null;
		}

		[SpecialName]
		[CompilerGenerated]
		internal long method_3()
		{
			return 0L;
		}

		[SpecialName]
		[CompilerGenerated]
		internal DateTime method_4()
		{
			return (DateTime)(object)null;
		}

		[SpecialName]
		[CompilerGenerated]
		internal Dictionary<string, long> method_5()
		{
			return null;
		}

		internal static Class76 smethod_0(int int_1, DateTime dateTime_2, string string_1, int int_2, FileInfo fileInfo_0)
		{
			return null;
		}

		internal static bool smethod_1()
		{
			return true;
		}

		internal static Class76 smethod_2()
		{
			return null;
		}

		static Class76()
		{
			Class200.smethod_34();
		}
	}

	private sealed class Class77
	{
		private readonly struct Struct76 : IEquatable<Struct76>
		{
			[CompilerGenerated]
			private readonly int int_0;

			[CompilerGenerated]
			private readonly int int_1;

			[CompilerGenerated]
			private readonly int int_2;

			[CompilerGenerated]
			private readonly int int_3;

			[CompilerGenerated]
			private readonly uint uint_0;

			private static object object_0;

			public Struct76(int int_4, int int_5, int int_6, int int_7, uint uint_1)
			{
			}

			[SpecialName]
			[CompilerGenerated]
			public int method_0()
			{
				return 0;
			}

			[SpecialName]
			[CompilerGenerated]
			public void method_1(int int_4)
			{
			}

			[SpecialName]
			[CompilerGenerated]
			public int method_2()
			{
				return 0;
			}

			[SpecialName]
			[CompilerGenerated]
			public void method_3(int int_4)
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
			public void method_5(int int_4)
			{
			}

			[SpecialName]
			[CompilerGenerated]
			public int method_6()
			{
				return 0;
			}

			[SpecialName]
			[CompilerGenerated]
			public void method_7(int int_4)
			{
			}

			[SpecialName]
			[CompilerGenerated]
			public uint method_8()
			{
				return 0u;
			}

			[SpecialName]
			[CompilerGenerated]
			public void method_9(uint uint_1)
			{
			}

			[SpecialName]
			internal bool method_10()
			{
				return true;
			}

			[CompilerGenerated]
			public override string ToString()
			{
				return null;
			}

			[CompilerGenerated]
			private bool method_11(StringBuilder stringBuilder_0)
			{
				return true;
			}

			[CompilerGenerated]
			public static bool operator !=(Struct76 struct76_0, Struct76 struct76_1)
			{
				return true;
			}

			[CompilerGenerated]
			public static bool operator ==(Struct76 struct76_0, Struct76 struct76_1)
			{
				return true;
			}

			[CompilerGenerated]
			public override int GetHashCode()
			{
				return 0;
			}

			[CompilerGenerated]
			public override bool Equals(object obj)
			{
				return true;
			}

			[CompilerGenerated]
			public bool Equals(Struct76 other)
			{
				return true;
			}

			[CompilerGenerated]
			public void method_12(out int int_4, out int int_5, out int int_6, out int int_7, out uint uint_1)
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

			static Struct76()
			{
				Class200.smethod_34();
			}
		}

		[CompilerGenerated]
		private sealed class _003CFindRipRelativeLeaXrefs_003Ed__11 : IEnumerable<(string Path, int InstructionRva)>, IEnumerable, IEnumerator<(string Path, int InstructionRva)>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private (string Path, int InstructionRva) _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public Class77 _003C_003E4__this;

			private byte[] image;

			public byte[] _003C_003E3__image;

			private IReadOnlyDictionary<int, string[]> pathsByTargetRva;

			public IReadOnlyDictionary<int, string[]> _003C_003E3__pathsByTargetRva;

			private IEnumerator<Struct76> _003C_003E7__wrap1;

			private Struct76 _003Csection_003E5__3;

			private int _003Coffset_003E5__4;

			private int _003CinstructionRva_003E5__5;

			private string[] _003C_003E7__wrap5;

			private int _003C_003E7__wrap6;

			private static _003CFindRipRelativeLeaXrefs_003Ed__11 _003CFindRipRelativeLeaXrefs_003Ed__11_0;

			(string Path, int InstructionRva) IEnumerator<(string, int)>.Current => ((string Path, int InstructionRva))null;

			object IEnumerator.Current => null;

			public _003CFindRipRelativeLeaXrefs_003Ed__11(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			void IEnumerator.Reset()
			{
			}

			IEnumerator<(string Path, int InstructionRva)> IEnumerable<(string, int)>.GetEnumerator()
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

			internal static _003CFindRipRelativeLeaXrefs_003Ed__11 smethod_1()
			{
				return null;
			}

			static _003CFindRipRelativeLeaXrefs_003Ed__11()
			{
				Class200.smethod_34();
			}
		}

		private readonly byte[] byte_0;

		private readonly Struct76[] struct76_0;

		private readonly int int_0;

		private readonly int int_1;

		[CompilerGenerated]
		private readonly int int_2;

		internal static Class77 class77_0;

		private Class77(byte[] byte_1, Struct76[] struct76_1, int int_3, int int_4, int int_5)
		{
		}

		[SpecialName]
		[CompilerGenerated]
		internal int gofAmityPbh()
		{
			return 0;
		}

		internal static Class77 smethod_0(byte[] byte_1)
		{
			return null;
		}

		internal int? method_0(int int_3)
		{
			return null;
		}

		private int? method_1(int int_3)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CFindRipRelativeLeaXrefs_003Ed__11))]
		internal IEnumerable<(string, int)> method_2(byte[] byte_1, IReadOnlyDictionary<int, string[]> ireadOnlyDictionary_0)
		{
			return null;
		}

		internal int? method_3(int int_3)
		{
			return null;
		}

		internal byte[] method_4(int int_3)
		{
			return null;
		}

		private static ushort smethod_1(byte[] byte_1, int int_3)
		{
			return 0;
		}

		private static uint smethod_2(byte[] byte_1, int int_3)
		{
			return 0u;
		}

		private static int smethod_3(byte[] byte_1, int int_3)
		{
			return 0;
		}

		internal static bool smethod_4()
		{
			return true;
		}

		internal static Class77 smethod_5()
		{
			return null;
		}

		static Class77()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private sealed class _003CFindOccurrences_003Ed__7 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private int _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private byte[] haystack;

		public byte[] _003C_003E3__haystack;

		private byte[] needle;

		public byte[] _003C_003E3__needle;

		private int _003Cmatch_003E5__2;

		internal static _003CFindOccurrences_003Ed__7 _003CFindOccurrences_003Ed__7_0;

		int IEnumerator<int>.Current => 0;

		object IEnumerator.Current => null;

		public _003CFindOccurrences_003Ed__7(int _003C_003E1__state)
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

		IEnumerator<int> IEnumerable<int>.GetEnumerator()
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

		internal static _003CFindOccurrences_003Ed__7 smethod_1()
		{
			return null;
		}

		static _003CFindOccurrences_003Ed__7()
		{
			Class200.smethod_34();
		}
	}

	private static readonly object object_0;

	private static readonly string[] string_0;

	private static Class76 class76_0;

	private static Class75 class75_0;

	internal static long smethod_0(string string_1, Process process_0)
	{
		return 0L;
	}

	internal static long smethod_1(string string_1, Process process_0, Func<long, int, byte[]> func_0)
	{
		return 0L;
	}

	internal static IReadOnlyDictionary<string, long> smethod_2(string string_1)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CFindOccurrences_003Ed__7))]
	private static IEnumerable<int> smethod_3(byte[] byte_0, byte[] byte_1)
	{
		return null;
	}

	static Class75()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		object_0 = new object();
		string_0 = new string[14]
		{
			Class200.smethod_20(31992),
			Class200.smethod_20(32068),
			Class200.smethod_20(32146),
			Class200.smethod_20(32224),
			Class200.smethod_20(32306),
			Class200.smethod_20(32388),
			Class200.smethod_20(32482),
			Class200.smethod_20(32554),
			Class200.smethod_20(32634),
			Class200.smethod_20(32720),
			Class200.smethod_20(32802),
			Class200.smethod_20(32880),
			Class200.smethod_20(32956),
			Class200.smethod_20(33042)
		};
	}

	internal static bool smethod_4()
	{
		return true;
	}

	internal static Class75 smethod_5()
	{
		return null;
	}
}
