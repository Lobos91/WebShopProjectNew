using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebbshoppenSS.Models;

namespace WebbshoppenSS.Data
{
    public static class ProductHeavy
    {
        public static List<FutureAge> ProductsHeavy { get; set; }

        public static List<FutureAge> GetProductsHeavy()
        {
            if (ProductsHeavy == null || !ProductsHeavy.Any()) //if list Charasters is empty
            {
                ProductsHeavy = new List<FutureAge>()
                {
                    new FutureAge()
                    {
                        ProductID = 13,
                        Name = "Future soldier",
                        Price = 3500,
                        ImgUrl ="SoldierHeavy1.jpg",
                        ProductType = ProductType.Infantry,
                        Quanity = 1000,
                        Interplanetary = false,
                        Details = "Light armored infantry soldier. Can be useful as a support for heavier units becouse of its speed.",
                        ProductCategory = new List<string>(){ "Future units"},
                    },
                    new FutureAge()
                    {
                        ProductID = 14,
                        Name = "Elite future warrior",
                        Price = 5000,
                        ImgUrl ="SoldierHeavy2.jpg",
                        ProductType = ProductType.Infantry,
                        Quanity = 1000,
                        Interplanetary = true,
                        Details = "Heavy armored infantry soldier. Highly trained and useful in any combat situation.",
                        ProductCategory = new List<string>(){ "Future units"},
                         Featured = true
                    },
                      new FutureAge()
                    {
                        ProductID = 15,
                        Name = "Elite bio-robot",
                        Price = 8000,
                        ImgUrl ="SoldierHeavy3.jpg",
                        ProductType = ProductType.Infantry,
                        Quanity = 1000,
                        Interplanetary = true,
                        Details = "Elite bio-robot. Intelligent and useful. Can be used to repair spaceship.",
                        ProductCategory = new List<string>(){ "Future units"},
                    },
                   new FutureAge()
                    {
                        ProductID = 16,
                        Name = "AFU-200 One",
                        Price = 15000,
                        ImgUrl ="VehicleHeavy1.jpg",
                        ProductType = ProductType.Vehilce,
                        Quanity = 20000,
                        Interplanetary = true,
                        Details = "Fast vehicle used to traverse varying terrain. Lightweight yet durable.",
                        ProductCategory = new List<string>(){ "Future units"},
                    },
                    new FutureAge()
                    {
                        ProductID = 17,
                        Name = "AFU-200 Two",
                        Price = 30000,
                        ImgUrl ="VehicleHeavy2.jpg",
                        ProductType = ProductType.Vehilce,
                        Quanity = 1000,
                        Interplanetary = false,
                        Details = "Heavy tank. As long as you are on the right side of the barrel, have no fear.",
                        ProductCategory = new List<string>(){ "Future units"},
                    },
                      new FutureAge()
                    {
                        ProductID = 18,
                        Name = "AFU-200 Three",
                        Price = 50000,
                        ImgUrl ="VehicleHeavy3.jpg",
                        ProductType = ProductType.Vehilce,
                        Quanity = 1000,
                        Interplanetary = true,
                        Details = "Travel the stars with style in this luxury space cruiser. Bring your own bombs in the huge storage area on lower deck.",
                        ProductCategory = new List<string>(){ "Future units"},
                    },

                };
            }
            return ProductsHeavy;

        }
    }
}
