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

        public string TestButton { get; set; }


        public void OnGet()
        {
            ProductsLight = ProductLight.GetProductsLight();
            ProductsLight = ProductsLight.OrderBy(m => m.ProductID).ToList();

        }

        public void OnPost()
        {
            ProductsLight = ProductLight.GetProductsLight();
            ProductsLight.OrderBy(m => m.ProductID).ToList();
            TestButton = "WOW!";
        }


    }
}