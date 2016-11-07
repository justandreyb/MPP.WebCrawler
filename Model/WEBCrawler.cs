using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEBCrawler.Model
{
    class WEBCrawler : IWEBCrawler
    {
        int maximalDepth;
        CrawlResult result;

        public WEBCrawler(int maximalDepth)
        {
            this.maximalDepth = maximalDepth;
            result = new CrawlResult();
        }

        public async Task<CrawlResult> PerformCrawlingAsync(LinkedList<string> links, int depth)
        {
            CrawlResult currentCrawl = new CrawlResult();
            foreach (string link in links)
            {
                try
                {
                    Site currentSite = null;
                    if (depth < maximalDepth)
                    {
                        currentSite = SiteSurfer.watchSite(link);
                        if (currentSite.InnerLinks != null)
                        {
                            currentCrawl = await PerformCrawlingAsync(currentSite.InnerLinks, depth + 1);
                        }
                        if (currentCrawl != null)
                        {
                            result.addResult(currentCrawl);
                        }
                        currentCrawl.setSite(currentSite);
                    }

                }
                catch {
                    throw new Exception();
                }
            }
            return result;
        }
    }
}
