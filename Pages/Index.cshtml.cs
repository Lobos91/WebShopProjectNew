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

namespace WebbshoppenSS.Pages
{
    public class IndexModel : PageModel
    {
        public List<Product> Alla { get; set; }
        public IEnumerable<Product> Get3Product { get; set; }

        public void OnGet()
        {
            Alla = AllProducts.GetAllProducts();
            Get3Product = Alla.Where(x => x.Details.Contains("arm")).ToList().Take(3);

            //(For tests only) Return old units
            // Get3Product = Alla.Where(x => x.ProductCategory.Contains("Old units"));  
        }
    }
}
