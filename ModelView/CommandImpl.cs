using System;
using System.Windows.Input;
using System.Threading.Tasks;

namespace WEBCrawler.ModelView
{
    public class CommandImpl : ICommand
    {
        private readonly Func<Task> command;
        private bool canExecute = true;
        public event EventHandler CanExecuteChanged;
        public bool CanExecute
        {
            get { return canExecute; }
            set
            {
                if (canExecute != value)
                {
                    canExecute = value;
                    EventHandler canExecuteChanged = CanExecuteChanged;
                    if (canExecuteChanged != null)
                    {
                        canExecuteChanged(this, EventArgs.Empty);
                    }
                }
            }
        }

        public CommandImpl(Func<Task> command)
        {
            this.command = command;
        }

        async void ICommand.Execute(object parameter)
        {
            try {
                await ExecuteAsync(parameter);
            } catch
            {
                throw new Exception();
            }
        }

        public Task ExecuteAsync(object parameter)
        {
            return command();
        }


        bool ICommand.CanExecute(object parameter)
        {
            return canExecute;
        }

    }
}
