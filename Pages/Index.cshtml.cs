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
        public IEnumerable<Product> GetFeatured { get; set; }

        public void OnGet(bool IsChecked)
        {
            Alla = AllProducts.GetAllProducts();

            GetFeatured = Alla.Where(x => x.Featured == true);
          
        }
    }
}
