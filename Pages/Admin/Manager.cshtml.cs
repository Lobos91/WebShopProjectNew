using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebbshoppenSS.Models;

namespace WebbshoppenSS.Pages.Admin
{
    public class ManagerModel : PageModel
    {
        public List<Product> GetAllProducts { get; set; }
        public List<Product> Result { get; set; }

        public void OnGet()
        {
           GetAllProducts = Data.AllProducts.GetAllProducts();
           Result = GetAllProducts.OrderBy(m => m.ProductID).ToList();
        }
    }
}
