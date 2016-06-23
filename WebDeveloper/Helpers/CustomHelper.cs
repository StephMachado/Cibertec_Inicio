using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebDeveloper.Helpers
{
    public static class CustomHelper
    {
        #region "Price"
        public static IHtmlString DisplayPriceStatic(double price)
        {
            string mensaje = string.Empty;
            if (price == 0.0)
                mensaje = "<span>Free!!!</span>";
            else
                mensaje = $"<span>{price}</span>";
            return new HtmlString(mensaje);
        }

        public static IHtmlString DisplayPriceExtension(this HtmlHelper helper, double price)
        {
            //El uso de esta función es mejor, porque el Helper está embebido.
            string mensaje = string.Empty;
            if (price == 0.0)
                mensaje = "<span>Free!!!</span>";
            else
                mensaje = $"<span>{price}</span>";
            return new HtmlString(mensaje);
        }

        #endregion

        #region "Date"
        public static IHtmlString DisplayDateOrNullExtension(this HtmlHelper helper, DateTime? date)
        {
            return new HtmlString(GetHtmlForDate(date));
        }

        private static string GetHtmlForDate(DateTime? date)
        {
            return date == null ? "<span>Free!!!</span>" : $"<span>{date.Value.ToString("dd/MM/yyyy")}</span>";
        }

        public static IHtmlString DisplayDateOrNullStatic(DateTime? date)
        {
            return new HtmlString(GetHtmlForDate(date));
        }

        #endregion
    }
}