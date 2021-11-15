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
        }
    }
}
