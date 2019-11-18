using System;
using System.Collections.Generic;
using System.Text;

namespace NewYearPresent.Sweets.CandyCore
{
    class NutritionalValue
    {
        public double proteins { get;private set; }

        public double fat { get;private set; }

        public double carbohydrates { get;private set; }
        public NutritionalValue(double proteins, double fat, double carbohydrates)
        {
            this.proteins = proteins;
            this.fat = fat;
            this.carbohydrates = carbohydrates;
        }
    }
}
