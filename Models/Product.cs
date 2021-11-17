using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebbshoppenSS.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Quanity { get; set; }
        public double Price { get; set; }
        public double PriceSek   { get; set; }
        public string Details { get; set; }
        public string ImgUrl { get; set; }
        public ProductType ProductType { get; set; }
        public List<string> ProductCategory { get; set; }
        public bool Featured { get; set; }
        public int Amount { get; set; }
      

    }
    
    public class MiddleAge : Product
    {
        public bool HasShield { get; set; }
    }

    public class NowAge : Product
    {
        public bool LandBased { get; set; }
    }


    public class FutureAge : Product
    {
        public bool Interplanetary { get; set; }
    }

}
