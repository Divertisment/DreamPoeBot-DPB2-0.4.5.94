using System.Collections.ObjectModel;
using System.Collections.Specialized;
using DreamPoeBot.Loki.Common;
using log4net;
using Newtonsoft.Json;
using ns0;

namespace DreamPoeBot.Loki.Bot.Implementation.Content.SkillBlacklist;

public class SkillBlacklistSettings : JsonSettings
{
	private static readonly ILog ilog_1;

	private static SkillBlacklistSettings skillBlacklistSettings_0;

	private ObservableCollection<PlayerSkillWrapper> observableCollection_0;

	private ObservableCollection<SkillId> observableCollection_1;

	private ObservableCollection<SkillName> observableCollection_2;

	private static SkillBlacklistSettings skillBlacklistSettings_1;

	public static SkillBlacklistSettings Instance => null;

	[JsonIgnore]
	public ObservableCollection<PlayerSkillWrapper> PlayerSkillStrings
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ObservableCollection<SkillId> BlacklistedSkillIds
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ObservableCollection<SkillName> BlacklistedSkillNames
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void method_0(object sender, NotifyCollectionChangedEventArgs e)
	{
	}

	private void method_1(object sender, NotifyCollectionChangedEventArgs e)
	{
	}

	static SkillBlacklistSettings()
	{
		Class200.smethod_34();
		Class204.smethod_0();
		ilog_1 = Logger.GetLoggerInstanceForType();
	}

	internal static bool smethod_5()
	{
		return true;
	}

	internal static SkillBlacklistSettings smethod_6()
	{
		return null;
	}
}
