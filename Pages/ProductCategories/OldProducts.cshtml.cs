using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebbshoppenSS.Models;

namespace WebbshoppenSS.Pages.ProductCategories
{
    public class OldProductsModel : PageModel
    {
        public List<Product> GetAllProducts { get; set; }
        public IEnumerable<Product> GetOnlyOldProducts { get; set; }

        public void OnGet()
        {
            GetAllProducts = Data.AllProducts.GetAllProducts();
            GetOnlyOldProducts = GetAllProducts.Where(x => x.ProductCategory.Contains("Old units"));
        }
    }
}
