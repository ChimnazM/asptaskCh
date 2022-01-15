using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp.netfirstask.controller
{
    public class HomeController : Controller
    {
        public ViewResult index()
        {
            ViewResult view = new ViewResult();
            view.ViewName = "index";
            return view;
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}
