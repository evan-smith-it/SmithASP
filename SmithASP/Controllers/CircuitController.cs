﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SmithASP.Controllers
{
    public class CircuitController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}