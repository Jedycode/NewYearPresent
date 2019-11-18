using System;
using System.Collections.Generic;
using System.Text;

namespace NewYearPresent.Sweets.CandyCore
{
    class Candy
    {
        public string name { get;private set; }
       
        public double weight { get;private set; }
        
        public double sugarPercentage { get;private set; }
        NutritionalValue nutritionalValue;

        public Candy(string name, double weight,NutritionalValue nutritionalValue, double sugarPercentage)
        {

        }
    }
}
