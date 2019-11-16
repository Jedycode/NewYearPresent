using System;
using System.Collections.Generic;
using System.Text;
using NewYearPresent.Sweets.CandyCore;
using NewYearPresent.Present.PresentManagment;
using NewYearPresent.Sweets.CandyType;

namespace NewYearPresent.Present.PresentCore
{
    class PresentContainer
    {
        public Managment managment;
        public string Name { get; private set; } 
        public List<Candy> presentContent { get; private set; }
        public PresentContainer(string name)
        {
            Name = name;
            presentContent = new List<Candy>();
            presentContent.Add(new Caramel("Карамель леденцовая «Зубастики» кола-ла", 20, 0, 98, 0.1, 70));
            presentContent.Add(new Caramel("Карамель леденцовая «Зубастики» фрутти-фру", 20, 0, 97, 0.1,67));
            presentContent.Add(new ChewingGum("Леденая свежесть Orbit", 15, 1, 60, 3,40));
            presentContent.Add(new Sour("Закисни!", 15, 0, 70, 4,50));

        }
        public void sortByWeight()
        {
            var sortedPresent = from candy in presentContent
                                orderby candy.Fat
                                select candy;
        }
        public void sortByFat()
        {

        }
        public void sortByCarbohydrates()
        {

        }
        public void sortByProteins()
        {

        }
        


    }
}
