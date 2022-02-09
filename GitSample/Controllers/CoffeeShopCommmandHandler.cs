using GitSample.Models;
using System;

namespace GitSample.Controllers
{
    internal class CoffeeShopCommmandHandler : ICoffeeShopCommmandHandler
    {
        public CoffeeShopCommmandHandler()
        {
        }

        public string HandleCommand()
        {
            var data = new CoffeeShopData();
            // var coffeeShops = data.ShopData.LoadCoffeeShops();
            string shops = string.Empty;
            foreach (var coffeeShop in data.GetData())
            {
                shops += coffeeShop.Location + coffeeShop.BeansInStockInKg + " \n";
            }
            return shops;
        }
    }
}