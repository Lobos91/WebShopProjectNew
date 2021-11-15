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
        public List<Product> Products { get; set; }
        //public List<Product> SelectedProduct { get; set; }
        public Product SelectedProduct { get; set; }

        public string Category { get; set; }  
        public ProductType UnitCategory { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductQuanity { get; set; }
        public string ProductImage { get; set; }
        public string ProductDetails { get; set; }
        public string  ProdCategory { get; set; }

        public void OnGet(int Id)
        {
            Products = Data.AllProducts.GetAllProducts();
            SelectedProduct = Products.Where(prodID => prodID.ProductID == Id).FirstOrDefault();
            ProdID = Id;
        }

        public IActionResult OnPost()
        {
            Products = Data.AllProducts.GetAllProducts();
            //SelectedProduct = Products.Where(prodID => prodID.ProductID == ProdID).FirstOrDefault();
            if (Category == "ProductLight")
            {
                Product updatedProduct = new Product()
                {
                    ProductID = ProdID,
                    Name = ProductName,
                    ProductType = UnitCategory,
                    Price = ProductPrice,
                    Quanity = ProductQuanity,
                    ImgUrl = ProductImage,
                    Details = ProductDetails,
                    ProductCategory = new List<string> { "Old units" }

                 };
                Data.AllProducts.UpdateProduct(updatedProduct);
            };


            if (Category == "ProductMedium")
            {
                Product updatedProduct = new Product()
                {
                    ProductID = ProdID,
                    Name = ProductName,
                    ProductType = UnitCategory,
                    Price = ProductPrice,
                    Quanity = ProductQuanity,
                    ImgUrl = ProductImage,
                    Details = ProductDetails,
                    ProductCategory = new List<string> { "Modern units" }
                };

                Data.AllProducts.UpdateProduct(updatedProduct);

            };

            if (Category == "ProductHeavy")
            {
                Product updatedProduct = new Product()
                {
                    ProductID = ProdID,
                    Name = ProductName,
                    ProductType = UnitCategory,
                    Price = ProductPrice,
                    Quanity = ProductQuanity,
                    ImgUrl = ProductImage,
                    Details = ProductDetails,
                    ProductCategory = new List<string> { "Future units" }
                };

                Data.AllProducts.UpdateProduct(updatedProduct);

            };
           
           
            return RedirectToPage("/Admin/Manager");
        }
    }
}
