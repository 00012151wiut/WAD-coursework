using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WEB_Principles.Models
{

    class Program_work_DRY : Product_SRP
    {
        static void Main(string[] args)
        {
            DoSomething("1", "Coffee", "Cappucino");
            DoSomething("2", "Coffee", "Americano");
            DoSomething("3", "Cake", "Cheese teramisu");
            DoSomething("4", "Cake", "Teramisu");
            Console.ReadLine();
        }
        private static void DoSomething(string foodid, string foodtype, string foodname)
        {
            string FoodId = foodid;
            string FoodType = foodtype;
            string FoodName = foodname;
            Console.WriteLine(FoodId, FoodType, FoodName);
        }
    }
}