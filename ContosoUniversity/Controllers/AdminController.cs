﻿using Microsoft.AspNetCore.Mvc;

namespace ContosoUniversity.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
