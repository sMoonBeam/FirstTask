using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lecture1.Helpers
{
    public static class CheckHelper
    {
        public static MvcHtmlString displayBox(this HtmlHelper html, string checkBoxResult)
        {
            var itemsList = new TagBuilder("ul");
            var checkBoxList = checkBoxResult.Split(new char[] {','});
            foreach(var temp in checkBoxList)
            {
                if (temp != "false")
                {
                    var item = new TagBuilder("li");
                    item.SetInnerText(temp);
                    itemsList.InnerHtml += item.ToString();
                }
            }
            return new MvcHtmlString(itemsList.ToString());
        }
    }
}