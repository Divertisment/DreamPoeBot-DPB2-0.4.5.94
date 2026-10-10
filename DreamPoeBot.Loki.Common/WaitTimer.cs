using System;
using System.Runtime.CompilerServices;
using ns0;

namespace DreamPoeBot.Loki.Common;

public class WaitTimer
{
	public sealed class WaitTimerEventArgs : EventArgs
	{
		[CompilerGenerated]
		private DateTime dateTime_0;

		[CompilerGenerated]
		private TimeSpan timeSpan_0;

		[CompilerGenerated]
		private DateTime dateTime_1;

		private static WaitTimerEventArgs waitTimerEventArgs_0;

		public DateTime TimeFinished
		{
			[CompilerGenerated]
			get
			{
				return (DateTime)(object)null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public TimeSpan WaitTime
		{
			[CompilerGenerated]
			get
			{
				return (TimeSpan)(object)null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public DateTime TimeStarted
		{
			[CompilerGenerated]
			get
			{
				return (DateTime)(object)null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static WaitTimerEventArgs smethod_1()
		{
			return null;
		}

		static WaitTimerEventArgs()
		{
			Class200.smethod_34();
		}
	}

	[CompilerGenerated]
	private TimeSpan timeSpan_0;

	[CompilerGenerated]
	private DateTime dateTime_0;

	private WaitTimerFinishedHandler waitTimerFinishedHandler_0;

	internal static WaitTimer waitTimer_0;

	public static WaitTimer OneSecond => null;

	public static WaitTimer FiveSeconds => null;

	public static WaitTimer TenSeconds => null;

	public static WaitTimer ThirtySeconds => null;

	public TimeSpan WaitTime
	{
		[CompilerGenerated]
		get
		{
			return (TimeSpan)(object)null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public DateTime EndTime => (DateTime)(object)null;

	public DateTime StartTime
	{
		[CompilerGenerated]
		get
		{
			return (DateTime)(object)null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsFinished => true;

	public TimeSpan TimeLeft => (TimeSpan)(object)null;

	public event WaitTimerFinishedHandler Finished
	{
		add
		{
		}
		remove
		{
		}
	}

	public void Reset(TimeSpan newDuration)
	{
	}

	public WaitTimer(TimeSpan waitTime)
	{
	}

	public void Reset()
	{
	}

	public void Stop()
	{
	}

	public void Update()
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static WaitTimer smethod_1()
	{
		return null;
	}

	static WaitTimer()
	{
		Class200.smethod_34();
	}
}
