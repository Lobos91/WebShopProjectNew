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
        public int MyCounter { get; set; }

        public void OnGet(int add)
        {
            ProductsLight = ProductLight.GetProductsLight();
            ProductsLight = ProductsLight.OrderBy(m => m.ProductID).ToList();
            Models.Count.Counter += add;
            MyCounter = Models.Count.Counter;
        }

        public void OnPost(int add)
        {

            ProductsLight = ProductLight.GetProductsLight();
            ProductsLight.OrderBy(m => m.ProductID).ToList();
            TestButton = "WOW!";
        }


    }
}