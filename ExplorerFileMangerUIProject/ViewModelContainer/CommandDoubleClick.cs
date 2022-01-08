using System;
using System.Windows.Input;

namespace ExplorerFileMangerUIProject.ViewModelContainer
{
    public class CommandDoubleClick : ICommand
    {
        private readonly Action<object> open;

        public CommandDoubleClick(Action<object> open)
        {
            this.open = open;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this.open?.Invoke(parameter);
        }

        public event EventHandler CanExecuteChanged;
    }
}