using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEBCrawler.Model.JSON
{
    class JSONCreator
    {
        private LinkedList<string> links = new LinkedList<string>();

        public void create()
        {
            links = new LinkedList<string>();

            //************************** FOR EXAMPLE *************************// 
                            string google = "google.com";
                            links.AddLast(google);
                            string yandex = "yandex.ru";
                            links.AddLast(yandex);
                            string yahoo = "yahoo.com";
                            links.AddLast(yahoo);
                            string mail = "mail.ru";
                            links.AddLast(mail);
                            string vk = "vk.com";
                            links.AddLast(vk);
            //****************************************************************// 

            string json = JsonConvert.SerializeObject(links);
            write(json);
        }

        private void write(String json)
        {
            File.WriteAllText("D://Work/C#/MPP/WEBCrawler/example" + ".json", json);    
        }
    }
}
