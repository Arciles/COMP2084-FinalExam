﻿using System.Web;
using System.Web.Mvc;

namespace COMP2084_FinalExam
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
