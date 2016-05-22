using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using DunwoodCrossing.Classes;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Hosting;
using System.IO;
using DunwoodCrossing.ViewModels;

namespace DunwoodCrossing.Controllers
{
    public class RulesController : Controller
    {


        public IActionResult Index()
        {
           
            return View();
        }
    }
}
