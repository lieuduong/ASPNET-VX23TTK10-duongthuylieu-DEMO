using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using WebApp.Areas.Admin.Models;

namespace WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string userJson = HttpContext.Session.GetString("user");

            if (string.IsNullOrEmpty(userJson))
            {
                // Nếu không có session => chuyển về trang đăng nhập
                return RedirectToAction("Login", "Account", new { area = "" });
            }

            JObject us = JObject.Parse(userJson);

            Member member = new Member
            {
                UserName = us.SelectToken("UserName")?.ToString(),
                Password = us.SelectToken("Password")?.ToString(),
                Role = Int32.Parse(us.SelectToken("Role")?.ToString() ?? "0")
            };

            return View(member);
        }

    }
}
