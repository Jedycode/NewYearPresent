using NewYearPresent.Present.PresentCore;
using NewYearPresent.Present.PresentManagment;
using NewYearPresent.Sweets.CandyCore;
using NewYearPresent.Sweets.CandyType;
using System;


namespace NewYearPresent

{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("HI! New Year is soon. Find out the contents of your gift this year!");
            PresentContainer present = new PresentContainer("gift1");
            Console.WriteLine("Functions:\n\t1 - to show present content\n\t2 - to set sugar range\n\t3 - to close app");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    foreach(var candy in present)
                    {
                        Console.WriteLine(candy);
                    }
                    break;
                case 2:
                    break;
                default:
                    Console.Clear();
                    break;
            }
            Console.ReadKey();
        }
    }
}
