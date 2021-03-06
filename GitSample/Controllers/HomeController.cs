using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GitSample.Models;

namespace GitSample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Index.";

            return View();
        }

        public IActionResult About()
        {          

            var data = new CoffeeShopData();
           // var coffeeShops = data.ShopData.LoadCoffeeShops();
            string shops = string.Empty;
            foreach (var coffeeShop in data.GetData())
            {
                shops += coffeeShop.Location + coffeeShop.BeansInStockInKg + " \n";               
            }

            ViewData["Message"] = shops;

            return View();
        }

        public IActionResult Contact()
        {

            
            ViewData["Message"] = "Your contact page.";

            

            return View();
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
