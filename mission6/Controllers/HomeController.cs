using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mission6.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace mission6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieEntryContext _myContext { get; set; }


        //Constructor
        public HomeController(ILogger<HomeController> logger, MovieEntryContext newContext)
        {
            _logger = logger;
            _myContext = newContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EnterNewMovie()
        {
            return View("EnterMovie");
        }

        //differentiate post and get actions

        [HttpPost]
        public IActionResult EnterNewMovie(MovieResponse response) //create a response object from this class
        {
            _myContext.Add(response);
            _myContext.SaveChanges();
            return View("Confirmation", response);
        }

        //create new action to navigate to the Podcasts page
        [HttpGet]
        public IActionResult Podcasts()
        {
            return View("Podcasts");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
