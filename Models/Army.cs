using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebbshoppenSS.Models
{
    public class Army
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Quanity { get; set; }
        public double Price { get; set; }
        public double PriceSek   { get; set; }
        public string Details { get; set; }
        public string ImgUrl { get; set; }
        public ProductType ProductType { get; set; }
        
        

    }
    
    public class MiddleAge : Army
    {

    }

    public class NowAge : Army
    {

    }

    public class FutureAge : Army
    {


    }
}
