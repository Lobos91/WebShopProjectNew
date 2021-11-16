using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebbshoppenSS.Data;
using WebbshoppenSS.Models;

namespace WebbshoppenSS.Pages.Admin
{
    public class ManagerModel : PageModel
    {
        public List<Product> GetAllProducts { get; set; }
        public List<Product> Result { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }



        public void OnGet()
        {
            GetAllProducts = Data.AllProducts.GetAllProducts();
            Result = GetAllProducts.OrderBy(m => m.ProductID).ToList();

            var products = from m in AllProducts.Products
                           select m;
            if (!string.IsNullOrWhiteSpace(SearchString))
            {
                products = products.Where(s => s.Name.ToLower().Contains(SearchString));
            }

            Result = products.ToList();
        }
      
    }
}
