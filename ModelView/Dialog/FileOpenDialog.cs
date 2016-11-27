using Microsoft.Win32;
using System.IO;
using WEBCrawler.Interface;

namespace WEBCrawler.ModelView.Dialog
{
    class FileOpenDialog : IDialog
    {
        public static new string ShowDialog()
        {
            string path;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.json)|*.json";
            if (openFileDialog.ShowDialog() == true)
                path = File.ReadAllText(openFileDialog.FileName);
            else
            {
                path = "Canceled";
            }
            return path;
        }
    }
}
