using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lecture1.Models;

namespace lecture1.Helpers
{
    public static class CommentsHelper
    {
        public static MvcHtmlString dislpayComments(this HtmlHelper html)
        {
            CommentsContent content = new CommentsContent();
            var div = new TagBuilder("div");
            div.MergeAttribute("class", "content");
            foreach (var item in CommentsContent.articles)
            {

                var innerDiv = new TagBuilder("div");
                innerDiv.MergeAttribute("class", "contentBlock");
                var headerH4 = new TagBuilder("h4");
                headerH4.SetInnerText(item.Name);
                var textH6 = new TagBuilder("h6");
                textH6.SetInnerText(item.Text);
                textH6.MergeAttribute("class", "contentText");
                var dateDiv = new TagBuilder("div");
                dateDiv.MergeAttribute("class", "contentDate");
                var dateH6 = new TagBuilder("h6");
                dateH6.SetInnerText("Post date: " + item.Data.ToString("d"));
                dateDiv.InnerHtml += dateH6.ToString();
                innerDiv.InnerHtml += headerH4.ToString();
                innerDiv.InnerHtml += textH6.ToString();
                innerDiv.InnerHtml += dateDiv.ToString();
                div.InnerHtml += innerDiv.ToString();
            }
            return new MvcHtmlString(div.ToString());
        }
    }
}