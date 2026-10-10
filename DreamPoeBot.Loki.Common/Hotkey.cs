using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns0;

namespace DreamPoeBot.Loki.Common;

public class Hotkey : IEquatable<Hotkey>
{
	[CompilerGenerated]
	private Action<Hotkey> action_0;

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private Keys keys_0;

	[CompilerGenerated]
	private ModifierKeys modifierKeys_0;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private bool bool_0;

	private static Hotkey hotkey_0;

	public Action<Hotkey> Callback
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

	public int Id
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public Keys Key
	{
		[CompilerGenerated]
		get
		{
			return (Keys)(object)null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public ModifierKeys ModifierKeys
	{
		[CompilerGenerated]
		get
		{
			return (ModifierKeys)(object)null;
		}
		[CompilerGenerated]
		private set
		{
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
		private set
		{
		}
	}

	internal Hotkey(string name, Keys key, ModifierKeys modifierKeys, int id, Action<Hotkey> callback)
	{
	}

	[SpecialName]
	[CompilerGenerated]
	internal bool method_0()
	{
		return true;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_1(bool bool_1)
	{
	}

	public override string ToString()
	{
		return null;
	}

	private string method_2()
	{
		return null;
	}

	public bool Equals(Hotkey other)
	{
		return true;
	}

	public override bool Equals(object obj)
	{
		return true;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator ==(Hotkey left, Hotkey right)
	{
		return true;
	}

	public static bool operator !=(Hotkey left, Hotkey right)
	{
		return true;
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static Hotkey smethod_1()
	{
		return null;
	}

	static Hotkey()
	{
		Class200.smethod_34();
	}
}
