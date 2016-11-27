using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WEBCrawler.Model;
using WEBCrawler.Model.JSON;
using WEBCrawler.ModelView.Dialog;

namespace WEBCrawler.ModelView
{
    class Commands
    {
        private Crawler crawler;
        private CrawlerHandler crawlerHandler;
        private CrawlResult result;

        public Commands(CrawlerHandler crawlerHandler)
        {
            this.crawlerHandler = crawlerHandler;
            crawler = new Crawler(6);
            result = new CrawlResult();

            InitializeCommands();
        }

        private CommandImpl openFileCommand;
        public CommandImpl OpenFileCommand
        {
            get
            {
                return openFileCommand;
            }
        }

        private CommandImpl iAmAliveCommand;
        public CommandImpl IAmAliveCommand
        {
            get
            {
                return iAmAliveCommand;
            }
        }

        private void InitializeCommands()
        {
            openFileCommand = new CommandImpl(async () =>
            {
                LinkedList<string> sites = new LinkedList<string>();
                sites = processingOpenFileCommand();
                foreach (string link in sites)
                {
                    crawlerHandler.ConsoleOutput = link + "\n";
                }
                if (openFileCommand.CanExecute)
                    openFileCommand.CanExecute = false;
             
                result = await Task.Run(() => crawler.PerformCrawlingAsync(sites, 0));
                openFileCommand.CanExecute = true;
                crawlerHandler.ConsoleOutput = result.getSite().Addres;
            });

            iAmAliveCommand = new CommandImpl(async () =>
            {
                ShowIAmAlive();
            });
        }

        private LinkedList<string> processingOpenFileCommand()
        {
            JSONParser jsonParser = new JSONParser();
            LinkedList<string> sites = new LinkedList<string>();

            crawlerHandler.ConsoleOutput = "Processing...\n";
            string json = FileOpenDialog.ShowDialog();
            if (json != "Canceled")
            {
                sites = jsonParser.parse(json);
            }
            else
            {
                crawlerHandler.ConsoleOutput = "Canceled.\n\n";
            }
            return sites;
        }

        private void ShowIAmAlive()
        {
            MessageBox.Show("Dont worry, i'm alive!");
        }

    }
}
