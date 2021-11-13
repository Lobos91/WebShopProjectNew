using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebbshoppenSS.Models;

namespace WebbshoppenSS.Pages.Admin
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        public string Category { get; set; }
        public ProductType UnitCategory { get; set; }
        public int ProdID { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductQuanity { get; set; }
        public string ProductImage { get; set; }
        public string ProductDetails { get; set; }

        public string Message { get; set; }

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            
            if (Category == "ProductLight")
            {
               Data.ProductLight.ProductsLight.Add(new MiddleAge 
                {
                            ProductID = ProdID,
                            Name = ProductName, 
                            Price = ProductPrice , 
                            Quanity = ProductQuanity,
                            ImgUrl = "/img/" + ProductImage, 
                            Details = ProductDetails,
                            ProductType = UnitCategory,
                            ProductCategory = new List<string>() { "Old units" },

               });

            }
            else if (Category == "ProductMedium")
            {
                Data.ProductMedium.ProductsMedium.Add(new NowAge
                {
                    ProductID = ProdID,
                    Name = ProductName,
                    Price = ProductPrice,
                    Quanity = ProductQuanity,
                    ImgUrl = "/img/" + ProductImage,
                    Details = ProductDetails,
                    ProductType = UnitCategory,
                    ProductCategory = new List<string>() { "Modern units" },
                });

            }
            else if (Category == "ProductHeavy")
            {
                Data.ProductHeavy.ProductsHeavy.Add(new FutureAge
                {
                    ProductID = ProdID,
                    Name = ProductName,
                    Price = ProductPrice,
                    Quanity = ProductQuanity,
                    ImgUrl = "/img/" + ProductImage,
                    Details = ProductDetails,
                    ProductType = UnitCategory,
                    ProductCategory = new List<string>() { "Future units" },
                });

            }
            return RedirectToPage("/Admin/Manager" );
        }
    }
}
