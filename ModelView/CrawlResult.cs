using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEBCrawler.Model
{
    class CrawlResult
    {
        Site site = null;
        LinkedList<CrawlResult> results;

        public CrawlResult()
        {
            results = new LinkedList<CrawlResult>();
        }

        public void setSite(Site site)
        {
            this.site = site;
        }

        public void addResult(CrawlResult result)
        {
            this.results.AddLast(result);
        }

        public Site getSite()
        {
            return this.site;
        }

    }
}
