using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WEBCrawler.Model
{
    class SiteSurfer
    {
        public static Site watchSite(String addres)
        {
            Site site = new Site(addres);
            site.initialize();
            return site;
        }
    }
}
