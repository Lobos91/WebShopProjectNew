using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using WebbshoppenSS.Models;
using System.Linq;
using WebbshoppenSS.Data;

namespace WebbshoppenSS.Pages
{
    public class CartModel : PageModel
    {
        public List<Product> GetShoppingCarts { get; set; }


        public void OnGet()
        {
            //funkar lite
            GetShoppingCarts = ShoppingCart.GetShoppingCart();
            GetShoppingCarts.OrderBy(m => m.ProductID).ToList();

            //var duplicates = GetShoppingCarts
            //      .GroupBy(r => r.ProductID)
            //      .Where(g => g.Count() > 1)
            //      .ToList();

            //GetShoppingCarts
            //      .GroupBy(r => r.ProductID)
            //      .Select(g => g.First())
            //      .ToList();

        }


    }
}
