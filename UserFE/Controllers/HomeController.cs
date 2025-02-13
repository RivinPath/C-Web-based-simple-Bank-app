﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UserFE.Models;

namespace UserFE.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View(); 
        }

        public IActionResult ShowTransactions()
        {
            return View();
        }



        public IActionResult Dashboard()
        {
            return View(); 
        }

        public IActionResult UpdateProfile()
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
