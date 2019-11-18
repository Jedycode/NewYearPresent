using System;
using System.Collections.Generic;
using System.Text;
using NewYearPresent.Sweets.CandyCore;

namespace NewYearPresent.Sweets.CandyType
{
    class ChewingGum: Candy
    {
        public ChewingGum(string name, double weight, NutritionalValue nutritionalValue, double sugarPercentage)
            : base(name, weight, nutritionalValue, sugarPercentage)
        {

        }
    }
}
