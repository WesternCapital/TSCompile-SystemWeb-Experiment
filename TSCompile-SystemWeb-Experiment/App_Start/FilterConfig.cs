﻿using System.Web;
using System.Web.Mvc;

namespace TSCompile_SystemWeb_Experiment
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
