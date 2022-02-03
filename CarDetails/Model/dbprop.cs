using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarDetails.Model
{
    public class dbprop
    {
        public string CarModel { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public int YearOfModel { get; set; }
        public string Description { get; set; }
    }
}