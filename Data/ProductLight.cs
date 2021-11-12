using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebbshoppenSS.Models;

namespace WebbshoppenSS.Data
{
    public static class ProductLight
    {
        public static List<MiddleAge> ProductsLight { get; set; }

        public static List<MiddleAge> GetProductsLight ()
        {
            if (ProductsLight == null || !ProductsLight.Any()) //Without that it won't add new product.
            {
                ProductsLight = new List<MiddleAge>()
            {
                new MiddleAge()  // Soldier 1/3 
                {
                    ProductID = 1,
                    Name = "Infantryman",
                    Price = 100,
                    ImgUrl ="SoldierLight1.png",
                    ProductType = ProductType.Infantry,
                    Quanity = 1000,
                    Details = "Light armored begginer level infantry soldier.\\" +
                    "Can be usefull as a support for heavier units becouse of its speed.",

                },
                new MiddleAge()  // Soldier 2/3 
                {
                    ProductID = 2,
                    Name = "Warrior",
                    Price = 250,
                    ImgUrl ="SoldierLight2.png",
                    ProductType = ProductType.Infantry,
                    Quanity = 1000,
                    Details = "Intermidate level soldier.\\" +
                    "Perfect choose for regular battles. ",

                },
                new MiddleAge()  // Soldier 3/3 
                {
                    ProductID = 3,
                    Name = "Knight",
                    Price = 600,
                    ImgUrl ="SoldierLight3.png",
                    ProductType = ProductType.Infantry,
                    Quanity = 1000,
                    Details = "Heavy armored elite Warrior\\" +
                    "Real hero of the battlefields.",
                },
                new MiddleAge() // vehicle 1/3
                {
                    ProductID = 4,
                    Name = "Horse man",
                    Price = 300,
                    ImgUrl = "VehicleLight1.png",
                    ProductType = ProductType.Vehilce,
                    Quanity = 4000,
                    Details = "Regular soldier on battle horse will significantly improve your chances to win.",

                },
                   new MiddleAge() // vehicle 2/3
                {
                    ProductID = 5,
                    Name = "Chariot",
                    Price = 900,
                    ImgUrl = "VehicleLight2.png",
                    ProductType = ProductType.Vehilce,
                    Quanity = 4000,
                    Details = "Fast unit with two soldiers will provide bigger impact against your enemies.",
                },
                     new MiddleAge() // vehicle 3/3
                {
                    ProductID = 6,
                    Name = "Elephant",
                    Price = 2000,
                    ImgUrl = "VehicleLight3.png",
                    ProductType = ProductType.Vehilce,
                    Quanity = 4000,
                    Details = "Giant war animal immune for enemy arrows and bolts. Can transport up to 20 soldiers.",

                }


            };
            }

            return ProductsLight;

        }

    }
}
