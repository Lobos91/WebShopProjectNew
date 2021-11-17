using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using WebbshoppenSS.Models;
using System.Linq;
using WebbshoppenSS.Data;

namespace WebbshoppenSS.Pages
{
    public class PastModel : PageModel
    {
        public List<MiddleAge> ProductsLight { get; set; }

        public void OnGet(int add)
        {
            ProductsLight = ProductLight.GetProductsLight();
            ProductsLight = ProductsLight.OrderBy(m => m.ProductID).ToList();
        }

        public IActionResult OnPost(int id)
        {

            ShoppingCart.AddToCart(id);

            return RedirectToPage("/Past");

        }


    }
}