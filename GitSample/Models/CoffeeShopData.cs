using BitSample.DataAccess;
using BitSample.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitSample.Models
{
    public class CoffeeShopData
    {
        public CoffeeShopDataProvider ShopData { get; }
        
        public IEnumerable<CoffeeShop> GetData()
        {
            var data = new CoffeeShopDataProvider();
            return data.LoadCoffeeShops();
        }
    }
}
