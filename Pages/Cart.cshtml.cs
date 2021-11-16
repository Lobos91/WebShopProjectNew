using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using WebbshoppenSS.Models;
using System.Linq;
using WebbshoppenSS.Data;


namespace WebbshoppenSS.Pages
{
    public class CartModel : PageModel
    {
        public List<Product> GetShoppingCarts { get; set; }

        [BindProperty]

        // public string ButtonTest { get; set; }
        // public int MyCounter { get; set; }
        public double Shipping { get; set; }
        [BindProperty]
        public string FirstName { get; set; }
        [BindProperty]
        public string LastName { get; set; }
        [BindProperty]

        public int PostalCode { get; set; }
        [BindProperty]
        public string Street { get; set; }
        [BindProperty]
        public string City { get; set; }

        public void OnGet()
        {
            GetShoppingCarts = ShoppingCart.GetShoppingCart();
            GetShoppingCarts.OrderBy(m => m.ProductID).ToList();

        }

        public IActionResult OnPostAdd(int id)
        {

            ShoppingCart.AddToCart(id);

            return RedirectToPage("/Cart");

        }

        public IActionResult OnPostRemove(int id)
        {

            ShoppingCart.RemoveFromCart(id);

            return RedirectToPage("/Cart");

        }

        public IActionResult OnPostAdressShipping()
        {

            return RedirectToPage("/Cart");

        }

        public IActionResult OnPostBuy(int id)
        {
            return RedirectToPage("/Cart");

        }
    }
}
