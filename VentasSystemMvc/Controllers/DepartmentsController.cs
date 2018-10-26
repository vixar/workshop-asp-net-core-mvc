﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VentasSystemMvc.Models;

namespace VentasSystemMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {

            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Electronics" });
            list.Add(new Department { Id = 2, Name = "Tools" });

            return View(list);
        }
    }
}