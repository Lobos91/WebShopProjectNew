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
    public class EditModel : PageModel
    {
        public int ProdID { get; set; }
        public List<Army> Products { get; set; }
        public List<Army> Product { get; set; }

        public string Category { get; set; }
        public ProductType UnitCategory { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductQuanity { get; set; }
        public string ProductImage { get; set; }
        public string ProductDetails { get; set; }

        public void OnGet(int Id)
        {
            Products = Data.AllProducts.GetAllProducts();
            Product = Products.Where(prodID => prodID.ProductID == Id).ToList();
            ProdID = Id;
        }

        public void OnPost()
        {
            Army product = Product.Where(x => x.ProductID == ProdID).FirstOrDefault();

            if (Category == "ProductLight")
            {
                product = new MiddleAge()
                {
                    Name = ProductName,
                    Price = ProductPrice,
                    Quanity = ProductQuanity,
                    Details = ProductDetails,
                    ImgUrl = "/img/" + ProductImage, 
                    ProductType = UnitCategory
                };
            }
            if (Category == "ProductMedium")
            {
                product = new NowAge()
                {
                    Name = ProductName,
                    Price = ProductPrice,
                    Quanity = ProductQuanity,
                    Details = ProductDetails,
                    ImgUrl = "/img/" + ProductImage,
                    ProductType = UnitCategory
                };
            }
            if (Category == "ProductHeavy")
            {
                product = new FutureAge()
                {
                    Name = ProductName,
                    Price = ProductPrice,
                    Quanity = ProductQuanity,
                    Details = ProductDetails,
                    ImgUrl = "/img/" + ProductImage,
                    ProductType = UnitCategory
                };
            }
        }
    }
}
