using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace ns0;

internal static class Class72
{
	internal sealed class Class73 : IEquatable<Class73>
	{
		[CompilerGenerated]
		private readonly long long_0;

		[CompilerGenerated]
		private readonly uint uint_0;

		[CompilerGenerated]
		private readonly uint uint_1;

		private static Class73 class73_0;

		[CompilerGenerated]
		private Type egXAKrsDTrF
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Class73(long long_1, uint uint_2, uint uint_3)
		{
		}

		[SpecialName]
		[CompilerGenerated]
		public long method_0()
		{
			return 0L;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_1(long long_1)
		{
		}

		[SpecialName]
		[CompilerGenerated]
		public uint method_2()
		{
			return 0u;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_3(uint uint_2)
		{
		}

		[SpecialName]
		[CompilerGenerated]
		public uint method_4()
		{
			return 0u;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_5(uint uint_2)
		{
		}

		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[CompilerGenerated]
		private bool method_6(StringBuilder stringBuilder_0)
		{
			return true;
		}

		[CompilerGenerated]
		public static bool operator !=(Class73? class73_1, Class73? class73_2)
		{
			return true;
		}

		[CompilerGenerated]
		public static bool operator ==(Class73? class73_1, Class73? class73_2)
		{
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return 0;
		}

		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return true;
		}

		[CompilerGenerated]
		public bool Equals(Class73? other)
		{
			return true;
		}

		[CompilerGenerated]
		public Class73 method_7()
		{
			return null;
		}

		[CompilerGenerated]
		private Class73(Class73 class73_1)
		{
		}

		[CompilerGenerated]
		public void method_8(out long long_1, out uint uint_2, out uint uint_3)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class73 smethod_1()
		{
			return null;
		}

		static Class73()
		{
			Class200.smethod_34();
		}
	}

	internal sealed class Exception2 : InvalidOperationException
	{
		internal static Exception2 exception2_0;

		public Exception2(string string_0)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Exception2 smethod_1()
		{
			return null;
		}

		static Exception2()
		{
			Class200.smethod_34();
		}
	}

	internal interface Interface8
	{
		nint imethod_0(nint intptr_0);

		nint Start(nint process, nint entry, nint argument, out uint threadId);

		uint imethod_1(nint intptr_0, uint uint_0);

		bool imethod_2(nint intptr_0, out uint uint_0);

		bool imethod_3(nint intptr_0, nint intptr_1);

		bool Close(nint intptr_0);

		[SpecialName]
		int imethod_4();
	}

	private sealed class Class74 : Interface8
	{
		internal static Class74 class74_0;

		[SpecialName]
		public int imethod_4()
		{
			return 0;
		}

		public nint imethod_0(nint intptr_0)
		{
			return (nint)(object)null;
		}

		public nint Start(nint process, nint entry, nint argument, out uint threadId)
		{
			return (nint)(object)null;
		}

		public uint imethod_1(nint intptr_0, uint uint_0)
		{
			return 0u;
		}

		public bool imethod_2(nint intptr_0, out uint uint_0)
		{
			return true;
		}

		public bool imethod_3(nint intptr_0, nint intptr_1)
		{
			return true;
		}

		public bool Close(nint intptr_0)
		{
			return true;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class74 smethod_1()
		{
			return null;
		}

		static Class74()
		{
			Class200.smethod_34();
		}
	}

	internal static Class73 smethod_0(nint intptr_0, long long_0, string string_0, Func<long, long> func_0, uint uint_0 = 5000u, Interface8? native = null)
	{
		return null;
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern nint VirtualAllocEx(nint intptr_0, nint intptr_1, nuint uintptr_0, uint uint_0, uint uint_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern nint CreateRemoteThread(nint intptr_0, nint intptr_1, nuint uintptr_0, nint intptr_2, nint intptr_3, uint uint_0, out uint uint_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern uint WaitForSingleObject(nint intptr_0, uint uint_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool GetExitCodeThread(nint intptr_0, out uint uint_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool VirtualFreeEx(nint intptr_0, nint intptr_1, nuint uintptr_0, uint uint_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CloseHandle(nint intptr_0);

	static Class72()
	{
		Class200.smethod_34();
	}
}
