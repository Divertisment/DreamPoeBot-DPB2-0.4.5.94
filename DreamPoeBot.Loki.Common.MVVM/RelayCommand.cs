using System;
using System.Windows.Input;
using ns0;

namespace DreamPoeBot.Loki.Common.MVVM;

public class RelayCommand : ICommand
{
	private readonly Action<object> action_0;

	private readonly Predicate<object> predicate_0;

	private static RelayCommand relayCommand_0;

	public event EventHandler CanExecuteChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	public RelayCommand(Action<object> execute)
	{
	}

	public RelayCommand(Action<object> execute, Predicate<object> canExecute)
	{
	}

	public bool CanExecute(object parameter)
	{
		return true;
	}

	public void Execute(object parameter)
	{
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static RelayCommand smethod_1()
	{
		return null;
	}

	static RelayCommand()
	{
		Class200.smethod_34();
	}
}
