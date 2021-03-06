using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebbshoppenSS.Models;
using WebbshoppenSS.Data;
using System.Collections;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebbshoppenSS.Pages
{
    public class IndexModel : PageModel
    {
        public List<Product> Alla { get; set; }
        public IEnumerable<Product> GetFeatured { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public void OnGet(bool IsChecked)

        {
            Alla = AllProducts.GetAllProducts();

                var products = from m in AllProducts.Products
                             select m;
                if (!string.IsNullOrEmpty(SearchString))
                {
                    products = products.Where(s => s.Name.Contains(SearchString));
                }

                Alla = products.ToList();

            GetFeatured = Alla.Where(x => x.Featured == true);

        }

        public IActionResult OnPost(int id)
        {

            ShoppingCart.AddToCart(id);

            return RedirectToPage("/Cart");

        }
    }
}
