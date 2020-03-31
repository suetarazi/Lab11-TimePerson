﻿using Lab11_TimePerson.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab11_TimePerson.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Index(int beginningYear, int endYear)
        {
            //redirect to results action with query output
            List<TimePerson> persons = TimePerson.GetPerson(beginningYear, endYear);

            return null;
        }
    
        public IActionResult Results(List<TimePerson> persons)
        {
            return View(persons);
        }

    }
}