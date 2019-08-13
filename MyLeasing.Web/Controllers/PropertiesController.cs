using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyLeasing.Web.Controllers
{
    public class PropertiesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}