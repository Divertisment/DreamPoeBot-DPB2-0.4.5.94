using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace ns0;

internal class Class200
{
	private class Class201
	{
	}

	internal class Class202
	{
		private BinaryReader binaryReader_0;

		public Class202(Stream stream_0)
		{
			binaryReader_0 = new BinaryReader(stream_0);
		}

		[SpecialName]
		internal Stream method_0()
		{
			return binaryReader_0.BaseStream;
		}

		internal byte[] method_1(int int_0)
		{
			return binaryReader_0.ReadBytes(int_0);
		}

		internal int method_2(byte[] byte_0, int int_0, int int_1)
		{
			return binaryReader_0.Read(byte_0, int_0, int_1);
		}

		internal int method_3()
		{
			return binaryReader_0.ReadInt32();
		}

		internal void method_4()
		{
			binaryReader_0.Close();
		}
	}

	private delegate void Delegate3(object o);

	internal class Class203
	{
		internal static string smethod_0(string string_0, string string_1)
		{
			return null;
		}
	}

	internal struct Struct293
	{
		internal int int_0;

		internal nint intptr_0;

		internal nint intptr_1;
	}

	private struct Struct294
	{
		public nuint uintptr_0;

		public nuint uintptr_1;

		public uint uint_0;

		public nint intptr_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct295
	{
		public nint intptr_0;

		public nint intptr_1;

		public nint intptr_2;

		public int int_0;
	}

	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	internal delegate uint Delegate4(nint classthis, nint comp, ref Struct295 info, [MarshalAs(UnmanagedType.U4)] uint flags, nint nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint Delegate5(nint classthis, nint comp, ref Struct295 info, [MarshalAs(UnmanagedType.U4)] uint flags, nint nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate nint Delegate6();

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate7(nint lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate nint Delegate8(nint lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate nuint Delegate9(nuint lpAddress, out Struct294 mbi, nuint dwLength);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate nint Delegate10(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate11(nint hProcess, nint lpBaseAddress, [In][Out] byte[] buffer, uint size, out nint lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate12(nint ptr);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate nint Delegate13(nint addr, nint length, int prot, int flags, int fd, nint offset);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate14(nint start, nint len, int mprot);

	[Flags]
	private enum Enum21
	{

	}

	private static byte[] byte_0;

	private static List<string> list_0;

	private static List<int> list_1;

	private static int int_0;

	private static Delegate13 delegate13_0;

	private static Delegate13 delegate13_1;

	private static Delegate5 delegate5_0;

	private static bool bool_0;

	private static bool bool_1;

	private static bool bool_2;

	private static Delegate9 delegate9_0;

	private static Delegate11 delegate11_0;

	private static int int_1;

	private static int int_2;

	private static Assembly assembly_0;

	private static int int_3;

	private static nint xWepxmuymUl;

	private static nint intptr_0;

	private static bool bool_3;

	private static object object_0;

	private static nint intptr_1;

	internal static Delegate5 delegate5_1;

	private static bool bool_4;

	internal static Delegate4 delegate4_0;

	private static byte[] byte_1;

	private static Delegate4 delegate4_1;

	private static Delegate10 YcZpxhitaaL;

	private static bool bool_5;

	private static bool bool_6;

	private static object object_1;

	internal static Hashtable hashtable_0;

	private static uint[] lkypxqhIuak;

	private static Delegate7 delegate7_0;

	private byte[] byte_2;

	private static bool bool_7;

	private static Dictionary<int, int> dictionary_0;

	private byte[] byte_3;

	private static RSACryptoServiceProvider rsacryptoServiceProvider_0;

	internal static Delegate5 delegate5_2;

	internal static Delegate4 delegate4_2;

	private static bool bool_8;

	private static Delegate8 delegate8_0;

	private static Delegate12 delegate12_0;

	static Class200()
	{
		intptr_0 = IntPtr.Zero;
		delegate4_0 = null;
		delegate5_1 = null;
		delegate4_2 = null;
		delegate5_2 = null;
		bool_8 = false;
		bool_4 = false;
		hashtable_0 = new Hashtable();
		xWepxmuymUl = IntPtr.Zero;
		delegate7_0 = null;
		delegate8_0 = null;
		delegate9_0 = null;
		YcZpxhitaaL = null;
		delegate11_0 = null;
		delegate12_0 = null;
		delegate13_0 = null;
		delegate13_1 = null;
		int_2 = -1;
		bool_2 = false;
		bool_7 = false;
		bool_5 = false;
		intptr_1 = IntPtr.Zero;
		delegate4_1 = null;
		delegate5_0 = null;
		bool_0 = false;
		int_1 = -2;
		int_3 = 0;
		bool_1 = false;
		lkypxqhIuak = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		bool_3 = false;
		bool_6 = false;
		dictionary_0 = null;
		object_1 = new object();
		assembly_0 = typeof(Class200).Assembly;
		byte_1 = new byte[0];
		rsacryptoServiceProvider_0 = null;
		byte_0 = new byte[0];
		object_0 = new object();
		list_0 = null;
		list_1 = null;
		int_0 = 0;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	internal Class200()
	{
	}

	private void method_0()
	{
	}

	internal static byte[] smethod_0(byte[] byte_4)
	{
		uint[] array = new uint[16];
		uint num = (uint)((448 - byte_4.Length * 8 % 512 + 512) % 512);
		if (num == 0)
		{
			num = 512u;
		}
		uint num2 = (uint)(byte_4.Length + num / 8 + 8L);
		ulong num3 = (ulong)(byte_4.Length * 8L);
		byte[] array2 = new byte[num2];
		for (int i = 0; i < byte_4.Length; i++)
		{
			array2[i] = byte_4[i];
		}
		array2[byte_4.Length] |= 128;
		for (int num4 = 8; num4 > 0; num4--)
		{
			array2[num2 - num4] = (byte)((num3 >> (8 - num4) * 8) & 0xFFL);
		}
		uint num5 = (uint)(array2.Length * 8) / 32u;
		uint uint_ = 1732584193u;
		uint uint_2 = 4023233417u;
		uint uint_3 = 2562383102u;
		uint uint_4 = 271733878u;
		for (uint num6 = 0u; num6 < num5 / 16; num6++)
		{
			uint num7 = num6 << 6;
			for (uint num8 = 0u; num8 < 61; num8 += 4)
			{
				array[num8 >> 2] = (uint)((array2[num7 + (num8 + 3)] << 24) | (array2[num7 + (num8 + 2)] << 16) | (array2[num7 + (num8 + 1)] << 8) | array2[num7 + num8]);
			}
			uint num9 = uint_;
			uint num10 = uint_2;
			uint num11 = uint_3;
			uint num12 = uint_4;
			smethod_1(ref uint_, uint_2, uint_3, uint_4, 0u, 7, 1u, array);
			smethod_1(ref uint_4, uint_, uint_2, uint_3, 1u, 12, 2u, array);
			smethod_1(ref uint_3, uint_4, uint_, uint_2, 2u, 17, 3u, array);
			smethod_1(ref uint_2, uint_3, uint_4, uint_, 3u, 22, 4u, array);
			smethod_1(ref uint_, uint_2, uint_3, uint_4, 4u, 7, 5u, array);
			smethod_1(ref uint_4, uint_, uint_2, uint_3, 5u, 12, 6u, array);
			smethod_1(ref uint_3, uint_4, uint_, uint_2, 6u, 17, 7u, array);
			smethod_1(ref uint_2, uint_3, uint_4, uint_, 7u, 22, 8u, array);
			smethod_1(ref uint_, uint_2, uint_3, uint_4, 8u, 7, 9u, array);
			smethod_1(ref uint_4, uint_, uint_2, uint_3, 9u, 12, 10u, array);
			smethod_1(ref uint_3, uint_4, uint_, uint_2, 10u, 17, 11u, array);
			smethod_1(ref uint_2, uint_3, uint_4, uint_, 11u, 22, 12u, array);
			smethod_1(ref uint_, uint_2, uint_3, uint_4, 12u, 7, 13u, array);
			smethod_1(ref uint_4, uint_, uint_2, uint_3, 13u, 12, 14u, array);
			smethod_1(ref uint_3, uint_4, uint_, uint_2, 14u, 17, 15u, array);
			smethod_1(ref uint_2, uint_3, uint_4, uint_, 15u, 22, 16u, array);
			smethod_2(ref uint_, uint_2, uint_3, uint_4, 1u, 5, 17u, array);
			smethod_2(ref uint_4, uint_, uint_2, uint_3, 6u, 9, 18u, array);
			smethod_2(ref uint_3, uint_4, uint_, uint_2, 11u, 14, 19u, array);
			smethod_2(ref uint_2, uint_3, uint_4, uint_, 0u, 20, 20u, array);
			smethod_2(ref uint_, uint_2, uint_3, uint_4, 5u, 5, 21u, array);
			smethod_2(ref uint_4, uint_, uint_2, uint_3, 10u, 9, 22u, array);
			smethod_2(ref uint_3, uint_4, uint_, uint_2, 15u, 14, 23u, array);
			smethod_2(ref uint_2, uint_3, uint_4, uint_, 4u, 20, 24u, array);
			smethod_2(ref uint_, uint_2, uint_3, uint_4, 9u, 5, 25u, array);
			smethod_2(ref uint_4, uint_, uint_2, uint_3, 14u, 9, 26u, array);
			smethod_2(ref uint_3, uint_4, uint_, uint_2, 3u, 14, 27u, array);
			smethod_2(ref uint_2, uint_3, uint_4, uint_, 8u, 20, 28u, array);
			smethod_2(ref uint_, uint_2, uint_3, uint_4, 13u, 5, 29u, array);
			smethod_2(ref uint_4, uint_, uint_2, uint_3, 2u, 9, 30u, array);
			smethod_2(ref uint_3, uint_4, uint_, uint_2, 7u, 14, 31u, array);
			smethod_2(ref uint_2, uint_3, uint_4, uint_, 12u, 20, 32u, array);
			smethod_3(ref uint_, uint_2, uint_3, uint_4, 5u, 4, 33u, array);
			smethod_3(ref uint_4, uint_, uint_2, uint_3, 8u, 11, 34u, array);
			smethod_3(ref uint_3, uint_4, uint_, uint_2, 11u, 16, 35u, array);
			smethod_3(ref uint_2, uint_3, uint_4, uint_, 14u, 23, 36u, array);
			smethod_3(ref uint_, uint_2, uint_3, uint_4, 1u, 4, 37u, array);
			smethod_3(ref uint_4, uint_, uint_2, uint_3, 4u, 11, 38u, array);
			smethod_3(ref uint_3, uint_4, uint_, uint_2, 7u, 16, 39u, array);
			smethod_3(ref uint_2, uint_3, uint_4, uint_, 10u, 23, 40u, array);
			smethod_3(ref uint_, uint_2, uint_3, uint_4, 13u, 4, 41u, array);
			smethod_3(ref uint_4, uint_, uint_2, uint_3, 0u, 11, 42u, array);
			smethod_3(ref uint_3, uint_4, uint_, uint_2, 3u, 16, 43u, array);
			smethod_3(ref uint_2, uint_3, uint_4, uint_, 6u, 23, 44u, array);
			smethod_3(ref uint_, uint_2, uint_3, uint_4, 9u, 4, 45u, array);
			smethod_3(ref uint_4, uint_, uint_2, uint_3, 12u, 11, 46u, array);
			smethod_3(ref uint_3, uint_4, uint_, uint_2, 15u, 16, 47u, array);
			smethod_3(ref uint_2, uint_3, uint_4, uint_, 2u, 23, 48u, array);
			smethod_4(ref uint_, uint_2, uint_3, uint_4, 0u, 6, 49u, array);
			smethod_4(ref uint_4, uint_, uint_2, uint_3, 7u, 10, 50u, array);
			smethod_4(ref uint_3, uint_4, uint_, uint_2, 14u, 15, 51u, array);
			smethod_4(ref uint_2, uint_3, uint_4, uint_, 5u, 21, 52u, array);
			smethod_4(ref uint_, uint_2, uint_3, uint_4, 12u, 6, 53u, array);
			smethod_4(ref uint_4, uint_, uint_2, uint_3, 3u, 10, 54u, array);
			smethod_4(ref uint_3, uint_4, uint_, uint_2, 10u, 15, 55u, array);
			smethod_4(ref uint_2, uint_3, uint_4, uint_, 1u, 21, 56u, array);
			smethod_4(ref uint_, uint_2, uint_3, uint_4, 8u, 6, 57u, array);
			smethod_4(ref uint_4, uint_, uint_2, uint_3, 15u, 10, 58u, array);
			smethod_4(ref uint_3, uint_4, uint_, uint_2, 6u, 15, 59u, array);
			smethod_4(ref uint_2, uint_3, uint_4, uint_, 13u, 21, 60u, array);
			smethod_4(ref uint_, uint_2, uint_3, uint_4, 4u, 6, 61u, array);
			smethod_4(ref uint_4, uint_, uint_2, uint_3, 11u, 10, 62u, array);
			smethod_4(ref uint_3, uint_4, uint_, uint_2, 2u, 15, 63u, array);
			smethod_4(ref uint_2, uint_3, uint_4, uint_, 9u, 21, 64u, array);
			uint_ += num9;
			uint_2 += num10;
			uint_3 += num11;
			uint_4 += num12;
		}
		byte[] array3 = new byte[16];
		Array.Copy(BitConverter.GetBytes(uint_), 0, array3, 0, 4);
		Array.Copy(BitConverter.GetBytes(uint_2), 0, array3, 4, 4);
		Array.Copy(BitConverter.GetBytes(uint_3), 0, array3, 8, 4);
		Array.Copy(BitConverter.GetBytes(uint_4), 0, array3, 12, 4);
		return array3;
	}

	private static void smethod_1(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + smethod_5(uint_0 + ((uint_1 & uint_2) | (~uint_1 & uint_3)) + uint_6[uint_4] + lkypxqhIuak[uint_5 - 1], ushort_0);
	}

	private static void smethod_2(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + smethod_5(uint_0 + ((uint_1 & uint_3) | (uint_2 & ~uint_3)) + uint_6[uint_4] + lkypxqhIuak[uint_5 - 1], ushort_0);
	}

	private static void smethod_3(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + smethod_5(uint_0 + (uint_1 ^ uint_2 ^ uint_3) + uint_6[uint_4] + lkypxqhIuak[uint_5 - 1], ushort_0);
	}

	private static void smethod_4(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + smethod_5(uint_0 + (uint_2 ^ (uint_1 | ~uint_3)) + uint_6[uint_4] + lkypxqhIuak[uint_5 - 1], ushort_0);
	}

	private static uint smethod_5(uint uint_0, ushort ushort_0)
	{
		return (uint_0 >> 32 - ushort_0) | (uint_0 << (int)ushort_0);
	}

	internal static byte[] smethod_6(byte[] byte_4)
	{
		if (!smethod_8())
		{
			return new MD5CryptoServiceProvider().ComputeHash(byte_4);
		}
		return smethod_0(byte_4);
	}

	private static void smethod_7()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	internal static bool smethod_8()
	{
		if (!bool_3)
		{
			smethod_10();
			bool_3 = true;
		}
		return bool_6;
	}

	internal byte[] method_1()
	{
		_ = "8yKfQATyyFtpbJe336XUve".Length;
		return new byte[2] { 1, 2 };
	}

	internal byte[] method_2()
	{
		_ = "pdgWpAYcDNLkUoqkT4M61".Length;
		return new byte[2] { 1, 2 };
	}

	internal byte[] method_3()
	{
		_ = "oxZmpcPjJPNWEajhAm30".Length;
		return new byte[2] { 1, 2 };
	}

	internal byte[] method_4()
	{
		_ = "RPThEI8GYJpzpQZgPWHZ7".Length;
		return new byte[2] { 1, 2 };
	}

	private static int smethod_9()
	{
		return 5;
	}

	internal static void smethod_10()
	{
		try
		{
			new MD5CryptoServiceProvider();
		}
		catch
		{
			bool_6 = true;
			return;
		}
		try
		{
			bool_6 = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static SymmetricAlgorithm smethod_11()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (smethod_8())
		{
			return new AesCryptoServiceProvider();
		}
		try
		{
			return new RijndaelManaged();
		}
		catch
		{
			return new AesCryptoServiceProvider();
		}
	}

	private byte[] TkEpDcNbuQl()
	{
		_ = "OIjDYyBjUf1gnXn2lfZ".Length;
		return new byte[2] { 1, 2 };
	}

	private byte[] method_5()
	{
		_ = "hjElRKLYTZbBDb8e".Length;
		return new byte[2] { 1, 2 };
	}

	internal static void smethod_12(HashAlgorithm hashAlgorithm_0, Stream stream_0, uint uint_0, byte[] byte_4)
	{
		while (uint_0 != 0)
		{
			int num = ((uint_0 > (uint)byte_4.Length) ? byte_4.Length : ((int)uint_0));
			stream_0.Read(byte_4, 0, num);
			smethod_13(hashAlgorithm_0, byte_4, 0, num);
			uint_0 -= (uint)num;
		}
	}

	internal static void smethod_13(HashAlgorithm hashAlgorithm_0, byte[] byte_4, int int_4, int int_5)
	{
		hashAlgorithm_0.TransformBlock(byte_4, int_4, int_5, byte_4, int_4);
	}

	internal static uint smethod_14(uint uint_0, int int_4, long long_0, BinaryReader binaryReader_0)
	{
		int num = 0;
		uint num3;
		uint num4;
		while (true)
		{
			if (num < int_4)
			{
				binaryReader_0.BaseStream.Position = long_0 + (num * 40 + 8);
				uint num2 = binaryReader_0.ReadUInt32();
				num3 = binaryReader_0.ReadUInt32();
				binaryReader_0.ReadUInt32();
				num4 = binaryReader_0.ReadUInt32();
				if (num3 <= uint_0 && uint_0 < num3 + num2)
				{
					break;
				}
				num++;
				continue;
			}
			return 0u;
		}
		return num4 + uint_0 - num3;
	}

	private static Stream smethod_15()
	{
		return new MemoryStream();
	}

	private static byte[] smethod_16(string string_0)
	{
		using FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.Read);
		int num = 0;
		int num2 = (int)fileStream.Length;
		byte[] array = new byte[num2];
		while (num2 > 0)
		{
			int num3 = fileStream.Read(array, num, num2);
			num += num3;
			num2 -= num3;
		}
		return array;
	}

	internal static object smethod_17(Assembly assembly_1)
	{
		try
		{
			if (File.Exists(assembly_1.Location))
			{
				return assembly_1.Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(assembly_1.GetName().CodeBase.ToString().Replace("file:///", "")))
			{
				return assembly_1.GetName().CodeBase.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(assembly_1.GetType().GetProperty("Location").GetValue(assembly_1, new object[0])
				.ToString()))
			{
				return assembly_1.GetType().GetProperty("Location").GetValue(assembly_1, new object[0])
					.ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	private static byte[] smethod_18(Stream stream_0)
	{
		return ((MemoryStream)stream_0).ToArray();
	}

	internal byte[] method_6()
	{
		return null;
	}

	internal byte[] method_7()
	{
		return null;
	}

	private static void smethod_19(Stream stream_0)
	{
		using BinaryReader binaryReader = new BinaryReader(stream_0);
		binaryReader.BaseStream.Position = 0L;
		byte[] byte_ = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
		byte[] array = new byte[32];
		array[0] = 162;
		array[0] = 142;
		array[0] = 92;
		array[0] = 41;
		array[1] = 113;
		array[1] = 14;
		array[1] = 181;
		array[2] = 109;
		array[2] = 147;
		array[2] = 239;
		array[3] = 123;
		array[3] = 116;
		array[3] = 209;
		array[3] = 37;
		array[4] = 162;
		array[4] = 190;
		array[4] = 120;
		array[4] = 175;
		array[4] = 110;
		array[4] = 107;
		array[5] = 150;
		array[5] = 98;
		array[5] = 154;
		array[5] = 18;
		array[5] = 215;
		array[6] = 129;
		array[6] = 109;
		array[6] = 173;
		array[6] = 75;
		array[7] = 108;
		array[7] = 97;
		array[7] = 178;
		array[7] = 122;
		array[8] = 109;
		array[8] = 130;
		array[8] = 127;
		array[8] = 92;
		array[8] = 105;
		array[9] = 118;
		array[9] = 127;
		array[9] = 148;
		array[10] = 188;
		array[10] = 107;
		array[10] = 104;
		array[10] = 84;
		array[10] = 158;
		array[11] = 147;
		array[11] = 145;
		array[11] = 213;
		array[11] = 160;
		array[11] = 156;
		array[11] = 180;
		array[12] = 129;
		array[12] = 209;
		array[12] = 128;
		array[12] = 87;
		array[13] = 128;
		array[13] = 82;
		array[13] = 71;
		array[13] = 156;
		array[13] = 26;
		array[14] = 133;
		array[14] = 123;
		array[14] = 164;
		array[14] = 237;
		array[14] = 48;
		array[15] = 121;
		array[15] = 142;
		array[15] = 71;
		array[16] = 128;
		array[16] = 164;
		array[16] = 198;
		array[17] = 118;
		array[17] = 51;
		array[17] = 164;
		array[17] = 154;
		array[17] = 120;
		array[17] = 72;
		array[18] = 156;
		array[18] = 93;
		array[18] = 184;
		array[19] = 146;
		array[19] = 182;
		array[19] = 169;
		array[19] = 108;
		array[19] = 3;
		array[20] = 64;
		array[20] = 164;
		array[20] = 126;
		array[20] = 182;
		array[21] = 138;
		array[21] = 159;
		array[21] = 99;
		array[21] = 141;
		array[21] = 58;
		array[22] = 159;
		array[22] = 102;
		array[22] = 140;
		array[22] = 219;
		array[22] = 121;
		array[23] = 144;
		array[23] = 226;
		array[23] = 142;
		array[23] = 185;
		array[23] = 134;
		array[23] = 181;
		array[24] = 115;
		array[24] = 112;
		array[24] = 170;
		array[24] = 157;
		array[24] = 208;
		array[25] = 188;
		array[25] = 89;
		array[25] = 164;
		array[25] = 134;
		array[25] = 86;
		array[26] = 169;
		array[26] = 226;
		array[26] = 154;
		array[26] = 121;
		array[26] = 62;
		array[26] = 120;
		array[27] = 126;
		array[27] = 41;
		array[27] = 164;
		array[27] = 208;
		array[27] = 115;
		array[27] = 243;
		array[28] = 124;
		array[28] = 117;
		array[28] = 120;
		array[28] = 154;
		array[28] = 199;
		array[28] = 18;
		array[29] = 152;
		array[29] = 161;
		array[29] = 30;
		array[30] = 71;
		array[30] = 112;
		array[30] = 146;
		array[30] = 146;
		array[30] = 99;
		array[30] = 62;
		array[31] = 149;
		array[31] = 120;
		array[31] = 40;
		array[31] = 154;
		byte[] array2 = new byte[16];
		array2[0] = 132;
		array2[0] = 102;
		array2[0] = 129;
		array2[0] = 227;
		array2[0] = 105;
		array2[0] = 99;
		array2[1] = 116;
		array2[1] = 102;
		array2[1] = 79;
		array2[1] = 168;
		array2[1] = 127;
		array2[1] = 221;
		array2[2] = 126;
		array2[2] = 178;
		array2[2] = 139;
		array2[2] = 47;
		array2[3] = 98;
		array2[3] = 187;
		array2[3] = 10;
		array2[4] = 137;
		array2[4] = 146;
		array2[4] = 116;
		array2[5] = 104;
		array2[5] = 86;
		array2[5] = 142;
		array2[5] = 59;
		array2[5] = 180;
		array2[6] = 155;
		array2[6] = 137;
		array2[6] = 154;
		array2[6] = 99;
		array2[6] = 217;
		array2[7] = 101;
		array2[7] = 106;
		array2[7] = 164;
		array2[7] = 152;
		array2[7] = 104;
		array2[7] = 214;
		array2[8] = 161;
		array2[8] = 110;
		array2[8] = 167;
		array2[8] = 158;
		array2[8] = 197;
		array2[9] = 116;
		array2[9] = 98;
		array2[9] = 105;
		array2[9] = 113;
		array2[9] = 104;
		array2[9] = 11;
		array2[10] = 130;
		array2[10] = 157;
		array2[10] = 130;
		array2[10] = 34;
		array2[10] = 114;
		array2[11] = 63;
		array2[11] = 148;
		array2[11] = 163;
		array2[11] = 196;
		array2[11] = 113;
		array2[11] = 46;
		array2[12] = 63;
		array2[12] = 52;
		array2[12] = 111;
		array2[12] = 117;
		array2[12] = 93;
		array2[12] = 229;
		array2[13] = 122;
		array2[13] = 109;
		array2[13] = 128;
		array2[13] = 48;
		array2[14] = 126;
		array2[14] = 128;
		array2[14] = 175;
		array2[14] = 238;
		array2[15] = 162;
		array2[15] = 96;
		array2[15] = 51;
		byte[] byte_2 = array2;
		if (assembly_0.EntryPoint == null)
		{
			int_0 = 80;
		}
		byte_0 = new Class200(array, byte_2).method_8(byte_);
	}

	internal static string smethod_20(int int_4)
	{
		if (byte_0.Length == 0)
		{
			list_0 = new List<string>();
			list_1 = new List<int>();
			smethod_19(typeof(Class200).GetTypeInfo().Assembly.GetManifestResourceStream("TQxpWUA8uDOIGSCie5.tpOAamlWofbME7fGTC"));
			Class204.smethod_0();
		}
		if (int_0 < 75)
		{
			MethodBase method = new StackFrame(1).GetMethod();
			if (assembly_0 != method.DeclaringType.Assembly)
			{
				bool flag = false;
				string name = method.DeclaringType.Assembly.GetName().Name;
				AssemblyName[] referencedAssemblies = assembly_0.GetReferencedAssemblies();
				foreach (AssemblyName assemblyName in referencedAssemblies)
				{
					if (name == assemblyName.Name)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					throw new Exception();
				}
			}
			int_0++;
		}
		lock (object_0)
		{
			int num = BitConverter.ToInt32(byte_0, int_4);
			if (num < list_1.Count && list_1[num] == int_4)
			{
				return list_0[num];
			}
			try
			{
				byte[] array = new byte[num];
				Array.Copy(byte_0, int_4 + 4, array, 0, num);
				string text = Encoding.Unicode.GetString(array, 0, array.Length);
				list_0.Add(text);
				list_1.Add(int_4);
				Array.Copy(BitConverter.GetBytes(list_0.Count - 1), 0, byte_0, int_4, 4);
				return text;
			}
			catch
			{
			}
		}
		return "";
	}

	private Class200(byte[] byte_4, byte[] byte_5)
	{
		byte_2 = byte_4;
		byte_3 = byte_5;
	}

	private byte[] method_8(byte[] byte_4)
	{
		if (byte_4.Length == 0)
		{
			return new byte[0];
		}
		int num = byte_4.Length % 4;
		int num2 = byte_4.Length / 4;
		byte[] array = new byte[byte_4.Length];
		int num3 = byte_2.Length / 4;
		uint num4 = 0u;
		uint num5 = 0u;
		uint num6 = 0u;
		if (num > 0)
		{
			num2++;
		}
		uint num7 = 0u;
		for (int i = 0; i < num2; i++)
		{
			int num8 = i % num3;
			int num9 = i * 4;
			num7 = (uint)(num8 * 4);
			num5 = (uint)((byte_2[num7 + 3] << 24) | (byte_2[num7 + 2] << 16) | (byte_2[num7 + 1] << 8) | byte_2[num7]);
			if (i == num2 - 1 && num > 0)
			{
				num6 = 0u;
				uint num10 = 255u;
				int num11 = 0;
				for (int j = 0; j < num; j++)
				{
					if (j > 0)
					{
						num6 <<= 8;
					}
					num6 |= byte_4[^(1 + j)];
				}
				num4 += num5;
				num4 += method_9(num4);
				uint num12 = num4 ^ num6;
				for (int k = 0; k < num; k++)
				{
					if (k > 0)
					{
						num10 <<= 8;
						num11 += 8;
					}
					array[num9 + k] = (byte)((num12 & num10) >> num11);
				}
			}
			else
			{
				num7 = (uint)num9;
				num6 = (uint)((byte_4[num7 + 3] << 24) | (byte_4[num7 + 2] << 16) | (byte_4[num7 + 1] << 8) | byte_4[num7]);
				num4 += num5;
				num4 += method_9(num4);
				uint num13 = num4 ^ num6;
				array[num9] = (byte)(num13 & 0xFF);
				array[num9 + 1] = (byte)((num13 & 0xFF00) >> 8);
				array[num9 + 2] = (byte)((num13 & 0xFF0000) >> 16);
				array[num9 + 3] = (byte)((num13 & 0xFF000000u) >> 24);
			}
		}
		return array;
	}

	private uint method_9(uint uint_0)
	{
		uint num = uint_0;
		num ^= num << 3;
		num += 3302414041u;
		num ^= num << 11;
		num += 2323220752u;
		num ^= num >> 27;
		num += 1568112929;
		return 319228767 - num;
	}

	internal static string smethod_21(string string_0)
	{
		"kpgXvF48ENe6eBu".Trim();
		byte[] array = Convert.FromBase64String(string_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static byte[] qxypDvAhFr5(byte[] byte_4)
	{
		return new Class200(new byte[32]
		{
			123, 5, 74, 12, 244, 156, 221, 154, 121, 221,
			183, 41, 121, 65, 9, 43, 67, 81, 23, 43,
			74, 63, 64, 23, 95, 185, 226, 244, 45, 194,
			211, 43
		}, new byte[16]
		{
			117, 254, 41, 121, 65, 52, 9, 43, 221, 154,
			12, 54, 68, 241, 68, 66
		}).method_8(byte_4);
	}

	private byte[] method_10()
	{
		return null;
	}

	private byte[] method_11()
	{
		return null;
	}

	[SpecialName]
	private static nint smethod_22()
	{
		if (intptr_0 == IntPtr.Zero)
		{
			intptr_0 = LoadLibrary("kernel ".Trim() + "32.dll");
		}
		return intptr_0;
	}

	private static int mllpDzdfXoh(nint intptr_2, int int_4, int int_5, ref int int_6)
	{
		if (delegate7_0 == null)
		{
			delegate7_0 = (Delegate7)Marshal.GetDelegateForFunctionPointer(GetProcAddress(smethod_22(), "Virtual ".Trim() + "Protect"), typeof(Delegate7));
		}
		return delegate7_0(intptr_2, int_4, int_5, ref int_6);
	}

	private static nint smethod_23(nint intptr_2, uint uint_0, uint uint_1, uint uint_2)
	{
		if (delegate8_0 == null)
		{
			delegate8_0 = (Delegate8)Marshal.GetDelegateForFunctionPointer(GetProcAddress(smethod_22(), "Virtual ".Trim() + "Alloc"), typeof(Delegate8));
		}
		return delegate8_0(intptr_2, uint_0, uint_1, uint_2);
	}

	private static nuint smethod_24(nuint uintptr_0, out Struct294 struct294_0, nuint uintptr_1)
	{
		if (delegate9_0 == null)
		{
			delegate9_0 = (Delegate9)Marshal.GetDelegateForFunctionPointer(GetProcAddress(smethod_22(), "Virtual ".Trim() + "Query"), typeof(Delegate9));
		}
		return delegate9_0(uintptr_0, out struct294_0, uintptr_1);
	}

	private static nint smethod_25(uint uint_0, int int_4, uint uint_1)
	{
		if (YcZpxhitaaL == null)
		{
			YcZpxhitaaL = (Delegate10)Marshal.GetDelegateForFunctionPointer(GetProcAddress(smethod_22(), "Open ".Trim() + "Process"), typeof(Delegate10));
		}
		return YcZpxhitaaL(uint_0, int_4, uint_1);
	}

	private static int smethod_26(nint intptr_2, nint intptr_3, [In][Out] byte[] byte_4, uint uint_0, out nint intptr_4)
	{
		if (delegate11_0 == null)
		{
			delegate11_0 = (Delegate11)Marshal.GetDelegateForFunctionPointer(GetProcAddress(smethod_22(), "Write ".Trim() + "Process ".Trim() + "Memory"), typeof(Delegate11));
		}
		return delegate11_0(intptr_2, intptr_3, byte_4, uint_0, out intptr_4);
	}

	private static int smethod_27(nint intptr_2)
	{
		if (delegate12_0 == null)
		{
			delegate12_0 = (Delegate12)Marshal.GetDelegateForFunctionPointer(GetProcAddress(smethod_22(), "Close ".Trim() + "Handle"), typeof(Delegate12));
		}
		return delegate12_0(intptr_2);
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi)]
	public static extern nint GetProcAddress(nint intptr_2, string string_0);

	[DllImport("kernel32")]
	public static extern nint LoadLibrary(string string_0);

	[DllImport("libclrjit", BestFitMapping = true, CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern nint getJit();

	[DllImport("libclrjit", BestFitMapping = true, CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern nint mmap(nint intptr_2, nint intptr_3, int int_4, int int_5, int int_6, nint intptr_4);

	[DllImport("libclrjit", BestFitMapping = true, CallingConvention = CallingConvention.StdCall, EntryPoint = "mmap", SetLastError = true)]
	public static extern nint mmap_1(nint intptr_2, nint intptr_3, int int_4, int int_5, int int_6, nint intptr_4);

	[DllImport("libclrjit", BestFitMapping = true, CallingConvention = CallingConvention.StdCall, EntryPoint = "mmap", SetLastError = true)]
	public static extern nint mmap_2(nint intptr_2, nint intptr_3, int int_4, int int_5, int int_6, nint intptr_4);

	private static nint smethod_28(nint intptr_2, nint intptr_3, int int_4, int int_5, int int_6, nint intptr_4)
	{
		try
		{
			if (bool_5)
			{
				return mmap_1(intptr_2, intptr_3, int_4, int_5, int_6, intptr_4);
			}
			return mmap_2(intptr_2, intptr_3, int_4, int_5, int_6, intptr_4);
		}
		catch
		{
			return mmap(intptr_2, intptr_3, int_4, int_5, int_6, intptr_4);
		}
	}

	[DllImport("libclrjit", BestFitMapping = true, CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	private static extern int mprotect(nint intptr_2, nint intptr_3, int int_4);

	[DllImport("libSystem", BestFitMapping = true, CallingConvention = CallingConvention.StdCall, EntryPoint = "mprotect", SetLastError = true)]
	private static extern int mprotect_1(nint intptr_2, nint intptr_3, int int_4);

	[DllImport("libc", BestFitMapping = true, CallingConvention = CallingConvention.StdCall, EntryPoint = "mprotect", SetLastError = true)]
	private static extern int mprotect_2(nint intptr_2, nint intptr_3, int int_4);

	private static int smethod_29(nint intptr_2, nint intptr_3, int int_4)
	{
		try
		{
			if (bool_5)
			{
				return mprotect_1(intptr_2, intptr_3, int_4);
			}
			return mprotect_2(intptr_2, intptr_3, int_4);
		}
		catch
		{
			return mprotect(intptr_2, intptr_3, int_4);
		}
	}

	[DllImport("libclrjit", BestFitMapping = true, CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	private static extern int getpagesize();

	[DllImport("libSystem", BestFitMapping = true, CallingConvention = CallingConvention.StdCall, EntryPoint = "getpagesize", SetLastError = true)]
	private static extern int getpagesize_1();

	[DllImport("libc", BestFitMapping = true, CallingConvention = CallingConvention.StdCall, EntryPoint = "getpagesize", SetLastError = true)]
	private static extern int getpagesize_2();

	[DllImport("libSystem")]
	private static extern int mincore(nint intptr_2, nuint uintptr_0, byte[] byte_4);

	[DllImport("libc", EntryPoint = "mincore")]
	private static extern int mincore_1(nint intptr_2, nuint uintptr_0, byte[] byte_4);

	private static List<nint> bRrpxnqDgi9()
	{
		List<nint> list = new List<nint>();
		string[] array = File.ReadAllLines("/proc/self/maps");
		foreach (string obj in array)
		{
			long num = BitConverter.ToInt64(typeof(Class201).Assembly.ManifestModule.ModuleVersionId.ToByteArray(), 0);
			long num2 = BitConverter.ToInt64(BitConverter.GetBytes(num).Reverse().ToArray(), 0);
			string[] array2 = obj.Split(' ');
			string text = array2[0];
			if (array2[1][0] != 'r')
			{
				continue;
			}
			long num3 = Convert.ToInt64(text.Split('-')[0], 16);
			if (Convert.ToInt64(text.Split('-')[1], 16) - num3 < 72L)
			{
				continue;
			}
			nint item = new IntPtr(num3);
			nint num4 = new IntPtr(num3 + 64L);
			if (!smethod_31(num4, 8))
			{
				continue;
			}
			try
			{
				long num5 = Marshal.ReadInt64(num4);
				if (num5 == num || num5 == num2)
				{
					list.Add(item);
				}
			}
			catch
			{
			}
		}
		return list;
	}

	public unsafe static nint[] smethod_30(MethodBase methodBase_0, int int_4, int int_5, int int_6)
	{
		if (bool_7 && typeof(string).Assembly.GetName().Version.Major >= 8 && int_6 == 1)
		{
			List<nint> list = bRrpxnqDgi9();
			if (list.Count > 0)
			{
				return list.ToArray();
			}
		}
		bool flag = true;
		if (!bool_2 && bool_7 && typeof(string).Assembly.GetName().Version.Major >= 8 && int_6 != 1)
		{
			flag = false;
		}
		if (bool_5)
		{
			_ = typeof(string).Assembly.GetName().Version.Major;
		}
		if (flag)
		{
			object value = typeof(Class201).Assembly.ManifestModule.ModuleHandle.GetType().GetField("m_ptr", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetValue(typeof(Class201).Assembly.ManifestModule.ModuleHandle);
			if (value is nint)
			{
				xWepxmuymUl = (nint)value;
			}
			if (value.GetType().ToString() == "System.Reflection.RuntimeModule")
			{
				xWepxmuymUl = (nint)value.GetType().GetField("m_pData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetValue(value);
			}
			long num = 0L;
			num = ((IntPtr)Marshal.GetHINSTANCE(typeof(Class201).Assembly.GetModules()[0])).ToInt64();
			if (IntPtr.Size == 8)
			{
				if (num == -1L)
				{
					num = 0L;
				}
			}
			else if ((int)num == -1)
			{
				num = 0L;
			}
			if (num > 0L)
			{
				return new nint[1]
				{
					new IntPtr(num)
				};
			}
			Type type = Type.GetType("System.IRuntimeMethodInfo");
			if (type != null)
			{
				PropertyInfo property = type.GetProperty("Value");
				if (property != null)
				{
					object value2 = property.GetValue(methodBase_0);
					MethodInfo method = typeof(RuntimeMethodHandle).GetMethod("_GetUtf8Name", BindingFlags.Static | BindingFlags.NonPublic);
					if (value2 != null && method != null)
					{
						Pointer pointer = (Pointer)method.Invoke(null, new object[1] { value2 });
						if (pointer != null)
						{
							nint num2 = new IntPtr(Pointer.Unbox(pointer)) - int_5 - int_4;
							try
							{
								if (smethod_31(num2, 2) && Marshal.ReadInt16(num2) == 23117)
								{
									return new nint[1] { num2 };
								}
							}
							catch (Exception)
							{
							}
							num2 += int_4;
							try
							{
								if (smethod_31(num2, 2) && Marshal.ReadInt16(num2) == 23117)
								{
									return new nint[1] { num2 };
								}
							}
							catch (Exception)
							{
							}
						}
					}
				}
			}
			MethodInfo method2 = typeof(RuntimeTypeHandle).GetMethod("GetMetadataImport", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			if (method2 != null)
			{
				object obj = method2.Invoke(null, new object[1] { typeof(Class201) });
				if (obj != null)
				{
					MethodInfo method3 = obj.GetType().GetMethod("GetName", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
					if (method3 != null)
					{
						object obj2 = method3.Invoke(obj, new object[1] { methodBase_0.MetadataToken });
						if (obj2 != null)
						{
							FieldInfo field = obj2.GetType().GetField("m_pStringHeap", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
							if (field != null)
							{
								object value3 = field.GetValue(obj2);
								if (value3 != null)
								{
									nint num3 = new IntPtr(Pointer.Unbox(value3)) - int_5 - int_4;
									if (smethod_31(num3, 2) && Marshal.ReadInt16(num3) == 23117)
									{
										return new nint[1] { num3 };
									}
									num3 = num3 - int_4 + int_4;
									if (smethod_31(num3, 2) && Marshal.ReadInt16(num3) == 23117)
									{
										return new nint[1] { num3 };
									}
								}
							}
						}
					}
				}
			}
			if (num <= 0L)
			{
				string location = typeof(Class201).Assembly.Location;
				if (!string.IsNullOrEmpty(location))
				{
					foreach (ProcessModule module in Process.GetCurrentProcess().Modules)
					{
						if (module.FileName == location)
						{
							num = ((IntPtr)module.BaseAddress).ToInt64();
							break;
						}
					}
				}
			}
			if (IntPtr.Size == 8)
			{
				if (num == -1L)
				{
					num = 0L;
				}
			}
			else if ((int)num == -1)
			{
				num = 0L;
			}
			if (num > 0L)
			{
				return new nint[1]
				{
					new IntPtr(num)
				};
			}
		}
		nint zero = IntPtr.Zero;
		if (bool_2)
		{
			byte[] bytes = new byte[10] { 99, 108, 114, 106, 105, 116, 46, 100, 108, 108 };
			nint num4 = LoadLibrary(Encoding.UTF8.GetString(bytes));
			if (num4 == IntPtr.Zero)
			{
				bytes = new byte[12]
				{
					109, 115, 99, 111, 114, 106, 105, 116, 46, 100,
					108, 108
				};
				num4 = LoadLibrary(Encoding.UTF8.GetString(bytes));
			}
			byte[] bytes2 = new byte[6] { 103, 101, 116, 74, 105, 116 };
			string string_ = Encoding.UTF8.GetString(bytes2);
			zero = ((Delegate6)smethod_38(GetProcAddress(num4, string_), typeof(Delegate6)))();
		}
		else
		{
			zero = getJit();
		}
		long value4 = ((IntPtr)Marshal.ReadIntPtr(zero, 0)).ToInt64();
		Delegate4 @delegate = null;
		Delegate5 delegate2 = null;
		if (bool_4)
		{
			@delegate = smethod_33;
		}
		else
		{
			delegate2 = smethod_32;
		}
		nint zero2 = IntPtr.Zero;
		zero2 = ((!bool_4) ? Marshal.GetFunctionPointerForDelegate(delegate2) : Marshal.GetFunctionPointerForDelegate(@delegate));
		long num5 = 0L;
		num5 = ((IntPtr.Size != 4) ? Marshal.ReadInt64(new IntPtr(value4)) : Marshal.ReadInt32(new IntPtr(value4)));
		delegate4_1 = null;
		delegate5_0 = null;
		try
		{
			if (bool_4)
			{
				delegate4_1 = (Delegate4)smethod_38(new IntPtr(num5), typeof(Delegate4));
			}
			else
			{
				delegate5_0 = (Delegate5)smethod_38(new IntPtr(num5), typeof(Delegate5));
			}
		}
		catch
		{
			try
			{
				if (bool_4)
				{
					Delegate obj4 = smethod_38(new IntPtr(num5), typeof(Delegate4));
					delegate4_1 = (Delegate4)Delegate.CreateDelegate(typeof(Delegate4), obj4.Method);
				}
				else
				{
					Delegate obj5 = smethod_38(new IntPtr(num5), typeof(Delegate5));
					delegate5_0 = (Delegate5)Delegate.CreateDelegate(typeof(Delegate5), obj5.Method);
				}
			}
			catch
			{
			}
		}
		byte[] array = new byte[32];
		uint nativeSizeOfCode = 0u;
		fixed (byte* value5 = array)
		{
			Struct295 info = default(Struct295);
			if (bool_4)
			{
				@delegate(new IntPtr(value5), IntPtr.Zero, ref info, 216669565u, new IntPtr(value5), ref nativeSizeOfCode);
			}
			else
			{
				delegate2(new IntPtr(value5), IntPtr.Zero, ref info, 216669565u, new IntPtr(value5), ref nativeSizeOfCode);
			}
		}
		if (bool_4)
		{
			RuntimeHelpers.PrepareDelegate(delegate4_1);
			RuntimeHelpers.PrepareMethod(delegate4_1.Method.MethodHandle);
			RuntimeHelpers.PrepareDelegate(@delegate);
			RuntimeHelpers.PrepareMethod(@delegate.Method.MethodHandle);
		}
		else
		{
			RuntimeHelpers.PrepareDelegate(delegate5_0);
			RuntimeHelpers.PrepareMethod(delegate5_0.Method.MethodHandle);
			RuntimeHelpers.PrepareDelegate(delegate2);
			RuntimeHelpers.PrepareMethod(delegate2.Method.MethodHandle);
		}
		byte[] array2 = null;
		if (IntPtr.Size != 4)
		{
			array2 = new byte[39]
			{
				72, 184, 0, 0, 0, 0, 0, 0, 0, 0,
				73, 57, 0, 116, 12, 72, 184, 0, 0, 0,
				0, 0, 0, 0, 0, 255, 224, 72, 184, 0,
				0, 0, 0, 0, 0, 0, 0, 255, 224
			};
		}
		else
		{
			array2 = new byte[29]
			{
				85, 139, 236, 139, 69, 16, 129, 56, 0, 0,
				0, 0, 116, 7, 184, 0, 0, 0, 0, 235,
				5, 184, 0, 0, 0, 0, 93, 255, 224
			};
			if (bool_4)
			{
				array2[5] = 12;
			}
		}
		nint zero3 = IntPtr.Zero;
		zero3 = (bool_2 ? smethod_23(IntPtr.Zero, (uint)array2.Length, 4096u, 64u) : ((!bool_7) ? smethod_28(IntPtr.Zero, new IntPtr(array2.Length), 6, 4097, 0, IntPtr.Zero) : smethod_28(IntPtr.Zero, new IntPtr(array2.Length), 6, 33, 0, IntPtr.Zero)));
		byte[] array3 = array2;
		byte[] array4 = null;
		byte[] array5 = null;
		byte[] array6 = null;
		nint value6 = methodBase_0.MethodHandle.Value;
		if (IntPtr.Size == 4)
		{
			array4 = BitConverter.GetBytes(((IntPtr)zero2).ToInt32());
			array5 = BitConverter.GetBytes(Convert.ToInt32(num5));
			array6 = BitConverter.GetBytes(((IntPtr)value6).ToInt32());
		}
		else
		{
			array4 = BitConverter.GetBytes(((IntPtr)zero2).ToInt64());
			array5 = BitConverter.GetBytes(num5);
			array6 = BitConverter.GetBytes(((IntPtr)value6).ToInt64());
		}
		if (IntPtr.Size == 4)
		{
			Array.Copy(array6, 0, array3, 8, 4);
			Array.Copy(array5, 0, array3, 15, 4);
			Array.Copy(array4, 0, array3, 22, 4);
		}
		else
		{
			Array.Copy(array6, 0, array3, 2, 8);
			Array.Copy(array5, 0, array3, 17, 8);
			Array.Copy(array4, 0, array3, 29, 8);
			if (bool_7 || bool_5)
			{
				array3[10] = 72;
				array3[12] = 2;
			}
		}
		Marshal.Copy(array3, 0, zero3, array3.Length);
		if (bool_2)
		{
			int int_7 = 0;
			mllpDzdfXoh(new IntPtr(value4), IntPtr.Size, 64, ref int_7);
			Marshal.WriteIntPtr(new IntPtr(value4), zero3);
			mllpDzdfXoh(new IntPtr(value4), IntPtr.Size, int_7, ref int_7);
		}
		else if (bool_7)
		{
			smethod_35(new IntPtr(value4), zero3);
		}
		else if (bool_5)
		{
			smethod_29(new IntPtr(value4), new IntPtr(IntPtr.Size), 2);
			Marshal.WriteIntPtr(new IntPtr(value4), zero3);
		}
		methodBase_0.Invoke(null, new object[0]);
		if (bool_2)
		{
			zero3 = new IntPtr(num5);
			int int_8 = 0;
			mllpDzdfXoh(new IntPtr(value4), IntPtr.Size, 64, ref int_8);
			Marshal.WriteIntPtr(new IntPtr(value4), zero3);
			mllpDzdfXoh(new IntPtr(value4), IntPtr.Size, int_8, ref int_8);
		}
		else if (bool_7)
		{
			smethod_35(new IntPtr(value4), zero3);
		}
		else if (bool_5)
		{
			smethod_29(new IntPtr(value4), new IntPtr(IntPtr.Size), 2);
			Marshal.WriteIntPtr(new IntPtr(value4), zero3);
		}
		if (intptr_1 != IntPtr.Zero)
		{
			if (Marshal.ReadInt16(intptr_1 - int_2) == 23117)
			{
				intptr_1 -= int_2;
			}
			else
			{
				intptr_1 -= int_2 + int_4;
			}
		}
		return new nint[1] { intptr_1 };
	}

	private static bool smethod_31(nint intptr_2, int int_4)
	{
		if (bool_2)
		{
			uint num = 257u;
			uint num2 = 238u;
			bool flag = false;
			Struct294 @struct = default(Struct294);
			nuint uintptr_ = new UIntPtr((ulong)((IntPtr)intptr_2).ToInt64());
			nuint num3 = new UIntPtr(((UIntPtr)uintptr_).ToUInt64() + (uint)(int_4 - 1));
			do
			{
				@struct = default(Struct294);
				smethod_24(uintptr_, out @struct, new UIntPtr((ulong)Marshal.SizeOf(@struct)));
				flag = (@struct.uint_1 & 0x1000) != 0 && (@struct.uint_2 & num) == 0 && (@struct.uint_2 & num2) != 0;
				uintptr_ = new UIntPtr(((UIntPtr)@struct.uintptr_0).ToUInt64() + (ulong)((IntPtr)@struct.intptr_0).ToInt64());
			}
			while (flag && ((UIntPtr)uintptr_).ToUInt64() <= ((UIntPtr)num3).ToUInt64());
			return flag;
		}
		if (bool_5)
		{
			int num4 = 0;
			while (true)
			{
				if (num4 < int_4)
				{
					byte[] array = new byte[1];
					if (mincore(smethod_36(intptr_2 + num4), new UIntPtr((ulong)smethod_37()), array) != 0)
					{
						break;
					}
					if ((array[0] & 1) != 0)
					{
						num4++;
						continue;
					}
					return false;
				}
				return true;
			}
			return false;
		}
		if (bool_7)
		{
			int num5 = 0;
			while (true)
			{
				if (num5 < int_4)
				{
					byte[] array2 = new byte[1];
					if (mincore_1(smethod_36(intptr_2 + num5), new UIntPtr((ulong)smethod_37()), array2) != 0)
					{
						break;
					}
					if ((array2[0] & 1) != 0)
					{
						num5++;
						continue;
					}
					return false;
				}
				return true;
			}
			return false;
		}
		return false;
	}

	internal static uint smethod_32(nint intptr_2, nint intptr_3, ref Struct295 struct295_0, [MarshalAs(UnmanagedType.U4)] uint uint_0, nint intptr_4, ref uint uint_1)
	{
		intptr_1 = struct295_0.intptr_2;
		if (intptr_3 != IntPtr.Zero)
		{
			return delegate5_0(intptr_2, intptr_3, ref struct295_0, uint_0, intptr_4, ref uint_1);
		}
		return 0u;
	}

	internal static uint smethod_33(nint intptr_2, nint intptr_3, ref Struct295 struct295_0, [MarshalAs(UnmanagedType.U4)] uint uint_0, nint intptr_4, ref uint uint_1)
	{
		intptr_1 = struct295_0.intptr_2;
		if (intptr_3 != IntPtr.Zero)
		{
			return delegate4_1(intptr_2, intptr_3, ref struct295_0, uint_0, intptr_4, ref uint_1);
		}
		return 0u;
	}

	internal unsafe static void smethod_34()
	{
		if (!bool_8)
		{
			bool_8 = true;
			smethod_7();
			bool_2 = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
			bool_7 = RuntimeInformation.IsOSPlatform(OSPlatform.Linux) || RuntimeInformation.IsOSPlatform(OSPlatform.Create("ANDROID"));
			bool_5 = RuntimeInformation.IsOSPlatform(OSPlatform.OSX);
			if (bool_2 && IntPtr.Size == 4 && Type.GetType("System.Reflection.ReflectionContext", throwOnError: false) != null)
			{
				foreach (ProcessModule module in Process.GetCurrentProcess().Modules)
				{
					if (module.ModuleName.ToLower() == "clrjit.dll")
					{
						Version version = new Version(module.FileVersionInfo.ProductMajorPart, module.FileVersionInfo.ProductMinorPart, module.FileVersionInfo.ProductBuildPart, module.FileVersionInfo.ProductPrivatePart);
						Version version2 = new Version(4, 0, 30319, 17020);
						Version version3 = new Version(4, 0, 30319, 17921);
						if (version >= version2 && version < version3)
						{
							bool_4 = true;
							break;
						}
					}
				}
			}
			if (IntPtr.Size == 4 && typeof(byte).Assembly.GetName().Version.Major >= 6 && bool_2)
			{
				bool_4 = true;
			}
			Class202 @class = new Class202(assembly_0.GetManifestResourceStream("CcrHH3tAm4veHXD4kx.Zdfc4UeXo9h8ZCdrJ2"));
			@class.method_0().Position = 0L;
			byte[] array = @class.method_1((int)@class.method_0().Length);
			byte[] array2 = new byte[32];
			array2[0] = 115;
			array2[0] = 160;
			array2[0] = 118;
			array2[0] = 103;
			array2[0] = 231;
			array2[1] = 92;
			array2[1] = 127;
			array2[1] = 180;
			array2[1] = 128;
			array2[1] = 210;
			array2[1] = 149;
			array2[2] = 104;
			array2[2] = 156;
			array2[2] = 47;
			array2[3] = 103;
			array2[3] = 100;
			array2[3] = 103;
			array2[3] = 98;
			array2[4] = 108;
			array2[4] = 86;
			array2[4] = 164;
			array2[4] = 121;
			array2[4] = 97;
			array2[4] = 173;
			array2[5] = 170;
			array2[5] = 85;
			array2[5] = 126;
			array2[5] = 79;
			array2[5] = 144;
			array2[5] = 223;
			array2[6] = 148;
			array2[6] = 124;
			array2[6] = 89;
			array2[6] = 53;
			array2[6] = 114;
			array2[7] = 102;
			array2[7] = 51;
			array2[7] = 65;
			array2[7] = 200;
			array2[7] = 115;
			array2[7] = 141;
			array2[8] = 232;
			array2[8] = 117;
			array2[8] = 171;
			array2[8] = 191;
			array2[8] = 254;
			array2[9] = 66;
			array2[9] = 117;
			array2[9] = 204;
			array2[9] = 126;
			array2[9] = 79;
			array2[9] = 74;
			array2[10] = 97;
			array2[10] = 102;
			array2[10] = 112;
			array2[10] = 126;
			array2[10] = 74;
			array2[11] = 214;
			array2[11] = 145;
			array2[11] = 163;
			array2[11] = 114;
			array2[11] = 77;
			array2[12] = 85;
			array2[12] = 156;
			array2[12] = 131;
			array2[12] = 151;
			array2[12] = 111;
			array2[12] = 158;
			array2[13] = 88;
			array2[13] = 111;
			array2[13] = 118;
			array2[13] = 136;
			array2[13] = 50;
			array2[14] = 122;
			array2[14] = 43;
			array2[14] = 113;
			array2[15] = 131;
			array2[15] = 153;
			array2[15] = 124;
			array2[15] = 43;
			array2[15] = 167;
			array2[16] = 138;
			array2[16] = 92;
			array2[16] = 134;
			array2[16] = 165;
			array2[16] = 157;
			array2[17] = 61;
			array2[17] = 211;
			array2[17] = 166;
			array2[18] = 168;
			array2[18] = 103;
			array2[18] = 36;
			array2[18] = 120;
			array2[19] = 49;
			array2[19] = 90;
			array2[19] = 152;
			array2[19] = 115;
			array2[19] = 119;
			array2[19] = 176;
			array2[20] = 164;
			array2[20] = 190;
			array2[20] = 162;
			array2[20] = 7;
			array2[21] = 169;
			array2[21] = 151;
			array2[21] = 152;
			array2[21] = 163;
			array2[22] = 98;
			array2[22] = 97;
			array2[22] = 60;
			array2[22] = 156;
			array2[22] = 181;
			array2[23] = 90;
			array2[23] = 82;
			array2[23] = 22;
			array2[24] = 109;
			array2[24] = 156;
			array2[24] = 145;
			array2[24] = 118;
			array2[24] = 73;
			array2[25] = 80;
			array2[25] = 146;
			array2[25] = 159;
			array2[25] = 98;
			array2[25] = 47;
			array2[26] = 141;
			array2[26] = 207;
			array2[26] = 237;
			array2[27] = 122;
			array2[27] = 152;
			array2[27] = 176;
			array2[27] = 148;
			array2[27] = 250;
			array2[28] = 161;
			array2[28] = 92;
			array2[28] = 215;
			array2[29] = 143;
			array2[29] = 142;
			array2[29] = 140;
			array2[29] = 128;
			array2[29] = 131;
			array2[29] = 80;
			array2[30] = 104;
			array2[30] = 64;
			array2[30] = 227;
			array2[31] = 130;
			array2[31] = 145;
			array2[31] = 99;
			array2[31] = 88;
			array2[31] = 116;
			array2[31] = 208;
			byte[] array3 = array2;
			byte[] array4 = new byte[16];
			array4[0] = 107;
			array4[0] = 130;
			array4[0] = 170;
			array4[0] = 33;
			array4[1] = 108;
			array4[1] = 64;
			array4[1] = 70;
			array4[1] = 156;
			array4[1] = 168;
			array4[2] = 193;
			array4[2] = 170;
			array4[2] = 165;
			array4[2] = 155;
			array4[2] = 93;
			array4[3] = 164;
			array4[3] = 13;
			array4[3] = 117;
			array4[3] = 84;
			array4[3] = 137;
			array4[4] = 124;
			array4[4] = 158;
			array4[4] = 220;
			array4[5] = 150;
			array4[5] = 88;
			array4[5] = 149;
			array4[5] = 156;
			array4[5] = 226;
			array4[6] = 158;
			array4[6] = 132;
			array4[6] = 198;
			array4[7] = 143;
			array4[7] = 182;
			array4[7] = 61;
			array4[8] = 145;
			array4[8] = 150;
			array4[8] = 157;
			array4[8] = 97;
			array4[8] = 142;
			array4[8] = 93;
			array4[9] = 178;
			array4[9] = 154;
			array4[9] = 175;
			array4[10] = 132;
			array4[10] = 150;
			array4[10] = 131;
			array4[10] = 114;
			array4[11] = 64;
			array4[11] = 185;
			array4[11] = 106;
			array4[11] = 166;
			array4[11] = 187;
			array4[12] = 202;
			array4[12] = 12;
			array4[12] = 167;
			array4[12] = 106;
			array4[12] = 158;
			array4[12] = 106;
			array4[13] = 98;
			array4[13] = 134;
			array4[13] = 115;
			array4[13] = 153;
			array4[13] = 88;
			array4[13] = 226;
			array4[14] = 155;
			array4[14] = 85;
			array4[14] = 81;
			array4[14] = 97;
			array4[14] = 92;
			array4[14] = 252;
			array4[15] = 93;
			array4[15] = 92;
			array4[15] = 156;
			array4[15] = 90;
			array4[15] = 111;
			array4[15] = 217;
			byte[] array5 = array4;
			Array.Reverse(array5);
			byte[] publicKeyToken = assembly_0.GetName().GetPublicKeyToken();
			if (publicKeyToken != null && publicKeyToken.Length != 0)
			{
				array5[1] = publicKeyToken[0];
				array5[3] = publicKeyToken[1];
				array5[5] = publicKeyToken[2];
				array5[7] = publicKeyToken[3];
				array5[9] = publicKeyToken[4];
				array5[11] = publicKeyToken[5];
				array5[13] = publicKeyToken[6];
				array5[15] = publicKeyToken[7];
				Array.Clear(publicKeyToken, 0, publicKeyToken.Length);
			}
			for (int i = 0; i < array5.Length; i++)
			{
				array3[i] ^= array5[i];
			}
			byte[] array6 = array;
			int num = array6.Length % 4;
			int num2 = array6.Length / 4;
			byte[] array7 = new byte[array6.Length];
			int num3 = array3.Length / 4;
			uint num4 = 0u;
			uint num5 = 0u;
			uint num6 = 0u;
			if (num > 0)
			{
				num2++;
			}
			uint num7 = 0u;
			for (int j = 0; j < num2; j++)
			{
				int num8 = j % num3;
				int num9 = j * 4;
				num7 = (uint)(num8 * 4);
				num5 = (uint)((array3[num7 + 3] << 24) | (array3[num7 + 2] << 16) | (array3[num7 + 1] << 8) | array3[num7]);
				uint num10 = 255u;
				int num11 = 0;
				if (j == num2 - 1 && num > 0)
				{
					num4 += num5;
					num6 = 0u;
					for (int k = 0; k < num; k++)
					{
						if (k > 0)
						{
							num6 <<= 8;
						}
						num6 |= array6[^(1 + k)];
					}
				}
				else
				{
					num7 = (uint)num9;
					num4 += num5;
					num6 = (uint)((array6[num7 + 3] << 24) | (array6[num7 + 2] << 16) | (array6[num7 + 1] << 8) | array6[num7]);
				}
				num4 = num4;
				uint num12 = num4;
				uint num13 = num4;
				uint num14 = 811548710u;
				uint num15 = num13;
				uint num16 = 2000764323u;
				uint num17 = 1354548737u;
				uint num18 = 2910730083u;
				uint num19 = 89396545u;
				num18 = 2821333538u;
				num16 = 1589459859u;
				num14 = (num15 ^ 0x7036DA49) - 432493244;
				num14 = 72638 * (num14 & 0x7FFF) - (num14 >> 15);
				num16 = 687362435 - num15;
				num18 = ((num15 << 5) | (num15 >> 27)) ^ num16;
				num19 = num18 & 0x55555555;
				num18 &= 0xAAAAAAAAu;
				num15 = (num18 >> 1) | (num19 << 1);
				uint num20 = num16 / 1354548737 + 1354548737;
				num17 = ((num16 - num16) ^ num20) + num16;
				num15 ^= num15 << 10;
				num15 += 903792804;
				num15 ^= num15 >> 9;
				num15 += num15;
				num15 ^= num15 << 25;
				num15 += num17;
				num15 = (((num16 << 17) + 903792804) ^ num15) + num15;
				num4 = num12 + (uint)(double)num15;
				if (j == num2 - 1 && num > 0)
				{
					uint num21 = num4 ^ num6;
					for (int l = 0; l < num; l++)
					{
						if (l > 0)
						{
							num10 <<= 8;
							num11 += 8;
						}
						array7[num9 + l] = (byte)((num21 & num10) >> num11);
					}
				}
				else
				{
					uint num22 = num4 ^ num6;
					array7[num9] = (byte)(num22 & 0xFF);
					array7[num9 + 1] = (byte)((num22 & 0xFF00) >> 8);
					array7[num9 + 2] = (byte)((num22 & 0xFF0000) >> 16);
					array7[num9 + 3] = (byte)((num22 & 0xFF000000u) >> 24);
				}
			}
			byte[] array8 = array7;
			int num23 = array8.Length / 8;
			fixed (byte* ptr = array8)
			{
				for (int m = 0; m < num23; m++)
				{
					*(long*)(ptr + m * 8) ^= 348451427L;
				}
			}
			@class = new Class202(new MemoryStream(array8));
			@class.method_0().Position = 0L;
			long num24 = 0L;
			int metadataToken = @class.method_3();
			Class200.int_2 = @class.method_3();
			@class.method_3();
			int int_ = @class.method_3();
			int num25 = @class.method_3();
			int num26 = @class.method_3();
			if (num26 == 4)
			{
				SymmetricAlgorithm symmetricAlgorithm = smethod_11();
				symmetricAlgorithm.Mode = CipherMode.CBC;
				ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(array3, array5);
				Array.Clear(array3, 0, array3.Length);
				MemoryStream memoryStream = new MemoryStream();
				CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
				cryptoStream.Write(array, 0, array.Length);
				cryptoStream.FlushFinalBlock();
				array8 = memoryStream.ToArray();
				Array.Clear(array5, 0, array5.Length);
				memoryStream.Close();
				cryptoStream.Close();
				@class.method_4();
				num25 = @class.method_3();
				num26 = @class.method_3();
			}
			int num27 = 7680;
			int num28 = 7680;
			int int_2 = 0;
			nint[] array9 = smethod_30(assembly_0.ManifestModule.ResolveMethod(metadataToken), 7680, int_, num26);
			long position = @class.method_0().Position;
			for (int n = 0; n < array9.Length; n++)
			{
				num27 = num28;
				@class.method_0().Position = position;
				num24 = ((IntPtr)array9[n]).ToInt64();
				bool flag = false;
				int num29 = Marshal.ReadInt32(new IntPtr(num24 + 60L));
				long num30 = num29 + 24;
				short num31 = Marshal.ReadInt16(new IntPtr(num24 + num30));
				long num32 = 0L;
				num32 = ((num31 != 523) ? (num29 + 232) : (num29 + 248));
				int num33 = Marshal.ReadInt32(new IntPtr(num24 + num32));
				Marshal.ReadInt32(new IntPtr(num24 + num32 + 4L));
				long num34 = 0L;
				if (num33 != 0)
				{
					short num35 = Marshal.ReadInt16(new IntPtr(num24 + num29 + 6L));
					long num36 = num32 + 16L;
					num34 = num36;
					long num37 = 0L;
					bool flag2 = false;
					int num38 = 0;
					int num39 = 0;
					for (int num40 = 0; num40 < num35; num40++)
					{
						num39 = Marshal.ReadInt32(new IntPtr(num24 + num36 + 8L));
						num38 = Marshal.ReadInt32(new IntPtr(num24 + num36 + 12L));
						if (num38 > num33 || num33 >= num38 + num39)
						{
							num36 += 40L;
							continue;
						}
						num37 = Marshal.ReadInt32(new IntPtr(num24 + num36 + 20L)) + num33 - num38;
						flag2 = true;
						break;
					}
					if (flag2)
					{
						num36 = num34;
						num33 = Marshal.ReadInt32(new IntPtr(num24 + num37 + 8L));
						int num41 = 0;
						int num42 = 0;
						flag2 = false;
						for (int num43 = 0; num43 < num35; num43++)
						{
							num42 = Marshal.ReadInt32(new IntPtr(num24 + num36 + 8L));
							num41 = Marshal.ReadInt32(new IntPtr(num24 + num36 + 12L));
							if (num41 > num33 || num33 >= num41 + num42)
							{
								num36 += 40L;
								continue;
							}
							num37 = Marshal.ReadInt32(new IntPtr(num24 + num36 + 20L)) + num33 - num41;
							flag2 = true;
							break;
						}
						if (flag2)
						{
							flag = Marshal.ReadInt32(new IntPtr(num24 + num37)) == 1112167234;
						}
					}
				}
				_ = IntPtr.Size;
				int_2 = 0;
				if (!flag)
				{
					num27 = 0;
				}
				if (num26 != 1)
				{
					continue;
				}
				nint intptr_ = IntPtr.Zero;
				FileStream fileStream = null;
				Enum21 uint_ = (Enum21)56;
				if (!bool_2)
				{
					if (bool_7)
					{
						fileStream = File.Open("/proc/self/mem", FileMode.Open, FileAccess.ReadWrite);
					}
				}
				else
				{
					intptr_ = smethod_25((uint)uint_, 1, (uint)Process.GetCurrentProcess().Id);
				}
				nint intptr_2 = IntPtr.Zero;
				nint num44 = IntPtr.Zero;
				bool flag3 = false;
				for (int num45 = 0; num45 < num25; num45++)
				{
					nint num46 = new IntPtr(num24 + @class.method_3() - num27);
					if (!bool_2)
					{
						nint num47 = smethod_36(num46);
						if (num44 != num47)
						{
							num44 = num47;
							if (flag3 = smethod_29(num47, new IntPtr(smethod_37()), 3) == -1)
							{
								break;
							}
						}
						if (!bool_7)
						{
							Marshal.WriteInt32(num46, @class.method_3());
							continue;
						}
						fileStream.Seek(((IntPtr)num46).ToInt64(), SeekOrigin.Begin);
						fileStream.Write(BitConverter.GetBytes(@class.method_3()), 0, 4);
					}
					else
					{
						if (mllpDzdfXoh(num46, 4, 4, ref int_2) == 0)
						{
							mllpDzdfXoh(num46, 4, 8, ref int_2);
						}
						if (IntPtr.Size == 4)
						{
							smethod_26(intptr_, num46, BitConverter.GetBytes(@class.method_3()), 4u, out intptr_2);
						}
						else
						{
							smethod_26(intptr_, num46, BitConverter.GetBytes(@class.method_3()), 4u, out intptr_2);
						}
						mllpDzdfXoh(num46, 4, int_2, ref int_2);
					}
				}
				if (flag3)
				{
					continue;
				}
				while (@class.method_0().Position < @class.method_0().Length - 1L)
				{
					int num48 = @class.method_3();
					nint intptr_3 = new IntPtr(num24 + num48 - num27);
					int num49 = @class.method_3();
					if (bool_2)
					{
						if (mllpDzdfXoh(intptr_3, num49 * 4, 4, ref int_2) == 0)
						{
							mllpDzdfXoh(intptr_3, num49 * 4, 8, ref int_2);
						}
						for (int num50 = 0; num50 < num49; num50++)
						{
							Marshal.WriteInt32(new IntPtr(((IntPtr)intptr_3).ToInt64() + num50 * 4), @class.method_3());
						}
						mllpDzdfXoh(intptr_3, num49 * 4, int_2, ref int_2);
						continue;
					}
					for (int num51 = 0; num51 < num49; num51++)
					{
						nint num52 = new IntPtr(((IntPtr)intptr_3).ToInt64() + num51 * 4);
						nint num53 = smethod_36(num52);
						if (num44 != num53)
						{
							num44 = num53;
							if (flag3 = smethod_29(num53, new IntPtr(smethod_37()), 3) == -1)
							{
								break;
							}
						}
						if (!bool_7)
						{
							Marshal.WriteInt32(num52, @class.method_3());
							continue;
						}
						fileStream.Seek(((IntPtr)num52).ToInt64(), SeekOrigin.Begin);
						fileStream.Write(BitConverter.GetBytes(@class.method_3()), 0, 4);
					}
					if (flag3)
					{
						break;
					}
				}
				if (!bool_2)
				{
					if (bool_7)
					{
						fileStream.Close();
					}
				}
				else
				{
					smethod_27(intptr_);
				}
			}
			if (num26 == 1)
			{
				Class204.smethod_0();
				bool_0 = true;
				return;
			}
			if (num25 > 0)
			{
				if (!bool_2)
				{
					FileStream fileStream2 = null;
					if (bool_7)
					{
						fileStream2 = File.Open("/proc/self/mem", FileMode.Open, FileAccess.ReadWrite);
					}
					nint num54 = IntPtr.Zero;
					for (int num55 = 0; num55 < num25; num55++)
					{
						nint num56 = new IntPtr(num24 + @class.method_3() - num27);
						nint num57 = smethod_36(num56);
						if (num54 != num57)
						{
							num54 = num57;
							smethod_29(num57, new IntPtr(smethod_37()), 3);
						}
						if (!bool_7)
						{
							Marshal.WriteInt32(num56, @class.method_3());
							continue;
						}
						fileStream2.Seek(((IntPtr)num56).ToInt64(), SeekOrigin.Begin);
						fileStream2.Write(BitConverter.GetBytes(@class.method_3()), 0, 4);
					}
					if (bool_7)
					{
						fileStream2.Close();
					}
				}
				else
				{
					for (int num58 = 0; num58 < num25; num58++)
					{
						nint num59 = new IntPtr(num24 + @class.method_3() - num27);
						if (mllpDzdfXoh(num59, 4, 4, ref int_2) == 0)
						{
							mllpDzdfXoh(num59, 4, 8, ref int_2);
						}
						Marshal.WriteInt32(num59, @class.method_3());
						mllpDzdfXoh(num59, 4, int_2, ref int_2);
					}
				}
			}
			int num60 = @class.method_3() + 1;
			Struct293[] array10 = new Struct293[num60];
			MemoryStream memoryStream2 = new MemoryStream();
			array10[0] = new Struct293
			{
				intptr_0 = IntPtr.Zero,
				intptr_1 = new IntPtr(0)
			};
			memoryStream2.WriteByte(42);
			int num61 = 0;
			while (@class.method_0().Position < @class.method_0().Length - 1L)
			{
				num61++;
				int num62 = @class.method_3() - num27;
				@class.method_3();
				int num63 = @class.method_3();
				byte[] array11 = @class.method_1(num63);
				long value = num24 + num62;
				array10[num61] = new Struct293
				{
					intptr_0 = new IntPtr(memoryStream2.Position),
					intptr_1 = new IntPtr(value),
					int_0 = array11.Length
				};
				memoryStream2.Write(array11, 0, array11.Length);
			}
			nint zero = IntPtr.Zero;
			memoryStream2.Flush();
			byte[] array12 = memoryStream2.ToArray();
			if (bool_2)
			{
				zero = smethod_23(IntPtr.Zero, (uint)array12.Length, 4096u, 64u);
				Marshal.Copy(array12, 0, zero, array12.Length);
			}
			else
			{
				int num64 = array12.Length / smethod_37();
				num64 = (num64 + 1) * smethod_37();
				zero = ((!bool_7) ? smethod_28(IntPtr.Zero, new IntPtr(num64), 3, 4097, 0, IntPtr.Zero) : smethod_28(IntPtr.Zero, new IntPtr(num64), 3, 33, 0, IntPtr.Zero));
				Marshal.Copy(array12, 0, zero, array12.Length);
				smethod_29(zero, new IntPtr(num64), 5);
			}
			hashtable_0 = new Hashtable(num60);
			for (int num65 = 0; num65 < array10.Length; num65++)
			{
				Struct293 @struct = array10[num65];
				@struct.intptr_0 = new IntPtr(((IntPtr)@struct.intptr_0).ToInt64() + ((IntPtr)zero).ToInt64());
				hashtable_0.Add(((IntPtr)@struct.intptr_1).ToInt64(), @struct);
			}
			nint zero2 = IntPtr.Zero;
			if (bool_2)
			{
				byte[] bytes = new byte[10] { 99, 108, 114, 106, 105, 116, 46, 100, 108, 108 };
				nint num66 = LoadLibrary(Encoding.UTF8.GetString(bytes));
				if (num66 == IntPtr.Zero)
				{
					bytes = new byte[12]
					{
						109, 115, 99, 111, 114, 106, 105, 116, 46, 100,
						108, 108
					};
					num66 = LoadLibrary(Encoding.UTF8.GetString(bytes));
				}
				byte[] bytes2 = new byte[6] { 103, 101, 116, 74, 105, 116 };
				string string_ = Encoding.UTF8.GetString(bytes2);
				zero2 = ((Delegate6)smethod_38(GetProcAddress(num66, string_), typeof(Delegate6)))();
			}
			else
			{
				zero2 = getJit();
			}
			long num67 = 0L;
			num67 = ((IntPtr.Size != 4) ? Marshal.ReadInt64(zero2) : Marshal.ReadInt32(zero2));
			Marshal.ReadIntPtr(zero2, 0);
			delegate4_2 = null;
			delegate5_2 = null;
			if (bool_4)
			{
				delegate4_2 = smethod_39;
			}
			else
			{
				delegate5_2 = smethod_40;
			}
			nint zero3 = IntPtr.Zero;
			zero3 = (bool_4 ? Marshal.GetFunctionPointerForDelegate(delegate4_2) : Marshal.GetFunctionPointerForDelegate(delegate5_2));
			long num68 = 0L;
			num68 = ((IntPtr.Size != 4) ? Marshal.ReadInt64(new IntPtr(num67)) : Marshal.ReadInt32(new IntPtr(num67)));
			Process.GetCurrentProcess();
			delegate4_0 = null;
			delegate5_1 = null;
			try
			{
				if (bool_4)
				{
					delegate4_0 = (Delegate4)smethod_38(new IntPtr(num68), typeof(Delegate4));
				}
				else
				{
					delegate5_1 = (Delegate5)smethod_38(new IntPtr(num68), typeof(Delegate5));
				}
			}
			catch
			{
				try
				{
					if (!bool_4)
					{
						Delegate obj2 = smethod_38(new IntPtr(num68), typeof(Delegate5));
						delegate5_1 = (Delegate5)Delegate.CreateDelegate(typeof(Delegate5), obj2.Method);
					}
					else
					{
						Delegate obj3 = smethod_38(new IntPtr(num68), typeof(Delegate4));
						delegate4_0 = (Delegate4)Delegate.CreateDelegate(typeof(Delegate4), obj3.Method);
					}
				}
				catch
				{
				}
			}
			int int_3 = 0;
			if (typeof(Class200).Assembly.EntryPoint != null && typeof(Class200).Assembly.EntryPoint.GetParameters().Length == 2 && typeof(Class200).Assembly.Location != null && typeof(Class200).Assembly.Location.Length > 0)
			{
				Class204.smethod_0();
				bool_0 = true;
				return;
			}
			try
			{
				object value2 = typeof(Class200).Assembly.ManifestModule.ModuleHandle.GetType().GetField("m_ptr", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetValue(typeof(Class201).Assembly.ManifestModule.ModuleHandle);
				if (value2 is nint)
				{
					xWepxmuymUl = (nint)value2;
				}
				if (value2.GetType().ToString() == "System.Reflection.RuntimeModule")
				{
					xWepxmuymUl = (nint)value2.GetType().GetField("m_pData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetValue(value2);
				}
				MemoryStream memoryStream3 = new MemoryStream();
				memoryStream3.Write(new byte[IntPtr.Size], 0, IntPtr.Size);
				if (IntPtr.Size == 4)
				{
					memoryStream3.Write(BitConverter.GetBytes(((IntPtr)xWepxmuymUl).ToInt32()), 0, 4);
				}
				else
				{
					memoryStream3.Write(BitConverter.GetBytes(((IntPtr)xWepxmuymUl).ToInt64()), 0, 8);
				}
				memoryStream3.Write(new byte[IntPtr.Size], 0, IntPtr.Size);
				memoryStream3.Write(new byte[IntPtr.Size], 0, IntPtr.Size);
				memoryStream3.Position = 0L;
				byte[] array13 = memoryStream3.ToArray();
				memoryStream3.Close();
				uint nativeSizeOfCode = 0u;
				fixed (byte* value3 = array13)
				{
					Struct295 info = new Struct295
					{
						intptr_1 = xWepxmuymUl
					};
					if (!bool_4)
					{
						delegate5_2(new IntPtr(value3), new IntPtr(value3), ref info, 216669565u, new IntPtr(value3), ref nativeSizeOfCode);
					}
					else
					{
						delegate4_2(new IntPtr(value3), new IntPtr(value3), ref info, 216669565u, new IntPtr(value3), ref nativeSizeOfCode);
					}
				}
			}
			catch
			{
			}
			if (!bool_4)
			{
				RuntimeHelpers.PrepareDelegate(delegate5_1);
				RuntimeHelpers.PrepareMethod(delegate5_1.Method.MethodHandle);
				RuntimeHelpers.PrepareDelegate(delegate5_2);
				RuntimeHelpers.PrepareMethod(delegate5_2.Method.MethodHandle);
			}
			else
			{
				RuntimeHelpers.PrepareDelegate(delegate4_0);
				RuntimeHelpers.PrepareMethod(delegate4_0.Method.MethodHandle);
				RuntimeHelpers.PrepareDelegate(delegate4_2);
				RuntimeHelpers.PrepareMethod(delegate4_2.Method.MethodHandle);
			}
			bool flag4 = RuntimeInformation.ProcessArchitecture == Architecture.Arm64;
			bool flag5 = RuntimeInformation.ProcessArchitecture == Architecture.Arm;
			bool flag6 = false;
			byte[] array14 = null;
			if (IntPtr.Size != 4)
			{
				if (flag4)
				{
					List<byte> list = new List<byte>(new byte[32]
					{
						75, 4, 64, 249, 236, 0, 0, 88, 13, 1,
						0, 88, 46, 1, 0, 88, 127, 1, 12, 235,
						65, 0, 0, 84, 160, 1, 31, 214, 192, 1,
						31, 214
					});
					byte[] bytes3 = BitConverter.GetBytes(((IntPtr)xWepxmuymUl).ToInt64());
					byte[] bytes4 = BitConverter.GetBytes(((IntPtr)zero3).ToInt64());
					byte[] bytes5 = BitConverter.GetBytes(num68);
					list.AddRange(bytes3);
					list.AddRange(bytes4);
					list.AddRange(bytes5);
					array14 = list.ToArray();
				}
				else if (!flag5)
				{
					array14 = new byte[40]
					{
						72, 184, 0, 0, 0, 0, 0, 0, 0, 0,
						73, 57, 64, 8, 116, 12, 72, 184, 0, 0,
						0, 0, 0, 0, 0, 0, 255, 224, 72, 184,
						0, 0, 0, 0, 0, 0, 0, 0, 255, 224
					};
				}
				else
				{
					List<byte> list2 = null;
					list2 = (flag6 ? new List<byte>(new byte[28]
					{
						210, 248, 4, 176, 223, 248, 20, 192, 223, 248,
						20, 208, 223, 248, 20, 224, 227, 69, 1, 209,
						221, 248, 0, 240, 222, 248, 0, 240
					}) : new List<byte>(new byte[32]
					{
						229, 146, 176, 4, 229, 159, 192, 20, 229, 159,
						208, 20, 229, 159, 224, 20, 225, 91, 0, 12,
						26, 0, 0, 0, 225, 47, 255, 29, 225, 47,
						255, 30
					}));
					byte[] bytes6 = BitConverter.GetBytes(((IntPtr)xWepxmuymUl).ToInt32());
					byte[] bytes7 = BitConverter.GetBytes(((IntPtr)zero3).ToInt32());
					byte[] bytes8 = BitConverter.GetBytes((int)num68);
					list2.AddRange(bytes6);
					list2.AddRange(bytes7);
					list2.AddRange(bytes8);
					array14 = list2.ToArray();
				}
			}
			else
			{
				array14 = new byte[30]
				{
					85, 139, 236, 139, 69, 16, 129, 120, 4, 0,
					0, 0, 0, 116, 7, 184, 0, 0, 0, 0,
					235, 5, 184, 0, 0, 0, 0, 93, 255, 224
				};
				if (bool_4)
				{
					array14[5] = 12;
				}
			}
			nint zero4 = IntPtr.Zero;
			zero4 = (bool_2 ? smethod_23(IntPtr.Zero, (uint)array14.Length, 4096u, 64u) : (bool_7 ? smethod_28(IntPtr.Zero, new IntPtr(Math.Max(smethod_37(), array14.Length)), 3, 33, 0, IntPtr.Zero) : smethod_28(IntPtr.Zero, new IntPtr(Math.Max(smethod_37(), array14.Length)), 3, 6146, -1, IntPtr.Zero)));
			byte[] array15 = array14;
			if (!flag4 && !flag5)
			{
				byte[] array16 = null;
				byte[] array17 = null;
				byte[] array18 = null;
				if (IntPtr.Size == 4)
				{
					array18 = BitConverter.GetBytes(((IntPtr)xWepxmuymUl).ToInt32());
					array16 = BitConverter.GetBytes(((IntPtr)zero3).ToInt32());
					array17 = BitConverter.GetBytes(Convert.ToInt32(num68));
				}
				else
				{
					array18 = BitConverter.GetBytes(((IntPtr)xWepxmuymUl).ToInt64());
					array16 = BitConverter.GetBytes(((IntPtr)zero3).ToInt64());
					array17 = BitConverter.GetBytes(num68);
				}
				if (IntPtr.Size == 4)
				{
					Array.Copy(array18, 0, array15, 9, 4);
					Array.Copy(array17, 0, array15, 16, 4);
					Array.Copy(array16, 0, array15, 23, 4);
				}
				else
				{
					Array.Copy(array18, 0, array15, 2, 8);
					Array.Copy(array17, 0, array15, 18, 8);
					Array.Copy(array16, 0, array15, 30, 8);
					if (bool_7 || bool_5)
					{
						array15[10] = 72;
						array15[12] = 66;
					}
				}
			}
			Marshal.Copy(array15, 0, zero4, array15.Length);
			if (!bool_2)
			{
				smethod_29(zero4, new IntPtr(Math.Max(smethod_37(), array14.Length)), 5);
			}
			if (bool_2)
			{
				mllpDzdfXoh(new IntPtr(num67), IntPtr.Size, 64, ref int_3);
				Marshal.WriteIntPtr(new IntPtr(num67), zero4);
				mllpDzdfXoh(new IntPtr(num67), IntPtr.Size, int_3, ref int_3);
			}
			else if (!bool_7)
			{
				if (bool_5)
				{
					if (smethod_29(new IntPtr(num67), new IntPtr(IntPtr.Size), 3) != 0)
					{
						smethod_29(smethod_36(new IntPtr(num67)), new IntPtr(smethod_37()), 3);
					}
					Marshal.WriteIntPtr(new IntPtr(num67), zero4);
				}
			}
			else
			{
				smethod_35(new IntPtr(num67), zero4);
			}
			bool_0 = true;
		}
		Class204.smethod_0();
	}

	private static void smethod_35(nint intptr_2, nint intptr_3)
	{
		byte[] array = null;
		array = ((IntPtr.Size != 4) ? BitConverter.GetBytes(((IntPtr)intptr_3).ToInt64()) : BitConverter.GetBytes(((IntPtr)intptr_3).ToInt32()));
		FileStream fileStream = File.Open("/proc/self/mem", FileMode.Open, FileAccess.ReadWrite);
		fileStream.Seek(((IntPtr)intptr_2).ToInt64(), SeekOrigin.Begin);
		fileStream.Write(array, 0, array.Length);
		fileStream.Close();
	}

	private static nint smethod_36(nint intptr_2)
	{
		return new IntPtr(((IntPtr)intptr_2).ToInt64() & ~(smethod_37() - 1));
	}

	[SpecialName]
	private static int smethod_37()
	{
		if (int_1 == -2)
		{
			try
			{
				if (bool_5)
				{
					int_1 = getpagesize_1();
				}
				else
				{
					int_1 = getpagesize_2();
				}
			}
			catch
			{
				int_1 = getpagesize();
			}
		}
		return int_1;
	}

	private static Delegate smethod_38(nint intptr_2, Type type_0)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			typeof(nint),
			typeof(Type)
		}).Invoke(null, new object[2] { intptr_2, type_0 });
	}

	internal static uint smethod_39(nint intptr_2, nint intptr_3, ref Struct295 struct295_0, [MarshalAs(UnmanagedType.U4)] uint uint_0, nint intptr_4, ref uint uint_1)
	{
		long num = ((IntPtr)struct295_0.intptr_2).ToInt64();
		object obj = hashtable_0[num];
		if (obj != null)
		{
			Struct293 @struct = (Struct293)obj;
			struct295_0.intptr_2 = @struct.intptr_0;
			struct295_0.int_0 = @struct.int_0;
			uint result = 0u;
			if (uint_0 == 216669565 && !bool_1)
			{
				bool_1 = true;
			}
			else
			{
				result = delegate4_0(intptr_2, intptr_3, ref struct295_0, uint_0, intptr_4, ref uint_1);
				struct295_0.intptr_2 = IntPtr.Zero;
				struct295_0.int_0 = 0;
			}
			return result;
		}
		return delegate4_0(intptr_2, intptr_3, ref struct295_0, uint_0, intptr_4, ref uint_1);
	}

	internal static uint smethod_40(nint intptr_2, nint intptr_3, ref Struct295 struct295_0, [MarshalAs(UnmanagedType.U4)] uint uint_0, nint intptr_4, ref uint uint_1)
	{
		long num = ((IntPtr)struct295_0.intptr_2).ToInt64();
		object obj = hashtable_0[num];
		if (obj != null)
		{
			Struct293 @struct = (Struct293)obj;
			struct295_0.intptr_2 = @struct.intptr_0;
			struct295_0.int_0 = @struct.int_0;
			uint result = 0u;
			if (uint_0 == 216669565 && !bool_1)
			{
				bool_1 = true;
			}
			else
			{
				result = delegate5_1(intptr_2, intptr_3, ref struct295_0, uint_0, intptr_4, ref uint_1);
				struct295_0.intptr_2 = IntPtr.Zero;
				struct295_0.int_0 = 0;
			}
			return result;
		}
		return delegate5_1(intptr_2, intptr_3, ref struct295_0, uint_0, intptr_4, ref uint_1);
	}

	internal static bool smethod_41()
	{
		return null == null;
	}

	internal static object smethod_42()
	{
		return null;
	}

	static int smethod_43()
	{
		return 1;
	}

	internal static bool smethod_44()
	{
		return null == null;
	}

	internal static object smethod_45()
	{
		return null;
	}
}
