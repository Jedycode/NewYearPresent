﻿using System;
using System.Collections.Generic;
using System.Text;
using NewYearPresent.Sweets.CandyCore;

namespace NewYearPresent.Sweets.CandyType
{
    class ChewingGum: Candy
    {
        public ChewingGum(string name, double weight, double proteins, double carbohydrates, double fat, double sugarPercentage)
            : base(name, weight, proteins, carbohydrates, fat, sugarPercentage)
        {

        }
    }
}
