using System;
using System.Collections.Generic;
using System.Text;

namespace NewYearPresent.Sweets.CandyCore
{
    class Candy
    {
        public string name { get; private set; }
        
        public double proteins { get; private set; }
        
        public double fat { get; private set; }
        
        public double carbohydrates { get; private set; }
        
        public double weight { get; private set; }
        
        public double sugarPercentage { get; private set; }
        
        public Candy(string name, double weight, double proteins, double carbohydrates, double fat, double sugarPercentage)
        {
            this.name = name;
            this.weight = weight;
            this.proteins = proteins;
            this.carbohydrates = carbohydrates;
            this.fat = fat;
            this.sugarPercentage = sugarPercentage;
        }
    }
}
