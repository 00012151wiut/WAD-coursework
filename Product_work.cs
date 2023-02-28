using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_Principles.Models
{
    class Program_work : Product_SRP
    {
        static void Main(string[] args)
        {
            DoSomething();
            DoSomethingAgain();
            DoSomethingMore();
            DoSomethingExtraordinary();
            Console.ReadLine();
        }

        private static void DoSomething()
        {
            string FoodId = "1";
            string FoodType = "Cake";
            string FoodName = "Cheese Teramisu";
            Console.WriteLine(FoodId, FoodType, FoodName);
        }

        private static void DoSomethingAgain()
        {
            string FoodId = "2";
            string FoodType = "Cake";
            string FoodName = "Teramisu";
            Console.WriteLine(FoodId, FoodType, FoodName);
        }

        private static void DoSomethingMore()
        {
            string FoodId = "3";
            string FoodType = "Coffee";
            string FoodName = "Cappucino";
            Console.WriteLine(FoodId, FoodType, FoodName);
        }

        private static void DoSomethingExtraordinary()
        {
            string FoodId = "4";
            string FoodType = "Coffee";
            string FoodName = "Americano";           
            Console.WriteLine(FoodId, FoodType, FoodName);
        }
    }
}
