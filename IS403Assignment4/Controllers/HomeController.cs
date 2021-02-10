using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IS403Assignment4.Models;

namespace IS403Assignment4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Home()
        {
            return View();

        }
        public IActionResult TopRestauraunts()
        {
            List<string> RestaurauntList = new List<string>();

            foreach(DefaultListEntry d in DefaultListEntry.GetPlaces())
            {
                // check for null fav dish
                string? fav_dish = d.FavoriteDish ??  "It's all Delicous" ;

                RestaurauntList.Add($" Rank: {d.Rank}) " +
                    $"Name: {d.RestaurauntName} | Address: {d.Adress} " + Environment.NewLine +
                    $"| Favorite Dish: {fav_dish} | Phone Number: {d.PhoneNumber}" +
                    $"| Web Link: {d.WebLink}");
            };
            return View(RestaurauntList);
        }


        public IActionResult SuggestedRestauraunts()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SuggestedRestauraunts(PersonalListEntry personalListEntry)
        {
            if (ModelState.IsValid)
            {
                TempStorage.addListEntry(personalListEntry);
                return View();
            }
            else
            {
                return View();
            }
          
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
