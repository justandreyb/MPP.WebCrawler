using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEBCrawler.Model
{
    class Site
    {
        private String addres;
        private HtmlDocument document;
        private LinkedList<String> innerLinks;

        public Site(String link)
        {
            this.Addres = link;

            HtmlWeb web = new HtmlWeb();
            document = web.Load(link);

            this.innerLinks = HTMLParser.parse(document);
        } 

        public string Addres
        {
            get
            {
                return addres;
            }

            set
            {
                addres = value;
            }
        }
        public HtmlDocument Document
        {
            get
            {
                return document;
            }

            set
            {
                document = value;
            }
        }
        public LinkedList<String> InnerLinks
        {
            get
            {
                return innerLinks;
            }

            set
            {
                innerLinks = value;
            }
        }

    }
}
