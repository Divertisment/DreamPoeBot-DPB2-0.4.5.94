using System;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Newtonsoft.Json.Linq;

namespace ns0;

internal sealed class Class190 : IDisposable
{
	private sealed class Class191
	{
		private readonly Stopwatch stopwatch_0;

		private readonly TimeSpan timeSpan_0;

		private static Class191 class191_0;

		internal Class191(TimeSpan timeSpan_1)
		{
		}

		[SpecialName]
		internal TimeSpan method_0()
		{
			return (TimeSpan)(object)null;
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class191 smethod_1()
		{
			return null;
		}

		static Class191()
		{
			Class200.smethod_34();
		}
	}

	private sealed class Header : IEquatable<Header>
	{
		[CompilerGenerated]
		private readonly string string_0;

		[CompilerGenerated]
		private readonly string string_1;

		internal static Header header_0;

		[CompilerGenerated]
		private Type bw3pyMRsljn
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public string Name
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

		public string Value
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

		public Header(string string_2, string string_3)
		{
		}

		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[CompilerGenerated]
		private bool method_0(StringBuilder stringBuilder_0)
		{
			return true;
		}

		[CompilerGenerated]
		public static bool operator !=(Header? header_1, Header? header_2)
		{
			return true;
		}

		[CompilerGenerated]
		public static bool operator ==(Header? header_1, Header? header_2)
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
		public bool Equals(Header? other)
		{
			return true;
		}

		[CompilerGenerated]
		public Header method_1()
		{
			return null;
		}

		[CompilerGenerated]
		private Header(Header original)
		{
		}

		[CompilerGenerated]
		public void method_2(out string string_2, out string string_3)
		{
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Header smethod_1()
		{
			return null;
		}

		static Header()
		{
			Class200.smethod_34();
		}
	}

	private static readonly Uri uri_0;

	private static readonly UTF8Encoding utf8Encoding_0;

	private readonly object object_0;

	private readonly HttpClient httpClient_0;

	private readonly RSA rsa_0;

	private string string_0;

	private string string_1;

	private DateTimeOffset dateTimeOffset_0;

	private DateTimeOffset? nullable_0;

	private long long_0;

	private bool bool_0;

	internal static Class190 class190_0;

	internal Class190(string string_2, int int_0 = 443, HttpMessageHandler httpMessageHandler_0 = null)
	{
	}

	[SpecialName]
	internal string method_0()
	{
		return null;
	}

	internal string method_1(string string_2, TimeSpan timeSpan_0)
	{
		return null;
	}

	internal Class192 method_2(uint uint_0, TimeSpan timeSpan_0)
	{
		return null;
	}

	internal ulong method_3(TimeSpan timeSpan_0)
	{
		return 0uL;
	}

	internal void method_4(TimeSpan timeSpan_0)
	{
	}

	internal Class193 method_5(string string_2, ulong ulong_0, long long_1, byte[] byte_0, byte[] byte_1, byte[] byte_2, TimeSpan timeSpan_0)
	{
		return null;
	}

	internal Class194 method_6(string string_2, Version version_0, TimeSpan timeSpan_0)
	{
		return null;
	}

	internal bool method_7(TimeSpan timeSpan_0)
	{
		return true;
	}

	private void method_8(Class191 class191_0)
	{
	}

	private JObject method_9(string string_2, JObject jobject_0, Class191 class191_0, bool bool_1 = true)
	{
		return null;
	}

	private JObject method_10(string string_2, string string_3, Header[] header_0, TimeSpan timeSpan_0)
	{
		return null;
	}

	private void method_11(DateTimeOffset? nullable_1, long long_1, long long_2)
	{
	}

	private void method_12()
	{
	}

	private static string smethod_0(HttpContent httpContent_0, CancellationToken cancellationToken_0)
	{
		return null;
	}

	private void method_13(JObject jobject_0, string string_2 = null)
	{
	}

	private void method_14()
	{
	}

	private void method_15()
	{
	}

	public void Dispose()
	{
	}

	private static string smethod_1(JObject jobject_0)
	{
		return null;
	}

	private static string smethod_2(byte[] byte_0)
	{
		return null;
	}

	private static bool smethod_3(string string_2, string string_3)
	{
		return true;
	}

	private static string smethod_4(JObject jobject_0, string string_2)
	{
		return null;
	}

	private static uint smethod_5(JObject jobject_0, string string_2)
	{
		return 0u;
	}

	private static ulong smethod_6(JObject jobject_0, string string_2)
	{
		return 0uL;
	}

	private static bool smethod_7(JObject jobject_0, string string_2)
	{
		return true;
	}

	private static byte[] smethod_8(JObject jobject_0, string string_2, int int_0)
	{
		return null;
	}

	private static DateTimeOffset smethod_9(JObject jobject_0, string string_2)
	{
		return (DateTimeOffset)(object)null;
	}

	static Class190()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		uri_0 = new Uri(Class200.smethod_20(2963498), UriKind.Absolute);
		utf8Encoding_0 = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true);
	}

	internal static bool smethod_10()
	{
		return true;
	}

	internal static Class190 smethod_11()
	{
		return null;
	}
}
