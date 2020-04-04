using Lab11_TimePerson.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab11_TimePerson.Controllers
{
    /// <summary>
    /// Controller file containing 3 IActionResults: an HTTP Get bringing in the beginningYear and endYear as inputted by the user in Index.cshtml, and two HTTP Posts: one to Index sending the beginningYear and endYear data and one to Results.cshtml to it can be shown to the user.
    /// </summary>
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
            
            return RedirectToAction("Results", new { beginningYear, endYear });
        }
    
        public IActionResult Results(int beginningYear, int endYear)
        {
            //redirect to results action with query output
            List<TimePerson> persons = TimePerson.GetPerson(beginningYear, endYear);

            return View(persons);
        }

    }
}
