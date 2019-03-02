using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetcoreApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotnetcoreApp.Controllers
{
    public class AccountController : Controller
    {
        //private string SessionID = "0";
        //private string SessionUsername = "_Name";
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string Username, string password)
        {
            string UserID = string.Empty;
            string UserName = string.Empty;

            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(password))
            {
                ViewData["invalidUser"] = "InValid User";
                return View("Login");
            }
            if (password.Contains("AP-") || password.Contains("ap-"))
            {
                password = password.Replace("AP-", "");
                password = password.Replace("ap-", "");
            }
            try
            {

                var Users = DAL.getUser(Username, password);

                if (Users != null)
                {
                    HttpContext.Session.SetString("SessionUsername", Users.Username);
                    HttpContext.Session.SetInt32("SessionID", Convert.ToInt32(Users.UserId));
                    UserID = HttpContext.Session.GetInt32("SessionID").ToString();
                    UserName = HttpContext.Session.GetString("SessionUsername").ToString();

                    return RedirectToAction("Index", "Home");
                }
                ViewData["invalidUser"] = "InValid User";
                return View("Login");
            }
            catch (Exception ex)
            {
                
                ViewData["invalidUser"] = "InValid User";
                return View("Login");
            }
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Account");
        }


    }
}