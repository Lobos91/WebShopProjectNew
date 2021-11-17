using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebbshoppenSS.Models;

namespace WebbshoppenSS.Data
{
    public static class AllProducts
    {
        public static List<Product> Products { get; set; }
        
        public static IEnumerable<MiddleAge> ProductsLight { get; private set; }
        public static IEnumerable<NowAge> ProductsMedium { get; private set; }
        public static IEnumerable<FutureAge> ProductsHeavy { get; private set; }

        public static List<Product> GetAllProducts()
        {
            Products = new List<Product>();

            ProductsLight = ProductLight.GetProductsLight();
            ProductsMedium = ProductMedium.GetProductsMedium();
            ProductsHeavy = ProductHeavy.GetProductsHeavy();

            Products.AddRange(ProductsLight);
            Products.AddRange(ProductsMedium);
            Products.AddRange(ProductsHeavy);
            
            return Products;
        }

        public static void UpdateProduct(Product updatedProduct)
        {

            int index = Products.IndexOf(Products.Where(p => p.ProductID == updatedProduct.ProductID).FirstOrDefault());

            Products[index].Name = updatedProduct.Name;
            Products[index].Quanity = updatedProduct.Quanity;
            Products[index].Price = updatedProduct.Price;
            Products[index].Details = updatedProduct.Details;
            Products[index].ImgUrl = updatedProduct.ImgUrl;
            Products[index].ProductType = updatedProduct.ProductType;
            Products[index].ProductCategory = updatedProduct.ProductCategory;
            Products[index].Featured = updatedProduct.Featured;
        }

    }
}
