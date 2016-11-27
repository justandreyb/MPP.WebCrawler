using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WEBCrawler.Model
{
    class JSONParser
    {
        public LinkedList<string> parse(String json)
        {
            LinkedList<string> container = new LinkedList<string>();
            try
            {
                try
                {
                    container = JsonConvert.DeserializeObject<LinkedList<string>>(json);
                }
                catch
                {
                    Console.WriteLine("Error in JSON file.");
                }
            }
            catch
            {
                throw new Exception();
            }
            return container;
        }
    }
}
