using GiftCalculator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using GiftCalculator.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace GiftCalculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new GiftCostViewModel();
            model.Gifts = new Dictionary<string, string>();

            model.Gifts.Add("A Goat", "Animals");
            model.Gifts.Add("A Cow", "Animals");
            model.Gifts.Add("School Pencils", "Education");
            model.Gifts.Add("Water and Sanitation", "Health");
            model.Gifts.Add("Food for life", "Health");
            model.Gifts.Add("Clean drinking water", "Health");

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(IFormCollection form)
        {

            string gift = Request.Form["giftType"];

            int total = 0;
            var category = "";
            var price = 0;
            switch (gift)
            {
                case "A Goat":
                    price = 10;
                    category = "Animals";
                    break;
                case "A Cow":
                    price = 100;
                    category = "Animals";
                    break;
                case "School Pencils":
                    price = 5;
                    category = "Education";
                    break;
                case "Water and Sanitation":
                    price = 2000;
                    category = "Health";
                    break;
                case "Food for life":
                    price = 5000;
                    category = "Health";
                    break;
                case "Clean drinking water":
                    price = 3000;
                    category = "Health";
                    break;
                default:
                    category = "None";
                    break;
            }

            //Add postage costs
            switch (category)
            {
                case "Animals":
                    total = price + 20;
                    break;
                case "Education":
                    total = price + 50;
                    break;
                case "Health":
                    total = price + 100;
                    break;
            }


            ViewBag.Total = total;


            return View("Total");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
