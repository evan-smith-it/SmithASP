﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmithASP.ViewComponents
{
    public class LoginViewComponent : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }

    }
}
