using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;
using DreamPoeBot.Auth;
using DreamPoeBot.DreamPoe;
using DreamPoeBot.Loki.Common;
using log4net;
using Newtonsoft.Json;
using ns0;

namespace DreamPoeBot.Loki;

public class GlobalSettings : JsonSettings
{
	private List<PremiumContentClass> list_0;

	private string string_1;

	private bool bool_1;

	private bool bool_2;

	private static readonly ILog ilog_1;

	public static Crypto Crypto;

	private static GlobalSettings globalSettings_0;

	private string string_2;

	private bool bool_3;

	private List<RegionOption> list_1;

	private Region region_0;

	private bool bool_4;

	private string string_3;

	private string string_4;

	private bool bool_5;

	private bool bool_6;

	private bool bool_7;

	private bool bool_8;

	private string vMbXbuXxdo;

	private string string_5;

	private string string_6;

	private string string_7;

	private bool bool_9;

	private string string_8;

	private bool bool_10;

	private string string_9;

	private bool bool_11;

	private Keys keys_0;

	private Keys keys_1;

	private ModifierKeys modifierKeys_0;

	private ModifierKeys modifierKeys_1;

	private bool bool_12;

	private Keys keys_2;

	private ModifierKeys modifierKeys_2;

	private bool bool_13;

	private Keys keys_3;

	private ModifierKeys modifierKeys_3;

	private bool bool_14;

	private Keys keys_4;

	private ModifierKeys modifierKeys_4;

	private bool bool_15;

	private Keys keys_5;

	private ModifierKeys modifierKeys_5;

	private bool bool_16;

	private Keys keys_6;

	private ModifierKeys modifierKeys_6;

	private bool bool_17;

	private Keys keys_7;

	private ModifierKeys modifierKeys_7;

	private bool OgjZeykHqW;

	private Keys keys_8;

	private ModifierKeys modifierKeys_8;

	private bool bool_18;

	private bool bool_19;

	private bool bool_20;

	private bool bool_21;

	private bool bool_22;

	private int int_0;

	private bool bool_23;

	private bool bool_24;

	private int int_1;

	private bool bool_25;

	private int int_2;

	private bool bool_26;

	private int int_3;

	private bool bool_27;

	private bool bool_28;

	private bool bool_29;

	private bool bool_30;

	internal static GlobalSettings globalSettings_1;

	public static GlobalSettings Instance => null;

	[DefaultValue(false)]
	public bool HumanLikeMouse
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[DefaultValue(7)]
	public int HumanLikeMouseMaxStep
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[DefaultValue(false)]
	public bool IsBackgroundFpsActive
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[DefaultValue(33)]
	public int BackgroundFps
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[DefaultValue(false)]
	public bool StopRenderOnHook
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[DefaultValue(false)]
	public bool MinimizeGameOnHook
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[DefaultValue(false)]
	public bool EnableMouseDegudOnHook
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[DefaultValue(false)]
	public bool DontAutoFocusGameWindow
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[DefaultValue(false)]
	public bool DontAutoFocusBotWindow
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[DefaultValue(false)]
	public bool HookCompatibility0
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[DefaultValue(false)]
	public bool HookCompatibility1
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[DefaultValue(8)]
	public int HookCompatibilityDepth
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[DefaultValue(false)]
	public bool DebugTicks
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[DefaultValue(false)]
	public bool DebugLastTask
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[DefaultValue(false)]
	public bool AllowExternalAccess
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[DefaultValue(true)]
	public bool StartStopBotEnabled
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[DefaultValue(Keys.S)]
	public Keys StartStopBotKey
	{
		get
		{
			return (Keys)(object)null;
		}
		set
		{
		}
	}

	[DefaultValue(Keys.S)]
	public Keys StartForceStopBotKey
	{
		get
		{
			return (Keys)(object)null;
		}
		set
		{
		}
	}

	[DefaultValue(ModifierKeys.Alt | ModifierKeys.Shift)]
	public ModifierKeys StartStopBotMod
	{
		get
		{
			return (ModifierKeys)(object)null;
		}
		set
		{
		}
	}

	[DefaultValue(ModifierKeys.Control | ModifierKeys.Shift)]
	public ModifierKeys StartForceStopBotMod
	{
		get
		{
			return (ModifierKeys)(object)null;
		}
		set
		{
		}
	}

	[DefaultValue(true)]
	public bool FocusBotWindowEnabled
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[DefaultValue(Keys.W)]
	public Keys FocusBotWindowKey
	{
		get
		{
			return (Keys)(object)null;
		}
		set
		{
		}
	}

	[DefaultValue(ModifierKeys.Alt | ModifierKeys.Shift)]
	public ModifierKeys FocusBotWindowMod
	{
		get
		{
			return (ModifierKeys)(object)null;
		}
		set
		{
		}
	}

	[DefaultValue(true)]
	public bool DebugMouseCursorPosEnabled
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[DefaultValue(Keys.X)]
	public Keys DebugMouseCursorPosKey
	{
		get
		{
			return (Keys)(object)null;
		}
		set
		{
		}
	}

	[DefaultValue(ModifierKeys.Alt | ModifierKeys.Shift)]
	public ModifierKeys DebugMouseCursorPosMod
	{
		get
		{
			return (ModifierKeys)(object)null;
		}
		set
		{
		}
	}

	[DefaultValue(true)]
	public bool DisablePHMEnabled
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[DefaultValue(Keys.D)]
	public Keys DisablePHMKey
	{
		get
		{
			return (Keys)(object)null;
		}
		set
		{
		}
	}

	[DefaultValue(ModifierKeys.Alt | ModifierKeys.Shift)]
	public ModifierKeys DisablePHMMod
	{
		get
		{
			return (ModifierKeys)(object)null;
		}
		set
		{
		}
	}

	[DefaultValue(true)]
	public bool EnablePHMEnabled
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[DefaultValue(Keys.E)]
	public Keys EnablePHMKey
	{
		get
		{
			return (Keys)(object)null;
		}
		set
		{
		}
	}

	[DefaultValue(ModifierKeys.Alt | ModifierKeys.Shift)]
	public ModifierKeys EnablePHMMod
	{
		get
		{
			return (ModifierKeys)(object)null;
		}
		set
		{
		}
	}

	[DefaultValue(true)]
	public bool ResetPHMEnabled
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[DefaultValue(Keys.R)]
	public Keys ResetPHMKey
	{
		get
		{
			return (Keys)(object)null;
		}
		set
		{
		}
	}

	[DefaultValue(ModifierKeys.Alt | ModifierKeys.Shift)]
	public ModifierKeys ResetPHMMod
	{
		get
		{
			return (ModifierKeys)(object)null;
		}
		set
		{
		}
	}

	[DefaultValue(true)]
	public bool DumpTGTEnabled
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[DefaultValue(Keys.T)]
	public Keys DumpTGTKey
	{
		get
		{
			return (Keys)(object)null;
		}
		set
		{
		}
	}

	[DefaultValue(ModifierKeys.Alt | ModifierKeys.Shift)]
	public ModifierKeys DumpTGTMod
	{
		get
		{
			return (ModifierKeys)(object)null;
		}
		set
		{
		}
	}

	[DefaultValue(true)]
	public bool DumpFrameUnderCursorEnabled
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[DefaultValue(Keys.A)]
	public Keys DumpFrameUnderCursorKey
	{
		get
		{
			return (Keys)(object)null;
		}
		set
		{
		}
	}

	[DefaultValue(ModifierKeys.Alt | ModifierKeys.Shift)]
	public ModifierKeys DumpFrameUnderCursorMod
	{
		get
		{
			return (ModifierKeys)(object)null;
		}
		set
		{
		}
	}

	[DefaultValue(false)]
	public bool AutoChooseConfig
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[DefaultValue(false)]
	public bool AutoChooseLanguage
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[DefaultValue("")]
	public string DPB2UpdaterName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[DefaultValue("")]
	public string AutoLanguage
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[DefaultValue("en")]
	public string LastUsedLanguage
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[JsonIgnore]
	public bool RandomizeProfileSelectionFalse => true;

	[DefaultValue(false)]
	public bool RandomizeProfileSelection
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[JsonIgnore]
	public string RandomProfileSelected
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[DefaultValue("")]
	public string ProfilesFolderPath
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[DefaultValue("")]
	public string ProfileBaseName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[DefaultValue("")]
	public string BlacklistedProfileWords
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[DefaultValue("")]
	public string LastUsedConfiguration
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[DefaultValue(true)]
	public bool AutoAuthLogin
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[DefaultValue(Region.BestLatency)]
	public Region AuthRegion
	{
		get
		{
			return (Region)(object)null;
		}
		set
		{
		}
	}

	[JsonIgnore]
	public IReadOnlyList<RegionOption> AuthRegionOptions => null;

	[DefaultValue(false)]
	public bool DisableUpdateCheck
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[JsonIgnore]
	[DefaultValue("")]
	public string AuthKey
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[DefaultValue("")]
	public string AuthKeys
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[DefaultValue(false)]
	public bool LogoutPoeOnAuthIssue2
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[DefaultValue(false)]
	public bool TerminatePoeOnAuthIssue
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[DefaultValue(20)]
	public int MemoryPullInterval
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public List<PremiumContentClass> PremiumContent
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[DefaultValue("Method2")]
	public string ObjectManagerPullMethod
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[DefaultValue(false)]
	public bool ObjectPullUseBlacklist
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[DefaultValue(false)]
	public bool ObjectPullLogData
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[JsonIgnore]
	public static ObservableCollection<string> ObjectManagerPullMethodList => null;

	[DefaultValue(false)]
	public bool UseStringPool
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[OnSerializing]
	internal void method_0(StreamingContext streamingContext_0)
	{
	}

	[OnSerialized]
	internal void method_1(StreamingContext streamingContext_0)
	{
	}

	[OnDeserialized]
	internal void method_2(StreamingContext streamingContext_0)
	{
	}

	static GlobalSettings()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_1 = Logger.GetLoggerInstanceForType();
		Crypto = new Crypto(Encoding.ASCII.GetBytes(Class200.smethod_20(10732)));
	}

	internal static bool smethod_5()
	{
		return true;
	}

	internal static GlobalSettings smethod_6()
	{
		return null;
	}
}
