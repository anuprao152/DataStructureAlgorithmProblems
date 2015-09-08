using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;  

namespace MyWebPageApp.Infrastructure
{
    public static class CustomeHelper
    {
        public static MvcHtmlString ListItemsFor(this HtmlHelper html, string[] list)
        {
            TagBuilder tag = new TagBuilder("ul");
            foreach ( string str in list)
            {
                TagBuilder itemtag = new TagBuilder("li");
                itemtag.SetInnerText(str);
                tag.InnerHtml +=  itemtag.ToString();
            }
            return new MvcHtmlString(tag.ToString());
        }

        public static string SimpleLink(this HtmlHelper html, string url, string text)
        {
            return String.Format("<a href=\"{0}\">{1}</a>", url, text);
        }
    }
}