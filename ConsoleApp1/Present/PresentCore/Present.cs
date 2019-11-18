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
                                orderby candy.weight
                                select candy;
            presentContent = sortedPresent.ToList();
        }
        public void sortByFat()
        {
            var sortedPresent = from candy in presentContent
                                orderby candy.fat
                                select candy;
            presentContent = sortedPresent.ToList();
        }
        public void sortByCarbohydrates()
        {
            var sortedPresent = from candy in presentContent
                                orderby candy.carbohydrates
                                select candy;
            presentContent = sortedPresent.ToList();
        }
        public void sortByProteins()
        {
            var sortedPresent = from candy in presentContent
                                orderby candy.proteins
                                select candy;
            presentContent = sortedPresent.ToList();
        }
        public void SweetsOutput(List<Candy> presentSweets)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Конфеты, содержащиеся в этом подарке:");
            foreach (Candy candy in presentSweets)
            {
                Console.Write($"{candy.name} Вес = {candy.weight}  Жиры = {candy.fat}  Белки = {candy.proteins}  Углеводы = {candy.carbohydrates} Процент сахара = {candy.sugarPercentage} \n");
            }
        }
        public List<Candy> SweetsByDefinedRange(double lowerValue, double upperValue)
        {
            var definedSweets = from candy in presentContent
                                  where candy.sugarPercentage >= lowerValue && candy.sugarPercentage <= upperValue
                                  select candy;

            if (definedSweets == null)
            {
                throw new Exception($"There is no sweets with such sugar percentage");
            }
            return definedSweets.ToList();

        }



    }
}
