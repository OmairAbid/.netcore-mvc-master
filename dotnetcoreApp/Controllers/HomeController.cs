using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetcoreApp.Models;
using Microsoft.AspNetCore.Http;

namespace dotnetcoreApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string userid = HttpContext.Session.GetInt32("SessionID").ToString();
            string UserName = HttpContext.Session.GetString("SessionUsername").ToString();
            if (string.IsNullOrEmpty(userid))
            {
                return RedirectToAction("Login", "Account");
            }
            try
            {
                return View();
                //kuch
            }
            catch (Exception ex)
            {
                return null;

            }
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
