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

            productToAdd.Quanity += -1;
            productToAdd.Amount += 1;


            shopCarts.Add(productToAdd);
        }

        public static void RemoveFromCart(int productId)
        {
            Product productToRemove = Data.AllProducts.GetAllProducts().Where(product => product.ProductID == productId).FirstOrDefault();

            productToRemove.Quanity += +1;
            productToRemove.Amount += -1;


            shopCarts.Remove(productToRemove);
        }
    }
}
