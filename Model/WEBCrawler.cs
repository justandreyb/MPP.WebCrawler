using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEBCrawler.Model
{
    class WEBCrawler : IWEBCrawler
    {
        public Task<CrawlResult> PerformCrawlingAsync(LinkedList<string> rootLinks, int maximalDepth)
        {
            CrawlResult result = new CrawlResult();

            Task<CrawlResult> task = new Task<CrawlResult>();
        }
    }
}
