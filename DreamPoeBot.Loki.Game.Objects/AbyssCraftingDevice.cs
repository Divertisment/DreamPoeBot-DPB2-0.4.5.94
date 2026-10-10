using DreamPoeBot.Loki.Elements;
using ns0;

namespace DreamPoeBot.Loki.Game.Objects;

public class AbyssCraftingDevice : NetworkObject
{
	public enum ActionResult
	{
		None,
		UiNotOpen,
		ButtonNotAvailable,
		ProcessHookManagerNotEnabled,
		CursorNotEmpty
	}

	private static AbyssCraftingDevice abyssCraftingDevice_0;

	public new AbyssCraftingDeviceElement Ui => null;

	public bool IsInterfaceVisible => true;

	public Item RewardItem => null;

	public bool CanTakeFinger => true;

	public bool CanReturnFinger => true;

	internal AbyssCraftingDevice(NetworkObject entry)
	{
	}

	public ActionResult TakeFinger()
	{
		return (ActionResult)(object)null;
	}

	public ActionResult ReturnFinger()
	{
		return (ActionResult)(object)null;
	}

	private ActionResult method_7(bool bool_0)
	{
		return (ActionResult)(object)null;
	}

	internal static bool smethod_24()
	{
		return true;
	}

	internal static AbyssCraftingDevice smethod_25()
	{
		return null;
	}

	static AbyssCraftingDevice()
	{
		Class200.smethod_34();
	}
}
