using BitSample.DataAccess.Model;
using System.Collections.Generic;

namespace BitSample.DataAccess
{
    public class CoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> LoadCoffeeShops()
        {
            yield return new CoffeeShop{Location = "Frankfurk", BeansInStockInKg = 107};
            yield return new CoffeeShop{Location = "Freiburg", BeansInStockInKg = 23};
            yield return new CoffeeShop{Location = "Munich", BeansInStockInKg = 56};
        }
    }
}
