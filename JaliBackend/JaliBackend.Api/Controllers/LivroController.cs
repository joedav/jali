﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JaliBackend.Api.Controllers
{
    /// <summary>
    /// Controller de livro
    /// </summary>
    public class LivroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
