using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MVC.Labs.Day2.EmployeeForm.Helpers
{
    public static class Extentions
    {
        public static MvcHtmlString ULFor(this HtmlHelper caller,ICollection<object> arr)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<ul  class='list-group'");
            foreach (object item in arr)
            {
               
                sb.Append("<a href='#' class='list-group-item list-group-item-action'>");
                sb.Append(item.ToString());
                sb.Append("</a>");

            }
            sb.Append("</ul>");
            return new MvcHtmlString(sb.ToString());
        }
    }
}