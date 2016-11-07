using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEBCrawler.Model
{
    class CrawlResult
    {
        LinkedList<Site> sites;

        public CrawlResult()
        {
            sites = new LinkedList<Site>();
        }

        public void addSite(Site site)
        {
            this.sites.AddLast(site);
        }

        public LinkedList<Site> getSites()
        {
            return this.sites;
        }

    }
}
