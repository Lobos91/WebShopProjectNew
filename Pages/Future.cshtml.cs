using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using WebbshoppenSS.Models;
using System.Linq;
using WebbshoppenSS.Data;


namespace WebbshoppenSS.Pages
{
    public class FutureModel : PageModel
    {
        public List<FutureAge> ProductsHeavy { get; set; }
        public string TestButton { get; set; }
        public void OnGet()
        {
            ProductsHeavy = ProductHeavy.GetProductsHeavy();
            ProductsHeavy.OrderBy(m => m.ProductID).ToList();
        }

        public void OnPost()
        {
            ProductsHeavy = ProductHeavy.GetProductsHeavy();
            ProductsHeavy.OrderBy(m => m.ProductID).ToList();
            TestButton = "WOW!";
        }
    }
}