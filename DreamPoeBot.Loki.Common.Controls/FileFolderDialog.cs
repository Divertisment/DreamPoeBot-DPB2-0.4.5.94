using System.Windows.Forms;
using ns0;

namespace DreamPoeBot.Loki.Common.Controls;

public class FileFolderDialog : CommonDialog
{
	private OpenFileDialog mMaAdWbyiOx;

	private static FileFolderDialog fileFolderDialog_0;

	public OpenFileDialog Dialog
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string SelectedPath
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string SelectedPaths => null;

	public new DialogResult ShowDialog()
	{
		return (DialogResult)(object)null;
	}

	public new DialogResult ShowDialog(IWin32Window owner)
	{
		return (DialogResult)(object)null;
	}

	public override void Reset()
	{
	}

	protected override bool RunDialog(nint hwndOwner)
	{
		return true;
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static FileFolderDialog smethod_1()
	{
		return null;
	}

	static FileFolderDialog()
	{
		Class200.smethod_34();
	}
}
