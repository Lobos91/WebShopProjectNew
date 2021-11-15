using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using WebbshoppenSS.Models;
using System.Linq;
using WebbshoppenSS.Data;


namespace WebbshoppenSS.Pages
{
    public class PresentModel : PageModel
    {
        public List<NowAge> ProductsMedium { get; set; }
        public string TestButton { get; set; }
        public void OnGet()
        {
            ProductsMedium = ProductMedium.GetProductsMedium();
            ProductsMedium.OrderBy(m => m.ProductID).ToList();
        }

        public IActionResult OnPost(int id)
        {

            ShoppingCart.AddToCart(id);

            return RedirectToPage("/Present");

            //ProductsHeavy = ProductHeavy.GetProductsHeavy();
            //ProductsHeavy.OrderBy(m => m.ProductID).ToList();
            //TestButton = "WOW!";
        }

    }
}
