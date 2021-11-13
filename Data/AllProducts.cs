using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebbshoppenSS.Models;

namespace WebbshoppenSS.Data
{
    public static class AllProducts
    {
        public static List<Product> Products { get; set; }
        
        public static IEnumerable<MiddleAge> ProductsLight { get; private set; }
        public static IEnumerable<NowAge> ProductsMedium { get; private set; }
        public static IEnumerable<FutureAge> ProductsHeavy { get; private set; }

        public static List<Product> GetAllProducts()
        {
            Products = new List<Product>();

            ProductsLight = ProductLight.GetProductsLight();
            ProductsMedium = ProductMedium.GetProductsMedium();
            ProductsHeavy = ProductHeavy.GetProductsHeavy();

            Products.AddRange(ProductsLight);
            Products.AddRange(ProductsHeavy);
            Products.AddRange(ProductsMedium);
            
            return Products;
        }




    }
}
