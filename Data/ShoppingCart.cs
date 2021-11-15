using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebbshoppenSS.Models;

namespace WebbshoppenSS.Data
{
    public class ShoppingCart
    {
        public static List<Product> shopCarts { get; set; } = new List<Product>();

        public static List<Product> GetShoppingCart()
        {
            return shopCarts;
        }

        public static void AddToCart(int productId)
        {
            Product productToAdd = Data.AllProducts.GetAllProducts().Where(product => product.ProductID == productId).FirstOrDefault();

            shopCarts.Add(productToAdd);
        }
    }
}
