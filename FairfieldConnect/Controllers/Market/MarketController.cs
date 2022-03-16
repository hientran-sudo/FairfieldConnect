// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using Microsoft.AspNetCore.Mvc;

namespace FairfieldConnect.Controllers
{
    public class MarketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Sell()
        {
            return View();

        }
        public IActionResult Shop()
        {
            return View();
        }
    }
}
