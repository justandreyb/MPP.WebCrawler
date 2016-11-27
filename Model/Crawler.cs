using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEBCrawler.Model
{
    class Crawler : IWEBCrawler
    {
        private int maximalDepth;
        private CrawlResult result;

        public Crawler(int maximalDepth)
        {
            this.maximalDepth = maximalDepth;
            this.result = new CrawlResult();
        }

        public async Task<CrawlResult> PerformCrawlingAsync(LinkedList<string> links, int depth)
        {
            CrawlResult currentCrawlResult = new CrawlResult();
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
                            currentCrawlResult = await PerformCrawlingAsync(currentSite.InnerLinks, depth + 1);
                        }
                        if (currentCrawlResult != null)
                        {
                            result.addResult(currentCrawlResult);
                        }
                        currentCrawlResult.setSite(currentSite);
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
