﻿using System.Web;
using System.Web.Mvc;

namespace web_new_lumiere
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
