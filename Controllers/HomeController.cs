using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Title = "Home";

            dynamic d = new ExpandoObject();
            d.Id = 1;
            d.Name = "jeff frank";
            ViewBag.Data = d;
            return View();
        }
    }
}