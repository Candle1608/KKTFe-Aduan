﻿using System.Web;
using System.Web.Mvc;

namespace KKTF_e_Aduan
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
