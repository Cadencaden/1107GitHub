﻿using System.Web;
using System.Web.Mvc;

namespace Rest_a_go
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
