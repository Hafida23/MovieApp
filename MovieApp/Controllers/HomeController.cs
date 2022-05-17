using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieApp.Data;
using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly MovieDbContext _context;

        public HomeController(MovieDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
             var result= _context.Movies.ToList();
            return View(result);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var Movie = _context.Movies.SingleOrDefault(e => e.Id == id); 
            return View(Movie);
                   
        }
        [HttpPost]
        public IActionResult Edit(Movie mov)
        {
            var movie = _context.Movies
                .FirstOrDefault(e => e.Id == mov.Id);

            if (ModelState.IsValid)
            {
                movie.Title=mov.Title;
                movie.Length=mov.Length;
                movie.Genre=mov.Genre;
                movie.MainActor=mov.MainActor;
                movie.DateRelease=mov.DateRelease;

                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var Movie = _context.Movies.SingleOrDefault(e => e.Id == id);
            return View(Movie);

        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var Movie = _context.Movies.SingleOrDefault(e => e.Id == id);
            return View(Movie);

        }
        [HttpPost]
        public IActionResult Delete(Movie mov)
        {
            var Movie = _context.Movies.SingleOrDefault(e => e.Id.Equals(mov.Id));
            _context.Remove(Movie);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Movie movie)
        {
             _context.Movies.Add(movie);
             _context.SaveChanges();

            return RedirectToAction(nameof(Index));
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
