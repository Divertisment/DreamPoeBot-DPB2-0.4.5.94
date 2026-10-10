namespace DreamPoeBot.Framework;

public struct ChooseColor
{
	public int lStructSize;

	public nint hwndOwner;

	public nint hInstance;

	public int rgbResult;

	public nint lpCustColors;

	public int Flags;

	public nint lCustData;

	public CCHookProc lpfnHook;

	public nint lpTemplateName;
}
