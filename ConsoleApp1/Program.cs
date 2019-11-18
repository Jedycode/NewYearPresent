using NewYearPresent.Present.PresentCore;
using NewYearPresent.Sweets.CandyCore;
using NewYearPresent.Sweets.CandyType;
using System.Collections.Generic;
using System;


namespace NewYearPresent

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HI! New Year is soon. Find out the contents of your gift this year!");
            PresentContainer present = new PresentContainer("gift1");
            int choice=0;
            while(choice != 4)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Функции:\n\t1 - показать содержимое подарка" +
                    "\n\t2 - сортировки\n\t3 - указать диапазон сахара\n\t4 - закрыть программу");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        present.SweetsOutput(present.presentContent);
                        break;
                    case 2:
                        Sorts(present);
                        present.SweetsOutput(present.presentContent);
                        break;
                    case 3:
                        FindSweetsBySugarRange(present);
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
            Console.ReadKey();
        }
        public static void Sorts(PresentContainer present)
        {
            Console.WriteLine("Виды сортировок:\n\t1 - сортировка по белкам" +
                    "\n\t2 - сортировка по жирам\n\t3 - сортировка по углеводам");
            int choice1 = Convert.ToInt32(Console.ReadLine());
            switch (choice1)
            {
                case 1:
                    present.sortByProteins();
                    break;
                case 2:
                    present.sortByFat();
                    break;
                case 3:
                    present.sortByCarbohydrates();
                    break;
            }
        }
        public static void FindSweetsBySugarRange(PresentContainer present)
        {
            try
            {
                Console.Write("Введите нижний диапазон сахара:");
                double lowValue = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nВведите верхний диапазон сахара:");
                double upValue = Convert.ToDouble(Console.ReadLine());
                List<Candy> outputList = present.SweetsByDefinedRange(lowValue, upValue);
                present.SweetsOutput(outputList);
            }
            catch
            {
                Console.WriteLine("Исключение");
            }
        }
    }
}
