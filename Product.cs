using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace WEB_Principles.Models
{
    public class Product
    {
        public string FoodId { get; set; }
        public string FoodType { get; set; }
        public string FoodName { get; set; }
        public List<Product> FoodRecipe { get; set; }
        public int FoodPrice { get; set; }

        public void Show(IDevice device)
        {
            string text = String.Format("");        
        }            
       
    }
    interface IDevice
    {
        void Display(string data);
    }

    class WindowsConsole : IDevice
    {
        public void Display(string text)
        {
            Console.WriteLine(text);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //creating product
            Product product1 = new Product();
            product1.FoodId = "01";
            product1.FoodType = "cake";
            product1.FoodName = "teramisu";
            product1.FoodRecipe = new List<Product>();
            product1.FoodPrice = 3;


            // show result
            IDevice device = new WindowsConsole();
            product1.Show(device);

        }

    }
}
