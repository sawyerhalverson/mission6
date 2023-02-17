using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public IActionResult EnterMovie()
        {
            ViewBag.Categories = _myContext.Categories.ToList();
            return View();
        }

        //differentiate post and get actions

        [HttpPost]
        public IActionResult EnterMovie(MovieResponse response) //create a response object from this class
        {   //validation
            if (ModelState.IsValid) { 
            _myContext.Add(response);
            _myContext.SaveChanges();
            return View("Confirmation", response);
        }
            else
            {
                ViewBag.Categories = _myContext.Categories.ToList();
                return View();
            }
        }

        //create new action to navigate to the Podcasts page
        [HttpGet]
        public IActionResult Podcasts()
        {
            return View("Podcasts");
        }
        


        [HttpGet]
        public IActionResult MovieList ()
        {
            var movies = _myContext.responses
                .Include(x => x.Category)
                .OrderBy(x => x.Title).ToList();
            return View(movies);
        }


        //add in edit and delete functions
        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = _myContext.Categories.ToList();

            var movieEntry = _myContext.responses.Single(x => x.MovieId == movieid);

            return View("EnterMovie", movieEntry);
        }

        [HttpPost]

        public IActionResult Edit (MovieResponse newResponse)
        {

            _myContext.Update(newResponse);
            _myContext.SaveChanges();
            return RedirectToAction("MovieList");
        }
        
        //create a delete action

        [HttpGet]
        public IActionResult Delete(int movieid)
        {

            var entry = _myContext.responses.Single(x => x.MovieId == movieid);
            return View(entry);
        }

        [HttpPost]
        public IActionResult Delete(MovieResponse response)
        {

            _myContext.responses.Remove(response);
            _myContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
