using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WEBCrawler.ModelView
{
    class CrawlerHandler : INotifyPropertyChanged
    {
        private Commands command;
        public Commands Command
        {
            get
            {
                if (command == null)
                {
                    command = new Commands(this);
                }
                return command;
            }
        }

        private string consoleOutput;
        public string ConsoleOutput
        {
            get { return consoleOutput; }
            set
            {
                consoleOutput = consoleOutput + value;
                OnPropertyChanged("ConsoleOutput");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
