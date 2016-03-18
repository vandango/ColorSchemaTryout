using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using myTest1.ViewModels.HomeModels;

namespace myTest1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public IActionResult Index()
        {
            var model = new IndexModel() {
                Test = "Ein Test2"
            };
			
			return View(model);
        }
    }
}