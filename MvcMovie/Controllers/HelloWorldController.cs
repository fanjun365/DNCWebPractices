﻿using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/
        //public string Index()
        //{
        //    return "This is my default action...";
        //}
        public IActionResult Index()
        {
            return View();
        }

        //// 
        //// GET: /HelloWorld/Welcome/ 
        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //}

        //// GET: /HelloWorld/Welcome/ 
        //// Requires using System.Text.Encodings.Web;
        //public string Welcome(string name, int id = 1, int numTimes = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, ID: {id}, NumTimes is: {numTimes}");
        //}

        public IActionResult Welcome(string name, int id = 1, int numTimes = 1)
        {
            ViewData["Message"] = $"Hello {name}, ID: {id}, NumTimes is: {numTimes}";
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}