using HtmlAgilityPack;
using System;
using System.Collections.Generic;

namespace WEBCrawler.Model
{
    class HTMLParser
    {
        public static LinkedList<String> parse(HtmlDocument currentHTMLDocument)
        {
            LinkedList<String> links = new LinkedList<String>();
           
            try
            {
                if (currentHTMLDocument != null)
                {
                    foreach (HtmlNode link in currentHTMLDocument.DocumentNode.SelectNodes("//a[@href]"))
                    {
                        String hrefValue = link.GetAttributeValue("href", string.Empty);
                        if (hrefValue[0] == 'h')
                            links.AddLast(hrefValue);
                    }
                }
                return links;
            }
            catch
            {
                return null;
            }
        }
    }
}
