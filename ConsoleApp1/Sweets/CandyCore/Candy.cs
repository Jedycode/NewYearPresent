using System;
using System.Collections.Generic;
using System.Text;

namespace NewYearPresent.Sweets.CandyCore
{
    class Candy
    {
        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double proteins;
        public double Proteins
        {
            get { return proteins; }
            set { proteins = value; }
        }
        private double fat;
        public double Fat
        {
            get { return fat; }
            set { fat = value; }
        }
        private double carbohydrates;
        public double Carbohydrates
        {
            get { return carbohydrates; }
            set { carbohydrates = value; }
        }
        private double weight;
        public double Weight
        {
            get { return carbohydrates; }
            set { carbohydrates = value; }
        }
        private double sugarPercentage;
        public double SugarPercentage
        {
            get { return sugarPercentage; }
            set { sugarPercentage = value; }
        }
        public Candy(string name, double weight, double proteins, double carbohydrates, double fat, double sugarPercentage)
        {

        }
    }
}
