using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEBCrawler.Model
{
    interface IWEBCrawler
    {
        Task<CrawlResult> PerformCrawlingAsync(LinkedList<string> rootLinks, int depth);
    }
}
