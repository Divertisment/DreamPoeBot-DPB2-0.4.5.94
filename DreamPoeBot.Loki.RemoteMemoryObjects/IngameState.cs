using System;
using System.Runtime.CompilerServices;
using DreamPoeBot.Loki.Game.Utilities;
using ns0;

namespace DreamPoeBot.Loki.RemoteMemoryObjects;

public class IngameState : RemoteMemoryObject
{
	private IngameData ingameData_0;

	private ServerData serverData_0;

	private readonly object object_0;

	private Memory memory_0;

	private long long_1;

	private PerFrameCachedValue<long> perFrameCachedValue_0;

	private PerFrameCachedValue<long> perFrameCachedValue_1;

	private PerAreaCachedValue<AreaMap> perAreaCachedValue_0;

	public DiagnosticElementNew DiagnosticData;

	internal static IngameState ingameState_0;

	public bool InGame => true;

	public bool PausedGame => true;

	public IngameData Data => null;

	public ServerData ServerData => null;

	public AreaMap CurrentAreaMap => null;

	public IngameUIElements IngameUi => null;

	public Element UIRoot => null;

	public Element UIHover => null;

	public Element UIHoverTooltip => null;

	public float UIHoverX => 0f;

	public float UIHoverY => 0f;

	public float CurentUIElementPosX => 0f;

	public float CurentUIElementPosY => 0f;

	public long FrameUnderCursor => 0L;

	public Element CursorHoverElement => null;

	public Camera Camera => null;

	public uint TimeInGameF => 0u;

	public TimeSpan TimeInGame => (TimeSpan)(object)null;

	public float CurLatency => 0f;

	public float CurFrameTime => 0f;

	public float CurFps => 0f;

	[Obsolete("Fps is no longer available in PoE2. Use DiagnosticData.FPSValues instead.", true)]
	public short Fps => 0;

	[Obsolete("FloatFps is no longer available in PoE2. Use DiagnosticData.FPSValues instead.", true)]
	public float FloatFps => 0f;

	internal long method_0()
	{
		return 0L;
	}

	[SpecialName]
	private long method_1()
	{
		return 0L;
	}

	[SpecialName]
	internal long method_2()
	{
		return 0L;
	}

	[SpecialName]
	private long method_3()
	{
		return 0L;
	}

	[SpecialName]
	private long method_4()
	{
		return 0L;
	}

	[SpecialName]
	private long method_5()
	{
		return 0L;
	}

	[CompilerGenerated]
	private AreaMap method_6()
	{
		return null;
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static IngameState smethod_3()
	{
		return null;
	}

	static IngameState()
	{
		Class200.smethod_34();
	}
}
