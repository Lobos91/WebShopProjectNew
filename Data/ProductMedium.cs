using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebbshoppenSS.Models;

namespace WebbshoppenSS.Data
{
    public static class ProductMedium
    {
        public static List<NowAge> ProductsMedium { get; set; }

        public static List<NowAge> GetProductsMedium()
        {
            if (ProductsMedium == null || !ProductsMedium.Any()) //if list Charasters is empty
            {
                ProductsMedium = new List<NowAge>()
                {

                    new NowAge()  // Soldier 1/3 
                    {
                        ProductID = 7,
                        Name = "Marine One",
                        Price = 600,
                        ImgUrl ="SoldierMedium1.jpg",
                        ProductType = ProductType.Infantry,
                        Quanity = 1000,
                        Details = "Light armored begginer level infantry soldier.\\" +
                        "Can be usefull as a support for heavier units becouse of its speed.",
                        ProductCategory = new List<string>(){ "Modern units"},

                    },
                    new NowAge()  // Soldier 2/3 
                    {
                        ProductID = 8,
                        Name = "Marine Two",
                        Price = 1000,
                        ImgUrl ="SoldierMedium2.jpg",
                        ProductType = ProductType.Infantry,
                        Quanity = 1000,
                        Details = "Light armored begginer level infantry soldier.\\" +
                        "Can be usefull as a support for heavier units becouse of its speed.",
                        ProductCategory = new List<string>(){ "Modern units"},

                    },
                    new NowAge()  // Soldier 3/3 
                    {
                        ProductID = 9,
                        Name = "Marine Three",
                        Price = 1250,
                        ImgUrl ="SoldierMedium3.jpg",
                        ProductType = ProductType.Infantry,
                        Quanity = 1000,
                        Details = "Light armored begginer level infantry soldier.\\" +
                        "Can be usefull as a support for heavier units becouse of its speed.",
                        ProductCategory = new List<string>(){ "Modern units"},
    
                    },
                    new NowAge()  // Vehicle 1/3 
                    {
                        ProductID = 10,
                        Name = "Tank",
                        Price = 10000,
                        ImgUrl ="VehicleMedium1.jpg",
                        ProductType = ProductType.Vehilce,
                        Quanity = 1000,
                        Details = "Light armored begginer level infantry soldier.\\" +
                        "Can be usefull as a support for heavier units becouse of its speed.",
                        ProductCategory = new List<string>(){ "Modern units"},
                         Featured = true

                     },
                     new NowAge()  // Vehicle 2/3 
                     {
                        ProductID = 11,
                        Name = "F16 fighter",
                        Price = 18500,
                        ImgUrl ="VehicleMedium2.jpg",
                        ProductType = ProductType.Vehilce,
                        Quanity = 1000,
                        Details = "Light armored begginer level infantry soldier.\\" +
                        "Can be usefull as a support for heavier units becouse of its speed.",
                        ProductCategory = new List<string>(){ "Modern units"},

                     },
                     new NowAge()  // Vehicle 3/3 
                     {
                        ProductID = 12,
                        Name = "Warship Millenium",
                        Price = 18500,
                        ImgUrl ="VehicleMedium3.jpg",
                        ProductType = ProductType.Vehilce,
                        Quanity = 1000,
                        Details = "Light armored begginer level infantry soldier.\\" +
                        "Can be usefull as a support for heavier units becouse of its speed.",
                        ProductCategory = new List<string>(){ "Modern units"},
                     }


                };
            }
            return ProductsMedium;

        }


    }
}
