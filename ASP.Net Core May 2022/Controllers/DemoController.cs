using Microsoft.AspNetCore.Mvc;
using System;

namespace ASP.Net_Core_May_2022.Controllers
{
    public class DemoController : Controller
    {
        public string Index(string id)
        {
            return "Hello from controller: " + id;
        }

        public IActionResult OkDemo(int id)
        {
            return Ok("You entered id = " + id );
        }

        public IActionResult json()
        {
            return Json( new { 
                message = "this is a JSON result",
                date = DateTime.Now
            } );
        }

        public IActionResult redirect()
        {
            return Redirect("https://google.com");
        }
    }
}
