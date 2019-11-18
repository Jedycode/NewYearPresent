using System;
using System.Collections.Generic;
using System.Text;
using NewYearPresent.Sweets.CandyCore;
using NewYearPresent.Sweets.CandyType;
using System.Linq;

namespace NewYearPresent.Present.PresentCore
{
    class PresentContainer
    {
        public string name { get; private set; } 
        public List<Candy> presentContent { get; private set; }
        public PresentContainer(string name)
        {
            this.name = name;
            presentContent = new List<Candy>();
            presentContent.Add(new Caramel("Карамель леденцовая «Зубастики» кола-ла", 20, (0.0, 98.0, 0.1), 70));
            presentContent.Add(new Caramel("Карамель леденцовая «Зубастики» фрутти-фру", 20, 0, 97, 0.1,67));
            presentContent.Add(new ChewingGum("Леденая свежесть Orbit", 15, 1, 60, 3,40));
            presentContent.Add(new Sour("Закисни!", 15, 0, 70, 4,50));

        }
        public void sortByWeight()
        {
            var sortedPresent = from candy in presentContent
                                orderby candy.Weight
                                select candy;
            presentContent = sortedPresent.ToList();
        }
        public void sortByFat()
        {
            var sortedPresent = from candy in presentContent
                                orderby candy.Fat
                                select candy;
            presentContent = sortedPresent.ToList();
        }
        public void sortByCarbohydrates()
        {
            var sortedPresent = from candy in presentContent
                                orderby candy.Carbohydrates
                                select candy;
            presentContent = sortedPresent.ToList();
        }
        public void sortByProteins()
        {
            var sortedPresent = from candy in presentContent
                                orderby candy.Proteins
                                select candy;
            presentContent = sortedPresent.ToList();
        }
        


    }
}
