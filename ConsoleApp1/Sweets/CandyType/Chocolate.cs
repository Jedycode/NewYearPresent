using System;
using System.Collections.Generic;
using System.Text;
using NewYearPresent.Sweets.CandyCore;

namespace NewYearPresent.Sweets.CandyType
{
    class Chocolate: Candy
    {
        public Chocolate(string name, double weight, NutritionalValue nutritionalValue, double sugarPercentage)
            : base(name, weight, nutritionalValue, sugarPercentage)
        {

        }
    }
}
